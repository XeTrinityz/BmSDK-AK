import { useEffect, useState } from "react";
import { open, save } from "@tauri-apps/plugin-dialog";
import type { Actions } from "../App";
import { api, type GameInstall, type Overview } from "../api";
import { Icons } from "../components/Icons";
import { IconTile, Toggle, ViewHeader, formatBytes, plural } from "../components/ui";

export default function SettingsView({ overview, actions }: { overview: Overview; actions: Actions }) {
  const [installs, setInstalls] = useState<GameInstall[]>([]);
  const game = overview.game!;
  const [librarySize, setLibrarySize] = useState<number | null>(null);
  const biggest = [...overview.mods].filter((m) => m.size > 0).sort((a, b) => b.size - a.size).slice(0, 4);

  useEffect(() => {
    void api.detectGames().then(setInstalls);
  }, []);

  useEffect(() => {
    void api.librarySize().then(setLibrarySize);
  }, [overview.mods.length]);

  const exportList = async () => {
    const path = await save({
      title: "Save your mod list",
      defaultPath: "BmSDK mod list.json",
      filters: [{ name: "Mod list", extensions: ["json"] }],
    });
    if (path) actions.attempt(api.exportList(path), "Saved your mod list");
  };

  const importList = async () => {
    const path = await open({ title: "Choose a mod list", filters: [{ name: "Mod list", extensions: ["json"] }] });
    if (typeof path !== "string") return;
    await actions.run("Applying the mod list", async () => {
      const r = await api.importList(path);
      const missing =
        r.missing.length > 0
          ? ` ${r.missing.length} aren't in your library: ${r.missing.slice(0, 3).join(", ")}${r.missing.length > 3 ? " and more" : ""}.`
          : "";
      actions.toast(`Turned on ${r.turnedOn} and off ${r.turnedOff}.${missing}`, "info");
    });
  };

  const useFolder = (path: string) =>
    actions.run("Switching game folder", async () => {
      const found = await api.setGameDir(path);
      actions.toast(found > 0 ? `Using that folder. Found ${plural(found, "mod")} in it.` : "Using that folder.", "success");
    });

  const browse = async () => {
    const picked = await open({ directory: true, title: "Choose your Batman: Arkham Knight folder" });
    if (typeof picked === "string") await useFolder(picked);
  };

  const others = installs.filter((i) => i.path.toLowerCase() !== game.path.toLowerCase());

  return (
    <>
      <ViewHeader icon={<Icons.Settings />} title="Settings" subtitle="Game folder, updates and where things are kept" />

      <section className="nv-card flex flex-none flex-col gap-3 p-[18px]">
        <Heading icon={<Icons.Gamepad />} title="Game folder" theme="purple" />
        <p className="path-box m-0">{game.path}</p>
        {others.map((i) => (
          <div key={i.path} className="flex items-center gap-3">
            <p className="m-0 min-w-0 flex-1 truncate font-mono text-[11.5px] text-[var(--text-muted)]">{i.path}</p>
            <span className="pill">{i.source}</span>
            <button type="button" className="btn btn-sm" disabled={!!actions.busy} onClick={() => void useFolder(i.path)}>
              Use this one
            </button>
          </div>
        ))}
        <div className="flex gap-2">
          <button type="button" className="btn" disabled={!!actions.busy} onClick={() => void browse()}>
            Choose another folder
          </button>
          <button
            type="button"
            className="btn"
            disabled={!!actions.busy}
            onClick={() =>
              void actions.run("Looking for mods", async () => {
                const found = await api.rescanGame();
                actions.toast(found > 0 ? `Found ${plural(found, "new mod")}.` : "No new mods in the game folder.", "info");
              })
            }
          >
            Look for mods in the game
          </button>
        </div>
        {others.length > 0 && (
          <p className="m-0 text-[11.5px] text-[var(--text-muted)]">
            Switching folders leaves the mods that are on in the old one. Mods that are off can go in the new one.
          </p>
        )}
      </section>

      <section className="nv-card flex flex-none flex-col gap-3 p-[18px]">
        <Heading icon={<Icons.Download />} title="Updates" theme="blue" />
        <div className="flex items-center gap-3">
          <div className="flex-1">
            <p className="m-0 text-[13px] font-semibold">Check for updates when the manager opens</p>
            <p className="m-0 mt-0.5 text-[12px] text-[var(--text-muted)]">
              Looks at the latest release on github.com/{overview.repo} for new BmSDK and manager versions.
            </p>
          </div>
          <Toggle
            checked={overview.checkOnStart}
            label="Check for updates on start"
            onChange={(v) => void api.setCheckOnStart(v).then(actions.refresh)}
          />
        </div>
      </section>

      <section className="nv-card flex flex-none flex-col gap-3 p-[18px]">
        <Heading icon={<Icons.Box />} title="Mod library" theme="emerald" />
        <p className="m-0 text-[12px] text-[var(--text-muted)]">
          A copy of every mod you add is kept here, so turning one off and on again doesn't need the download.
          {librarySize !== null && ` It's using ${formatBytes(librarySize)} on disk.`}
        </p>
        <div className="flex items-center gap-2.5">
          <p className="path-box m-0 min-w-0 flex-1">{overview.libraryDir}</p>
          <button type="button" className="btn flex-none" onClick={() => actions.attempt(api.openFolder("library"), "Opened the mod library")}>
            <Icons.Folder />
            Open library
          </button>
        </div>
        {biggest.length > 0 && (
          <div className="flex flex-col gap-1.5">
            <p className="label m-0">Biggest mods</p>
            {biggest.map((m) => (
              <div key={m.id} className="flex items-center gap-3 text-[12px]">
                <span className="w-[200px] flex-none truncate font-semibold text-[var(--text-secondary)]">{m.name}</span>
                <div className="progress-track h-1.5 min-w-0 flex-1">
                  <div className="h-full rounded-full bg-[#46d39a]" style={{ width: `${Math.max(2, (m.size / biggest[0].size) * 100)}%` }} />
                </div>
                <span className="w-[70px] flex-none text-right font-mono text-[11px] text-[var(--text-muted)]">{formatBytes(m.size)}</span>
              </div>
            ))}
          </div>
        )}
      </section>

      <section className="nv-card flex flex-none flex-col gap-3 p-[18px]">
        <Heading icon={<Icons.Upload />} title="Share your setup" theme="blue" />
        <div className="flex items-center gap-3">
          <p className="m-0 min-w-0 flex-1 text-[12px] leading-relaxed text-[var(--text-muted)]">
            Save the list of your mods as a small file to send to a friend. When they import it, the mods they already have
            are turned on to match. The list holds no mod files, so they still need to get any they're missing.
          </p>
          <button type="button" className="btn flex-none" disabled={!!actions.busy} onClick={() => void exportList()}>
            Export list
          </button>
          <button type="button" className="btn flex-none" disabled={!!actions.busy} onClick={() => void importList()}>
            Import list
          </button>
        </div>
      </section>

      <div className="min-h-0 flex-1" />
      <p className="m-0 flex-none text-[11.5px] text-[var(--text-muted)]">
        BmSDK Manager {overview.managerVersion} ·{" "}
        <button type="button" className="text-[#9ad0ff] hover:text-[#c7e4ff]" onClick={() => actions.attempt(api.openUrl(`https://github.com/${overview.repo}`), "Opened GitHub in your browser")}>
          github.com/{overview.repo}
        </button>
      </p>
    </>
  );
}

function Heading({ icon, title, theme }: { icon: JSX.Element; title: string; theme: "purple" | "blue" | "emerald" }) {
  return (
    <div className="flex items-center gap-3">
      <IconTile theme={theme} size={30} radius={10}>
        {icon}
      </IconTile>
      <p className="m-0 font-display text-[13px] font-bold">{title}</p>
    </div>
  );
}
