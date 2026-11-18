import { useEffect, useRef, useState } from "react";
import type { ReactNode } from "react";
import type { Actions } from "../App";
import { api, type Overview, type Updates } from "../api";
import { Icons } from "../components/Icons";
import { IconTile, SpinIcon, ViewHeader, formatTime, pinTip, plural, type Theme } from "../components/ui";

const ACTIVITY_THEME: Record<string, { theme: Theme; icon: () => JSX.Element }> = {
  info: { theme: "blue", icon: Icons.Info },
  success: { theme: "emerald", icon: Icons.Check },
  warning: { theme: "amber", icon: Icons.Alert },
  error: { theme: "rose", icon: Icons.X },
};

export default function HomeView({
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
  const game = overview.game!;
  const enabled = overview.mods.filter((m) => m.enabled);
  const count = (kinds: string[]) => enabled.filter((m) => kinds.includes(m.kind)).length;
  const installed = game.sdkVersion;
  const working = !!actions.busy;
  const [launching, setLaunching] = useState(false);
  const [confirmVerify, setConfirmVerify] = useState(false);

  // The warning lapses if you walk away, so a later click can't start a verify by accident
  useEffect(() => {
    if (!confirmVerify) return;
    const t = setTimeout(() => setConfirmVerify(false), 6000);
    return () => clearTimeout(t);
  }, [confirmVerify]);
  const verifyButton = useRef<HTMLButtonElement>(null);

  // The warning is a pinned tooltip, so it takes the place of the plain one and doesn't cover it
  useEffect(() => {
    if (!confirmVerify) return;
    pinTip(
      verifyButton.current,
      "Steam puts back any game file that was changed, which includes mods that replace game files. Turn replacers on again afterwards.",
      "warning",
    );
    return () => pinTip(null);
  }, [confirmVerify]);
  const installing = actions.busy === "Installing BmSDK";
  const logsAlarm = !!overview.logsAlert.crash || overview.logsAlert.errors > 0;

  const installSdk = () =>
    actions.run("Installing BmSDK", async () => {
      const version = await api.installSdk();
      await actions.checkUpdates();
      actions.toast(`BmSDK ${version} is installed.`, "success");
    });

  let status: { text: string; theme: Theme };
  if (checking) status = { text: "Checking", theme: "blue" };
  else if (!installed) status = { text: "Not installed", theme: "rose" };
  else if (updateError) status = { text: "Couldn't check", theme: "amber" };
  else if (updates?.sdkUpdate) status = { text: "Update available", theme: "blue" };
  else if (updates) status = { text: "Up to date", theme: "emerald" };
  else status = { text: "Not checked", theme: "amber" };

  const stats: { label: string; value: number; theme: Theme; icon: () => JSX.Element }[] = [
    { label: "Script mods", value: count(["scriptMod", "prebuiltDll", "looseScripts"]), theme: "blue", icon: Icons.Code },
    { label: "Suits and DLC", value: count(["dlc"]), theme: "emerald", icon: Icons.Shirt },
    { label: "Replacers and plugins", value: count(["replacer", "asiPlugin"]), theme: "amber", icon: Icons.Swap },
    { label: "Game files backed up", value: overview.backedUp, theme: "cyan", icon: Icons.Shield },
  ];

  return (
    <>
      <ViewHeader
        icon={<Icons.Home />}
        title="Batman: Arkham Knight"
        subtitle={
          game.running
            ? "The game is running. Close it before changing mods."
            : `${plural(enabled.length, "mod")} on${installed ? `, BmSDK ${installed}` : ", BmSDK isn't installed yet"}`
        }
      >
        {logsAlarm && (
          <button
            type="button"
            className="btn border-[rgba(237,86,108,.4)] text-[#ffa8b4]"
            title="Opens the logs. Copy diagnostics is there too."
            onClick={() => actions.openLogs()}
          >
            <Icons.Alert />
            {overview.logsAlert.crash
              ? "Game crashed"
              : `${overview.logsAlert.errors} error${overview.logsAlert.errors === 1 ? "" : "s"} logged`}
          </button>
        )}
        <button type="button" className="btn" onClick={() => actions.attempt(api.openFolder("game"), "Opened the game folder")}>
          <Icons.Folder />
          Open game folder
        </button>
        <button
          type="button"
          className="btn"
          title="Turns your mods off, starts the game, and turns them back on when it closes"
          disabled={game.running || working || launching || overview.suspended > 0}
          onClick={async () => {
            setLaunching(true);
            await actions.run("Starting without mods", async () => {
              await api.playClean();
            }, "Starting without mods. They come back on when the game closes.");
            setTimeout(() => setLaunching(false), 6000);
          }}
        >
          Play without mods
        </button>
        <button
          type="button"
          className="btn btn-primary h-10 px-[18px] text-[13px]"
          disabled={game.running || working || launching}
          onClick={() => {
            setLaunching(true);
            actions.attempt(api.launchGame(), "Starting Arkham Knight");
            // The game takes a few seconds to show up as running, so hold the button until then
            setTimeout(() => setLaunching(false), 6000);
          }}
        >
          <Icons.Play />
          {game.running ? "Running" : launching ? "Starting…" : "Play"}
        </button>
      </ViewHeader>

      {overview.suspended > 0 && (
        <Banner
          theme="amber"
          icon={<Icons.Refresh />}
          text={`${overview.suspended} mod${overview.suspended === 1 ? " is" : "s are"} off for a launch without mods. They come back on when the game closes.`}
        >
          <button
            type="button"
            className="btn"
            disabled={game.running || working}
            onClick={() => void actions.run("Turning mods back on", () => api.restoreSuspended(), "Your mods are back on.")}
          >
            Turn them back on
          </button>
        </Banner>
      )}

      {installed && !game.asiLoader && (
        <Banner
          theme="amber"
          icon={<Icons.Alert />}
          text="The ASI loader (dinput8.dll) is missing, so BmSDK can't start with the game. Repair install puts it back."
        >
          <button type="button" className="btn btn-primary" disabled={working} onClick={() => void installSdk()}>
            {installing ? "Repairing…" : "Repair install"}
          </button>
        </Banner>
      )}

      {updates?.managerUpdate && (
        <section className="nv-card flex flex-none items-center gap-3.5 border-[rgba(91,177,255,.28)] px-4 py-3">
          <IconTile theme="blue" size={34} radius={11}>
            <Icons.Download />
          </IconTile>
          <p className="m-0 flex-1 text-[13px] text-[var(--text-secondary)]">
            <span className="font-bold text-[var(--text-primary)]">Manager {updates.latest} is out.</span> It updates
            itself and restarts in a few seconds.
          </p>
          <button
            type="button"
            className="btn btn-primary"
            disabled={working}
            onClick={() => void actions.run("Updating the manager", api.updateManager)}
          >
            {actions.busy === "Updating the manager" ? "Updating…" : "Update and restart"}
          </button>
        </section>
      )}

      <div className="grid flex-none grid-cols-[1.55fr_1fr] gap-3.5">
        <section className="nv-card relative flex flex-col gap-3.5 overflow-hidden p-[18px]">
          <div className="pointer-events-none absolute -right-16 -top-20 h-[260px] w-[260px] rounded-full bg-[radial-gradient(circle,rgba(59,158,255,.18),transparent_70%)]" />
          <div className="flex items-center gap-3">
            <IconTile theme="blue">
              <Icons.Code />
            </IconTile>
            <div className="flex-1">
              <p className="m-0 font-display text-[13px] font-bold">BmSDK</p>
              <p className="m-0 mt-0.5 text-[12px] text-[var(--text-muted)]">Script runtime and mod loader</p>
            </div>
            <StatusPill text={status.text} theme={status.theme} spinning={checking} />
          </div>

          <div className="grid min-h-0 flex-1 grid-cols-3 gap-3">
            <Stat label="Installed" value={installed ?? "None"} sub="In your game folder" bright />
            <Stat
              label="Latest release"
              value={updates?.latest ?? (checking ? "…" : "?")}
              sub={updates ? (updates.sdkUpdate ? "Newer than yours" : "You have it") : "From GitHub"}
            />
            <Stat label="Source" value="GitHub" sub={overview.repo} mono />
          </div>

          {updateError && <p className="m-0 text-[12px] text-[#f4cf8e]">{updateError}</p>}

          <div className="flex gap-2">
            {updates && (updates.sdkUpdate || !installed) ? (
              <button type="button" className="btn btn-primary" disabled={working} onClick={() => void installSdk()}>
                <Icons.Download />
                {installing ? "Installing…" : installed ? `Update to ${updates.latest}` : `Install ${updates.latest}`}
              </button>
            ) : (
              <button type="button" className="btn" disabled={checking || working} onClick={() => void actions.checkUpdates()}>
                <SpinIcon active={checking} />
                Check now
              </button>
            )}
            {updates && (
              <button type="button" className="btn" onClick={() => actions.attempt(api.openUrl(updates.url), "Opened the release notes in your browser")}>
                What's new
              </button>
            )}
            {updates && installed && !updates.sdkUpdate && (
              <button type="button" className="btn" disabled={working} onClick={() => void installSdk()}>
                {installing ? "Repairing…" : "Repair install"}
              </button>
            )}
          </div>
        </section>

        <section className="nv-card flex flex-col gap-3 p-[18px]">
          <div className="flex items-center gap-3">
            <IconTile theme="purple">
              <Icons.Gamepad />
            </IconTile>
            <div className="flex-1">
              <p className="m-0 font-display text-[13px] font-bold">Game install</p>
              <p className="m-0 mt-0.5 text-[12px] text-[var(--text-muted)]">{game.store} copy</p>
            </div>
          </div>
          <p className="path-box m-0">{game.path}</p>
          <div className="grid grid-cols-2 gap-2">
            <Dot ok={game.writable} yes="Writable" no="Needs access" />
            <Dot ok={game.asiLoader} yes="ASI loader" no="No ASI loader" />
          </div>
          <div className="flex-1" />
          {game.store === "Steam" && (
            <div>
              <button
                ref={verifyButton}
                type="button"
                className={`btn w-full ${confirmVerify ? "btn-primary" : ""}`}
                disabled={game.running || working}
                title="Opens Steam and checks the game's files against its servers. It fixes missing or damaged files."
                onClick={() => {
                  if (!confirmVerify) {
                    setConfirmVerify(true);
                    return;
                  }
                  setConfirmVerify(false);
                  actions.attempt(api.verifyGameFiles(), "Steam is verifying the game files. Watch its window for progress.");
                }}
              >
                <Icons.Shield />
                {confirmVerify ? "Verify now" : "Verify game files in Steam"}
              </button>
            </div>
          )}
          <button type="button" className="btn w-full" onClick={() => actions.navigate("settings")}>
            Change folder
          </button>
        </section>
      </div>

      <div className="grid flex-none grid-cols-4 gap-3.5">
        {stats.map((s) => (
          <div key={s.label} className="nv-card flex items-center gap-3 rounded-2xl p-3.5">
            <IconTile theme={s.theme} size={36} radius={11}>
              <s.icon />
            </IconTile>
            <div className="min-w-0">
              <p className="m-0 font-display text-[22px] font-bold leading-none">{s.value}</p>
              <p className="m-0 mt-1 truncate text-[11.5px] text-[var(--text-muted)]">{s.label}</p>
            </div>
          </div>
        ))}
      </div>

      <section className="nv-card flex min-h-0 flex-1 flex-col gap-2.5 px-[18px] py-4">
        <div className="flex items-center">
          <p className="m-0 flex-1 font-display text-[13px] font-bold">Activity</p>
          <span className="label">Recent</span>
        </div>
        <div className="flex min-h-0 flex-1 flex-col gap-2.5 overflow-y-auto pr-1">
          {overview.activity.length === 0 && (
            <p className="m-0 text-[12.5px] text-[var(--text-muted)]">Installs, updates and changes show up here.</p>
          )}
          {overview.activity.map((a, i) => {
            const t = ACTIVITY_THEME[a.level] ?? ACTIVITY_THEME.info;
            return (
              <div key={i} className="flex items-center gap-3">
                <IconTile theme={t.theme} size={26} radius={8} iconSize={13}>
                  <t.icon />
                </IconTile>
                <p className="m-0 min-w-0 flex-1 truncate text-[12.5px] text-[var(--text-secondary)]">{a.text}</p>
                <span className="font-mono text-[11px] text-[var(--text-muted)]">{formatTime(a.time)}</span>
              </div>
            );
          })}
        </div>
      </section>
    </>
  );
}

function Banner({ theme, icon, text, children }: { theme: Theme; icon: ReactNode; text: string; children: ReactNode }) {
  return (
    <section
      className="nv-card flex flex-none items-center gap-3.5 px-4 py-3"
      style={{ borderColor: theme === "rose" ? "rgba(237,86,108,.3)" : "rgba(237,180,86,.3)" }}
    >
      <IconTile theme={theme} size={34} radius={11}>
        {icon}
      </IconTile>
      <p className="m-0 min-w-0 flex-1 text-[13px] leading-snug text-[var(--text-secondary)]">{text}</p>
      <div className="flex flex-none gap-2">{children}</div>
    </section>
  );
}

function Stat({ label, value, sub, bright, mono }: { label: string; value: string; sub: string; bright?: boolean; mono?: boolean }) {
  return (
    <div className="flex min-w-0 flex-col justify-between gap-3 rounded-[14px] border border-[var(--border-default)] bg-[rgba(255,255,255,.03)] px-4 py-3.5">
      <p className="label m-0">{label}</p>
      <p
        className={`m-0 truncate font-display text-[30px] font-bold leading-none ${bright ? "text-[var(--text-primary)]" : "text-[var(--text-secondary)]"}`}
      >
        {value}
      </p>
      <p className={`m-0 truncate text-[11.5px] text-[var(--text-muted)] ${mono ? "font-mono text-[10.5px]" : ""}`}>{sub}</p>
    </div>
  );
}

function StatusPill({ text, theme, spinning }: { text: string; theme: Theme; spinning?: boolean }) {
  const colors: Record<Theme, string> = {
    blue: "#9ad0ff",
    emerald: "#7fe9c0",
    amber: "#f4cf8e",
    rose: "#ffa8b4",
    cyan: "#8fe6f4",
    purple: "#c7b6ff",
    teal: "#8fe8d8",
  };
  return (
    <span className="pill" style={{ color: colors[theme] }}>
      <span className={`flex [&_svg]:h-3 [&_svg]:w-3 ${spinning ? "spin" : ""}`}>
        {spinning ? <Icons.Spinner /> : theme === "emerald" ? <Icons.Check /> : <Icons.Circle />}
      </span>
      {text}
    </span>
  );
}

function Dot({ ok, yes, no }: { ok: boolean; yes: string; no: string }) {
  return (
    <span className="pill justify-center py-2">
      <span style={{ color: ok ? "#7fe9c0" : "#f4cf8e" }}>●</span>
      {ok ? yes : no}
    </span>
  );
}
