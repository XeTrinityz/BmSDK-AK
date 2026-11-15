#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameplayEventsWriterBase<br/>
/// (size = 444)
/// (flags = 134217874)
/// </summary>
public partial class GameplayEventsWriterBase : BmSDK.Engine.GameplayEvents, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameplayEventsWriterBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GameplayEventsWriterBase.
    /// </summary>
    public static GameplayEventsWriterBase DefaultObject => (GameplayEventsWriterBase)StaticClass().DefaultObject;

    internal GameplayEventsWriterBase() { }

    /// <summary>
    /// Constructs a new GameplayEventsWriterBase
    /// </summary>
    public GameplayEventsWriterBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameplayEventsWriterBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameplayEventsWriterBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameplayEventsWriterBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Const: GAMEEVENT_MAX_EVENTID = 0x0000FFFF
    /// </summary>
    public const int GAMEEVENT_MAX_EVENTID = 0x0000FFFF;

    /// <summary>
    /// Const: GAMEEVENT_GAME_SPECIFIC = 1000
    /// </summary>
    public const int GAMEEVENT_GAME_SPECIFIC = 1000;

    /// <summary>
    /// Const: GAMEEVENT_GENERIC_PARAM_LIST_END = 400
    /// </summary>
    public const int GAMEEVENT_GENERIC_PARAM_LIST_END = 400;

    /// <summary>
    /// Const: GAMEEVENT_GENERIC_PARAM_LIST_START = 300
    /// </summary>
    public const int GAMEEVENT_GENERIC_PARAM_LIST_START = 300;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_KILL_NORMAL = 200
    /// </summary>
    public const int GAMEEVENT_PLAYER_KILL_NORMAL = 200;

    /// <summary>
    /// Const: GAMEEVENT_WEAPON_FIRED = 152
    /// </summary>
    public const int GAMEEVENT_WEAPON_FIRED = 152;

    /// <summary>
    /// Const: GAMEEVENT_WEAPON_DAMAGE_MELEE = 151
    /// </summary>
    public const int GAMEEVENT_WEAPON_DAMAGE_MELEE = 151;

    /// <summary>
    /// Const: GAMEEVENT_WEAPON_DAMAGE = 150
    /// </summary>
    public const int GAMEEVENT_WEAPON_DAMAGE = 150;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_ROUND_STALEMATE = 110
    /// </summary>
    public const int GAMEEVENT_PLAYER_ROUND_STALEMATE = 110;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_ROUND_WON = 109
    /// </summary>
    public const int GAMEEVENT_PLAYER_ROUND_WON = 109;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_DEATH = 108
    /// </summary>
    public const int GAMEEVENT_PLAYER_DEATH = 108;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_KILL_STREAK = 107
    /// </summary>
    public const int GAMEEVENT_PLAYER_KILL_STREAK = 107;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_TEAMCHANGE = 106
    /// </summary>
    public const int GAMEEVENT_PLAYER_TEAMCHANGE = 106;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_LOCATION_POLL = 105
    /// </summary>
    public const int GAMEEVENT_PLAYER_LOCATION_POLL = 105;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_KILL = 104
    /// </summary>
    public const int GAMEEVENT_PLAYER_KILL = 104;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_MATCH_WON = 103
    /// </summary>
    public const int GAMEEVENT_PLAYER_MATCH_WON = 103;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_SPAWN = 102
    /// </summary>
    public const int GAMEEVENT_PLAYER_SPAWN = 102;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_LOGOUT = 101
    /// </summary>
    public const int GAMEEVENT_PLAYER_LOGOUT = 101;

    /// <summary>
    /// Const: GAMEEVENT_PLAYER_LOGIN = 100
    /// </summary>
    public const int GAMEEVENT_PLAYER_LOGIN = 100;

    /// <summary>
    /// Const: GAMEEVENT_TEAM_ROUND_STALEMATE = 52
    /// </summary>
    public const int GAMEEVENT_TEAM_ROUND_STALEMATE = 52;

    /// <summary>
    /// Const: GAMEEVENT_TEAM_ROUND_WON = 5
    /// </summary>
    public const int GAMEEVENT_TEAM_ROUND_WON = 5;

    /// <summary>
    /// Const: GAMEEVENT_TEAM_MATCH_WON = 4
    /// </summary>
    public const int GAMEEVENT_TEAM_MATCH_WON = 4;

    /// <summary>
    /// Const: GAMEEVENT_TEAM_GAME_SCORE = 51
    /// </summary>
    public const int GAMEEVENT_TEAM_GAME_SCORE = 51;

    /// <summary>
    /// Const: GAMEEVENT_TEAM_CREATED = 50
    /// </summary>
    public const int GAMEEVENT_TEAM_CREATED = 50;

    /// <summary>
    /// Const: GAMEEVENT_FRAMETIME_POLL = 43
    /// </summary>
    public const int GAMEEVENT_FRAMETIME_POLL = 43;

    /// <summary>
    /// Const: GAMEEVENT_GPUFRAMETIME_POLL = 42
    /// </summary>
    public const int GAMEEVENT_GPUFRAMETIME_POLL = 42;

    /// <summary>
    /// Const: GAMEEVENT_GAMETHREAD_POLL = 41
    /// </summary>
    public const int GAMEEVENT_GAMETHREAD_POLL = 41;

    /// <summary>
    /// Const: GAMEEVENT_RENDERTHREAD_POLL = 40
    /// </summary>
    public const int GAMEEVENT_RENDERTHREAD_POLL = 40;

    /// <summary>
    /// Const: GAMEEVENT_PING_POLL = 39
    /// </summary>
    public const int GAMEEVENT_PING_POLL = 39;

    /// <summary>
    /// Const: GAMEEVENT_NETWORKUSAGEOUT_POLL = 38
    /// </summary>
    public const int GAMEEVENT_NETWORKUSAGEOUT_POLL = 38;

    /// <summary>
    /// Const: GAMEEVENT_NETWORKUSAGEIN_POLL = 37
    /// </summary>
    public const int GAMEEVENT_NETWORKUSAGEIN_POLL = 37;

    /// <summary>
    /// Const: GAMEEVENT_FRAMERATE_POLL = 36
    /// </summary>
    public const int GAMEEVENT_FRAMERATE_POLL = 36;

    /// <summary>
    /// Const: GAMEEVENT_MEMORYUSAGE_POLL = 35
    /// </summary>
    public const int GAMEEVENT_MEMORYUSAGE_POLL = 35;

    /// <summary>
    /// Const: GAMEEVENT_GAME_MAPNAME = 8
    /// </summary>
    public const int GAMEEVENT_GAME_MAPNAME = 8;

    /// <summary>
    /// Const: GAMEEVENT_GAME_OPTION_URL = 7
    /// </summary>
    public const int GAMEEVENT_GAME_OPTION_URL = 7;

    /// <summary>
    /// Const: GAMEEVENT_GAME_CLASS = 6
    /// </summary>
    public const int GAMEEVENT_GAME_CLASS = 6;

    /// <summary>
    /// Const: GAMEEVENT_ROUND_ENDED = 3
    /// </summary>
    public const int GAMEEVENT_ROUND_ENDED = 3;

    /// <summary>
    /// Const: GAMEEVENT_ROUND_STARTED = 2
    /// </summary>
    public const int GAMEEVENT_ROUND_STARTED = 2;

    /// <summary>
    /// Const: GAMEEVENT_MATCH_ENDED = 1
    /// </summary>
    public const int GAMEEVENT_MATCH_ENDED = 1;

    /// <summary>
    /// Const: GAMEEVENT_MATCH_STARTED = 0
    /// </summary>
    public const int GAMEEVENT_MATCH_STARTED = 0;

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RecordCoverLinkFireLinks;
    /// <summary>
    /// Function: RecordCoverLinkFireLinks
    /// </summary>
    public unsafe virtual int RecordCoverLinkFireLinks(BmSDK.Engine.CoverLink Link, BmSDK.Engine.Controller Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RecordCoverLinkFireLinks, "Engine.GameplayEventsWriterBase.RecordCoverLinkFireLinks", this);
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
    public unsafe virtual void RecordAIPathFail(BmSDK.Engine.Controller AI, BmSDK.FStringArg Reason, System.Numerics.Vector3 Dest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RecordAIPathFail, "Engine.GameplayEventsWriterBase.RecordAIPathFail", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AI, paramsPtr + 0);
        Reason.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dest, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogSystemPollEvents;
    /// <summary>
    /// Function: LogSystemPollEvents
    /// </summary>
    public unsafe virtual void LogSystemPollEvents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogSystemPollEvents, "Engine.GameplayEventsWriterBase.LogSystemPollEvents", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogProjectileIntEvent;
    /// <summary>
    /// Function: LogProjectileIntEvent
    /// </summary>
    public unsafe virtual void LogProjectileIntEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class Proj, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogProjectileIntEvent, "Engine.GameplayEventsWriterBase.LogProjectileIntEvent", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogDamageEvent;
    /// <summary>
    /// Function: LogDamageEvent
    /// </summary>
    public unsafe virtual void LogDamageEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class dmgType, BmSDK.Engine.Controller Target, int Amount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogDamageEvent, "Engine.GameplayEventsWriterBase.LogDamageEvent", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogWeaponIntEvent;
    /// <summary>
    /// Function: LogWeaponIntEvent
    /// </summary>
    public unsafe virtual void LogWeaponIntEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class WeaponClass, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogWeaponIntEvent, "Engine.GameplayEventsWriterBase.LogWeaponIntEvent", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerPlayerEvent;
    /// <summary>
    /// Function: LogPlayerPlayerEvent
    /// </summary>
    public unsafe virtual void LogPlayerPlayerEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Engine.Controller Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerPlayerEvent, "Engine.GameplayEventsWriterBase.LogPlayerPlayerEvent", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerKillDeath;
    /// <summary>
    /// Function: LogPlayerKillDeath
    /// </summary>
    public unsafe virtual void LogPlayerKillDeath(int EventID, int KillType, BmSDK.Engine.Controller Killer, BmSDK.Class dmgType, BmSDK.Engine.Controller Dead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerKillDeath, "Engine.GameplayEventsWriterBase.LogPlayerKillDeath", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dead, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogAllPlayerPositionsEvent;
    /// <summary>
    /// Function: LogAllPlayerPositionsEvent
    /// </summary>
    public unsafe virtual void LogAllPlayerPositionsEvent(int EventID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogAllPlayerPositionsEvent, "Engine.GameplayEventsWriterBase.LogAllPlayerPositionsEvent", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerLoginChange;
    /// <summary>
    /// Function: LogPlayerLoginChange
    /// </summary>
    public unsafe virtual void LogPlayerLoginChange(int EventID, BmSDK.Engine.Controller Player, BmSDK.FStringArg PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bSplitScreen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerLoginChange, "Engine.GameplayEventsWriterBase.LogPlayerLoginChange", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        PlayerName.WriteTo(paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSplitScreen, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerSpawnEvent;
    /// <summary>
    /// Function: LogPlayerSpawnEvent
    /// </summary>
    public unsafe virtual void LogPlayerSpawnEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.Class PawnClass, int TeamID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerSpawnEvent, "Engine.GameplayEventsWriterBase.LogPlayerSpawnEvent", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnClass, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerStringEvent;
    /// <summary>
    /// Function: LogPlayerStringEvent
    /// </summary>
    public unsafe virtual void LogPlayerStringEvent(int EventID, BmSDK.Engine.Controller Player, BmSDK.FStringArg EventString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerStringEvent, "Engine.GameplayEventsWriterBase.LogPlayerStringEvent", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        EventString.WriteTo(paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerFloatEvent;
    /// <summary>
    /// Function: LogPlayerFloatEvent
    /// </summary>
    public unsafe virtual void LogPlayerFloatEvent(int EventID, BmSDK.Engine.Controller Player, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerFloatEvent, "Engine.GameplayEventsWriterBase.LogPlayerFloatEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogPlayerIntEvent;
    /// <summary>
    /// Function: LogPlayerIntEvent
    /// </summary>
    public unsafe virtual void LogPlayerIntEvent(int EventID, BmSDK.Engine.Controller Player, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogPlayerIntEvent, "Engine.GameplayEventsWriterBase.LogPlayerIntEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogTeamStringEvent;
    /// <summary>
    /// Function: LogTeamStringEvent
    /// </summary>
    public unsafe virtual void LogTeamStringEvent(int EventID, BmSDK.Engine.TeamInfo Team, BmSDK.FStringArg Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogTeamStringEvent, "Engine.GameplayEventsWriterBase.LogTeamStringEvent", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        Value.WriteTo(paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogTeamFloatEvent;
    /// <summary>
    /// Function: LogTeamFloatEvent
    /// </summary>
    public unsafe virtual void LogTeamFloatEvent(int EventID, BmSDK.Engine.TeamInfo Team, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogTeamFloatEvent, "Engine.GameplayEventsWriterBase.LogTeamFloatEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogTeamIntEvent;
    /// <summary>
    /// Function: LogTeamIntEvent
    /// </summary>
    public unsafe virtual void LogTeamIntEvent(int EventID, BmSDK.Engine.TeamInfo Team, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogTeamIntEvent, "Engine.GameplayEventsWriterBase.LogTeamIntEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogGamePositionEvent;
    /// <summary>
    /// Function: LogGamePositionEvent
    /// </summary>
    public unsafe virtual void LogGamePositionEvent(int EventID, out System.Numerics.Vector3 Position, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogGamePositionEvent, "Engine.GameplayEventsWriterBase.LogGamePositionEvent", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Position);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Position = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogGameFloatEvent;
    /// <summary>
    /// Function: LogGameFloatEvent
    /// </summary>
    public unsafe virtual void LogGameFloatEvent(int EventID, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogGameFloatEvent, "Engine.GameplayEventsWriterBase.LogGameFloatEvent", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogGameStringEvent;
    /// <summary>
    /// Function: LogGameStringEvent
    /// </summary>
    public unsafe virtual void LogGameStringEvent(int EventID, BmSDK.FStringArg Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogGameStringEvent, "Engine.GameplayEventsWriterBase.LogGameStringEvent", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        Value.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LogGameIntEvent;
    /// <summary>
    /// Function: LogGameIntEvent
    /// </summary>
    public unsafe virtual void LogGameIntEvent(int EventID, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LogGameIntEvent, "Engine.GameplayEventsWriterBase.LogGameIntEvent", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EndLogging;
    /// <summary>
    /// Function: EndLogging
    /// </summary>
    public unsafe virtual void EndLogging()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EndLogging, "Engine.GameplayEventsWriterBase.EndLogging", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetLogging;
    /// <summary>
    /// Function: ResetLogging
    /// </summary>
    public unsafe virtual void ResetLogging(float HeartbeatDelta = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetLogging, "Engine.GameplayEventsWriterBase.ResetLogging", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartbeatDelta, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartLogging;
    /// <summary>
    /// Function: StartLogging
    /// </summary>
    public unsafe virtual void StartLogging(float HeartbeatDelta = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartLogging, "Engine.GameplayEventsWriterBase.StartLogging", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartbeatDelta, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlaylistId;
    /// <summary>
    /// Function: GetPlaylistId
    /// </summary>
    public unsafe virtual int GetPlaylistId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlaylistId, "Engine.GameplayEventsWriterBase.GetPlaylistId", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetGameTypeId;
    /// <summary>
    /// Function: GetGameTypeId
    /// </summary>
    public unsafe virtual int GetGameTypeId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetGameTypeId, "Engine.GameplayEventsWriterBase.GetGameTypeId", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Poll;
    /// <summary>
    /// Function: Poll
    /// </summary>
    public unsafe virtual void Poll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Poll, "Engine.GameplayEventsWriterBase.Poll", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopPolling;
    /// <summary>
    /// Function: StopPolling
    /// </summary>
    public unsafe virtual void StopPolling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopPolling, "Engine.GameplayEventsWriterBase.StopPolling", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartPolling;
    /// <summary>
    /// Function: StartPolling
    /// </summary>
    public unsafe virtual void StartPolling(float HearbeatDelta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartPolling, "Engine.GameplayEventsWriterBase.StartPolling", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HearbeatDelta, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsSessionInProgress;
    /// <summary>
    /// Function: IsSessionInProgress
    /// </summary>
    public unsafe virtual bool IsSessionInProgress()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsSessionInProgress, "Engine.GameplayEventsWriterBase.IsSessionInProgress", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: Game
    /// </summary>
    public unsafe BmSDK.Engine.GameInfo Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameInfo>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
}
