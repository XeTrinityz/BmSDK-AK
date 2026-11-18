use futures_util::StreamExt;
use serde::{Deserialize, Serialize};
use std::fs;
use std::io::Write;
use std::path::{Path, PathBuf};

/// The repo releases come from. CI sets it to the repo that built this exe.
pub const REPO: &str = match option_env!("BMSDK_REPO") {
    Some(repo) => repo,
    None => "XeTrinityz/BmSDK-AK",
};

pub const MANAGER_ASSET: &str = "BmSDK-Manager.exe";

pub fn manager_version() -> &'static str {
    env!("CARGO_PKG_VERSION")
}

#[derive(Deserialize)]
struct GhRelease {
    tag_name: String,
    html_url: String,
    assets: Vec<GhAsset>,
}

#[derive(Deserialize, Serialize, Clone)]
pub struct GhAsset {
    pub name: String,
    pub browser_download_url: String,
    pub size: u64,
}

#[derive(Serialize, Clone)]
#[serde(rename_all = "camelCase")]
pub struct ReleaseInfo {
    pub version: String,
    pub url: String,
    pub sdk_zip: Option<GhAsset>,
    pub manager_exe: Option<GhAsset>,
}

fn client() -> Result<reqwest::Client, String> {
    reqwest::Client::builder()
        .user_agent(format!("BmSDK-Manager/{}", manager_version()))
        .build()
        .map_err(|e| e.to_string())
}

pub async fn latest() -> Result<ReleaseInfo, String> {
    let response = client()?
        .get(format!("https://api.github.com/repos/{REPO}/releases/latest"))
        .header("Accept", "application/vnd.github+json")
        .send()
        .await
        .map_err(|e| format!("Couldn't reach GitHub: {e}"))?;

    if response.status() == reqwest::StatusCode::FORBIDDEN {
        return Err("GitHub is rate limiting update checks. Try again in a few minutes.".into());
    }
    let release: GhRelease = response
        .error_for_status()
        .map_err(|e| format!("GitHub returned an error: {e}"))?
        .json()
        .await
        .map_err(|e| format!("Couldn't read the release info: {e}"))?;

    let sdk_zip = release
        .assets
        .iter()
        .find(|a| a.name.starts_with("BmSDK-AK-") && a.name.to_ascii_lowercase().ends_with(".zip"))
        .cloned();
    let manager_exe = release.assets.iter().find(|a| a.name.eq_ignore_ascii_case(MANAGER_ASSET)).cloned();

    Ok(ReleaseInfo {
        version: release.tag_name.trim_start_matches('v').to_string(),
        url: release.html_url,
        sdk_zip,
        manager_exe,
    })
}

/// True when `latest` is a newer version than `current`. Unparseable versions never count as newer.
pub fn is_newer(latest: &str, current: &str) -> bool {
    match (semver::Version::parse(latest), semver::Version::parse(current)) {
        (Ok(l), Ok(c)) => l > c,
        _ => false,
    }
}

pub async fn download(url: &str, dest: &Path, mut on_progress: impl FnMut(u64, u64)) -> Result<(), String> {
    let response = client()?
        .get(url)
        .send()
        .await
        .and_then(|r| r.error_for_status())
        .map_err(|e| format!("Download failed: {e}"))?;

    let total = response.content_length().unwrap_or(0);
    if let Some(parent) = dest.parent() {
        fs::create_dir_all(parent).map_err(|e| e.to_string())?;
    }
    let partial = dest.with_extension("part");
    let mut file = fs::File::create(&partial).map_err(|e| e.to_string())?;
    let mut done = 0u64;
    let mut stream = response.bytes_stream();

    while let Some(chunk) = stream.next().await {
        let chunk = chunk.map_err(|e| format!("Download failed: {e}"))?;
        file.write_all(&chunk).map_err(|e| e.to_string())?;
        done += chunk.len() as u64;
        on_progress(done, total);
    }

    drop(file);
    if total > 0 && done != total {
        let _ = fs::remove_file(&partial);
        return Err("The download was cut short. Please try again.".into());
    }
    fs::rename(&partial, dest).map_err(|e| e.to_string())
}

/// Docs that only make sense inside the release ZIP, not loose in the game folder.
const SDK_SKIPPED: [&str; 2] = ["README.md", "LICENSE.md"];

pub fn install_sdk_zip(zip: &Path, game_dir: &Path) -> Result<(), String> {
    crate::archive::extract_zip(zip, game_dir, &SDK_SKIPPED)
}

fn old_exe_path(exe: &Path) -> PathBuf {
    exe.with_extension("exe.old")
}

/// Removes the exe left behind by the last self-update.
pub fn cleanup_after_update() {
    if let Ok(exe) = std::env::current_exe() {
        let _ = fs::remove_file(old_exe_path(&exe));
    }
}

/// Swaps the running exe for `new_exe` and starts the new one. A running exe can be renamed but not overwritten.
pub fn replace_running_exe(new_exe: &Path) -> Result<(), String> {
    let exe = std::env::current_exe().map_err(|e| e.to_string())?;
    let old = old_exe_path(&exe);
    let _ = fs::remove_file(&old);

    fs::rename(&exe, &old).map_err(|e| format!("Couldn't replace the manager: {e}"))?;
    if let Err(e) = fs::rename(new_exe, &exe).or_else(|_| fs::copy(new_exe, &exe).map(|_| ())) {
        let _ = fs::rename(&old, &exe);
        return Err(format!("Couldn't replace the manager: {e}"));
    }
    let _ = fs::remove_file(new_exe);

    std::process::Command::new(&exe).spawn().map_err(|e| format!("Updated, but couldn't restart: {e}"))?;
    Ok(())
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn compares_versions() {
        assert!(is_newer("0.25.0", "0.24.1"));
        assert!(!is_newer("0.24.1", "0.24.1"));
        assert!(!is_newer("0.24.0", "0.24.1"));
        assert!(!is_newer("garbage", "0.24.1"));
    }
}
