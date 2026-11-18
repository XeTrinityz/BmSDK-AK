//! Nexus Mods links and update checks. Nothing here needs an account or an API key: it reads the same public
//! mod page data the Nexus site itself uses.

use super::*;
use library::NexusLink;
use serde::Deserialize;
use std::cmp::Ordering;

pub const GAME_DOMAIN: &str = "batmanarkhamknight";
const GRAPHQL_URL: &str = "https://api.nexusmods.com/v2/graphql";

pub fn mod_url(id: u32) -> String {
    format!("https://www.nexusmods.com/{GAME_DOMAIN}/mods/{id}")
}

/// The mod id from a page link for this game, or from a plain number.
pub fn parse_mod_id(text: &str) -> Option<u32> {
    let text = text.trim();
    if !text.is_empty() && text.bytes().all(|b| b.is_ascii_digit()) {
        return text.parse().ok().filter(|id| *id > 0);
    }

    let lower = text.to_ascii_lowercase();
    let marker = format!("nexusmods.com/{GAME_DOMAIN}/mods/");
    let rest = &lower[lower.find(&marker)? + marker.len()..];
    let digits: String = rest.chars().take_while(char::is_ascii_digit).collect();
    digits.parse().ok().filter(|id| *id > 0)
}

/// The mod id and version from a Nexus download name like "Night Suit-1234-1-0-1699999999.zip".
pub fn parse_file_name(name: &str) -> Option<(u32, String)> {
    let stem = match name.rsplit_once('.') {
        Some((stem, ext)) if matches!(ext.to_ascii_lowercase().as_str(), "zip" | "7z" | "rar") => stem,
        _ => name,
    };
    let parts: Vec<&str> = stem.split('-').collect();
    let last = parts.len().checked_sub(1)?;

    let stamp = parts[last];
    if !(9..=11).contains(&stamp.len()) || !stamp.bytes().all(|b| b.is_ascii_digit()) {
        return None;
    }

    // The first number that's followed only by version pieces and then the timestamp is the mod id
    // Starts at 1: the mod's own name always comes first, even when it's a number
    (1..last.saturating_sub(1).max(1)).find_map(|i| {
        let id = parts[i];
        let version = &parts[i + 1..last];
        let is_id = !id.is_empty() && id.bytes().all(|b| b.is_ascii_digit());
        let is_version = !version.is_empty() && version.iter().all(|p| !p.is_empty() && p.bytes().all(|b| b.is_ascii_alphanumeric()));
        if is_id && is_version {
            id.parse().ok().map(|n| (n, version.join(".")))
        } else {
            None
        }
    })
}

#[derive(Deserialize)]
struct Node {
    #[serde(rename = "modId")]
    mod_id: u32,
    name: Option<String>,
    author: Option<String>,
    version: Option<String>,
}

#[derive(Deserialize)]
struct Data {
    #[serde(rename = "legacyModsByDomain")]
    mods: Nodes,
}

#[derive(Deserialize)]
struct Nodes {
    nodes: Vec<Node>,
}

#[derive(Deserialize)]
struct Response {
    data: Option<Data>,
}

pub struct Fetched {
    pub name: Option<String>,
    pub author: Option<String>,
    pub version: Option<String>,
}

/// Name, author and latest version for these mods. Mods Nexus no longer lists are left out.
pub async fn fetch(ids: &[u32]) -> Result<HashMap<u32, Fetched>, String> {
    const QUERY: &str = "query($ids: [CompositeDomainWithIdInput!]!) { legacyModsByDomain(ids: $ids) { nodes { modId name author version } } }";

    let client = reqwest::Client::builder()
        .user_agent(format!("BmSDK-Manager/{}", release::manager_version()))
        .timeout(std::time::Duration::from_secs(20))
        .build()
        .map_err(|e| e.to_string())?;

    let mut out = HashMap::new();
    for chunk in ids.chunks(50) {
        let variables: Vec<serde_json::Value> =
            chunk.iter().map(|id| serde_json::json!({ "gameDomain": GAME_DOMAIN, "modId": id })).collect();
        let body = serde_json::json!({ "query": QUERY, "variables": { "ids": variables } });

        let response: Response = client
            .post(GRAPHQL_URL)
            .json(&body)
            .send()
            .await
            .map_err(|e| format!("Couldn't reach Nexus Mods: {e}"))?
            .error_for_status()
            .map_err(|e| format!("Nexus Mods returned an error: {e}"))?
            .json()
            .await
            .map_err(|e| format!("Couldn't read the answer from Nexus Mods: {e}"))?;

        for n in response.data.map(|d| d.mods.nodes).unwrap_or_default() {
            out.insert(n.mod_id, Fetched { name: n.name, author: n.author, version: n.version });
        }
    }
    Ok(out)
}

/// True when the latest version on Nexus is newer than the one installed. Unknown versions never count.
pub fn update_available(link: &NexusLink) -> bool {
    match (&link.latest, &link.installed) {
        (Some(latest), Some(installed)) => match extras::version_cmp(latest, installed) {
            Some(order) => order == Ordering::Greater,
            // Versions with no numbers, like "final", count as new when they differ
            None => !latest.trim().eq_ignore_ascii_case(installed.trim()),
        },
        _ => false,
    }
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
pub struct NexusView {
    pub mod_id: u32,
    pub name: Option<String>,
    pub author: Option<String>,
    pub latest: Option<String>,
    pub installed: Option<String>,
    pub url: String,
    pub update_available: bool,
}

/// A mod's link with the version its mod.toml has now. The saved one goes stale when the mod is edited
/// or updated in the game folder.
pub fn current(m: &library::ModRecord, game: Option<&Path>) -> Option<NexusLink> {
    let mut link = m.nexus.clone()?;
    if let Some(version) = library::version_of(m, game) {
        link.installed = Some(version);
    }
    Some(link)
}

pub fn view(link: &NexusLink) -> NexusView {
    NexusView {
        mod_id: link.mod_id,
        name: link.name.clone(),
        author: link.author.clone(),
        latest: link.latest.clone(),
        installed: link.installed.clone(),
        url: mod_url(link.mod_id),
        update_available: update_available(link),
    }
}

/// Links a mod to a Nexus page. An empty text unlinks it.
#[tauri::command(async)]
pub fn set_nexus_link(app: AppHandle, id: String, text: String) -> Res<()> {
    let mut state = lock(&app);
    let index = state.find(&id)?;

    if text.trim().is_empty() {
        state.mods[index].nexus = None;
    } else {
        let mod_id = parse_mod_id(&text)
            .ok_or("That isn't a Nexus Mods link for Batman: Arkham Knight. Paste the mod page link, or just its number.")?;
        let keep = state.mods[index].nexus.clone().filter(|l| l.mod_id == mod_id);
        state.mods[index].nexus = Some(keep.unwrap_or(NexusLink { mod_id, ..Default::default() }));
    }
    state.save()
}

#[derive(Serialize)]
#[serde(rename_all = "camelCase")]
pub struct NexusCheck {
    pub linked: usize,
    /// Names of mods with a newer version on Nexus.
    pub updates: Vec<String>,
}

/// Asks Nexus about every linked mod and stores the latest versions.
#[tauri::command]
pub async fn check_nexus(app: AppHandle) -> Res<NexusCheck> {
    let ids: Vec<u32> = {
        let state = lock(&app);
        let mut ids: Vec<u32> = state.mods.iter().filter_map(|m| m.nexus.as_ref().map(|n| n.mod_id)).collect();
        ids.sort_unstable();
        ids.dedup();
        ids
    };
    if ids.is_empty() {
        return Ok(NexusCheck { linked: 0, updates: Vec::new() });
    }

    let fetched = fetch(&ids).await?;

    let mut state = lock(&app);
    let game = state.game().ok();
    let now = library::now();
    for i in 0..state.mods.len() {
        let Some(link) = state.mods[i].nexus.clone() else { continue };
        let Some(f) = fetched.get(&link.mod_id) else { continue };

        let mut link = link;
        link.name = f.name.clone().or(link.name);
        link.author = f.author.clone().or(link.author);
        link.latest = f.version.clone().or(link.latest);
        link.fetched = now;
        // The mod's own mod.toml says what is installed. Without one, keep what the download's name said,
        // else assume the latest is what's installed
        link.installed =
            library::version_of(&state.mods[i], game.as_deref()).or(link.installed).or_else(|| link.latest.clone());
        state.mods[i].nexus = Some(link);
    }
    state.save()?;

    let updates = state
        .mods
        .iter()
        .filter(|m| m.nexus.as_ref().is_some_and(update_available))
        .map(|m| m.name.clone())
        .collect();
    Ok(NexusCheck { linked: ids.len(), updates })
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn reads_ids_from_links_and_numbers() {
        assert_eq!(parse_mod_id("1234"), Some(1234));
        assert_eq!(parse_mod_id(" https://www.nexusmods.com/batmanarkhamknight/mods/3570?tab=files "), Some(3570));
        assert_eq!(parse_mod_id("nexusmods.com/BatmanArkhamKnight/mods/12"), Some(12));
        assert_eq!(parse_mod_id("https://www.nexusmods.com/skyrim/mods/12"), None);
        assert_eq!(parse_mod_id("0"), None);
        assert_eq!(parse_mod_id("not a link"), None);
    }

    #[test]
    fn reads_id_and_version_from_download_names() {
        assert_eq!(parse_file_name("Night Suit-1234-1-0-1699999999.zip"), Some((1234, "1.0".into())));
        assert_eq!(parse_file_name("Batwing-77-2-0-2-1700000000.7z"), Some((77, "2.0.2".into())));
        assert_eq!(parse_file_name("My Mod-5-1-0b-1700000000"), Some((5, "1.0b".into())));
        assert_eq!(parse_file_name("Night Suit.zip"), None);
        assert_eq!(parse_file_name("2049-88-1-0-1700000000.zip"), Some((88, "1.0".into())));
        assert_eq!(parse_file_name("Mod-1234-1699999999.zip"), None);
    }

    #[test]
    fn spots_updates() {
        let link = |latest: &str, installed: &str| NexusLink {
            mod_id: 1,
            latest: Some(latest.into()),
            installed: Some(installed.into()),
            ..Default::default()
        };
        assert!(update_available(&link("1.10", "1.9")));
        assert!(!update_available(&link("1.2", "1.2.0")));
        assert!(!update_available(&link("1.0", "1.1")));
        assert!(update_available(&link("final", "beta")));
        assert!(!update_available(&link("Final", "final")));
        assert!(!update_available(&NexusLink { mod_id: 1, ..Default::default() }));
    }
}
