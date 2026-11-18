fn main() {
    println!("cargo:rerun-if-env-changed=BMSDK_REPO");
    tauri_build::build()
}
