#include "pch.h"
#include "Safe.h"
#include "Engine/GameFunctions.h"

// These stay free of C++ objects so __try can be used in them.

bool Safe::Copy(void* dst, const void* src, size_t size)
{
    if (!src || !size)
    {
        return false;
    }

    __try
    {
        memcpy(dst, src, size);
        return true;
    }
    __except (EXCEPTION_EXECUTE_HANDLER)
    {
        return false;
    }
}

bool Safe::LoadPackage(const wchar_t* name, void** package, DWORD* code)
{
    __try
    {
        *package = GameFunctions::LoadPackage(nullptr, name, 0);
        return true;
    }
    __except (EXCEPTION_EXECUTE_HANDLER)
    {
        *code = GetExceptionCode();
        return false;
    }
}

bool Safe::CollectGarbage(DWORD* code)
{
    __try
    {
        GameFunctions::CollectGarbage(0, 1);
        return true;
    }
    __except (EXCEPTION_EXECUTE_HANDLER)
    {
        *code = GetExceptionCode();
        return false;
    }
}
