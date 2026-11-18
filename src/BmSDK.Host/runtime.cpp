#include <iostream>
#include <filesystem>

#include <Windows.h>

#include <coreclr_delegates.h>
#include <hostfxr.h>
#include <nethost.h>

#include "runtime.h"

using namespace std;
using namespace std::filesystem;

namespace runtime {
    // Func aliases for hostfxr
    using HostInitFn = hostfxr_initialize_for_dotnet_command_line_fn;
    using HostGetDelegateFn = hostfxr_get_runtime_delegate_fn;
    using HostCloseFn = hostfxr_close_fn;
    using HostLoadAssemblyFn = load_assembly_and_get_function_pointer_fn;
    // Entry point func type alias
    typedef void(CORECLR_DELEGATE_CALLTYPE* ComponentEntryFn)();

    // Funcs from hostfxr
    static HostInitFn hostInitFn = nullptr;
    static HostGetDelegateFn hostGetDelegateFn = nullptr;
    static HostCloseFn hostCloseFn = nullptr;
    static HostLoadAssemblyFn hostLoadAssemblyFn = nullptr;

    // Filesystem helpers
    static path get_plugin_path() {
        wstring result(MAX_PATH, L'\0');
        GetModuleFileName(NULL, result.data(), MAX_PATH);
        return path(result);
    }

    static path get_game_dir() { return get_plugin_path().parent_path(); }

    // Tells the player why mods won't load. The game then starts without BmSDK.
    static void report_failure(const wstring& what, int code = 0) {
        wstring text = L"BmSDK couldn't start, so the game will run without mods.\n\n" + what;
        if (code != 0) {
            wchar_t hex[16];
            swprintf_s(hex, L"0x%08X", (unsigned)code);
            text += wstring(L" (error ") + hex + L")";
        }
        text += L"\n\nInstall BmSDK again with BmSDK Manager to put its files back.";
        MessageBoxW(nullptr, text.c_str(), L"BmSDK", MB_OK | MB_ICONWARNING | MB_SETFOREGROUND | MB_TOPMOST);
    }

    // Using the nethost library, discover the location of hostfxr and get exports
    static bool load_hostfxr() {
        // Point to local hostfxr.dll (or fall back to global .NET copy if not a publish build)
        const wstring assemblyPath = get_game_dir().wstring() + L"\\sdk\\BmSDK.dll";
        get_hostfxr_parameters params{ sizeof(get_hostfxr_parameters), assemblyPath.c_str(), nullptr };

        // Pre-allocate a large buffer for the path to hostfxr
        char_t buffer[MAX_PATH];
        size_t buffer_size = sizeof(buffer) / sizeof(char_t);
        int rc = get_hostfxr_path(buffer, &buffer_size, &params);
        if (rc != 0)
            return false;

        // Load hostfxr and get desired exports
        HMODULE lib = LoadLibraryW(buffer);
        if (lib == nullptr)
            return false;

        hostInitFn = (HostInitFn)GetProcAddress(lib, "hostfxr_initialize_for_dotnet_command_line");
        hostGetDelegateFn = (HostGetDelegateFn)GetProcAddress(lib, "hostfxr_get_runtime_delegate");
        hostCloseFn = (HostCloseFn)GetProcAddress(lib, "hostfxr_close");

        return (hostInitFn && hostGetDelegateFn && hostCloseFn);
    }

    // Load and initialize .NET Core and get desired function pointer for scenario
    static HostLoadAssemblyFn get_dotnet_load_assembly(const char_t* assembly_path, int& rc) {
        // Load .NET Core
        void* hostLoadAssemblyFn = nullptr;
        hostfxr_handle cxt = nullptr;
        const char_t* argv[] = { assembly_path };
        rc = hostInitFn(1, argv, nullptr, &cxt);
        if (rc != 0 || cxt == nullptr) {
            std::cerr << "Init failed: " << std::hex << std::showbase << rc << std::endl;
            hostCloseFn(cxt);
            return nullptr;
        }

        // Get the load assembly function pointer
        rc = hostGetDelegateFn(
            cxt,
            hdt_load_assembly_and_get_function_pointer,
            &hostLoadAssemblyFn);
        if (rc != 0 || hostLoadAssemblyFn == nullptr)
            std::cerr << "Get delegate failed: " << std::hex << std::showbase << rc << std::endl;

        hostCloseFn(cxt);
        return (HostLoadAssemblyFn)hostLoadAssemblyFn;
    }

    void load_dll() {
        // Load HostFxr and get exported hosting functions
        if (!load_hostfxr()) {
            report_failure(L"The .NET files in Binaries\\Win64\\sdk are missing or damaged.");
            return;
        }

        // Initialize and start the .NET Core runtime
        const wstring basePath = get_game_dir();
        const wstring asmPath = L"\\sdk\\BmSDK";
        const wstring dotnetDllPath = basePath + L"\\sdk\\BmSDK.dll";
        int rc = 0;
        hostLoadAssemblyFn = get_dotnet_load_assembly(dotnetDllPath.c_str(), rc);
        if (hostLoadAssemblyFn == nullptr) {
            report_failure(L".NET couldn't start from Binaries\\Win64\\sdk.", rc);
            return;
        }

        // Load managed assembly and get function pointer to a managed method
        const wstring dotnetType = L"BmSDK.Framework.Loader, BmSDK";
        const wstring dotnetMethod = L"GuardedDllMain";

        // Function pointer to managed delegate
        ComponentEntryFn GuardedDllMain = nullptr;
        rc = hostLoadAssemblyFn(
            dotnetDllPath.c_str(),
            dotnetType.c_str(),
            dotnetMethod.c_str(),
            UNMANAGEDCALLERSONLY_METHOD,
            nullptr,
            (void**)&GuardedDllMain);

        if (rc != 0 || GuardedDllMain == nullptr) {
            report_failure(L"BmSDK.dll in Binaries\\Win64\\sdk couldn't be loaded.", rc);
            return;
        }

        GuardedDllMain();
    }
}
