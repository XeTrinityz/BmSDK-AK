import { invoke } from "@tauri-apps/api/core";
import { listen } from "@tauri-apps/api/event";

export type Kind =
  | "scriptMod"
  | "prebuiltDll"
  | "looseScripts"
  | "dlc"
  | "replacer"
  | "asiPlugin"
  | "tfcInstaller"
  | "resoRep";

export interface GameView {
  path: string;
  store: string;
  writable: boolean;
  running: boolean;
  sdkVersion: string | null;
  asiLoader: boolean;
}

export interface ModView {
  id: string;
  name: string;
  kind: Kind;
  description: string;
  source: string;
  enabled: boolean;
  location: string;
  fileCount: number;
  size: number;
  sharesWith: string[];
  added: number;
  version: string | null;
  nexus: NexusView | null;
}

export interface NexusView {
  modId: number;
  name: string | null;
  author: string | null;
  latest: string | null;
  installed: string | null;
  url: string;
  updateAvailable: boolean;
}

export interface NexusCheck {
  linked: number;
  updates: string[];
}

export interface Activity {
  time: number;
  level: "info" | "success" | "warning" | "error";
  text: string;
}

export interface BaselineView {
  created: number;
  files: number;
}

export interface BaselineFindings {
  changed: string[];
  missing: string[];
  added: string[];
}

export interface TfcInstall {
  number: number;
  name: string;
  changed: number;
  added: number;
}

export interface Overview {
  managerVersion: string;
  repo: string;
  setupDone: boolean;
  checkOnStart: boolean;
  game: GameView | null;
  mods: ModView[];
  backedUp: number;
  libraryDir: string;
  activity: Activity[];
  profiles: ProfileView[];
  suspended: number;
  logsAlert: LogsAlert;
  tfc: TfcInstall[];
  baseline: BaselineView | null;
}

export interface ProfileView {
  name: string;
  count: number;
  active: boolean;
}

export interface LogsAlert {
  errors: number;
  crash: string | null;
}

export interface GameInstall {
  path: string;
  source: string;
}

export interface Updates {
  latest: string;
  url: string;
  sdkInstalled: string | null;
  sdkUpdate: boolean;
  sdkSize: number;
  managerUpdate: boolean;
}

export interface ReviewMod {
  index: number;
  name: string;
  kind: Kind;
  supported: boolean;
  description: string;
  targets: string[];
  fileCount: number;
  sharesWith: string[];
  backsUp: number;
  replaces: string | null;
  version: string | null;
  installedVersion: string | null;
  versionChange: "newer" | "older" | "same" | null;
}

export interface Review {
  id: string;
  source: string;
  size: number;
  mods: ReviewMod[];
}

export interface Progress {
  task: "sdk" | "manager" | "files" | "mods" | "baseline";
  done: number;
  total: number;
}

export interface LogSource {
  path: string;
  title: string;
  group: "sdk" | "mod" | "crash";
  size: number;
  modified: number;
}

export interface LogText {
  text: string;
  truncated: boolean;
  size: number;
  modified: number;
}

export interface Cleared {
  deleted: number;
  failed: number;
}

/** The backend's marker for "the game folder needs write access first". */
export const NEEDS_ADMIN = "needs_admin";

export const api = {
  overview: () => invoke<Overview>("get_overview"),
  detectGames: () => invoke<GameInstall[]>("detect_games"),
  setGameDir: (path: string) => invoke<number>("set_game_dir", { path }),
  checkUpdates: () => invoke<Updates>("check_updates"),
  installSdk: () => invoke<string>("install_sdk"),
  updateManager: () => invoke<void>("update_manager"),
  grantAccess: () => invoke<boolean>("grant_access"),
  scanPaths: (paths: string[]) => invoke<Review[]>("scan_paths", { paths }),
  installReview: (id: string, indices: number[]) => invoke<void>("install_review", { id, indices }),
  discardReview: (id: string) => invoke<void>("discard_review", { id }),
  setModEnabled: (id: string, enabled: boolean) => invoke<void>("set_mod_enabled", { id, enabled }),
  uninstallMod: (id: string) => invoke<void>("uninstall_mod", { id }),
  bulkMods: (ids: string[], action: "enable" | "disable" | "uninstall") => invoke<number>("bulk_mods", { ids, action }),
  disableAll:() => invoke<number>("disable_all"),
  rescanGame: () => invoke<number>("rescan_game"),
  finishSetup: () => invoke<void>("finish_setup"),
  setCheckOnStart: (value: boolean) => invoke<void>("set_check_on_start", { value }),
  openFolder: (which: "game" | "library" | "backups" | "mod", id?: string) =>
    invoke<void>("open_folder", { which, id }),
  listLogs: () => invoke<LogSource[]>("list_logs"),
  readLog: (path: string) => invoke<LogText>("read_log", { path }),
  clearLogs: () => invoke<Cleared>("clear_logs"),
  revealLog: (path: string) => invoke<void>("reveal_log", { path }),
  librarySize: () => invoke<number>("library_size"),
  saveProfile: (name: string) => invoke<void>("save_profile", { name }),
  applyProfile: (name: string) => invoke<void>("apply_profile", { name }),
  deleteProfile: (name: string) => invoke<void>("delete_profile", { name }),
  playClean: () => invoke<number>("play_clean"),
  createBaseline: () => invoke<number>("create_baseline"),
  recycleAdded: (paths: string[]) => invoke<number>("recycle_added", { paths }),
  checkBaseline: () => invoke<BaselineFindings>("check_baseline"),
  restoreTfc: (number: number) => invoke<number>("restore_tfc", { number }),
  restoreSuspended: () => invoke<number>("restore_suspended"),
  ackLogs: () => invoke<void>("ack_logs"),
  diagnostics: () => invoke<string>("diagnostics"),
  verifyGameFiles: () => invoke<void>("verify_game_files"),
  setNexusLink: (id: string, text: string) => invoke<void>("set_nexus_link", { id, text }),
  checkNexus: () => invoke<NexusCheck>("check_nexus"),
  launchGame: () => invoke<void>("launch_game"),
  openUrl: (url: string) => invoke<void>("open_url", { url }),
};

export const onStateChanged = (handler: () => void) => listen("state-changed", handler);

export const onProgress = (handler: (p: Progress) => void) =>
  listen<Progress>("progress", (e) => handler(e.payload));

export function errorText(e: unknown): string {
  return typeof e === "string" ? e : e instanceof Error ? e.message : String(e);
}
