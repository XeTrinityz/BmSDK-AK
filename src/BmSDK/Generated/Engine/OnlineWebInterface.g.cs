#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineWebInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineWebInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnRequestComplete;
    /// <summary>
    /// Function: OnRequestComplete
    /// </summary>
    public unsafe virtual void OnRequestComplete(BmSDK.Engine.HttpRequestInterface OriginalRequest, BmSDK.Engine.HttpResponseInterface Response, bool bDidSucceed)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnRequestComplete, "Engine.OnlineWebInterface.OnRequestComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalRequest, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Response, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDidSucceed, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WebRequest;
    /// <summary>
    /// Function: WebRequest
    /// </summary>
    public unsafe virtual void WebRequest(BmSDK.FStringArg HttpMethod, BmSDK.FStringArg URL, BmSDK.FStringArg Params = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WebRequest, "Engine.OnlineWebInterface.WebRequest", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        HttpMethod.WriteTo(paramsPtr + 0);
        URL.WriteTo(paramsPtr + 16);
        Params.WriteTo(paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        return;
    }
}
