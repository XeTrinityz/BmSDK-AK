#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RDMThroughWallsSuppressableInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RDMThroughWallsSuppressableInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_SuppressDetectiveModeVisibilityThroughWalls;
    /// <summary>
    /// Function: SuppressDetectiveModeVisibilityThroughWalls
    /// </summary>
    public unsafe virtual void SuppressDetectiveModeVisibilityThroughWalls(bool bSuppress)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SuppressDetectiveModeVisibilityThroughWalls, "BmGame.RDMThroughWallsSuppressableInterface.SuppressDetectiveModeVisibilityThroughWalls", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuppress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnregisterDMThroughWallsSuppressable;
    /// <summary>
    /// Function: UnregisterDMThroughWallsSuppressable
    /// </summary>
    public unsafe virtual void UnregisterDMThroughWallsSuppressable()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnregisterDMThroughWallsSuppressable, "BmGame.RDMThroughWallsSuppressableInterface.UnregisterDMThroughWallsSuppressable", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterDMThroughWallsSuppressable;
    /// <summary>
    /// Function: RegisterDMThroughWallsSuppressable
    /// </summary>
    public unsafe virtual void RegisterDMThroughWallsSuppressable()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterDMThroughWallsSuppressable, "BmGame.RDMThroughWallsSuppressableInterface.RegisterDMThroughWallsSuppressable", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
