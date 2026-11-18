use crate::detect::{self, Detected, Kind};
use serde::{Deserialize, Serialize};
use std::fs;
use std::path::{Path, PathBuf};
use std::time::{SystemTime, UNIX_EPOCH};

/// Where the game's own files go while a mod replaces them. Same drive as the game, so moves are instant.
pub const BACKUP_DIR: &str = "BmSDK Manager Backups";

/// Folders that stay even when a mod leaves them empty.
const KEEP_DIRS: [&str; 3] = ["binaries/win64/plugins", "binaries/win64/sdk", "bmgame/scriptsdev"];

#[derive(Serialize, Deserialize, Clone)]
#[serde(rename_all = "camelCase")]
pub struct ModRecord {
    pub id: String,
    pub name: String,
    pub kind: Kind,
    pub description: String,
    pub source: String,
    /// Game-relative paths with `/`.
    pub files: Vec<String>,
    pub enabled: bool,
    pub added: u64,
    /// Orders enabled mods that share a file. The highest one's copy is in the game.
    pub enabled_at: u64,
    #[serde(default)]
    pub nexus: Option<NexusLink>,
}

#[derive(Serialize, Deserialize, Clone, Default)]
#[serde(rename_all = "camelCase", default)]
pub struct NexusLink {
    pub mod_id: u32,
    pub name: Option<String>,
    pub author: Option<String>,
    /// The version Nexus lists now.
    pub latest: Option<String>,
    /// The version the user has, from the download's file name, the mod's own file, or the latest when neither is known.
    pub installed: Option<String>,
    pub fetched: u64,
}

#[derive(Serialize, Deserialize, Clone)]
pub struct Profile {
    pub name: String,
    /// Mod ids in the order they get turned on.
    pub mods: Vec<String>,
}

#[derive(Serialize, Deserialize, Clone)]
pub struct Activity {
    pub time: u64,
    pub level: String,
    pub text: String,
}

#[derive(Serialize, Deserialize)]
#[serde(rename_all = "camelCase", default)]
pub struct State {
    pub game_dir: Option<String>,
    pub setup_done: bool,
    pub check_on_start: bool,
    pub mods: Vec<ModRecord>,
    /// Game files that were moved into the backup folder.
    pub originals: Vec<String>,
    pub activity: Vec<Activity>,
    pub counter: u64,
    pub profiles: Vec<Profile>,
    /// Mods turned off for a launch without mods, waiting to be turned back on.
    pub suspended: Vec<String>,
    /// When the user last looked at crash reports and the BmSDK log.
    pub crash_seen: u64,
    pub log_seen: u64,
}

impl Default for State {
    fn default() -> Self {
        Self {
            game_dir: None,
            setup_done: false,
            check_on_start: true,
            mods: Vec::new(),
            originals: Vec::new(),
            activity: Vec::new(),
            counter: 0,
            profiles: Vec::new(),
            suspended: Vec::new(),
            crash_seen: 0,
            log_seen: 0,
        }
    }
}

pub fn now() -> u64 {
    SystemTime::now().duration_since(UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0)
}

pub fn data_dir() -> PathBuf {
    let base = std::env::var_os("LOCALAPPDATA").map(PathBuf::from).unwrap_or_else(std::env::temp_dir);
    base.join("BmSDK Manager")
}

pub fn library_dir() -> PathBuf {
    data_dir().join("Library")
}

pub fn staging_dir() -> PathBuf {
    data_dir().join("Staging")
}

fn state_path() -> PathBuf {
    data_dir().join("state.json")
}

fn eq(a: &str, b: &str) -> bool {
    a.eq_ignore_ascii_case(b)
}

fn to_native(rel: &str) -> PathBuf {
    rel.split('/').collect()
}

impl State {
    pub fn load() -> State {
        let path = state_path();
        let Ok(bytes) = fs::read(&path) else { return State::default() };
        serde_json::from_slice(&bytes).unwrap_or_else(|_| {
            // Starting fresh overwrites the file on the next save, so what was there is kept beside it
            let kept = fs::copy(&path, path.with_extension("json.bad")).is_ok();
            let mut state = State::default();
            state.log(
                "error",
                if kept {
                    "The manager's saved list couldn't be read, so it started fresh. The old file is kept as state.json.bad."
                } else {
                    "The manager's saved list couldn't be read, so it started fresh."
                },
            );
            state
        })
    }

    pub fn save(&self) -> Result<(), String> {
        let path = state_path();
        fs::create_dir_all(data_dir()).map_err(|e| e.to_string())?;
        let tmp = path.with_extension("json.tmp");
        fs::write(&tmp, serde_json::to_vec_pretty(self).map_err(|e| e.to_string())?).map_err(|e| e.to_string())?;
        fs::rename(&tmp, &path).map_err(|e| e.to_string())
    }

    pub fn log(&mut self, level: &str, text: impl Into<String>) {
        self.activity.push(Activity { time: now(), level: level.into(), text: text.into() });
        let excess = self.activity.len().saturating_sub(60);
        self.activity.drain(..excess);
    }

    pub fn next_id(&mut self) -> String {
        self.counter += 1;
        format!("{}-{}", now(), self.counter)
    }

    fn tick(&mut self) -> u64 {
        self.counter += 1;
        self.counter
    }

    pub fn game(&self) -> Result<PathBuf, String> {
        self.game_dir.as_ref().map(PathBuf::from).ok_or_else(|| "Pick your game folder first.".to_string())
    }

    pub fn find(&self, id: &str) -> Result<usize, String> {
        self.mods.iter().position(|m| m.id == id).ok_or_else(|| "That mod isn't in the library any more.".to_string())
    }

    /// The enabled mod whose copy of `rel` is in the game, ignoring `except`.
    pub fn top_owner(&self, rel: &str, except: Option<&str>) -> Option<&ModRecord> {
        self.mods
            .iter()
            .filter(|m| m.enabled && Some(m.id.as_str()) != except && m.files.iter().any(|f| eq(f, rel)))
            .max_by_key(|m| m.enabled_at)
    }

    fn is_original(&self, rel: &str) -> bool {
        self.originals.iter().any(|o| eq(o, rel))
    }

    /// Points profiles at the new copy of a mod that was updated. An update gets a new id, and a profile
    /// still naming the old one would turn the mod off the next time it's applied.
    pub fn replace_in_profiles(&mut self, old: &str, new: &str) {
        for id in self.profiles.iter_mut().flat_map(|p| p.mods.iter_mut()).filter(|id| *id == old) {
            *id = new.to_string();
        }
    }
}

pub struct Deployer<'a> {
    pub state: &'a mut State,
    pub game: PathBuf,
}

impl Deployer<'_> {
    fn lib_file(id: &str, rel: &str) -> PathBuf {
        library_dir().join(id).join(to_native(rel))
    }

    fn game_file(&self, rel: &str) -> PathBuf {
        self.game.join(to_native(rel))
    }

    fn backup_file(&self, rel: &str) -> PathBuf {
        self.game.join(BACKUP_DIR).join(to_native(rel))
    }

    /// Makes sure the mod whose file is in the game also has it in the library, before it gets overwritten.
    fn preserve(&self, owner_id: &str, rel: &str) -> Result<(), String> {
        let lib = Self::lib_file(owner_id, rel);
        let target = self.game_file(rel);
        if self.game_copy_wins(rel, &target, &lib) {
            copy_file(&target, &lib)?;
        }
        Ok(())
    }

    /// True when the copy in the game should go into the library: the library has none, or the file was
    /// changed in the game since it was put there, like a plugin's .ini or a script someone is working on.
    /// A file that replaced one of the game's own never counts as changed. Steam puts its own copy back
    /// there when it verifies or updates the game, and that must not end up as the mod's file.
    fn game_copy_wins(&self, rel: &str, target: &Path, lib: &Path) -> bool {
        let Ok(in_game) = fs::metadata(target) else { return false };
        let Ok(in_lib) = fs::metadata(lib) else { return true };
        // Copies keep the modified time, so an untouched file matches on both
        !self.state.is_original(rel) && (in_game.len() != in_lib.len() || in_game.modified().ok() != in_lib.modified().ok())
    }

    pub fn enable(&mut self, id: &str) -> Result<(), String> {
        let index = self.state.find(id)?;
        if self.state.mods[index].enabled {
            return Ok(());
        }
        let files = self.state.mods[index].files.clone();

        let mut done: Vec<String> = Vec::new();
        let result = files.iter().try_for_each(|rel| {
            self.put_file(id, rel)?;
            done.push(rel.clone());
            Ok::<(), String>(())
        });

        if let Err(e) = result {
            // Put everything back the way it was before this mod
            for rel in done.iter().rev() {
                let _ = self.restore_below(rel, id);
            }
            return Err(e);
        }

        let order = self.state.tick();
        let m = &mut self.state.mods[index];
        m.enabled = true;
        m.enabled_at = order;
        Ok(())
    }

    fn put_file(&mut self, id: &str, rel: &str) -> Result<(), String> {
        let src = Self::lib_file(id, rel);
        if !src.is_file() {
            return Err(format!("{rel} is missing from the mod library."));
        }
        let target = self.game_file(rel);

        if let Some(owner) = self.state.top_owner(rel, Some(id)) {
            self.preserve(&owner.id.clone(), rel)?;
        } else if target.exists() && !self.state.is_original(rel) {
            move_file(&target, &self.backup_file(rel))?;
            self.state.originals.push(rel.to_string());
        }

        copy_file(&src, &target)
    }

    pub fn disable(&mut self, id: &str) -> Result<(), String> {
        let index = self.state.find(id)?;
        if !self.state.mods[index].enabled {
            return Ok(());
        }
        let files = self.state.mods[index].files.clone();
        let my_order = self.state.mods[index].enabled_at;

        let mut gone: Vec<&String> = Vec::new();
        let mut done: Vec<&String> = Vec::new();
        for rel in &files {
            let newer_owner = self.state.top_owner(rel, Some(id)).is_some_and(|o| o.enabled_at > my_order);
            if newer_owner {
                // A newer mod's copy is in the game. Ours was kept in the library when it got overwritten.
                continue;
            }
            let lib = Self::lib_file(id, rel);
            let target = self.game_file(rel);
            let result = if self.game_copy_wins(rel, &target, &lib) { move_file(&target, &lib) } else { Ok(()) };
            if let Err(e) = result.and_then(|()| self.restore_below(rel, id)) {
                // Stopping here would leave the mod on with some of its files already swapped back, and the next
                // try would take the game files put back for it as the mod's own. So it goes back to fully on.
                if !target.exists() {
                    let _ = self.put_file(id, rel);
                }
                for rel in done.iter().rev() {
                    let _ = self.put_file(id, rel);
                }
                return Err(e);
            }
            // Deleted in the game before the library ever had a copy. Turning the mod on would fail on it.
            if !lib.is_file() {
                gone.push(rel);
            }
            done.push(rel);
        }

        let m = &mut self.state.mods[index];
        m.enabled = false;
        m.files.retain(|f| !gone.contains(&f));
        Ok(())
    }

    /// Puts back whatever was in the game under this mod's copy of `rel`.
    fn restore_below(&mut self, rel: &str, id: &str) -> Result<(), String> {
        let target = self.game_file(rel);

        if let Some(owner) = self.state.top_owner(rel, Some(id)) {
            return copy_file(&Self::lib_file(&owner.id, rel), &target);
        }

        if self.state.is_original(rel) {
            let backup = self.backup_file(rel);
            if backup.exists() {
                move_file(&backup, &target)?;
                prune_empty(backup.parent(), &self.game.join(BACKUP_DIR), 0, &[]);
            }
            self.state.originals.retain(|o| !eq(o, rel));
            return Ok(());
        }

        if target.exists() {
            make_writable(&target);
            fs::remove_file(&target).map_err(|e| format!("Couldn't remove {rel}: {e}"))?;
        }
        // Folders like BmGame\Mods and DLC\356474 sit two deep and always stay
        prune_empty(target.parent(), &self.game, 3, &KEEP_DIRS);
        Ok(())
    }

    pub fn uninstall(&mut self, id: &str) -> Result<(), String> {
        self.disable(id)?;
        let index = self.state.find(id)?;
        discard(&library_dir().join(id));
        self.state.mods.remove(index);
        Ok(())
    }

    /// Copies a detected mod into the library and turns it on.
    pub fn add(&mut self, staged: &Path, found: &Detected, source: &str, on_file: &mut dyn FnMut()) -> Result<String, String> {
        let id = self.state.next_id();
        let lib = library_dir().join(&id);

        for m in &found.files {
            if let Err(e) = copy_file(&staged.join(to_native(&m.src)), &lib.join(to_native(&m.dest))) {
                let _ = fs::remove_dir_all(&lib);
                return Err(e);
            }
            on_file();
        }

        self.state.mods.push(ModRecord {
            id: id.clone(),
            name: found.name.clone(),
            kind: found.kind,
            description: found.description.clone(),
            source: source.to_string(),
            files: found.files.iter().map(|m| m.dest.clone()).collect(),
            enabled: false,
            added: now(),
            enabled_at: 0,
            nexus: None,
        });

        if let Err(e) = self.enable(&id) {
            let _ = fs::remove_dir_all(&lib);
            self.state.mods.retain(|m| m.id != id);
            return Err(e);
        }
        Ok(id)
    }
}

/// Finds mods already in the game that the manager doesn't know about yet.
pub fn import_existing(state: &mut State, game: &Path) -> usize {
    let owned = |state: &State, rel: &str| state.mods.iter().any(|m| m.files.iter().any(|f| eq(f, rel)));
    let mut found: Vec<(String, Kind, String, Vec<String>)> = Vec::new();

    let under = |dir: &Path, prefix: &str| -> Vec<String> {
        detect::list_files(dir).into_iter().map(|f| format!("{prefix}/{f}")).collect()
    };

    for entry in read_dirs(&game.join("BmGame").join("Mods")) {
        let toml_path = entry.join("mod.toml");
        if !toml_path.is_file() {
            continue;
        }
        let folder = entry.file_name().unwrap_or_default().to_string_lossy().to_string();
        let toml = detect::read_mod_toml(&toml_path);
        let prebuilt = toml.assembly.as_ref().is_some_and(|a| entry.join(a).is_file());
        found.push((
            toml.name.unwrap_or_else(|| folder.clone()),
            if prebuilt { Kind::PrebuiltDll } else { Kind::ScriptMod },
            toml.description.unwrap_or_else(|| "BmSDK script mod".into()),
            under(&entry, &format!("BmGame/Mods/{folder}")),
        ));
    }

    for file in read_files(&game.join("BmGame").join("Scripts")) {
        let name = file.file_name().unwrap_or_default().to_string_lossy().to_string();
        if name.to_ascii_lowercase().ends_with(".cs") {
            found.push((name.clone(), Kind::LooseScripts, "BmSDK script".into(), vec![format!("BmGame/Scripts/{name}")]));
        }
    }

    // Folders TFC Installer made are listed with its own entry, so they are not picked up as separate mods
    let tfc_made = crate::tfc::made_folders(game);
    for number in read_dirs(&game.join("DLC")) {
        let n = number.file_name().unwrap_or_default().to_string_lossy().to_string();
        if !n.bytes().all(|b| b.is_ascii_digit()) {
            continue;
        }
        for entry in read_dirs(&number) {
            let folder = entry.file_name().unwrap_or_default().to_string_lossy().to_string();
            if eq(&folder, "Content") || tfc_made.contains(&format!("dlc/{n}/{folder}").to_ascii_lowercase()) {
                continue;
            }
            let files = under(&entry, &format!("DLC/{n}/{folder}"));
            let count = files.len();
            found.push((folder, Kind::Dlc, format!("Suit or DLC content, {count} files"), files));
        }
    }

    for (dir, prefix) in [
        (game.join("Binaries").join("Win64").join("plugins"), "Binaries/Win64/plugins"),
        (game.join("Binaries").join("Win64"), "Binaries/Win64"),
    ] {
        for file in read_files(&dir) {
            let name = file.file_name().unwrap_or_default().to_string_lossy().to_string();
            let lower = name.to_ascii_lowercase();
            if !lower.ends_with(".asi") || lower.starts_with("bmsdk") {
                continue;
            }
            let stem = &name[..name.len() - 4];
            let mut files = vec![format!("{prefix}/{name}")];
            if dir.join(format!("{stem}.ini")).is_file() {
                files.push(format!("{prefix}/{stem}.ini"));
            }
            found.push((stem.to_string(), Kind::AsiPlugin, "ASI plugin loaded by the ASI loader".into(), files));
        }
    }

    let mut added = 0;
    for (name, kind, description, files) in found {
        if files.is_empty() || files.iter().any(|f| owned(state, f)) {
            continue;
        }
        let id = state.next_id();
        let order = state.tick();
        state.mods.push(ModRecord {
            id,
            name,
            kind,
            description,
            source: "Found in game".into(),
            files,
            enabled: true,
            added: now(),
            enabled_at: order,
            nexus: None,
        });
        added += 1;
    }
    added
}

/// Gets rid of an uninstalled mod's files. They go to the Recycle Bin when there is one, because for a mod
/// that was found in the game this is the only copy, and it can be a whole folder someone is working in.
fn discard(dir: &Path) {
    // Tests would fill the real Recycle Bin
    #[cfg(all(windows, not(test)))]
    if crate::winapi::recycle(dir) {
        return;
    }
    let _ = fs::remove_dir_all(dir);
}

fn read_dirs(dir: &Path) -> Vec<PathBuf> {
    let mut v: Vec<PathBuf> = fs::read_dir(dir).into_iter().flatten().flatten().map(|e| e.path()).filter(|p| p.is_dir()).collect();
    v.sort();
    v
}

fn read_files(dir: &Path) -> Vec<PathBuf> {
    let mut v: Vec<PathBuf> = fs::read_dir(dir).into_iter().flatten().flatten().map(|e| e.path()).filter(|p| p.is_file()).collect();
    v.sort();
    v
}

fn make_writable(path: &Path) {
    if let Ok(meta) = fs::metadata(path) {
        let mut perms = meta.permissions();
        if perms.readonly() {
            #[allow(clippy::permissions_set_readonly_false)]
            perms.set_readonly(false);
            let _ = fs::set_permissions(path, perms);
        }
    }
}

pub fn copy_file(from: &Path, to: &Path) -> Result<(), String> {
    if let Some(parent) = to.parent() {
        fs::create_dir_all(parent).map_err(|e| e.to_string())?;
    }
    make_writable(to);
    fs::copy(from, to).map(|_| ()).map_err(|e| format!("Couldn't copy to {}: {e}", to.display()))
}

fn move_file(from: &Path, to: &Path) -> Result<(), String> {
    if let Some(parent) = to.parent() {
        fs::create_dir_all(parent).map_err(|e| e.to_string())?;
    }
    make_writable(from);
    make_writable(to);
    if fs::rename(from, to).is_ok() {
        return Ok(());
    }
    // Different drives: copy, then delete
    fs::copy(from, to).map_err(|e| format!("Couldn't move {}: {e}", from.display()))?;
    fs::remove_file(from).map_err(|e| format!("Couldn't move {}: {e}", from.display()))
}

/// Removes empty folders from `dir` upwards while they sit at least `min_depth` below `stop` and aren't in `keep`.
fn prune_empty(dir: Option<&Path>, stop: &Path, min_depth: usize, keep: &[&str]) {
    let mut cur = dir.map(Path::to_path_buf);
    while let Some(d) = cur {
        let Ok(rel) = d.strip_prefix(stop) else { break };
        let rel_text = rel.to_string_lossy().replace('\\', "/").to_ascii_lowercase();
        if rel.components().count() < min_depth || keep.contains(&rel_text.as_str()) || fs::remove_dir(&d).is_err() {
            break;
        }
        cur = d.parent().map(Path::to_path_buf);
    }
}

/// The version a script mod declares in its mod.toml, if it has one.
pub fn version_of(m: &ModRecord, game: Option<&Path>) -> Option<String> {
    let rel = detect::mod_toml_path(m.files.iter().map(String::as_str))?;
    let lib = library_dir().join(&m.id).join(to_native(rel));
    let path = if lib.is_file() { lib } else { game?.join(to_native(rel)) };
    detect::read_mod_toml(&path).version
}

/// A short "where it lives" line for the UI, with Windows separators.
pub fn location(m: &ModRecord) -> String {
    let first = m.files.first().map(String::as_str).unwrap_or_default();
    let segs: Vec<&str> = first.split('/').collect();
    let text = match m.kind {
        Kind::ScriptMod | Kind::PrebuiltDll | Kind::Dlc if segs.len() >= 3 => segs[..3].join("/"),
        Kind::LooseScripts | Kind::AsiPlugin => segs[..segs.len().saturating_sub(1)].join("/"),
        _ => {
            let mut tops: Vec<&str> = m.files.iter().filter_map(|f| f.split('/').next()).collect();
            tops.sort_unstable();
            tops.dedup();
            return format!("{} files in {}", m.files.len(), tops.join(", "));
        }
    };
    text.replace('/', "\\")
}

// Tests that point LOCALAPPDATA at a temp folder share this, so they never overlap
#[cfg(test)]
pub(crate) static ENV_LOCK: std::sync::Mutex<()> = std::sync::Mutex::new(());

#[cfg(test)]
mod tests {
    use super::*;
    use crate::detect::Mapping;

    // Runs in a temp LOCALAPPDATA so the library lands there too. The lock keeps tests from sharing it.
    fn setup() -> (std::sync::MutexGuard<'static, ()>, tempfile::TempDir, PathBuf) {
        let guard = ENV_LOCK.lock().unwrap_or_else(|e| e.into_inner());
        let dir = tempfile::tempdir().unwrap();
        std::env::set_var("LOCALAPPDATA", dir.path().join("appdata"));
        let game = dir.path().join("game");
        fs::create_dir_all(game.join("BmGame").join("Config")).unwrap();
        fs::write(game.join("BmGame").join("Config").join("BmEngine.ini"), "original").unwrap();
        (guard, dir, game)
    }

    fn staged(root: &Path, rel: &str, text: &str) -> Mapping {
        let p = root.join(to_native(rel));
        fs::create_dir_all(p.parent().unwrap()).unwrap();
        fs::write(p, text).unwrap();
        Mapping { src: rel.into(), dest: rel.into() }
    }

    #[test]
    fn replacers_stack_and_restore() {
        let (_guard, dir, game) = setup();
        let stage = dir.path().join("stage");
        let ini = "BmGame/Config/BmEngine.ini";
        let ini_path = game.join(to_native(ini));
        let mut state = State::default();
        let mut d = Deployer { state: &mut state, game: game.clone() };

        let a = Detected { name: "A".into(), kind: Kind::Replacer, description: String::new(), files: vec![staged(&stage, ini, "a")] };
        let a_id = d.add(&stage, &a, "a.zip", &mut || {}).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "a");
        assert_eq!(fs::read_to_string(game.join(BACKUP_DIR).join("BmGame/Config/BmEngine.ini")).unwrap(), "original");

        let b = Detected { name: "B".into(), kind: Kind::Replacer, description: String::new(), files: vec![staged(&stage, ini, "b")] };
        let b_id = d.add(&stage, &b, "b.zip", &mut || {}).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "b");

        // Turning off the older one leaves the newer one in place
        d.disable(&a_id).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "b");

        d.enable(&a_id).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "a");

        d.uninstall(&a_id).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "b");

        d.disable(&b_id).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "original");
        assert!(d.state.originals.is_empty());
        assert!(!game.join(BACKUP_DIR).exists());
    }

    #[test]
    fn imported_mod_survives_disable_and_enable() {
        let (_guard, _dir, game) = setup();
        let mod_dir = game.join("DLC").join("356474").join("Suit");
        fs::create_dir_all(&mod_dir).unwrap();
        fs::write(mod_dir.join("a.upk"), "suit").unwrap();

        let mut state = State::default();
        assert_eq!(import_existing(&mut state, &game), 1);
        let id = state.mods[0].id.clone();
        let mut d = Deployer { state: &mut state, game: game.clone() };

        d.disable(&id).unwrap();
        assert!(!mod_dir.exists());
        assert!(game.join("DLC").join("356474").exists());

        d.enable(&id).unwrap();
        assert_eq!(fs::read_to_string(mod_dir.join("a.upk")).unwrap(), "suit");
    }

    // The order an update runs in: the new copy goes in first, then the old one is uninstalled
    #[test]
    fn a_failed_update_leaves_the_old_mod() {
        let (_guard, dir, game) = setup();
        let stage = dir.path().join("stage");
        let dll = "BmGame/Mods/Cam/Cam.dll";
        let extra = "BmGame/Mods/Cam/old-only.txt";
        let mut state = State::default();
        let mut d = Deployer { state: &mut state, game: game.clone() };

        let v1 = Detected {
            name: "Cam".into(),
            kind: Kind::PrebuiltDll,
            description: String::new(),
            files: vec![staged(&stage, dll, "v1"), staged(&stage, extra, "x")],
        };
        let old = d.add(&stage, &v1, "cam1.zip", &mut || {}).unwrap();

        // A file the archive listed can't be copied
        let broken = Detected {
            name: "Cam".into(),
            kind: Kind::PrebuiltDll,
            description: String::new(),
            files: vec![staged(&stage, dll, "v2"), Mapping { src: "missing.dll".into(), dest: "BmGame/Mods/Cam/missing.dll".into() }],
        };
        assert!(d.add(&stage, &broken, "cam2.zip", &mut || {}).is_err());
        assert_eq!(d.state.mods.len(), 1);
        assert!(d.state.mods[0].enabled);
        assert_eq!(fs::read_to_string(game.join(to_native(dll))).unwrap(), "v1");

        let v2 = Detected { name: "Cam".into(), kind: Kind::PrebuiltDll, description: String::new(), files: vec![staged(&stage, dll, "v2")] };
        d.add(&stage, &v2, "cam2.zip", &mut || {}).unwrap();
        d.uninstall(&old).unwrap();
        assert_eq!(d.state.mods.len(), 1);
        assert_eq!(fs::read_to_string(game.join(to_native(dll))).unwrap(), "v2");
        assert!(!game.join(to_native(extra)).exists());
    }

    #[test]
    fn a_state_file_that_cant_be_read_is_kept() {
        let (_guard, _dir, _game) = setup();
        fs::create_dir_all(data_dir()).unwrap();
        fs::write(state_path(), "{ \"mods\": [ { \"id\": 1 } ] }").unwrap();

        let state = State::load();
        assert!(state.mods.is_empty());
        assert!(state.activity[0].text.contains("state.json.bad"));
        assert_eq!(fs::read_to_string(state_path().with_extension("json.bad")).unwrap(), "{ \"mods\": [ { \"id\": 1 } ] }");

        // A good file loads as before and leaves no note
        State::default().save().unwrap();
        assert!(State::load().activity.is_empty());
    }

    #[test]
    fn edits_in_the_game_survive_disable_and_enable() {
        let (_guard, dir, game) = setup();
        let stage = dir.path().join("stage");
        let ini = "Binaries/Win64/plugins/Fov.ini";
        let ini_path = game.join(to_native(ini));
        let mut state = State::default();
        let mut d = Deployer { state: &mut state, game: game.clone() };

        let fov = Detected { name: "Fov".into(), kind: Kind::AsiPlugin, description: String::new(), files: vec![staged(&stage, ini, "fov=90")] };
        let id = d.add(&stage, &fov, "fov.zip", &mut || {}).unwrap();

        fs::write(&ini_path, "fov=110").unwrap();
        d.disable(&id).unwrap();
        assert!(!ini_path.exists());
        d.enable(&id).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "fov=110");

        // A second mod taking the file over keeps the first one's edit too
        fs::write(&ini_path, "fov=120").unwrap();
        let other = Detected { name: "Other".into(), kind: Kind::AsiPlugin, description: String::new(), files: vec![staged(&stage, ini, "fov=60")] };
        let other_id = d.add(&stage, &other, "other.zip", &mut || {}).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "fov=60");
        d.uninstall(&other_id).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "fov=120");
    }

    #[test]
    fn a_file_deleted_in_the_game_doesnt_stop_the_mod_turning_back_on() {
        let (_guard, _dir, game) = setup();
        let scripts = game.join("BmGame").join("Mods").join("Mine").join("scripts");
        fs::create_dir_all(&scripts).unwrap();
        fs::write(game.join("BmGame").join("Mods").join("Mine").join("mod.toml"), "name = \"Mine\"").unwrap();
        fs::write(scripts.join("Old.cs"), "old").unwrap();
        fs::write(scripts.join("Kept.cs"), "kept").unwrap();

        let mut state = State::default();
        assert_eq!(import_existing(&mut state, &game), 1);
        let id = state.mods[0].id.clone();
        let mut d = Deployer { state: &mut state, game: game.clone() };

        // Renamed or deleted while working on the mod, so no copy of it exists anywhere
        fs::remove_file(scripts.join("Old.cs")).unwrap();
        d.disable(&id).unwrap();
        d.enable(&id).unwrap();
        assert_eq!(fs::read_to_string(scripts.join("Kept.cs")).unwrap(), "kept");
        assert!(!scripts.join("Old.cs").exists());
        assert_eq!(d.state.mods[0].files.len(), 2);
    }

    #[test]
    fn a_locked_file_doesnt_leave_a_mod_half_off() {
        use std::os::windows::fs::OpenOptionsExt;
        let (_guard, dir, game) = setup();
        let stage = dir.path().join("stage");
        let ini = "BmGame/Config/BmEngine.ini";
        let added = "BmGame/Config/Added.ini";
        let mut state = State::default();
        let mut d = Deployer { state: &mut state, game: game.clone() };

        let a = Detected {
            name: "A".into(),
            kind: Kind::Replacer,
            description: String::new(),
            files: vec![staged(&stage, ini, "a"), staged(&stage, added, "added")],
        };
        let id = d.add(&stage, &a, "a.zip", &mut || {}).unwrap();
        d.enable(&id).unwrap();

        // Another program has the second file open, so it can't be removed
        let lock = fs::OpenOptions::new().read(true).share_mode(0).open(game.join(to_native(added))).unwrap();
        assert!(d.disable(&id).is_err());
        assert!(d.state.mods[0].enabled);
        assert_eq!(fs::read_to_string(game.join(to_native(ini))).unwrap(), "a");
        drop(lock);

        // Trying again once the file is free puts the game's own file back, not the mod's
        d.disable(&id).unwrap();
        assert_eq!(fs::read_to_string(game.join(to_native(ini))).unwrap(), "original");
        assert!(!game.join(to_native(added)).exists());
        d.enable(&id).unwrap();
        assert_eq!(fs::read_to_string(game.join(to_native(ini))).unwrap(), "a");
    }

    #[test]
    fn a_game_file_steam_put_back_is_not_taken_as_the_mods() {
        let (_guard, dir, game) = setup();
        let stage = dir.path().join("stage");
        let ini = "BmGame/Config/BmEngine.ini";
        let ini_path = game.join(to_native(ini));
        let mut state = State::default();
        let mut d = Deployer { state: &mut state, game: game.clone() };

        let a = Detected { name: "A".into(), kind: Kind::Replacer, description: String::new(), files: vec![staged(&stage, ini, "a")] };
        let id = d.add(&stage, &a, "a.zip", &mut || {}).unwrap();

        fs::write(&ini_path, "verified by steam").unwrap();
        d.disable(&id).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "original");
        d.enable(&id).unwrap();
        assert_eq!(fs::read_to_string(&ini_path).unwrap(), "a");
    }
}
