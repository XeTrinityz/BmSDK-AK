import { useEffect, useState } from "react";
import { open } from "@tauri-apps/plugin-dialog";
import type { Actions } from "../App";
import { api, type GameFileFindings, type GameInstall, type Overview, type Updates } from "../api";
import { Icons } from "../components/Icons";
import { IconTile, SpinIcon, Toggle, ViewHeader, formatBytes, plural } from "../components/ui";

export default function SettingsView({
  overview,
  actions,
  updates,
  checking,
  updateError,
}: {
  overview: Overview;
  actions: Actions;
  updates: Updates | null;
  checking: boolean;
  updateError: string | null;
}) {
  const [installs, setInstalls] = useState<GameInstall[]>([]);
  const game = overview.game!;
  const [librarySize, setLibrarySize] = useState<number | null>(null);
  const [findings, setFindings] = useState<GameFileFindings | null>(null);
  const [confirmRecycle, setConfirmRecycle] = useState(false);
  const biggest = [...overview.mods].filter((m) => m.size > 0).sort((a, b) => b.size - a.size).slice(0, 4);

  useEffect(() => {
    void api.detectGames().then(setInstalls);
  }, []);

  useEffect(() => {
    void api.librarySize().then(setLibrarySize);
  }, [overview.mods.length]);

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
        <div className="flex items-center gap-3 border-t border-[var(--border-default)] pt-3">
          <div className="min-w-0 flex-1 text-[12px] leading-relaxed text-[var(--text-secondary)]">
            <p className="m-0">
              Manager {overview.managerVersion}
              {updates?.managerUpdate ? (
                <span className="font-semibold text-[#9ad0ff]"> · {updates.latest} is ready</span>
              ) : updates ? (
                <span className="text-[#7fe9c0]"> · up to date</span>
              ) : null}
            </p>
            <p className="m-0">
              BmSDK {game.sdkVersion ?? "not installed"}
              {updates?.sdkUpdate ? (
                <span className="font-semibold text-[#9ad0ff]"> · {updates.latest} is ready</span>
              ) : updates && game.sdkVersion ? (
                <span className="text-[#7fe9c0]"> · up to date</span>
              ) : null}
            </p>
            {updateError && <p className="m-0 text-[#f4cf8e]">{updateError}</p>}
          </div>
          <button type="button" className="btn flex-none" disabled={checking || !!actions.busy} onClick={() => void actions.checkUpdates()}>
            <SpinIcon active={checking} />
            Check now
          </button>
          {updates?.managerUpdate && (
            <button
              type="button"
              className="btn btn-primary flex-none"
              disabled={!!actions.busy}
              onClick={() => void actions.run("Updating the manager", api.updateManager)}
            >
              {actions.busy === "Updating the manager" ? "Updating…" : "Update and restart"}
            </button>
          )}
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
        <Heading icon={<Icons.Shield />} title="Game files" theme="purple" />
        <p className="m-0 text-[12px] leading-relaxed text-[var(--text-muted)]">
          Compares your game with the list of files Steam installs, so you can see which ones something else changed or
          added. Files from mods you installed here are left out. It only works on Steam copies.
        </p>
        <div className="flex items-center gap-2.5">
          <button
            type="button"
            className="btn"
            disabled={!!actions.busy}
            onClick={() =>
              void actions.run("Checking the game files", async () => {
                setFindings(await api.checkGameFiles());
              })
            }
          >
            Check game files
          </button>
        </div>
        {findings && (
          <div className="flex flex-col gap-2.5">
            {!findings.sameBuild && (
              <p className="m-0 text-[12px] text-[#f4cf8e]">
                Your Steam build or language differs from the list, so some files may show up that are fine.
              </p>
            )}
            {findings.changed.length + findings.missing.length + findings.added.length === 0 && (
              <p className="m-0 text-[12px] text-[#7fe9c0]">Every game file matches Steam's.</p>
            )}
            {(
              [
                ["Changed", findings.changed, "Differ from Steam's. A mod, or a setting the game saved."],
                ["Missing", findings.missing, "Steam installs these, and they aren't there."],
                ["Added", findings.added, "Not from Steam, and not from a mod you installed here."],
              ] as const
            ).map(
              ([title, list, note]) =>
                list.length > 0 && (
                  <div key={title} className="flex flex-col gap-1">
                    <p className="label m-0">
                      {title} ({list.length}) <span className="normal-case tracking-normal opacity-70">{note}</span>
                    </p>
                    <div className="path-box m-0 max-h-[160px] overflow-y-auto">
                      {list.map((f) => (
                        <span key={f} className="block truncate leading-[1.6]">
                          {f}
                        </span>
                      ))}
                    </div>
                  </div>
                ),
            )}
            {findings.added.length > 0 && (
              <div className="flex items-center gap-2.5">
                <button
                  type="button"
                  className={`btn ${confirmRecycle ? "btn-primary" : ""}`}
                  disabled={!!actions.busy || game.running}
                  onBlur={() => setConfirmRecycle(false)}
                  onClick={async () => {
                    if (!confirmRecycle) return setConfirmRecycle(true);
                    setConfirmRecycle(false);
                    await actions.run("Recycling added files", async () => {
                      const n = await api.recycleAdded(findings.added);
                      actions.toast(`Moved ${plural(n, "file")} to the Recycle Bin.`, "success");
                      setFindings(await api.checkGameFiles());
                    });
                  }}
                >
                  {confirmRecycle ? `Recycle ${plural(findings.added.length, "file")}` : "Recycle added files"}
                </button>
                <p className="m-0 text-[11.5px] text-[var(--text-muted)]">They go to the Recycle Bin, so you can get them back.</p>
              </div>
            )}
            {findings.changed.length > 0 && (
              <p className="m-0 text-[11.5px] text-[var(--text-muted)]">
                Verify game files in Steam on the Home page puts changed and missing files back.
              </p>
            )}
          </div>
        )}
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
