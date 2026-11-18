import { useCallback, useEffect, useRef, useState } from "react";
import { getCurrentWindow } from "@tauri-apps/api/window";
import { getCurrentWebview } from "@tauri-apps/api/webview";
import { api, errorText, NEEDS_ADMIN, onProgress, onStateChanged, type Overview, type Progress, type Review, type Updates } from "./api";
import { Icons } from "./components/Icons";
import { IconTile, ProgressBar, Tooltips, formatBytes } from "./components/ui";
import HomeView from "./views/HomeView";
import ModsView from "./views/ModsView";
import BackupsView from "./views/BackupsView";
import LogsView from "./views/LogsView";
import SettingsView from "./views/SettingsView";
import SetupWizard from "./views/SetupWizard";
import ReviewDialog from "./views/ReviewDialog";

export type View = "home" | "mods" | "backups" | "logs" | "settings";

export interface Actions {
  refresh: () => Promise<void>;
  /** Runs a change to the game folder, asking for write access first when Windows needs it. */
  run: (label: string, task: () => Promise<unknown>, success?: string) => Promise<boolean>;
  toast: (text: string, level?: Toast["level"]) => void;
  checkUpdates: () => Promise<void>;
  scan: (paths: string[]) => Promise<void>;
  navigate: (view: View) => void;
  /** Opens the Logs view, filtered to one mod's lines when a name is given. */
  openLogs: (modName?: string) => void;
  /** Runs a quick action like opening a folder and confirms it in the status bar. */
  attempt: (task: Promise<unknown>, done: string) => void;
  /** The label of the task running now. Buttons that change things disable while it's set. */
  busy: string | null;
}

interface Toast {
  id: number;
  text: string;
  level: "info" | "success" | "error";
  leaving?: boolean;
}

const NAV: { id: View; label: string; icon: () => JSX.Element }[] = [
  { id: "home", label: "Home", icon: Icons.Home },
  { id: "mods", label: "Mods", icon: Icons.Box },
  { id: "backups", label: "Backups", icon: Icons.Shield },
  { id: "logs", label: "Logs", icon: Icons.Logs },
  { id: "settings", label: "Settings", icon: Icons.Settings },
];

const PROGRESS_LABEL: Record<Progress["task"], string> = {
  sdk: "Downloading BmSDK",
  manager: "Downloading the new manager",
  files: "Copying mod files",
  mods: "Changing mods",
};

export default function App() {
  const [overview, setOverview] = useState<Overview | null>(null);
  const [view, setView] = useState<View>("home");
  const [logMod, setLogMod] = useState<string | null>(null);
  const [updates, setUpdates] = useState<Updates | null>(null);
  const [checking, setChecking] = useState(false);
  const [updateError, setUpdateError] = useState<string | null>(null);
  const [busy, setBusy] = useState<string | null>(null);
  const [progress, setProgress] = useState<Progress | null>(null);
  const [reviews, setReviews] = useState<Review[] | null>(null);
  const [dragging, setDragging] = useState(false);
  const [adminRetry, setAdminRetry] = useState<(() => void) | null>(null);
  const [toasts, setToasts] = useState<Toast[]>([]);
  const [slow, setSlow] = useState(false);
  const [card, setCard] = useState<{ label: string; progress: Progress | null; done: boolean } | null>(null);
  const [cardLeaving, setCardLeaving] = useState(false);
  const toastId = useRef(0);
  const succeeded = useRef(false);
  const busyRef = useRef<string | null>(null);
  busyRef.current = busy;
  const cardShown = useRef(false);

  // Quick changes like a toggle finish before this shows, so they don't flash a progress card
  useEffect(() => {
    setSlow(false);
    if (!busy) return;
    const t = setTimeout(() => setSlow(true), 400);
    return () => clearTimeout(t);
  }, [busy]);
  const showBusy = !!busy && (slow || !!progress) && !(overview && (!overview.setupDone || !overview.game) && busy === "Installing BmSDK");

  useEffect(() => {
    cardShown.current = card !== null;
  }, [card]);

  // When a task ends the card turns into a "Done" state for a moment, then leaves.
  // A failed task skips the "Done" since its error toast says what happened.
  useEffect(() => {
    if (showBusy) {
      setCard({ label: busy!, progress, done: false });
      setCardLeaving(false);
      return;
    }
    if (!cardShown.current) return;

    const ok = succeeded.current;
    if (ok) setCard((c) => (c ? { ...c, done: true } : c));
    const leave = setTimeout(() => setCardLeaving(true), ok ? 1300 : 0);
    const remove = setTimeout(() => {
      setCard(null);
      setCardLeaving(false);
    }, ok ? 1600 : 300);
    return () => {
      clearTimeout(leave);
      clearTimeout(remove);
    };
  }, [showBusy, busy, progress]);
  const startupChecked = useRef(false);

  const refresh = useCallback(async () => {
    setOverview(await api.overview());
  }, []);

  const toast = useCallback((text: string, level: Toast["level"] = "info") => {
    const id = ++toastId.current;
    setToasts((t) => [...t, { id, text, level }]);
    // Fade out first, then drop it once the exit animation is done
    setTimeout(() => {
      setToasts((t) => t.map((x) => (x.id === id ? { ...x, leaving: true } : x)));
      setTimeout(() => setToasts((t) => t.filter((x) => x.id !== id)), 300);
    }, level === "error" ? 7000 : 4000);
  }, []);

  const run = useCallback<Actions["run"]>(
    async (label, task, success) => {
      setBusy(label);
      setProgress(null);
      succeeded.current = false;
      try {
        await task();
        succeeded.current = true;
        if (success) toast(success, "success");
        return true;
      } catch (e) {
        const text = errorText(e);
        if (text === NEEDS_ADMIN) {
          setAdminRetry(() => () => void run(label, task, success));
        } else {
          toast(text, "error");
        }
        return false;
      } finally {
        setBusy(null);
        setProgress(null);
        await refresh();
      }
    },
    [refresh, toast],
  );

  // Linked mods are checked on Nexus alongside BmSDK. It stays quiet when Nexus can't be reached.
  const checkNexus = useCallback(async () => {
    try {
      const r = await api.checkNexus();
      if (r.updates.length > 0) {
        toast(
          r.updates.length === 1
            ? `${r.updates[0]} has a new version on Nexus Mods.`
            : `${r.updates.length} mods have new versions on Nexus Mods.`,
          "info",
        );
      }
      await refresh();
    } catch {
      // No connection or Nexus changed something. The mod panel's own check reports errors.
    }
  }, [toast, refresh]);

  const checkUpdates = useCallback(async () => {
    void checkNexus();
    setChecking(true);
    setUpdateError(null);
    try {
      setUpdates(await api.checkUpdates());
    } catch (e) {
      setUpdateError(errorText(e));
    } finally {
      setChecking(false);
    }
  }, [checkNexus]);

  const scan = useCallback(
    async (paths: string[]) => {
      if (paths.length === 0 || busyRef.current) return;
      setBusy("Looking inside");
      try {
        setReviews(await api.scanPaths(paths));
      } catch (e) {
        toast(errorText(e), "error");
      } finally {
        setBusy(null);
      }
    },
    [toast],
  );

  useEffect(() => {
    void refresh();
    const unlisten = onProgress(setProgress);
    // The backend changes things on its own too, such as turning mods back on after the game closes
    const unlistenState = onStateChanged(() => void refresh());
    return () => {
      void unlisten.then((f) => f());
      void unlistenState.then((f) => f());
    };
  }, [refresh]);

  // Opening the logs counts as looking at them, which clears the alert dot
  const alertNow = !!overview && (overview.logsAlert.errors > 0 || !!overview.logsAlert.crash);
  useEffect(() => {
    if (view === "logs" && alertNow) void api.ackLogs().then(refresh);
  }, [view, alertNow, refresh]);

  useEffect(() => {
    if (!overview || startupChecked.current) return;
    startupChecked.current = true;
    if (overview.checkOnStart && overview.setupDone) void checkUpdates();
  }, [overview, checkUpdates]);

  useEffect(() => {
    const unlisten = getCurrentWebview().onDragDropEvent((event) => {
      const p = event.payload;
      if (p.type === "enter" || p.type === "over") setDragging(true);
      else if (p.type === "leave") setDragging(false);
      else if (p.type === "drop") {
        setDragging(false);
        void scan(p.paths);
      }
    });
    return () => void unlisten.then((f) => f());
  }, [scan]);

  const actions: Actions = {
    refresh,
    run,
    toast,
    checkUpdates,
    scan,
    navigate: (v) => {
      setLogMod(null);
      setView(v);
    },
    openLogs: (modName) => {
      setLogMod(modName ?? null);
      setView("logs");
    },
    attempt: (task, done) => void task.then(() => toast(done, "info"), (e) => toast(errorText(e), "error")),
    busy,
  };

  if (!overview) {
    return <div className="app-shell h-full" />;
  }

  const inSetup = !overview.setupDone || !overview.game;

  return (
    <div className="app-shell relative flex h-full flex-col overflow-hidden">
      <TitleBar version={overview.managerVersion} />

      {inSetup ? (
        <SetupWizard overview={overview} actions={actions} busy={busy} progress={progress} />
      ) : (
        <div className="relative flex min-h-0 flex-1">
          <nav aria-label="App navigation" className="relative z-10 flex w-[72px] flex-none flex-col items-center justify-center gap-2.5 border-r border-[var(--border-default)]">
            {NAV.map((item) => (
              <button
                key={item.id}
                type="button"
                className="nav-rail-item relative [&_svg]:h-[22px] [&_svg]:w-[22px]"
                data-active={view === item.id}
                aria-current={view === item.id ? "page" : undefined}
                aria-label={item.label}
                title={item.label}
                onClick={() => actions.navigate(item.id)}
              >
                <item.icon />
                {item.id === "logs" && alertNow && view !== "logs" && (
                  <span
                    aria-label="The last session had errors"
                    title={overview.logsAlert.crash ? "The game crashed last time" : `${overview.logsAlert.errors} errors in the last session`}
                    className="absolute right-1.5 top-1.5 h-2.5 w-2.5 rounded-full border-2 border-[#0a1322] bg-[#ff7a8c]"
                  />
                )}
              </button>
            ))}
          </nav>
          <main key={view} className="view-in relative z-10 flex min-h-0 min-w-0 flex-1 flex-col gap-4 overflow-y-auto px-6 py-[22px]">
            {view === "home" && (
              <HomeView
                overview={overview}
                actions={actions}
                updates={updates}
                checking={checking}
                updateError={updateError}
              />
            )}
            {view === "mods" && <ModsView overview={overview} actions={actions} />}
            {view === "backups" && <BackupsView overview={overview} actions={actions} />}
            {view === "logs" && <LogsView actions={actions} mods={overview.mods} initialMod={logMod} />}
            {view === "settings" && <SettingsView overview={overview} actions={actions} />}
          </main>
        </div>
      )}

      {dragging && (
        <div className="overlay pointer-events-none">
          <div className="drop-zone h-[220px] w-[520px] flex-col gap-3 text-[15px] [&_svg]:h-9 [&_svg]:w-9">
            <Icons.Upload />
            Drop to install
            <span className="text-[12px] font-medium text-[var(--text-muted)]">.zip, .7z, .rar, folders, .cs scripts or .asi plugins</span>
          </div>
        </div>
      )}

      {reviews && (
        <ReviewDialog
          reviews={reviews}
          onClose={() => setReviews(null)}
          actions={actions}
        />
      )}

      {adminRetry && (
        <div className="overlay">
          <section role="dialog" aria-labelledby="admin-title" className="dialog w-[480px]">
            <div className="flex items-center gap-3.5">
              <IconTile theme="amber" size={44} radius={14}>
                <Icons.Lock />
              </IconTile>
              <h2 id="admin-title" className="m-0 text-[18px] font-bold">Windows needs your OK</h2>
            </div>
            <p className="m-0 text-[13px] leading-relaxed text-[var(--text-secondary)]">
              Your game is in a protected folder. Allow access once and your Windows account can change files in the game
              folder from then on. Nothing outside the game folder changes.
            </p>
            <div className="flex justify-end gap-2.5">
              <button type="button" className="btn" onClick={() => setAdminRetry(null)}>
                Cancel
              </button>
              <button
                type="button"
                className="btn btn-primary"
                onClick={async () => {
                  const retry = adminRetry;
                  setAdminRetry(null);
                  try {
                    if (await api.grantAccess()) retry();
                    else toast("Access wasn't granted, so nothing changed.", "error");
                  } catch (e) {
                    toast(errorText(e), "error");
                  }
                }}
              >
                Allow access
              </button>
            </div>
          </section>
        </div>
      )}

      <Tooltips />

      <StatusBar
        card={card}
        leaving={cardLeaving}
        toast={toasts.filter((t) => !t.leaving).slice(-1)[0]}
        onDismiss={(id) => setToasts((t) => t.filter((x) => x.id !== id))}
      />
    </div>
  );
}

function StatusBar({
  card,
  leaving,
  toast,
  onDismiss,
}: {
  card: { label: string; progress: Progress | null; done: boolean } | null;
  leaving: boolean;
  toast: Toast | undefined;
  onDismiss: (id: number) => void;
}) {
  // Work in progress comes first, then the latest message, then a quiet idle line
  const working = card && !leaving;
  const p = card?.progress ?? null;
  const counts =
    !card || card.done || !p || p.total <= 0
      ? null
      : p.task === "sdk" || p.task === "manager"
        ? `${formatBytes(p.done)} / ${formatBytes(p.total)}`
        : `${p.done} / ${p.total}`;

  let tone = "#7f93b3";
  let icon = <Icons.Circle />;
  let text = "Ready";
  let spin = false;
  let bg = "transparent";

  if (working) {
    tone = card.done ? "#7fe9c0" : "#5db1ff";
    icon = card.done ? <Icons.Check /> : <Icons.Spinner />;
    spin = !card.done;
    text = card.done ? "Done" : p ? PROGRESS_LABEL[p.task] : card.label;
  } else if (toast) {
    const kinds = {
      error: { tone: "#ffa8b4", bg: "rgba(237,86,108,.1)", icon: <Icons.X /> },
      success: { tone: "#7fe9c0", bg: "rgba(70,211,154,.08)", icon: <Icons.Check /> },
      info: { tone: "#9ad0ff", bg: "rgba(59,158,255,.08)", icon: <Icons.Info /> },
    }[toast.level];
    tone = kinds.tone;
    bg = kinds.bg;
    icon = kinds.icon;
    text = toast.text;
  }

  return (
    <footer
      role="status"
      aria-live="polite"
      className="relative z-30 flex h-10 flex-none items-center gap-3 border-t border-[var(--border-default)] px-5 transition-colors duration-300"
      style={{ background: bg }}
    >
      <span key={working ? "work" : (toast?.id ?? "idle")} className="status-in flex min-w-0 flex-1 items-center gap-2.5 text-[12.5px]">
        <span className={`flex flex-none [&_svg]:h-4 [&_svg]:w-4 ${spin ? "spin" : ""}`} style={{ color: tone }}>
          {icon}
        </span>
        <span className="min-w-0 flex-1 truncate font-medium" style={{ color: toast || working ? "#e4ecf8" : "#7f93b3" }} title={text}>
          {text}
        </span>
      </span>
      {working && (
        <>
          {counts && <span className="flex-none font-mono text-[11px] text-[var(--text-muted)]">{counts}</span>}
          <div className="w-[220px] flex-none">
            <ProgressBar done={card.done ? 1 : (p?.done ?? 0)} total={card.done ? 1 : (p?.total ?? 0)} />
          </div>
        </>
      )}
      {!working && toast && (
        <button type="button" className="win-ctrl !h-7 !w-7 flex-none [&_svg]:h-3.5 [&_svg]:w-3.5" aria-label="Dismiss" onClick={() => onDismiss(toast.id)}>
          <Icons.X />
        </button>
      )}
    </footer>
  );
}

function TitleBar({ version }: { version: string }) {
  const win = getCurrentWindow();
  return (
    <header className="relative z-30 flex h-[52px] flex-none select-none items-center border-b border-[var(--border-default)] pl-4 pr-3">
      <div className="flex h-full min-w-0 flex-1 items-center gap-2.5" data-tauri-drag-region>
        <img src="./icon.ico" alt="" className="pointer-events-none h-[30px] w-[30px] rounded-[9px] object-contain" />
        <span className="pointer-events-none font-display text-[15px] font-semibold tracking-[0.2px]">BmSDK Manager</span>
        <span className="pill pointer-events-none px-2 py-0.5 text-[10px]">v{version}</span>
      </div>
      <div className="flex items-center gap-1">
        <button type="button" className="win-ctrl [&_svg]:h-3.5 [&_svg]:w-3.5" aria-label="Minimize" onClick={() => void win.minimize()}>
          <Icons.Minus />
        </button>
        <button type="button" className="win-ctrl win-ctrl-close [&_svg]:h-3.5 [&_svg]:w-3.5" aria-label="Close" onClick={() => void win.close()}>
          <Icons.X />
        </button>
      </div>
    </header>
  );
}
