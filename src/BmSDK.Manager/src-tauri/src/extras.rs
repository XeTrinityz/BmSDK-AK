//! Profiles, launching without mods, crash diagnostics and sharing a mod list.

use super::*;
use library::Profile;
use serde::Deserialize;
use std::collections::HashSet;
use std::time::Duration;

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
pub struct ProfileView {
    pub name: String,
    pub count: usize,
    /// True when exactly this profile's mods are on right now.
    pub active: bool,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
pub struct LogsAlert {
    /// Error lines in the last session's BmSDK.log. Zero once the logs have been looked at.
    pub errors: usize,
    /// Title of a crash report newer than the last look.
    pub crash: Option<String>,
}

pub fn logs_alert(state: &State, dir: &Path) -> LogsAlert {
    let sdk_modified = fs::metadata(logs::sdk_log(dir)).ok().map(|m| logs::modified_secs(&m)).unwrap_or(0);
    let errors = if sdk_modified > state.log_seen { logs::sdk_errors(dir).0 } else { 0 };
    let crash = logs::newest_crash(dir).filter(|c| c.modified > state.crash_seen).map(|c| c.title);
    LogsAlert { errors, crash }
}

/// Compares dotted versions like 1.2 and 1.10.0. None when either has no numbers to compare.
pub fn version_cmp(a: &str, b: &str) -> Option<std::cmp::Ordering> {
    let parts = |v: &str| -> Option<Vec<u64>> {
        let nums: Vec<u64> = v
            .trim()
            .trim_start_matches(['v', 'V'])
            .split(['.', '-', '+'])
            .map_while(|p| p.parse::<u64>().ok())
            .collect();
        (!nums.is_empty()).then_some(nums)
    };
    let (mut x, mut y) = (parts(a)?, parts(b)?);
    let len = x.len().max(y.len());
    x.resize(len, 0);
    y.resize(len, 0);
    Some(x.cmp(&y))
}

pub fn profile_views(state: &State) -> Vec<ProfileView> {
    let enabled: HashSet<&str> = state.mods.iter().filter(|m| m.enabled).map(|m| m.id.as_str()).collect();
    state
        .profiles
        .iter()
        .map(|p| {
            // Mods uninstalled since the profile was saved no longer count
            let present: Vec<&str> =
                p.mods.iter().map(String::as_str).filter(|id| state.mods.iter().any(|m| m.id == *id)).collect();
            ProfileView {
                name: p.name.clone(),
                count: present.len(),
                active: present.len() == enabled.len() && present.iter().all(|id| enabled.contains(id)),
            }
        })
        .collect()
}

fn enabled_in_order(state: &State) -> Vec<String> {
    let mut on: Vec<(u64, String)> = state.mods.iter().filter(|m| m.enabled).map(|m| (m.enabled_at, m.id.clone())).collect();
    on.sort();
    on.into_iter().map(|(_, id)| id).collect()
}

/// Leaves exactly `wanted` on. Returns how many were turned on and off.
fn apply_set(app: &AppHandle, state: &mut State, dir: &Path, wanted: &[String]) -> Res<(usize, usize)> {
    // Newest first when taking mods out, so each one finds the copy under it still in place
    let mut off: Vec<(u64, String)> =
        state.mods.iter().filter(|m| m.enabled && !wanted.contains(&m.id)).map(|m| (m.enabled_at, m.id.clone())).collect();
    off.sort_by(|a, b| b.0.cmp(&a.0));
    let on: Vec<String> =
        wanted.iter().filter(|id| state.mods.iter().any(|m| &m.id == *id && !m.enabled)).cloned().collect();

    let total = (off.len() + on.len()) as u64;
    let mut done = 0u64;
    let mut deployer = Deployer { state, game: dir.to_path_buf() };
    for (_, id) in &off {
        deployer.disable(id)?;
        done += 1;
        emit(app, "mods", done, total);
    }
    for id in &on {
        deployer.enable(id)?;
        done += 1;
        emit(app, "mods", done, total);
    }
    Ok((on.len(), off.len()))
}

#[tauri::command(async)]
pub fn save_profile(app: AppHandle, name: String) -> Res<()> {
    let name = name.trim().to_string();
    if name.is_empty() || name.chars().count() > 40 {
        return Err("Give the profile a name of up to 40 characters.".into());
    }

    let mut state = lock(&app);
    let mods = enabled_in_order(&state);
    match state.profiles.iter_mut().find(|p| p.name.eq_ignore_ascii_case(&name)) {
        Some(existing) => existing.mods = mods,
        None => state.profiles.push(Profile { name: name.clone(), mods }),
    }
    state.log("info", format!("Saved the profile {name}"));
    state.save()
}

#[tauri::command(async)]
pub fn apply_profile(app: AppHandle, name: String) -> Res<()> {
    let mut state = lock(&app);
    let dir = ready_to_change(&state)?;
    let wanted = state.profiles.iter().find(|p| p.name == name).ok_or("That profile is gone.")?.mods.clone();

    let result = apply_set(&app, &mut state, &dir, &wanted);
    match &result {
        Ok(_) => state.log("info", format!("Switched to the profile {name}")),
        Err(e) => state.log("error", format!("Couldn't switch to {name}: {e}")),
    }
    state.save()?;
    result.map(|_| ())
}

#[tauri::command(async)]
pub fn delete_profile(app: AppHandle, name: String) -> Res<()> {
    let mut state = lock(&app);
    state.profiles.retain(|p| p.name != name);
    state.save()
}

/// Turns every mod off, starts the game, and turns them back on once the game closes.
#[tauri::command(async)]
pub fn play_clean(app: AppHandle) -> Res<usize> {
    let mut state = lock(&app);
    let dir = ready_to_change(&state)?;
    if !state.suspended.is_empty() {
        return Err("Your mods are already off for a launch without mods. Turn them back on first.".into());
    }

    let before = enabled_in_order(&state);
    let result = apply_set(&app, &mut state, &dir, &[]);
    let now_off: Vec<String> =
        before.into_iter().filter(|id| state.mods.iter().any(|m| &m.id == id && !m.enabled)).collect();
    let count = now_off.len();
    state.suspended = now_off;
    state.log("info", format!("Turned off {count} mod{} to start the game without them", if count == 1 { "" } else { "s" }));
    state.save()?;
    result?;
    drop(state);

    if let Err(e) = game::launch(&dir) {
        let _ = restore_inner(&app);
        return Err(e);
    }
    watch_and_restore(app, true);
    Ok(count)
}

fn restore_inner(app: &AppHandle) -> Res<usize> {
    let mut state = lock(app);
    if state.suspended.is_empty() {
        return Ok(0);
    }
    let dir = ready_to_change(&state)?;
    let ids: Vec<String> =
        state.suspended.iter().filter(|id| state.mods.iter().any(|m| &m.id == *id && !m.enabled)).cloned().collect();

    let mut deployer = Deployer { state: &mut state, game: dir };
    let result = ids.iter().try_for_each(|id| deployer.enable(id));
    match &result {
        Ok(()) => {
            state.suspended.clear();
            state.log("success", format!("Turned {} mod{} back on", ids.len(), if ids.len() == 1 { "" } else { "s" }));
        }
        Err(e) => state.log("error", format!("Couldn't turn your mods back on: {e}")),
    }
    state.save()?;
    result.map(|_| ids.len())
}

#[tauri::command(async)]
pub fn restore_suspended(app: AppHandle) -> Res<usize> {
    restore_inner(&app)
}

/// Waits for the game to close, then turns the suspended mods back on.
pub fn watch_and_restore(app: AppHandle, wait_for_start: bool) {
    std::thread::spawn(move || {
        let pause = || std::thread::sleep(Duration::from_secs(2));

        if wait_for_start {
            // Steam can take a while to bring the game up. If it never does, the Home banner offers a manual restore.
            let started = (0..90).any(|_| {
                pause();
                game::is_running()
            });
            if !started {
                return;
            }
            let _ = app.emit("state-changed", ());
        }

        while game::is_running() {
            pause();
        }
        // Give the game a moment to let go of its files
        pause();
        let _ = restore_inner(&app);
        let _ = app.emit("state-changed", ());
    });
}

/// Marks the logs and crash reports as looked at, which clears the alert on the Logs icon.
#[tauri::command(async)]
pub fn ack_logs(app: AppHandle) -> Res<()> {
    let mut state = lock(&app);
    state.crash_seen = library::now();
    state.log_seen = library::now();
    state.save()
}

fn kind_label(kind: Kind) -> &'static str {
    match kind {
        Kind::ScriptMod => "Script mod",
        Kind::PrebuiltDll => "Prebuilt DLL",
        Kind::LooseScripts => "Loose script",
        Kind::Dlc => "Suit / DLC",
        Kind::Replacer => "Replacer",
        Kind::AsiPlugin => "ASI plugin",
        Kind::TfcInstaller | Kind::ResoRep => "Not supported",
    }
}

/// Swaps every occurrence of `word` for `with`, ignoring ASCII case.
fn redact(text: &str, word: &str, with: &str) -> String {
    if word.len() < 3 {
        return text.to_string();
    }
    let lower = text.to_ascii_lowercase();
    let needle = word.to_ascii_lowercase();
    let mut out = String::with_capacity(text.len());
    let mut at = 0;
    while let Some(i) = lower[at..].find(&needle) {
        out.push_str(&text[at..at + i]);
        out.push_str(with);
        at += i + needle.len();
    }
    out.push_str(&text[at..]);
    out
}

fn yes_no(value: bool) -> &'static str {
    if value { "yes" } else { "no" }
}

/// A text summary to paste into a bug report. Windows user and PC names are taken out.
#[tauri::command(async)]
pub fn diagnostics(app: AppHandle) -> Res<String> {
    let state = lock(&app);
    let dir = state.game()?;
    let mut out = String::new();

    out += &format!("BmSDK Manager {}\n", release::manager_version());
    out += &format!("BmSDK: {}\n", game::sdk_version(&dir).unwrap_or_else(|| "not installed".into()));
    out += &format!(
        "Game: {} copy, ASI loader: {}, folder writable: {}\n",
        game::store(&dir),
        yes_no(game::has_asi_loader(&dir)),
        yes_no(game::is_writable(&dir))
    );

    let on: Vec<&library::ModRecord> = state.mods.iter().filter(|m| m.enabled).collect();
    out += &format!("\nMods on ({}):\n", on.len());
    for m in &on {
        let version = library::version_of(m, Some(&dir)).map(|v| format!(" v{v}")).unwrap_or_default();
        out += &format!("- {} [{}]{version}\n", m.name, kind_label(m.kind));
    }
    let off: Vec<&str> = state.mods.iter().filter(|m| !m.enabled).map(|m| m.name.as_str()).collect();
    if !off.is_empty() {
        out += &format!("\nMods off ({}): {}\n", off.len(), off.join(", "));
    }
    drop(state);

    match logs::read_tail(&logs::sdk_log(&dir), 256 * 1024) {
        Ok(log) => {
            let lines: Vec<&str> = log.text.lines().collect();
            let tail = &lines[lines.len().saturating_sub(100)..];
            out += &format!("\n--- BmSDK.log, last {} lines ---\n{}\n", tail.len(), tail.join("\n"));
        }
        Err(_) => out += "\n--- BmSDK.log: none ---\n",
    }

    if let Some(crash) = logs::newest_crash(&dir) {
        if let Ok(report) = logs::read_tail(Path::new(&crash.path), 64 * 1024) {
            // The first line names the PC and the account, so it stays out
            let body: Vec<&str> = report.text.lines().skip(1).take(40).collect();
            out += &format!("\n--- Newest crash report, {} ---\n{}\n", crash.title, body.join("\n"));
        }
    }

    for (var, with) in [("USERNAME", "<user>"), ("COMPUTERNAME", "<pc>")] {
        if let Ok(value) = std::env::var(var) {
            out = redact(&out, &value, with);
        }
    }
    Ok(out)
}

#[derive(Serialize, Deserialize)]
struct ListEntry {
    name: String,
    kind: Kind,
    enabled: bool,
    #[serde(default, skip_serializing_if = "Option::is_none")]
    version: Option<String>,
}

#[derive(Serialize, Deserialize)]
struct ListFile {
    manager: String,
    sdk: Option<String>,
    mods: Vec<ListEntry>,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
pub struct ImportResult {
    pub turned_on: usize,
    pub turned_off: usize,
    /// Mods the list wants on that aren't in this library.
    pub missing: Vec<String>,
}

#[tauri::command(async)]
pub fn export_list(app: AppHandle, path: String) -> Res<usize> {
    let state = lock(&app);
    let dir = state.game().ok();
    let list = ListFile {
        manager: release::manager_version().into(),
        sdk: dir.as_ref().and_then(|d| game::sdk_version(d)),
        mods: state
            .mods
            .iter()
            .map(|m| ListEntry {
                name: m.name.clone(),
                kind: m.kind,
                enabled: m.enabled,
                version: library::version_of(m, dir.as_deref()),
            })
            .collect(),
    };

    let mut path = PathBuf::from(path);
    if !path.extension().is_some_and(|e| e.eq_ignore_ascii_case("json")) {
        path.set_extension("json");
    }
    let json = serde_json::to_vec_pretty(&list).map_err(|e| e.to_string())?;
    fs::write(&path, json).map_err(|e| format!("Couldn't save the list: {e}"))?;
    Ok(list.mods.len())
}

/// Turns on the mods a shared list has on, for the ones this library has. The list has no files, so it can't install any.
#[tauri::command(async)]
pub fn import_list(app: AppHandle, path: String) -> Res<ImportResult> {
    let path = Path::new(&path);
    if fs::metadata(path).map(|m| m.len()).unwrap_or(0) > 1024 * 1024 {
        return Err("That file is too big to be a mod list.".into());
    }
    let text = fs::read_to_string(path).map_err(|e| format!("Couldn't read the list: {e}"))?;
    let list: ListFile = serde_json::from_str(&text).map_err(|_| "That file isn't a mod list from BmSDK Manager.".to_string())?;

    let mut state = lock(&app);
    let dir = ready_to_change(&state)?;

    let mut wanted = Vec::new();
    let mut missing = Vec::new();
    for entry in list.mods.iter().filter(|e| e.enabled) {
        match state.mods.iter().find(|m| m.kind == entry.kind && m.name.eq_ignore_ascii_case(&entry.name)) {
            Some(m) => wanted.push(m.id.clone()),
            None => missing.push(entry.name.clone()),
        }
    }

    let result = apply_set(&app, &mut state, &dir, &wanted);
    match &result {
        Ok(_) => state.log("info", "Applied a shared mod list"),
        Err(e) => state.log("error", format!("Couldn't apply the mod list: {e}")),
    }
    state.save()?;
    let (turned_on, turned_off) = result?;
    Ok(ImportResult { turned_on, turned_off, missing })
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn redacts_names_in_any_case() {
        assert_eq!(redact(r"C:\Users\Alice\x and ALICE", "alice", "<user>"), r"C:\Users\<user>\x and <user>");
        // Too short to be safe to replace everywhere
        assert_eq!(redact("an a", "a", "<user>"), "an a");
    }

    #[test]
    fn compares_versions() {
        use std::cmp::Ordering::*;
        assert_eq!(version_cmp("1.2", "1.10"), Some(Less));
        assert_eq!(version_cmp("v2.0.0", "2"), Some(Equal));
        assert_eq!(version_cmp("1.0.1", "1.0"), Some(Greater));
        assert_eq!(version_cmp("beta", "1.0"), None);
    }

    #[test]
    fn list_round_trips() {
        let json = r#"{"manager":"0.24.1","sdk":null,"mods":[{"name":"Cam","kind":"scriptMod","enabled":true}]}"#;
        let list: ListFile = serde_json::from_str(json).unwrap();
        assert_eq!(list.mods[0].kind, Kind::ScriptMod);
        assert!(list.mods[0].version.is_none());
    }
}
