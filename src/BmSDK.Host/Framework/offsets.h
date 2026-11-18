#pragma once

#include <Windows.h>
#include <cstdint>
#include <cstring>

namespace offsets {
    inline constexpr uint32_t TimeDateStampEpic = 0x6508B1CE;
    inline constexpr uint32_t TimeDateStampSteam = 0x5F8AA2F9;

    // How FEngineLoop::PreInit starts in the Steam build
    inline constexpr uint8_t PreInitStartSteam[] = {
        0x40, 0x55, 0x56, 0x57, 0x41, 0x54, 0x41, 0x55, 0x41, 0x56, 0x41, 0x57, 0x48, 0x8D, 0x6C, 0x24,
        0x80, 0x48, 0x81, 0xEC, 0x80, 0x01, 0x00, 0x00, 0x48, 0xC7, 0x45, 0x30, 0xFE, 0xFF, 0xFF, 0xFF,
    };

    inline uintptr_t BaseAddress = 0;
    inline uintptr_t EngineLoopPreInit = 0;

    // An unknown exe may be too small for the address, so it is checked before it is read
    inline bool starts_with(uintptr_t address, const uint8_t* bytes, size_t count) {
        MEMORY_BASIC_INFORMATION info{};
        if (VirtualQuery((LPCVOID)address, &info, sizeof(info)) == 0)
            return false;
        if (info.State != MEM_COMMIT || (info.Protect & (PAGE_NOACCESS | PAGE_GUARD)) != 0)
            return false;
        if ((uintptr_t)info.BaseAddress + info.RegionSize < address + count)
            return false;

        return memcmp((const void*)address, bytes, count) == 0;
    }

    // Identifies the build from the PE header's TimeDateStamp. False when it isn't one BmSDK can hook.
    inline bool init() {
        BaseAddress = (uintptr_t)GetModuleHandle(NULL);

        auto dosHeader = (PIMAGE_DOS_HEADER)BaseAddress;
        auto ntHeaders = (PIMAGE_NT_HEADERS64)(BaseAddress + dosHeader->e_lfanew);

        switch (ntHeaders->FileHeader.TimeDateStamp) {
            case TimeDateStampEpic:
                EngineLoopPreInit = 0x5DEA60;
                return true;
            case TimeDateStampSteam:
                EngineLoopPreInit = 0x5B7220;
                return true;
            default:
                // Any other exe used to be taken for Steam's. It still is when PreInit is where Steam
                // has it. Hooking that address in a GOG or older exe would crash the game at startup.
                EngineLoopPreInit = 0x5B7220;
                return starts_with(BaseAddress + EngineLoopPreInit, PreInitStartSteam, sizeof(PreInitStartSteam));
        }
    }
}
