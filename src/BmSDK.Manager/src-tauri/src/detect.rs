use serde::{Deserialize, Serialize};
use std::collections::{HashMap, HashSet};
use std::fs;
use std::path::{Path, PathBuf};

/// The DLC folder mods go in when they don't name one. It's the one known to load mods reliably.
pub const DEFAULT_DLC_FOLDER: &str = "356474";

const GAME_TOP_FOLDERS: [&str; 4] = ["bmgame", "binaries", "engine", "dlc"];

const DOC_EXTENSIONS: [&str; 14] =
    ["txt", "md", "rtf", "pdf", "nfo", "url", "html", "htm", "jpg", "jpeg", "png", "gif", "bmp", "webp"];

/// DLL names the game loads from its exe folder, which loaders and injectors like ReShade take over.
const PROXY_DLLS: [&str; 8] =
    ["dxgi.dll", "d3d11.dll", "d3d9.dll", "dinput8.dll", "winmm.dll", "version.dll", "xinput1_3.dll", "xinput9_1_0.dll"];

/// Game folders a loose file can be matched to by name. Other folders hold mods and backups.
const GAME_CONTENT_DIRS: [&str; 6] =
    ["BmGame/Config", "BmGame/CookedPCConsole", "BmGame/Localization", "BmGame/Movies", "BmGame/Splash", "Engine"];

#[derive(Serialize, Deserialize, Clone, Copy, PartialEq, Eq, Debug)]
#[serde(rename_all = "camelCase")]
pub enum Kind {
    ScriptMod,
    PrebuiltDll,
    LooseScripts,
    Dlc,
    Replacer,
    AsiPlugin,
    TfcInstaller,
    ResoRep,
}

impl Kind {
    pub fn supported(self) -> bool {
        !matches!(self, Kind::TfcInstaller | Kind::ResoRep)
    }
}

/// A file to copy: `src` is relative to the scanned folder, `dest` to the game folder. Both use `/`.
#[derive(Clone, Debug)]
pub struct Mapping {
    pub src: String,
    pub dest: String,
}

#[derive(Clone, Debug)]
pub struct Detected {
    pub name: String,
    pub kind: Kind,
    pub description: String,
    pub files: Vec<Mapping>,
}

pub fn is_document(path: &str) -> bool {
    DOC_EXTENSIONS.contains(&ext(path).as_str())
}

fn ext(path: &str) -> String {
    let name = file_name(path);
    match name.rfind('.') {
        Some(i) => name[i + 1..].to_ascii_lowercase(),
        None => String::new(),
    }
}

fn file_name(path: &str) -> &str {
    path.rsplit('/').next().unwrap_or(path)
}

fn parent(path: &str) -> &str {
    path.rfind('/').map(|i| &path[..i]).unwrap_or("")
}

fn join(a: &str, b: &str) -> String {
    if a.is_empty() {
        b.to_string()
    } else {
        format!("{a}/{b}")
    }
}

fn inside(path: &str, root: &str) -> bool {
    root.is_empty()
        || path.eq_ignore_ascii_case(root)
        || (path.len() > root.len()
            && path.as_bytes()[root.len()] == b'/'
            && path[..root.len()].eq_ignore_ascii_case(root))
}

fn rel<'a>(path: &'a str, root: &str) -> &'a str {
    if root.is_empty() {
        path
    } else {
        &path[root.len() + 1..]
    }
}

fn first_segment(path: &str) -> String {
    path.split('/').next().unwrap_or_default().to_ascii_lowercase()
}

fn is_digits(s: &str) -> bool {
    !s.is_empty() && s.bytes().all(|b| b.is_ascii_digit())
}

/// Keeps only roots that aren't inside another root.
fn outermost(mut roots: Vec<String>) -> Vec<String> {
    roots.sort_by_key(|r| r.to_ascii_lowercase());
    roots.dedup_by(|a, b| a.eq_ignore_ascii_case(b));
    let all = roots.clone();
    roots.retain(|r| !all.iter().any(|o| !o.eq_ignore_ascii_case(r) && inside(r, o)));
    roots
}

fn sanitize_folder(name: &str) -> String {
    let cleaned: String = name.chars().map(|c| if r#"<>:"/\|?*"#.contains(c) || c.is_control() { '_' } else { c }).collect();
    let trimmed = cleaned.trim().trim_end_matches('.').to_string();
    if trimmed.is_empty() { "Mod".into() } else { trimmed }
}

pub fn list_files(root: &Path) -> Vec<String> {
    let mut out = Vec::new();
    let mut stack = vec![root.to_path_buf()];

    while let Some(dir) = stack.pop() {
        for entry in fs::read_dir(&dir).into_iter().flatten().flatten() {
            let path = entry.path();
            let name = entry.file_name().to_string_lossy().to_string();
            if path.is_dir() {
                if !name.eq_ignore_ascii_case("__MACOSX") {
                    stack.push(path);
                }
            } else if !name.eq_ignore_ascii_case("desktop.ini") && !name.eq_ignore_ascii_case("thumbs.db") {
                if let Ok(r) = path.strip_prefix(root) {
                    out.push(r.to_string_lossy().replace('\\', "/"));
                }
            }
        }
    }

    out.sort();
    out
}

pub struct ModToml {
    pub name: Option<String>,
    pub description: Option<String>,
    pub assembly: Option<String>,
    pub version: Option<String>,
}

pub fn read_mod_toml(path: &Path) -> ModToml {
    let text = fs::read_to_string(path).unwrap_or_default();
    let mut toml = ModToml { name: None, description: None, assembly: None, version: None };

    for line in text.lines() {
        let line = line.trim();
        if line.starts_with('#') {
            continue;
        }
        let Some((key, value)) = line.split_once('=') else { continue };
        let value = value.trim();
        if !(value.len() >= 2 && value.starts_with('"') && value.ends_with('"')) {
            continue;
        }
        let value = value[1..value.len() - 1].to_string();
        match key.trim() {
            "name" => toml.name = Some(value),
            "description" => toml.description = Some(value),
            "assembly" => toml.assembly = Some(value),
            "version" => toml.version = Some(value),
            _ => {}
        }
    }

    toml
}

/// The game-relative path of a script mod's mod.toml among its files.
pub fn mod_toml_path<'a>(mut files: impl Iterator<Item = &'a str>) -> Option<&'a str> {
    files.find(|f| {
        let s: Vec<&str> = f.split('/').collect();
        s.len() == 4
            && s[0].eq_ignore_ascii_case("BmGame")
            && s[1].eq_ignore_ascii_case("Mods")
            && s[3].eq_ignore_ascii_case("mod.toml")
    })
}

fn looks_like_dlc_config(path: &Path) -> bool {
    let bytes = fs::read(path).unwrap_or_default();
    // DLC configs are often UTF-16, so drop the zero bytes before searching
    let text: String = bytes.iter().filter(|b| **b != 0).map(|b| *b as char).collect::<String>().to_ascii_lowercase();
    text.contains("showcaseitems") || text.contains("dlcbundlesinstalled") || text.contains("[bmgame.rgameinfo]")
}

/// Works out which mods a folder holds and where each file goes in the game.
/// `game` lets loose files that share a name with one of the game's own go where that file is.
pub fn detect(root: &Path, fallback_name: &str, game: Option<&Path>) -> Vec<Detected> {
    let files = list_files(root);
    let mut dirs: HashSet<String> = HashSet::new();
    for f in &files {
        let mut d = parent(f);
        while !d.is_empty() && dirs.insert(d.to_ascii_lowercase()) {
            d = parent(d);
        }
    }
    let has_dir = |d: &str| dirs.contains(&d.to_ascii_lowercase());
    let name_of = |dir: &str| sanitize_folder(if dir.is_empty() { fallback_name } else { file_name(dir) });

    let mut found: Vec<Detected> = Vec::new();
    let mut claimed: HashSet<String> = HashSet::new();
    let claim = |claimed: &mut HashSet<String>, f: &str| claimed.insert(f.to_ascii_lowercase());
    let is_claimed = |claimed: &HashSet<String>, f: &str| claimed.contains(&f.to_ascii_lowercase());

    // TFC Installer mods patch the game's packages and inis in place. Copying only their plain files
    // would leave the game half modded, so the whole folder waits for TFC Installer.
    let tfc_roots = outermost(files.iter().filter_map(|f| tfc_root(f)).collect());
    for r in &tfc_roots {
        for f in files.iter().filter(|f| inside(f, r)) {
            claim(&mut claimed, f);
        }
        found.push(Detected {
            name: name_of(r),
            kind: Kind::TfcInstaller,
            description: "Package and texture patches made for TFC Installer. Install it with TFC Installer. When it is in, the manager lists it so you can remove it.".into(),
            files: Vec::new(),
        });
    }

    // Script mods: a folder with mod.toml goes to BmGame\Mods\<folder>
    let script_roots = outermost(
        files
            .iter()
            .filter(|f| file_name(f).eq_ignore_ascii_case("mod.toml") && !is_claimed(&claimed, f))
            .map(|f| parent(f).to_string())
            .collect(),
    );
    let mut script_found: Vec<(usize, String)> = Vec::new();
    for r in &script_roots {
        let toml = read_mod_toml(&root.join(join(r, "mod.toml")));
        let folder = name_of(r);
        let mut mappings = Vec::new();
        for f in files.iter().filter(|f| inside(f, r)) {
            mappings.push(Mapping { src: f.clone(), dest: format!("BmGame/Mods/{folder}/{}", rel(f, r)) });
            claim(&mut claimed, f);
        }
        let prebuilt = toml
            .assembly
            .as_ref()
            .is_some_and(|a| files.iter().any(|f| f.eq_ignore_ascii_case(&join(r, &a.replace('\\', "/")))));
        script_found.push((found.len(), r.clone()));
        found.push(Detected {
            name: toml.name.unwrap_or_else(|| folder.clone()),
            kind: if prebuilt { Kind::PrebuiltDll } else { Kind::ScriptMod },
            description: toml.description.unwrap_or_else(|| "BmSDK script mod".into()),
            files: mappings,
        });
    }

    // DLC mods: Config and/or CookedPCConsole that register new content, or anything under DLC\<number>\
    let mut dlc_candidates = Vec::new();
    for d in files.iter().map(|f| parent(f)) {
        let mut cur = d;
        loop {
            if has_dir(&join(cur, "Config")) || has_dir(&join(cur, "CookedPCConsole")) {
                let c = if file_name(cur).eq_ignore_ascii_case("BmGame") { parent(cur) } else { cur };
                let segs: Vec<&str> = c.split('/').collect();
                let official_content = segs.len() >= 3
                    && segs[segs.len() - 1].eq_ignore_ascii_case("Content")
                    && is_digits(segs[segs.len() - 2])
                    && segs[segs.len() - 3].eq_ignore_ascii_case("DLC");
                if !official_content && !script_roots.iter().any(|s| inside(c, s)) {
                    dlc_candidates.push(c.to_string());
                }
            }
            if cur.is_empty() {
                break;
            }
            cur = parent(cur);
        }
    }
    dlc_candidates.sort();
    dlc_candidates.dedup();
    let dlc_candidates: Vec<String> = dlc_candidates
        .into_iter()
        .filter(|c| {
            dlc_number(c).is_some()
                || files.iter().any(|f| inside(f, c) && ext(f) == "ini" && looks_like_dlc_config(&root.join(f)))
        })
        .collect();
    for c in outermost(dlc_candidates) {
        let number = dlc_number(&c).unwrap_or_else(|| DEFAULT_DLC_FOLDER.to_string());
        let name = name_of(&c);
        let mut mappings = Vec::new();
        for f in files.iter().filter(|f| inside(f, &c)) {
            if is_claimed(&claimed, f) {
                continue;
            }
            // A readme or preview next to the mod's folders isn't part of it
            if is_document(f) && parent(f).eq_ignore_ascii_case(&c) {
                continue;
            }
            mappings.push(Mapping { src: f.clone(), dest: format!("DLC/{number}/{name}/{}", rel(f, &c)) });
            claim(&mut claimed, f);
        }
        if !mappings.is_empty() {
            let count = mappings.len();
            found.push(Detected {
                name,
                kind: Kind::Dlc,
                description: format!("Suit or DLC content, {count} file{}", plural(count)),
                files: mappings,
            });
        }
    }

    // A script mod's extra files, laid out like the game folder next to BmGame\Mods\<mod>
    for (index, r) in &script_found {
        let segs: Vec<&str> = r.split('/').collect();
        let game_root = if segs.len() >= 3
            && segs[segs.len() - 2].eq_ignore_ascii_case("Mods")
            && segs[segs.len() - 3].eq_ignore_ascii_case("BmGame")
        {
            segs[..segs.len() - 3].join("/")
        } else {
            parent(r).to_string()
        };
        if game_root.eq_ignore_ascii_case(r) {
            continue;
        }
        for f in files.iter().filter(|f| inside(f, &game_root)) {
            let rf = rel(f, &game_root);
            if !is_claimed(&claimed, f) && GAME_TOP_FOLDERS.contains(&first_segment(rf).as_str()) && rf.contains('/') {
                found[*index].files.push(Mapping { src: f.clone(), dest: rf.to_string() });
                claim(&mut claimed, f);
            }
        }
    }

    // Loose scripts in a game layout: BmGame\Scripts\*.cs
    let loose_roots = outermost(
        files
            .iter()
            .filter(|f| ext(f) == "cs" && !is_claimed(&claimed, f))
            .filter_map(|f| {
                let lower = f.to_ascii_lowercase();
                let i = lower.find("bmgame/scripts/")?;
                (i == 0 || lower.as_bytes()[i - 1] == b'/').then(|| f[..i].trim_end_matches('/').to_string())
            })
            .filter(|d| !has_dir(&join(&join(d, "BmGame"), "CookedPCConsole")))
            .collect(),
    );
    for d in loose_roots {
        let mappings = take_game_layout(&files, &d, &mut claimed);
        if !mappings.is_empty() {
            let scripts: Vec<&str> = mappings.iter().filter(|m| ext(&m.dest) == "cs").map(|m| file_name(&m.dest)).collect();
            found.push(Detected {
                name: name_of(&d),
                kind: Kind::LooseScripts,
                description: format!("BmSDK scripts: {}", summarize(&scripts)),
                files: mappings,
            });
        }
    }

    // Replacers: files laid out like the game folder that go in place of the game's own
    let replacer_roots = outermost(
        files
            .iter()
            .filter(|f| !is_claimed(&claimed, f) && !is_document(f))
            .flat_map(|f| {
                let mut roots = Vec::new();
                let mut cur = parent(f);
                loop {
                    let rf = rel(f, cur);
                    if is_game_layout(rf) {
                        roots.push(cur.to_string());
                    }
                    if cur.is_empty() {
                        break;
                    }
                    cur = parent(cur);
                }
                roots
            })
            .collect(),
    );
    for d in replacer_roots {
        let mappings = take_game_layout(&files, &d, &mut claimed);
        if mappings.is_empty() {
            continue;
        }
        let is_asi = mappings.iter().all(|m| first_segment(&m.dest) == "binaries")
            && mappings.iter().any(|m| ext(&m.dest) == "asi");
        found.push(if is_asi {
            Detected { name: name_of(&d), kind: Kind::AsiPlugin, description: "ASI plugin loaded by the ASI loader".into(), files: mappings }
        } else {
            replacer(name_of(&d), mappings)
        });
    }

    // Loose ASI plugins go next to the SDK's own host plugin
    let asi: Vec<&String> = files.iter().filter(|f| !is_claimed(&claimed, f) && ext(f) == "asi").collect();
    if !asi.is_empty() {
        let mut mappings = Vec::new();
        for f in &asi {
            let stem = &f[..f.len() - 4];
            for g in files.iter().filter(|g| !is_claimed(&claimed, g) && (g.eq_ignore_ascii_case(f) || g.eq_ignore_ascii_case(&format!("{stem}.ini")))) {
                mappings.push(Mapping { src: g.clone(), dest: format!("Binaries/Win64/plugins/{}", file_name(g)) });
            }
        }
        for m in &mappings {
            claim(&mut claimed, &m.src);
        }
        let name = if asi.len() == 1 { sanitize_folder(&file_name(asi[0])[..file_name(asi[0]).len() - 4]) } else { sanitize_folder(fallback_name) };
        found.push(Detected { name, kind: Kind::AsiPlugin, description: "ASI plugin loaded by the ASI loader".into(), files: mappings });
    }

    // Loose files named like exactly one of the game's own go where that file is
    if let Some(game) = game {
        let loose: Vec<&String> = files.iter().filter(|f| !is_claimed(&claimed, f) && !is_document(f) && !is_proxy(f)).collect();
        if !loose.is_empty() {
            let index = game_files_by_name(game);
            let mut seen: HashMap<String, usize> = HashMap::new();
            for f in &loose {
                *seen.entry(file_name(f).to_ascii_lowercase()).or_default() += 1;
            }
            let mappings: Vec<Mapping> = loose
                .iter()
                .filter_map(|f| {
                    let key = file_name(f).to_ascii_lowercase();
                    // The same name twice in one archive is usually variants to pick from, so neither is guessed
                    match index.get(&key) {
                        Some(paths) if paths.len() == 1 && seen[&key] == 1 => Some(Mapping { src: (*f).clone(), dest: paths[0].clone() }),
                        _ => None,
                    }
                })
                .collect();
            if !mappings.is_empty() {
                for m in &mappings {
                    claim(&mut claimed, &m.src);
                }
                found.push(replacer(sanitize_folder(fallback_name), mappings));
            }
        }
    }

    // Loaders and injectors like ReShade go next to the exe, with the folders they came with
    let proxy_roots =
        outermost(files.iter().filter(|f| !is_claimed(&claimed, f) && is_proxy(f)).map(|f| parent(f).to_string()).collect());
    for d in proxy_roots {
        let mappings: Vec<Mapping> = files
            .iter()
            .filter(|f| inside(f, &d) && !is_claimed(&claimed, f) && !is_document(f))
            .map(|f| Mapping { src: f.clone(), dest: join("Binaries/Win64", rel(f, &d)) })
            .collect();
        for m in &mappings {
            claim(&mut claimed, &m.src);
        }
        found.push(replacer(name_of(&d), mappings));
    }

    let leftovers: Vec<&String> = files.iter().filter(|f| !is_claimed(&claimed, f) && !is_document(f)).collect();

    // An archive of bare .cs files: they all go in BmGame\Scripts
    if found.is_empty() && !leftovers.is_empty() && leftovers.iter().all(|f| ext(f) == "cs") {
        let mappings: Vec<Mapping> =
            leftovers.iter().map(|f| Mapping { src: (*f).clone(), dest: format!("BmGame/Scripts/{}", file_name(f)) }).collect();
        let scripts: Vec<&str> = mappings.iter().map(|m| file_name(&m.dest)).collect();
        found.push(Detected {
            name: if scripts.len() == 1 { scripts[0].to_string() } else { sanitize_folder(fallback_name) },
            kind: Kind::LooseScripts,
            description: format!("BmSDK scripts: {}", summarize(&scripts)),
            files: mappings,
        });
        return found;
    }

    if found.is_empty() && !leftovers.is_empty() && leftovers.iter().all(|f| ext(f) == "dds") {
        found.push(Detected {
            name: sanitize_folder(fallback_name),
            kind: Kind::ResoRep,
            description: "Loose .dds textures for ResoRep. Install ResoRep and copy these into its folder.".into(),
            files: Vec::new(),
        });
    }

    found
}

fn replacer(name: String, files: Vec<Mapping>) -> Detected {
    let mut tops: Vec<&str> = files.iter().map(|m| m.dest.split('/').next().unwrap_or_default()).collect();
    tops.sort_unstable();
    tops.dedup();
    let count = files.len();
    let description = format!("Replaces or adds {count} game file{} in {}", plural(count), tops.join(", "));
    Detected { name, kind: Kind::Replacer, description, files }
}

fn is_proxy(path: &str) -> bool {
    PROXY_DLLS.contains(&file_name(path).to_ascii_lowercase().as_str())
}

/// The folder a TFC Installer mod sits in, found from one of its patch or mapping files.
/// Such a mod keeps its files in Game, System and TexturePack, or flat in its own folder in old ones.
fn tfc_root(f: &str) -> Option<String> {
    let e = ext(f);
    // IniPatch also covers IniPatchReadOnly and IniPatchCreateOrUpdate
    if !(e == "packagepatch" || e == "tfcmapping" || e.starts_with("inipatch")) {
        return None;
    }
    let segs: Vec<&str> = f.split('/').collect();
    let layout = segs[..segs.len() - 1]
        .iter()
        .position(|s| ["game", "system", "texturepack"].contains(&s.to_ascii_lowercase().as_str()));
    Some(match layout {
        Some(i) => segs[..i].join("/"),
        None => parent(f).to_string(),
    })
}

/// The game's own files by lower-case name, as game-relative paths.
fn game_files_by_name(game: &Path) -> HashMap<String, Vec<String>> {
    let mut index: HashMap<String, Vec<String>> = HashMap::new();
    for rel in vanilla_files(game) {
        index.entry(file_name(&rel).to_ascii_lowercase()).or_default().push(rel);
    }
    index
}

/// Game-relative paths, with `/`, of every file in the folders that hold the game's own files.
/// Mod folders, backups, logs and saves sit elsewhere and aren't in it.
pub fn vanilla_files(game: &Path) -> Vec<String> {
    let mut dirs: Vec<String> = GAME_CONTENT_DIRS.iter().map(|d| d.to_string()).collect();
    // Only the official content. The other folders under DLC\<number> are mods.
    for entry in fs::read_dir(game.join("DLC")).into_iter().flatten().flatten() {
        let n = entry.file_name().to_string_lossy().to_string();
        if is_digits(&n) {
            dirs.push(format!("DLC/{n}/Content"));
        }
    }

    let mut out = Vec::new();
    for d in &dirs {
        for f in list_files(&game.join(d.split('/').collect::<PathBuf>())) {
            out.push(format!("{d}/{f}"));
        }
    }
    // Just the exe's folder. plugins and sdk under it belong to mods.
    for entry in fs::read_dir(game.join("Binaries").join("Win64")).into_iter().flatten().flatten() {
        if entry.path().is_file() {
            out.push(format!("Binaries/Win64/{}", entry.file_name().to_string_lossy()));
        }
    }
    out
}

fn dlc_number(dir: &str) -> Option<String> {
    let segs: Vec<&str> = dir.split('/').collect();
    segs.windows(3)
        .find(|w| w[0].eq_ignore_ascii_case("DLC") && is_digits(w[1]))
        .map(|w| w[1].to_string())
}

/// A path relative to a candidate root that looks like it belongs in the game folder.
fn is_game_layout(rf: &str) -> bool {
    let segs: Vec<&str> = rf.split('/').collect();
    if segs.len() < 2 {
        return false;
    }
    match segs[0].to_ascii_lowercase().as_str() {
        "bmgame" | "binaries" | "engine" => true,
        "dlc" => segs.len() >= 3 && is_digits(segs[1]),
        _ => false,
    }
}

fn take_game_layout(files: &[String], root: &str, claimed: &mut HashSet<String>) -> Vec<Mapping> {
    let mut out = Vec::new();
    for f in files.iter().filter(|f| inside(f, root) && !claimed.contains(&f.to_ascii_lowercase())) {
        let rf = rel(f, root);
        if is_game_layout(rf) {
            out.push(Mapping { src: f.clone(), dest: rf.to_string() });
        }
    }
    for m in &out {
        claimed.insert(m.src.to_ascii_lowercase());
    }
    out
}

fn plural(n: usize) -> &'static str {
    if n == 1 { "" } else { "s" }
}

fn summarize(names: &[&str]) -> String {
    let shown = names.iter().take(3).copied().collect::<Vec<_>>().join(", ");
    if names.len() > 3 { format!("{shown} and {} more", names.len() - 3) } else { shown }
}

#[cfg(test)]
mod tests {
    use super::*;

    fn write(root: &Path, rel: &str, text: &str) {
        let path = root.join(rel);
        fs::create_dir_all(path.parent().unwrap()).unwrap();
        fs::write(path, text).unwrap();
    }

    fn dests(d: &Detected) -> Vec<&str> {
        let mut v: Vec<&str> = d.files.iter().map(|m| m.dest.as_str()).collect();
        v.sort();
        v
    }

    #[test]
    fn mixed_pack() {
        let dir = tempfile::tempdir().unwrap();
        let root = dir.path();
        write(root, "BmGame/Mods/Cam/mod.toml", "name = \"Camera Tools\"\nassembly = \"Cam.dll\"\n");
        write(root, "BmGame/Mods/Cam/Cam.dll", "x");
        write(root, "Binaries/Win64/Console.txt", "x");
        write(root, "Night Suit/BmGame/Config/BmGame.ini", "[BmGame.RGameInfo]\nShowcaseItems=(Item=\"Night\")");
        write(root, "Night Suit/BmGame/CookedPCConsole/Night.upk", "x");
        write(root, "Night Suit/readme.txt", "x");
        write(root, "Shadows/BmGame/Config/BmEngine.ini", "x");
        write(root, "Textures/tex.PackagePatch", "x");
        write(root, "readme.txt", "x");

        let found = detect(root, "Pack", None);
        let by = |k: Kind| found.iter().find(|d| d.kind == k).unwrap_or_else(|| panic!("no {k:?} in {found:#?}"));

        let script = by(Kind::PrebuiltDll);
        assert_eq!(script.name, "Camera Tools");
        assert_eq!(dests(script), vec!["Binaries/Win64/Console.txt", "BmGame/Mods/Cam/Cam.dll", "BmGame/Mods/Cam/mod.toml"]);

        let dlc = by(Kind::Dlc);
        assert_eq!(dlc.name, "Night Suit");
        assert_eq!(
            dests(dlc),
            vec!["DLC/356474/Night Suit/BmGame/Config/BmGame.ini", "DLC/356474/Night Suit/BmGame/CookedPCConsole/Night.upk"]
        );

        assert_eq!(dests(by(Kind::Replacer)), vec!["BmGame/Config/BmEngine.ini"]);
        assert!(found.iter().any(|d| d.kind == Kind::TfcInstaller));
        assert_eq!(found.len(), 4);
    }

    #[test]
    fn official_dlc_content_is_a_replacer() {
        let dir = tempfile::tempdir().unwrap();
        write(dir.path(), "DLC/356474/Content/BmGame/CookedPCConsole/a.upk", "x");
        let found = detect(dir.path(), "Fix", None);
        assert_eq!(found.len(), 1);
        assert_eq!(found[0].kind, Kind::Replacer);
        assert_eq!(dests(&found[0]), vec!["DLC/356474/Content/BmGame/CookedPCConsole/a.upk"]);
    }

    #[test]
    fn bare_scripts_and_asi() {
        let dir = tempfile::tempdir().unwrap();
        write(dir.path(), "MyScript.cs", "x");
        let found = detect(dir.path(), "S", None);
        assert_eq!(found[0].kind, Kind::LooseScripts);
        assert_eq!(dests(&found[0]), vec!["BmGame/Scripts/MyScript.cs"]);

        let dir = tempfile::tempdir().unwrap();
        write(dir.path(), "Fov/Fov.asi", "x");
        write(dir.path(), "Fov/Fov.ini", "x");
        let found = detect(dir.path(), "Fov", None);
        assert_eq!(found[0].kind, Kind::AsiPlugin);
        assert_eq!(dests(&found[0]), vec!["Binaries/Win64/plugins/Fov.asi", "Binaries/Win64/plugins/Fov.ini"]);
    }

    #[test]
    fn resorep_textures() {
        let dir = tempfile::tempdir().unwrap();
        write(dir.path(), "a.dds", "x");
        write(dir.path(), "preview.png", "x");
        let found = detect(dir.path(), "Tex", None);
        assert_eq!(found[0].kind, Kind::ResoRep);
    }

    #[test]
    fn tfc_installer_mod_is_never_half_installed() {
        let dir = tempfile::tempdir().unwrap();
        write(dir.path(), "Patch/GameProfile.xml", "x");
        write(dir.path(), "Patch/Game/BmGame/CookedPCConsole/BmGame.upk.PackagePatch", "x");
        write(dir.path(), "Patch/Game/DLC/356474/NewSuit/BmGame/Config/BmGame.ini", "[BmGame.RGameInfo]");
        write(dir.path(), "Patch/TexturePack/Skins.TFCMapping", "x");
        write(dir.path(), "Other/BmGame/Config/BmEngine.ini", "x");
        let found = detect(dir.path(), "Pack", None);
        assert_eq!(found.len(), 2);
        let tfc = found.iter().find(|d| d.kind == Kind::TfcInstaller).unwrap();
        assert_eq!(tfc.name, "Patch");
        assert!(tfc.files.is_empty());
        assert_eq!(dests(found.iter().find(|d| d.kind == Kind::Replacer).unwrap()), vec!["BmGame/Config/BmEngine.ini"]);

        // Plain files in TFC Installer's Game folder, with nothing to patch, copy like any other layout
        let dir = tempfile::tempdir().unwrap();
        write(dir.path(), "Game/BmGame/Movies/Intro.bik", "x");
        let found = detect(dir.path(), "Movie", None);
        assert_eq!(found[0].kind, Kind::Replacer);
        assert_eq!(dests(&found[0]), vec!["BmGame/Movies/Intro.bik"]);
    }

    #[test]
    fn loose_files_match_game_files_by_name() {
        let game = tempfile::tempdir().unwrap();
        write(game.path(), "BmGame/CookedPCConsole/Playable_Batman_SF.upk", "x");
        write(game.path(), "BmGame/Localization/INT/Hud.int", "x");
        write(game.path(), "BmGame/Localization/FRA/Hud.int", "x");
        write(game.path(), "DLC/356474/Content/BmGame/CookedPCConsole/Suit_SF.upk", "x");
        write(game.path(), "DLC/356474/SomeMod/BmGame/CookedPCConsole/Theirs.upk", "x");

        let dir = tempfile::tempdir().unwrap();
        write(dir.path(), "playable_batman_sf.upk", "x");
        write(dir.path(), "Suit_SF.upk", "x");
        write(dir.path(), "Hud.int", "x");
        write(dir.path(), "Theirs.upk", "x");
        write(dir.path(), "4K/BmEngine.ini", "x");
        write(dir.path(), "1080p/BmEngine.ini", "x");
        let found = detect(dir.path(), "Pack", Some(game.path()));
        assert_eq!(found.len(), 1);
        assert_eq!(found[0].kind, Kind::Replacer);
        // Hud.int is in two languages, Theirs.upk is another mod's and BmEngine.ini comes in two variants
        assert_eq!(
            dests(&found[0]),
            vec!["BmGame/CookedPCConsole/Playable_Batman_SF.upk", "DLC/356474/Content/BmGame/CookedPCConsole/Suit_SF.upk"]
        );
    }

    #[test]
    fn proxy_dll_pack_goes_next_to_the_exe() {
        let dir = tempfile::tempdir().unwrap();
        write(dir.path(), "ReShade/dxgi.dll", "x");
        write(dir.path(), "ReShade/ReShade.ini", "x");
        write(dir.path(), "ReShade/reshade-shaders/Shaders/a.fx", "x");
        write(dir.path(), "ReShade/readme.txt", "x");
        let found = detect(dir.path(), "Pack", None);
        assert_eq!(found[0].name, "ReShade");
        assert_eq!(
            dests(&found[0]),
            vec!["Binaries/Win64/ReShade.ini", "Binaries/Win64/dxgi.dll", "Binaries/Win64/reshade-shaders/Shaders/a.fx"]
        );
    }
}
