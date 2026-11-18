import type { ReactNode } from "react";

function Svg({ children, size = 20, width = 2 }: { children: ReactNode; size?: number; width?: number }) {
  return (
    <svg
      width={size}
      height={size}
      viewBox="0 0 24 24"
      fill="none"
      stroke="currentColor"
      strokeWidth={width}
      strokeLinecap="round"
      strokeLinejoin="round"
      aria-hidden="true"
    >
      {children}
    </svg>
  );
}

export const Icons = {
  Home: () => (
    <Svg width={1.8}>
      <path d="M3 11l9-7 9 7" />
      <path d="M5 10v10h14V10" />
      <path d="M10 20v-6h4v6" />
    </Svg>
  ),
  Box: () => (
    <Svg width={1.8}>
      <path d="M12 3l8 4.5v9L12 21l-8-4.5v-9z" />
      <path d="M4 7.5l8 4.5 8-4.5M12 12v9" />
    </Svg>
  ),
  Shield: () => (
    <Svg width={1.8}>
      <path d="M12 3l7 3v6c0 4.5-3 7.5-7 9-4-1.5-7-4.5-7-9V6z" />
    </Svg>
  ),
  Settings: () => (
    <Svg width={1.8}>
      <path d="M12.22 2h-.44a2 2 0 0 0-2 2v.18a2 2 0 0 1-1 1.73l-.43.25a2 2 0 0 1-2 0l-.15-.08a2 2 0 0 0-2.73.73l-.22.38a2 2 0 0 0 .73 2.73l.15.1a2 2 0 0 1 1 1.72v.51a2 2 0 0 1-1 1.74l-.15.09a2 2 0 0 0-.73 2.73l.22.38a2 2 0 0 0 2.73.73l.15-.08a2 2 0 0 1 2 0l.43.25a2 2 0 0 1 1 1.73V20a2 2 0 0 0 2 2h.44a2 2 0 0 0 2-2v-.18a2 2 0 0 1 1-1.73l.43-.25a2 2 0 0 1 2 0l.15.08a2 2 0 0 0 2.73-.73l.22-.39a2 2 0 0 0-.73-2.73l-.15-.08a2 2 0 0 1-1-1.74v-.5a2 2 0 0 1 1-1.74l.15-.09a2 2 0 0 0 .73-2.73l-.22-.38a2 2 0 0 0-2.73-.73l-.15.08a2 2 0 0 1-2 0l-.43-.25a2 2 0 0 1-1-1.73V4a2 2 0 0 0-2-2z" />
      <circle cx="12" cy="12" r="3" />
    </Svg>
  ),
  Code: () => (
    <Svg>
      <path d="M8 6l-6 6 6 6M16 6l6 6-6 6" />
    </Svg>
  ),
  Chip: () => (
    <Svg>
      <rect x="5" y="5" width="14" height="14" rx="2" />
      <path d="M9 2v3M15 2v3M9 19v3M15 19v3M2 9h3M2 15h3M19 9h3M19 15h3" />
    </Svg>
  ),
  FileCode: () => (
    <Svg>
      <path d="M14 3H7a2 2 0 00-2 2v14a2 2 0 002 2h10a2 2 0 002-2V8z" />
      <path d="M14 3v5h5M10 13l-2 2 2 2M14 13l2 2-2 2" />
    </Svg>
  ),
  Shirt: () => (
    <Svg>
      <path d="M8 3l-5 4 3 4 2-1v11h8V10l2 1 3-4-5-4c0 2-2 3-4 3s-4-1-4-3z" />
    </Svg>
  ),
  Swap: () => (
    <Svg>
      <path d="M4 7h13l-3-3M20 17H7l3 3" />
    </Svg>
  ),
  Plug: () => (
    <Svg>
      <path d="M9 2v6M15 2v6M6 8h12v3a6 6 0 01-12 0zM12 17v5" />
    </Svg>
  ),
  Alert: () => (
    <Svg>
      <path d="M12 3l9 16H3z" />
      <path d="M12 10v4M12 17h.01" />
    </Svg>
  ),
  Check: () => (
    <Svg width={2.6}>
      <path d="M5 12l5 5 9-10" />
    </Svg>
  ),
  X: () => (
    <Svg>
      <path d="M6 6l12 12M18 6L6 18" />
    </Svg>
  ),
  Minus: () => (
    <Svg>
      <path d="M5 12h14" />
    </Svg>
  ),
  Plus: () => (
    <Svg width={2.4}>
      <path d="M12 5v14M5 12h14" />
    </Svg>
  ),
  Play: () => (
    <svg width="16" height="16" viewBox="0 0 24 24" fill="currentColor" aria-hidden="true">
      <path d="M7 4.5v15l12-7.5z" />
    </svg>
  ),
  Folder: () => (
    <Svg>
      <path d="M3 7h6l2 2h10v10H3z" />
    </Svg>
  ),
  Refresh: () => (
    <Svg>
      <path d="M20 11a8 8 0 10-2.3 5.7M20 4v7h-7" />
    </Svg>
  ),
  Download: () => (
    <Svg>
      <path d="M12 4v11M7 10l5 5 5-5" />
      <path d="M5 20h14" />
    </Svg>
  ),
  Upload: () => (
    <Svg>
      <path d="M12 15V4M7 9l5-5 5 5" />
      <path d="M4 15v4a1 1 0 001 1h14a1 1 0 001-1v-4" />
    </Svg>
  ),
  Search: () => (
    <Svg>
      <circle cx="11" cy="11" r="7" />
      <path d="M20 20l-3.5-3.5" />
    </Svg>
  ),
  Gamepad: () => (
    <Svg>
      <rect x="2" y="7" width="20" height="11" rx="4" />
      <path d="M7 11v3M5.5 12.5h3M16 12h.01M18 14h.01" />
    </Svg>
  ),
  Archive: () => (
    <Svg>
      <path d="M21 8v13H3V8M1 3h22v5H1zM10 12h4" />
    </Svg>
  ),
  Info: () => (
    <Svg>
      <circle cx="12" cy="12" r="9" />
      <path d="M12 11v5M12 8h.01" />
    </Svg>
  ),
  Spinner: () => (
    <Svg width={2.4}>
      <path d="M12 3a9 9 0 109 9" />
    </Svg>
  ),
  Circle: () => (
    <Svg>
      <circle cx="12" cy="12" r="8" />
    </Svg>
  ),
  Lock: () => (
    <Svg>
      <rect x="4" y="10" width="16" height="11" rx="2" />
      <path d="M8 10V7a4 4 0 018 0v3" />
    </Svg>
  ),
  Trash: () => (
    <Svg>
      <path d="M4 7h16M9 7V4h6v3M6 7l1 13h10l1-13" />
    </Svg>
  ),
  Logs: () => (
    <Svg width={1.8}>
      <path d="M14 3H7a2 2 0 00-2 2v14a2 2 0 002 2h10a2 2 0 002-2V8z" />
      <path d="M14 3v5h5M9 13h6M9 17h6M9 9h2" />
    </Svg>
  ),
  Chevron: () => (
    <Svg width={2.2}>
      <path d="M6 9l6 6 6-6" />
    </Svg>
  ),
  External: () => (
    <Svg>
      <path d="M14 4h6v6M20 4l-9 9M18 14v6H4V6h6" />
    </Svg>
  ),
};
