#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineAccountInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineAccountInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLocalAccountNames;
    /// <summary>
    /// Function: GetLocalAccountNames
    /// </summary>
    public unsafe virtual bool GetLocalAccountNames(out BmSDK.TArray<BmSDK.FString> Accounts)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLocalAccountNames, "Engine.OnlineAccountInterface.GetLocalAccountNames", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Accounts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteLocalAccount;
    /// <summary>
    /// Function: DeleteLocalAccount
    /// </summary>
    public unsafe virtual bool DeleteLocalAccount(BmSDK.FStringArg UserName, BmSDK.FStringArg Password = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteLocalAccount, "Engine.OnlineAccountInterface.DeleteLocalAccount", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserName.WriteTo(paramsPtr + 0);
        Password.WriteTo(paramsPtr + 16);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RenameLocalAccount;
    /// <summary>
    /// Function: RenameLocalAccount
    /// </summary>
    public unsafe virtual bool RenameLocalAccount(BmSDK.FStringArg NewUserName, BmSDK.FStringArg OldUserName, BmSDK.FStringArg Password = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RenameLocalAccount, "Engine.OnlineAccountInterface.RenameLocalAccount", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        NewUserName.WriteTo(paramsPtr + 0);
        OldUserName.WriteTo(paramsPtr + 16);
        Password.WriteTo(paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateLocalAccount;
    /// <summary>
    /// Function: CreateLocalAccount
    /// </summary>
    public unsafe virtual bool CreateLocalAccount(BmSDK.FStringArg UserName, BmSDK.FStringArg Password = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateLocalAccount, "Engine.OnlineAccountInterface.CreateLocalAccount", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserName.WriteTo(paramsPtr + 0);
        Password.WriteTo(paramsPtr + 16);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearCreateOnlineAccountCompletedDelegate;
    /// <summary>
    /// Function: ClearCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe virtual void ClearCreateOnlineAccountCompletedDelegate(BmSDK.FScriptDelegate AccountCreateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearCreateOnlineAccountCompletedDelegate, "Engine.OnlineAccountInterface.ClearCreateOnlineAccountCompletedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountCreateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddCreateOnlineAccountCompletedDelegate;
    /// <summary>
    /// Function: AddCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe virtual void AddCreateOnlineAccountCompletedDelegate(BmSDK.FScriptDelegate AccountCreateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddCreateOnlineAccountCompletedDelegate, "Engine.OnlineAccountInterface.AddCreateOnlineAccountCompletedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountCreateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnCreateOnlineAccountCompleted;
    /// <summary>
    /// Function: OnCreateOnlineAccountCompleted
    /// </summary>
    public unsafe virtual void OnCreateOnlineAccountCompleted(BmSDK.Engine.OnlineSubsystem.EOnlineAccountCreateStatus ErrorStatus)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnCreateOnlineAccountCompleted, "Engine.OnlineAccountInterface.OnCreateOnlineAccountCompleted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateOnlineAccount;
    /// <summary>
    /// Function: CreateOnlineAccount
    /// </summary>
    public unsafe virtual bool CreateOnlineAccount(BmSDK.FStringArg UserName, BmSDK.FStringArg Password, BmSDK.FStringArg EmailAddress, BmSDK.FStringArg ProductKey = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateOnlineAccount, "Engine.OnlineAccountInterface.CreateOnlineAccount", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserName.WriteTo(paramsPtr + 0);
        Password.WriteTo(paramsPtr + 16);
        EmailAddress.WriteTo(paramsPtr + 32);
        ProductKey.WriteTo(paramsPtr + 48);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }
}
