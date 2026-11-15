#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnPlayerHarleyQuinn<br/>
/// (size = 11020)
/// (flags = 10485814)
/// </summary>
public partial class MPawnPlayerHarleyQuinn : BmSDK.BmGame.MPawnPlayerHarleyQuinnBase, BmSDK.BmGame.RXrayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnPlayerHarleyQuinn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnPlayerHarleyQuinn.
    /// </summary>
    public static MPawnPlayerHarleyQuinn DefaultObject => (MPawnPlayerHarleyQuinn)StaticClass().DefaultObject;

    internal MPawnPlayerHarleyQuinn() { }

    /// <summary>
    /// Constructs a new MPawnPlayerHarleyQuinn
    /// </summary>
    public MPawnPlayerHarleyQuinn(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnPlayerHarleyQuinn(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinn>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinn>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinn>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinn>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinn>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinn>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinn>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinn>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanUseGrateChutes;
    /// <summary>
    /// Function: CanUseGrateChutes
    /// </summary>
    public unsafe override bool CanUseGrateChutes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanUseGrateChutes, "BmScript.MPawnPlayerHarleyQuinn.CanUseGrateChutes", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSentryGunAniminfo;
    /// <summary>
    /// Function: GetSentryGunAniminfo
    /// </summary>
    public unsafe override void GetSentryGunAniminfo(out BmSDK.Engine.AnimSet sentryGunAnimSet, out BmSDK.BmGame.RSpecialMoveConfig PlayerMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSentryGunAniminfo, "BmScript.MPawnPlayerHarleyQuinn.GetSentryGunAniminfo", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out sentryGunAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sentryGunAnimSet, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerMove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        sentryGunAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        PlayerMove = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySpottedBark;
    /// <summary>
    /// Function: PlaySpottedBark
    /// </summary>
    public unsafe override bool PlaySpottedBark(BmSDK.BmGame.RPawnVillain Villain, BmSDK.BmGame.RAlertEventCoordinatorBase AEC, BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase.FBarkFlag> BarkFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySpottedBark, "BmScript.MPawnPlayerHarleyQuinn.PlaySpottedBark", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkFlags, paramsPtr + 16);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe override void OnLevelChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnLevelChange, "BmScript.MPawnPlayerHarleyQuinn.OnLevelChange", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnMayhemComboTakedown;
    /// <summary>
    /// Function: SpawnMayhemComboTakedown
    /// </summary>
    public unsafe virtual bool SpawnMayhemComboTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnMayhemComboTakedown, "BmScript.MPawnPlayerHarleyQuinn.SpawnMayhemComboTakedown", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryStrike;
    /// <summary>
    /// Function: TryStrike
    /// </summary>
    public unsafe override bool TryStrike(float TimeInitiatedByPlayer = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryStrike, "BmScript.MPawnPlayerHarleyQuinn.TryStrike", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMayhemPrompt;
    /// <summary>
    /// Function: GetMayhemPrompt
    /// </summary>
    public unsafe override void GetMayhemPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMayhemPrompt, "BmScript.MPawnPlayerHarleyQuinn.GetMayhemPrompt", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowAttracMayhemModeMeter;
    /// <summary>
    /// Function: ShowAttracMayhemModeMeter
    /// </summary>
    public unsafe override void ShowAttracMayhemModeMeter(bool Enable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowAttracMayhemModeMeter, "BmScript.MPawnPlayerHarleyQuinn.ShowAttracMayhemModeMeter", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMayhemMeterHUDAnims;
    /// <summary>
    /// Function: UpdateMayhemMeterHUDAnims
    /// </summary>
    public unsafe virtual void UpdateMayhemMeterHUDAnims(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMayhemMeterHUDAnims, "BmScript.MPawnPlayerHarleyQuinn.UpdateMayhemMeterHUDAnims", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMayhemMeterHUD;
    /// <summary>
    /// Function: UpdateMayhemMeterHUD
    /// </summary>
    public unsafe override void UpdateMayhemMeterHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMayhemMeterHUD, "BmScript.MPawnPlayerHarleyQuinn.UpdateMayhemMeterHUD", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitMayhemMeterHUD;
    /// <summary>
    /// Function: InitMayhemMeterHUD
    /// </summary>
    public unsafe override void InitMayhemMeterHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitMayhemMeterHUD, "BmScript.MPawnPlayerHarleyQuinn.InitMayhemMeterHUD", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnterCinematicMode;
    /// <summary>
    /// Function: EnterCinematicMode
    /// </summary>
    public unsafe override void EnterCinematicMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnterCinematicMode, "BmScript.MPawnPlayerHarleyQuinn.EnterCinematicMode", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInMayhemTransition;
    /// <summary>
    /// Function: IsInMayhemTransition
    /// </summary>
    public unsafe virtual void IsInMayhemTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInMayhemTransition, "BmScript.MPawnPlayerHarleyQuinn.IsInMayhemTransition", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayCharacterBark;
    /// <summary>
    /// Function: PlayCharacterBark
    /// </summary>
    public unsafe override void PlayCharacterBark(BmSDK.Engine.AkDialogueConversation aBark, bool bRejectIfInterruptsAnySpeech = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayCharacterBark, "BmScript.MPawnPlayerHarleyQuinn.PlayCharacterBark", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aBark, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRejectIfInterruptsAnySpeech, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayIdleConversation;
    /// <summary>
    /// Function: PlayIdleConversation
    /// </summary>
    public unsafe virtual void PlayIdleConversation(out BmSDK.TArray<BmSDK.Engine.AkDialogueConversation> IdleConversations, bool bChooseRandomIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayIdleConversation, "BmScript.MPawnPlayerHarleyQuinn.PlayIdleConversation", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChooseRandomIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IdleConversations = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.AkDialogueConversation>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayIdleBarks;
    /// <summary>
    /// Function: PlayIdleBarks
    /// </summary>
    public unsafe virtual void PlayIdleBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayIdleBarks, "BmScript.MPawnPlayerHarleyQuinn.PlayIdleBarks", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayAttackBarks;
    /// <summary>
    /// Function: PlayAttackBarks
    /// </summary>
    public unsafe virtual void PlayAttackBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayAttackBarks, "BmScript.MPawnPlayerHarleyQuinn.PlayAttackBarks", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayGrabbedBarks;
    /// <summary>
    /// Function: PlayGrabbedBarks
    /// </summary>
    public unsafe virtual void PlayGrabbedBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayGrabbedBarks, "BmScript.MPawnPlayerHarleyQuinn.PlayGrabbedBarks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayCounterBarks;
    /// <summary>
    /// Function: PlayCounterBarks
    /// </summary>
    public unsafe virtual void PlayCounterBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayCounterBarks, "BmScript.MPawnPlayerHarleyQuinn.PlayCounterBarks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayBatBarks;
    /// <summary>
    /// Function: PlayBatBarks
    /// </summary>
    public unsafe virtual void PlayBatBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayBatBarks, "BmScript.MPawnPlayerHarleyQuinn.PlayBatBarks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayTakedownBarks;
    /// <summary>
    /// Function: PlayTakedownBarks
    /// </summary>
    public unsafe virtual void PlayTakedownBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayTakedownBarks, "BmScript.MPawnPlayerHarleyQuinn.PlayTakedownBarks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnTakedownAgainst;
    /// <summary>
    /// Function: SpawnTakedownAgainst
    /// </summary>
    public unsafe override BmSDK.BmGame.RStealthTakeDownStage SpawnTakedownAgainst(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages takedown, BmSDK.BmGame.RPawnVillain Victim, bool bSpawningNextStage = default, bool bFearTakedown = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnTakedownAgainst, "BmScript.MPawnPlayerHarleyQuinn.SpawnTakedownAgainst", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawningNextStage, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFearTakedown, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RStealthTakeDownStage>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowTakedownPrompt;
    /// <summary>
    /// Function: ShowTakedownPrompt
    /// </summary>
    public unsafe override void ShowTakedownPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, BmSDK.FStringArg TakedownPrompt, bool FearTDAvailable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowTakedownPrompt, "BmScript.MPawnPlayerHarleyQuinn.ShowTakedownPrompt", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        TakedownPrompt.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FearTDAvailable, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowFearTakedownPrompt;
    /// <summary>
    /// Function: ShowFearTakedownPrompt
    /// </summary>
    public unsafe override bool ShowFearTakedownPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bCurrentTakedownTargetAllowFearTakedown, BmSDK.BmGame.RPawnVillain CurrentTakedownTarget2, bool bEnoughEnergyForAFearTakedown, BmSDK.BmGame.RGameInfo.EStealthTakeDownStages FearTakedownType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowFearTakedownPrompt, "BmScript.MPawnPlayerHarleyQuinn.ShowFearTakedownPrompt", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentTakedownTargetAllowFearTakedown, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentTakedownTarget2, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnoughEnergyForAFearTakedown, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FearTakedownType, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PounceOnThug;
    /// <summary>
    /// Function: PounceOnThug
    /// </summary>
    public unsafe override void PounceOnThug(BmSDK.BmGame.RPawnVillain Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PounceOnThug, "BmScript.MPawnPlayerHarleyQuinn.PounceOnThug", this);
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnEquipBaseBallBat;
    /// <summary>
    /// Function: UnEquipBaseBallBat
    /// </summary>
    public unsafe override void UnEquipBaseBallBat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnEquipBaseBallBat, "BmScript.MPawnPlayerHarleyQuinn.UnEquipBaseBallBat", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EquipBaseBallBat;
    /// <summary>
    /// Function: EquipBaseBallBat
    /// </summary>
    public unsafe virtual void EquipBaseBallBat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EquipBaseBallBat, "BmScript.MPawnPlayerHarleyQuinn.EquipBaseBallBat", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ActivateDamageProxy;
    /// <summary>
    /// Function: ActivateDamageProxy
    /// </summary>
    public unsafe virtual void ActivateDamageProxy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ActivateDamageProxy, "BmScript.MPawnPlayerHarleyQuinn.ActivateDamageProxy", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HoldOnBaseBallBat;
    /// <summary>
    /// Function: HoldOnBaseBallBat
    /// </summary>
    public unsafe override void HoldOnBaseBallBat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HoldOnBaseBallBat, "BmScript.MPawnPlayerHarleyQuinn.HoldOnBaseBallBat", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearIgnoreUnequipBaseBallBat;
    /// <summary>
    /// Function: ClearIgnoreUnequipBaseBallBat
    /// </summary>
    public unsafe virtual void ClearIgnoreUnequipBaseBallBat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearIgnoreUnequipBaseBallBat, "BmScript.MPawnPlayerHarleyQuinn.ClearIgnoreUnequipBaseBallBat", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnequipJITB;
    /// <summary>
    /// Function: UnequipJITB
    /// </summary>
    public unsafe virtual void UnequipJITB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnequipJITB, "BmScript.MPawnPlayerHarleyQuinn.UnequipJITB", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EquipJITB;
    /// <summary>
    /// Function: EquipJITB
    /// </summary>
    public unsafe virtual void EquipJITB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EquipJITB, "BmScript.MPawnPlayerHarleyQuinn.EquipJITB", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasUpgrade;
    /// <summary>
    /// Function: HasUpgrade
    /// </summary>
    public unsafe override bool HasUpgrade(BmSDK.FStringArg UpgradeFlag)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasUpgrade, "BmScript.MPawnPlayerHarleyQuinn.HasUpgrade", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UpgradeFlag.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUnlockedMeleeArmourLevel;
    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedMeleeArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUnlockedMeleeArmourLevel, "BmScript.MPawnPlayerHarleyQuinn.GetUnlockedMeleeArmourLevel", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUnlockedBallisticArmourLevel;
    /// <summary>
    /// Function: GetUnlockedBallisticArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedBallisticArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUnlockedBallisticArmourLevel, "BmScript.MPawnPlayerHarleyQuinn.GetUnlockedBallisticArmourLevel", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStunMove;
    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe override BmSDK.Class GetStunMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStunMove, "BmScript.MPawnPlayerHarleyQuinn.GetStunMove", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HopOffVantagePoint;
    /// <summary>
    /// Function: HopOffVantagePoint
    /// </summary>
    public unsafe override void HopOffVantagePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HopOffVantagePoint, "BmScript.MPawnPlayerHarleyQuinn.HopOffVantagePoint", this);
        byte* paramsPtr = stackalloc byte[240];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitPawnEffect;
    /// <summary>
    /// Function: InitPawnEffect
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnEffectComponent InitPawnEffect(BmSDK.BmGame.RPawnVillain Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitPawnEffect, "BmScript.MPawnPlayerHarleyQuinn.InitPawnEffect", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnEffectComponent>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.MPawnPlayerHarleyQuinn.Tick", this);
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyTutorialCompleted;
    /// <summary>
    /// Function: NotifyTutorialCompleted
    /// </summary>
    public unsafe override void NotifyTutorialCompleted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyTutorialCompleted, "BmScript.MPawnPlayerHarleyQuinn.NotifyTutorialCompleted", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShotBy;
    /// <summary>
    /// Function: ShotBy
    /// </summary>
    public unsafe override void ShotBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, System.Numerics.Vector3 HitLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShotBy, "BmScript.MPawnPlayerHarleyQuinn.ShotBy", this);
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 248);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DodgeBulletsExit;
    /// <summary>
    /// Function: DodgeBulletsExit
    /// </summary>
    public unsafe virtual void DodgeBulletsExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DodgeBulletsExit, "BmScript.MPawnPlayerHarleyQuinn.DodgeBulletsExit", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DodgeBullets;
    /// <summary>
    /// Function: DodgeBullets
    /// </summary>
    public unsafe virtual void DodgeBullets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DodgeBullets, "BmScript.MPawnPlayerHarleyQuinn.DodgeBullets", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DebugGiveAllGadgets;
    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe override void DebugGiveAllGadgets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DebugGiveAllGadgets, "BmScript.MPawnPlayerHarleyQuinn.DebugGiveAllGadgets", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDefaultInventory;
    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe override void AddDefaultInventory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDefaultInventory, "BmScript.MPawnPlayerHarleyQuinn.AddDefaultInventory", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckDetonateTarget;
    /// <summary>
    /// Function: CheckDetonateTarget
    /// </summary>
    public unsafe override void CheckDetonateTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckDetonateTarget, "BmScript.MPawnPlayerHarleyQuinn.CheckDetonateTarget", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeDamage, "BmScript.MPawnPlayerHarleyQuinn.TakeDamage", this);
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldPlayHitReaction;
    /// <summary>
    /// Function: ShouldPlayHitReaction
    /// </summary>
    public unsafe override bool ShouldPlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.Class RangedDmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldPlayHitReaction, "BmScript.MPawnPlayerHarleyQuinn.ShouldPlayHitReaction", this);
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RangedDmgType, paramsPtr + 248);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 256);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeFallingDamage;
    /// <summary>
    /// Function: TakeFallingDamage
    /// </summary>
    public unsafe override void TakeFallingDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeFallingDamage, "BmScript.MPawnPlayerHarleyQuinn.TakeFallingDamage", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerMayhemAlert;
    /// <summary>
    /// Function: TriggerMayhemAlert
    /// </summary>
    public unsafe virtual void TriggerMayhemAlert()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerMayhemAlert, "BmScript.MPawnPlayerHarleyQuinn.TriggerMayhemAlert", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMaterialsForMayhem;
    /// <summary>
    /// Function: UpdateMaterialsForMayhem
    /// </summary>
    public unsafe virtual void UpdateMaterialsForMayhem()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMaterialsForMayhem, "BmScript.MPawnPlayerHarleyQuinn.UpdateMaterialsForMayhem", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMayhemPP;
    /// <summary>
    /// Function: UpdateMayhemPP
    /// </summary>
    public unsafe virtual void UpdateMayhemPP(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMayhemPP, "BmScript.MPawnPlayerHarleyQuinn.UpdateMayhemPP", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ActivateHarleyOnSpeedFX;
    /// <summary>
    /// Function: ActivateHarleyOnSpeedFX
    /// </summary>
    public unsafe virtual void ActivateHarleyOnSpeedFX(bool bActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ActivateHarleyOnSpeedFX, "BmScript.MPawnPlayerHarleyQuinn.ActivateHarleyOnSpeedFX", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerMayhemModeChangedEvents;
    /// <summary>
    /// Function: TriggerMayhemModeChangedEvents
    /// </summary>
    public unsafe virtual void TriggerMayhemModeChangedEvents(bool bCausedByCineMode = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerMayhemModeChangedEvents, "BmScript.MPawnPlayerHarleyQuinn.TriggerMayhemModeChangedEvents", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCausedByCineMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ActivateMayhemMode;
    /// <summary>
    /// Function: ActivateMayhemMode
    /// </summary>
    public unsafe override void ActivateMayhemMode(bool bActive, bool bForce = default, bool bCausedByCineMode = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ActivateMayhemMode, "BmScript.MPawnPlayerHarleyQuinn.ActivateMayhemMode", this);
        byte* paramsPtr = stackalloc byte[176];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCausedByCineMode, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetInMayhemMode;
    /// <summary>
    /// Function: SetInMayhemMode
    /// </summary>
    public unsafe virtual void SetInMayhemMode(bool On)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInMayhemMode, "BmScript.MPawnPlayerHarleyQuinn.SetInMayhemMode", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMayhemMode;
    /// <summary>
    /// Function: UpdateMayhemMode
    /// </summary>
    public unsafe virtual void UpdateMayhemMode(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMayhemMode, "BmScript.MPawnPlayerHarleyQuinn.UpdateMayhemMode", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanReceiveAttackFromPawn, "BmScript.MPawnPlayerHarleyQuinn.CanReceiveAttackFromPawn", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldDeactivateMayhemMode;
    /// <summary>
    /// Function: ShouldDeactivateMayhemMode
    /// </summary>
    public unsafe override bool ShouldDeactivateMayhemMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldDeactivateMayhemMode, "BmScript.MPawnPlayerHarleyQuinn.ShouldDeactivateMayhemMode", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FinishFightTimer;
    /// <summary>
    /// Function: FinishFightTimer
    /// </summary>
    public unsafe virtual void FinishFightTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FinishFightTimer, "BmScript.MPawnPlayerHarleyQuinn.FinishFightTimer", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool On, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInXrayMode, "BmScript.MPawnPlayerHarleyQuinn.SetInXrayMode", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetupPlayerSpecificCombatAnimsets;
    /// <summary>
    /// Function: SetupPlayerSpecificCombatAnimsets
    /// </summary>
    public unsafe override void SetupPlayerSpecificCombatAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetupPlayerSpecificCombatAnimsets, "BmScript.MPawnPlayerHarleyQuinn.SetupPlayerSpecificCombatAnimsets", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Destroyed, "BmScript.MPawnPlayerHarleyQuinn.Destroyed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.MPawnPlayerHarleyQuinn.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: MayhemBarkLockTime<br/>
    /// Default: 3
    /// </summary>
    public unsafe float MayhemBarkLockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10664); }
    }

    /// <summary>
    /// ObjectProperty: PounceLandFX<br/>
    /// Default: PFX_Catwoman.Particles.pounce_climb
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PounceLandFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10668); }
    }

    /// <summary>
    /// ObjectProperty: PounceHardLandFX<br/>
    /// Default: PFX_Catwoman.Particles.pounce_impact
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PounceHardLandFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10676); }
    }

    /// <summary>
    /// ObjectProperty: HairMaterialInst<br/>
    /// Default: Catwoman.Materials.Catwoman_Hair_Blend_Anisotropy_Mat_INST
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HairMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10684); }
    }

    /// <summary>
    /// ObjectProperty: HairCWC1MaterialInst<br/>
    /// Default: Character_Shared.Materials.Catwoman_Hair_Blend_intro_INST
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HairCWC1MaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10692); }
    }

    /// <summary>
    /// ObjectProperty: StandMayhemModeSpecialMove<br/>
    /// Default: WBGMDLC_HarleyQuinn_Special_Moves.MayhemModeActivate_Stand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StandMayhemModeSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 10700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10700); }
    }

    /// <summary>
    /// ObjectProperty: RailingMayhemModeSpecialMove<br/>
    /// Default: WBGMDLC_HarleyQuinn_Special_Moves.MayhemModeActivate_Railing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingMayhemModeSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 10708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10708); }
    }

    /// <summary>
    /// ObjectProperty: HarleyOnSpeedFX<br/>
    /// Default: Zeppelin_World_Shaders.ParticleSystem.HarleyOnSpeed
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HarleyOnSpeedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10716); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: HarleyOnSpeedFXComps
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> HarleyOnSpeedFXComps => new(4, Ptr + 10724, 8, this);

    /// <summary>
    /// ComponentProperty: HarleyOnSpeedFXComps
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HarleyOnSpeedFXComps_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 10724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10724); }
    }
    /// <summary>
    /// ComponentProperty: HarleyOnSpeedFXComps
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HarleyOnSpeedFXComps_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 10732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10732); }
    }
    /// <summary>
    /// ComponentProperty: HarleyOnSpeedFXComps
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HarleyOnSpeedFXComps_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 10740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10740); }
    }
    /// <summary>
    /// ComponentProperty: HarleyOnSpeedFXComps
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HarleyOnSpeedFXComps_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 10748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10748); }
    }

    /// <summary>
    /// ComponentProperty: XrayHairMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayHairMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10756); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskBaseBallBatMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskBaseBallBatMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10764); }
    }

    /// <summary>
    /// ComponentProperty: BaseBallBat<br/>
    /// Default: BmScript.Default__MPawnPlayerHarleyQuinn.BaseBallBat0
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BaseBallBat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10772); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceInterrogation
    /// </summary>
    public unsafe bool bDebugForceInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bAllowDeathCoughSpeech
    /// </summary>
    public unsafe bool bAllowDeathCoughSpeech
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bDieOnCeilingsOnly
    /// </summary>
    public unsafe bool bDieOnCeilingsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bForceInstantDeath
    /// </summary>
    public unsafe bool bForceInstantDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: IsUsingBaseBallBat
    /// </summary>
    public unsafe bool IsUsingBaseBallBat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreUnequipBaseBallBat
    /// </summary>
    public unsafe bool bIgnoreUnequipBaseBallBat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bPsychoIdleStartDone
    /// </summary>
    public unsafe bool bPsychoIdleStartDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bCanInterruptBark
    /// </summary>
    public unsafe bool bCanInterruptBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bShouldDeactivateMayhemMode
    /// </summary>
    public unsafe bool bShouldDeactivateMayhemMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bFinishedFight<br/>
    /// Default: true
    /// </summary>
    public unsafe bool bFinishedFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bMayhemMeterInitDone
    /// </summary>
    public unsafe bool bMayhemMeterInitDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bVerifyForGrappleResets
    /// </summary>
    public unsafe bool bVerifyForGrappleResets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bIsInTunnel
    /// </summary>
    public unsafe bool bIsInTunnel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// BoolProperty: bHasMayhemTakedownTarget
    /// </summary>
    public unsafe bool bHasMayhemTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10780); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10780); }
    }

    /// <summary>
    /// StructProperty: CoughTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CoughTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 10784);

    /// <summary>
    /// ArrayProperty: SkinMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> SkinMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 10788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10788); }
    }

    /// <summary>
    /// NameProperty: OWBrightnessMaterialParameterName<br/>
    /// Default: CW_OW_Brightness_Multiplier
    /// </summary>
    public unsafe BmSDK.FName OWBrightnessMaterialParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10804); }
    }

    /// <summary>
    /// FloatProperty: BrightnessIndoors<br/>
    /// Default: 1
    /// </summary>
    public unsafe float BrightnessIndoors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10812); }
    }

    /// <summary>
    /// FloatProperty: BrightnessOutdoors<br/>
    /// Default: 3
    /// </summary>
    public unsafe float BrightnessOutdoors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10816); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: HarleyOnSpeedFXBones
    /// </summary>
    public InlineArray<BmSDK.FName> HarleyOnSpeedFXBones => new(4, Ptr + 10820, 8, this);

    /// <summary>
    /// NameProperty: HarleyOnSpeedFXBones<br/>
    /// Default: Bip01_L_Hand
    /// </summary>
    public unsafe BmSDK.FName HarleyOnSpeedFXBones_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10820); }
    }
    /// <summary>
    /// NameProperty: HarleyOnSpeedFXBones<br/>
    /// Default: Bip01_R_Hand
    /// </summary>
    public unsafe BmSDK.FName HarleyOnSpeedFXBones_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10828); }
    }
    /// <summary>
    /// NameProperty: HarleyOnSpeedFXBones<br/>
    /// Default: Bip01_L_Foot
    /// </summary>
    public unsafe BmSDK.FName HarleyOnSpeedFXBones_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10836); }
    }
    /// <summary>
    /// NameProperty: HarleyOnSpeedFXBones<br/>
    /// Default: Bip01_R_Foot
    /// </summary>
    public unsafe BmSDK.FName HarleyOnSpeedFXBones_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10844); }
    }

    /// <summary>
    /// StructProperty: MayhemModeCameraShake<br/>
    /// Default: (TimeDuration=2.2,LocAmplitude=(X=20,Y=20,Z=20),LocFrequency=(X=20,Y=20,Z=20),RotAmplitude=(X=200,Y=50,Z=50),RotFrequency=(X=5.5,Y=5.5,Z=5.5),FOVMultiplier=1,FOVFrequency=5,AdvancedOptions=(FalloffMin...
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct MayhemModeCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 10852);

    /// <summary>
    /// FloatProperty: NoGrappleElapsedTime
    /// </summary>
    public unsafe float NoGrappleElapsedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11008); }
    }

    /// <summary>
    /// FloatProperty: checkTimerForTunnel
    /// </summary>
    public unsafe float checkTimerForTunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11012); }
    }

    /// <summary>
    /// FloatProperty: checkTimerForMayhemTakedownTarget
    /// </summary>
    public unsafe float checkTimerForMayhemTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11016); }
    }
}
