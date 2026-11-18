import { useState } from "react";
import type { Actions } from "../App";
import { api, type Overview } from "../api";
import { Icons } from "../components/Icons";
import { IconTile, KindTile, ViewHeader, plural } from "../components/ui";

export default function BackupsView({ overview, actions }: { overview: Overview; actions: Actions }) {
  const [confirming, setConfirming] = useState(false);
  const replacing = overview.mods.filter((m) => m.enabled && (m.kind === "replacer" || m.kind === "asiPlugin"));
  const enabled = overview.mods.filter((m) => m.enabled).length;

  return (
    <>
      <ViewHeader
        icon={<Icons.Shield />}
        title="Backups"
        subtitle={`${plural(overview.backedUp, "game file")} backed up while mods replace them`}
      >
        <button type="button" className="btn" onClick={() => actions.attempt(api.openFolder("backups"), "Opened the backups folder")}>
          <Icons.Folder />
          Open backups
        </button>
      </ViewHeader>

      <section className="nv-card flex flex-none items-start gap-3.5 p-[18px]">
        <IconTile theme="cyan">
          <Icons.Info />
        </IconTile>
        <div className="flex-1 text-[12.5px] leading-relaxed text-[var(--text-secondary)]">
          <p className="m-0">
            When a mod replaces one of the game's own files, the original is moved to{" "}
            <span className="font-mono text-[11.5px] text-[var(--text-primary)]">BmSDK Manager Backups</span> in the game
            folder. Turning the mod off puts it back.
          </p>
          <p className="m-0 mt-2">
            If two mods change the same file, the one turned on last wins. Turning it off brings back the other mod's
            copy, then the game's.
          </p>
        </div>
      </section>

      <section className="nv-card flex min-h-0 flex-1 flex-col gap-2 p-[18px]">
        <p className="m-0 font-display text-[13px] font-bold">Mods replacing game files</p>
        <div className="flex min-h-0 flex-1 flex-col gap-1 overflow-y-auto">
          {replacing.length === 0 && (
            <p className="m-0 text-[12.5px] text-[var(--text-muted)]">No replacers are on right now.</p>
          )}
          {replacing.map((m) => (
            <div key={m.id} className="flex items-center gap-3 py-1.5">
              <KindTile kind={m.kind} size={30} />
              <p className="m-0 min-w-0 flex-1 truncate text-[13px] font-semibold">{m.name}</p>
              <span className="font-mono text-[11px] text-[var(--text-muted)]">{m.location}</span>
            </div>
          ))}
        </div>
      </section>

      <section className="nv-card flex flex-none items-center gap-3.5 border-[rgba(237,86,108,.2)] p-[18px]">
        <IconTile theme="rose">
          <Icons.Refresh />
        </IconTile>
        <div className="flex-1">
          <p className="m-0 font-display text-[13px] font-bold">Back to a clean game</p>
          <p className="m-0 mt-0.5 text-[12px] text-[var(--text-muted)]">
            Turns every mod off and puts all backed up files back. Mods stay in your library.
          </p>
        </div>
        <button
          type="button"
          className="btn btn-danger"
          disabled={enabled === 0 || !!actions.busy}
          onClick={() => {
            if (!confirming) {
              setConfirming(true);
              return;
            }
            setConfirming(false);
            void actions.run("Turning every mod off", () => api.disableAll(), "Every mod is off and the game's files are back.");
          }}
        >
          {confirming ? `Turn off ${plural(enabled, "mod")}?` : "Turn everything off"}
        </button>
      </section>
    </>
  );
}
