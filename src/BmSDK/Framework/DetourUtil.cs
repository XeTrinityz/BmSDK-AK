using Windows.Win32;
using PInvokeDetours = Microsoft.Detours.PInvoke;

namespace BmSDK.Framework;

public static class DetourUtil
{
    // Keep delegates in memory to avoid GC
    private static readonly List<Delegate> s_detourDelegateRefs = [];

    // Creates a detour and returns the original function
    public static unsafe T NewDetour<T>(IntPtr funcOffset, T detourFunc)
        where T : Delegate
    {
        void* origFuncPtr = MemUtil.GetPointer(funcOffset);

        // Get a pointer to the managed detour method
        s_detourDelegateRefs.Add(detourFunc);
        void* managedDetourFuncPtr = Marshal.GetFunctionPointerForDelegate(detourFunc).ToPointer();

        PInvokeDetours.DetourRestoreAfterWith();

        Guard.Require(PInvokeDetours.DetourTransactionBegin() == 0);
        Guard.Require(PInvokeDetours.DetourUpdateThread(PInvoke.GetCurrentThread()) == 0);
        Guard.Require(PInvokeDetours.DetourAttach(&origFuncPtr, managedDetourFuncPtr) == 0);
        Guard.Require(PInvokeDetours.DetourTransactionCommit() == 0);

        return Marshal.GetDelegateForFunctionPointer<T>((IntPtr)origFuncPtr);
    }

    /// <summary>
    /// Creates a detour to an [UnmanagedCallersOnly] function and returns the original function. Calls
    /// through it skip the marshalling a delegate detour costs on every call.
    /// </summary>
    public static unsafe IntPtr NewDetour(IntPtr funcOffset, IntPtr detourFunc)
    {
        void* origFuncPtr = MemUtil.GetPointer(funcOffset);

        PInvokeDetours.DetourRestoreAfterWith();

        Guard.Require(PInvokeDetours.DetourTransactionBegin() == 0);
        Guard.Require(PInvokeDetours.DetourUpdateThread(PInvoke.GetCurrentThread()) == 0);
        Guard.Require(PInvokeDetours.DetourAttach(&origFuncPtr, detourFunc.ToPointer()) == 0);
        Guard.Require(PInvokeDetours.DetourTransactionCommit() == 0);

        return (IntPtr)origFuncPtr;
    }
}
