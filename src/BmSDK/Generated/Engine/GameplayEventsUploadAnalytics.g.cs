#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameplayEventsUploadAnalytics<br/>
/// (size = 444)
/// (flags = 134217874)
/// </summary>
public partial class GameplayEventsUploadAnalytics : BmSDK.Engine.GameplayEventsWriterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameplayEventsUploadAnalytics", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GameplayEventsUploadAnalytics.
    /// </summary>
    public static GameplayEventsUploadAnalytics DefaultObject => (GameplayEventsUploadAnalytics)StaticClass().DefaultObject;

    internal GameplayEventsUploadAnalytics() { }

    /// <summary>
    /// Constructs a new GameplayEventsUploadAnalytics
    /// </summary>
    public GameplayEventsUploadAnalytics(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameplayEventsUploadAnalytics Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameplayEventsUploadAnalytics(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsUploadAnalytics>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsUploadAnalytics>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsUploadAnalytics>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsUploadAnalytics>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsUploadAnalytics>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsUploadAnalytics>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsUploadAnalytics>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsUploadAnalytics>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RecordCoverLinkFireLinks;
    /// <summary>
    /// Function: RecordCoverLinkFireLinks
    /// </summary>
    public unsafe override int RecordCoverLinkFireLinks(BmSDK.Engine.CoverLink Link, BmSDK.Engine.Controller Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RecordCoverLinkFireLinks, "Engine.GameplayEventsUploadAnalytics.RecordCoverLinkFireLinks", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RecordAIPathFail;
    /// <summary>
    /// Function: RecordAIPathFail
    /// </summary>
    public unsafe override void RecordAIPathFail(BmSDK.Engine.Controller AI, BmSDK.FStringArg Reason, System.Numerics.Vector3 Dest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RecordAIPathFail, "Engine.GameplayEventsUploadAnalytics.RecordAIPathFail", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AI, paramsPtr + 0);
        Reason.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dest, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetGenericParamListEntry;
    /// <summary>
    /// Function: GetGenericParamListEntry
    /// </summary>
    public unsafe virtual BmSDK.Engine.GenericParamListStatEntry GetGenericParamListEntry()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetGenericParamListEntry, "Engine.GameplayEventsUploadAnalytics.GetGenericParamListEntry", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.GenericParamListStatEntry>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogProjectileIntEvent;
    /// <summary>
    /// Function: LogProjectileIntEvent<br/>
    /// Native code at BatmanAK.exe+0xB7BD00 in the Steam build
    /// </summary>
    public unsafe override void LogProjectileIntEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class Proj, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogProjectileIntEvent, "Engine.GameplayEventsUploadAnalytics.LogProjectileIntEvent", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogDamageEvent;
    /// <summary>
    /// Function: LogDamageEvent<br/>
    /// Native code at BatmanAK.exe+0xB7B8C0 in the Steam build
    /// </summary>
    public unsafe override void LogDamageEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class dmgType, BmSDK.Engine.Controller Target, int Amount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogDamageEvent, "Engine.GameplayEventsUploadAnalytics.LogDamageEvent", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 28);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogWeaponIntEvent;
    /// <summary>
    /// Function: LogWeaponIntEvent<br/>
    /// Native code at BatmanAK.exe+0xB7CCF0 in the Steam build
    /// </summary>
    public unsafe override void LogWeaponIntEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class WeaponClass, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogWeaponIntEvent, "Engine.GameplayEventsUploadAnalytics.LogWeaponIntEvent", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerPlayerEvent;
    /// <summary>
    /// Function: LogPlayerPlayerEvent<br/>
    /// Native code at BatmanAK.exe+0xB7B620 in the Steam build
    /// </summary>
    public unsafe override void LogPlayerPlayerEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Engine.Controller Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerPlayerEvent, "Engine.GameplayEventsUploadAnalytics.LogPlayerPlayerEvent", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 12);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerKillDeath;
    /// <summary>
    /// Function: LogPlayerKillDeath<br/>
    /// Native code at BatmanAK.exe+0xB7B200 in the Steam build
    /// </summary>
    public unsafe override void LogPlayerKillDeath(int EventID, int KillType, BmSDK.Engine.Controller Killer, BmSDK.Class dmgType, BmSDK.Engine.Controller Dead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerKillDeath, "Engine.GameplayEventsUploadAnalytics.LogPlayerKillDeath", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dead, paramsPtr + 24);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogAllPlayerPositionsEvent;
    /// <summary>
    /// Function: LogAllPlayerPositionsEvent<br/>
    /// Native code at BatmanAK.exe+0xB7B0E0 in the Steam build
    /// </summary>
    public unsafe override void LogAllPlayerPositionsEvent(int EventID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogAllPlayerPositionsEvent, "Engine.GameplayEventsUploadAnalytics.LogAllPlayerPositionsEvent", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerLoginChange;
    /// <summary>
    /// Function: LogPlayerLoginChange<br/>
    /// Native code at BatmanAK.exe+0xBA8930 in the Steam build
    /// </summary>
    public unsafe override void LogPlayerLoginChange(int EventID, BmSDK.Engine.Controller Player, BmSDK.FStringArg PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bSplitScreen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerLoginChange, "Engine.GameplayEventsUploadAnalytics.LogPlayerLoginChange", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        PlayerName.WriteTo(paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSplitScreen, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerSpawnEvent;
    /// <summary>
    /// Function: LogPlayerSpawnEvent<br/>
    /// Native code at BatmanAK.exe+0xB7AD80 in the Steam build
    /// </summary>
    public unsafe override void LogPlayerSpawnEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class PawnClass, int TeamID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerSpawnEvent, "Engine.GameplayEventsUploadAnalytics.LogPlayerSpawnEvent", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnClass, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 20);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerStringEvent;
    /// <summary>
    /// Function: LogPlayerStringEvent<br/>
    /// Native code at BatmanAK.exe+0xBA8670 in the Steam build
    /// </summary>
    public unsafe override void LogPlayerStringEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.FStringArg EventString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerStringEvent, "Engine.GameplayEventsUploadAnalytics.LogPlayerStringEvent", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        EventString.WriteTo(paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerFloatEvent;
    /// <summary>
    /// Function: LogPlayerFloatEvent<br/>
    /// Native code at BatmanAK.exe+0xB7AAD0 in the Steam build
    /// </summary>
    public unsafe override void LogPlayerFloatEvent(int EventID, BmSDK.Engine.Controller Player, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerFloatEvent, "Engine.GameplayEventsUploadAnalytics.LogPlayerFloatEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerIntEvent;
    /// <summary>
    /// Function: LogPlayerIntEvent<br/>
    /// Native code at BatmanAK.exe+0xB7A830 in the Steam build
    /// </summary>
    public unsafe override void LogPlayerIntEvent(int EventID, BmSDK.Engine.Controller Player, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerIntEvent, "Engine.GameplayEventsUploadAnalytics.LogPlayerIntEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogTeamStringEvent;
    /// <summary>
    /// Function: LogTeamStringEvent<br/>
    /// Native code at BatmanAK.exe+0xBA83B0 in the Steam build
    /// </summary>
    public unsafe override void LogTeamStringEvent(int EventID, BmSDK.Engine.TeamInfo Team, BmSDK.FStringArg Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogTeamStringEvent, "Engine.GameplayEventsUploadAnalytics.LogTeamStringEvent", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        Value.WriteTo(paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogTeamFloatEvent;
    /// <summary>
    /// Function: LogTeamFloatEvent<br/>
    /// Native code at BatmanAK.exe+0xB7A580 in the Steam build
    /// </summary>
    public unsafe override void LogTeamFloatEvent(int EventID, BmSDK.Engine.TeamInfo Team, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogTeamFloatEvent, "Engine.GameplayEventsUploadAnalytics.LogTeamFloatEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogTeamIntEvent;
    /// <summary>
    /// Function: LogTeamIntEvent<br/>
    /// Native code at BatmanAK.exe+0xB7A2E0 in the Steam build
    /// </summary>
    public unsafe override void LogTeamIntEvent(int EventID, BmSDK.Engine.TeamInfo Team, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogTeamIntEvent, "Engine.GameplayEventsUploadAnalytics.LogTeamIntEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogGamePositionEvent;
    /// <summary>
    /// Function: LogGamePositionEvent<br/>
    /// Native code at BatmanAK.exe+0xB7A0B0 in the Steam build
    /// </summary>
    public unsafe override void LogGamePositionEvent(int EventID, out System.Numerics.Vector3 Position, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogGamePositionEvent, "Engine.GameplayEventsUploadAnalytics.LogGamePositionEvent", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Position);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Position = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogGameFloatEvent;
    /// <summary>
    /// Function: LogGameFloatEvent<br/>
    /// Native code at BatmanAK.exe+0xB79EC0 in the Steam build
    /// </summary>
    public unsafe override void LogGameFloatEvent(int EventID, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogGameFloatEvent, "Engine.GameplayEventsUploadAnalytics.LogGameFloatEvent", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogGameStringEvent;
    /// <summary>
    /// Function: LogGameStringEvent<br/>
    /// Native code at BatmanAK.exe+0xBA81C0 in the Steam build
    /// </summary>
    public unsafe override void LogGameStringEvent(int EventID, BmSDK.FStringArg Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogGameStringEvent, "Engine.GameplayEventsUploadAnalytics.LogGameStringEvent", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        Value.WriteTo(paramsPtr + 4);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogGameIntEvent;
    /// <summary>
    /// Function: LogGameIntEvent<br/>
    /// Native code at BatmanAK.exe+0xB79CE0 in the Steam build
    /// </summary>
    public unsafe override void LogGameIntEvent(int EventID, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogGameIntEvent, "Engine.GameplayEventsUploadAnalytics.LogGameIntEvent", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EndLogging;
    /// <summary>
    /// Function: EndLogging<br/>
    /// Native code at BatmanAK.exe+0xB2E070 in the Steam build
    /// </summary>
    public unsafe override void EndLogging()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EndLogging, "Engine.GameplayEventsUploadAnalytics.EndLogging", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetLogging;
    /// <summary>
    /// Function: ResetLogging<br/>
    /// Native code at BatmanAK.exe+0xB3F6F0 in the Steam build
    /// </summary>
    public unsafe override void ResetLogging(float HeartbeatDelta = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetLogging, "Engine.GameplayEventsUploadAnalytics.ResetLogging", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartbeatDelta, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartLogging;
    /// <summary>
    /// Function: StartLogging<br/>
    /// Native code at BatmanAK.exe+0xB3F660 in the Steam build
    /// </summary>
    public unsafe override void StartLogging(float HeartbeatDelta = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartLogging, "Engine.GameplayEventsUploadAnalytics.StartLogging", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartbeatDelta, paramsPtr + 0);
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
}
