#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_GFxMovieComputerMinigame_ManBat<br/>
/// (size = 440)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_GFxMovieComputerMinigame_ManBat : BmSDK.BmScript.RSeqAct_GFxMovieComputerMinigame, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_GFxMovieComputerMinigame_ManBat.
    /// </summary>
    public static RSeqAct_GFxMovieComputerMinigame_ManBat DefaultObject => (RSeqAct_GFxMovieComputerMinigame_ManBat)StaticClass().DefaultObject;

    internal RSeqAct_GFxMovieComputerMinigame_ManBat() { }

    /// <summary>
    /// Constructs a new RSeqAct_GFxMovieComputerMinigame_ManBat
    /// </summary>
    public RSeqAct_GFxMovieComputerMinigame_ManBat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_GFxMovieComputerMinigame_ManBat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_GFxMovieComputerMinigame_ManBat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieComputerMinigame_ManBat>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieComputerMinigame_ManBat>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieComputerMinigame_ManBat>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieComputerMinigame_ManBat>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieComputerMinigame_ManBat>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieComputerMinigame_ManBat>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieComputerMinigame_ManBat>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieComputerMinigame_ManBat>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdatePrompts;
    /// <summary>
    /// Function: UpdatePrompts
    /// </summary>
    public unsafe virtual void UpdatePrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdatePrompts, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.UpdatePrompts", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetIdleState;
    /// <summary>
    /// Function: SetIdleState
    /// </summary>
    public unsafe virtual void SetIdleState(bool is_idle, bool is_game)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetIdleState, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.SetIdleState", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_idle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_game, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_AnnounceIdleReached;
    /// <summary>
    /// Function: XI_AnnounceIdleReached
    /// </summary>
    public unsafe override void XI_AnnounceIdleReached(BmSDK.FStringArg idle_string)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_AnnounceIdleReached, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.XI_AnnounceIdleReached", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        idle_string.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetEnumForString;
    /// <summary>
    /// Function: GetEnumForString
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.ManBatOutput GetEnumForString(BmSDK.FStringArg enum_string)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetEnumForString, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.GetEnumForString", this);
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        enum_string.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.ManBatOutput>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MinigameFinished;
    /// <summary>
    /// Function: MinigameFinished
    /// </summary>
    public unsafe override void MinigameFinished(bool was_successful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MinigameFinished, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.MinigameFinished", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(was_successful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateScreen;
    /// <summary>
    /// Function: CreateScreen
    /// </summary>
    public unsafe override void CreateScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateScreen, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.CreateScreen", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetFlashInIdleState;
    /// <summary>
    /// Function: SetFlashInIdleState
    /// </summary>
    public unsafe virtual void SetFlashInIdleState(bool is_idle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetFlashInIdleState, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.SetFlashInIdleState", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_idle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Update;
    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Update, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.Update", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGadgetsEnabled;
    /// <summary>
    /// Function: SetGadgetsEnabled
    /// </summary>
    public unsafe virtual void SetGadgetsEnabled(bool are_enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGadgetsEnabled, "BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.SetGadgetsEnabled", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(are_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ManBatOutput
    /// </summary>
    public enum ManBatOutput : byte
    {
        MBO_WaitingToBegin = 0,
        MBO_AnalysingLangstrom = 1,
        MBO_AnalysingBat = 2,
        MBO_AnalysingManBat = 3,
        MBO_ResequencerActive = 4,
        MBO_GameComplete = 5,
        MBO_MAX = 6,
    }

    /// <summary>
    /// ByteProperty: CurrentState
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.ManBatState CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.ManBatState>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ByteProperty: MostRecentIdle
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.ManBatOutput MostRecentIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_GFxMovieComputerMinigame_ManBat.ManBatOutput>(Ptr + 421); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 421); }
    }

    /// <summary>
    /// BoolProperty: GameInitialised
    /// </summary>
    public unsafe bool GameInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: GameComplete
    /// </summary>
    public unsafe bool GameComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: FlashInIdleState
    /// </summary>
    public unsafe bool FlashInIdleState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bUsingKeyboard
    /// </summary>
    public unsafe bool bUsingKeyboard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: FlashInIdleCountdown
    /// </summary>
    public unsafe float FlashInIdleCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ObjectProperty: AllTheSoundsPlayedFromTimeLine<br/>
    /// Default: Ww_UI_Manbat_Computer.UI_Manbat_Computer
    /// </summary>
    public unsafe BmSDK.Engine.AkBank AllTheSoundsPlayedFromTimeLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkBank>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// Enum: ManBatState
    /// </summary>
    public enum ManBatState : byte
    {
        MBS_Nothing = 0,
        MBS_Screensaver = 1,
        MBS_Desktop = 2,
        MBS_PlayingGame = 3,
        MBS_GameComplete = 4,
        MBS_CinematicVersion = 5,
        MBS_MAX = 6,
    }
}
