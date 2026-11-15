#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: _OnlineSubsystemSteamworks<br/>
/// (size = 3088)
/// (flags = 134217910)
/// </summary>
public partial class _OnlineSubsystemSteamworks : BmSDK.IpDrv.OnlineSubsystemCommonImpl, BmSDK.Engine.OnlineSystemInterface, BmSDK.Engine.OnlinePlayerInterface, BmSDK.Engine.OnlinePlayerInterfaceEx, BmSDK.Engine.OnlineAccountInterface, BmSDK.Engine.OnlineStatsInterface, BmSDK.Engine.OnlineContentInterface, BmSDK.Engine.OnlineTitleFileInterface, BmSDK.Engine.OnlineVoiceInterface, BmSDK.Engine.OnlineWebInterface, BmSDK.Engine.UserCloudFileInterface, BmSDK.Engine.SharedCloudFileInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as _OnlineSubsystemSteamworks.
    /// </summary>
    public static _OnlineSubsystemSteamworks DefaultObject => (_OnlineSubsystemSteamworks)StaticClass().DefaultObject;

    internal _OnlineSubsystemSteamworks() { }

    /// <summary>
    /// Constructs a new _OnlineSubsystemSteamworks
    /// </summary>
    public _OnlineSubsystemSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, _OnlineSubsystemSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected _OnlineSubsystemSteamworks(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CancelFetchSteamDLC;
    /// <summary>
    /// Function: CancelFetchSteamDLC
    /// </summary>
    public unsafe virtual void CancelFetchSteamDLC(BmSDK.GameObject TargetObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CancelFetchSteamDLC, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CancelFetchSteamDLC", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetObject, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FetchSteamDLC;
    /// <summary>
    /// Function: FetchSteamDLC
    /// </summary>
    public unsafe virtual void FetchSteamDLC(BmSDK.GameObject TargetObject, BmSDK.FScriptDelegate cback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FetchSteamDLC, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FetchSteamDLC", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cback, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SteamDLCCallback;
    /// <summary>
    /// Function: SteamDLCCallback
    /// </summary>
    public unsafe virtual void SteamDLCCallback(bool bWasSuccessful, BmSDK.TArray<BmSDK.IpDrv.OnlineSubsystemCommonImpl.FSteam_PriceInfo> aPrices)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SteamDLCCallback, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SteamDLCCallback", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPrices, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Exit;
    /// <summary>
    /// Function: Exit
    /// </summary>
    public unsafe override void Exit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Exit, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Exit", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Init", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnRequestComplete;
    /// <summary>
    /// Function: OnRequestComplete
    /// </summary>
    public unsafe virtual void OnRequestComplete(BmSDK.Engine.HttpRequestInterface OriginalRequest, BmSDK.Engine.HttpResponseInterface Response, bool bDidSucceed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnRequestComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRequestComplete", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalRequest, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Response, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDidSucceed, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WebRequest;
    /// <summary>
    /// Function: WebRequest
    /// </summary>
    public unsafe virtual void WebRequest(BmSDK.FStringArg HttpMethod, BmSDK.FStringArg URL, BmSDK.FStringArg Params = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WebRequest, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WebRequest", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        HttpMethod.WriteTo(paramsPtr + 0);
        URL.WriteTo(paramsPtr + 16);
        Params.WriteTo(paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSteamID;
    /// <summary>
    /// Function: GetSteamID
    /// </summary>
    public unsafe virtual BmSDK.FString GetSteamID()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSteamID, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSteamID", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteSharedFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteSharedFileCompleteDelegate(BmSDK.FScriptDelegate WriteSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteSharedFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteSharedFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteSharedFileCompleteDelegate(BmSDK.FScriptDelegate WriteSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteSharedFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteSharedFile;
    /// <summary>
    /// Function: WriteSharedFile
    /// </summary>
    public unsafe virtual bool WriteSharedFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> Contents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteSharedFile", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        Contents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteSharedFileComplete;
    /// <summary>
    /// Function: OnWriteSharedFileComplete
    /// </summary>
    public unsafe virtual void OnWriteSharedFileComplete(bool bWasSuccessful, BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, BmSDK.FStringArg SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteSharedFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteSharedFileComplete", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        Filename.WriteTo(paramsPtr + 20);
        SharedHandle.WriteTo(paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadSharedFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadSharedFileCompleteDelegate(BmSDK.FScriptDelegate ReadSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadSharedFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadSharedFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadSharedFileCompleteDelegate(BmSDK.FScriptDelegate ReadSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadSharedFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadSharedFile;
    /// <summary>
    /// Function: ReadSharedFile
    /// </summary>
    public unsafe virtual bool ReadSharedFile(BmSDK.FStringArg SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadSharedFile", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        SharedHandle.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadSharedFileComplete;
    /// <summary>
    /// Function: OnReadSharedFileComplete
    /// </summary>
    public unsafe virtual void OnReadSharedFileComplete(bool bWasSuccessful, BmSDK.FStringArg SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadSharedFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadSharedFileComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        SharedHandle.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearSharedFile;
    /// <summary>
    /// Function: ClearSharedFile
    /// </summary>
    public unsafe virtual bool ClearSharedFile(BmSDK.FStringArg SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearSharedFile", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        SharedHandle.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearSharedFiles;
    /// <summary>
    /// Function: ClearSharedFiles
    /// </summary>
    public unsafe virtual bool ClearSharedFiles()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearSharedFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearSharedFiles", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSharedFileContents;
    /// <summary>
    /// Function: GetSharedFileContents
    /// </summary>
    public unsafe virtual bool GetSharedFileContents(BmSDK.FStringArg SharedHandle, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSharedFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSharedFileContents", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        SharedHandle.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteFileToScatch;
    /// <summary>
    /// Function: WriteFileToScatch
    /// </summary>
    public unsafe virtual bool WriteFileToScatch(byte LocalUserNum, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteFileToScatch, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteFileToScatch", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadFileFromScatch;
    /// <summary>
    /// Function: ReadFileFromScatch
    /// </summary>
    public unsafe virtual bool ReadFileFromScatch(byte LocalUserNum, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> OutFileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadFileFromScatch, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadFileFromScatch", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        OutFileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearAllDelegates;
    /// <summary>
    /// Function: ClearAllDelegates
    /// </summary>
    public unsafe virtual void ClearAllDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearAllDelegates, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearAllDelegates", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CancelDownloadFileIO;
    /// <summary>
    /// Function: CancelDownloadFileIO
    /// </summary>
    public unsafe virtual void CancelDownloadFileIO()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CancelDownloadFileIO, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CancelDownloadFileIO", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDeleteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearDeleteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDeleteDownloadFileCompleteDelegate(BmSDK.FScriptDelegate DeleteDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDeleteDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDeleteDownloadFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDeleteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddDeleteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDeleteDownloadFileCompleteDelegate(BmSDK.FScriptDelegate DeleteDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDeleteDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddDeleteDownloadFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnDeleteDownloadFileComplete;
    /// <summary>
    /// Function: OnDeleteDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteDownloadFileComplete(bool bWasSuccessful, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnDeleteDownloadFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnDeleteDownloadFileComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteDownloadFile;
    /// <summary>
    /// Function: DeleteDownloadFile
    /// </summary>
    public unsafe virtual bool DeleteDownloadFile(BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteDownloadFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteDownloadFile", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteDownloadFileCompleteDelegate(BmSDK.FScriptDelegate WriteDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteDownloadFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteDownloadFileCompleteDelegate(BmSDK.FScriptDelegate WriteDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteDownloadFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteDownloadFileComplete;
    /// <summary>
    /// Function: OnWriteDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnWriteDownloadFileComplete(bool bWasSuccessful, BmSDK.FStringArg Filename, int bytesProcessed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteDownloadFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteDownloadFileComplete", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteDownloadFile;
    /// <summary>
    /// Function: WriteDownloadFile
    /// </summary>
    public unsafe virtual bool WriteDownloadFile(BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents, out BmSDK.FString FileCRC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteDownloadFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteDownloadFile", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        FileCRC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadDownloadFileCompleteDelegate(BmSDK.FScriptDelegate ReadDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadDownloadFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadDownloadFileCompleteDelegate(BmSDK.FScriptDelegate ReadDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadDownloadFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadDownloadFileComplete;
    /// <summary>
    /// Function: OnReadDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnReadDownloadFileComplete(bool bWasSuccessful, BmSDK.FStringArg Filename, int bytesProcessed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadDownloadFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadDownloadFileComplete", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadDownloadFile;
    /// <summary>
    /// Function: ReadDownloadFile
    /// </summary>
    public unsafe virtual bool ReadDownloadFile(BmSDK.FStringArg Filename, out BmSDK.TArray<byte> OutFileContents, out BmSDK.FString OutFileCRC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadDownloadFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadDownloadFile", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        OutFileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        OutFileCRC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDownloadFileSize;
    /// <summary>
    /// Function: GetDownloadFileSize
    /// </summary>
    public unsafe virtual int GetDownloadFileSize(BmSDK.FStringArg Filename, bool KeepHandle = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDownloadFileSize, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetDownloadFileSize", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeepHandle, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnumerateDownloadFiles;
    /// <summary>
    /// Function: EnumerateDownloadFiles
    /// </summary>
    public unsafe virtual void EnumerateDownloadFiles(out BmSDK.TArray<BmSDK.FString> OutFiles, BmSDK.FStringArg Subfolder)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnumerateDownloadFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.EnumerateDownloadFiles", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Subfolder.WriteTo(paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        OutFiles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnumerateDownloadFolders;
    /// <summary>
    /// Function: EnumerateDownloadFolders
    /// </summary>
    public unsafe virtual void EnumerateDownloadFolders(out BmSDK.TArray<BmSDK.FString> OutFolders)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnumerateDownloadFolders, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.EnumerateDownloadFolders", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutFolders = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDeleteUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDeleteUserFileCompleteDelegate(BmSDK.FScriptDelegate DeleteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDeleteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDeleteUserFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDeleteUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDeleteUserFileCompleteDelegate(BmSDK.FScriptDelegate DeleteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDeleteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddDeleteUserFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteUserFile;
    /// <summary>
    /// Function: DeleteUserFile
    /// </summary>
    public unsafe virtual bool DeleteUserFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, bool bShouldCloudDelete, bool bShouldLocallyDelete)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteUserFile", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldCloudDelete, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldLocallyDelete, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnDeleteUserFileComplete;
    /// <summary>
    /// Function: OnDeleteUserFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteUserFileComplete(bool bWasSuccessful, BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnDeleteUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnDeleteUserFileComplete", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        Filename.WriteTo(paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteUserFileCompleteDelegate(BmSDK.FScriptDelegate WriteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteUserFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteUserFileCompleteDelegate(BmSDK.FScriptDelegate WriteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteUserFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ManageLocalBackups;
    /// <summary>
    /// Function: ManageLocalBackups
    /// </summary>
    public unsafe virtual bool ManageLocalBackups(BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ManageLocalBackups, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ManageLocalBackups", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteUserFileLocal;
    /// <summary>
    /// Function: WriteUserFileLocal
    /// </summary>
    public unsafe virtual bool WriteUserFileLocal(BmSDK.FStringArg SaveName, out BmSDK.TArray<byte> Contents, bool isSteamBackup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteUserFileLocal, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteUserFileLocal", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        SaveName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isSteamBackup, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        Contents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteUserFile;
    /// <summary>
    /// Function: WriteUserFile
    /// </summary>
    public unsafe virtual bool WriteUserFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteUserFile", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteUserFileComplete;
    /// <summary>
    /// Function: OnWriteUserFileComplete
    /// </summary>
    public unsafe virtual void OnWriteUserFileComplete(bool bWasSuccessful, BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteUserFileComplete", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        Filename.WriteTo(paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadUserFileCompleteDelegate(BmSDK.FScriptDelegate ReadUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadUserFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadUserFileCompleteDelegate(BmSDK.FScriptDelegate ReadUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadUserFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadUserFile;
    /// <summary>
    /// Function: ReadUserFile
    /// </summary>
    public unsafe virtual bool ReadUserFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadUserFile", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadUserFileComplete;
    /// <summary>
    /// Function: OnReadUserFileComplete
    /// </summary>
    public unsafe virtual void OnReadUserFileComplete(bool bWasSuccessful, BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadUserFileComplete", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        Filename.WriteTo(paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUserFileList;
    /// <summary>
    /// Function: GetUserFileList
    /// </summary>
    public unsafe virtual void GetUserFileList(BmSDK.FStringArg UserId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserFiles)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUserFileList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUserFileList", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        UserFiles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearEnumerateUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearEnumerateUserFileCompleteDelegate(BmSDK.FScriptDelegate EnumerateUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearEnumerateUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearEnumerateUserFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnumerateUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddEnumerateUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddEnumerateUserFileCompleteDelegate(BmSDK.FScriptDelegate EnumerateUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddEnumerateUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddEnumerateUserFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnumerateUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnumerateUserFiles;
    /// <summary>
    /// Function: EnumerateUserFiles
    /// </summary>
    public unsafe virtual void EnumerateUserFiles(BmSDK.FStringArg UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnumerateUserFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.EnumerateUserFiles", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnEnumerateUserFilesComplete;
    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe virtual void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FStringArg UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnEnumerateUserFilesComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnEnumerateUserFilesComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFile;
    /// <summary>
    /// Function: ClearFile
    /// </summary>
    public unsafe virtual bool ClearFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFile", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFiles;
    /// <summary>
    /// Function: ClearFiles
    /// </summary>
    public unsafe virtual bool ClearFiles(BmSDK.FStringArg UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFiles", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFileContents;
    /// <summary>
    /// Function: GetFileContents
    /// </summary>
    public unsafe virtual bool GetFileContents(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFileContents", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyVOIPPlaybackFinished;
    /// <summary>
    /// Function: NotifyVOIPPlaybackFinished
    /// </summary>
    public unsafe virtual void NotifyVOIPPlaybackFinished(BmSDK.Engine.AudioComponent VOIPAudioComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyVOIPPlaybackFinished, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.NotifyVOIPPlaybackFinished", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VOIPAudioComponent, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnVOIPPlaybackFinished;
    /// <summary>
    /// Function: OnVOIPPlaybackFinished
    /// </summary>
    public unsafe virtual void OnVOIPPlaybackFinished(BmSDK.Engine.AudioComponent AC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnVOIPPlaybackFinished, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnVOIPPlaybackFinished", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnmuteAll;
    /// <summary>
    /// Function: UnmuteAll
    /// </summary>
    public unsafe virtual bool UnmuteAll(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnmuteAll, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnmuteAll", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MuteAll;
    /// <summary>
    /// Function: MuteAll
    /// </summary>
    public unsafe virtual bool MuteAll(byte LocalUserNum, bool bAllowFriends)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MuteAll, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.MuteAll", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowFriends, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetSpeechRecognitionObject;
    /// <summary>
    /// Function: SetSpeechRecognitionObject
    /// </summary>
    public unsafe virtual bool SetSpeechRecognitionObject(byte LocalUserNum, BmSDK.Engine.SpeechRecognition SpeechRecogObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetSpeechRecognitionObject, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetSpeechRecognitionObject", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechRecogObj, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SelectVocabulary;
    /// <summary>
    /// Function: SelectVocabulary
    /// </summary>
    public unsafe virtual bool SelectVocabulary(byte LocalUserNum, int VocabularyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SelectVocabulary, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SelectVocabulary", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VocabularyId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearRecognitionCompleteDelegate;
    /// <summary>
    /// Function: ClearRecognitionCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearRecognitionCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate RecognitionDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearRecognitionCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearRecognitionCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecognitionDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddRecognitionCompleteDelegate;
    /// <summary>
    /// Function: AddRecognitionCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRecognitionCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate RecognitionDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddRecognitionCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddRecognitionCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecognitionDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnRecognitionComplete;
    /// <summary>
    /// Function: OnRecognitionComplete
    /// </summary>
    public unsafe virtual void OnRecognitionComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnRecognitionComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRecognitionComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRecognitionResults;
    /// <summary>
    /// Function: GetRecognitionResults
    /// </summary>
    public unsafe virtual bool GetRecognitionResults(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FSpeechRecognizedWord> Words)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRecognitionResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetRecognitionResults", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Words = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FSpeechRecognizedWord>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopSpeechRecognition;
    /// <summary>
    /// Function: StopSpeechRecognition
    /// </summary>
    public unsafe virtual bool StopSpeechRecognition(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopSpeechRecognition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StopSpeechRecognition", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartSpeechRecognition;
    /// <summary>
    /// Function: StartSpeechRecognition
    /// </summary>
    public unsafe virtual bool StartSpeechRecognition(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartSpeechRecognition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StartSpeechRecognition", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopNetworkedVoice;
    /// <summary>
    /// Function: StopNetworkedVoice
    /// </summary>
    public unsafe virtual void StopNetworkedVoice(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopNetworkedVoice, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StopNetworkedVoice", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartNetworkedVoice;
    /// <summary>
    /// Function: StartNetworkedVoice
    /// </summary>
    public unsafe virtual void StartNetworkedVoice(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartNetworkedVoice, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StartNetworkedVoice", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearPlayerTalkingDelegate;
    /// <summary>
    /// Function: ClearPlayerTalkingDelegate
    /// </summary>
    public unsafe virtual void ClearPlayerTalkingDelegate(BmSDK.FScriptDelegate TalkerDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearPlayerTalkingDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearPlayerTalkingDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TalkerDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddPlayerTalkingDelegate;
    /// <summary>
    /// Function: AddPlayerTalkingDelegate
    /// </summary>
    public unsafe virtual void AddPlayerTalkingDelegate(BmSDK.FScriptDelegate TalkerDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddPlayerTalkingDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddPlayerTalkingDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TalkerDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPlayerTalkingStateChange;
    /// <summary>
    /// Function: OnPlayerTalkingStateChange
    /// </summary>
    public unsafe virtual void OnPlayerTalkingStateChange(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, bool bIsTalking)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPlayerTalkingStateChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnPlayerTalkingStateChange", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsTalking, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnmuteRemoteTalker;
    /// <summary>
    /// Function: UnmuteRemoteTalker
    /// </summary>
    public unsafe virtual bool UnmuteRemoteTalker(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bIsSystemWide = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnmuteRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnmuteRemoteTalker", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSystemWide, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MuteRemoteTalker;
    /// <summary>
    /// Function: MuteRemoteTalker
    /// </summary>
    public unsafe virtual bool MuteRemoteTalker(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bIsSystemWide = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MuteRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.MuteRemoteTalker", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSystemWide, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetRemoteTalkerPriority;
    /// <summary>
    /// Function: SetRemoteTalkerPriority
    /// </summary>
    public unsafe virtual bool SetRemoteTalkerPriority(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, int Priority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetRemoteTalkerPriority, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetRemoteTalkerPriority", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsHeadsetPresent;
    /// <summary>
    /// Function: IsHeadsetPresent
    /// </summary>
    public unsafe virtual bool IsHeadsetPresent(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsHeadsetPresent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsHeadsetPresent", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsRemotePlayerTalking;
    /// <summary>
    /// Function: IsRemotePlayerTalking
    /// </summary>
    public unsafe virtual bool IsRemotePlayerTalking(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsRemotePlayerTalking, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsRemotePlayerTalking", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsLocalPlayerTalking;
    /// <summary>
    /// Function: IsLocalPlayerTalking
    /// </summary>
    public unsafe virtual bool IsLocalPlayerTalking(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsLocalPlayerTalking, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsLocalPlayerTalking", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnregisterRemoteTalker;
    /// <summary>
    /// Function: UnregisterRemoteTalker
    /// </summary>
    public unsafe virtual bool UnregisterRemoteTalker(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnregisterRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnregisterRemoteTalker", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterRemoteTalker;
    /// <summary>
    /// Function: RegisterRemoteTalker
    /// </summary>
    public unsafe virtual bool RegisterRemoteTalker(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterRemoteTalker", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnregisterLocalTalker;
    /// <summary>
    /// Function: UnregisterLocalTalker
    /// </summary>
    public unsafe virtual bool UnregisterLocalTalker(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnregisterLocalTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnregisterLocalTalker", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterLocalTalker;
    /// <summary>
    /// Function: RegisterLocalTalker
    /// </summary>
    public unsafe virtual bool RegisterLocalTalker(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterLocalTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterLocalTalker", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearRequestTitleFileListCompleteDelegate;
    /// <summary>
    /// Function: ClearRequestTitleFileListCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearRequestTitleFileListCompleteDelegate(BmSDK.FScriptDelegate RequestTitleFileListDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearRequestTitleFileListCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearRequestTitleFileListCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestTitleFileListDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddRequestTitleFileListCompleteDelegate;
    /// <summary>
    /// Function: AddRequestTitleFileListCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRequestTitleFileListCompleteDelegate(BmSDK.FScriptDelegate RequestTitleFileListDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddRequestTitleFileListCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddRequestTitleFileListCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestTitleFileListDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnRequestTitleFileListComplete;
    /// <summary>
    /// Function: OnRequestTitleFileListComplete
    /// </summary>
    public unsafe virtual void OnRequestTitleFileListComplete(bool bWasSuccessful, BmSDK.FStringArg ResultStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnRequestTitleFileListComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRequestTitleFileListComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        ResultStr.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RequestTitleFileList;
    /// <summary>
    /// Function: RequestTitleFileList
    /// </summary>
    public unsafe virtual void RequestTitleFileList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RequestTitleFileList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RequestTitleFileList", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDownloadedFile;
    /// <summary>
    /// Function: ClearDownloadedFile
    /// </summary>
    public unsafe virtual bool ClearDownloadedFile(BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDownloadedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDownloadedFile", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDownloadedFiles;
    /// <summary>
    /// Function: ClearDownloadedFiles
    /// </summary>
    public unsafe virtual bool ClearDownloadedFiles()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDownloadedFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDownloadedFiles", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTitleFileState;
    /// <summary>
    /// Function: GetTitleFileState
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetTitleFileState(BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTitleFileState, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTitleFileState", this);
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTitleFileContents;
    /// <summary>
    /// Function: GetTitleFileContents
    /// </summary>
    public unsafe virtual bool GetTitleFileContents(BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTitleFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTitleFileContents", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadTitleFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadTitleFileCompleteDelegate(BmSDK.FScriptDelegate ReadTitleFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadTitleFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadTitleFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadTitleFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadTitleFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadTitleFileCompleteDelegate(BmSDK.FScriptDelegate ReadTitleFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadTitleFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadTitleFileCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadTitleFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadTitleFile;
    /// <summary>
    /// Function: ReadTitleFile
    /// </summary>
    public unsafe virtual bool ReadTitleFile(BmSDK.FStringArg FileToRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadTitleFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadTitleFile", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        FileToRead.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadTitleFileComplete;
    /// <summary>
    /// Function: OnReadTitleFileComplete
    /// </summary>
    public unsafe virtual void OnReadTitleFileComplete(bool bWasSuccessful, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadTitleFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadTitleFileComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearSaveGames;
    /// <summary>
    /// Function: ClearSaveGames
    /// </summary>
    public unsafe virtual bool ClearSaveGames(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearSaveGames, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearSaveGames", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteSaveGame;
    /// <summary>
    /// Function: DeleteSaveGame
    /// </summary>
    public unsafe virtual bool DeleteSaveGame(byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteSaveGame, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteSaveGame", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        FriendlyName.WriteTo(paramsPtr + 8);
        Filename.WriteTo(paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteSaveGameDataComplete;
    /// <summary>
    /// Function: ClearWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearWriteSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate WriteSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteSaveGameDataComplete;
    /// <summary>
    /// Function: AddWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddWriteSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate WriteSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteSaveGameDataComplete;
    /// <summary>
    /// Function: OnWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnWriteSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        FriendlyName.WriteTo(paramsPtr + 12);
        Filename.WriteTo(paramsPtr + 28);
        SaveFileName.WriteTo(paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteSaveGameData;
    /// <summary>
    /// Function: WriteSaveGameData
    /// </summary>
    public unsafe virtual bool WriteSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName, out BmSDK.TArray<byte> SaveGameData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteSaveGameData", this);
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        FriendlyName.WriteTo(paramsPtr + 8);
        Filename.WriteTo(paramsPtr + 24);
        SaveFileName.WriteTo(paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 40);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 56);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadSaveGameDataComplete;
    /// <summary>
    /// Function: ClearReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearReadSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadSaveGameDataComplete;
    /// <summary>
    /// Function: AddReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddReadSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadSaveGameDataComplete;
    /// <summary>
    /// Function: OnReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnReadSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        FriendlyName.WriteTo(paramsPtr + 12);
        Filename.WriteTo(paramsPtr + 28);
        SaveFileName.WriteTo(paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSaveGameData;
    /// <summary>
    /// Function: GetSaveGameData
    /// </summary>
    public unsafe virtual bool GetSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSaveGameData", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        FriendlyName.WriteTo(paramsPtr + 8);
        Filename.WriteTo(paramsPtr + 24);
        SaveFileName.WriteTo(paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bIsValid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsValid, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 40);
        bIsValid = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 56);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 76);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadSaveGameData;
    /// <summary>
    /// Function: ReadSaveGameData
    /// </summary>
    public unsafe virtual bool ReadSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadSaveGameData", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        FriendlyName.WriteTo(paramsPtr + 8);
        Filename.WriteTo(paramsPtr + 24);
        SaveFileName.WriteTo(paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 56);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAvailableDownloadCounts;
    /// <summary>
    /// Function: GetAvailableDownloadCounts
    /// </summary>
    public unsafe virtual void GetAvailableDownloadCounts(byte LocalUserNum, out int NewDownloads, out int TotalDownloads)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAvailableDownloadCounts, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetAvailableDownloadCounts", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewDownloads);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDownloads, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalDownloads);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalDownloads, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewDownloads = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        TotalDownloads = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: ClearQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void ClearQueryAvailableDownloadsComplete(byte LocalUserNum, BmSDK.FScriptDelegate QueryDownloadsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearQueryAvailableDownloadsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearQueryAvailableDownloadsComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDownloadsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: AddQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void AddQueryAvailableDownloadsComplete(byte LocalUserNum, BmSDK.FScriptDelegate QueryDownloadsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddQueryAvailableDownloadsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddQueryAvailableDownloadsComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDownloadsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: OnQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void OnQueryAvailableDownloadsComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnQueryAvailableDownloadsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnQueryAvailableDownloadsComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_QueryAvailableDownloads;
    /// <summary>
    /// Function: QueryAvailableDownloads
    /// </summary>
    public unsafe virtual bool QueryAvailableDownloads(byte LocalUserNum, int CategoryMask = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_QueryAvailableDownloads, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.QueryAvailableDownloads", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryMask, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearCrossTitleSaveGames;
    /// <summary>
    /// Function: ClearCrossTitleSaveGames
    /// </summary>
    public unsafe virtual bool ClearCrossTitleSaveGames(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearCrossTitleSaveGames, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCrossTitleSaveGames", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: ClearReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadCrossTitleSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadCrossTitleSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: AddReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddReadCrossTitleSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadCrossTitleSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadCrossTitleSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: OnReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadCrossTitleSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadCrossTitleSaveGameDataComplete", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 12);
        FriendlyName.WriteTo(paramsPtr + 16);
        Filename.WriteTo(paramsPtr + 32);
        SaveFileName.WriteTo(paramsPtr + 48);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCrossTitleSaveGameData;
    /// <summary>
    /// Function: GetCrossTitleSaveGameData
    /// </summary>
    public unsafe virtual bool GetCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCrossTitleSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCrossTitleSaveGameData", this);
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 8);
        FriendlyName.WriteTo(paramsPtr + 12);
        Filename.WriteTo(paramsPtr + 28);
        SaveFileName.WriteTo(paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bIsValid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsValid, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        bIsValid = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 60);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 80);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadCrossTitleSaveGameData;
    /// <summary>
    /// Function: ReadCrossTitleSaveGameData
    /// </summary>
    public unsafe virtual bool ReadCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadCrossTitleSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadCrossTitleSaveGameData", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 8);
        FriendlyName.WriteTo(paramsPtr + 12);
        Filename.WriteTo(paramsPtr + 28);
        SaveFileName.WriteTo(paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadCrossTitleContentCompleteDelegate;
    /// <summary>
    /// Function: ClearReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, BmSDK.FScriptDelegate ReadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadCrossTitleContentCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadCrossTitleContentCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadCrossTitleContentCompleteDelegate;
    /// <summary>
    /// Function: AddReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, BmSDK.FScriptDelegate ReadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadCrossTitleContentCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadCrossTitleContentCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadCrossTitleContentComplete;
    /// <summary>
    /// Function: OnReadCrossTitleContentComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleContentComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadCrossTitleContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadCrossTitleContentComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCrossTitleContentList;
    /// <summary>
    /// Function: GetCrossTitleContentList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent> ContentList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCrossTitleContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCrossTitleContentList", this);
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearCrossTitleContentList;
    /// <summary>
    /// Function: ClearCrossTitleContentList
    /// </summary>
    public unsafe virtual void ClearCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearCrossTitleContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCrossTitleContentList", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadCrossTitleContentList;
    /// <summary>
    /// Function: ReadCrossTitleContentList
    /// </summary>
    public unsafe virtual bool ReadCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int TitleId = default, int DeviceID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadCrossTitleContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadCrossTitleContentList", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUserLanguage;
    /// <summary>
    /// Function: GetUserLanguage
    /// </summary>
    public unsafe virtual BmSDK.FString GetUserLanguage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUserLanguage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUserLanguage", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUserCountryCode;
    /// <summary>
    /// Function: GetUserCountryCode
    /// </summary>
    public unsafe virtual BmSDK.FString GetUserCountryCode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUserCountryCode, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUserCountryCode", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowPS4DownloadList;
    /// <summary>
    /// Function: ShowPS4DownloadList
    /// </summary>
    public unsafe virtual void ShowPS4DownloadList(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowPS4DownloadList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowPS4DownloadList", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowPS4StoreIcon;
    /// <summary>
    /// Function: ShowPS4StoreIcon
    /// </summary>
    public unsafe virtual void ShowPS4StoreIcon(bool bShow, int Position = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowPS4StoreIcon, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowPS4StoreIcon", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BrowseInGameStoreItem;
    /// <summary>
    /// Function: BrowseInGameStoreItem
    /// </summary>
    public unsafe virtual void BrowseInGameStoreItem(byte LocalUserNum, BmSDK.FStringArg ItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BrowseInGameStoreItem, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.BrowseInGameStoreItem", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        ItemId.WriteTo(paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PurchaseInGameStoreItem;
    /// <summary>
    /// Function: PurchaseInGameStoreItem
    /// </summary>
    public unsafe virtual void PurchaseInGameStoreItem(byte LocalUserNum, BmSDK.FStringArg ItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PurchaseInGameStoreItem, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.PurchaseInGameStoreItem", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        ItemId.WriteTo(paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: ClearPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void ClearPurchaseInGameStoreContentComplete(byte LocalUserNum, BmSDK.FScriptDelegate PurchaseInGameStoreContentComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearPurchaseInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearPurchaseInGameStoreContentComplete", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: AddPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void AddPurchaseInGameStoreContentComplete(byte LocalUserNum, BmSDK.FScriptDelegate PurchaseInGameStoreContentComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddPurchaseInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddPurchaseInGameStoreContentComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: OnPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnPurchaseInGameStoreContentComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPurchaseInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnPurchaseInGameStoreContentComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetInGameStoreContentList;
    /// <summary>
    /// Function: GetInGameStoreContentList
    /// </summary>
    public unsafe virtual void GetInGameStoreContentList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent> ContentList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetInGameStoreContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetInGameStoreContentList", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ContentList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadInGameStoreContentList;
    /// <summary>
    /// Function: ReadInGameStoreContentList
    /// </summary>
    public unsafe virtual bool ReadInGameStoreContentList(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadInGameStoreContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadInGameStoreContentList", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearInGameStoreContentList;
    /// <summary>
    /// Function: ClearInGameStoreContentList
    /// </summary>
    public unsafe virtual void ClearInGameStoreContentList(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearInGameStoreContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearInGameStoreContentList", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadInGameStoreContentComplete;
    /// <summary>
    /// Function: ClearReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void ClearReadInGameStoreContentComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadInGameStoreContentComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadInGameStoreContentComplete", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadInGameStoreContentComplete;
    /// <summary>
    /// Function: AddReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void AddReadInGameStoreContentComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadInGameStoreContentComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadInGameStoreContentComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadInGameStoreContentComplete;
    /// <summary>
    /// Function: OnReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnReadInGameStoreContentComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadInGameStoreContentComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearContentStatusChangeDelegate;
    /// <summary>
    /// Function: ClearContentStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearContentStatusChangeDelegate(BmSDK.FScriptDelegate ContentStatusChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearContentStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearContentStatusChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentStatusChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddContentStatusChangeDelegate;
    /// <summary>
    /// Function: AddContentStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddContentStatusChangeDelegate(BmSDK.FScriptDelegate ContentStatusChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddContentStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddContentStatusChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentStatusChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnContentStatusChange;
    /// <summary>
    /// Function: OnContentStatusChange
    /// </summary>
    public unsafe virtual void OnContentStatusChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnContentStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnContentStatusChange", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetContentList;
    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> ContentList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetContentList", this);
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearContentList;
    /// <summary>
    /// Function: ClearContentList
    /// </summary>
    public unsafe virtual void ClearContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearContentList", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadContentList;
    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe virtual bool ReadContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int DeviceID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadContentList", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasContentUpdated;
    /// <summary>
    /// Function: HasContentUpdated
    /// </summary>
    public unsafe virtual bool HasContentUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasContentUpdated, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.HasContentUpdated", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadContentComplete;
    /// <summary>
    /// Function: ClearReadContentComplete
    /// </summary>
    public unsafe virtual void ClearReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, BmSDK.FScriptDelegate ReadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadContentComplete", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadContentComplete;
    /// <summary>
    /// Function: AddReadContentComplete
    /// </summary>
    public unsafe virtual void AddReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, BmSDK.FScriptDelegate ReadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadContentComplete", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadContentComplete;
    /// <summary>
    /// Function: OnReadContentComplete
    /// </summary>
    public unsafe virtual void OnReadContentComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadContentComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearContentChangeDelegate;
    /// <summary>
    /// Function: ClearContentChangeDelegate
    /// </summary>
    public unsafe virtual void ClearContentChangeDelegate(BmSDK.FScriptDelegate ContentDelegate, byte LocalUserNum = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearContentChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearContentChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddContentChangeDelegate;
    /// <summary>
    /// Function: AddContentChangeDelegate
    /// </summary>
    public unsafe virtual void AddContentChangeDelegate(BmSDK.FScriptDelegate ContentDelegate, byte LocalUserNum = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddContentChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddContentChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnContentChange;
    /// <summary>
    /// Function: OnContentChange
    /// </summary>
    public unsafe virtual void OnContentChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnContentChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnContentChange", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CalcAggregateSkill;
    /// <summary>
    /// Function: CalcAggregateSkill
    /// </summary>
    public unsafe virtual void CalcAggregateSkill(BmSDK.TArray<double> Mus, BmSDK.TArray<double> Sigmas, out double OutAggregateMu, out double OutAggregateSigma)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CalcAggregateSkill, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CalcAggregateSkill", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sigmas, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAggregateMu);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAggregateMu, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAggregateSigma);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAggregateSigma, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAggregateMu = BmSDK.Framework.MarshalUtil.ToManagedParam<double>(paramsPtr + 32);
        OutAggregateSigma = BmSDK.Framework.MarshalUtil.ToManagedParam<double>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterStatGuid;
    /// <summary>
    /// Function: RegisterStatGuid
    /// </summary>
    public unsafe virtual bool RegisterStatGuid(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, out BmSDK.FString ClientStatGuid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterStatGuid", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClientStatGuid = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetClientStatGuid;
    /// <summary>
    /// Function: GetClientStatGuid
    /// </summary>
    public unsafe virtual BmSDK.FString GetClientStatGuid()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetClientStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetClientStatGuid", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearRegisterHostStatGuidCompleteDelegateDelegate;
    /// <summary>
    /// Function: ClearRegisterHostStatGuidCompleteDelegateDelegate
    /// </summary>
    public unsafe virtual void ClearRegisterHostStatGuidCompleteDelegateDelegate(BmSDK.FScriptDelegate RegisterHostStatGuidCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearRegisterHostStatGuidCompleteDelegateDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearRegisterHostStatGuidCompleteDelegateDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterHostStatGuidCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddRegisterHostStatGuidCompleteDelegate;
    /// <summary>
    /// Function: AddRegisterHostStatGuidCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRegisterHostStatGuidCompleteDelegate(BmSDK.FScriptDelegate RegisterHostStatGuidCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddRegisterHostStatGuidCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddRegisterHostStatGuidCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterHostStatGuidCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnRegisterHostStatGuidComplete;
    /// <summary>
    /// Function: OnRegisterHostStatGuidComplete
    /// </summary>
    public unsafe virtual void OnRegisterHostStatGuidComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnRegisterHostStatGuidComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRegisterHostStatGuidComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterHostStatGuid;
    /// <summary>
    /// Function: RegisterHostStatGuid
    /// </summary>
    public unsafe virtual bool RegisterHostStatGuid(out BmSDK.FString HostStatGuid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterHostStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterHostStatGuid", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HostStatGuid = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHostStatGuid;
    /// <summary>
    /// Function: GetHostStatGuid
    /// </summary>
    public unsafe virtual BmSDK.FString GetHostStatGuid()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHostStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetHostStatGuid", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteOnlinePlayerScores;
    /// <summary>
    /// Function: WriteOnlinePlayerScores
    /// </summary>
    public unsafe virtual bool WriteOnlinePlayerScores(BmSDK.FName SessionName, int LeaderboardId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore> PlayerScores)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteOnlinePlayerScores, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteOnlinePlayerScores", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardId, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerScores = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore>>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateLeaderboard;
    /// <summary>
    /// Function: CreateLeaderboard
    /// </summary>
    public unsafe virtual bool CreateLeaderboard(BmSDK.FStringArg LeaderboardName, BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType SortType, BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat DisplayFormat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateLeaderboard, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateLeaderboard", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        LeaderboardName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SortType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayFormat, paramsPtr + 17);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetStats;
    /// <summary>
    /// Function: ResetStats
    /// </summary>
    public unsafe virtual bool ResetStats(bool bResetAchievements)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetStats", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetAchievements, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFlushOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: ClearFlushOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearFlushOnlineStatsCompleteDelegate(BmSDK.FScriptDelegate FlushOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFlushOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFlushOnlineStatsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlushOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddFlushOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: AddFlushOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddFlushOnlineStatsCompleteDelegate(BmSDK.FScriptDelegate FlushOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddFlushOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFlushOnlineStatsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlushOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFlushOnlineStatsComplete;
    /// <summary>
    /// Function: OnFlushOnlineStatsComplete
    /// </summary>
    public unsafe virtual void OnFlushOnlineStatsComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFlushOnlineStatsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFlushOnlineStatsComplete", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FlushOnlineStats;
    /// <summary>
    /// Function: FlushOnlineStats
    /// </summary>
    public unsafe virtual bool FlushOnlineStats(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FlushOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FlushOnlineStats", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteOnlineStats;
    /// <summary>
    /// Function: WriteOnlineStats
    /// </summary>
    public unsafe virtual bool WriteOnlineStats(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, BmSDK.Engine.OnlineStatsWrite StatsWrite)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteOnlineStats", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsWrite, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FreeStats;
    /// <summary>
    /// Function: FreeStats
    /// </summary>
    public unsafe virtual void FreeStats(BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FreeStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FreeStats", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadOnlineStatsCompleteDelegate(BmSDK.FScriptDelegate ReadOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadOnlineStatsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: AddReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadOnlineStatsCompleteDelegate(BmSDK.FScriptDelegate ReadOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadOnlineStatsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadOnlineStatsComplete;
    /// <summary>
    /// Function: OnReadOnlineStatsComplete
    /// </summary>
    public unsafe virtual void OnReadOnlineStatsComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadOnlineStatsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadOnlineStatsComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineStatsByRankAroundPlayer;
    /// <summary>
    /// Function: ReadOnlineStatsByRankAroundPlayer
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsByRankAroundPlayer(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead, int NumRows = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineStatsByRankAroundPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsByRankAroundPlayer", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumRows, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineStatsByRank;
    /// <summary>
    /// Function: ReadOnlineStatsByRank
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsByRank(BmSDK.Engine.OnlineStatsRead StatsRead, int StartIndex = default, int NumToRead = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineStatsByRank, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsByRank", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToRead, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineStatsForFriends;
    /// <summary>
    /// Function: ReadOnlineStatsForFriends
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsForFriends(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineStatsForFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsForFriends", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineStats;
    /// <summary>
    /// Function: ReadOnlineStats
    /// </summary>
    public unsafe virtual bool ReadOnlineStats(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStats", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DebugWriteLBForUser;
    /// <summary>
    /// Function: DebugWriteLBForUser
    /// </summary>
    public unsafe virtual void DebugWriteLBForUser(BmSDK.FStringArg User, int BoardID, int RankValue, BmSDK.TArray<int> StatsArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DebugWriteLBForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DebugWriteLBForUser", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        User.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RankValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsArray, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DropOnlineStatsRead;
    /// <summary>
    /// Function: DropOnlineStatsRead
    /// </summary>
    public unsafe virtual void DropOnlineStatsRead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DropOnlineStatsRead, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DropOnlineStatsRead", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetOnlineStatsForAllUsers;
    /// <summary>
    /// Function: ResetOnlineStatsForAllUsers
    /// </summary>
    public unsafe virtual bool ResetOnlineStatsForAllUsers(int BoardID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetOnlineStatsForAllUsers, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetOnlineStatsForAllUsers", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetOnlineStatsForUser;
    /// <summary>
    /// Function: ResetOnlineStatsForUser
    /// </summary>
    public unsafe virtual bool ResetOnlineStatsForUser(byte LocalUserNum, int BoardID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetOnlineStatsForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetOnlineStatsForUser", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLocalAccountNames;
    /// <summary>
    /// Function: GetLocalAccountNames
    /// </summary>
    public unsafe virtual bool GetLocalAccountNames(out BmSDK.TArray<BmSDK.FString> Accounts)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLocalAccountNames, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLocalAccountNames", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Accounts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteLocalAccount;
    /// <summary>
    /// Function: DeleteLocalAccount
    /// </summary>
    public unsafe virtual bool DeleteLocalAccount(BmSDK.FStringArg UserName, BmSDK.FStringArg Password = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteLocalAccount", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserName.WriteTo(paramsPtr + 0);
        Password.WriteTo(paramsPtr + 16);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RenameLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RenameLocalAccount", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        NewUserName.WriteTo(paramsPtr + 0);
        OldUserName.WriteTo(paramsPtr + 16);
        Password.WriteTo(paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateLocalAccount", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserName.WriteTo(paramsPtr + 0);
        Password.WriteTo(paramsPtr + 16);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearCreateOnlineAccountCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCreateOnlineAccountCompletedDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountCreateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddCreateOnlineAccountCompletedDelegate;
    /// <summary>
    /// Function: AddCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe virtual void AddCreateOnlineAccountCompletedDelegate(BmSDK.FScriptDelegate AccountCreateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddCreateOnlineAccountCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddCreateOnlineAccountCompletedDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountCreateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnCreateOnlineAccountCompleted;
    /// <summary>
    /// Function: OnCreateOnlineAccountCompleted
    /// </summary>
    public unsafe virtual void OnCreateOnlineAccountCompleted(BmSDK.Engine.OnlineSubsystem.EOnlineAccountCreateStatus ErrorStatus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnCreateOnlineAccountCompleted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnCreateOnlineAccountCompleted", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateOnlineAccount;
    /// <summary>
    /// Function: CreateOnlineAccount
    /// </summary>
    public unsafe virtual bool CreateOnlineAccount(BmSDK.FStringArg UserName, BmSDK.FStringArg Password, BmSDK.FStringArg EmailAddress, BmSDK.FStringArg ProductKey = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateOnlineAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateOnlineAccount", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserName.WriteTo(paramsPtr + 0);
        Password.WriteTo(paramsPtr + 16);
        EmailAddress.WriteTo(paramsPtr + 32);
        ProductKey.WriteTo(paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsExternalRemoteDevice;
    /// <summary>
    /// Function: IsExternalRemoteDevice
    /// </summary>
    public unsafe virtual bool IsExternalRemoteDevice()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsExternalRemoteDevice, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsExternalRemoteDevice", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OpenWebBrowser;
    /// <summary>
    /// Function: OpenWebBrowser
    /// </summary>
    public unsafe virtual void OpenWebBrowser(BmSDK.FStringArg sURL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OpenWebBrowser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OpenWebBrowser", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sURL.WriteTo(paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNpAvailabilityForUser;
    /// <summary>
    /// Function: GetNpAvailabilityForUser
    /// </summary>
    public unsafe virtual int GetNpAvailabilityForUser(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNpAvailabilityForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNpAvailabilityForUser", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckNpAvailabilityForUser;
    /// <summary>
    /// Function: CheckNpAvailabilityForUser
    /// </summary>
    public unsafe virtual void CheckNpAvailabilityForUser(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckNpAvailabilityForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CheckNpAvailabilityForUser", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StreamingInstall_Poll;
    /// <summary>
    /// Function: StreamingInstall_Poll
    /// </summary>
    public unsafe virtual int StreamingInstall_Poll(out int Percent, out int Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StreamingInstall_Poll, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StreamingInstall_Poll", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Percent);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percent, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Percent = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StreamingInstall_CheckChunk;
    /// <summary>
    /// Function: StreamingInstall_CheckChunk
    /// </summary>
    public unsafe virtual bool StreamingInstall_CheckChunk(int Chunk)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StreamingInstall_CheckChunk, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StreamingInstall_CheckChunk", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Chunk, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StreamingInstall_IsFinished;
    /// <summary>
    /// Function: StreamingInstall_IsFinished
    /// </summary>
    public unsafe virtual bool StreamingInstall_IsFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StreamingInstall_IsFinished, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StreamingInstall_IsFinished", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetDurangoKinectState;
    /// <summary>
    /// Function: SetDurangoKinectState
    /// </summary>
    public unsafe virtual void SetDurangoKinectState(bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetDurangoKinectState, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetDurangoKinectState", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGTCStates;
    /// <summary>
    /// Function: SetGTCStates
    /// </summary>
    public unsafe virtual void SetGTCStates(bool bPlayEnabled, bool bPauseEnabled, bool bMenuEnabled, bool bViewEnabled, bool bBackEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGTCStates, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetGTCStates", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPauseEnabled, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMenuEnabled, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bViewEnabled, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBackEnabled, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGTCState;
    /// <summary>
    /// Function: SetGTCState
    /// </summary>
    public unsafe virtual void SetGTCState(BmSDK.Engine.OnlineSubsystem.EGTCCommand Id, bool bState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGTCState, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetGTCState", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearGTCCommandDelegate;
    /// <summary>
    /// Function: ClearGTCCommandDelegate
    /// </summary>
    public unsafe virtual void ClearGTCCommandDelegate(BmSDK.FScriptDelegate GTCCommandDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearGTCCommandDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearGTCCommandDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GTCCommandDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddGTCCommandDelegate;
    /// <summary>
    /// Function: AddGTCCommandDelegate
    /// </summary>
    public unsafe virtual void AddGTCCommandDelegate(BmSDK.FScriptDelegate GTCCommandDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddGTCCommandDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddGTCCommandDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GTCCommandDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnGTCCommand;
    /// <summary>
    /// Function: OnGTCCommand
    /// </summary>
    public unsafe virtual void OnGTCCommand(BmSDK.Engine.OnlineSubsystem.EGTCCommand NewCommand)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnGTCCommand, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnGTCCommand", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NavigateBack;
    /// <summary>
    /// Function: NavigateBack
    /// </summary>
    public unsafe virtual void NavigateBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NavigateBack, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.NavigateBack", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OpenHelpManual;
    /// <summary>
    /// Function: OpenHelpManual
    /// </summary>
    public unsafe virtual void OpenHelpManual(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OpenHelpManual, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OpenHelpManual", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecordStop;
    /// <summary>
    /// Function: VideoRecordStop
    /// </summary>
    public unsafe virtual bool VideoRecordStop(byte LocalUserNum, byte VideoId, BmSDK.FStringArg TitleStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecordStop, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecordStop", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoId, paramsPtr + 1);
        TitleStr.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecordStart;
    /// <summary>
    /// Function: VideoRecordStart
    /// </summary>
    public unsafe virtual bool VideoRecordStart(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecordStart, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecordStart", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecord;
    /// <summary>
    /// Function: VideoRecord
    /// </summary>
    public unsafe virtual void VideoRecord(byte LocalUserNum, byte VideoId, BmSDK.FStringArg TitleStr, float TimeStart, float TimeStop)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecord, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecord", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoId, paramsPtr + 1);
        TitleStr.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeStart, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeStop, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecordSetGameSectionId;
    /// <summary>
    /// Function: VideoRecordSetGameSectionId
    /// </summary>
    public unsafe virtual void VideoRecordSetGameSectionId(int SectionId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecordSetGameSectionId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecordSetGameSectionId", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SectionId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecordAllowed;
    /// <summary>
    /// Function: VideoRecordAllowed
    /// </summary>
    public unsafe virtual void VideoRecordAllowed(bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecordAllowed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecordAllowed", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsVideoRecordAllowed;
    /// <summary>
    /// Function: IsVideoRecordAllowed
    /// </summary>
    public unsafe virtual bool IsVideoRecordAllowed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsVideoRecordAllowed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsVideoRecordAllowed", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnBindAllPlayers;
    /// <summary>
    /// Function: UnBindAllPlayers
    /// </summary>
    public unsafe virtual void UnBindAllPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnBindAllPlayers, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnBindAllPlayers", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnBindPlayer;
    /// <summary>
    /// Function: UnBindPlayer
    /// </summary>
    public unsafe virtual void UnBindPlayer(int ControllerId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnBindPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnBindPlayer", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResumePlayer;
    /// <summary>
    /// Function: ResumePlayer
    /// </summary>
    public unsafe virtual int ResumePlayer(int ControllerId, int ControllerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResumePlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResumePlayer", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReBindPlayer;
    /// <summary>
    /// Function: ReBindPlayer
    /// </summary>
    public unsafe virtual void ReBindPlayer(int ControllerId, int ControllerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReBindPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReBindPlayer", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BindPlayer;
    /// <summary>
    /// Function: BindPlayer
    /// </summary>
    public unsafe virtual int BindPlayer(int ControllerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BindPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.BindPlayer", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBoundCount;
    /// <summary>
    /// Function: GetBoundCount
    /// </summary>
    public unsafe virtual int GetBoundCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBoundCount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetBoundCount", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineAvatar;
    /// <summary>
    /// Function: ReadOnlineAvatar
    /// </summary>
    public unsafe virtual void ReadOnlineAvatar(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, int Size, BmSDK.FScriptDelegate ReadOnlineAvatarCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineAvatar, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineAvatar", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineAvatarCompleteDelegate, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadOnlineAvatarComplete;
    /// <summary>
    /// Function: OnReadOnlineAvatarComplete
    /// </summary>
    public unsafe virtual void OnReadOnlineAvatarComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, BmSDK.Engine.Texture2D Avatar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadOnlineAvatarComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadOnlineAvatarComplete", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Avatar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowCustomMessageUI;
    /// <summary>
    /// Function: ShowCustomMessageUI
    /// </summary>
    public unsafe virtual bool ShowCustomMessageUI(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Recipients, BmSDK.FStringArg MessageTitle, BmSDK.FStringArg NonEditableMessage, BmSDK.FStringArg EditableMessage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowCustomMessageUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowCustomMessageUI", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        MessageTitle.WriteTo(paramsPtr + 20);
        NonEditableMessage.WriteTo(paramsPtr + 36);
        EditableMessage.WriteTo(paramsPtr + 52);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 52);
        Recipients = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearCrossTitleProfileSettings;
    /// <summary>
    /// Function: ClearCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual void ClearCrossTitleProfileSettings(byte LocalUserNum, int TitleId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCrossTitleProfileSettings", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCrossTitleProfileSettings;
    /// <summary>
    /// Function: GetCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineProfileSettings GetCrossTitleProfileSettings(byte LocalUserNum, int TitleId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCrossTitleProfileSettings", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineProfileSettings>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadCrossTitleProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadCrossTitleProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadCrossTitleProfileSettingsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadCrossTitleProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadCrossTitleProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadCrossTitleProfileSettingsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadCrossTitleProfileSettingsComplete;
    /// <summary>
    /// Function: OnReadCrossTitleProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleProfileSettingsComplete(byte LocalUserNum, int TitleId, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadCrossTitleProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadCrossTitleProfileSettingsComplete", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadCrossTitleProfileSettings;
    /// <summary>
    /// Function: ReadCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual bool ReadCrossTitleProfileSettings(byte LocalUserNum, int TitleId, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadCrossTitleProfileSettings", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnlockAvatarAward;
    /// <summary>
    /// Function: UnlockAvatarAward
    /// </summary>
    public unsafe virtual bool UnlockAvatarAward(byte LocalUserNum, int AvatarItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnlockAvatarAward, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockAvatarAward", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarItemId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTimeSinceGuideLastClosed;
    /// <summary>
    /// Function: GetTimeSinceGuideLastClosed
    /// </summary>
    public unsafe virtual float GetTimeSinceGuideLastClosed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTimeSinceGuideLastClosed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTimeSinceGuideLastClosed", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateInfocastSystem;
    /// <summary>
    /// Function: CreateInfocastSystem
    /// </summary>
    public unsafe virtual void CreateInfocastSystem()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateInfocastSystem, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateInfocastSystem", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearNewInfocastDelegate;
    /// <summary>
    /// Function: ClearNewInfocastDelegate
    /// </summary>
    public unsafe virtual void ClearNewInfocastDelegate(BmSDK.FScriptDelegate InfocastDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearNewInfocastDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearNewInfocastDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfocastDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddNewInfocastDelegate;
    /// <summary>
    /// Function: AddNewInfocastDelegate
    /// </summary>
    public unsafe virtual void AddNewInfocastDelegate(BmSDK.FScriptDelegate InfocastDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddNewInfocastDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddNewInfocastDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfocastDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnNewInfocast;
    /// <summary>
    /// Function: OnNewInfocast
    /// </summary>
    public unsafe virtual void OnNewInfocast(BmSDK.FStringArg Infocast)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnNewInfocast, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnNewInfocast", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Infocast.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowCustomPlayersUI;
    /// <summary>
    /// Function: ShowCustomPlayersUI
    /// </summary>
    public unsafe virtual bool ShowCustomPlayersUI(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.FStringArg Title, BmSDK.FStringArg Description)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowCustomPlayersUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowCustomPlayersUI", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        Title.WriteTo(paramsPtr + 20);
        Description.WriteTo(paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowPlayersUI;
    /// <summary>
    /// Function: ShowPlayersUI
    /// </summary>
    public unsafe virtual bool ShowPlayersUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowPlayersUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowPlayersUI", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowGuideUI;
    /// <summary>
    /// Function: ShowGuideUI
    /// </summary>
    public unsafe virtual bool ShowGuideUI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowGuideUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowGuideUI", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowFriendsInviteUI;
    /// <summary>
    /// Function: ShowFriendsInviteUI
    /// </summary>
    public unsafe virtual bool ShowFriendsInviteUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowFriendsInviteUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFriendsInviteUI", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearProfileDataChangedDelegate;
    /// <summary>
    /// Function: ClearProfileDataChangedDelegate
    /// </summary>
    public unsafe virtual void ClearProfileDataChangedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ProfileDataChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearProfileDataChangedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearProfileDataChangedDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileDataChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddProfileDataChangedDelegate;
    /// <summary>
    /// Function: AddProfileDataChangedDelegate
    /// </summary>
    public unsafe virtual void AddProfileDataChangedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ProfileDataChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddProfileDataChangedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddProfileDataChangedDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileDataChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnProfileDataChanged;
    /// <summary>
    /// Function: OnProfileDataChanged
    /// </summary>
    public unsafe virtual void OnProfileDataChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnProfileDataChanged, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnProfileDataChanged", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnlockGamerPicture;
    /// <summary>
    /// Function: UnlockGamerPicture
    /// </summary>
    public unsafe virtual bool UnlockGamerPicture(byte LocalUserNum, int PictureId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnlockGamerPicture, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockGamerPicture", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PictureId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsDeviceValid;
    /// <summary>
    /// Function: IsDeviceValid
    /// </summary>
    public unsafe virtual bool IsDeviceValid(int DeviceID, int SizeNeeded = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsDeviceValid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsDeviceValid", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SizeNeeded, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDeviceSelectionResults;
    /// <summary>
    /// Function: GetDeviceSelectionResults
    /// </summary>
    public unsafe virtual int GetDeviceSelectionResults(byte LocalUserNum, out BmSDK.FString DeviceName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDeviceSelectionResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetDeviceSelectionResults", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DeviceName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDeviceSelectionDoneDelegate;
    /// <summary>
    /// Function: ClearDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe virtual void ClearDeviceSelectionDoneDelegate(byte LocalUserNum, BmSDK.FScriptDelegate DeviceDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDeviceSelectionDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDeviceSelectionDoneDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDeviceSelectionDoneDelegate;
    /// <summary>
    /// Function: AddDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe virtual void AddDeviceSelectionDoneDelegate(byte LocalUserNum, BmSDK.FScriptDelegate DeviceDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDeviceSelectionDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddDeviceSelectionDoneDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnDeviceSelectionComplete;
    /// <summary>
    /// Function: OnDeviceSelectionComplete
    /// </summary>
    public unsafe virtual void OnDeviceSelectionComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnDeviceSelectionComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnDeviceSelectionComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowDeviceSelectionUI;
    /// <summary>
    /// Function: ShowDeviceSelectionUI
    /// </summary>
    public unsafe virtual bool ShowDeviceSelectionUI(byte LocalUserNum, int SizeNeeded, bool bForceShowUI = default, bool bManageStorage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowDeviceSelectionUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowDeviceSelectionUI", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SizeNeeded, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowUI, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bManageStorage, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowMembershipMarketplaceUI;
    /// <summary>
    /// Function: ShowMembershipMarketplaceUI
    /// </summary>
    public unsafe virtual bool ShowMembershipMarketplaceUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowMembershipMarketplaceUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowMembershipMarketplaceUI", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowContentMarketplaceUI;
    /// <summary>
    /// Function: ShowContentMarketplaceUI
    /// </summary>
    public unsafe virtual bool ShowContentMarketplaceUI(byte LocalUserNum, int CategoryMask = default, int OfferId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowContentMarketplaceUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowContentMarketplaceUI", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryMask, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OfferId, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowInviteUI;
    /// <summary>
    /// Function: ShowInviteUI
    /// </summary>
    public unsafe virtual bool ShowInviteUI(byte LocalUserNum, BmSDK.FStringArg InviteText = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowInviteUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowInviteUI", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        InviteText.WriteTo(paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowAchievementsUI;
    /// <summary>
    /// Function: ShowAchievementsUI
    /// </summary>
    public unsafe virtual bool ShowAchievementsUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowAchievementsUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowAchievementsUI", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowMessagesUI;
    /// <summary>
    /// Function: ShowMessagesUI
    /// </summary>
    public unsafe virtual bool ShowMessagesUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowMessagesUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowMessagesUI", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowTokenRedemptionUI;
    /// <summary>
    /// Function: ShowTokenRedemptionUI
    /// </summary>
    public unsafe virtual bool ShowTokenRedemptionUI(byte LocalUserNum, BmSDK.FStringArg OfferId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowTokenRedemptionUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowTokenRedemptionUI", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        OfferId.WriteTo(paramsPtr + 4);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowAccountPickerUI;
    /// <summary>
    /// Function: ShowAccountPickerUI
    /// </summary>
    public unsafe virtual bool ShowAccountPickerUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowAccountPickerUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowAccountPickerUI", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowGamerCardUI;
    /// <summary>
    /// Function: ShowGamerCardUI
    /// </summary>
    public unsafe virtual bool ShowGamerCardUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, BmSDK.FStringArg NickName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowGamerCardUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowGamerCardUI", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        NickName.WriteTo(paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowFeedbackUI;
    /// <summary>
    /// Function: ShowFeedbackUI
    /// </summary>
    public unsafe virtual bool ShowFeedbackUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowFeedbackUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFeedbackUI", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearMsgBoxUIDelegate;
    /// <summary>
    /// Function: ClearMsgBoxUIDelegate
    /// </summary>
    public unsafe virtual void ClearMsgBoxUIDelegate(BmSDK.FScriptDelegate MsgDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearMsgBoxUIDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearMsgBoxUIDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MsgDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddMsgBoxUIDoneDelegate;
    /// <summary>
    /// Function: AddMsgBoxUIDoneDelegate
    /// </summary>
    public unsafe virtual void AddMsgBoxUIDoneDelegate(BmSDK.FScriptDelegate MsgDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddMsgBoxUIDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddMsgBoxUIDoneDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MsgDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnMsgBoxUIComplete;
    /// <summary>
    /// Function: OnMsgBoxUIComplete
    /// </summary>
    public unsafe virtual void OnMsgBoxUIComplete(int ButtonResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnMsgBoxUIComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnMsgBoxUIComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonResult, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowSystemMsgBoxUI;
    /// <summary>
    /// Function: ShowSystemMsgBoxUI
    /// </summary>
    public unsafe virtual bool ShowSystemMsgBoxUI(byte LocalUserNum, int SysMsg)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowSystemMsgBoxUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowSystemMsgBoxUI", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SysMsg, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_WriteUserFileInternal;
    /// <summary>
    /// Function: WriteUserFileInternal
    /// </summary>
    public unsafe bool WriteUserFileInternal(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteUserFileInternal, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteUserFileInternal");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerNicknameFromIndex;
    /// <summary>
    /// Function: GetPlayerNicknameFromIndex
    /// </summary>
    public unsafe override BmSDK.FString GetPlayerNicknameFromIndex(int UserIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerNicknameFromIndex, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerNicknameFromIndex", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAchievements;
    /// <summary>
    /// Function: GetAchievements
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetAchievements(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails> Achievements, int TitleId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAchievements, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetAchievements", this);
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Achievements = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadAchievementsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadAchievementsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadAchievementsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadAchievementsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadAchievementsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadAchievementsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadAchievementsCompleteDelegate;
    /// <summary>
    /// Function: AddReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadAchievementsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadAchievementsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadAchievementsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadAchievementsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadAchievementsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadAchievementsComplete;
    /// <summary>
    /// Function: OnReadAchievementsComplete
    /// </summary>
    public unsafe virtual void OnReadAchievementsComplete(int TitleId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadAchievementsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadAchievementsComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadAchievements;
    /// <summary>
    /// Function: ReadAchievements
    /// </summary>
    public unsafe virtual bool ReadAchievements(byte LocalUserNum, int TitleId = default, bool bShouldReadText = default, bool bShouldReadImages = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadAchievements, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadAchievements", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldReadText, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldReadImages, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearUnlockAchievementCompleteDelegate;
    /// <summary>
    /// Function: ClearUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearUnlockAchievementCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate UnlockAchievementCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearUnlockAchievementCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearUnlockAchievementCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockAchievementCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddUnlockAchievementCompleteDelegate;
    /// <summary>
    /// Function: AddUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe virtual void AddUnlockAchievementCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate UnlockAchievementCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddUnlockAchievementCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddUnlockAchievementCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockAchievementCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnUnlockAchievementComplete;
    /// <summary>
    /// Function: OnUnlockAchievementComplete
    /// </summary>
    public unsafe virtual void OnUnlockAchievementComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnUnlockAchievementComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnUnlockAchievementComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnlockAchievement;
    /// <summary>
    /// Function: UnlockAchievement
    /// </summary>
    public unsafe virtual bool UnlockAchievement(byte LocalUserNum, int AchievementId, float PercentComplete = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnlockAchievement, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockAchievement", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AchievementId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PercentComplete, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisplayAchievementProgress;
    /// <summary>
    /// Function: DisplayAchievementProgress
    /// </summary>
    public unsafe virtual bool DisplayAchievementProgress(int AchievementId, int ProgressCount, int MaxProgress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisplayAchievementProgress, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DisplayAchievementProgress", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AchievementId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProgressCount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxProgress, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteMessage;
    /// <summary>
    /// Function: DeleteMessage
    /// </summary>
    public unsafe virtual bool DeleteMessage(byte LocalUserNum, int MessageIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteMessage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteMessage", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFriendMessageReceivedDelegate;
    /// <summary>
    /// Function: ClearFriendMessageReceivedDelegate
    /// </summary>
    public unsafe virtual void ClearFriendMessageReceivedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate MessageDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFriendMessageReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendMessageReceivedDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddFriendMessageReceivedDelegate;
    /// <summary>
    /// Function: AddFriendMessageReceivedDelegate
    /// </summary>
    public unsafe virtual void AddFriendMessageReceivedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate MessageDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddFriendMessageReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendMessageReceivedDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFriendMessageReceived;
    /// <summary>
    /// Function: OnFriendMessageReceived
    /// </summary>
    public unsafe virtual void OnFriendMessageReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId SendingPlayer, BmSDK.FStringArg SendingNick, BmSDK.FStringArg Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFriendMessageReceived, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendMessageReceived", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SendingPlayer, paramsPtr + 4);
        SendingNick.WriteTo(paramsPtr + 12);
        Message.WriteTo(paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFriendMessages;
    /// <summary>
    /// Function: GetFriendMessages
    /// </summary>
    public unsafe virtual void GetFriendMessages(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage> FriendMessages)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFriendMessages, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendMessages", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FriendMessages = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearJoinFriendGameCompleteDelegate;
    /// <summary>
    /// Function: ClearJoinFriendGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearJoinFriendGameCompleteDelegate(BmSDK.FScriptDelegate JoinFriendGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearJoinFriendGameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearJoinFriendGameCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinFriendGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddJoinFriendGameCompleteDelegate;
    /// <summary>
    /// Function: AddJoinFriendGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddJoinFriendGameCompleteDelegate(BmSDK.FScriptDelegate JoinFriendGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddJoinFriendGameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddJoinFriendGameCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinFriendGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnJoinFriendGameComplete;
    /// <summary>
    /// Function: OnJoinFriendGameComplete
    /// </summary>
    public unsafe virtual void OnJoinFriendGameComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnJoinFriendGameComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnJoinFriendGameComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_JoinFriendGame;
    /// <summary>
    /// Function: JoinFriendGame
    /// </summary>
    public unsafe virtual bool JoinFriendGame(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_JoinFriendGame, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.JoinFriendGame", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReceivedGameInviteDelegate;
    /// <summary>
    /// Function: ClearReceivedGameInviteDelegate
    /// </summary>
    public unsafe virtual void ClearReceivedGameInviteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReceivedGameInviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReceivedGameInviteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReceivedGameInviteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReceivedGameInviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReceivedGameInviteDelegate;
    /// <summary>
    /// Function: AddReceivedGameInviteDelegate
    /// </summary>
    public unsafe virtual void AddReceivedGameInviteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReceivedGameInviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReceivedGameInviteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReceivedGameInviteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReceivedGameInviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReceivedGameInvite;
    /// <summary>
    /// Function: OnReceivedGameInvite
    /// </summary>
    public unsafe virtual void OnReceivedGameInvite(byte LocalUserNum, BmSDK.FStringArg InviterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReceivedGameInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReceivedGameInvite", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        InviterName.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendGameInviteToFriends;
    /// <summary>
    /// Function: SendGameInviteToFriends
    /// </summary>
    public unsafe virtual bool SendGameInviteToFriends(byte LocalUserNum, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Friends, BmSDK.FStringArg Text = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendGameInviteToFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendGameInviteToFriends", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friends, paramsPtr + 4);
        Text.WriteTo(paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendGameInviteToFriend;
    /// <summary>
    /// Function: SendGameInviteToFriend
    /// </summary>
    public unsafe virtual bool SendGameInviteToFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend, BmSDK.FStringArg Text = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendGameInviteToFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendGameInviteToFriend", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
        Text.WriteTo(paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendMessageToFriend;
    /// <summary>
    /// Function: SendMessageToFriend
    /// </summary>
    public unsafe virtual bool SendMessageToFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend, BmSDK.FStringArg Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendMessageToFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendMessageToFriend", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
        Message.WriteTo(paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFriendInviteReceivedDelegate;
    /// <summary>
    /// Function: ClearFriendInviteReceivedDelegate
    /// </summary>
    public unsafe virtual void ClearFriendInviteReceivedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate InviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFriendInviteReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendInviteReceivedDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddFriendInviteReceivedDelegate;
    /// <summary>
    /// Function: AddFriendInviteReceivedDelegate
    /// </summary>
    public unsafe virtual void AddFriendInviteReceivedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate InviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddFriendInviteReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendInviteReceivedDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFriendInviteReceived;
    /// <summary>
    /// Function: OnFriendInviteReceived
    /// </summary>
    public unsafe virtual void OnFriendInviteReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer, BmSDK.FStringArg RequestingNick, BmSDK.FStringArg Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFriendInviteReceived, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendInviteReceived", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
        RequestingNick.WriteTo(paramsPtr + 12);
        Message.WriteTo(paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RemoveFriend;
    /// <summary>
    /// Function: RemoveFriend
    /// </summary>
    public unsafe virtual bool RemoveFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId FormerFriend)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RemoveFriend", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormerFriend, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DenyFriendInvite;
    /// <summary>
    /// Function: DenyFriendInvite
    /// </summary>
    public unsafe virtual bool DenyFriendInvite(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DenyFriendInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DenyFriendInvite", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AcceptFriendInvite;
    /// <summary>
    /// Function: AcceptFriendInvite
    /// </summary>
    public unsafe virtual bool AcceptFriendInvite(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AcceptFriendInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AcceptFriendInvite", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearAddFriendByNameCompleteDelegate;
    /// <summary>
    /// Function: ClearAddFriendByNameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearAddFriendByNameCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate FriendDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearAddFriendByNameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearAddFriendByNameCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddAddFriendByNameCompleteDelegate;
    /// <summary>
    /// Function: AddAddFriendByNameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddAddFriendByNameCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate FriendDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddAddFriendByNameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddAddFriendByNameCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnAddFriendByNameComplete;
    /// <summary>
    /// Function: OnAddFriendByNameComplete
    /// </summary>
    public unsafe virtual void OnAddFriendByNameComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnAddFriendByNameComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnAddFriendByNameComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddFriendByName;
    /// <summary>
    /// Function: AddFriendByName
    /// </summary>
    public unsafe virtual bool AddFriendByName(byte LocalUserNum, BmSDK.FStringArg FriendName, BmSDK.FStringArg Message = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddFriendByName, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendByName", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        FriendName.WriteTo(paramsPtr + 4);
        Message.WriteTo(paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddFriend;
    /// <summary>
    /// Function: AddFriend
    /// </summary>
    public unsafe virtual bool AddFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewFriend, BmSDK.FStringArg Message = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriend", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFriend, paramsPtr + 4);
        Message.WriteTo(paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetKeyboardInputResults;
    /// <summary>
    /// Function: GetKeyboardInputResults
    /// </summary>
    public unsafe virtual BmSDK.FString GetKeyboardInputResults(out byte bWasCanceled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetKeyboardInputResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetKeyboardInputResults", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bWasCanceled);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasCanceled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bWasCanceled = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearKeyboardInputDoneDelegate;
    /// <summary>
    /// Function: ClearKeyboardInputDoneDelegate
    /// </summary>
    public unsafe virtual void ClearKeyboardInputDoneDelegate(BmSDK.FScriptDelegate InputDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearKeyboardInputDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearKeyboardInputDoneDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddKeyboardInputDoneDelegate;
    /// <summary>
    /// Function: AddKeyboardInputDoneDelegate
    /// </summary>
    public unsafe virtual void AddKeyboardInputDoneDelegate(BmSDK.FScriptDelegate InputDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddKeyboardInputDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddKeyboardInputDoneDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnKeyboardInputComplete;
    /// <summary>
    /// Function: OnKeyboardInputComplete
    /// </summary>
    public unsafe virtual void OnKeyboardInputComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnKeyboardInputComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnKeyboardInputComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowKeyboardUI;
    /// <summary>
    /// Function: ShowKeyboardUI
    /// </summary>
    public unsafe virtual bool ShowKeyboardUI(byte LocalUserNum, BmSDK.FStringArg TitleText, BmSDK.FStringArg DescriptionText, bool bIsPassword = default, bool bShouldValidate = default, BmSDK.FStringArg DefaultText = default, int MaxResultLength = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowKeyboardUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowKeyboardUI", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        TitleText.WriteTo(paramsPtr + 4);
        DescriptionText.WriteTo(paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPassword, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldValidate, paramsPtr + 40);
        DefaultText.WriteTo(paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxResultLength, paramsPtr + 60);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetOnlineStatus;
    /// <summary>
    /// Function: SetOnlineStatus
    /// </summary>
    public unsafe virtual void SetOnlineStatus(byte LocalUserNum, int StatusId, out BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting> LocalizedStringSettings, out BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty> Properties)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetOnlineStatus, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetOnlineStatus", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatusId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LocalizedStringSettings = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting>>(paramsPtr + 8);
        Properties = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty>>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFriendsList;
    /// <summary>
    /// Function: GetFriendsList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetFriendsList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> Friends, int Count = default, int StartingAt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFriendsList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendsList", this);
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingAt, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Friends = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadFriendsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadFriendsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadFriendsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadFriendsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadFriendsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadFriendsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadFriendsCompleteDelegate;
    /// <summary>
    /// Function: AddReadFriendsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadFriendsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadFriendsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadFriendsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadFriendsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadFriendsComplete;
    /// <summary>
    /// Function: OnReadFriendsComplete
    /// </summary>
    public unsafe virtual void OnReadFriendsComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadFriendsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadFriendsComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadFriendsList;
    /// <summary>
    /// Function: ReadFriendsList
    /// </summary>
    public unsafe virtual bool ReadFriendsList(byte LocalUserNum, int Count = default, int StartingAt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadFriendsList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadFriendsList", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingAt, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWritePlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: ClearWritePlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWritePlayerStorageCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate WritePlayerStorageCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWritePlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWritePlayerStorageCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WritePlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWritePlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: AddWritePlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWritePlayerStorageCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate WritePlayerStorageCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWritePlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWritePlayerStorageCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WritePlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWritePlayerStorageComplete;
    /// <summary>
    /// Function: OnWritePlayerStorageComplete
    /// </summary>
    public unsafe virtual void OnWritePlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWritePlayerStorageComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWritePlayerStorageComplete", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WritePlayerStorage;
    /// <summary>
    /// Function: WritePlayerStorage
    /// </summary>
    public unsafe virtual bool WritePlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WritePlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WritePlayerStorage", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerStorage;
    /// <summary>
    /// Function: GetPlayerStorage
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlinePlayerStorage GetPlayerStorage(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerStorage", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlinePlayerStorage>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadPlayerStorageForNetIdCompleteDelegate;
    /// <summary>
    /// Function: ClearReadPlayerStorageForNetIdCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadPlayerStorageForNetIdCompleteDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, BmSDK.FScriptDelegate ReadPlayerStorageForNetIdCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadPlayerStorageForNetIdCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadPlayerStorageForNetIdCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageForNetIdCompleteDelegate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadPlayerStorageForNetIdCompleteDelegate;
    /// <summary>
    /// Function: AddReadPlayerStorageForNetIdCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadPlayerStorageForNetIdCompleteDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, BmSDK.FScriptDelegate ReadPlayerStorageForNetIdCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadPlayerStorageForNetIdCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadPlayerStorageForNetIdCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageForNetIdCompleteDelegate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadPlayerStorageForNetIdComplete;
    /// <summary>
    /// Function: OnReadPlayerStorageForNetIdComplete
    /// </summary>
    public unsafe virtual void OnReadPlayerStorageForNetIdComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadPlayerStorageForNetIdComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadPlayerStorageForNetIdComplete", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadPlayerStorageForNetId;
    /// <summary>
    /// Function: ReadPlayerStorageForNetId
    /// </summary>
    public unsafe virtual bool ReadPlayerStorageForNetId(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadPlayerStorageForNetId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadPlayerStorageForNetId", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadPlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: ClearReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadPlayerStorageCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadPlayerStorageCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadPlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadPlayerStorageCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadPlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: AddReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadPlayerStorageCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadPlayerStorageCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadPlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadPlayerStorageCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadPlayerStorageComplete;
    /// <summary>
    /// Function: OnReadPlayerStorageComplete
    /// </summary>
    public unsafe virtual void OnReadPlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadPlayerStorageComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadPlayerStorageComplete", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadPlayerStorage;
    /// <summary>
    /// Function: ReadPlayerStorage
    /// </summary>
    public unsafe virtual bool ReadPlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadPlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadPlayerStorage", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFriendJoinURL;
    /// <summary>
    /// Function: GetFriendJoinURL
    /// </summary>
    public unsafe virtual bool GetFriendJoinURL(BmSDK.Engine.OnlineSubsystem.FUniqueNetId FriendUID, out BmSDK.FString ServerURL, out BmSDK.FString ServerUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFriendJoinURL, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendJoinURL", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendUID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ServerURL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        ServerUID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCommandlineJoinURL;
    /// <summary>
    /// Function: GetCommandlineJoinURL
    /// </summary>
    public unsafe virtual bool GetCommandlineJoinURL(bool bMarkAsJoined, out BmSDK.FString ServerURL, out BmSDK.FString ServerUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCommandlineJoinURL, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCommandlineJoinURL", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMarkAsJoined, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ServerURL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        ServerUID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Int64ToUniqueNetId;
    /// <summary>
    /// Function: Int64ToUniqueNetId
    /// </summary>
    public unsafe virtual bool Int64ToUniqueNetId(BmSDK.FStringArg UIDString, out BmSDK.Engine.OnlineSubsystem.FUniqueNetId OutUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Int64ToUniqueNetId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Int64ToUniqueNetId", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UIDString.WriteTo(paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutUID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutUID, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        OutUID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UniqueNetIdToInt64;
    /// <summary>
    /// Function: UniqueNetIdToInt64
    /// </summary>
    public unsafe virtual BmSDK.FString UniqueNetIdToInt64(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId Uid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UniqueNetIdToInt64, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UniqueNetIdToInt64", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Uid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Uid = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowProfileUI;
    /// <summary>
    /// Function: ShowProfileUI
    /// </summary>
    public unsafe virtual bool ShowProfileUI(byte LocalUserNum, BmSDK.FStringArg SubURL = default, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerUID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowProfileUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowProfileUI", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        SubURL.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerUID, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UniqueNetIdToPlayerName;
    /// <summary>
    /// Function: UniqueNetIdToPlayerName
    /// </summary>
    public unsafe virtual BmSDK.FString UniqueNetIdToPlayerName(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId Uid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UniqueNetIdToPlayerName, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UniqueNetIdToPlayerName", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Uid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Uid = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSteamClanData;
    /// <summary>
    /// Function: GetSteamClanData
    /// </summary>
    public unsafe virtual void GetSteamClanData(out BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamPlayerClanData> Results)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSteamClanData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSteamClanData", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Results = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamPlayerClanData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearGetNumberOfCurrentPlayersCompleteDelegate;
    /// <summary>
    /// Function: ClearGetNumberOfCurrentPlayersCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearGetNumberOfCurrentPlayersCompleteDelegate(BmSDK.FScriptDelegate GetNumberOfCurrentPlayersCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearGetNumberOfCurrentPlayersCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearGetNumberOfCurrentPlayersCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetNumberOfCurrentPlayersCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddGetNumberOfCurrentPlayersCompleteDelegate;
    /// <summary>
    /// Function: AddGetNumberOfCurrentPlayersCompleteDelegate
    /// </summary>
    public unsafe virtual void AddGetNumberOfCurrentPlayersCompleteDelegate(BmSDK.FScriptDelegate GetNumberOfCurrentPlayersCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddGetNumberOfCurrentPlayersCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddGetNumberOfCurrentPlayersCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetNumberOfCurrentPlayersCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnGetNumberOfCurrentPlayersComplete;
    /// <summary>
    /// Function: OnGetNumberOfCurrentPlayersComplete
    /// </summary>
    public unsafe virtual void OnGetNumberOfCurrentPlayersComplete(int TotalPlayers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnGetNumberOfCurrentPlayersComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnGetNumberOfCurrentPlayersComplete", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalPlayers, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNumberOfCurrentPlayers;
    /// <summary>
    /// Function: GetNumberOfCurrentPlayers
    /// </summary>
    public unsafe virtual bool GetNumberOfCurrentPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNumberOfCurrentPlayers, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNumberOfCurrentPlayers", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteProfileSettingsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate WriteProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteProfileSettingsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddWriteProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteProfileSettingsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate WriteProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteProfileSettingsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteProfileSettingsComplete;
    /// <summary>
    /// Function: OnWriteProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnWriteProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteProfileSettingsComplete", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteProfileSettings;
    /// <summary>
    /// Function: WriteProfileSettings
    /// </summary>
    public unsafe virtual bool WriteProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteProfileSettings", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetProfileSettings;
    /// <summary>
    /// Function: GetProfileSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineProfileSettings GetProfileSettings(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetProfileSettings", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineProfileSettings>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadProfileSettingsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadProfileSettingsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadProfileSettingsCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadProfileSettingsCompleteDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadProfileSettingsComplete;
    /// <summary>
    /// Function: OnReadProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnReadProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadProfileSettingsComplete", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadProfileSettings;
    /// <summary>
    /// Function: ReadProfileSettings
    /// </summary>
    public unsafe virtual bool ReadProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadProfileSettings", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFriendsChangeDelegate;
    /// <summary>
    /// Function: ClearFriendsChangeDelegate
    /// </summary>
    public unsafe virtual void ClearFriendsChangeDelegate(byte LocalUserNum, BmSDK.FScriptDelegate FriendsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFriendsChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendsChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddFriendsChangeDelegate;
    /// <summary>
    /// Function: AddFriendsChangeDelegate
    /// </summary>
    public unsafe virtual void AddFriendsChangeDelegate(byte LocalUserNum, BmSDK.FScriptDelegate FriendsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddFriendsChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendsChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearMutingChangeDelegate;
    /// <summary>
    /// Function: ClearMutingChangeDelegate
    /// </summary>
    public unsafe virtual void ClearMutingChangeDelegate(BmSDK.FScriptDelegate MutingDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearMutingChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearMutingChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutingDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddMutingChangeDelegate;
    /// <summary>
    /// Function: AddMutingChangeDelegate
    /// </summary>
    public unsafe virtual void AddMutingChangeDelegate(BmSDK.FScriptDelegate MutingDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddMutingChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddMutingChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutingDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearLoginCancelledDelegate;
    /// <summary>
    /// Function: ClearLoginCancelledDelegate
    /// </summary>
    public unsafe virtual void ClearLoginCancelledDelegate(BmSDK.FScriptDelegate CancelledDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearLoginCancelledDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginCancelledDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancelledDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddLoginCancelledDelegate;
    /// <summary>
    /// Function: AddLoginCancelledDelegate
    /// </summary>
    public unsafe virtual void AddLoginCancelledDelegate(BmSDK.FScriptDelegate CancelledDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddLoginCancelledDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginCancelledDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancelledDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearLoginStatusChangeDelegate;
    /// <summary>
    /// Function: ClearLoginStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLoginStatusChangeDelegate(BmSDK.FScriptDelegate LoginStatusDelegate, byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearLoginStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginStatusChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddLoginStatusChangeDelegate;
    /// <summary>
    /// Function: AddLoginStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddLoginStatusChangeDelegate(BmSDK.FScriptDelegate LoginStatusDelegate, byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddLoginStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginStatusChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnLoginStatusChange;
    /// <summary>
    /// Function: OnLoginStatusChange
    /// </summary>
    public unsafe virtual void OnLoginStatusChange(BmSDK.Engine.OnlineSubsystem.ELoginStatus NewStatus, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnLoginStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginStatusChange", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStatus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearLoginChangeDelegate;
    /// <summary>
    /// Function: ClearLoginChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLoginChangeDelegate(BmSDK.FScriptDelegate LoginDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearLoginChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddLoginChangeDelegate;
    /// <summary>
    /// Function: AddLoginChangeDelegate
    /// </summary>
    public unsafe virtual void AddLoginChangeDelegate(BmSDK.FScriptDelegate LoginDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddLoginChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowFriendsUI;
    /// <summary>
    /// Function: ShowFriendsUI
    /// </summary>
    public unsafe virtual bool ShowFriendsUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowFriendsUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFriendsUI", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsMuted;
    /// <summary>
    /// Function: IsMuted
    /// </summary>
    public unsafe virtual bool IsMuted(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsMuted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsMuted", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AreAnyFriends;
    /// <summary>
    /// Function: AreAnyFriends
    /// </summary>
    public unsafe virtual bool AreAnyFriends(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FFriendsQuery> Query)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AreAnyFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AreAnyFriends", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Query = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FFriendsQuery>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsFriend;
    /// <summary>
    /// Function: IsFriend
    /// </summary>
    public unsafe virtual bool IsFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsFriend", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanShowPresenceInformation;
    /// <summary>
    /// Function: CanShowPresenceInformation
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanShowPresenceInformation(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanShowPresenceInformation, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanShowPresenceInformation", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanViewPlayerProfiles;
    /// <summary>
    /// Function: CanViewPlayerProfiles
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanViewPlayerProfiles(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanViewPlayerProfiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanViewPlayerProfiles", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPurchaseContent;
    /// <summary>
    /// Function: CanPurchaseContent
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPurchaseContent(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPurchaseContent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanPurchaseContent", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanDownloadUserContent;
    /// <summary>
    /// Function: CanDownloadUserContent
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanDownloadUserContent(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanDownloadUserContent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanDownloadUserContent", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanCommunicate;
    /// <summary>
    /// Function: CanCommunicate
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanCommunicate(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanCommunicate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanCommunicate", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPlayOnline;
    /// <summary>
    /// Function: CanPlayOnline
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPlayOnline(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPlayOnline, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanPlayOnline", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsOnlineAccount;
    /// <summary>
    /// Function: IsOnlineAccount
    /// </summary>
    public unsafe virtual bool IsOnlineAccount(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsOnlineAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsOnlineAccount", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsLocalLogin;
    /// <summary>
    /// Function: IsLocalLogin
    /// </summary>
    public unsafe virtual bool IsLocalLogin(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsLocalLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsLocalLogin", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsGuestLogin;
    /// <summary>
    /// Function: IsGuestLogin
    /// </summary>
    public unsafe virtual bool IsGuestLogin(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsGuestLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsGuestLogin", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerDisplayName;
    /// <summary>
    /// Function: GetPlayerDisplayName
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerDisplayName(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerDisplayName, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerDisplayName", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerNickname;
    /// <summary>
    /// Function: GetPlayerNickname
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerNickname(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerNickname, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerNickname", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUniquePlayerId;
    /// <summary>
    /// Function: GetUniquePlayerId
    /// </summary>
    public unsafe virtual bool GetUniquePlayerId(byte LocalUserNum, out BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUniquePlayerId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUniquePlayerId", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayerID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLoginStatus;
    /// <summary>
    /// Function: GetLoginStatus
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ELoginStatus GetLoginStatus(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLoginStatus, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLoginStatus", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.ELoginStatus>(paramsPtr + 1);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearLogoutCompletedDelegate;
    /// <summary>
    /// Function: ClearLogoutCompletedDelegate
    /// </summary>
    public unsafe virtual void ClearLogoutCompletedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate LogoutDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearLogoutCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLogoutCompletedDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogoutDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddLogoutCompletedDelegate;
    /// <summary>
    /// Function: AddLogoutCompletedDelegate
    /// </summary>
    public unsafe virtual void AddLogoutCompletedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate LogoutDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddLogoutCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLogoutCompletedDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogoutDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnLogoutCompleted;
    /// <summary>
    /// Function: OnLogoutCompleted
    /// </summary>
    public unsafe virtual void OnLogoutCompleted(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnLogoutCompleted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLogoutCompleted", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Logout;
    /// <summary>
    /// Function: Logout
    /// </summary>
    public unsafe virtual bool Logout(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Logout, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Logout", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearLoginFailedDelegate;
    /// <summary>
    /// Function: ClearLoginFailedDelegate
    /// </summary>
    public unsafe virtual void ClearLoginFailedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate LoginFailedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearLoginFailedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginFailedDelegate", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginFailedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddLoginFailedDelegate;
    /// <summary>
    /// Function: AddLoginFailedDelegate
    /// </summary>
    public unsafe virtual void AddLoginFailedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate LoginFailedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddLoginFailedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginFailedDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginFailedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnLoginFailed;
    /// <summary>
    /// Function: OnLoginFailed
    /// </summary>
    public unsafe virtual void OnLoginFailed(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ErrorCode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnLoginFailed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginFailed", this);
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorCode, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AutoLogin;
    /// <summary>
    /// Function: AutoLogin
    /// </summary>
    public unsafe virtual bool AutoLogin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AutoLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AutoLogin", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Login;
    /// <summary>
    /// Function: Login
    /// </summary>
    public unsafe virtual bool Login(byte LocalUserNum, BmSDK.FStringArg LoginName, BmSDK.FStringArg Password, bool bWantsLocalOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Login, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Login", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        LoginName.WriteTo(paramsPtr + 4);
        Password.WriteTo(paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantsLocalOnly, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowLoginUI;
    /// <summary>
    /// Function: ShowLoginUI
    /// </summary>
    public unsafe virtual bool ShowLoginUI(bool bShowOnlineOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowLoginUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowLoginUI", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowOnlineOnly, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFriendsChange;
    /// <summary>
    /// Function: OnFriendsChange
    /// </summary>
    public unsafe virtual void OnFriendsChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFriendsChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendsChange", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnMutingChange;
    /// <summary>
    /// Function: OnMutingChange
    /// </summary>
    public unsafe virtual void OnMutingChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnMutingChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnMutingChange", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnLoginCancelled;
    /// <summary>
    /// Function: OnLoginCancelled
    /// </summary>
    public unsafe virtual void OnLoginCancelled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnLoginCancelled, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginCancelled", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnLoginChange;
    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe virtual void OnLoginChange(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnLoginChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginChange", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLocale;
    /// <summary>
    /// Function: GetLocale
    /// </summary>
    public unsafe virtual int GetLocale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLocale, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLocale", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearStorageDeviceChangeDelegate;
    /// <summary>
    /// Function: ClearStorageDeviceChangeDelegate
    /// </summary>
    public unsafe virtual void ClearStorageDeviceChangeDelegate(BmSDK.FScriptDelegate StorageDeviceChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearStorageDeviceChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearStorageDeviceChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageDeviceChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddStorageDeviceChangeDelegate;
    /// <summary>
    /// Function: AddStorageDeviceChangeDelegate
    /// </summary>
    public unsafe virtual void AddStorageDeviceChangeDelegate(BmSDK.FScriptDelegate StorageDeviceChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddStorageDeviceChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddStorageDeviceChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageDeviceChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnStorageDeviceChange;
    /// <summary>
    /// Function: OnStorageDeviceChange
    /// </summary>
    public unsafe virtual void OnStorageDeviceChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnStorageDeviceChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnStorageDeviceChange", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNATType;
    /// <summary>
    /// Function: GetNATType
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ENATType GetNATType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNATType, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNATType", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.ENATType>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearConnectionStatusChangeDelegate;
    /// <summary>
    /// Function: ClearConnectionStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearConnectionStatusChangeDelegate(BmSDK.FScriptDelegate ConnectionStatusDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearConnectionStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearConnectionStatusChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddConnectionStatusChangeDelegate;
    /// <summary>
    /// Function: AddConnectionStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddConnectionStatusChangeDelegate(BmSDK.FScriptDelegate ConnectionStatusDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddConnectionStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddConnectionStatusChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnConnectionStatusChange;
    /// <summary>
    /// Function: OnConnectionStatusChange
    /// </summary>
    public unsafe virtual void OnConnectionStatusChange(BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ConnectionStatus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnConnectionStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnConnectionStatusChange", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsControllerConnected;
    /// <summary>
    /// Function: IsControllerConnected
    /// </summary>
    public unsafe virtual bool IsControllerConnected(int ControllerId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsControllerConnected, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsControllerConnected", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearControllerChangeDelegate;
    /// <summary>
    /// Function: ClearControllerChangeDelegate
    /// </summary>
    public unsafe virtual void ClearControllerChangeDelegate(BmSDK.FScriptDelegate ControllerChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearControllerChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearControllerChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddControllerChangeDelegate;
    /// <summary>
    /// Function: AddControllerChangeDelegate
    /// </summary>
    public unsafe virtual void AddControllerChangeDelegate(BmSDK.FScriptDelegate ControllerChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddControllerChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddControllerChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnControllerChange;
    /// <summary>
    /// Function: OnControllerChange
    /// </summary>
    public unsafe virtual void OnControllerChange(int ControllerId, bool bIsConnected)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnControllerChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnControllerChange", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsConnected, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetNetworkNotificationPosition;
    /// <summary>
    /// Function: SetNetworkNotificationPosition
    /// </summary>
    public unsafe virtual void SetNetworkNotificationPosition(BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition NewPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetNetworkNotificationPosition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetNetworkNotificationPosition", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNetworkNotificationPosition;
    /// <summary>
    /// Function: GetNetworkNotificationPosition
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition GetNetworkNotificationPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNetworkNotificationPosition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNetworkNotificationPosition", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearExternalUIChangeDelegate;
    /// <summary>
    /// Function: ClearExternalUIChangeDelegate
    /// </summary>
    public unsafe virtual void ClearExternalUIChangeDelegate(BmSDK.FScriptDelegate ExternalUIDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearExternalUIChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearExternalUIChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExternalUIDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddExternalUIChangeDelegate;
    /// <summary>
    /// Function: AddExternalUIChangeDelegate
    /// </summary>
    public unsafe virtual void AddExternalUIChangeDelegate(BmSDK.FScriptDelegate ExternalUIDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddExternalUIChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddExternalUIChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExternalUIDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnExternalUIChange;
    /// <summary>
    /// Function: OnExternalUIChange
    /// </summary>
    public unsafe virtual void OnExternalUIChange(bool bIsOpening)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnExternalUIChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnExternalUIChange", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsOpening, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearLinkStatusChangeDelegate;
    /// <summary>
    /// Function: ClearLinkStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLinkStatusChangeDelegate(BmSDK.FScriptDelegate LinkStatusDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearLinkStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLinkStatusChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddLinkStatusChangeDelegate;
    /// <summary>
    /// Function: AddLinkStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddLinkStatusChangeDelegate(BmSDK.FScriptDelegate LinkStatusDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddLinkStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLinkStatusChangeDelegate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnLinkStatusChange;
    /// <summary>
    /// Function: OnLinkStatusChange
    /// </summary>
    public unsafe virtual void OnLinkStatusChange(bool bIsConnected)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnLinkStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLinkStatusChange", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsConnected, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasLinkConnection;
    /// <summary>
    /// Function: HasLinkConnection
    /// </summary>
    public unsafe virtual bool HasLinkConnection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasLinkConnection, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.HasLinkConnection", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FSteamUserCloudMetadata
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSteamUserCloudMetadata
    {
        /// <summary>
        /// StrProperty: UserId
        /// </summary>
        public unsafe BmSDK.FString UserId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UserCloudMetadata
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserCloudMetadata
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSteamUserCloud
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSteamUserCloud
    {
        /// <summary>
        /// StrProperty: UserId
        /// </summary>
        public unsafe BmSDK.FString UserId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UserCloudFileData
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile> UserCloudFileData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FLocalTalkerSteam
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FLocalTalkerSteam
    {
        /// <summary>
        /// BoolProperty: bHasVoice
        /// </summary>
        public unsafe bool bHasVoice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bHasNetworkedVoice
        /// </summary>
        public unsafe bool bHasNetworkedVoice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsRecognizingSpeech
        /// </summary>
        public unsafe bool bIsRecognizingSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bWasTalking
        /// </summary>
        public unsafe bool bWasTalking
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsTalking
        /// </summary>
        public unsafe bool bIsTalking
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsRegistered
        /// </summary>
        public unsafe bool bIsRegistered
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: MuteType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.EMuteType MuteType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.EMuteType>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EMuteType
    /// </summary>
    public enum EMuteType : byte
    {
        MUTE_None = 0,
        MUTE_AllButFriends = 1,
        MUTE_All = 2,
        MUTE_MAX = 3,
    }

    /// <summary>
    /// Struct: FContentListCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public partial record struct FContentListCache
    {
        /// <summary>
        /// ArrayProperty: Content
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> Content
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: ReadState
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState ReadState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: ContentChangeDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ContentChangeDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: ReadCompleteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReadCompleteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ArrayProperty: ContentStatusChangeDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ContentStatusChangeDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ArrayProperty: ReadInGameStoreContentCompleteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReadInGameStoreContentCompleteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// ArrayProperty: PurchaseInGameStoreContentCompleteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> PurchaseInGameStoreContentCompleteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// IntProperty: NewDownloadCount
        /// </summary>
        public unsafe int NewDownloadCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// IntProperty: TotalDownloadCount
        /// </summary>
        public unsafe int TotalDownloadCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FLeaderboardEntry
    {
        /// <summary>
        /// StructProperty: PlayerUID
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Rank
        /// </summary>
        public unsafe int Rank
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: LeaderboardData
        /// </summary>
        public unsafe BmSDK.TArray<int> LeaderboardData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FDeferredLeaderboardWrite
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FDeferredLeaderboardWrite
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: LeaderboardData
        /// </summary>
        public unsafe BmSDK.TArray<int> LeaderboardData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FDeferredLeaderboardRead
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FDeferredLeaderboardRead
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: RequestType
        /// </summary>
        public unsafe byte RequestType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Start
        /// </summary>
        public unsafe int Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: End
        /// </summary>
        public unsafe int End
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayerList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PlayerList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardTemplate
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FLeaderboardTemplate
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: UpdateType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardUpdateType UpdateType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardUpdateType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardSize
        /// </summary>
        public unsafe int LeaderboardSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: SortType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType SortType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: DisplayFormat
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat DisplayFormat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }

        /// <summary>
        /// StructProperty: LeaderboardRef
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardHandle LeaderboardRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardHandle>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bLeaderboardInitializing
        /// </summary>
        public unsafe bool bLeaderboardInitializing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bLeaderboardInitiated
        /// </summary>
        public unsafe bool bLeaderboardInitiated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardHandle
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FLeaderboardHandle
    {
        /// <summary>
        /// StructProperty: Dud
        /// </summary>
        public unsafe ulong Dud
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: ELeaderboardUpdateType
    /// </summary>
    public enum ELeaderboardUpdateType : byte
    {
        LUT_KeepBest = 0,
        LUT_Force = 1,
        LUT_MAX = 2,
    }

    /// <summary>
    /// Enum: ELeaderboardFormat
    /// </summary>
    public enum ELeaderboardFormat : byte
    {
        LF_Number = 0,
        LF_Seconds = 1,
        LF_Milliseconds = 2,
        LF_MAX = 3,
    }

    /// <summary>
    /// Enum: ELeaderboardSortType
    /// </summary>
    public enum ELeaderboardSortType : byte
    {
        LST_Ascending = 0,
        LST_Descending = 1,
        LST_MAX = 2,
    }

    /// <summary>
    /// Enum: ELeaderboardRequestType
    /// </summary>
    public enum ELeaderboardRequestType : byte
    {
        LBRT_Global = 0,
        LBRT_Player = 1,
        LBRT_Friends = 2,
        LBRT_MAX = 3,
    }

    /// <summary>
    /// Struct: FPendingPlayerStats
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FPendingPlayerStats
    {
        /// <summary>
        /// StructProperty: Player
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PlayerName
        /// </summary>
        public unsafe BmSDK.FString PlayerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: StatGuid
        /// </summary>
        public unsafe BmSDK.FString StatGuid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: Stats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPlayerStat> Stats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPlayerStat>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: Score
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StrProperty: Place
        /// </summary>
        public unsafe BmSDK.FString Place
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FPlayerStat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FPlayerStat
    {
        /// <summary>
        /// IntProperty: ViewId
        /// </summary>
        public unsafe int ViewId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ColumnId
        /// </summary>
        public unsafe int ColumnId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.Engine.Settings.FSettingsData Data
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.FSettingsData>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FQueuedAvatarRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FQueuedAvatarRequest
    {
        /// <summary>
        /// FloatProperty: CheckTime
        /// </summary>
        public unsafe float CheckTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumberOfAttempts
        /// </summary>
        public unsafe int NumberOfAttempts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: PlayerNetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Size
        /// </summary>
        public unsafe int Size
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// DelegateProperty: ReadOnlineAvatarCompleteDelegate
        /// </summary>
        public unsafe BmSDK.FScriptDelegate ReadOnlineAvatarCompleteDelegate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FDeviceIdCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FDeviceIdCache
    {
        /// <summary>
        /// IntProperty: DeviceID
        /// </summary>
        public unsafe int DeviceID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// DelegateProperty: DeviceSelectionMulticast
        /// </summary>
        public unsafe BmSDK.FScriptDelegate DeviceSelectionMulticast
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: DeviceSelectionDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> DeviceSelectionDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FAchievementProgressStat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAchievementProgressStat
    {
        /// <summary>
        /// IntProperty: AchievementId
        /// </summary>
        public unsafe int AchievementId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MaxProgress
        /// </summary>
        public unsafe int MaxProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bUnlock
        /// </summary>
        public unsafe bool bUnlock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FAchievementMappingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FAchievementMappingInfo
    {
        /// <summary>
        /// IntProperty: AchievementId
        /// </summary>
        public unsafe int AchievementId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: AchievementName
        /// </summary>
        public unsafe BmSDK.FName AchievementName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ViewId
        /// </summary>
        public unsafe int ViewId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: ProgressCount
        /// </summary>
        public unsafe int ProgressCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: MaxProgress
        /// </summary>
        public unsafe int MaxProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bAutoUnlock
        /// </summary>
        public unsafe bool bAutoUnlock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FSteamPlayerClanData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSteamPlayerClanData
    {
        /// <summary>
        /// StrProperty: ClanName
        /// </summary>
        public unsafe BmSDK.FString ClanName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ClanTag
        /// </summary>
        public unsafe BmSDK.FString ClanTag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FControllerConnectionState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FControllerConnectionState
    {
        /// <summary>
        /// IntProperty: bIsControllerConnected
        /// </summary>
        public unsafe int bIsControllerConnected
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: bLastIsControllerConnected
        /// </summary>
        public unsafe int bLastIsControllerConnected
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FOnlineStatusMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FOnlineStatusMapping
    {
        /// <summary>
        /// IntProperty: StatusId
        /// </summary>
        public unsafe int StatusId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: StatusString
        /// </summary>
        public unsafe BmSDK.FString StatusString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FProfileSettingsCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FProfileSettingsCache
    {
        /// <summary>
        /// ObjectProperty: Profile
        /// </summary>
        public unsafe BmSDK.Engine.OnlineProfileSettings Profile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ReadDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReadDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: WriteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> WriteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: ProfileDataChangedDelegates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ProfileDataChangedDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// StructProperty: DLCAPI
    /// </summary>
    public unsafe System.IntPtr DLCAPI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ObjectProperty: CachedGameInt
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks CachedGameInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ObjectProperty: CachedProfile
    /// </summary>
    public unsafe BmSDK.Engine.OnlineProfileSettings CachedProfile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: PlayerStorageCache
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerStorage PlayerStorageCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: CachedAuthInt
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks CachedAuthInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStatsRead
    /// </summary>
    public unsafe BmSDK.Engine.OnlineStatsRead CurrentStatsRead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineStatsRead>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: GameID
    /// </summary>
    public unsafe int GameID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StrProperty: EncryptedProductKey
    /// </summary>
    public unsafe BmSDK.FString EncryptedProductKey
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: ConnectionStatusChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ConnectionStatusChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: ControllerChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ControllerChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: LinkStatusDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> LinkStatusDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ByteProperty: CurrentNotificationPosition<br/>
    /// Default: NNP_TopRight
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition CurrentNotificationPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ByteProperty: LoggedInStatus
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ELoginStatus LoggedInStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELoginStatus>(Ptr + 749); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 749); }
    }

    /// <summary>
    /// ByteProperty: bWasKeyboardInputCanceled
    /// </summary>
    public unsafe byte bWasKeyboardInputCanceled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 750); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 750); }
    }

    /// <summary>
    /// ByteProperty: UserStatsReceivedState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState UserStatsReceivedState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(Ptr + 751); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 751); }
    }

    /// <summary>
    /// StrProperty: LocalProfileName
    /// </summary>
    public unsafe BmSDK.FString LocalProfileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StrProperty: LoggedInPlayerName<br/>
    /// Default: "Local Profile"
    /// </summary>
    public unsafe BmSDK.FString LoggedInPlayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// StructProperty: LoggedInPlayerId
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId LoggedInPlayerId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 784);

    /// <summary>
    /// IntProperty: LoggedInPlayerNum
    /// </summary>
    public unsafe int LoggedInPlayerNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StrProperty: ProfileDataDirectory
    /// </summary>
    public unsafe BmSDK.FString ProfileDataDirectory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// StrProperty: ProfileDataExtension
    /// </summary>
    public unsafe BmSDK.FString ProfileDataExtension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ArrayProperty: FriendInviteReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> FriendInviteReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ArrayProperty: FriendMessageReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> FriendMessageReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ArrayProperty: AddFriendByNameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> AddFriendByNameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// StructProperty: ProfileCache
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FProfileSettingsCache ProfileCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FProfileSettingsCache>(Ptr + 876);

    /// <summary>
    /// StrProperty: CachedFriendMessage
    /// </summary>
    public unsafe BmSDK.FString CachedFriendMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: LocationUrlsForInvites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LocationUrlsForInvites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StrProperty: LocationUrl
    /// </summary>
    public unsafe BmSDK.FString LocationUrl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: ReceivedGameInviteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReceivedGameInviteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ArrayProperty: JoinFriendGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> JoinFriendGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ArrayProperty: GetNumberOfCurrentPlayersCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> GetNumberOfCurrentPlayersCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: RegisterHostStatGuidCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> RegisterHostStatGuidCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: CachedFriendMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage> CachedFriendMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bStoringAchievement
    /// </summary>
    public unsafe bool bStoringAchievement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bLastHasConnection
    /// </summary>
    public unsafe bool bLastHasConnection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bHasSteamworksAccount
    /// </summary>
    public unsafe bool bHasSteamworksAccount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bShouldUseMcp
    /// </summary>
    public unsafe bool bShouldUseMcp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bNeedsKeyboardTicking
    /// </summary>
    public unsafe bool bNeedsKeyboardTicking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bVideoRecordEnabled<br/>
    /// Default: true
    /// </summary>
    public unsafe bool bVideoRecordEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bClientStatsStorePending
    /// </summary>
    public unsafe bool bClientStatsStorePending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bGSStatsStoresSuccess
    /// </summary>
    public unsafe bool bGSStatsStoresSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bIsStatsSessionOk
    /// </summary>
    public unsafe bool bIsStatsSessionOk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bReadOpComplete
    /// </summary>
    public unsafe bool m_bReadOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bWriteOpComplete
    /// </summary>
    public unsafe bool m_bWriteOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bDeleteOpComplete
    /// </summary>
    public unsafe bool m_bDeleteOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bOpSuccessful
    /// </summary>
    public unsafe bool m_bOpSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bHasReceivedSteamPrices
    /// </summary>
    public unsafe bool bHasReceivedSteamPrices
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// ArrayProperty: AchievementDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> AchievementDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ArrayProperty: AchievementReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> AchievementReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ReadFriendsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReadFriendsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: WriteProfileSettingsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> WriteProfileSettingsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ArrayProperty: FriendsChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> FriendsChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ArrayProperty: LoginChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> LoginChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: LoginFailedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> LoginFailedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ArrayProperty: LogoutCompletedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> LogoutCompletedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ArrayProperty: MutingChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> MutingChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: StatusMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FOnlineStatusMapping> StatusMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FOnlineStatusMapping>>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// StrProperty: DefaultStatus
    /// </summary>
    public unsafe BmSDK.FString DefaultStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// StrProperty: GameInviteMessage
    /// </summary>
    public unsafe BmSDK.FString GameInviteMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ControllerStates
    /// </summary>
    public InlineArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState> ControllerStates => new(4, Ptr + 1256, 8, this);

    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 1256);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 1264);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 1272);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 1280);

    /// <summary>
    /// FloatProperty: ConnectionPresenceTimeInterval<br/>
    /// Default: 0.5
    /// </summary>
    public unsafe float ConnectionPresenceTimeInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: ConnectionPresenceElapsedTime
    /// </summary>
    public unsafe float ConnectionPresenceElapsedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ArrayProperty: PendingRedirects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.InternetLink.FIpAddr> PendingRedirects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.InternetLink.FIpAddr>>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// StrProperty: KeyboardResultsString
    /// </summary>
    public unsafe BmSDK.FString KeyboardResultsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ArrayProperty: KeyboardInputDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> KeyboardInputDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ArrayProperty: AchievementMappings<br/>
    /// Default: ((AchievementId=1,AchievementName=EACID_MP_A_Battle_Within),(AchievementId=2,AchievementName=EACID_MP_A_Heart_Broken_in_Two),(AchievementId=3,AchievementName=EACID_OT_Absolution),(AchievementId=4,Achi...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementMappingInfo> AchievementMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementMappingInfo>>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ArrayProperty: LocalPlayerStorageReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> LocalPlayerStorageReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: LocalPlayerStorageWriteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> LocalPlayerStorageWriteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ArrayProperty: RemotePlayerStorageReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> RemotePlayerStorageReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ArrayProperty: PendingAchievementProgress
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementProgressStat> PendingAchievementProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementProgressStat>>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// StructProperty: DeviceCache
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeviceIdCache DeviceCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeviceIdCache>(Ptr + 1424);

    /// <summary>
    /// ArrayProperty: QueuedAvatarRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FQueuedAvatarRequest> QueuedAvatarRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FQueuedAvatarRequest>>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ArrayProperty: AccountCreateDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> AccountCreateDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: TotalGSStatsStoresPending
    /// </summary>
    public unsafe int TotalGSStatsStoresPending
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// ArrayProperty: ReadOnlineStatsCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReadOnlineStatsCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// ArrayProperty: FlushOnlineStatsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> FlushOnlineStatsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// ArrayProperty: PendingStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPendingPlayerStats> PendingStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPendingPlayerStats>>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// ArrayProperty: LeaderboardList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardTemplate> LeaderboardList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardTemplate>>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// ArrayProperty: DeferredLeaderboardReads
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardRead> DeferredLeaderboardReads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardRead>>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// ArrayProperty: DeferredLeaderboardWrites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite> DeferredLeaderboardWrites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite>>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// ArrayProperty: PendingLeaderboardStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite> PendingLeaderboardStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite>>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ArrayProperty: GameServerStatsMappings
    /// </summary>
    public unsafe BmSDK.TArray<int> GameServerStatsMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// StructProperty: ContentCache
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FContentListCache ContentCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FContentListCache>(Ptr + 1624);

    /// <summary>
    /// StrProperty: DLCRootDir<br/>
    /// Default: "../../DLC/"
    /// </summary>
    public unsafe BmSDK.FString DLCRootDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// ArrayProperty: ReadTitleFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReadTitleFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile> SharedFileCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile>>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// ArrayProperty: SpeechRecognitionCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> SpeechRecognitionCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ArrayProperty: TalkingDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> TalkingDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ArrayProperty: MuteList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> MuteList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// StructProperty: CurrentLocalTalker
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLocalTalkerSteam CurrentLocalTalker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLocalTalkerSteam>(Ptr + 1828);

    /// <summary>
    /// ArrayProperty: RemoteTalkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FRemoteTalker> RemoteTalkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FRemoteTalker>>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// ArrayProperty: EnumerateUserFilesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> EnumerateUserFilesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ArrayProperty: ReadUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReadUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: WriteUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> WriteUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: DeleteUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> DeleteUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ArrayProperty: ReadDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> ReadDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// ArrayProperty: WriteDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> WriteDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// ArrayProperty: DeleteDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> DeleteDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// ArrayProperty: UserCloudFiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloud> UserCloudFiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloud>>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ArrayProperty: UserCloudMetadata
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloudMetadata> UserCloudMetadata
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloudMetadata>>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileReadCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> SharedFileReadCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileWriteCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FScriptDelegate> SharedFileWriteCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FScriptDelegate>>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// StrProperty: m_DownloadFileName
    /// </summary>
    public unsafe BmSDK.FString m_DownloadFileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// StructProperty: m_DownloadFileDescriptor
    /// </summary>
    public unsafe System.IntPtr m_DownloadFileDescriptor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// StructProperty: m_DownloadFileTask
    /// </summary>
    public unsafe System.IntPtr m_DownloadFileTask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// IntProperty: m_bytesProcessed
    /// </summary>
    public unsafe int m_bytesProcessed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// ArrayProperty: CachedSteamPrices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContentOffering> CachedSteamPrices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContentOffering>>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// DelegateProperty: __OnLinkStatusChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnLinkStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// DelegateProperty: __OnExternalUIChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnExternalUIChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// DelegateProperty: __OnControllerChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnControllerChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// DelegateProperty: __OnConnectionStatusChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnConnectionStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// DelegateProperty: __OnStorageDeviceChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnStorageDeviceChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnLoginChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginCancelled__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnLoginCancelled__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// DelegateProperty: __OnMutingChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnMutingChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendsChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnFriendsChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginFailed__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnLoginFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// DelegateProperty: __OnLogoutCompleted__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnLogoutCompleted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginStatusChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnLoginStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnWriteProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// DelegateProperty: __OnGetNumberOfCurrentPlayersComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnGetNumberOfCurrentPlayersComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadPlayerStorageComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadPlayerStorageComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadPlayerStorageForNetIdComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadPlayerStorageForNetIdComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// DelegateProperty: __OnWritePlayerStorageComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnWritePlayerStorageComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadFriendsComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadFriendsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// DelegateProperty: __OnKeyboardInputComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnKeyboardInputComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// DelegateProperty: __OnAddFriendByNameComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnAddFriendByNameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendInviteReceived__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnFriendInviteReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedGameInvite__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReceivedGameInvite__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinFriendGameComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnJoinFriendGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendMessageReceived__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnFriendMessageReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnlockAchievementComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnUnlockAchievementComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadAchievementsComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadAchievementsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// DelegateProperty: __OnMsgBoxUIComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnMsgBoxUIComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeviceSelectionComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnDeviceSelectionComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// DelegateProperty: __OnProfileDataChanged__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnProfileDataChanged__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// DelegateProperty: __OnNewInfocast__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnNewInfocast__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadCrossTitleProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadOnlineAvatarComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadOnlineAvatarComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// DelegateProperty: __OnGTCCommand__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnGTCCommand__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// DelegateProperty: __OnCreateOnlineAccountCompleted__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnCreateOnlineAccountCompleted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadOnlineStatsComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadOnlineStatsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// DelegateProperty: __OnFlushOnlineStatsComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnFlushOnlineStatsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterHostStatGuidComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnRegisterHostStatGuidComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// DelegateProperty: __OnContentChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnContentChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadContentComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// DelegateProperty: __OnContentStatusChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnContentStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadInGameStoreContentComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadInGameStoreContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// DelegateProperty: __OnPurchaseInGameStoreContentComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnPurchaseInGameStoreContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleContentComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadCrossTitleContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadCrossTitleSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// DelegateProperty: __OnQueryAvailableDownloadsComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnQueryAvailableDownloadsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnWriteSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadTitleFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// DelegateProperty: __OnRequestTitleFileListComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnRequestTitleFileListComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// DelegateProperty: __OnPlayerTalkingStateChange__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnPlayerTalkingStateChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }

    /// <summary>
    /// DelegateProperty: __OnRecognitionComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnRecognitionComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2896); }
    }

    /// <summary>
    /// DelegateProperty: __OnEnumerateUserFilesComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnEnumerateUserFilesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadUserFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteUserFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnWriteUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteUserFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnDeleteUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadDownloadFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteDownloadFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnWriteDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteDownloadFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnDeleteDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadSharedFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnReadSharedFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteSharedFileComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnWriteSharedFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 3040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }
    }

    /// <summary>
    /// DelegateProperty: __OnRequestComplete__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __OnRequestComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 3056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3056); }
    }

    /// <summary>
    /// DelegateProperty: __SteamDLCCallback__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __SteamDLCCallback__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }
}
