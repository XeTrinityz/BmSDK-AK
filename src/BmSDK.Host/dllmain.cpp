#include <Windows.h>

#include "Framework/offsets.h"
#include "Framework/detour_manager.h"

static DWORD WINAPI report_unsupported(LPVOID) {
    MessageBoxW(nullptr,
        L"BmSDK doesn't work with this copy of the game, so the game will run without mods.\n\n"
        L"It needs the current Steam or Epic Games version of Batman: Arkham Knight. GOG copies and older versions aren't supported.",
        L"BmSDK", MB_OK | MB_ICONWARNING | MB_SETFOREGROUND | MB_TOPMOST);
    return 0;
}

static void init_runtime() {
    if (!offsets::init()) {
        // A message box can't be shown from inside DllMain, so it gets a thread of its own
        if (HANDLE thread = CreateThread(nullptr, 0, report_unsupported, nullptr, 0, nullptr))
            CloseHandle(thread);
        return;
    }

    DetourRestoreAfterWith();
    DetourManager::RegisterEngineLoopPreInitDetour();
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved) {
    switch (ul_reason_for_call) {
        case DLL_PROCESS_ATTACH:
            init_runtime();
            break;
        case DLL_THREAD_ATTACH:
        case DLL_THREAD_DETACH:
        case DLL_PROCESS_DETACH:
            break;
    }
    return TRUE;
}
