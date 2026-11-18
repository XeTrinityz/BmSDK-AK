use std::os::windows::ffi::OsStrExt;
use std::path::Path;

use windows::core::PCWSTR;
use windows::Win32::Foundation::CloseHandle;
use windows::Win32::Storage::FileSystem::{GetFileVersionInfoSizeW, GetFileVersionInfoW, VerQueryValueW};
use windows::Win32::System::Diagnostics::ToolHelp::{
    CreateToolhelp32Snapshot, Process32FirstW, Process32NextW, PROCESSENTRY32W, TH32CS_SNAPPROCESS,
};
use windows::Win32::System::Threading::{GetExitCodeProcess, WaitForSingleObject, INFINITE};
use windows::Win32::UI::Shell::{ShellExecuteExW, SEE_MASK_NOCLOSEPROCESS, SHELLEXECUTEINFOW};
use windows::Win32::UI::WindowsAndMessaging::SW_HIDE;

fn wide(text: &str) -> Vec<u16> {
    std::ffi::OsStr::new(text).encode_wide().chain(Some(0)).collect()
}

/// The ProductVersion string from a file's version resource.
pub fn product_version(file: &Path) -> Option<String> {
    let path: Vec<u16> = file.as_os_str().encode_wide().chain(Some(0)).collect();

    unsafe {
        let size = GetFileVersionInfoSizeW(PCWSTR(path.as_ptr()), None);
        if size == 0 {
            return None;
        }

        let mut data = vec![0u8; size as usize];
        GetFileVersionInfoW(PCWSTR(path.as_ptr()), 0, size, data.as_mut_ptr().cast()).ok()?;

        // The string table is keyed by language and code page, so ask which one the file has
        let mut ptr = std::ptr::null_mut();
        let mut len = 0u32;
        let key = wide(r"\VarFileInfo\Translation");
        if !VerQueryValueW(data.as_ptr().cast(), PCWSTR(key.as_ptr()), &mut ptr, &mut len).as_bool() || len < 4 {
            return None;
        }
        let pair = std::slice::from_raw_parts(ptr as *const u16, 2);

        let key = wide(&format!(r"\StringFileInfo\{:04x}{:04x}\ProductVersion", pair[0], pair[1]));
        if !VerQueryValueW(data.as_ptr().cast(), PCWSTR(key.as_ptr()), &mut ptr, &mut len).as_bool() || len == 0 {
            return None;
        }

        let chars = std::slice::from_raw_parts(ptr as *const u16, len as usize);
        let text = String::from_utf16_lossy(chars);
        Some(text.trim_end_matches('\0').to_string())
    }
}

/// Runs a program elevated through the UAC prompt and waits for it.
/// Returns the exit code, or None when the prompt was declined.
pub fn run_elevated(program: &str, parameters: &str) -> Option<u32> {
    let verb = wide("runas");
    let file = wide(program);
    let params = wide(parameters);

    let mut info = SHELLEXECUTEINFOW {
        cbSize: std::mem::size_of::<SHELLEXECUTEINFOW>() as u32,
        fMask: SEE_MASK_NOCLOSEPROCESS,
        lpVerb: PCWSTR(verb.as_ptr()),
        lpFile: PCWSTR(file.as_ptr()),
        lpParameters: PCWSTR(params.as_ptr()),
        nShow: SW_HIDE.0,
        ..Default::default()
    };

    unsafe {
        ShellExecuteExW(&mut info).ok()?;
        if info.hProcess.is_invalid() {
            return None;
        }

        WaitForSingleObject(info.hProcess, INFINITE);
        let mut code = 1u32;
        let _ = GetExitCodeProcess(info.hProcess, &mut code);
        let _ = CloseHandle(info.hProcess);
        Some(code)
    }
}

/// True when a process with this exe name is running. Reads the process list directly, which is much faster than spawning tasklist.
pub fn process_running(name: &str) -> bool {
    unsafe {
        let Ok(snapshot) = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0) else {
            return false;
        };
        let mut entry = PROCESSENTRY32W { dwSize: std::mem::size_of::<PROCESSENTRY32W>() as u32, ..Default::default() };
        let mut found = false;

        if Process32FirstW(snapshot, &mut entry).is_ok() {
            loop {
                let len = entry.szExeFile.iter().position(|&c| c == 0).unwrap_or(entry.szExeFile.len());
                if String::from_utf16_lossy(&entry.szExeFile[..len]).eq_ignore_ascii_case(name) {
                    found = true;
                    break;
                }
                if Process32NextW(snapshot, &mut entry).is_err() {
                    break;
                }
            }
        }

        let _ = CloseHandle(snapshot);
        found
    }
}

/// Hides the light 1px border Windows 11 draws around borderless windows, and keeps the rounded corners.
/// Both calls do nothing on Windows 10.
pub fn hide_window_border(hwnd: *mut core::ffi::c_void) {
    use windows::Win32::Foundation::HWND;
    use windows::Win32::Graphics::Dwm::{DwmSetWindowAttribute, DWMWA_BORDER_COLOR, DWMWA_WINDOW_CORNER_PREFERENCE, DWMWCP_ROUND};

    const DWMWA_COLOR_NONE: u32 = 0xFFFF_FFFE;
    let hwnd = HWND(hwnd);
    let color = DWMWA_COLOR_NONE;
    let corners = DWMWCP_ROUND.0;
    unsafe {
        let _ = DwmSetWindowAttribute(hwnd, DWMWA_BORDER_COLOR, &color as *const u32 as *const _, size_of::<u32>() as u32);
        let _ = DwmSetWindowAttribute(hwnd, DWMWA_WINDOW_CORNER_PREFERENCE, &corners as *const i32 as *const _, size_of::<i32>() as u32);
    }
}
