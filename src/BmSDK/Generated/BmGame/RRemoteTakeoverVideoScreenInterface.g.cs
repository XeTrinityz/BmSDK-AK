#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RRemoteTakeoverVideoScreenInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RRemoteTakeoverVideoScreenInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetStaticTransitionParameter;
    /// <summary>
    /// Function: SetStaticTransitionParameter
    /// </summary>
    public unsafe virtual void SetStaticTransitionParameter(float val)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetStaticTransitionParameter, "BmGame.RRemoteTakeoverVideoScreenInterface.SetStaticTransitionParameter", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(val, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RevertToStandardTexture;
    /// <summary>
    /// Function: RevertToStandardTexture
    /// </summary>
    public unsafe virtual void RevertToStandardTexture()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RevertToStandardTexture, "BmGame.RRemoteTakeoverVideoScreenInterface.RevertToStandardTexture", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTakeoverTexture;
    /// <summary>
    /// Function: SetTakeoverTexture
    /// </summary>
    public unsafe virtual void SetTakeoverTexture(BmSDK.Engine.TextureRenderTarget2D takeoverTexture)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTakeoverTexture, "BmGame.RRemoteTakeoverVideoScreenInterface.SetTakeoverTexture", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takeoverTexture, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeTakenOverByScarecrow;
    /// <summary>
    /// Function: CanBeTakenOverByScarecrow
    /// </summary>
    public unsafe virtual bool CanBeTakenOverByScarecrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeTakenOverByScarecrow, "BmGame.RRemoteTakeoverVideoScreenInterface.CanBeTakenOverByScarecrow", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeTakenOverByRiddler;
    /// <summary>
    /// Function: CanBeTakenOverByRiddler
    /// </summary>
    public unsafe virtual bool CanBeTakenOverByRiddler()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeTakenOverByRiddler, "BmGame.RRemoteTakeoverVideoScreenInterface.CanBeTakenOverByRiddler", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }
}
