use std::fs;
use std::io;
use std::path::{Component, Path, PathBuf};

/// Joins an archive entry name onto `root`, refusing anything that would land outside it.
pub fn safe_join(root: &Path, name: &str) -> Option<PathBuf> {
    let mut out = root.to_path_buf();
    let mut pushed = false;

    for part in Path::new(&name.replace('\\', "/")).components() {
        match part {
            Component::Normal(p) => {
                out.push(p);
                pushed = true;
            }
            Component::CurDir => {}
            _ => return None,
        }
    }

    pushed.then_some(out)
}

pub fn is_archive(path: &Path) -> bool {
    matches!(extension(path).as_str(), "zip" | "7z" | "rar")
}

fn extension(path: &Path) -> String {
    path.extension().map(|e| e.to_string_lossy().to_ascii_lowercase()).unwrap_or_default()
}

pub fn extract(archive: &Path, dest: &Path) -> Result<(), String> {
    fs::create_dir_all(dest).map_err(|e| e.to_string())?;

    match extension(archive).as_str() {
        "zip" => extract_zip(archive, dest, &[]),
        "7z" => extract_7z(archive, dest),
        "rar" => extract_rar(archive, dest),
        other => Err(format!("Can't open .{other} files")),
    }
}

/// Extracts a zip, skipping top level entries named in `skip`.
pub fn extract_zip(archive: &Path, dest: &Path, skip: &[&str]) -> Result<(), String> {
    let file = fs::File::open(archive).map_err(|e| e.to_string())?;
    let mut zip = zip::ZipArchive::new(file).map_err(|e| format!("Not a valid zip: {e}"))?;

    for i in 0..zip.len() {
        let mut entry = zip.by_index(i).map_err(|e| e.to_string())?;
        if entry.is_dir() || skip.iter().any(|s| entry.name().eq_ignore_ascii_case(s)) {
            continue;
        }

        let out = safe_join(dest, entry.name()).ok_or_else(|| format!("Unsafe path in archive: {}", entry.name()))?;
        write_entry(&out, &mut entry)?;
    }

    Ok(())
}

fn extract_7z(archive: &Path, dest: &Path) -> Result<(), String> {
    let mut bad_name = None;

    sevenz_rust::decompress_file_with_extract_fn(archive, dest, |entry, reader, _| {
        if entry.is_directory() {
            return Ok(true);
        }
        match safe_join(dest, entry.name()) {
            Some(out) => {
                write_entry(&out, reader).map_err(|e| sevenz_rust::Error::other(e))?;
                Ok(true)
            }
            None => {
                bad_name = Some(entry.name().to_string());
                Ok(false)
            }
        }
    })
    .map_err(|e| format!("Couldn't open the 7z archive: {e}"))?;

    match bad_name {
        Some(name) => Err(format!("Unsafe path in archive: {name}")),
        None => Ok(()),
    }
}

fn extract_rar(archive: &Path, dest: &Path) -> Result<(), String> {
    let mut open = unrar::Archive::new(archive)
        .open_for_processing()
        .map_err(|e| format!("Couldn't open the rar archive: {e}"))?;

    while let Some(header) = open.read_header().map_err(|e| e.to_string())? {
        let entry = header.entry();
        open = if entry.is_file() {
            let name = entry.filename.to_string_lossy().into_owned();
            let out = safe_join(dest, &name).ok_or_else(|| format!("Unsafe path in archive: {name}"))?;
            if let Some(parent) = out.parent() {
                fs::create_dir_all(parent).map_err(|e| e.to_string())?;
            }
            header.extract_to(&out).map_err(|e| e.to_string())?
        } else {
            header.skip().map_err(|e| e.to_string())?
        };
    }

    Ok(())
}

fn write_entry(out: &Path, reader: &mut dyn io::Read) -> Result<(), String> {
    if let Some(parent) = out.parent() {
        fs::create_dir_all(parent).map_err(|e| e.to_string())?;
    }
    let mut file = fs::File::create(out).map_err(|e| e.to_string())?;
    io::copy(reader, &mut file).map_err(|e| e.to_string())?;
    Ok(())
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn safe_join_blocks_escapes() {
        let root = Path::new(r"C:\stage");
        assert_eq!(safe_join(root, "a/b.txt"), Some(PathBuf::from(r"C:\stage\a\b.txt")));
        assert_eq!(safe_join(root, r"a\.\b.txt"), Some(PathBuf::from(r"C:\stage\a\b.txt")));
        assert_eq!(safe_join(root, "../evil.txt"), None);
        assert_eq!(safe_join(root, r"C:\Windows\evil.dll"), None);
        assert_eq!(safe_join(root, "/abs.txt"), None);
        assert_eq!(safe_join(root, ""), None);
    }
}
