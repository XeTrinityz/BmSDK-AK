import { useState } from "react";
import type { Actions } from "../App";
import { api, type Review } from "../api";
import { Icons } from "../components/Icons";
import { IconTile, KindBadge, formatBytes, plural } from "../components/ui";

export default function ReviewDialog({
  reviews,
  onClose,
  actions,
}: {
  reviews: Review[];
  onClose: () => void;
  actions: Actions;
}) {
  const [chosen, setChosen] = useState<Record<string, Set<number>>>(() =>
    Object.fromEntries(reviews.map((r) => [r.id, new Set(r.mods.filter((m) => m.supported).map((m) => m.index))])),
  );

  const total = Object.values(chosen).reduce((n, s) => n + s.size, 0);
  const found = reviews.reduce((n, r) => n + r.mods.length, 0);
  const anyBackups = reviews.some((r) => r.mods.some((m) => chosen[r.id].has(m.index) && m.backsUp > 0));

  const toggle = (id: string, index: number) =>
    setChosen((c) => {
      const next = new Set(c[id]);
      if (next.has(index)) next.delete(index);
      else next.add(index);
      return { ...c, [id]: next };
    });

  const cancel = () => {
    reviews.forEach((r) => void api.discardReview(r.id));
    onClose();
  };

  const install = async () => {
    onClose();
    for (const r of reviews) {
      const indices = [...chosen[r.id]];
      if (indices.length === 0) {
        void api.discardReview(r.id);
        continue;
      }
      await actions.run(`Installing from ${r.source}`, () => api.installReview(r.id, indices), `Installed ${plural(indices.length, "mod")} from ${r.source}.`);
    }
  };

  const title = found === 0 ? "No mods found" : `Found ${plural(found, "mod")}`;

  return (
    <div className="overlay">
      <section role="dialog" aria-labelledby="review-title" className="dialog">
        <div className="flex items-center gap-3.5">
          <IconTile theme="blue" size={44} radius={14}>
            <Icons.Archive />
          </IconTile>
          <div className="min-w-0 flex-1">
            <h2 id="review-title" className="m-0 text-[18px] font-bold">
              {title}
            </h2>
            <p className="m-0 mt-0.5 truncate font-mono text-[11.5px] text-[var(--text-muted)]">
              {reviews.map((r) => `${r.source} · ${formatBytes(r.size)}`).join(", ")}
            </p>
          </div>
        </div>

        <div className="flex min-h-0 flex-col gap-2 overflow-y-auto pr-1">
          {found === 0 && (
            <p className="m-0 text-[13px] leading-relaxed text-[var(--text-secondary)]">
              Nothing in here looks like an Arkham Knight mod the manager knows how to install. Check the mod's readme for
              how it should be installed.
            </p>
          )}
          {reviews.flatMap((r) =>
            r.mods.map((m) => {
              const checked = chosen[r.id].has(m.index);
              const warn = m.supported && (m.sharesWith.length > 0 || m.versionChange === "older" || (m.replaces && !m.versionChange));
              return (
                <label
                  key={`${r.id}-${m.index}`}
                  className="flex gap-3.5 rounded-[14px] border p-3.5"
                  style={{
                    opacity: m.supported ? 1 : 0.7,
                    borderColor: warn ? "rgba(237,180,86,.28)" : "rgba(255,255,255,.06)",
                    background: warn ? "rgba(237,180,86,.05)" : "rgba(255,255,255,.03)",
                    cursor: m.supported ? "pointer" : "default",
                  }}
                >
                  <input
                    type="checkbox"
                    className="mt-0.5 h-5 w-5 flex-none accent-[#3b9eff]"
                    checked={checked}
                    disabled={!m.supported}
                    onChange={() => toggle(r.id, m.index)}
                  />
                  <div className="min-w-0 flex-1">
                    <div className="flex items-center gap-2">
                      <p className="m-0 flex-1 truncate text-[13.5px] font-bold">{m.name}</p>
                      <KindBadge kind={m.kind} />
                    </div>
                    {m.supported && m.targets.length > 0 && (
                      <p className="m-0 mt-1.5 truncate font-mono text-[11px] text-[#9fb1cc]">
                        → {m.targets.slice(0, 3).join("  +  ")}
                        {m.targets.length > 3 ? `  +  ${m.targets.length - 3} more` : ""}
                      </p>
                    )}
                    <p className="m-0 mt-1.5 text-[12px] leading-normal text-[var(--text-muted)]">
                      {m.description}
                      {m.replaces &&
                        (m.version && m.installedVersion
                          ? m.versionChange === "newer"
                            ? ` Updates the ${m.replaces} you have, v${m.installedVersion} to v${m.version}.`
                            : m.versionChange === "older"
                              ? ` Older than the ${m.replaces} you have, v${m.version} against v${m.installedVersion}. Installing it downgrades.`
                              : ` Same version as the ${m.replaces} you have, v${m.version}. Installing it reinstalls.`
                          : ` Replaces the ${m.replaces} you have now.`)}
                      {!m.replaces && m.version && ` Version ${m.version}.`}
                      {m.sharesWith.length > 0 && ` Also changes files from ${m.sharesWith.join(", ")}. This one wins.`}
                      {m.backsUp > 0 && ` ${plural(m.backsUp, "game file")} will be backed up first.`}
                    </p>
                  </div>
                </label>
              );
            }),
          )}
        </div>

        {anyBackups && (
          <div className="flex items-center gap-2.5 rounded-xl border border-[rgba(52,197,224,.18)] bg-[rgba(52,197,224,.07)] px-3 py-2.5 text-[12px] text-[#8fe6f4] [&_svg]:h-4 [&_svg]:w-4 [&_svg]:flex-none">
            <Icons.Shield />
            Game files a mod replaces are backed up first and put back when you turn it off.
          </div>
        )}

        <div className="flex justify-end gap-2.5">
          <button type="button" className="btn h-[38px]" onClick={cancel}>
            {total === 0 ? "Close" : "Cancel"}
          </button>
          {total > 0 && (
            <button type="button" className="btn btn-primary h-[38px] px-4" onClick={() => void install()}>
              Install {plural(total, "mod")}
            </button>
          )}
        </div>
      </section>
    </div>
  );
}
