#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineSocialInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineSocialInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearPostLinkCompleted;
    /// <summary>
    /// Function: ClearPostLinkCompleted
    /// </summary>
    public unsafe virtual void ClearPostLinkCompleted(byte LocalUserNum, BmSDK.FScriptDelegate PostLinkDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearPostLinkCompleted, "Engine.OnlineSocialInterface.ClearPostLinkCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostLinkDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddPostLinkCompleted;
    /// <summary>
    /// Function: AddPostLinkCompleted
    /// </summary>
    public unsafe virtual void AddPostLinkCompleted(byte LocalUserNum, BmSDK.FScriptDelegate PostLinkDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddPostLinkCompleted, "Engine.OnlineSocialInterface.AddPostLinkCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostLinkDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPostLinkCompleted;
    /// <summary>
    /// Function: OnPostLinkCompleted
    /// </summary>
    public unsafe virtual void OnPostLinkCompleted(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPostLinkCompleted, "Engine.OnlineSocialInterface.OnPostLinkCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PostLink;
    /// <summary>
    /// Function: PostLink
    /// </summary>
    public unsafe virtual bool PostLink(byte LocalUserNum, out BmSDK.Engine.OnlineSubsystem.FSocialPostLinkInfo PostLinkInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostLink, "Engine.OnlineSocialInterface.PostLink", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PostLinkInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FSocialPostLinkInfo>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 104);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearPostImageCompleted;
    /// <summary>
    /// Function: ClearPostImageCompleted
    /// </summary>
    public unsafe virtual void ClearPostImageCompleted(byte LocalUserNum, BmSDK.FScriptDelegate PostImageDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearPostImageCompleted, "Engine.OnlineSocialInterface.ClearPostImageCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostImageDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddPostImageCompleted;
    /// <summary>
    /// Function: AddPostImageCompleted
    /// </summary>
    public unsafe virtual void AddPostImageCompleted(byte LocalUserNum, BmSDK.FScriptDelegate PostImageDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddPostImageCompleted, "Engine.OnlineSocialInterface.AddPostImageCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostImageDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPostImageCompleted;
    /// <summary>
    /// Function: OnPostImageCompleted
    /// </summary>
    public unsafe virtual void OnPostImageCompleted(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPostImageCompleted, "Engine.OnlineSocialInterface.OnPostImageCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PostImage;
    /// <summary>
    /// Function: PostImage
    /// </summary>
    public unsafe virtual bool PostImage(byte LocalUserNum, out BmSDK.Engine.OnlineSubsystem.FSocialPostImageInfo PostImageInfo, BmSDK.TArray<byte> FullImage)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostImage, "Engine.OnlineSocialInterface.PostImage", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FullImage, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PostImageInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FSocialPostImageInfo>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearQuerySocialPostPrivilegesCompleted;
    /// <summary>
    /// Function: ClearQuerySocialPostPrivilegesCompleted
    /// </summary>
    public unsafe virtual void ClearQuerySocialPostPrivilegesCompleted(BmSDK.FScriptDelegate PostPrivilegesDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearQuerySocialPostPrivilegesCompleted, "Engine.OnlineSocialInterface.ClearQuerySocialPostPrivilegesCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostPrivilegesDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddQuerySocialPostPrivilegesCompleted;
    /// <summary>
    /// Function: AddQuerySocialPostPrivilegesCompleted
    /// </summary>
    public unsafe virtual void AddQuerySocialPostPrivilegesCompleted(BmSDK.FScriptDelegate PostPrivilegesDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddQuerySocialPostPrivilegesCompleted, "Engine.OnlineSocialInterface.AddQuerySocialPostPrivilegesCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostPrivilegesDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnQuerySocialPostPrivilegesCompleted;
    /// <summary>
    /// Function: OnQuerySocialPostPrivilegesCompleted
    /// </summary>
    public unsafe virtual void OnQuerySocialPostPrivilegesCompleted(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FSocialPostPrivileges PostPrivileges)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnQuerySocialPostPrivilegesCompleted, "Engine.OnlineSocialInterface.OnQuerySocialPostPrivilegesCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostPrivileges, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_QuerySocialPostPrivileges;
    /// <summary>
    /// Function: QuerySocialPostPrivileges
    /// </summary>
    public unsafe virtual bool QuerySocialPostPrivileges()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_QuerySocialPostPrivileges, "Engine.OnlineSocialInterface.QuerySocialPostPrivileges", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }
}
