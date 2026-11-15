#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineCustomContentInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineCustomContentInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_CancelCustomContentRequest;
    /// <summary>
    /// Function: CancelCustomContentRequest
    /// </summary>
    public unsafe virtual void CancelCustomContentRequest(BmSDK.FStringArg sCustomId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CancelCustomContentRequest, "Engine.OnlineCustomContentInterface.CancelCustomContentRequest", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sCustomId.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCustomContentAsString;
    /// <summary>
    /// Function: GetCustomContentAsString
    /// </summary>
    public unsafe virtual void GetCustomContentAsString(BmSDK.FStringArg sCustomId, out BmSDK.FString ContentData)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCustomContentAsString, "Engine.OnlineCustomContentInterface.GetCustomContentAsString", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sCustomId.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        ContentData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCustomContent;
    /// <summary>
    /// Function: GetCustomContent
    /// </summary>
    public unsafe virtual void GetCustomContent(BmSDK.FStringArg sCustomId, out BmSDK.TArray<byte> ContentData)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCustomContent, "Engine.OnlineCustomContentInterface.GetCustomContent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sCustomId.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        ContentData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartCustomContentRequest;
    /// <summary>
    /// Function: StartCustomContentRequest
    /// </summary>
    public unsafe virtual void StartCustomContentRequest(BmSDK.FStringArg sContentName, BmSDK.FStringArg sCustomId, BmSDK.FScriptDelegate dReadCustomContentComplete, BmSDK.Engine.OnlineSubsystem.ECustomContentAccessMode eCCAM = default, BmSDK.FStringArg Category = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartCustomContentRequest, "Engine.OnlineCustomContentInterface.StartCustomContentRequest", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sContentName.WriteTo(paramsPtr + 0);
        sCustomId.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dReadCustomContentComplete, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCCAM, paramsPtr + 48);
        Category.WriteTo(paramsPtr + 52);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 52);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsCustomContentAccessModeAvailable;
    /// <summary>
    /// Function: IsCustomContentAccessModeAvailable
    /// </summary>
    public unsafe virtual bool IsCustomContentAccessModeAvailable(BmSDK.Engine.OnlineSubsystem.ECustomContentAccessMode eCCAM)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsCustomContentAccessModeAvailable, "Engine.OnlineCustomContentInterface.IsCustomContentAccessModeAvailable", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCCAM, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsCustomContentTypeAvailable;
    /// <summary>
    /// Function: IsCustomContentTypeAvailable
    /// </summary>
    public unsafe virtual bool IsCustomContentTypeAvailable(BmSDK.Engine.OnlineSubsystem.ECustomContentType CustomContentType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsCustomContentTypeAvailable, "Engine.OnlineCustomContentInterface.IsCustomContentTypeAvailable", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomContentType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsCustomContentAvailable;
    /// <summary>
    /// Function: IsCustomContentAvailable
    /// </summary>
    public unsafe virtual bool IsCustomContentAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsCustomContentAvailable, "Engine.OnlineCustomContentInterface.IsCustomContentAvailable", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }
}
