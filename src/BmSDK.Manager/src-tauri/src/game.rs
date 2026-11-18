use serde::Serialize;
use std::fs;
use std::path::{Path, PathBuf};
use std::process::Command;

pub const STEAM_APP_ID: &str = "208650";
const EPIC_APP_NAME: &str = "Cowbird";
const PROCESS_NAME: &str = "BatmanAK.exe";

#[derive(Serialize, Clone)]
pub struct GameInstall {
    pub path: String,
    pub source: String,
}

pub fn is_valid(dir: &Path) -> bool {
    dir.join("Binaries").join("Win64").join(PROCESS_NAME).is_file() && dir.join("BmGame").is_dir()
}

/// Accepts the game folder or a folder a few levels inside it, like Binaries\Win64.
pub fn find_root(path: &Path) -> Option<PathBuf> {
    path.ancestors().take(4).find(|dir| is_valid(dir)).map(normalize)
}

pub fn normalize(path: &Path) -> PathBuf {
    let full = std::path::absolute(path).unwrap_or_else(|_| path.to_path_buf());
    let text = full.to_string_lossy();
    let trimmed = text.trim_end_matches(['\\', '/']);
    // Keep "C:\" intact, a bare "C:" means the current directory on that drive
    if trimmed.ends_with(':') {
        full
    } else {
        PathBuf::from(trimmed)
    }
}

pub fn same_path(a: &Path, b: &Path) -> bool {
    normalize(a).to_string_lossy().eq_ignore_ascii_case(&normalize(b).to_string_lossy())
}

pub fn detect_all() -> Vec<GameInstall> {
    let mut found: Vec<GameInstall> = Vec::new();
    let candidates = detect_steam().into_iter().chain(detect_epic());

    for install in candidates {
        let path = normalize(Path::new(&install.path));
        if is_valid(&path) && !found.iter().any(|x| same_path(Path::new(&x.path), &path)) {
            found.push(GameInstall { path: path.to_string_lossy().into_owned(), source: install.source });
        }
    }

    found
}

pub fn store(dir: &Path) -> &'static str {
    if dir.join(".egstore").is_dir() {
        return "Epic Games";
    }

    let has_gog_info = fs::read_dir(dir).into_iter().flatten().flatten().any(|e| {
        let name = e.file_name().to_string_lossy().to_ascii_lowercase();
        name.starts_with("goggame-") && name.ends_with(".info")
    });
    if has_gog_info {
        return "GOG";
    }

    if dir.to_string_lossy().to_ascii_lowercase().contains("steamapps")
        || dir.join("Binaries").join("Win64").join("steam_api64.dll").is_file()
    {
        return "Steam";
    }

    "Unknown"
}

pub fn has_asi_loader(dir: &Path) -> bool {
    dir.join("Binaries").join("Win64").join("dinput8.dll").is_file()
}

pub fn sdk_dll(dir: &Path) -> PathBuf {
    dir.join("Binaries").join("Win64").join("sdk").join("BmSDK.dll")
}

pub fn sdk_version(dir: &Path) -> Option<String> {
    let dll = sdk_dll(dir);
    if !dll.is_file() {
        return None;
    }

    crate::winapi::product_version(&dll).map(|v| v.split('+').next().unwrap_or_default().to_string())
}

pub fn is_writable(dir: &Path) -> bool {
    let probe = dir.join(format!(".bmsdk-manager-{}.tmp", std::process::id()));
    match fs::File::create(&probe) {
        Ok(_) => {
            let _ = fs::remove_file(&probe);
            true
        }
        Err(_) => false,
    }
}

pub fn is_running() -> bool {
    crate::winapi::process_running(PROCESS_NAME)
}

pub fn launch(dir: &Path) -> Result<(), String> {
    if store(dir) == "Steam" {
        return opener::open(format!("steam://rungameid/{STEAM_APP_ID}")).map_err(|e| e.to_string());
    }

    let bin = dir.join("Binaries").join("Win64");
    Command::new(bin.join(PROCESS_NAME))
        .current_dir(&bin)
        .spawn()
        .map(|_| ())
        .map_err(|e| format!("Couldn't start the game: {e}"))
}

pub fn hidden_command(program: &str) -> Command {
    let mut cmd = Command::new(program);
    #[cfg(windows)]
    {
        use std::os::windows::process::CommandExt;
        const CREATE_NO_WINDOW: u32 = 0x0800_0000;
        cmd.creation_flags(CREATE_NO_WINDOW);
    }
    cmd
}

fn detect_steam() -> Vec<GameInstall> {
    let Some(steam) = steam_path() else {
        return Vec::new();
    };

    let mut libraries = vec![steam.clone()];
    if let Ok(text) = fs::read_to_string(steam.join("steamapps").join("libraryfolders.vdf")) {
        libraries.extend(vdf_values(&text, "path").into_iter().map(PathBuf::from));
    }

    libraries
        .into_iter()
        .filter_map(|library| {
            let manifest = library.join("steamapps").join(format!("appmanifest_{STEAM_APP_ID}.acf"));
            let text = fs::read_to_string(manifest).ok()?;
            let dir = vdf_values(&text, "installdir").into_iter().next()?;
            Some(GameInstall {
                path: library.join("steamapps").join("common").join(dir).to_string_lossy().into_owned(),
                source: "Steam".into(),
            })
        })
        .collect()
}

fn steam_path() -> Option<PathBuf> {
    use winreg::enums::{HKEY_CURRENT_USER, HKEY_LOCAL_MACHINE};
    use winreg::RegKey;

    let machine = RegKey::predef(HKEY_LOCAL_MACHINE)
        .open_subkey(r"SOFTWARE\WOW6432Node\Valve\Steam")
        .and_then(|k| k.get_value::<String, _>("InstallPath"));
    let user = RegKey::predef(HKEY_CURRENT_USER)
        .open_subkey(r"SOFTWARE\Valve\Steam")
        .and_then(|k| k.get_value::<String, _>("SteamPath"));

    machine.or(user).ok().map(PathBuf::from).filter(|p| p.is_dir())
}

fn detect_epic() -> Vec<GameInstall> {
    let program_data = std::env::var_os("ProgramData").map(PathBuf::from).unwrap_or_else(|| PathBuf::from(r"C:\ProgramData"));
    let manifests = program_data.join("Epic").join("EpicGamesLauncher").join("Data").join("Manifests");

    fs::read_dir(manifests)
        .into_iter()
        .flatten()
        .flatten()
        .filter(|e| e.path().extension().is_some_and(|x| x.eq_ignore_ascii_case("item")))
        .filter_map(|e| {
            let json: serde_json::Value = serde_json::from_str(&fs::read_to_string(e.path()).ok()?).ok()?;
            if json.get("AppName")?.as_str()? != EPIC_APP_NAME {
                return None;
            }
            Some(GameInstall { path: json.get("InstallLocation")?.as_str()?.to_string(), source: "Epic Games".into() })
        })
        .collect()
}

/// Values of a key in Valve's KeyValues text, like `"path"  "D:\\SteamLibrary"`.
fn vdf_values(text: &str, key: &str) -> Vec<String> {
    text.lines()
        .filter_map(|line| {
            let mut parts = line.split('"').filter(|s| !s.trim().is_empty());
            let k = parts.next()?;
            let v = parts.next()?;
            k.eq_ignore_ascii_case(key).then(|| v.replace(r"\\", r"\"))
        })
        .collect()
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn reads_vdf_values() {
        let text = "\"libraryfolders\"\n{\n\t\"0\"\n\t{\n\t\t\"path\"\t\t\"D:\\\\SteamLibrary\"\n\t\t\"label\"\t\t\"\"\n\t}\n}";
        assert_eq!(vdf_values(text, "path"), vec![r"D:\SteamLibrary".to_string()]);
    }

    #[test]
    fn normalize_keeps_drive_root() {
        assert_eq!(normalize(Path::new(r"C:\")), PathBuf::from(r"C:\"));
        assert_eq!(normalize(Path::new(r"C:\Games\BAK\")), PathBuf::from(r"C:\Games\BAK"));
    }
}
