import { useEffect, useState, type ReactNode } from "react";
import { open } from "@tauri-apps/plugin-dialog";
import type { Actions } from "../App";
import { api, errorText, type GameInstall, type Overview, type Progress, type Updates } from "../api";
import { Icons } from "../components/Icons";
import { KindTile, ProgressBar, formatBytes, plural } from "../components/ui";
import { pickMods } from "./ModsView";

const STEPS = ["Find the game", "Install BmSDK", "Add mods"];

export default function SetupWizard({
  overview,
  actions,
  busy,
  progress,
}: {
  overview: Overview;
  actions: Actions;
  busy: string | null;
  progress: Progress | null;
}) {
  const [step, setStep] = useState(0);

  return (
    <div className="relative z-10 flex min-h-0 flex-1 flex-col">
      <ol aria-label="Setup steps" className="mx-auto flex w-[640px] list-none items-center gap-3.5 p-0 pt-7">
        {STEPS.map((label, i) => (
          <li key={label} className="contents">
            {i > 0 && (
              <span
                aria-hidden="true"
                className="h-0.5 flex-1 rounded"
                style={{ background: i <= step ? "linear-gradient(90deg, rgba(70,211,154,.5), rgba(91,177,255,.5))" : "rgba(255,255,255,.08)" }}
              />
            )}
            <span
              className="flex items-center gap-2.5 text-[12.5px] font-semibold"
              style={{ color: i < step ? "#7fe9c0" : i === step ? "#f0f5fc" : "#7f93b3" }}
              aria-current={i === step ? "step" : undefined}
            >
              <span
                className="flex h-[26px] w-[26px] items-center justify-center rounded-full border font-display text-[12px] font-bold [&_svg]:h-3 [&_svg]:w-3"
                style={
                  i < step
                    ? { background: "rgba(70,211,154,.15)", borderColor: "rgba(70,211,154,.35)" }
                    : i === step
                      ? { background: "var(--accent-grad)", border: 0, color: "#fff", boxShadow: "0 6px 16px -6px rgba(59,158,255,.8)" }
                      : { borderColor: "rgba(255,255,255,.12)" }
                }
              >
                {i < step ? <Icons.Check /> : i + 1}
              </span>
              {label}
            </span>
          </li>
        ))}
      </ol>

      {step === 0 && <FindGame overview={overview} actions={actions} onNext={() => setStep(1)} />}
      {step === 1 && <InstallSdk overview={overview} actions={actions} busy={busy} progress={progress} onBack={() => setStep(0)} onNext={() => setStep(2)} />}
      {step === 2 && <AddMods overview={overview} actions={actions} onBack={() => setStep(1)} />}
    </div>
  );
}

function Hero({ title, text, children }: { title: string; text: string; children?: ReactNode }) {
  return (
    <div className="flex flex-col items-center gap-4 text-center">
      <div className="flex h-[88px] w-[88px] items-center justify-center rounded-[28px] shadow-[0_24px_60px_-18px_rgba(59,158,255,.85),inset_0_1px_0_rgba(255,255,255,.35)] [background:var(--accent-grad)]">
        <img src="./icon.ico" alt="" className="h-14 w-14" />
      </div>
      <div>
        <h1 className="m-0 text-[24px] font-bold tracking-[-0.3px]">{title}</h1>
        <p className="m-0 mt-1.5 text-[13px] text-[var(--text-muted)]">{text}</p>
      </div>
      {children}
    </div>
  );
}

function Footer({ children, path }: { children: ReactNode; path?: string }) {
  return (
    <footer className="flex flex-none items-center gap-2.5 border-t border-[var(--border-default)] px-6 py-4">
      <span className="min-w-0 flex-1 truncate font-mono text-[11.5px] text-[var(--text-muted)]">{path}</span>
      {children}
    </footer>
  );
}

function FindGame({ overview, actions, onNext }: { overview: Overview; actions: Actions; onNext: () => void }) {
  const [installs, setInstalls] = useState<GameInstall[] | null>(null);
  const [chosen, setChosen] = useState<string | null>(overview.game?.path ?? null);

  useEffect(() => {
    void api.detectGames().then((found) => {
      setInstalls(found);
      if (!chosen && found.length > 0) setChosen(found[0].path);
    });
    // Only on first show, so a later pick isn't replaced by the detected one
  }, []);

  const browse = async () => {
    const picked = await open({ directory: true, title: "Choose your Batman: Arkham Knight folder" });
    if (typeof picked === "string") {
      setInstalls((list) => [...(list ?? []).filter((i) => i.path !== picked), { path: picked, source: "Chosen by you" }]);
      setChosen(picked);
    }
  };

  const next = async () => {
    if (!chosen) return;
    if (await actions.run("Checking the folder", () => api.setGameDir(chosen))) onNext();
  };

  return (
    <>
      <main className="mx-auto flex w-[640px] flex-1 flex-col justify-center gap-6">
        <Hero title="Welcome to BmSDK Manager" text="It installs BmSDK, keeps it up to date and installs your mods. First, where's the game?" />
        <div className="flex flex-col gap-2">
          {installs === null && <p className="m-0 text-center text-[12.5px] text-[var(--text-muted)]">Looking for Steam and Epic installs…</p>}
          {installs?.length === 0 && (
            <p className="m-0 text-center text-[12.5px] text-[var(--text-muted)]">
              Couldn't find the game through Steam or Epic. Choose its folder yourself.
            </p>
          )}
          {installs?.map((i) => (
            <label
              key={i.path}
              className="flex cursor-pointer items-center gap-3.5 rounded-[14px] border p-3.5"
              style={{
                borderColor: chosen === i.path ? "rgba(91,177,255,.35)" : "rgba(255,255,255,.07)",
                background: chosen === i.path ? "rgba(91,177,255,.08)" : "rgba(255,255,255,.03)",
              }}
            >
              <input type="radio" name="game" className="h-4 w-4 accent-[#3b9eff]" checked={chosen === i.path} onChange={() => setChosen(i.path)} />
              <span className="min-w-0 flex-1 truncate font-mono text-[12px] text-[var(--text-secondary)]">{i.path}</span>
              <span className="pill">{i.source}</span>
            </label>
          ))}
          <button type="button" className="btn self-center" onClick={() => void browse()}>
            <Icons.Folder />
            Choose a folder
          </button>
        </div>
      </main>
      <Footer>
        <button type="button" className="btn btn-primary h-10 px-[18px]" disabled={!chosen} onClick={() => void next()}>
          Next
        </button>
      </Footer>
    </>
  );
}

function InstallSdk({
  overview,
  actions,
  busy,
  progress,
  onBack,
  onNext,
}: {
  overview: Overview;
  actions: Actions;
  busy: string | null;
  progress: Progress | null;
  onBack: () => void;
  onNext: () => void;
}) {
  const [updates, setUpdates] = useState<Updates | null>(null);
  const [error, setError] = useState<string | null>(null);
  const game = overview.game!;
  const installed = game.sdkVersion;
  // BmSDK can be on the right version and still not load, if the ASI loader next to the game exe is gone
  const loaderMissing = !!installed && !game.asiLoader;
  const upToDate = !!installed && !!updates && !updates.sdkUpdate && !loaderMissing;
  const needsRepair = loaderMissing && !!updates && !updates.sdkUpdate;

  const check = () => {
    setError(null);
    api.checkUpdates().then(setUpdates, (e) => setError(errorText(e)));
  };
  useEffect(check, []);

  const install = () => actions.run("Installing BmSDK", async () => {
    await api.installSdk();
    setUpdates(await api.checkUpdates());
  });

  const downloading = busy === "Installing BmSDK";
  const items: { text: string; state: "done" | "doing" | "todo" | "warn" }[] = [
    { text: `Found Arkham Knight (${game.store})`, state: "done" },
    { text: game.writable ? "The game folder can be written to" : "Windows will ask once to allow changes to the game folder", state: game.writable ? "done" : "warn" },
    {
      text: updates ? `Latest BmSDK is ${updates.latest}` : error ? "Couldn't reach GitHub" : "Checking GitHub for the latest release",
      state: updates ? "done" : error ? "warn" : "doing",
    },
    {
      text: upToDate
        ? `BmSDK ${installed} is installed`
        : downloading
          ? "Downloading and installing"
          : needsRepair
            ? `BmSDK ${installed} is installed, but the ASI loader (dinput8.dll) is missing. Repair puts it back.`
            : installed
              ? `BmSDK ${installed} is installed, an update is ready`
              : "BmSDK isn't installed yet",
      state: upToDate ? "done" : downloading ? "doing" : needsRepair ? "warn" : "todo",
    },
  ];

  return (
    <>
      <main className="mx-auto flex w-[640px] flex-1 flex-col justify-center gap-5">
        <Hero
          title={upToDate ? `BmSDK ${installed} is ready` : updates ? `Get BmSDK ${updates.latest}` : "Getting BmSDK"}
          text="BmSDK comes from the latest GitHub release. The manager only downloads it when there's a new one."
        />
        {downloading && (
          <div className="flex flex-col gap-2">
            <ProgressBar done={progress?.done ?? 0} total={progress?.total ?? 0} />
            {progress && progress.total > 0 && (
              <p className="m-0 font-mono text-[11.5px] text-[var(--text-muted)]">
                {formatBytes(progress.done)} of {formatBytes(progress.total)}
              </p>
            )}
          </div>
        )}
        <div className="flex flex-col gap-2 rounded-[14px] border border-[var(--border-default)] bg-[rgba(255,255,255,.035)] px-4 py-3.5">
          {items.map((item) => (
            <div key={item.text} className="flex items-center gap-2.5 text-[12.5px] [&_svg]:h-[15px] [&_svg]:w-[15px]">
              <span
                className={`flex ${item.state === "doing" ? "spin" : ""}`}
                style={{ color: { done: "#7fe9c0", doing: "#5db1ff", todo: "#7f93b3", warn: "#f4cf8e" }[item.state] }}
              >
                {item.state === "done" ? <Icons.Check /> : item.state === "doing" ? <Icons.Spinner /> : item.state === "warn" ? <Icons.Alert /> : <Icons.Circle />}
              </span>
              <span style={{ color: item.state === "todo" ? "#7f93b3" : "#c2d2ea" }}>{item.text}</span>
            </div>
          ))}
        </div>
        {error && (
          <div className="flex items-center gap-3">
            <p className="m-0 flex-1 text-[12px] text-[#f4cf8e]">{error}</p>
            <button type="button" className="btn btn-sm" onClick={check}>
              Try again
            </button>
          </div>
        )}
      </main>
      <Footer path={game.path}>
        <button type="button" className="btn h-10" disabled={!!busy} onClick={onBack}>
          Back
        </button>
        {!upToDate && (
          <button type="button" className="btn btn-primary h-10 px-[18px]" disabled={!updates || !!busy} onClick={() => void install()}>
            <Icons.Download />
            {needsRepair ? "Repair install" : updates ? `${installed ? "Update to" : "Install"} ${updates.latest}` : "Install"}
            {updates && updates.sdkSize > 0 && <span className="font-normal opacity-75">({formatBytes(updates.sdkSize)})</span>}
          </button>
        )}
        <button type="button" className={upToDate ? "btn btn-primary h-10 px-[18px]" : "btn h-10"} disabled={!!busy} onClick={onNext}>
          {upToDate ? "Next" : "Skip"}
        </button>
      </Footer>
    </>
  );
}

function AddMods({ overview, actions, onBack }: { overview: Overview; actions: Actions; onBack: () => void }) {
  const finish = async () => {
    await api.finishSetup();
    await actions.refresh();
  };

  return (
    <>
      <main className="mx-auto flex w-[640px] flex-1 flex-col justify-center gap-5">
        <Hero
          title={overview.mods.length > 0 ? `Found ${plural(overview.mods.length, "mod")} you already have` : "Add some mods"}
          text="Drop mod archives or folders anywhere in this window. The manager works out what each one is and where it goes."
        />
        {overview.mods.length > 0 && (
          <div className="flex max-h-[150px] flex-col gap-1 overflow-y-auto rounded-[14px] border border-[var(--border-default)] bg-[rgba(255,255,255,.03)] p-2">
            {overview.mods.map((m) => (
              <div key={m.id} className="flex items-center gap-3 px-2 py-1">
                <KindTile kind={m.kind} size={26} />
                <span className="min-w-0 flex-1 truncate text-[12.5px] font-semibold">{m.name}</span>
                <span className="truncate font-mono text-[11px] text-[var(--text-muted)]">{m.location}</span>
              </div>
            ))}
          </div>
        )}
        <button type="button" className="drop-zone h-[88px] [&_svg]:h-5 [&_svg]:w-5" onClick={() => void pickMods(actions)}>
          <Icons.Upload />
          Drop mods here, or click to choose files
        </button>
      </main>
      <Footer>
        <button type="button" className="btn h-10" onClick={onBack}>
          Back
        </button>
        <button type="button" className="btn btn-primary h-10 px-[18px]" onClick={() => void finish()}>
          Finish
        </button>
      </Footer>
    </>
  );
}
