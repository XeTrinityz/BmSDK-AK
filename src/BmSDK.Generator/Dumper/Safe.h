#pragma once

// Memory reads and engine calls that can fault without taking the game down.
namespace Safe
{
    bool Copy(void* dst, const void* src, size_t size);
    bool LoadPackage(const wchar_t* name, void** package, DWORD* code);
    bool CollectGarbage(DWORD* code);

    template <typename T> bool Read(uintptr_t address, T& out)
    {
        return Copy(&out, (const void*)address, sizeof(T));
    }
}
