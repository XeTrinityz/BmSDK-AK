use serde::Serialize;
use std::collections::HashSet;
use std::fs;
use std::path::{Path, PathBuf};

const ROOT: &str = "TFCInstallerBackups";
const INFO: &str = "ModInfo.xml";
const NEW_FOLDER_MARK: &str = "NewFolder";

/// One run of TFC Installer, kept in its own numbered folder. Later runs sit on top of earlier ones.
#[derive(Serialize, Clone)]
#[serde(rename_all = "camelCase")]
pub struct TfcInstall {
    pub number: u32,
    pub name: String,
    /// Game files it changed, with a backup of each original.
    pub changed: usize,
    /// Files and folders it added.
    pub added: usize,
}

enum Entry {
    /// A game file that was replaced. The original is the backup.
    Replaced { game: PathBuf, backup: PathBuf },
    /// A file TFC Installer added. Nothing was there before.
    Added { game: PathBuf, backup: PathBuf },
    /// A folder TFC Installer made. It goes when it's empty.
    Folder { game: PathBuf, marker: PathBuf },
}

impl Entry {
    fn game(&self) -> &Path {
        match self {
            Entry::Replaced { game, .. } | Entry::Added { game, .. } | Entry::Folder { game, .. } => game,
        }
    }
}

fn root(game: &Path) -> PathBuf {
    game.join(ROOT)
}

fn number_dirs(game: &Path) -> Vec<(u32, PathBuf)> {
    let mut v: Vec<(u32, PathBuf)> = fs::read_dir(root(game))
        .into_iter()
        .flatten()
        .flatten()
        .filter(|e| e.path().is_dir())
        .filter_map(|e| {
            let name = e.file_name().to_string_lossy().to_string();
            let number = if name.len() == 8 { name.parse::<u32>().ok() } else { None };
            number.map(|n| (n, e.path()))
        })
        .collect();
    v.sort();
    v
}

fn mod_name(dir: &Path) -> String {
    let text = fs::read_to_string(dir.join(INFO)).unwrap_or_default();
    text.split("name=\"")
        .nth(1)
        .and_then(|s| s.split('"').next())
        .map(|s| s.replace("&amp;", "&").replace("&quot;", "\"").replace("&apos;", "'").replace("&lt;", "<").replace("&gt;", ">"))
        .filter(|s| !s.is_empty())
        .unwrap_or_else(|| "Unknown mod".into())
}

/// Backup file names end in a marker on the original's extension. The order matters, because
/// NewFileBackup and FileBackup both end in Backup.
fn classify(backup: &Path, game: PathBuf) -> Option<Entry> {
    let name = backup.file_name()?.to_string_lossy().to_string();
    if name == NEW_FOLDER_MARK {
        return Some(Entry::Folder { game: backup.parent()?.to_path_buf(), marker: backup.to_path_buf() });
    }
    let ext = backup.extension()?.to_string_lossy().to_string();
    let strip = |suffix: &str| -> Option<PathBuf> {
        // The original extension has to be left over, so a bare "Backup" extension doesn't count
        (ext.ends_with(suffix) && ext.len() > suffix.len()).then(|| game.with_file_name(&name[..name.len() - suffix.len()]))
    };
    if let Some(g) = strip("Installed") {
        return Some(Entry::Added { game: g, backup: backup.to_path_buf() });
    }
    if let Some(g) = strip("NewFileBackup") {
        return Some(Entry::Added { game: g, backup: backup.to_path_buf() });
    }
    for suffix in ["FileBackup", "TFCInstallerBackup", "TFCInstallerTOCBackup", "Backup"] {
        if let Some(g) = strip(suffix) {
            return Some(Entry::Replaced { game: g, backup: backup.to_path_buf() });
        }
    }
    None
}

fn collect(game: &Path, dir: &Path, out: &mut Vec<Entry>) {
    let base = dir.join("Game");
    let mut stack = vec![base.clone()];
    while let Some(d) = stack.pop() {
        for e in fs::read_dir(&d).into_iter().flatten().flatten() {
            let p = e.path();
            if p.is_dir() {
                stack.push(p);
                continue;
            }
            let Ok(rel) = p.strip_prefix(&base) else { continue };
            // The game path the backup stands for, before any suffix comes off
            let target = game.join(rel);
            if let Some(entry) = classify(&p, target.clone()) {
                // A folder marker stands for the folder the backup sits in
                let entry = match entry {
                    Entry::Folder { marker, .. } => Entry::Folder { game: target.parent().map(Path::to_path_buf).unwrap_or(target), marker },
                    other => other,
                };
                out.push(entry);
            }
        }
    }
}

pub fn list(game: &Path) -> Vec<TfcInstall> {
    number_dirs(game)
        .into_iter()
        .map(|(number, dir)| {
            let mut entries = Vec::new();
            collect(game, &dir, &mut entries);
            let added = entries.iter().filter(|e| !matches!(e, Entry::Replaced { .. })).count();
            TfcInstall { number, name: mod_name(&dir), changed: entries.len() - added, added }
        })
        .collect()
}

/// Folders TFC Installer made, as lower-case game-relative paths with `/`. They belong to it, not to the
/// manager's own list of mods found in the game.
pub fn made_folders(game: &Path) -> HashSet<String> {
    let mut set = HashSet::new();
    for (_, dir) in number_dirs(game) {
        let mut entries = Vec::new();
        collect(game, &dir, &mut entries);
        for e in entries {
            if let Entry::Folder { game: folder, .. } = e {
                if let Ok(rel) = folder.strip_prefix(game) {
                    set.insert(rel.to_string_lossy().replace('\\', "/").to_ascii_lowercase());
                }
            }
        }
    }
    set
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

fn remove(path: &Path) -> Result<(), String> {
    if path.exists() {
        make_writable(path);
        fs::remove_file(path).map_err(|e| format!("Couldn't remove {}: {e}", path.display()))?;
    }
    Ok(())
}

fn put_back(backup: &Path, game: &Path) -> Result<(), String> {
    make_writable(backup);
    if fs::rename(backup, game).is_ok() {
        return Ok(());
    }
    fs::copy(backup, game).map_err(|e| format!("Couldn't put back {}: {e}", game.display()))?;
    remove(backup)
}

/// Undoes one run's changes with the rules TFC Installer's own restore uses.
fn restore_one(game: &Path, dir: &Path, done: &mut usize) -> Result<(), String> {
    let mut entries = Vec::new();
    collect(game, dir, &mut entries);
    // Deepest paths first, so a folder is empty by the time it's looked at
    entries.sort_by(|a, b| b.game().cmp(a.game()));

    for entry in &entries {
        match entry {
            Entry::Replaced { game: target, backup } => {
                // A backup that's gone means this one was already put back
                if !backup.exists() {
                    continue;
                }
                remove(target)?;
                put_back(backup, target)?;
            }
            Entry::Added { game: target, backup } => {
                remove(target)?;
                remove(backup)?;
            }
            Entry::Folder { game: folder, marker } => {
                remove(marker)?;
                if folder.is_dir() && fs::read_dir(folder).map(|mut d| d.next().is_none()).unwrap_or(false) {
                    let _ = fs::remove_dir(folder);
                }
            }
        }
        *done += 1;
    }

    let _ = fs::remove_file(dir.join(INFO));
    // What's left is folders of backups with nothing in them
    prune(dir);
    Ok(())
}

fn prune(dir: &Path) {
    for e in fs::read_dir(dir).into_iter().flatten().flatten() {
        if e.path().is_dir() {
            prune(&e.path());
        }
    }
    let _ = fs::remove_dir(dir);
}

/// Restores `number` and every later run, newest first, because later runs were made on top of it.
/// Returns how many files and folders were put back or removed.
pub fn restore(game: &Path, number: u32) -> Result<usize, String> {
    let mut done = 0;
    let mut runs = number_dirs(game);
    runs.retain(|(n, _)| *n >= number);
    runs.reverse();
    if runs.is_empty() {
        return Err("TFC Installer's backup for that isn't there any more.".into());
    }
    for (_, dir) in runs {
        restore_one(game, &dir, &mut done)?;
    }
    // The marker file and the folder go once nothing is left to restore
    if number_dirs(game).is_empty() {
        for e in fs::read_dir(root(game)).into_iter().flatten().flatten() {
            if e.path().is_file() && e.file_name().to_string_lossy().starts_with(ROOT) {
                let _ = fs::remove_file(e.path());
            }
        }
        let _ = fs::remove_dir(root(game));
    }
    Ok(done)
}

#[cfg(test)]
mod tests {
    use super::*;

    fn write(root: &Path, rel: &str, text: &str) {
        let p = root.join(rel);
        fs::create_dir_all(p.parent().unwrap()).unwrap();
        fs::write(p, text).unwrap();
    }

    fn read(root: &Path, rel: &str) -> Option<String> {
        fs::read_to_string(root.join(rel)).ok()
    }

    // Two runs: the first patched a package and added a folder, the second patched the same package again
    fn setup() -> (tempfile::TempDir, PathBuf) {
        let dir = tempfile::tempdir().unwrap();
        let g = dir.path().to_path_buf();
        let cooked = "BmGame/CookedPCConsole";
        write(&g, &format!("{cooked}/a.upk"), "patched twice");
        write(&g, "BmGame/Config/b.ini", "overridden");
        write(&g, "DLC/1/New/Config/BmGame.ini", "new");
        write(&g, "DLC/1/New/c.tfc", "tfc");
        write(&g, "BmGame/Localization/INT/Hud.int", "mine");

        let b0 = format!("{ROOT}/00000000");
        write(&g, &format!("{b0}/{INFO}"), "<ModInfo name=\"Pack &amp; Co\" />");
        write(&g, &format!("{b0}/Game/{cooked}/a.upkBackup"), "original");
        write(&g, &format!("{b0}/Game/BmGame/Config/b.iniFileBackup"), "b original");
        write(&g, &format!("{b0}/Game/DLC/1/New/NewFolder"), "");
        write(&g, &format!("{b0}/Game/DLC/1/New/Config/NewFolder"), "");
        write(&g, &format!("{b0}/Game/DLC/1/New/Config/BmGame.iniNewFileBackup"), "");
        write(&g, &format!("{b0}/Game/DLC/1/New/c.tfcInstalled"), "");
        write(&g, &format!("{b0}/Game/BmGame/Localization/INT/Hud.intNewFileBackup"), "");

        let b1 = format!("{ROOT}/00000001");
        write(&g, &format!("{b1}/{INFO}"), "<ModInfo name=\"Update\" />");
        write(&g, &format!("{b1}/Game/{cooked}/a.upkBackup"), "patched once");
        write(&g, &format!("{ROOT}/{ROOT}V4"), "");
        (dir, g)
    }

    #[test]
    fn lists_runs_with_names_and_counts() {
        let (_dir, g) = setup();
        let runs = list(&g);
        assert_eq!(runs.len(), 2);
        assert_eq!(runs[0].name, "Pack & Co");
        assert_eq!((runs[0].changed, runs[0].added), (2, 5));
        assert_eq!(runs[1].name, "Update");
        assert!(made_folders(&g).contains("dlc/1/new"));
        assert!(made_folders(&g).contains("dlc/1/new/config"));
    }

    #[test]
    fn restoring_the_first_run_undoes_both_in_order() {
        let (_dir, g) = setup();
        assert!(restore(&g, 0).is_ok());
        assert_eq!(read(&g, "BmGame/CookedPCConsole/a.upk").as_deref(), Some("original"));
        assert_eq!(read(&g, "BmGame/Config/b.ini").as_deref(), Some("b original"));
        assert!(!g.join("DLC/1/New").exists());
        assert!(!g.join("BmGame/Localization/INT/Hud.int").exists());
        assert!(!g.join(ROOT).exists());
    }

    #[test]
    fn restoring_a_later_run_leaves_the_earlier_one() {
        let (_dir, g) = setup();
        assert!(restore(&g, 1).is_ok());
        assert_eq!(read(&g, "BmGame/CookedPCConsole/a.upk").as_deref(), Some("patched once"));
        assert!(g.join("DLC/1/New/c.tfc").exists());
        assert_eq!(list(&g).len(), 1);
        assert!(g.join(ROOT).join("00000000").exists());
    }

    #[test]
    fn backup_names_are_told_apart() {
        let t = PathBuf::from("G/x.upk");
        assert!(matches!(classify(Path::new("B/x.upkBackup"), t.clone()), Some(Entry::Replaced { .. })));
        assert!(matches!(classify(Path::new("B/x.upkNewFileBackup"), t.clone()), Some(Entry::Added { .. })));
        assert!(matches!(classify(Path::new("B/x.upkFileBackup"), t.clone()), Some(Entry::Replaced { .. })));
        assert!(classify(Path::new("B/x.Backup"), t).is_none());
    }
}
