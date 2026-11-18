import { useEffect, useLayoutEffect, useRef, useState, type ReactNode } from "react";
import type { Kind } from "../api";
import { Icons } from "./Icons";

export type Theme = "blue" | "emerald" | "amber" | "rose" | "cyan" | "purple" | "teal";

export const THEME: Record<Theme, { bg: string; glow: string; soft: string; text: string }> = {
  blue: { bg: "linear-gradient(140deg,#5db1ff,#2f7fff)", glow: "rgba(59,158,255,.55)", soft: "rgba(59,158,255,.12)", text: "#9ad0ff" },
  emerald: { bg: "linear-gradient(140deg,#5ce0b0,#22b582)", glow: "rgba(70,211,154,.5)", soft: "rgba(70,211,154,.12)", text: "#7fe9c0" },
  amber: { bg: "linear-gradient(140deg,#ffd27a,#e2a23a)", glow: "rgba(237,180,86,.45)", soft: "rgba(237,180,86,.12)", text: "#f4cf8e" },
  rose: { bg: "linear-gradient(140deg,#ff7a8c,#e23a55)", glow: "rgba(237,86,108,.5)", soft: "rgba(237,86,108,.12)", text: "#ffa8b4" },
  cyan: { bg: "linear-gradient(140deg,#68e6f0,#22a9c4)", glow: "rgba(52,197,224,.5)", soft: "rgba(52,197,224,.12)", text: "#8fe6f4" },
  purple: { bg: "linear-gradient(140deg,#b79cff,#7a5cff)", glow: "rgba(138,108,255,.5)", soft: "rgba(138,108,255,.14)", text: "#c7b6ff" },
  teal: { bg: "linear-gradient(140deg,#5ce0c8,#22b5a0)", glow: "rgba(52,201,176,.5)", soft: "rgba(52,201,176,.12)", text: "#8fe8d8" },
};

export const KIND_INFO: Record<Kind, { label: string; theme: Theme; icon: () => JSX.Element }> = {
  scriptMod: { label: "Script mod", theme: "blue", icon: Icons.Code },
  prebuiltDll: { label: "Prebuilt DLL", theme: "purple", icon: Icons.Chip },
  looseScripts: { label: "Loose script", theme: "cyan", icon: Icons.FileCode },
  dlc: { label: "Suit / DLC", theme: "emerald", icon: Icons.Shirt },
  replacer: { label: "Replacer", theme: "amber", icon: Icons.Swap },
  asiPlugin: { label: "ASI plugin", theme: "teal", icon: Icons.Plug },
  tfcInstaller: { label: "Not supported", theme: "rose", icon: Icons.Alert },
  resoRep: { label: "Not supported", theme: "rose", icon: Icons.Alert },
};

export function IconTile({
  children,
  theme = "blue",
  size = 40,
  radius = 12,
  iconSize,
}: {
  children: ReactNode;
  theme?: Theme;
  size?: number;
  radius?: number;
  iconSize?: number;
}) {
  const t = THEME[theme];
  const inner = iconSize ?? Math.round(size * 0.46);
  return (
    <div
      className="flex flex-none items-center justify-center text-white"
      style={{
        width: size,
        height: size,
        borderRadius: radius,
        background: t.bg,
        boxShadow: `0 6px 16px -6px ${t.glow}, inset 0 1px 0 rgba(255,255,255,.3)`,
      }}
    >
      <span className="flex [&>svg]:h-[var(--s)] [&>svg]:w-[var(--s)]" style={{ ["--s" as string]: `${inner}px` }}>
        {children}
      </span>
    </div>
  );
}

export function KindTile({ kind, size = 34 }: { kind: Kind; size?: number }) {
  const info = KIND_INFO[kind];
  return (
    <IconTile theme={info.theme} size={size} radius={Math.round(size / 3)}>
      <info.icon />
    </IconTile>
  );
}

export function KindBadge({ kind }: { kind: Kind }) {
  const info = KIND_INFO[kind];
  const t = THEME[info.theme];
  return (
    <span className="badge" style={{ background: t.soft, color: t.text }}>
      {info.label}
    </span>
  );
}

export function ViewHeader({
  icon,
  title,
  subtitle,
  children,
}: {
  icon: ReactNode;
  title: string;
  subtitle: string;
  children?: ReactNode;
}) {
  return (
    <div className="flex flex-none items-center gap-3">
      <div className="flex h-11 w-11 flex-none items-center justify-center rounded-2xl border border-[rgba(91,177,255,.22)] bg-[var(--accent-soft)] text-[#5db1ff] shadow-[0_8px_22px_-12px_rgba(59,158,255,.7)] [&_svg]:h-5 [&_svg]:w-5">
        {icon}
      </div>
      <div className="min-w-0 flex-1">
        <h1 className="m-0 truncate text-[19px] font-bold leading-tight tracking-[-0.2px]">{title}</h1>
        <p className="m-0 mt-0.5 truncate text-[12px] text-[var(--text-muted)]">{subtitle}</p>
      </div>
      {children}
    </div>
  );
}

export function Toggle({
  checked,
  onChange,
  label,
  disabled,
}: {
  checked: boolean;
  onChange: (value: boolean) => void;
  label: string;
  disabled?: boolean;
}) {
  return (
    <button
      type="button"
      role="switch"
      className="toggle"
      aria-checked={checked}
      aria-label={label}
      disabled={disabled}
      onClick={(e) => {
        e.stopPropagation();
        onChange(!checked);
      }}
    >
      <span />
    </button>
  );
}

export function ProgressBar({ done, total }: { done: number; total: number }) {
  const indeterminate = total <= 0;
  const pct = indeterminate ? 0 : Math.min(100, (done / total) * 100);
  return (
    <div className="progress-track" role="progressbar" aria-valuenow={indeterminate ? undefined : Math.round(pct)}>
      <div className="progress-fill" data-indeterminate={indeterminate} style={{ width: `${pct}%` }} />
    </div>
  );
}

export function formatBytes(bytes: number): string {
  if (bytes < 1024) return `${bytes} B`;
  const units = ["KB", "MB", "GB"];
  let value = bytes / 1024;
  let unit = 0;
  while (value >= 1024 && unit < units.length - 1) {
    value /= 1024;
    unit++;
  }
  return `${value < 10 ? value.toFixed(1) : Math.round(value)} ${units[unit]}`;
}

export function formatTime(unixSeconds: number): string {
  const date = new Date(unixSeconds * 1000);
  const today = new Date();
  return date.toDateString() === today.toDateString()
    ? date.toLocaleTimeString([], { hour: "2-digit", minute: "2-digit" })
    : date.toLocaleDateString([], { day: "numeric", month: "short" });
}

export function plural(n: number, word: string) {
  return `${n} ${word}${n === 1 ? "" : "s"}`;
}

/**
 * A refresh arrow that turns while `active`, and always finishes the turn it's on.
 * A task that completes early still gets one full rotation, so the click is visible.
 */
export function SpinIcon({ active }: { active: boolean }) {
  const [turning, setTurning] = useState(false);
  const activeRef = useRef(active);
  activeRef.current = active;

  useEffect(() => {
    if (active) setTurning(true);
  }, [active]);

  return (
    <span
      className={`flex ${turning ? "spin-turn" : ""}`}
      onAnimationIteration={() => {
        if (!activeRef.current) setTurning(false);
      }}
    >
      <Icons.Refresh />
    </span>
  );
}

export interface SelectOption {
  value: string;
  label: string;
}

/** A dropdown in the app's own style, replacing the browser's plain one. */
export function Select({
  value,
  options,
  onChange,
  label,
  className = "",
}: {
  value: string;
  options: SelectOption[];
  onChange: (value: string) => void;
  label: string;
  className?: string;
}) {
  const [open, setOpen] = useState(false);
  const [active, setActive] = useState(0);
  const root = useRef<HTMLDivElement>(null);
  const selectedIndex = Math.max(0, options.findIndex((o) => o.value === value));

  useEffect(() => {
    if (!open) return;
    const close = (e: MouseEvent) => {
      if (!root.current?.contains(e.target as Node)) setOpen(false);
    };
    document.addEventListener("mousedown", close);
    return () => document.removeEventListener("mousedown", close);
  }, [open]);

  const show = () => {
    setActive(selectedIndex);
    setOpen(true);
  };
  const pick = (i: number) => {
    onChange(options[i].value);
    setOpen(false);
  };

  const onKeyDown = (e: React.KeyboardEvent) => {
    if (e.key === "Escape") {
      setOpen(false);
    } else if (e.key === "ArrowDown" || e.key === "ArrowUp") {
      e.preventDefault();
      if (!open) return show();
      setActive((a) => (a + (e.key === "ArrowDown" ? 1 : options.length - 1)) % options.length);
    } else if (e.key === "Enter" || e.key === " ") {
      e.preventDefault();
      if (open) pick(active);
      else show();
    }
  };

  return (
    <div ref={root} className={`relative ${className}`}>
      <button
        type="button"
        aria-label={label}
        aria-haspopup="listbox"
        aria-expanded={open}
        className="flex h-8 w-full items-center gap-2 rounded-[11px] border bg-[var(--bg-input)] pl-3 pr-2 text-[12px] font-semibold text-[var(--text-secondary)] transition-colors hover:text-[var(--text-primary)]"
        style={{ borderColor: open ? "rgba(91,177,255,.45)" : "rgba(255,255,255,.07)" }}
        onClick={() => (open ? setOpen(false) : show())}
        onKeyDown={onKeyDown}
      >
        <span className="min-w-0 flex-1 truncate text-left">{options[selectedIndex]?.label}</span>
        <span className="flex text-[var(--text-muted)] transition-transform duration-200 [&_svg]:h-3.5 [&_svg]:w-3.5" style={{ transform: open ? "rotate(180deg)" : "none" }}>
          <Icons.Chevron />
        </span>
      </button>
      {open && (
        <div
          role="listbox"
          aria-label={label}
          className="view-in absolute right-0 top-[calc(100%+6px)] z-50 max-h-[260px] w-max min-w-full max-w-[280px] overflow-y-auto rounded-[14px] border border-[var(--border-strong)] bg-[#101b2e] p-1.5 shadow-[0_18px_40px_-12px_rgba(0,0,0,.7)]"
        >
          {options.map((o, i) => (
            <button
              key={o.value}
              type="button"
              role="option"
              aria-selected={o.value === value}
              className="flex w-full items-center gap-3 rounded-[9px] px-2.5 py-[7px] text-left text-[12.5px] font-semibold transition-colors"
              style={{
                background: i === active ? "rgba(91,177,255,.14)" : "transparent",
                color: o.value === value ? "#cfe6ff" : "#c2d2ea",
              }}
              onMouseEnter={() => setActive(i)}
              onClick={() => pick(i)}
            >
              <span className="min-w-0 flex-1 truncate">{o.label}</span>
              <span className="flex w-3.5 flex-none text-[#5db1ff] [&_svg]:h-3.5 [&_svg]:w-3.5" style={{ opacity: o.value === value ? 1 : 0 }}>
                <Icons.Check />
              </span>
            </button>
          ))}
        </div>
      )}
    </div>
  );
}

const TIP_GAP = 10;
const TIP_MARGIN = 8;

/**
 * Replaces the browser's plain tooltips. Anything with a `title` attribute gets this one instead: the title
 * moves to `data-tip` the first time it's hovered, so the browser never draws its own. Mount it once.
 */
export function Tooltips() {
  const [tip, setTip] = useState<{ text: string; rect: DOMRect } | null>(null);
  const [pos, setPos] = useState<{ left: number; top: number; below: boolean; arrow: number } | null>(null);
  const bubble = useRef<HTMLDivElement>(null);

  useEffect(() => {
    let timer: number | undefined;
    let anchor: Element | null = null;
    let visible = false;

    const hide = () => {
      window.clearTimeout(timer);
      anchor = null;
      visible = false;
      setTip(null);
      setPos(null);
    };

    const show = (el: Element, delay: number) => {
      const text = el.getAttribute("data-tip");
      if (!text) return;
      window.clearTimeout(timer);
      anchor = el;
      timer = window.setTimeout(() => {
        if (!el.isConnected) return hide();
        visible = true;
        setPos(null);
        setTip({ text, rect: el.getBoundingClientRect() });
      }, delay);
    };

    const over = (e: Event) => {
      const el = (e.target as Element | null)?.closest?.("[title],[data-tip]") ?? null;
      if (!el) return;
      // Taking the title away stops the browser from showing its own tooltip
      const title = el.getAttribute("title");
      if (title) {
        el.setAttribute("data-tip", title);
        el.removeAttribute("title");
      }
      if (el !== anchor) show(el, visible ? 60 : e.type === "focusin" ? 150 : 400);
    };

    const out = (e: Event) => {
      const el = (e.target as Element | null)?.closest?.("[data-tip]");
      if (el && el === anchor) hide();
    };

    document.addEventListener("mouseover", over);
    document.addEventListener("focusin", over);
    document.addEventListener("mouseout", out);
    document.addEventListener("focusout", out);
    document.addEventListener("mousedown", hide);
    document.addEventListener("keydown", hide);
    window.addEventListener("wheel", hide, { passive: true });
    window.addEventListener("blur", hide);
    return () => {
      window.clearTimeout(timer);
      document.removeEventListener("mouseover", over);
      document.removeEventListener("focusin", over);
      document.removeEventListener("mouseout", out);
      document.removeEventListener("focusout", out);
      document.removeEventListener("mousedown", hide);
      document.removeEventListener("keydown", hide);
      window.removeEventListener("wheel", hide);
      window.removeEventListener("blur", hide);
    };
  }, []);

  // Measure the bubble before it's shown, so it never flashes in the wrong spot and always stays inside the window
  useLayoutEffect(() => {
    const el = bubble.current;
    if (!tip || !el) return;
    const w = el.offsetWidth;
    const h = el.offsetHeight;
    const { rect } = tip;
    const below = rect.top - TIP_GAP - h < TIP_MARGIN;
    const centre = rect.left + rect.width / 2;
    const left = Math.min(Math.max(TIP_MARGIN, centre - w / 2), window.innerWidth - w - TIP_MARGIN);
    const top = below ? rect.bottom + TIP_GAP : rect.top - TIP_GAP - h;
    // The arrow keeps pointing at the element even when the bubble was pushed away from a window edge
    setPos({ left, top, below, arrow: Math.min(Math.max(12, centre - left), w - 12) });
  }, [tip]);

  if (!tip) return null;
  return (
    <div
      ref={bubble}
      role="tooltip"
      className="tooltip-bubble"
      style={{
        left: pos?.left ?? 0,
        top: pos?.top ?? 0,
        visibility: pos ? "visible" : "hidden",
      }}
    >
      {tip.text}
      {pos && (
        <span
          aria-hidden="true"
          className="tooltip-arrow"
          style={pos.below ? { top: -5, left: pos.arrow - 5 } : { bottom: -5, left: pos.arrow - 5 }}
        />
      )}
    </div>
  );
}
