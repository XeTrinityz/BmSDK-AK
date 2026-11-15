#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RSpecialMoveInstance_VantageSwingInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RSpecialMoveInstance_VantageSwingInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_NextSwing;
    /// <summary>
    /// Function: NextSwing
    /// </summary>
    public unsafe virtual void NextSwing()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NextSwing, "BmGame.RSpecialMoveInstance_VantageSwingInterface.NextSwing", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNextHidePoint;
    /// <summary>
    /// Function: GetNextHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetNextHidePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNextHidePoint, "BmGame.RSpecialMoveInstance_VantageSwingInterface.GetNextHidePoint", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTargetHidePoint;
    /// <summary>
    /// Function: GetTargetHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetTargetHidePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTargetHidePoint, "BmGame.RSpecialMoveInstance_VantageSwingInterface.GetTargetHidePoint", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanUpdateGrapple;
    /// <summary>
    /// Function: CanUpdateGrapple
    /// </summary>
    public unsafe virtual bool CanUpdateGrapple()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanUpdateGrapple, "BmGame.RSpecialMoveInstance_VantageSwingInterface.CanUpdateGrapple", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetNextHidePoint;
    /// <summary>
    /// Function: SetNextHidePoint
    /// </summary>
    public unsafe virtual void SetNextHidePoint(BmSDK.BmGame.RHidePoint NextPoint, System.Numerics.Vector3 NextPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetNextHidePoint, "BmGame.RSpecialMoveInstance_VantageSwingInterface.SetNextHidePoint", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
