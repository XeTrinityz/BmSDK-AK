#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RDetonateGadgetInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RDetonateGadgetInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCurrentDetonateTarget;
    /// <summary>
    /// Function: GetCurrentDetonateTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetCurrentDetonateTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCurrentDetonateTarget, "BmGame.RDetonateGadgetInterface.GetCurrentDetonateTarget", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }
}
