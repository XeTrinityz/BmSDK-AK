#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineNewsInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineNewsInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNews;
    /// <summary>
    /// Function: GetNews
    /// </summary>
    public unsafe virtual BmSDK.FString GetNews(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineNewsType NewsType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNews, "Engine.OnlineNewsInterface.GetNews", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewsType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadNewsCompletedDelegate;
    /// <summary>
    /// Function: ClearReadNewsCompletedDelegate
    /// </summary>
    public unsafe virtual void ClearReadNewsCompletedDelegate(BmSDK.FScriptDelegate ReadNewsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadNewsCompletedDelegate, "Engine.OnlineNewsInterface.ClearReadNewsCompletedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadNewsDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadNewsCompletedDelegate;
    /// <summary>
    /// Function: AddReadNewsCompletedDelegate
    /// </summary>
    public unsafe virtual void AddReadNewsCompletedDelegate(BmSDK.FScriptDelegate ReadNewsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadNewsCompletedDelegate, "Engine.OnlineNewsInterface.AddReadNewsCompletedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadNewsDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadNewsCompleted;
    /// <summary>
    /// Function: OnReadNewsCompleted
    /// </summary>
    public unsafe virtual void OnReadNewsCompleted(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.EOnlineNewsType NewsType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadNewsCompleted, "Engine.OnlineNewsInterface.OnReadNewsCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewsType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadNews;
    /// <summary>
    /// Function: ReadNews
    /// </summary>
    public unsafe virtual bool ReadNews(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineNewsType NewsType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadNews, "Engine.OnlineNewsInterface.ReadNews", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewsType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }
}
