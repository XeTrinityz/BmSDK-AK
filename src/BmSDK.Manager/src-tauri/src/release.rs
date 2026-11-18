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
    /// "sha256:<hex>", which GitHub works out for every asset it stores.
    #[serde(default, skip_serializing)]
    pub digest: Option<String>,
}

#[derive(Serialize, Clone)]
#[serde(rename_all = "camelCase")]
pub struct ReleaseInfo {
    pub version: String,
    pub url: String,
    pub sdk_zip: Option<GhAsset>,
    pub manager_exe: Option<GhAsset>,
    /// Every asset, for finding the .sha256 file that goes with a download in older releases.
    #[serde(skip)]
    pub assets: Vec<GhAsset>,
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
        assets: release.assets,
    })
}

/// The SHA-256 of a file, as lowercase hex.
pub fn sha256_file(path: &Path) -> Result<String, String> {
    use sha2::{Digest, Sha256};
    let mut file = fs::File::open(path).map_err(|e| e.to_string())?;
    let mut hasher = Sha256::new();
    std::io::copy(&mut file, &mut hasher).map_err(|e| e.to_string())?;
    Ok(hasher.finalize().iter().map(|b| format!("{b:02x}")).collect())
}

/// The hash from a sha256sum line like "<64 hex digits>  BmSDK-Manager.exe".
fn parse_sha256(text: &str) -> Option<String> {
    let hash = text.split_whitespace().next()?.to_ascii_lowercase();
    (hash.len() == 64 && hash.bytes().all(|b| b.is_ascii_hexdigit())).then_some(hash)
}

/// The hash GitHub lists for an asset.
fn digest_hash(asset: &GhAsset) -> Option<String> {
    parse_sha256(asset.digest.as_deref()?.strip_prefix("sha256:")?)
}

/// Checks a download against the hash GitHub lists for it. Releases 0.26.0 and 0.25.0 also have a .sha256 file
/// next to each download, which is used when there's no digest. A release with neither passes. A file that
/// doesn't match is deleted.
pub async fn verify_download(release: &ReleaseInfo, asset: &GhAsset, file: &Path) -> Result<(), String> {
    let expected = match digest_hash(asset) {
        Some(hash) => hash,
        None => {
            let wanted = format!("{}.sha256", asset.name);
            let Some(hash_asset) = release.assets.iter().find(|a| a.name.eq_ignore_ascii_case(&wanted)) else {
                return Ok(());
            };
            let text = client()?
                .get(&hash_asset.browser_download_url)
                .send()
                .await
                .and_then(|r| r.error_for_status())
                .map_err(|e| format!("Couldn't get the file's checksum: {e}"))?
                .text()
                .await
                .map_err(|e| format!("Couldn't get the file's checksum: {e}"))?;
            parse_sha256(&text).ok_or("The release's checksum file is damaged.")?
        }
    };

    let path = file.to_path_buf();
    let actual = tauri::async_runtime::spawn_blocking(move || sha256_file(&path)).await.map_err(|e| e.to_string())??;
    if actual != expected {
        let _ = fs::remove_file(file);
        return Err(format!("{} didn't match its checksum, so it wasn't installed. Please try again.", asset.name));
    }
    Ok(())
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
    fn hashes_and_reads_checksums() {
        let dir = tempfile::tempdir().unwrap();
        let file = dir.path().join("abc.txt");
        fs::write(&file, "abc").unwrap();
        let abc = "ba7816bf8f01cfea414140de5dae2223b00361a396177a9cb410ff61f20015ad";
        assert_eq!(sha256_file(&file).unwrap(), abc);

        assert_eq!(parse_sha256(&format!("{}  BmSDK-Manager.exe\n", abc.to_uppercase())).as_deref(), Some(abc));
        assert_eq!(parse_sha256("not a hash  file"), None);
        assert_eq!(parse_sha256(""), None);

        let asset = |digest: Option<&str>| GhAsset { name: "a".into(), browser_download_url: String::new(), size: 0, digest: digest.map(String::from) };
        assert_eq!(digest_hash(&asset(Some(&format!("sha256:{abc}")))).as_deref(), Some(abc));
        assert_eq!(digest_hash(&asset(Some("sha1:abc"))), None);
        assert_eq!(digest_hash(&asset(None)), None);
    }

    #[test]
    fn compares_versions() {
        assert!(is_newer("0.25.0", "0.24.1"));
        assert!(!is_newer("0.24.1", "0.24.1"));
        assert!(!is_newer("0.24.0", "0.24.1"));
        assert!(!is_newer("garbage", "0.24.1"));
    }
}
