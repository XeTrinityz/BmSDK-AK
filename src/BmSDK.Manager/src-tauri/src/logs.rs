use serde::Serialize;
use std::fs;
use std::io::{Read, Seek, SeekFrom};
use std::path::{Path, PathBuf};
use std::time::UNIX_EPOCH;

/// Only the end of a big log is read. The newest lines are the ones that matter when something breaks.
const MAX_READ: u64 = 2 * 1024 * 1024;
const MAX_CRASH_REPORTS: usize = 10;

#[derive(Serialize, Clone)]
#[serde(rename_all = "camelCase")]
pub struct LogSource {
    pub path: String,
    pub title: String,
    /// "sdk", "mod" or "crash"
    pub group: String,
    pub size: u64,
    pub modified: u64,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
pub struct LogText {
    pub text: String,
    pub truncated: bool,
    pub size: u64,
    pub modified: u64,
}

fn source(path: &Path, title: String, group: &str) -> Option<LogSource> {
    let meta = fs::metadata(path).ok()?;
    if !meta.is_file() {
        return None;
    }
    Some(LogSource {
        path: path.to_string_lossy().into_owned(),
        title,
        group: group.into(),
        size: meta.len(),
        modified: modified_secs(&meta),
    })
}

pub fn modified_secs(meta: &fs::Metadata) -> u64 {
    meta.modified().ok().and_then(|t| t.duration_since(UNIX_EPOCH).ok()).map(|d| d.as_secs()).unwrap_or(0)
}

fn files_in(dir: &Path) -> Vec<PathBuf> {
    fs::read_dir(dir).into_iter().flatten().flatten().map(|e| e.path()).collect()
}

fn has_ext(path: &Path, ext: &str) -> bool {
    path.extension().is_some_and(|e| e.eq_ignore_ascii_case(ext))
}

pub fn list(game: &Path) -> Vec<LogSource> {
    collect(game, Some(MAX_CRASH_REPORTS))
}

fn collect(game: &Path, crash_cap: Option<usize>) -> Vec<LogSource> {
    let mut out = Vec::new();

    out.extend(source(&sdk_log(game), "BmSDK.log".into(), "sdk"));

    let mut mod_dirs: Vec<PathBuf> = files_in(&game.join("BmGame").join("Mods")).into_iter().filter(|p| p.is_dir()).collect();
    mod_dirs.sort();
    for dir in mod_dirs {
        let folder = dir.file_name().unwrap_or_default().to_string_lossy().into_owned();
        for rel in crate::detect::list_files(&dir).into_iter().filter(|f| has_ext(Path::new(f), "log")) {
            out.extend(source(&dir.join(&rel), format!("{folder} · {rel}"), "mod"));
        }
    }

    let logs_dir = game.join("BmGame").join("Logs");
    let mut crash: Vec<LogSource> = files_in(&logs_dir)
        .into_iter()
        .filter(|p| {
            let name = p.file_name().unwrap_or_default().to_string_lossy().to_ascii_lowercase();
            (name.starts_with("ue3autoreportdump") && has_ext(p, "txt")) || has_ext(p, "log")
        })
        .filter_map(|p| {
            let title = p.file_name().unwrap_or_default().to_string_lossy().into_owned();
            source(&p, title, "crash")
        })
        .collect();
    crash.sort_by(|a, b| b.modified.cmp(&a.modified));
    if let Some(cap) = crash_cap {
        crash.truncate(cap);
    }
    out.extend(crash);

    out
}

#[derive(Serialize)]
pub struct Cleared {
    pub deleted: usize,
    /// Logs that couldn't be removed, usually because the game has them open.
    pub failed: usize,
}

/// Deletes every log the list can show, plus older crash reports. Crash dumps (.dmp) are left alone.
pub fn clear(game: &Path) -> Cleared {
    let mut cleared = Cleared { deleted: 0, failed: 0 };
    for s in collect(game, None) {
        let path = Path::new(&s.path);
        if let Ok(meta) = fs::metadata(path) {
            let mut perms = meta.permissions();
            if perms.readonly() {
                #[allow(clippy::permissions_set_readonly_false)]
                perms.set_readonly(false);
                let _ = fs::set_permissions(path, perms);
            }
        }
        match fs::remove_file(path) {
            Ok(()) => cleared.deleted += 1,
            Err(_) => cleared.failed += 1,
        }
    }
    cleared
}

/// Reads a log the list offered. Anything else is refused so the UI can't be used to read other files.
pub fn read(game: &Path, path: &str) -> Result<LogText, String> {
    if !list(game).iter().any(|s| s.path == path) {
        return Err("That log isn't available any more.".into());
    }

    read_tail(Path::new(path), MAX_READ)
}

/// Reads the last `max` bytes of a text file as lines.
pub fn read_tail(path: &Path, max: u64) -> Result<LogText, String> {
    let mut file = fs::File::open(path).map_err(|e| format!("Couldn't open the log: {e}"))?;
    let meta = file.metadata().map_err(|e| e.to_string())?;
    let size = meta.len();
    let truncated = size > max;
    if truncated {
        file.seek(SeekFrom::Start(size - max)).map_err(|e| e.to_string())?;
    }
    let mut bytes = Vec::new();
    file.take(max).read_to_end(&mut bytes).map_err(|e| e.to_string())?;

    let mut text = decode(&bytes);
    if truncated {
        // The cut usually lands mid-line, so drop that partial line
        if let Some(i) = text.find('\n') {
            text.drain(..=i);
        }
    }

    Ok(LogText { text, truncated, size, modified: modified_secs(&meta) })
}

fn is_error_line(line: &str) -> bool {
    const WORDS: [&str; 6] = ["error", "exception", "failed", "fatal", "crash", "crashed"];
    line.split(|c: char| !c.is_ascii_alphanumeric()).any(|w| WORDS.iter().any(|k| w.eq_ignore_ascii_case(k)))
}

pub fn sdk_log(game: &Path) -> PathBuf {
    game.join("Binaries").join("Win64").join("BmSDK.log")
}

/// How many error lines the last session's BmSDK.log has, and when it was written.
pub fn sdk_errors(game: &Path) -> (usize, u64) {
    match read_tail(&sdk_log(game), 512 * 1024) {
        Ok(log) => (log.text.lines().filter(|l| is_error_line(l)).count(), log.modified),
        Err(_) => (0, 0),
    }
}

pub fn newest_crash(game: &Path) -> Option<LogSource> {
    list(game).into_iter().find(|s| s.group == "crash")
}

/// The game writes crash reports as UTF-16. BmSDK and most mods write UTF-8.
fn decode(bytes: &[u8]) -> String {
    let utf16_le = bytes.starts_with(&[0xFF, 0xFE])
        || (bytes.len() >= 4 && bytes.iter().skip(1).step_by(2).take(64).filter(|b| **b == 0).count() > 16);

    if utf16_le {
        let body = bytes.strip_prefix(&[0xFF, 0xFE]).unwrap_or(bytes);
        let units: Vec<u16> = body.chunks_exact(2).map(|c| u16::from_le_bytes([c[0], c[1]])).collect();
        String::from_utf16_lossy(&units)
    } else {
        let body = bytes.strip_prefix(&[0xEF, 0xBB, 0xBF]).unwrap_or(bytes);
        String::from_utf8_lossy(body).into_owned()
    }
    .replace("\r\n", "\n")
}

pub fn reveal(game: &Path, path: &str) -> Result<(), String> {
    if !list(game).iter().any(|s| s.path == path) {
        return Err("That log isn't available any more.".into());
    }
    use std::os::windows::process::CommandExt;
    // Explorer wants /select,"path" as is. A normal arg would quote the whole thing and it gets ignored.
    std::process::Command::new("explorer.exe")
        .raw_arg(format!("/select,\"{path}\""))
        .spawn()
        .map(|_| ())
        .map_err(|e| e.to_string())
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn spots_error_lines() {
        assert!(is_error_line("Entry.cs: Unhandled exception in OnTick"));
        assert!(is_error_line("Loader: [Cam] build FAILED"));
        assert!(!is_error_line("Slow frame 406 ms. Knightfall OnTick 86.1 ms"));
        assert!(!is_error_line("Loader: 9 scripts unchanged, loaded the last build"));
    }

    #[test]
    fn decodes_utf8_and_utf16() {
        assert_eq!(decode(b"Loader: hi\r\nok"), "Loader: hi\nok");

        let mut utf16 = vec![0xFF, 0xFE];
        utf16.extend("Fatal error!\r\n".encode_utf16().flat_map(|u| u.to_le_bytes()));
        assert_eq!(decode(&utf16), "Fatal error!\n");

        // Crash reports sometimes have no byte order mark
        let bare: Vec<u8> = "Address = 0x45d6627c in BatmanAK.exe".encode_utf16().flat_map(|u| u.to_le_bytes()).collect();
        assert_eq!(decode(&bare), "Address = 0x45d6627c in BatmanAK.exe");
    }

    #[test]
    fn clear_removes_logs_but_not_dumps() {
        let dir = tempfile::tempdir().unwrap();
        let game = dir.path();
        let sdk = game.join("Binaries").join("Win64");
        let logs = game.join("BmGame").join("Logs");
        let mod_dir = game.join("BmGame").join("Mods").join("Cam");
        for d in [&sdk, &logs, &mod_dir] {
            fs::create_dir_all(d).unwrap();
        }
        fs::write(sdk.join("BmSDK.log"), "x").unwrap();
        fs::write(mod_dir.join("cam.log"), "x").unwrap();
        fs::write(mod_dir.join("mod.toml"), "x").unwrap();
        for i in 0..12 {
            fs::write(logs.join(format!("UE3AutoReportDump{i:04}.txt")), "x").unwrap();
        }
        fs::write(logs.join("crash.dmp"), "x").unwrap();

        let result = clear(game);
        assert_eq!((result.deleted, result.failed), (14, 0));
        assert!(!sdk.join("BmSDK.log").exists());
        assert!(mod_dir.join("mod.toml").exists());
        assert!(logs.join("crash.dmp").exists());
        assert!(list(game).is_empty());
    }

    #[test]
    fn only_listed_logs_can_be_read() {
        let dir = tempfile::tempdir().unwrap();
        let game = dir.path();
        let sdk = game.join("Binaries").join("Win64");
        fs::create_dir_all(&sdk).unwrap();
        fs::write(sdk.join("BmSDK.log"), "Loader: ok").unwrap();
        fs::write(game.join("secret.txt"), "no").unwrap();

        let log = sdk.join("BmSDK.log").to_string_lossy().into_owned();
        assert_eq!(read(game, &log).unwrap().text, "Loader: ok");
        assert!(read(game, &game.join("secret.txt").to_string_lossy()).is_err());
    }
}
