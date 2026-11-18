import { useEffect, useMemo, useRef, useState, type ReactNode } from "react";
import { open } from "@tauri-apps/plugin-dialog";
import type { Actions } from "../App";
import { api, errorText, type Kind, type ModView, type Overview } from "../api";
import { Icons } from "../components/Icons";
import { KindBadge, KindTile, SpinIcon, Toggle, ViewHeader, formatBytes, plural } from "../components/ui";

type Filter = "all" | "scripts" | "dlc" | "files";

const FILTERS: { id: Filter; label: string; kinds: Kind[] }[] = [
  { id: "all", label: "All", kinds: [] },
  { id: "scripts", label: "Scripts", kinds: ["scriptMod", "prebuiltDll", "looseScripts"] },
  { id: "dlc", label: "Suits and DLC", kinds: ["dlc"] },
  { id: "files", label: "Replacers and plugins", kinds: ["replacer", "asiPlugin"] },
];

export async function pickMods(actions: Actions) {
  const picked = await open({
    multiple: true,
    title: "Choose mods to install",
    filters: [
      { name: "Mods", extensions: ["zip", "7z", "rar", "cs", "asi"] },
      { name: "Any file", extensions: ["*"] },
    ],
  });
  if (picked) await actions.scan(Array.isArray(picked) ? picked : [picked]);
}

// Windows can't offer files and folders in one dialog, so unpacked mods get their own picker
export async function pickFolders(actions: Actions) {
  const picked = await open({ directory: true, multiple: true, title: "Choose mod folders to install" });
  if (picked) await actions.scan(Array.isArray(picked) ? picked : [picked]);
}

export default function ModsView({ overview: loaded, actions }: { overview: Overview; actions: Actions }) {
  // Toggles show their new state right away and roll back if the change fails
  const [optimistic, setOptimistic] = useState<Record<string, boolean>>({});
  const overview = useMemo(
    () => ({ ...loaded, mods: loaded.mods.map((m) => (m.id in optimistic ? { ...m, enabled: optimistic[m.id] } : m)) }),
    [loaded, optimistic],
  );
  const holdState = async (ids: string[], enabled: boolean, task: () => Promise<boolean>) => {
    setOptimistic((o) => ({ ...o, ...Object.fromEntries(ids.map((id) => [id, enabled])) }));
    await task();
    setOptimistic((o) => Object.fromEntries(Object.entries(o).filter(([id]) => !ids.includes(id))));
  };
  const [filter, setFilter] = useState<Filter>("all");
  const [search, setSearch] = useState("");
  const [selectedId, setSelectedId] = useState<string | null>(overview.mods[0]?.id ?? null);
  const [selecting, setSelecting] = useState(false);
  const [picked, setPicked] = useState<Set<string>>(new Set());
  const [confirmingRemove, setConfirmingRemove] = useState(false);
  const [naming, setNaming] = useState(false);
  const [profileName, setProfileName] = useState("");
  const [menu, setMenu] = useState<{ x: number; y: number; id: string } | null>(null);
  const [menuConfirm, setMenuConfirm] = useState(false);
  const nameInput = useRef<HTMLInputElement>(null);
  const [confirmTfc, setConfirmTfc] = useState<number | null>(null);

  useEffect(() => {
    if (naming) nameInput.current?.focus();
  }, [naming]);

  // The right-click menu closes on any click elsewhere, scrolling, Escape or losing focus
  useEffect(() => {
    if (!menu) return;
    const close = () => {
      setMenu(null);
      setMenuConfirm(false);
    };
    const onKey = (e: KeyboardEvent) => e.key === "Escape" && close();
    window.addEventListener("mousedown", close);
    window.addEventListener("blur", close);
    window.addEventListener("keydown", onKey);
    window.addEventListener("wheel", close, { passive: true });
    return () => {
      window.removeEventListener("mousedown", close);
      window.removeEventListener("blur", close);
      window.removeEventListener("keydown", onKey);
      window.removeEventListener("wheel", close);
    };
  }, [menu]);

  // Picks can hide behind a filter, so they don't carry over when the list changes
  useEffect(() => {
    setPicked(new Set());
    setConfirmingRemove(false);
  }, [filter, search, selecting]);

  // A confirm armed for one selection shouldn't carry over to a different one
  useEffect(() => setConfirmingRemove(false), [picked]);

  const mods = useMemo(() => {
    const kinds = FILTERS.find((f) => f.id === filter)!.kinds;
    const q = search.trim().toLowerCase();
    return overview.mods
      .filter((m) => kinds.length === 0 || kinds.includes(m.kind))
      .filter((m) => !q || m.name.toLowerCase().includes(q) || m.location.toLowerCase().includes(q))
      .sort((a, b) => Number(b.enabled) - Number(a.enabled) || a.name.localeCompare(b.name));
  }, [overview.mods, filter, search]);

  const selected = overview.mods.find((m) => m.id === selectedId) ?? null;
  useEffect(() => {
    if (!selected && mods.length > 0) setSelectedId(mods[0].id);
  }, [selected, mods]);

  const enabledCount = overview.mods.filter((m) => m.enabled).length;
  const menuMod = menu ? overview.mods.find((m) => m.id === menu.id) : undefined;
  const allPicked = mods.length > 0 && mods.every((m) => picked.has(m.id));
  const togglePick = (id: string) =>
    setPicked((p) => {
      const next = new Set(p);
      if (next.has(id)) next.delete(id);
      else next.add(id);
      return next;
    });

  const bulk = async (action: "enable" | "disable" | "uninstall") => {
    const ids = mods.filter((m) => picked.has(m.id)).map((m) => m.id);
    const label = { enable: "Turning on", disable: "Turning off", uninstall: "Uninstalling" }[action];
    const done = { enable: "turned on", disable: "turned off", uninstall: "uninstalled" }[action];
    const run = () => actions.run(`${label} ${plural(ids.length, "mod")}`, () => api.bulkMods(ids, action), `${plural(ids.length, "mod")} ${done}.`);
    let ok = false;
    if (action === "uninstall") ok = await run();
    else await holdState(ids, action === "enable", async () => (ok = await run()));
    if (ok) {
      setPicked(new Set());
      setConfirmingRemove(false);
    }
  };

  const setEnabled = (m: ModView, on: boolean) =>
    holdState([m.id], on, () =>
      actions.run(on ? `Turning on ${m.name}` : `Turning off ${m.name}`, () => api.setModEnabled(m.id, on)),
    );

  return (
    <div className="flex min-h-0 flex-1 gap-4">
      <div className="flex min-w-0 flex-1 flex-col gap-3.5">
        <ViewHeader
          icon={<Icons.Box />}
          title="Mods"
          subtitle={`${plural(overview.mods.length, "mod")} in your library, ${enabledCount} on`}
        >
          <button type="button" className="btn" aria-pressed={selecting} onClick={() => setSelecting((s) => !s)}>
            <Icons.Check />
            {selecting ? "Done" : "Select"}
          </button>
          <button type="button" className="btn" disabled={!!actions.busy} onClick={() => void pickFolders(actions)}>
            <Icons.Folder />
            Add folder
          </button>
          <button type="button" className="btn btn-primary" disabled={!!actions.busy} onClick={() => void pickMods(actions)}>
            <Icons.Plus />
            Add mod
          </button>
        </ViewHeader>

        {selecting && (
          <div className="flex h-[38px] flex-none items-center gap-2.5 rounded-xl border border-[rgba(91,177,255,.28)] bg-[rgba(91,177,255,.08)] px-3">
            <label className="flex cursor-pointer items-center gap-2.5 text-[12.5px] font-semibold">
              <input
                type="checkbox"
                className="h-4 w-4 accent-[#3b9eff]"
                checked={allPicked}
                onChange={() => setPicked(allPicked ? new Set() : new Set(mods.map((m) => m.id)))}
              />
              {picked.size > 0 ? `${picked.size} selected` : "Select all shown"}
            </label>
            <div className="flex-1" />
            <button type="button" className="btn btn-sm" disabled={picked.size === 0 || !!actions.busy} onClick={() => void bulk("enable")}>
              Turn on
            </button>
            <button type="button" className="btn btn-sm" disabled={picked.size === 0 || !!actions.busy} onClick={() => void bulk("disable")}>
              Turn off
            </button>
            <button
              type="button"
              className="btn btn-sm btn-danger"
              disabled={picked.size === 0 || !!actions.busy}
              onClick={() => {
                if (!confirmingRemove) setConfirmingRemove(true);
                else void bulk("uninstall");
              }}
            >
              {confirmingRemove ? `Uninstall ${plural(picked.size, "mod")}?` : "Uninstall"}
            </button>
          </div>
        )}

        <div className="flex flex-none flex-wrap items-center gap-2" aria-label="Profiles">
          <span className="label mr-1">Profiles</span>
          {overview.profiles.map((p) => (
            <span key={p.name} className="inline-flex items-center">
              <button
                type="button"
                className="chip !rounded-r-none"
                aria-pressed={p.active}
                disabled={!!actions.busy}
                title={`Turn on exactly the ${p.count} mods saved in ${p.name}`}
                onClick={() => void actions.run(`Switching to ${p.name}`, () => api.applyProfile(p.name), `Switched to ${p.name}.`)}
              >
                {p.name} <span className="count">{p.count}</span>
              </button>
              <button
                type="button"
                className="chip !rounded-l-none !border-l-0 !px-2"
                aria-label={`Delete the profile ${p.name}`}
                title="Delete this profile. Your mods aren't touched."
                onClick={() => void api.deleteProfile(p.name).then(actions.refresh)}
              >
                <span className="flex [&_svg]:h-3 [&_svg]:w-3">
                  <Icons.X />
                </span>
              </button>
            </span>
          ))}
          {naming ? (
            <form
              className="flex items-center gap-1.5"
              onSubmit={(e) => {
                e.preventDefault();
                const name = profileName.trim();
                if (!name) return;
                setNaming(false);
                setProfileName("");
                void actions.run("Saving the profile", () => api.saveProfile(name), `Saved ${name}.`);
              }}
            >
              <input
                ref={nameInput}
                value={profileName}
                maxLength={40}
                onChange={(e) => setProfileName(e.target.value)}
                onKeyDown={(e) => e.key === "Escape" && setNaming(false)}
                placeholder="Profile name"
                aria-label="Profile name"
                className="h-[30px] w-[150px] rounded-full border border-[rgba(91,177,255,.35)] bg-[var(--bg-input)] px-3 text-[12px] font-medium text-[var(--text-primary)] outline-none"
              />
              <button type="submit" className="btn btn-sm" disabled={!profileName.trim()}>
                Save
              </button>
              <button type="button" className="btn btn-sm" onClick={() => setNaming(false)}>
                Cancel
              </button>
            </form>
          ) : (
            <button
              type="button"
              className="chip"
              title="Save the mods that are on right now, so you can switch back to them in one click"
              onClick={() => setNaming(true)}
            >
              <span className="flex [&_svg]:h-3 [&_svg]:w-3">
                <Icons.Plus />
              </span>
              Save current setup
            </button>
          )}
        </div>

        {overview.tfc.length > 0 && (
          <section className="nv-card flex flex-none flex-col gap-2 border-[rgba(237,180,86,.28)] p-3">
            <p className="m-0 text-[12px] leading-snug text-[var(--text-muted)]">
              TFC Installer changed your game files. The manager can't install these, but it can put the game back. Removing
              one also removes the ones TFC Installer ran after it.
            </p>
            {overview.tfc.map((t) => (
              <div key={t.number} className="flex items-center gap-3">
                <div className="min-w-0 flex-1">
                  <p className="m-0 truncate text-[13px] font-bold">{t.name}</p>
                  <p className="m-0 mt-0.5 text-[11.5px] text-[var(--text-muted)]">
                    {plural(t.changed, "game file")} changed, {plural(t.added, "file or folder")} added
                  </p>
                </div>
                <button
                  type="button"
                  className={`btn ${confirmTfc === t.number ? "btn-primary" : ""}`}
                  disabled={!!actions.busy}
                  onBlur={() => setConfirmTfc(null)}
                  onClick={async () => {
                    if (confirmTfc !== t.number) return setConfirmTfc(t.number);
                    setConfirmTfc(null);
                    await actions.run(`Removing ${t.name}`, () => api.restoreTfc(t.number), `${t.name} removed. The game files are back.`);
                  }}
                >
                  {confirmTfc === t.number ? "Remove it" : "Remove"}
                </button>
              </div>
            ))}
          </section>
        )}

        <div className="flex flex-wrap items-center gap-2">
          {FILTERS.map((f) => {
            const n = f.kinds.length === 0 ? overview.mods.length : overview.mods.filter((m) => f.kinds.includes(m.kind)).length;
            return (
              <button key={f.id} type="button" className="chip" aria-pressed={filter === f.id} onClick={() => setFilter(f.id)}>
                {f.label} <span className="count">{n}</span>
              </button>
            );
          })}
          <div className="flex-1" />
          <label className="flex h-8 w-[200px] items-center gap-2 rounded-[11px] border border-[rgba(255,255,255,.07)] bg-[var(--bg-input)] px-3 text-[var(--text-muted)] [&_svg]:h-3.5 [&_svg]:w-3.5">
            <Icons.Search />
            <input
              value={search}
              onChange={(e) => setSearch(e.target.value)}
              placeholder="Search mods"
              aria-label="Search mods"
              className="min-w-0 flex-1 border-0 bg-transparent text-[12px] font-medium text-[var(--text-primary)] outline-none"
            />
          </label>
        </div>

        <section className="nv-card flex min-h-0 flex-1 flex-col gap-0.5 p-2">
          <div className="flex min-h-0 flex-1 flex-col gap-0.5 overflow-y-auto" role="listbox" aria-label="Mods">
            {mods.map((m) => (
              <div
                key={m.id}
                role="option"
                tabIndex={0}
                aria-selected={selecting ? picked.has(m.id) : m.id === selectedId}
                className="mod-row cursor-pointer"
                style={{ opacity: m.enabled ? 1 : 0.62 }}
                onContextMenu={(e) => {
                  e.preventDefault();
                  setMenuConfirm(false);
                  setMenu({ x: e.clientX, y: e.clientY, id: m.id });
                }}
                onClick={() => (selecting ? togglePick(m.id) : setSelectedId(m.id))}
                onKeyDown={(e) => {
                  if (e.key === "Enter" || e.key === " ") {
                    e.preventDefault();
                    if (selecting) togglePick(m.id);
                    else setSelectedId(m.id);
                  }
                }}
              >
                {selecting && (
                  <input
                    type="checkbox"
                    tabIndex={-1}
                    aria-label={`Select ${m.name}`}
                    className="pointer-events-none h-4 w-4 flex-none accent-[#3b9eff]"
                    checked={picked.has(m.id)}
                    readOnly
                  />
                )}
                <KindTile kind={m.kind} />
                <div className="min-w-0 flex-1">
                  <p className="m-0 truncate text-[13px] font-bold">{m.name}</p>
                  <p className="m-0 mt-0.5 truncate font-mono text-[11px] text-[var(--text-muted)]">
                    {m.enabled ? m.location : "Off, kept in the library"}
                  </p>
                </div>
                {m.sharesWith.length > 0 && (
                  <span className="badge" style={{ background: "rgba(237,180,86,.12)", color: "#f4cf8e" }} title={`Shares files with ${m.sharesWith.join(", ")}`}>
                    Overlaps
                  </span>
                )}
                {m.nexus?.updateAvailable && (
                  <span
                    className="badge"
                    style={{ background: "rgba(91,177,255,.16)", color: "#9ad0ff" }}
                    title={`Version ${m.nexus.latest} is on Nexus Mods. You have ${m.nexus.installed}.`}
                  >
                    Update
                  </span>
                )}
                <KindBadge kind={m.kind} />
                <Toggle disabled={!!actions.busy} checked={m.enabled} label={`${m.enabled ? "Turn off" : "Turn on"} ${m.name}`} onChange={(on) => void setEnabled(m, on)} />
              </div>
            ))}
            {mods.length === 0 && (
              <p className="m-auto max-w-[320px] text-center text-[12.5px] text-[var(--text-muted)]">
                {overview.mods.length === 0 ? "No mods yet. Drop one below or use Add mod." : "Nothing matches that filter."}
              </p>
            )}
          </div>
          <button type="button" disabled={!!actions.busy} className="drop-zone m-1 h-[52px] flex-none [&_svg]:h-[18px] [&_svg]:w-[18px]" onClick={() => void pickMods(actions)}>
            <Icons.Upload />
            Drop a .zip, .7z, .rar or folder anywhere to install it
          </button>
        </section>
      </div>

      {selected && !selecting ? <ModDetail mod={selected} actions={actions} onToggle={(on) => void setEnabled(selected, on)} /> : null}

      {menu && menuMod && (
        <div
          role="menu"
          className="view-in fixed z-[60] w-[200px] rounded-[14px] border border-[var(--border-strong)] bg-[#101b2e] p-1.5 shadow-[0_18px_40px_-12px_rgba(0,0,0,.7)]"
          style={{ left: Math.min(menu.x, window.innerWidth - 212), top: Math.min(menu.y, window.innerHeight - 200) }}
          onMouseDown={(e) => e.stopPropagation()}
          onContextMenu={(e) => e.preventDefault()}
        >
          <MenuItem
            disabled={!!actions.busy}
            onClick={() => {
              setMenu(null);
              void setEnabled(menuMod, !menuMod.enabled);
            }}
          >
            {menuMod.enabled ? "Turn off" : "Turn on"}
          </MenuItem>
          {(menuMod.kind === "scriptMod" || menuMod.kind === "prebuiltDll" || menuMod.kind === "looseScripts") && (
            <MenuItem
              onClick={() => {
                setMenu(null);
                actions.openLogs(menuMod.name);
              }}
            >
              View logs
            </MenuItem>
          )}
          <MenuItem
            onClick={() => {
              setMenu(null);
              actions.attempt(api.openFolder("mod", menuMod.id), `Opened the folder for ${menuMod.name}`);
            }}
          >
            Open folder
          </MenuItem>
          <div className="mx-1.5 my-1 h-px bg-[var(--border-default)]" />
          <MenuItem
            danger
            disabled={!!actions.busy}
            onClick={() => {
              if (!menuConfirm) {
                setMenuConfirm(true);
                return;
              }
              setMenu(null);
              setMenuConfirm(false);
              void actions.run(`Uninstalling ${menuMod.name}`, () => api.uninstallMod(menuMod.id), `${menuMod.name} was uninstalled.`);
            }}
          >
            {menuConfirm ? "Click again to uninstall" : "Uninstall"}
          </MenuItem>
        </div>
      )}
    </div>
  );
}

function NexusSection({ mod, actions }: { mod: ModView; actions: Actions }) {
  const [text, setText] = useState("");
  const [checking, setChecking] = useState(false);
  useEffect(() => setText(""), [mod.id]);
  const link = mod.nexus;

  const save = (value: string) =>
    actions.run(value.trim() ? "Linking to Nexus Mods" : "Removing the Nexus Mods link", async () => {
      await api.setNexusLink(mod.id, value);
      if (value.trim()) {
        const r = await api.checkNexus();
        if (r.updates.includes(mod.name)) actions.toast(`${mod.name} has a new version on Nexus Mods.`, "info");
      }
    });

  const check = async () => {
    setChecking(true);
    try {
      const r = await api.checkNexus();
      await actions.refresh();
      actions.toast(r.updates.length > 0 ? `New versions on Nexus Mods: ${r.updates.join(", ")}.` : "Everything linked is up to date.", "info");
    } catch (e) {
      actions.toast(errorText(e), "error");
    } finally {
      setChecking(false);
    }
  };

  const small = "btn btn-sm !h-7 !w-7 !px-0";

  return (
    <div className="flex flex-col gap-1.5">
      <div className="flex items-center gap-1.5">
        <p className="label m-0 flex-1">Nexus Mods</p>
        {link && (
          <>
            <button type="button" className={small} aria-label="Open the Nexus Mods page" title="Open the Nexus Mods page" onClick={() => actions.attempt(api.openUrl(link.url), "Opened the Nexus Mods page in your browser")}>
              <Icons.External />
            </button>
            <button type="button" className={small} aria-label="Check for a new version" title="Check Nexus Mods for a new version" disabled={checking} onClick={() => void check()}>
              <SpinIcon active={checking} />
            </button>
            <button type="button" className={small} aria-label="Unlink from Nexus Mods" title="Remove the link to the Nexus Mods page" disabled={!!actions.busy} onClick={() => void save("")}>
              <Icons.X />
            </button>
          </>
        )}
      </div>
      {link ? (
        <>
          <p className="m-0 truncate text-[12px] text-[var(--text-secondary)]" title={link.name ?? undefined}>
            {link.name ? `${link.name}${link.author ? ` by ${link.author}` : ""}` : `Mod page ${link.modId}`}
          </p>
          <div className="flex items-center gap-1.5 text-[11.5px]">
            <span className="text-[var(--text-muted)]">You have</span>
            <span className="font-semibold">{link.installed ? `v${link.installed}` : "?"}</span>
            <span className="text-[var(--text-muted)]">· Latest</span>
            <span className="font-semibold" style={{ color: link.updateAvailable ? "#9ad0ff" : "#7fe9c0" }}>
              {link.latest ? `v${link.latest}` : "?"}
            </span>
          </div>
          {link.updateAvailable && (
            <p className="m-0 rounded-[9px] border border-[rgba(91,177,255,.28)] bg-[rgba(91,177,255,.07)] px-2.5 py-1.5 text-[11px] leading-snug text-[#9ad0ff]">
              New version out. Download it on Nexus and drop the zip here.
            </p>
          )}
        </>
      ) : (
        <form
          className="flex gap-1.5"
          onSubmit={(e) => {
            e.preventDefault();
            if (text.trim()) void save(text);
          }}
        >
          <input
            value={text}
            onChange={(e) => setText(e.target.value)}
            placeholder="Paste the Nexus page link"
            aria-label="Nexus Mods page link"
            className="h-7 min-w-0 flex-1 rounded-[9px] border border-[rgba(255,255,255,.1)] bg-[var(--bg-input)] px-2.5 text-[11.5px] font-medium text-[var(--text-primary)] outline-none focus:border-[rgba(91,177,255,.5)]"
          />
          <button type="submit" className="btn btn-sm" disabled={!text.trim() || !!actions.busy}>
            Link
          </button>
        </form>
      )}
    </div>
  );
}

function MenuItem({
  children,
  onClick,
  disabled,
  danger,
}: {
  children: ReactNode;
  onClick: () => void;
  disabled?: boolean;
  danger?: boolean;
}) {
  return (
    <button
      type="button"
      role="menuitem"
      disabled={disabled}
      onClick={onClick}
      className="flex w-full items-center rounded-[9px] px-2.5 py-[7px] text-left text-[12.5px] font-semibold transition-colors hover:bg-[rgba(91,177,255,.14)] disabled:opacity-40"
      style={{ color: danger ? "#ffa8b4" : "#c2d2ea" }}
    >
      {children}
    </button>
  );
}

function ModDetail({ mod, actions, onToggle }: { mod: ModView; actions: Actions; onToggle: (on: boolean) => void }) {
  const [confirming, setConfirming] = useState(false);
  useEffect(() => setConfirming(false), [mod.id]);
  // Only script mods write to BmSDK.log, so the log shortcut only makes sense for them
  const isScript = mod.kind === "scriptMod" || mod.kind === "prebuiltDll" || mod.kind === "looseScripts";

  return (
    <aside className="nv-card flex min-h-0 w-[290px] flex-none flex-col gap-3 overflow-y-auto p-4">
      <div className="flex flex-none items-center gap-3">
        <KindTile kind={mod.kind} size={44} />
        <div className="min-w-0 flex-1">
          <p className="m-0 font-display text-[16px] font-bold leading-tight [overflow-wrap:anywhere]">{mod.name}</p>
          <div className="mt-1.5 flex flex-wrap items-center gap-1.5">
            <KindBadge kind={mod.kind} />
            {mod.version && <span className="pill !px-2 !py-[2px] text-[10.5px]">v{mod.version}</span>}
          </div>
        </div>
      </div>

      <p className="m-0 line-clamp-3 text-[12px] leading-snug text-[var(--text-secondary)]" title={mod.description}>
        {mod.description}
      </p>

      <div className="flex flex-col gap-1.5 text-[12px]">
        <div className="flex items-center gap-2">
          <span className="label w-[74px] flex-none">Status</span>
          <span className="font-semibold" style={{ color: mod.enabled ? "#7fe9c0" : "#7f93b3" }}>
            {mod.enabled ? "On" : "Off"}
          </span>
          <span className="text-[var(--text-muted)]">· {mod.source}</span>
        </div>
        <div className="flex items-center gap-2">
          <span className="label w-[74px] flex-none">Location</span>
          <span className="min-w-0 flex-1 truncate font-mono text-[11px] text-[var(--text-secondary)]" title={`${mod.enabled ? "Installed to" : "Goes to"} ${mod.location}`}>
            {mod.location}
          </span>
        </div>
        <div className="flex items-center gap-2">
          <span className="label w-[74px] flex-none">Files</span>
          <span className="text-[var(--text-secondary)]">
            {plural(mod.fileCount, "file")} · {formatBytes(mod.size)}
          </span>
        </div>
      </div>

      {mod.sharesWith.length > 0 && (
        <p className="m-0 rounded-[10px] border border-[rgba(237,180,86,.22)] bg-[rgba(237,180,86,.06)] px-2.5 py-1.5 text-[11px] leading-snug text-[#f4cf8e]">
          Some files are also changed by {mod.sharesWith.join(", ")}. The one turned on last wins.
        </p>
      )}

      <div className="border-t border-[var(--border-default)] pt-3">
        <NexusSection mod={mod} actions={actions} />
      </div>

      <div className="flex-1" />

      <div className="flex flex-none flex-col gap-2">
        <div className="flex gap-2">
          <button
            type="button"
            disabled={!!actions.busy}
            className={`btn min-w-0 flex-1 ${mod.enabled ? "" : "btn-primary"}`}
            onClick={() => onToggle(!mod.enabled)}
          >
            {mod.enabled ? "Turn off" : "Turn on"}
          </button>
          <button
            type="button"
            className={`btn btn-danger !w-9 !px-0 ${confirming ? "!w-auto !px-3" : ""}`}
            aria-label={confirming ? "Click again to uninstall" : `Uninstall ${mod.name}`}
            title={confirming ? undefined : "Uninstall this mod"}
            disabled={!!actions.busy}
            onClick={() => {
              if (!confirming) {
                setConfirming(true);
                return;
              }
              void actions.run(`Uninstalling ${mod.name}`, () => api.uninstallMod(mod.id), `${mod.name} was uninstalled.`);
            }}
          >
            <Icons.Trash />
            {confirming && "Sure?"}
          </button>
        </div>
        <div className="grid grid-cols-2 gap-2">
          {isScript ? (
            <button type="button" className="btn" onClick={() => actions.openLogs(mod.name)}>
              <Icons.Logs />
              View logs
            </button>
          ) : null}
          <button
            type="button"
            className={`btn ${isScript ? "" : "col-span-2"}`}
            onClick={() => actions.attempt(api.openFolder("mod", mod.id), `Opened the folder for ${mod.name}`)}
          >
            <Icons.Folder />
            Open folder
          </button>
        </div>
      </div>
    </aside>
  );
}
