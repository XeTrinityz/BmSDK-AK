#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RMatineeController<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RMatineeController : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearMatinee;
    /// <summary>
    /// Function: ClearMatinee
    /// </summary>
    public unsafe virtual void ClearMatinee()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearMatinee, "BmGame.RMatineeController.ClearMatinee", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetMatinee;
    /// <summary>
    /// Function: SetMatinee
    /// </summary>
    public unsafe virtual void SetMatinee(BmSDK.Engine.SeqAct_Interp M)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetMatinee, "BmGame.RMatineeController.SetMatinee", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
