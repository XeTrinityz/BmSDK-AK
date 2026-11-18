//! Tells the game's own files from changed ones, using a list made once from a Steam copy verified through
//! Steam. Each file is checked by size and a hash of a few pieces of it, so a check reads about 1 GB, not
//! the whole game.

use crate::detect;
use serde::Serialize;
use std::collections::{HashMap, HashSet};
use std::fs;
use std::io::{Read, Seek, SeekFrom};
use std::path::{Path, PathBuf};

const STEAM_LIST: &str = include_str!("../vanilla/steam.txt");

/// Files up to this size are hashed whole. Bigger ones are hashed in pieces.
const WHOLE_LIMIT: u64 = 1 << 20;
const PIECE: u64 = 64 << 10;

/// Files that sit in the game's folders but don't come from Steam: BmSDK's ASI loader, the file that lets
/// the exe start without Steam, the SDK's log, and a hooking library some old tools drop next to the exe.
const NOT_STEAM: [&str; 4] = [
    "Binaries/Win64/dinput8.dll",
    "Binaries/Win64/steam_appid.txt",
    "Binaries/Win64/EasyHook64.dll",
    "Binaries/Win64/BmSDK.log",
];

struct Expected {
    path: String,
    size: u64,
    hash: String,
}

struct List {
    build: String,
    depots: Vec<String>,
    files: HashMap<String, Expected>,
}

#[derive(Serialize, Default)]
#[serde(rename_all = "camelCase")]
pub struct Findings {
    /// Steam's game files that differ from the list.
    pub changed: Vec<String>,
    /// Steam's game files that aren't there.
    pub missing: Vec<String>,
    /// Files in the game's folders that Steam didn't put there, and the manager didn't either.
    pub added: Vec<String>,
    /// False when this copy is a different Steam build or language than the list, so results may be off.
    pub same_build: bool,
}

fn key(rel: &str) -> String {
    rel.to_ascii_lowercase()
}

fn native(rel: &str) -> PathBuf {
    rel.split('/').collect()
}

fn parse(text: &str) -> List {
    let mut list = List { build: String::new(), depots: Vec::new(), files: HashMap::new() };
    for line in text.lines() {
        if let Some(b) = line.strip_prefix("build ") {
            list.build = b.trim().to_string();
        } else if let Some(d) = line.strip_prefix("depots ") {
            list.depots = d.split_whitespace().map(String::from).collect();
        } else if let [size, hash, path] = line.splitn(3, '\t').collect::<Vec<_>>()[..] {
            if let Ok(size) = size.parse() {
                list.files.insert(key(path), Expected { path: path.to_string(), size, hash: hash.to_string() });
            }
        }
    }
    list
}

/// SHA-256 of the whole file when it's small, or of four pieces spread over it, cut to 16 hex digits.
pub fn sample_hash(path: &Path, size: u64) -> Result<String, String> {
    use sha2::{Digest, Sha256};
    let err = |e: std::io::Error| format!("Couldn't read {}: {e}", path.display());
    let mut file = fs::File::open(path).map_err(err)?;
    let mut hasher = Sha256::new();
    if size <= WHOLE_LIMIT {
        let mut buf = Vec::with_capacity(size as usize);
        file.read_to_end(&mut buf).map_err(err)?;
        hasher.update(&buf);
    } else {
        let mut buf = vec![0u8; PIECE as usize];
        for at in [0, size / 3, size * 2 / 3, size - PIECE] {
            file.seek(SeekFrom::Start(at)).map_err(err)?;
            file.read_exact(&mut buf).map_err(err)?;
            hasher.update(&buf);
        }
    }
    Ok(hasher.finalize()[..8].iter().map(|b| format!("{b:02x}")).collect())
}

/// The game's own files, minus the ones listed as not from Steam.
fn scope(game: &Path) -> Vec<String> {
    let mut rels = detect::vanilla_files(game);
    rels.retain(|r| !NOT_STEAM.iter().any(|n| n.eq_ignore_ascii_case(r)));
    rels
}

/// The Steam build id and installed depots, from the app manifest two folders above the game.
fn steam_install(game: &Path) -> Option<(String, Vec<String>)> {
    let acf = game.parent()?.parent()?.join(format!("appmanifest_{}.acf", crate::game::STEAM_APP_ID));
    let text = fs::read_to_string(acf).ok()?;
    let value = |line: &str| line.split('"').nth(3).map(String::from);
    let build = text.lines().find(|l| l.trim_start().starts_with("\"buildid\"")).and_then(value)?;

    // Depots are the keys inside the InstalledDepots block
    let mut depots = Vec::new();
    let mut depth = 0;
    let mut inside = false;
    for line in text.lines().map(str::trim) {
        if line == "\"InstalledDepots\"" {
            inside = true;
            continue;
        }
        if !inside {
            continue;
        }
        match line {
            "{" => depth += 1,
            "}" => {
                depth -= 1;
                if depth == 0 {
                    break;
                }
            }
            _ if depth == 1 => {
                let name = line.trim_matches('"');
                if !name.is_empty() && name.bytes().all(|b| b.is_ascii_digit()) {
                    depots.push(name.to_string());
                }
            }
            _ => {}
        }
    }
    depots.sort();
    Some((build, depots))
}

/// True for a file of a DLC whose folder isn't in this copy of the game at all.
fn not_owned_dlc(game: &Path, rel: &str) -> bool {
    let mut parts = rel.split('/');
    match (parts.next(), parts.next()) {
        (Some(d), Some(n)) if d.eq_ignore_ascii_case("DLC") => !game.join("DLC").join(n).is_dir(),
        _ => false,
    }
}

fn check_with(list: &List, game: &Path, owned: &HashSet<String>, progress: &mut dyn FnMut(u64, u64)) -> Result<Findings, String> {
    let mut findings = Findings { same_build: true, ..Default::default() };
    if let Some((build, depots)) = steam_install(game) {
        findings.same_build = build == list.build && depots == list.depots;
    }

    let total = list.files.len() as u64;
    for (done, (k, expected)) in list.files.iter().enumerate() {
        progress(done as u64, total);
        if owned.contains(k) {
            continue;
        }
        let file = game.join(native(&expected.path));
        let Ok(meta) = fs::metadata(&file) else {
            // Someone who doesn't own a DLC has no folder for it, which isn't a problem
            if !not_owned_dlc(game, &expected.path) {
                findings.missing.push(expected.path.clone());
            }
            continue;
        };
        if meta.len() != expected.size || sample_hash(&file, meta.len())? != expected.hash {
            findings.changed.push(expected.path.clone());
        }
    }

    for rel in scope(game) {
        let k = key(&rel);
        if !list.files.contains_key(&k) && !owned.contains(&k) {
            findings.added.push(rel);
        }
    }

    findings.changed.sort();
    findings.missing.sort();
    findings.added.sort();
    Ok(findings)
}

/// Checks a Steam copy of the game against the list that ships with the manager. `owned` holds lower-case
/// game-relative paths the manager put there itself, which aren't reported.
pub fn check(game: &Path, owned: &HashSet<String>, progress: &mut dyn FnMut(u64, u64)) -> Result<Findings, String> {
    if crate::game::store(game) != "Steam" {
        return Err("Only Steam copies of the game can be checked. The list of the game's files comes from Steam.".into());
    }
    check_with(&parse(STEAM_LIST), game, owned, progress)
}

/// Lower-case game-relative paths of files in the game's folders that aren't Steam's, so they're safe to remove.
pub fn added_files(game: &Path) -> HashSet<String> {
    let list = parse(STEAM_LIST);
    scope(game).iter().map(|r| key(r)).filter(|k| !list.files.contains_key(k)).collect()
}

/// Writes the list from a game folder. Only for making the list that ships, on a copy just verified in Steam.
#[cfg(test)]
fn write_list(game: &Path, out: &Path) -> Result<usize, String> {
    let (build, depots) = steam_install(game).ok_or("Couldn't read the game's Steam app manifest.")?;
    let mut rels = scope(game);
    rels.sort();
    let mut text = String::from("# The game's own files, from a Steam copy verified through Steam. Made by the make_vanilla_list test.\n");
    text.push_str(&format!("build {build}\ndepots {}\n", depots.join(" ")));
    for rel in &rels {
        let file = game.join(native(rel));
        let size = fs::metadata(&file).map_err(|e| e.to_string())?.len();
        text.push_str(&format!("{size}\t{}\t{rel}\n", sample_hash(&file, size)?));
    }
    fs::write(out, text).map_err(|e| e.to_string())?;
    Ok(rels.len())
}

#[cfg(test)]
mod tests {
    use super::*;

    fn write(root: &Path, rel: &str, bytes: &[u8]) {
        let p = root.join(native(rel));
        fs::create_dir_all(p.parent().unwrap()).unwrap();
        fs::write(p, bytes).unwrap();
    }

    fn list_of(game: &Path) -> List {
        let mut text = String::from("build 1\ndepots 2\n");
        for rel in scope(game) {
            let f = game.join(native(&rel));
            let size = fs::metadata(&f).unwrap().len();
            text.push_str(&format!("{size}\t{}\t{rel}\n", sample_hash(&f, size).unwrap()));
        }
        parse(&text)
    }

    #[test]
    fn a_same_size_change_in_a_sampled_piece_is_caught() {
        let dir = tempfile::tempdir().unwrap();
        let big = vec![7u8; (WHOLE_LIMIT * 3) as usize];
        let f = dir.path().join("big.upk");
        fs::write(&f, &big).unwrap();
        let before = sample_hash(&f, big.len() as u64).unwrap();
        let mut changed = big.clone();
        changed[10] = 8;
        fs::write(&f, &changed).unwrap();
        assert_ne!(sample_hash(&f, big.len() as u64).unwrap(), before);
    }

    #[test]
    fn finds_changed_missing_and_added_but_not_the_managers_own() {
        let dir = tempfile::tempdir().unwrap();
        let game = dir.path();
        write(game, "BmGame/CookedPCConsole/a.upk", b"aaaa");
        write(game, "BmGame/CookedPCConsole/b.upk", b"bbbb");
        write(game, "BmGame/CookedPCConsole/c.upk", b"cccc");
        write(game, "BmGame/Config/same.ini", b"keep");
        write(game, "Binaries/Win64/dinput8.dll", b"sdk");
        let list = list_of(game);
        assert_eq!(list.files.len(), 4);

        write(game, "BmGame/CookedPCConsole/a.upk", b"AAAA");
        fs::remove_file(game.join("BmGame/CookedPCConsole/b.upk")).unwrap();
        write(game, "BmGame/CookedPCConsole/new.upk", b"n");
        write(game, "BmGame/CookedPCConsole/c.upk", b"replaced by a mod");
        write(game, "BmGame/Mods/Mine/mod.toml", b"x");

        let owned: HashSet<String> = ["bmgame/cookedpcconsole/c.upk".to_string()].into();
        let f = check_with(&list, game, &owned, &mut |_, _| {}).unwrap();
        assert_eq!(f.changed, vec!["BmGame/CookedPCConsole/a.upk"]);
        assert_eq!(f.missing, vec!["BmGame/CookedPCConsole/b.upk"]);
        assert_eq!(f.added, vec!["BmGame/CookedPCConsole/new.upk"]);
    }

    #[test]
    fn reads_build_and_depots_from_the_app_manifest() {
        let dir = tempfile::tempdir().unwrap();
        let game = dir.path().join("steamapps").join("common").join("BAK");
        fs::create_dir_all(&game).unwrap();
        fs::write(
            dir.path().join("steamapps").join("appmanifest_208650.acf"),
            "\"AppState\"\n{\n\t\"buildid\"\t\t\"42\"\n\t\"InstalledDepots\"\n\t{\n\t\t\"208652\"\n\t\t{\n\t\t\t\"manifest\"\t\t\"1\"\n\t\t}\n\t\t\"208651\"\n\t\t{\n\t\t}\n\t}\n}\n",
        )
        .unwrap();
        assert_eq!(steam_install(&game), Some(("42".into(), vec!["208651".into(), "208652".into()])));
    }

    // Run on purpose, on a game just verified in Steam with nothing added:
    // BMSDK_GAME="F:\...\Batman Arkham Knight" cargo test make_vanilla_list -- --ignored
    #[test]
    #[ignore]
    fn make_vanilla_list() {
        let game = std::env::var("BMSDK_GAME").expect("set BMSDK_GAME to the game folder");
        let out = Path::new(env!("CARGO_MANIFEST_DIR")).join("vanilla").join("steam.txt");
        let n = write_list(Path::new(&game), &out).unwrap();
        println!("wrote {n} files to {}", out.display());
    }

    #[test]
    #[ignore]
    fn check_game_from_env() {
        let game = std::env::var("BMSDK_GAME").expect("set BMSDK_GAME to the game folder");
        let t = std::time::Instant::now();
        let f = check(Path::new(&game), &HashSet::new(), &mut |_, _| {}).unwrap();
        println!("took {:?}, same build {}", t.elapsed(), f.same_build);
        for (name, list) in [("changed", &f.changed), ("missing", &f.missing), ("added", &f.added)] {
            println!("{name}: {}", list.len());
            for p in list.iter().take(25) {
                println!("  {p}");
            }
        }
    }
}
