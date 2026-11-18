mod archive;
mod detect;
mod extras;
mod game;
mod library;
mod logs;
mod nexus;
mod release;
#[cfg(windows)]
mod winapi;

use detect::{Detected, Kind};
use library::{Deployer, State};
use serde::Serialize;
use std::collections::HashMap;
use std::fs;
use std::path::{Path, PathBuf};
use std::sync::Mutex;
use tauri::{AppHandle, Emitter, Manager};

struct Pending {
    source: String,
    dir: PathBuf,
    extracted: bool,
    found: Vec<Detected>,
}

struct App {
    state: Mutex<State>,
    pending: Mutex<HashMap<String, Pending>>,
}

type Res<T> = Result<T, String>;

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
struct GameView {
    path: String,
    store: String,
    writable: bool,
    running: bool,
    sdk_version: Option<String>,
    asi_loader: bool,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
struct ModView {
    id: String,
    name: String,
    kind: Kind,
    description: String,
    source: String,
    enabled: bool,
    location: String,
    file_count: usize,
    size: u64,
    /// Enabled mods that change some of the same files.
    shares_with: Vec<String>,
    added: u64,
    version: Option<String>,
    nexus: Option<nexus::NexusView>,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
struct Overview {
    manager_version: String,
    repo: String,
    setup_done: bool,
    check_on_start: bool,
    game: Option<GameView>,
    mods: Vec<ModView>,
    backed_up: usize,
    library_dir: String,
    activity: Vec<library::Activity>,
    profiles: Vec<extras::ProfileView>,
    /// Mods waiting to come back on after a launch without mods.
    suspended: usize,
    logs_alert: extras::LogsAlert,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
struct ReviewMod {
    index: usize,
    name: String,
    kind: Kind,
    supported: bool,
    description: String,
    targets: Vec<String>,
    file_count: usize,
    /// Enabled mods that already change some of these files.
    shares_with: Vec<String>,
    /// Game files that will be moved to the backup folder first.
    backs_up: usize,
    /// An installed mod with the same name and type, which this one replaces.
    replaces: Option<String>,
    version: Option<String>,
    installed_version: Option<String>,
    /// "newer", "older" or "same" compared with the installed one this replaces.
    version_change: Option<&'static str>,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
struct Review {
    id: String,
    source: String,
    size: u64,
    mods: Vec<ReviewMod>,
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
struct Updates {
    latest: String,
    url: String,
    sdk_installed: Option<String>,
    sdk_update: bool,
    sdk_size: u64,
    manager_update: bool,
}

#[derive(Serialize, Clone)]
#[serde(rename_all = "camelCase")]
struct Progress {
    task: String,
    done: u64,
    total: u64,
}

fn emit(app: &AppHandle, task: &str, done: u64, total: u64) {
    let _ = app.emit("progress", Progress { task: task.into(), done, total });
}

fn lock(app: &AppHandle) -> std::sync::MutexGuard<'_, State> {
    app.state::<App>().inner().state.lock().unwrap_or_else(|e| e.into_inner())
}

fn game_view(dir: &Path) -> GameView {
    GameView {
        path: dir.to_string_lossy().into_owned(),
        store: game::store(dir).into(),
        writable: game::is_writable(dir),
        running: game::is_running(),
        sdk_version: game::sdk_version(dir),
        asi_loader: game::has_asi_loader(dir),
    }
}

fn file_size(path: &Path) -> u64 {
    fs::metadata(path).map(|m| m.len()).unwrap_or(0)
}

fn shares_with(state: &State, files: &[String], except: Option<&str>) -> Vec<String> {
    let mut names: Vec<String> = state
        .mods
        .iter()
        .filter(|m| m.enabled && Some(m.id.as_str()) != except)
        .filter(|m| m.files.iter().any(|f| files.iter().any(|g| g.eq_ignore_ascii_case(f))))
        .map(|m| m.name.clone())
        .collect();
    names.sort();
    names.dedup();
    names
}

/// Checks the things every change to the game folder needs.
fn ready_to_change(state: &State) -> Res<PathBuf> {
    let dir = state.game()?;
    if game::is_running() {
        return Err("Close the game first. Its files are locked while it runs.".into());
    }
    if !game::is_writable(&dir) {
        return Err("needs_admin".into());
    }
    Ok(dir)
}

#[tauri::command(async)]
fn get_overview(app: AppHandle) -> Overview {
    let state = lock(&app);
    let game = state.game_dir.as_ref().map(|d| game_view(Path::new(d)));
    let game_dir = state.game_dir.clone().map(PathBuf::from);

    let mods = state
        .mods
        .iter()
        .map(|m| {
            let size = m
                .files
                .iter()
                .map(|f| {
                    let lib = library::library_dir().join(&m.id).join(f);
                    if lib.exists() {
                        file_size(&lib)
                    } else {
                        game_dir.as_ref().map(|g| file_size(&g.join(f))).unwrap_or(0)
                    }
                })
                .sum();
            ModView {
                id: m.id.clone(),
                name: m.name.clone(),
                kind: m.kind,
                description: m.description.clone(),
                source: m.source.clone(),
                enabled: m.enabled,
                location: library::location(m),
                file_count: m.files.len(),
                size,
                shares_with: if m.enabled { shares_with(&state, &m.files, Some(&m.id)) } else { Vec::new() },
                added: m.added,
                version: library::version_of(m, game_dir.as_deref()),
                nexus: m.nexus.as_ref().map(nexus::view),
            }
        })
        .collect();

    Overview {
        manager_version: release::manager_version().into(),
        repo: release::REPO.into(),
        setup_done: state.setup_done,
        check_on_start: state.check_on_start,
        game,
        mods,
        backed_up: state.originals.len(),
        library_dir: library::library_dir().to_string_lossy().into_owned(),
        activity: state.activity.iter().rev().take(20).cloned().collect(),
        profiles: extras::profile_views(&state),
        suspended: state.suspended.len(),
        logs_alert: match &game_dir {
            Some(dir) => extras::logs_alert(&state, dir),
            None => extras::LogsAlert { errors: 0, crash: None },
        },
    }
}

#[tauri::command(async)]
fn detect_games() -> Vec<game::GameInstall> {
    game::detect_all()
}

#[tauri::command(async)]
fn set_game_dir(app: AppHandle, path: String) -> Res<usize> {
    let dir = game::find_root(Path::new(&path))
        .ok_or("That folder isn't a Batman: Arkham Knight install. Pick the folder with Binaries and BmGame in it.")?;
    let mut state = lock(&app);

    let same = state.game_dir.as_ref().is_some_and(|d| game::same_path(Path::new(d), &dir));
    if !same {
        // Mods that are on stay with the old folder. Ones that are off live in the library and can go in the new one.
        for m in state.mods.iter().filter(|m| m.enabled) {
            let _ = fs::remove_dir_all(library::library_dir().join(&m.id));
        }
        state.mods.retain(|m| !m.enabled);
        state.originals.clear();
        state.game_dir = Some(dir.to_string_lossy().into_owned());
        state.log("info", format!("Using the game in {}", dir.display()));
    }

    let found = library::import_existing(&mut state, &dir);
    if found > 0 {
        state.log("info", format!("Found {found} mod{} already in the game", if found == 1 { "" } else { "s" }));
    }
    state.save()?;
    Ok(found)
}

#[tauri::command]
async fn check_updates(app: AppHandle) -> Res<Updates> {
    let latest = release::latest().await?;
    let installed = {
        let state = lock(&app);
        state.game_dir.as_ref().and_then(|d| game::sdk_version(Path::new(d)))
    };

    Ok(Updates {
        sdk_update: latest.sdk_zip.is_some()
            && installed.as_ref().is_none_or(|v| release::is_newer(&latest.version, v)),
        sdk_size: latest.sdk_zip.as_ref().map(|a| a.size).unwrap_or(0),
        manager_update: latest.manager_exe.is_some() && release::is_newer(&latest.version, release::manager_version()),
        latest: latest.version,
        url: latest.url,
        sdk_installed: installed,
    })
}

#[tauri::command]
async fn install_sdk(app: AppHandle) -> Res<String> {
    let dir = ready_to_change(&lock(&app))?;
    let latest = release::latest().await?;
    let asset = latest.sdk_zip.clone().ok_or("The latest release has no BmSDK ZIP attached.")?;

    let zip = library::data_dir().join("Downloads").join(&asset.name);
    let progress_app = app.clone();
    release::download(&asset.browser_download_url, &zip, |done, total| emit(&progress_app, "sdk", done, total)).await?;
    release::verify_download(&latest, &asset, &zip).await?;

    let zip_for_task = zip.clone();
    let dir_for_task = dir.clone();
    let result = tauri::async_runtime::spawn_blocking(move || release::install_sdk_zip(&zip_for_task, &dir_for_task))
        .await
        .map_err(|e| e.to_string())?;
    let _ = fs::remove_file(&zip);

    let mut state = lock(&app);
    match result {
        Ok(()) => {
            state.log("success", format!("Installed BmSDK {} from GitHub", latest.version));
            // The release brings the template and example scripts, so list them too
            if let Ok(dir) = state.game() {
                library::import_existing(&mut state, &dir);
            }
            state.save()?;
            Ok(latest.version)
        }
        Err(e) => {
            state.log("error", format!("BmSDK install failed: {e}"));
            state.save()?;
            Err(e)
        }
    }
}

#[tauri::command]
async fn update_manager(app: AppHandle) -> Res<()> {
    let latest = release::latest().await?;
    let asset = latest.manager_exe.clone().ok_or("The latest release has no manager attached.")?;
    let exe = std::env::current_exe().map_err(|e| e.to_string())?;
    let new_exe = exe.with_extension("exe.new");

    let progress_app = app.clone();
    release::download(&asset.browser_download_url, &new_exe, |done, total| emit(&progress_app, "manager", done, total))
        .await
        .map_err(|e| format!("{e} If the manager is in a protected folder, move it somewhere like Downloads."))?;
    release::verify_download(&latest, &asset, &new_exe).await?;

    {
        let mut state = lock(&app);
        state.log("success", format!("Updated the manager to {}", latest.version));
        state.save()?;
    }
    release::replace_running_exe(&new_exe)?;
    app.exit(0);
    Ok(())
}

#[tauri::command(async)]
fn grant_access(app: AppHandle) -> Res<bool> {
    let dir = lock(&app).game()?;

    let output = game::hidden_command("whoami").args(["/user", "/fo", "csv", "/nh"]).output().map_err(|e| e.to_string())?;
    let text = String::from_utf8_lossy(&output.stdout);
    let sid = text.trim().rsplit(',').next().unwrap_or_default().trim_matches('"').to_string();
    if !sid.starts_with("S-1-") {
        return Err("Couldn't work out your Windows account.".into());
    }

    #[cfg(windows)]
    {
        let params = format!("\"{}\" /grant *{sid}:(OI)(CI)M /Q", dir.display());
        if winapi::run_elevated("icacls.exe", &params).is_none() {
            return Ok(false);
        }
    }

    let writable = game::is_writable(&dir);
    let mut state = lock(&app);
    if writable {
        state.log("success", "Gave your account write access to the game folder");
        state.save()?;
    }
    Ok(writable)
}

#[tauri::command(async)]
fn scan_paths(app: AppHandle, paths: Vec<String>) -> Res<Vec<Review>> {
    let mut reviews = Vec::new();

    for path in paths {
        let path = PathBuf::from(path);
        let source = path.file_name().unwrap_or_default().to_string_lossy().into_owned();
        let stem = path.file_stem().unwrap_or_default().to_string_lossy().into_owned();
        let id = lock(&app).next_id();

        let (dir, extracted, size) = if path.is_dir() {
            let size = detect::list_files(&path).iter().map(|f| file_size(&path.join(f))).sum();
            (path.clone(), false, size)
        } else if archive::is_archive(&path) {
            let dir = library::staging_dir().join(&id);
            if let Err(e) = archive::extract(&path, &dir) {
                let _ = fs::remove_dir_all(&dir);
                return Err(format!("{source}: {e}"));
            }
            (dir, true, file_size(&path))
        } else if path.extension().is_some_and(|e| e.eq_ignore_ascii_case("cs") || e.eq_ignore_ascii_case("asi")) {
            // A single script or plugin: stage it on its own so detection sees just that file
            let dir = library::staging_dir().join(&id);
            library::copy_file(&path, &dir.join(&source))?;
            (dir, true, file_size(&path))
        } else {
            return Err(format!("{source}: drop a .zip, .7z or .rar, a folder, a .cs script or an .asi plugin."));
        };

        let found = detect::detect(&dir, &stem);
        let state = lock(&app);
        let game_dir = state.game_dir.clone().map(PathBuf::from);

        let mods = found
            .iter()
            .enumerate()
            .map(|(index, d)| {
                let dests: Vec<String> = d.files.iter().map(|m| m.dest.clone()).collect();
                let owned_by_any = |rel: &str| state.mods.iter().any(|m| m.enabled && m.files.iter().any(|f| f.eq_ignore_ascii_case(rel)));
                let backs_up = game_dir
                    .as_ref()
                    .map(|g| dests.iter().filter(|r| !owned_by_any(r) && g.join(r).exists()).count())
                    .unwrap_or(0);
                let mut targets: Vec<String> = dests
                    .iter()
                    .map(|r| {
                        let segs: Vec<&str> = r.split('/').collect();
                        let keep = match d.kind {
                            Kind::ScriptMod | Kind::PrebuiltDll | Kind::Dlc if r.starts_with("BmGame/Mods/") || r.starts_with("DLC/") => 3,
                            _ => segs.len().saturating_sub(1).max(1),
                        };
                        segs[..keep.min(segs.len())].join("\\")
                    })
                    .collect();
                targets.sort();
                targets.dedup();
                let installed = state.mods.iter().find(|m| m.kind == d.kind && m.name.eq_ignore_ascii_case(&d.name));
                let replaces = installed.map(|m| m.name.clone());
                let version = detect::mod_toml_path(d.files.iter().map(|m| m.dest.as_str()))
                    .and_then(|dest| d.files.iter().find(|m| m.dest == dest))
                    .and_then(|m| detect::read_mod_toml(&dir.join(m.src.split('/').collect::<PathBuf>())).version);
                let installed_version = installed.and_then(|m| library::version_of(m, game_dir.as_deref()));
                let version_change = match (&version, &installed_version) {
                    (Some(new), Some(old)) => extras::version_cmp(new, old).map(|o| match o {
                        std::cmp::Ordering::Greater => "newer",
                        std::cmp::Ordering::Less => "older",
                        std::cmp::Ordering::Equal => "same",
                    }),
                    _ => None,
                };

                ReviewMod {
                    index,
                    name: d.name.clone(),
                    kind: d.kind,
                    supported: d.kind.supported(),
                    description: d.description.clone(),
                    targets,
                    file_count: d.files.len(),
                    shares_with: shares_with(&state, &dests, None).into_iter().filter(|n| Some(n) != replaces.as_ref()).collect(),
                    backs_up,
                    replaces,
                    version,
                    installed_version,
                    version_change,
                }
            })
            .collect();
        drop(state);

        reviews.push(Review { id: id.clone(), source: source.clone(), size, mods });
        app.state::<App>().pending.lock().unwrap_or_else(|e| e.into_inner()).insert(id, Pending { source, dir, extracted, found });
    }

    Ok(reviews)
}

fn take_pending(app: &AppHandle, id: &str) -> Option<Pending> {
    app.state::<App>().pending.lock().unwrap_or_else(|e| e.into_inner()).remove(id)
}

fn drop_pending(p: &Pending) {
    if p.extracted {
        let _ = fs::remove_dir_all(&p.dir);
    }
}

#[tauri::command(async)]
fn install_review(app: AppHandle, id: String, indices: Vec<usize>) -> Res<()> {
    let pending = take_pending(&app, &id).ok_or("This install expired. Drop the file again.")?;
    let mut state = lock(&app);
    let dir = match ready_to_change(&state) {
        Ok(d) => d,
        Err(e) => {
            // Keep it so the user can retry after granting access or closing the game
            drop(state);
            app.state::<App>().pending.lock().unwrap_or_else(|e| e.into_inner()).insert(id, pending);
            return Err(e);
        }
    };

    let chosen: Vec<&Detected> =
        indices.iter().filter_map(|i| pending.found.get(*i)).filter(|d| d.kind.supported() && !d.files.is_empty()).collect();
    let total: u64 = chosen.iter().map(|d| d.files.len() as u64).sum();
    let mut done = 0u64;
    let mut result = Ok(());

    for d in chosen {
        let mut deployer = Deployer { state: &mut state, game: dir.clone() };
        let mut carried: Option<library::NexusLink> = None;
        if let Some((old, link)) = deployer
            .state
            .mods
            .iter()
            .find(|m| m.kind == d.kind && m.name.eq_ignore_ascii_case(&d.name))
            .map(|m| (m.id.clone(), m.nexus.clone()))
        {
            carried = link;
            if let Err(e) = deployer.uninstall(&old) {
                result = Err(e);
                break;
            }
        }
        let mut tick = || {
            done += 1;
            emit(&app, "files", done, total);
        };
        match deployer.add(&pending.dir, d, &pending.source, &mut tick) {
            Ok(new_id) => {
                // A Nexus-named download links itself. A reinstall keeps the old link when the file says nothing new.
                let from_name = nexus::parse_file_name(&pending.source);
                let link = match (from_name, carried) {
                    (Some((mod_id, version)), old) => {
                        let same = old.filter(|l| l.mod_id == mod_id).unwrap_or_default();
                        Some(library::NexusLink { mod_id, installed: Some(version), ..same })
                    }
                    (None, Some(old)) => Some(library::NexusLink { installed: None, ..old }),
                    (None, None) => None,
                };
                if let Some(m) = state.mods.iter_mut().find(|m| m.id == new_id) {
                    m.nexus = link;
                }
                state.log("success", format!("Installed {}", d.name))
            }
            Err(e) => {
                state.log("error", format!("Couldn't install {}: {e}", d.name));
                result = Err(e);
                break;
            }
        }
    }

    drop_pending(&pending);
    state.save()?;
    result
}

#[tauri::command(async)]
fn discard_review(app: AppHandle, id: String) {
    if let Some(p) = take_pending(&app, &id) {
        drop_pending(&p);
    }
}

#[tauri::command(async)]
fn set_mod_enabled(app: AppHandle, id: String, enabled: bool) -> Res<()> {
    let mut state = lock(&app);
    let dir = ready_to_change(&state)?;
    let name = state.mods[state.find(&id)?].name.clone();
    let mut deployer = Deployer { state: &mut state, game: dir };
    let result = if enabled { deployer.enable(&id) } else { deployer.disable(&id) };

    match &result {
        Ok(()) => state.log("info", format!("Turned {} {name}", if enabled { "on" } else { "off" })),
        Err(e) => state.log("error", format!("Couldn't change {name}: {e}")),
    }
    state.save()?;
    result
}

#[tauri::command(async)]
fn uninstall_mod(app: AppHandle, id: String) -> Res<()> {
    let mut state = lock(&app);
    let dir = ready_to_change(&state)?;
    let name = state.mods[state.find(&id)?].name.clone();
    let result = Deployer { state: &mut state, game: dir }.uninstall(&id);

    match &result {
        Ok(()) => state.log("info", format!("Uninstalled {name}")),
        Err(e) => state.log("error", format!("Couldn't uninstall {name}: {e}")),
    }
    state.save()?;
    result
}

#[tauri::command(async)]
fn bulk_mods(app: AppHandle, ids: Vec<String>, action: String) -> Res<usize> {
    let verb = match action.as_str() {
        "enable" => "Turned on",
        "disable" => "Turned off",
        "uninstall" => "Uninstalled",
        _ => return Err("Unknown action".into()),
    };
    let mut state = lock(&app);
    let dir = ready_to_change(&state)?;

    let mut targets: Vec<(u64, String)> =
        state.mods.iter().filter(|m| ids.contains(&m.id)).map(|m| (m.enabled_at, m.id.clone())).collect();
    // Newest first when taking mods out, so each one finds the copy under it still in place
    if action != "enable" {
        targets.sort_by(|a, b| b.0.cmp(&a.0));
    }

    let total = targets.len() as u64;
    let mut deployer = Deployer { state: &mut state, game: dir };
    let mut done = 0usize;
    let mut result = Ok(());
    for (_, id) in &targets {
        let step = match action.as_str() {
            "enable" => deployer.enable(id),
            "disable" => deployer.disable(id),
            _ => deployer.uninstall(id),
        };
        if let Err(e) = step {
            result = Err(e);
            break;
        }
        done += 1;
        emit(&app, "mods", done as u64, total);
    }

    if done > 0 {
        state.log("info", format!("{verb} {done} mod{}", if done == 1 { "" } else { "s" }));
    }
    if let Err(e) = &result {
        state.log("error", format!("Stopped after {done} of {total}: {e}"));
    }
    state.save()?;
    result.map(|_| done)
}

#[tauri::command(async)]
fn disable_all(app: AppHandle) -> Res<usize> {
    let mut state = lock(&app);
    let dir = ready_to_change(&state)?;
    // Newest first, so each one finds the copy under it still in place
    let mut ids: Vec<(u64, String)> = state.mods.iter().filter(|m| m.enabled).map(|m| (m.enabled_at, m.id.clone())).collect();
    ids.sort_by(|a, b| b.0.cmp(&a.0));

    let mut deployer = Deployer { state: &mut state, game: dir };
    let mut count = 0;
    let mut result = Ok(());
    for (_, id) in &ids {
        if let Err(e) = deployer.disable(id) {
            result = Err(e);
            break;
        }
        count += 1;
    }

    state.log("info", format!("Turned off {count} mod{} and put the game's files back", if count == 1 { "" } else { "s" }));
    state.save()?;
    result.map(|_| count)
}

#[tauri::command(async)]
fn rescan_game(app: AppHandle) -> Res<usize> {
    let mut state = lock(&app);
    let dir = state.game()?;
    let found = library::import_existing(&mut state, &dir);
    if found > 0 {
        state.log("info", format!("Found {found} more mod{} in the game", if found == 1 { "" } else { "s" }));
    }
    state.save()?;
    Ok(found)
}

#[tauri::command(async)]
fn finish_setup(app: AppHandle) -> Res<()> {
    let mut state = lock(&app);
    state.setup_done = true;
    state.save()
}

#[tauri::command(async)]
fn set_check_on_start(app: AppHandle, value: bool) -> Res<()> {
    let mut state = lock(&app);
    state.check_on_start = value;
    state.save()
}

#[tauri::command(async)]
fn open_folder(app: AppHandle, which: String, id: Option<String>) -> Res<()> {
    let state = lock(&app);
    let path = match which.as_str() {
        "game" => state.game()?,
        "library" => library::library_dir(),
        "backups" => state.game()?.join(library::BACKUP_DIR),
        "mod" => {
            let m = &state.mods[state.find(id.as_deref().unwrap_or_default())?];
            let first = m.files.first().ok_or("This mod has no files.")?;
            let base = if m.enabled { state.game()? } else { library::library_dir().join(&m.id) };
            let file = base.join(first.split('/').collect::<PathBuf>());
            let loc = library::location(m);
            // For a mod with its own folder, open that folder rather than the one holding its first file
            let folder = base.join(loc.replace('\\', "/").split('/').collect::<PathBuf>());
            if folder.is_dir() { folder } else { file.parent().map(Path::to_path_buf).unwrap_or(base) }
        }
        _ => return Err("Unknown folder".into()),
    };
    fs::create_dir_all(&path).ok();
    opener::open(&path).map_err(|e| e.to_string())
}

/// Asks Steam to check the game's files against its servers. Steam shows its own progress window.
#[tauri::command(async)]
fn verify_game_files(app: AppHandle) -> Res<()> {
    let mut state = lock(&app);
    let dir = state.game()?;
    if game::store(&dir) != "Steam" {
        return Err("Only Steam copies of the game can be verified through Steam.".into());
    }
    if game::is_running() {
        return Err("Close the game first. Steam can't check files that are in use.".into());
    }
    opener::open(format!("steam://validate/{}", game::STEAM_APP_ID)).map_err(|e| format!("Couldn't reach Steam: {e}"))?;
    state.log("info", "Asked Steam to verify the game files");
    state.save()
}

#[tauri::command(async)]
fn launch_game(app: AppHandle) -> Res<()> {
    let dir = lock(&app).game()?;
    game::launch(&dir)
}

#[tauri::command(async)]
fn list_logs(app: AppHandle) -> Res<Vec<logs::LogSource>> {
    Ok(logs::list(&lock(&app).game()?))
}

#[tauri::command(async)]
fn read_log(app: AppHandle, path: String) -> Res<logs::LogText> {
    logs::read(&lock(&app).game()?, &path)
}

#[tauri::command(async)]
fn clear_logs(app: AppHandle) -> Res<logs::Cleared> {
    let mut state = lock(&app);
    let result = logs::clear(&state.game()?);
    state.log(
        if result.failed > 0 { "warning" } else { "info" },
        format!("Cleared {} log{}", result.deleted, if result.deleted == 1 { "" } else { "s" }),
    );
    state.save()?;
    Ok(result)
}

#[tauri::command(async)]
fn reveal_log(app: AppHandle, path: String) -> Res<()> {
    logs::reveal(&lock(&app).game()?, &path)
}

/// Total size of the mod library on disk.
#[tauri::command(async)]
fn library_size() -> u64 {
    detect::list_files(&library::library_dir())
        .iter()
        .map(|f| file_size(&library::library_dir().join(f.split('/').collect::<PathBuf>())))
        .sum()
}

#[tauri::command(async)]
fn open_url(url: String) -> Res<()> {
    // Only release pages and Nexus, never anything the UI could be tricked into passing
    let allowed = ["https://github.com/", "https://www.nexusmods.com/"];
    if !allowed.iter().any(|p| url.starts_with(p)) {
        return Err("That link isn't allowed.".into());
    }
    opener::open(url).map_err(|e| e.to_string())
}

pub fn run() {
    release::cleanup_after_update();
    let _ = fs::remove_dir_all(library::staging_dir());

    let mut initial = State::load();
    // Crash reports from before the manager was around aren't news
    if initial.crash_seen == 0 {
        initial.crash_seen = library::now();
        let _ = initial.save();
    }
    // Pick up mods that showed up in the game folder since last time
    if let Some(dir) = initial.game_dir.clone() {
        let found = library::import_existing(&mut initial, Path::new(&dir));
        if found > 0 {
            initial.log("info", format!("Found {found} mod{} in the game", if found == 1 { "" } else { "s" }));
            let _ = initial.save();
        }
    }

    tauri::Builder::default()
        .plugin(tauri_plugin_dialog::init())
        .manage(App { state: Mutex::new(initial), pending: Mutex::new(HashMap::new()) })
        .setup(|app| {
            #[cfg(windows)]
            if let Some(window) = app.get_webview_window("main") {
                if let Ok(hwnd) = window.hwnd() {
                    winapi::hide_window_border(hwnd.0 as *mut _);
                }
            }
            // A launch without mods that the manager didn't see through, such as after it was closed or crashed
            let waiting = app.state::<App>().state.lock().map(|s| !s.suspended.is_empty()).unwrap_or(false);
            if waiting {
                extras::watch_and_restore(app.handle().clone(), false);
            }
            Ok(())
        })
        .invoke_handler(tauri::generate_handler![
            get_overview,
            detect_games,
            set_game_dir,
            check_updates,
            install_sdk,
            update_manager,
            grant_access,
            scan_paths,
            install_review,
            discard_review,
            set_mod_enabled,
            uninstall_mod,
            bulk_mods,
            disable_all,
            rescan_game,
            finish_setup,
            set_check_on_start,
            open_folder,
            launch_game,
            verify_game_files,
            list_logs,
            read_log,
            reveal_log,
            clear_logs,
            library_size,
            nexus::set_nexus_link,
            nexus::check_nexus,
            extras::save_profile,
            extras::apply_profile,
            extras::delete_profile,
            extras::play_clean,
            extras::restore_suspended,
            extras::ack_logs,
            extras::diagnostics,
            extras::export_list,
            extras::import_list,
            open_url,
        ])
        .run(tauri::generate_context!())
        .expect("error while running the BmSDK Manager");
}
