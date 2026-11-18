import { useCallback, useEffect, useMemo, useRef, useState } from "react";
import type { Actions } from "../App";
import { copyDiagnostics } from "../diagnostics";
import { api, errorText, type LogSource, type LogText, type ModView } from "../api";
import { Icons } from "../components/Icons";
import { IconTile, Select, SpinIcon, ViewHeader, formatBytes, formatTime, plural, type Theme } from "../components/ui";

type Level = "error" | "warn" | "perf" | "info";
type LevelFilter = "all" | "warn" | "error";

const GROUPS: { id: LogSource["group"]; title: string; theme: Theme; icon: () => JSX.Element }[] = [
  { id: "sdk", title: "BmSDK", theme: "blue", icon: Icons.Code },
  { id: "mod", title: "Mods", theme: "purple", icon: Icons.Box },
  { id: "crash", title: "Game crash reports", theme: "rose", icon: Icons.Alert },
];

const LEVEL_STYLE: Record<Level, { bar: string; text: string }> = {
  error: { bar: "#ff7a8c", text: "#ffc2ca" },
  warn: { bar: "#edb456", text: "#f4cf8e" },
  perf: { bar: "transparent", text: "#7f93b3" },
  info: { bar: "transparent", text: "#c2d2ea" },
};

const MAX_LINES = 3000;
const MAX_READ_LABEL = "2 MB";

function levelOf(line: string): Level {
  if (/\b(error|exception|failed|fatal|crash(ed)?)\b/i.test(line)) return "error";
  if (/\bwarn(ing)?\b/i.test(line)) return "warn";
  if (/^slow frame/i.test(line)) return "perf";
  return "info";
}

/** Words a mod's log lines carry: its name and its folder, which BmSDK uses as the line's sender or tag. */
function modKeys(m: ModView): string[] {
  const folder = m.location.split("\\").pop() ?? "";
  return [...new Set([m.name, folder].filter((k) => k.length > 1).map((k) => k.toLowerCase()))];
}

export default function LogsView({
  actions,
  mods,
  initialMod,
}: {
  actions: Actions;
  mods: ModView[];
  initialMod: string | null;
}) {
  const [modFilter, setModFilter] = useState<string | null>(initialMod);
  useEffect(() => setModFilter(initialMod), [initialMod]);
  const [sources, setSources] = useState<LogSource[] | null>(null);
  const [selected, setSelected] = useState<string | null>(null);
  const [log, setLog] = useState<LogText | null>(null);
  const [error, setError] = useState<string | null>(null);
  const [level, setLevel] = useState<LevelFilter>("all");
  const [search, setSearch] = useState("");
  const [follow, setFollow] = useState(false);
  const [copied, setCopied] = useState(false);
  const [refreshing, setRefreshing] = useState(false);
  const [confirmClear, setConfirmClear] = useState(false);

  // An armed confirm lapses after a few seconds so a later click can't delete by accident
  useEffect(() => {
    if (!confirmClear) return;
    const t = setTimeout(() => setConfirmClear(false), 4000);
    return () => clearTimeout(t);
  }, [confirmClear]);
  const scroller = useRef<HTMLDivElement>(null);
  const stickToEnd = useRef(true);

  const loadSources = useCallback(async () => {
    try {
      const list = await api.listLogs();
      setSources(list);
      setSelected((cur) => (cur && list.some((s) => s.path === cur) ? cur : (list[0]?.path ?? null)));
    } catch (e) {
      setError(errorText(e));
      setSources([]);
    }
  }, []);

  const loadLog = useCallback(async (path: string) => {
    try {
      setLog(await api.readLog(path));
      setError(null);
    } catch (e) {
      setError(errorText(e));
      setLog(null);
    }
  }, []);

  useEffect(() => {
    void loadSources();
  }, [loadSources]);

  useEffect(() => {
    if (!selected) {
      setLog(null);
      return;
    }
    stickToEnd.current = true;
    void loadLog(selected);
  }, [selected, loadLog]);

  // Live view: re-read the log every couple of seconds while the game runs
  useEffect(() => {
    if (!follow || !selected) return;
    const t = setInterval(() => void loadLog(selected), 2000);
    return () => clearInterval(t);
  }, [follow, selected, loadLog]);

  const lines = useMemo(() => {
    if (!log) return [];
    const all = log.text.split("\n");
    if (all[all.length - 1] === "") all.pop();
    return all.map((text, i) => ({ n: i + 1, text, level: levelOf(text) }));
  }, [log]);

  const counts = useMemo(
    () => ({
      error: lines.filter((l) => l.level === "error").length,
      warn: lines.filter((l) => l.level === "warn").length,
    }),
    [lines],
  );

  const isSdkLog = sources?.find((s) => s.path === selected)?.group === "sdk";
  const scriptMods = useMemo(
    () => mods.filter((m) => m.kind === "scriptMod" || m.kind === "prebuiltDll" || m.kind === "looseScripts"),
    [mods],
  );

  const shown = useMemo(() => {
    const q = search.trim().toLowerCase();
    const mod = isSdkLog && modFilter ? mods.find((m) => m.name === modFilter) : undefined;
    const keys = mod ? modKeys(mod) : [];
    return lines.filter((l) => {
      const text = l.text.toLowerCase();
      return (
        (level === "all" || (level === "error" ? l.level === "error" : l.level === "error" || l.level === "warn")) &&
        (!q || text.includes(q)) &&
        (keys.length === 0 || keys.some((k) => text.includes(k)))
      );
    });
  }, [lines, level, search, isSdkLog, modFilter, mods]);
  const visible = shown.length > MAX_LINES ? shown.slice(-MAX_LINES) : shown;

  // Newest lines are at the bottom, so open there unless the reader scrolled up
  useEffect(() => {
    const el = scroller.current;
    if (el && stickToEnd.current) el.scrollTop = el.scrollHeight;
  }, [visible, selected]);

  const copy = async () => {
    try {
      await navigator.clipboard.writeText(shown.map((l) => l.text).join("\n"));
      setCopied(true);
      setTimeout(() => setCopied(false), 1500);
    } catch {
      actions.toast("Couldn't copy. Try Show in folder instead.", "error");
    }
  };

  const current = sources?.find((s) => s.path === selected) ?? null;

  return (
    <>
      <ViewHeader
        icon={<Icons.Logs />}
        title="Logs"
        subtitle="BmSDK, mod and crash logs in one place, for finding out what went wrong"
      >
        <button
          type="button"
          className="btn"
          onClick={() => {
            setRefreshing(true);
            void loadSources()
              .then(() => (selected ? loadLog(selected) : undefined))
              .finally(() => setRefreshing(false));
          }}
        >
          <SpinIcon active={refreshing} />
          Refresh
        </button>
        <button type="button" className="btn" onClick={() => void copyDiagnostics(actions)} title="Copies your setup, the mods that are on and the latest log lines, ready to paste into a bug report">
          Copy diagnostics
        </button>
        <button
          type="button"
          className="btn btn-danger"
          disabled={!sources || sources.length === 0}
          onClick={() => {
            if (!confirmClear) {
              setConfirmClear(true);
              return;
            }
            setConfirmClear(false);
            void api.clearLogs().then(
              (r) => {
                actions.toast(
                  r.failed > 0
                    ? `Cleared ${plural(r.deleted, "log")}. ${r.failed} couldn't be removed, probably because the game is running.`
                    : `Cleared ${plural(r.deleted, "log")}.`,
                  r.failed > 0 ? "error" : "success",
                );
                setLog(null);
                void loadSources();
              },
              (e) => actions.toast(errorText(e), "error"),
            );
          }}
        >
          <Icons.Trash />
          {confirmClear ? `Delete ${plural(sources?.length ?? 0, "log")}?` : "Clear logs"}
        </button>
      </ViewHeader>

      <div className="flex min-h-0 flex-1 gap-4">
        <aside className="nv-card flex w-[270px] flex-none flex-col gap-1 overflow-y-auto p-2.5" aria-label="Log files">
          {sources === null && <p className="m-3 text-[12px] text-[var(--text-muted)]">Looking for logs…</p>}
          {sources?.length === 0 && (
            <p className="m-3 text-[12px] leading-relaxed text-[var(--text-muted)]">
              No logs yet. BmSDK writes one the first time the game starts with it installed.
            </p>
          )}
          {GROUPS.map((g) => {
            const items = sources?.filter((s) => s.group === g.id) ?? [];
            if (items.length === 0) return null;
            return (
              <div key={g.id} className="mb-1.5 flex flex-col gap-0.5">
                <div className="flex items-center gap-2 px-2 pb-1 pt-1.5">
                  <IconTile theme={g.theme} size={20} radius={7} iconSize={11}>
                    <g.icon />
                  </IconTile>
                  <span className="label">{g.title}</span>
                </div>
                {items.map((s) => (
                  <button
                    key={s.path}
                    type="button"
                    className="mod-row !gap-2 !px-2.5 !py-2"
                    aria-selected={s.path === selected}
                    onClick={() => setSelected(s.path)}
                  >
                    <div className="min-w-0 flex-1">
                      <p className="m-0 truncate text-[12.5px] font-semibold" title={s.title}>
                        {s.title}
                      </p>
                      <p className="m-0 mt-0.5 font-mono text-[10.5px] text-[var(--text-muted)]">
                        {formatBytes(s.size)} · {formatTime(s.modified)}
                      </p>
                    </div>
                  </button>
                ))}
              </div>
            );
          })}
        </aside>

        <section className="nv-card flex min-w-0 flex-1 flex-col gap-3 p-4">
          {!current ? (
            <p className="m-auto text-[12.5px] text-[var(--text-muted)]">Pick a log on the left.</p>
          ) : (
            <>
              <div className="flex flex-none flex-wrap items-center gap-2">
                <div className="flex gap-1.5">
                  <button type="button" className="chip" aria-pressed={level === "all"} onClick={() => setLevel("all")}>
                    All <span className="count">{lines.length}</span>
                  </button>
                  <button type="button" className="chip" aria-pressed={level === "warn"} onClick={() => setLevel("warn")}>
                    Warnings and errors <span className="count">{counts.warn + counts.error}</span>
                  </button>
                  <button type="button" className="chip" aria-pressed={level === "error"} onClick={() => setLevel("error")}>
                    Errors <span className="count">{counts.error}</span>
                  </button>
                </div>
                <div className="flex-1" />
                {isSdkLog && scriptMods.length > 0 && (
                  <Select
                    label="Only show lines from one mod"
                    className="w-[170px]"
                    value={modFilter ?? ""}
                    onChange={(v) => setModFilter(v || null)}
                    options={[{ value: "", label: "Every mod" }, ...scriptMods.map((m) => ({ value: m.name, label: m.name }))]}
                  />
                )}
                <label className="flex h-8 w-[180px] items-center gap-2 rounded-[11px] border border-[rgba(255,255,255,.07)] bg-[var(--bg-input)] px-3 text-[var(--text-muted)] [&_svg]:h-3.5 [&_svg]:w-3.5">
                  <Icons.Search />
                  <input
                    value={search}
                    onChange={(e) => setSearch(e.target.value)}
                    placeholder="Search this log"
                    aria-label="Search this log"
                    className="min-w-0 flex-1 border-0 bg-transparent text-[12px] font-medium text-[var(--text-primary)] outline-none"
                  />
                </label>
              </div>

              <div
                ref={scroller}
                className="min-h-0 flex-1 overflow-auto rounded-xl border border-[var(--border-default)] bg-[var(--bg-input)] py-2 font-mono text-[11.5px] leading-[1.6] [user-select:text]"
                onScroll={(e) => {
                  const el = e.currentTarget;
                  stickToEnd.current = el.scrollHeight - el.scrollTop - el.clientHeight < 40;
                }}
                tabIndex={0}
                aria-label={`${current.title} contents`}
              >
                {error && <p className="m-3 text-[#ffa8b4]">{error}</p>}
                {!error && log && lines.length === 0 && <p className="m-3 text-[var(--text-muted)]">This log is empty.</p>}
                {!error && lines.length > 0 && visible.length === 0 && (
                  <p className="m-3 text-[var(--text-muted)]">No lines match that filter.</p>
                )}
                {log?.truncated && (
                  <p className="mx-3 mb-2 text-[var(--text-muted)]">
                    Showing the last {MAX_READ_LABEL} of this {formatBytes(log.size)} log.
                  </p>
                )}
                {shown.length > MAX_LINES && (
                  <p className="mx-3 mb-2 text-[var(--text-muted)]">
                    Showing the newest {MAX_LINES} of {shown.length} lines. Use search or filters to narrow it.
                  </p>
                )}
                {visible.map((l) => {
                  const st = LEVEL_STYLE[l.level];
                  return (
                    <div
                      key={l.n}
                      className="flex gap-3 whitespace-pre-wrap break-words px-3"
                      style={{ borderLeft: `3px solid ${st.bar}`, color: st.text }}
                    >
                      <span className="w-9 flex-none select-none text-right text-[#4d5f7d]">{l.n}</span>
                      <span className="min-w-0 flex-1">{l.text || " "}</span>
                    </div>
                  );
                })}
              </div>

              <div className="flex flex-none items-center gap-2">
                <p className="m-0 min-w-0 flex-1 text-[11.5px] leading-snug text-[var(--text-muted)]">
                  {plural(counts.error, "error")}, {plural(counts.warn, "warning")}
                  {current.group === "sdk" &&
                    (current.path.toLowerCase().endsWith(".prev.log")
                      ? " · The session before the last one. BmSDK keeps it in case the game was started again after a crash."
                      : " · A new log starts each time the game launches, so this is the last session.")}
                  {current.group === "crash" && " · The game writes these when it crashes. Newest first."}
                </p>
                <label className="flex cursor-pointer items-center gap-2 text-[12px] font-semibold text-[var(--text-secondary)]">
                  <input
                    type="checkbox"
                    className="h-4 w-4 accent-[#3b9eff]"
                    checked={follow}
                    onChange={(e) => setFollow(e.target.checked)}
                  />
                  Live
                </label>
                <button type="button" className="btn btn-sm" onClick={() => void copy()} disabled={shown.length === 0}>
                  {copied ? "Copied" : level === "all" && !search ? "Copy" : "Copy shown"}
                </button>
                <button
                  type="button"
                  className="btn btn-sm"
                  onClick={() => actions.attempt(api.revealLog(current.path), "Showing the log in its folder")}
                >
                  <Icons.Folder />
                  Show in folder
                </button>
              </div>
            </>
          )}
        </section>
      </div>
    </>
  );
}
