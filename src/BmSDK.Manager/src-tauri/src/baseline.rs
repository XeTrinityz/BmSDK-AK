use crate::detect;
use crate::library;
use serde::{Deserialize, Serialize};
use std::collections::{BTreeMap, HashSet};
use std::fs;
use std::io::Read;
use std::path::{Path, PathBuf};
use std::time::UNIX_EPOCH;

#[derive(Serialize, Deserialize, Clone)]
struct Entry {
    /// The path as it is on disk, game-relative with `/`.
    path: String,
    size: u64,
    /// Nanoseconds since 1970. Only a hint to skip hashing, never proof by itself.
    modified: u64,
    hash: String,
}

/// A snapshot of the game's own files, taken once by the user on a game with nothing changed.
#[derive(Serialize, Deserialize, Clone)]
pub struct Baseline {
    pub game_dir: String,
    pub created: u64,
    files: BTreeMap<String, Entry>,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
pub struct BaselineView {
    pub created: u64,
    pub files: usize,
}

#[derive(Serialize, Default)]
#[serde(rename_all = "camelCase")]
pub struct Findings {
    /// In the baseline, but different now.
    pub changed: Vec<String>,
    /// In the baseline, gone now.
    pub missing: Vec<String>,
    /// Not in the baseline.
    pub added: Vec<String>,
}

fn path() -> PathBuf {
    library::data_dir().join("baseline.json")
}

fn key(rel: &str) -> String {
    rel.to_ascii_lowercase()
}

fn native(rel: &str) -> PathBuf {
    rel.split('/').collect()
}

fn modified(meta: &fs::Metadata) -> u64 {
    meta.modified().ok().and_then(|t| t.duration_since(UNIX_EPOCH).ok()).map(|d| d.as_nanos() as u64).unwrap_or(0)
}

/// SHA-256 as hex, reporting the bytes read as it goes so a big file still shows progress.
fn hash_file(path: &Path, on_bytes: &mut dyn FnMut(u64)) -> Result<String, String> {
    use sha2::{Digest, Sha256};
    let mut file = fs::File::open(path).map_err(|e| format!("Couldn't read {}: {e}", path.display()))?;
    let mut hasher = Sha256::new();
    let mut buf = vec![0u8; 4 << 20];
    loop {
        let n = file.read(&mut buf).map_err(|e| format!("Couldn't read {}: {e}", path.display()))?;
        if n == 0 {
            break;
        }
        hasher.update(&buf[..n]);
        on_bytes(n as u64);
    }
    Ok(hasher.finalize().iter().map(|b| format!("{b:02x}")).collect())
}

impl Baseline {
    pub fn load() -> Option<Baseline> {
        serde_json::from_slice(&fs::read(path()).ok()?).ok()
    }

    fn save(&self) -> Result<(), String> {
        fs::create_dir_all(library::data_dir()).map_err(|e| e.to_string())?;
        let tmp = path().with_extension("json.tmp");
        fs::write(&tmp, serde_json::to_vec(self).map_err(|e| e.to_string())?).map_err(|e| e.to_string())?;
        fs::rename(&tmp, path()).map_err(|e| e.to_string())
    }

    pub fn view_for(&self, game: &Path) -> Option<BaselineView> {
        crate::game::same_path(Path::new(&self.game_dir), game).then(|| BaselineView { created: self.created, files: self.files.len() })
    }
}

/// The game's own files. BmSDK's ASI loader sits next to the exe but belongs to BmSDK, so it never counts.
pub fn scope(game: &Path) -> Vec<String> {
    let mut rels = detect::vanilla_files(game);
    rels.retain(|r| !r.eq_ignore_ascii_case("Binaries/Win64/dinput8.dll"));
    rels
}

impl Baseline {
    /// True when the snapshot has no entry for this game-relative path.
    pub fn lacks(&self, rel: &str) -> bool {
        !self.files.contains_key(&key(rel))
    }
}

/// Hashes every game file and keeps the result. `progress` gets bytes done and the total.
pub fn create(game: &Path, progress: &mut dyn FnMut(u64, u64)) -> Result<Baseline, String> {
    let rels = scope(game);
    let total: u64 = rels.iter().map(|r| fs::metadata(game.join(native(r))).map(|m| m.len()).unwrap_or(0)).sum();
    let mut done = 0u64;
    let mut files = BTreeMap::new();

    for rel in rels {
        let file = game.join(native(&rel));
        let meta = fs::metadata(&file).map_err(|e| format!("Couldn't read {rel}: {e}"))?;
        let hash = hash_file(&file, &mut |n| {
            done += n;
            progress(done, total);
        })?;
        files.insert(key(&rel), Entry { path: rel, size: meta.len(), modified: modified(&meta), hash });
    }

    let baseline = Baseline { game_dir: game.to_string_lossy().into_owned(), created: library::now(), files };
    baseline.save()?;
    Ok(baseline)
}

/// Compares the game with the baseline. `owned` holds lower-case game-relative paths the manager put there
/// itself, so those aren't reported. A file whose size and time match is trusted. One whose time moved
/// but whose contents didn't, like after Steam verifies, is cleared and remembered.
pub fn check(game: &Path, baseline: &mut Baseline, owned: &HashSet<String>, progress: &mut dyn FnMut(u64, u64)) -> Result<Findings, String> {
    let rels = scope(game);
    let mut findings = Findings::default();
    let mut seen: HashSet<String> = HashSet::new();
    let mut refreshed = false;

    // Only files that need a hash count toward the progress total
    let mut to_hash: Vec<(String, u64)> = Vec::new();
    for rel in &rels {
        let k = key(rel);
        seen.insert(k.clone());
        let Some(entry) = baseline.files.get(&k) else {
            if !owned.contains(&k) {
                findings.added.push(rel.clone());
            }
            continue;
        };
        let Ok(meta) = fs::metadata(game.join(native(rel))) else { continue };
        if meta.len() != entry.size {
            if !owned.contains(&k) {
                findings.changed.push(rel.clone());
            }
        } else if modified(&meta) != entry.modified {
            to_hash.push((k, meta.len()));
        }
    }

    let total: u64 = to_hash.iter().map(|(_, n)| n).sum();
    let mut done = 0u64;
    for (k, _) in to_hash {
        let Some(entry) = baseline.files.get(&k).cloned() else { continue };
        let file = game.join(native(&entry.path));
        let hash = hash_file(&file, &mut |n| {
            done += n;
            progress(done, total);
        })?;
        if hash == entry.hash {
            if let (Some(e), Ok(meta)) = (baseline.files.get_mut(&k), fs::metadata(&file)) {
                e.modified = modified(&meta);
                refreshed = true;
            }
        } else if !owned.contains(&k) {
            findings.changed.push(entry.path);
        }
    }

    for (k, entry) in &baseline.files {
        if !seen.contains(k) && !owned.contains(k) {
            findings.missing.push(entry.path.clone());
        }
    }

    if refreshed {
        let _ = baseline.save();
    }
    findings.changed.sort();
    findings.added.sort();
    findings.missing.sort();
    Ok(findings)
}

#[cfg(test)]
mod tests {
    use super::*;

    fn write(root: &Path, rel: &str, text: &str) {
        let p = root.join(native(rel));
        fs::create_dir_all(p.parent().unwrap()).unwrap();
        fs::write(p, text).unwrap();
    }

    #[test]
    fn finds_changed_added_and_missing_but_not_the_managers_own() {
        let _guard = crate::library::ENV_LOCK.lock().unwrap_or_else(|e| e.into_inner());
        let dir = tempfile::tempdir().unwrap();
        std::env::set_var("LOCALAPPDATA", dir.path().join("appdata"));
        let game = dir.path().join("game");
        write(&game, "BmGame/CookedPCConsole/a.upk", "aaaa");
        write(&game, "BmGame/CookedPCConsole/b.upk", "bbbb");
        write(&game, "BmGame/CookedPCConsole/c.upk", "cccc");
        write(&game, "BmGame/Config/same.ini", "keep");
        write(&game, "BmGame/Mods/Mine/mod.toml", "x");

        let mut b = create(&game, &mut |_, _| {}).unwrap();
        assert_eq!(b.files.len(), 4);
        assert!(Baseline::load().is_some());

        // Same size, so only the contents tell. Also a changed time with the same contents, like a Steam restore.
        write(&game, "BmGame/CookedPCConsole/a.upk", "AAAA");
        fs::remove_file(game.join("BmGame/CookedPCConsole/b.upk")).unwrap();
        write(&game, "BmGame/CookedPCConsole/new.upk", "n");
        write(&game, "BmGame/Config/same.ini", "keep");
        write(&game, "BmGame/CookedPCConsole/c.upk", "longer than before");

        let owned: HashSet<String> = ["bmgame/cookedpcconsole/c.upk".to_string()].into();
        let f = check(&game, &mut b, &owned, &mut |_, _| {}).unwrap();
        assert_eq!(f.changed, vec!["BmGame/CookedPCConsole/a.upk"]);
        assert_eq!(f.missing, vec!["BmGame/CookedPCConsole/b.upk"]);
        assert_eq!(f.added, vec!["BmGame/CookedPCConsole/new.upk"]);
    }
}
