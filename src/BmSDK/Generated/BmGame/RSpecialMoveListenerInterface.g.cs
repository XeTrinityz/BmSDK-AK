#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RSpecialMoveListenerInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RSpecialMoveListenerInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpecialMoveFinished;
    /// <summary>
    /// Function: SpecialMoveFinished
    /// </summary>
    public unsafe virtual void SpecialMoveFinished(BmSDK.BmGame.RSpecialMoveInstance MoveFinishing, BmSDK.BmGame.RPawnPlayer Pawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpecialMoveFinished, "BmGame.RSpecialMoveListenerInterface.SpecialMoveFinished", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveFinishing, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
