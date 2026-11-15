#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnPlayerBatgirl<br/>
/// (size = 10504)
/// (flags = 10486326)
/// </summary>
public partial class MPawnPlayerBatgirl : BmSDK.BmGame.MPawnPlayerBatgirlBase, BmSDK.BmGame.RXrayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnPlayerBatgirl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnPlayerBatgirl.
    /// </summary>
    public static MPawnPlayerBatgirl DefaultObject => (MPawnPlayerBatgirl)StaticClass().DefaultObject;

    internal MPawnPlayerBatgirl() { }

    /// <summary>
    /// Constructs a new MPawnPlayerBatgirl
    /// </summary>
    public MPawnPlayerBatgirl(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnPlayerBatgirl(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirl>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirl>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirl>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirl>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirl>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirl>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirl>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirl>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnSuperBatclawSlam;
    /// <summary>
    /// Function: SpawnSuperBatclawSlam
    /// </summary>
    public unsafe override void SpawnSuperBatclawSlam(BmSDK.BmGame.RPawnCombat TargetPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnSuperBatclawSlam, "BmScript.MPawnPlayerBatgirl.SpawnSuperBatclawSlam", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSentryGunAniminfo;
    /// <summary>
    /// Function: GetSentryGunAniminfo
    /// </summary>
    public unsafe override void GetSentryGunAniminfo(out BmSDK.Engine.AnimSet sentryGunAnimSet, out BmSDK.BmGame.RSpecialMoveConfig PlayerMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSentryGunAniminfo, "BmScript.MPawnPlayerBatgirl.GetSentryGunAniminfo", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayTannoyBarkResponse;
    /// <summary>
    /// Function: PlayTannoyBarkResponse
    /// </summary>
    public unsafe virtual void PlayTannoyBarkResponse(bool bInterrupted)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayTannoyBarkResponse, "BmScript.MPawnPlayerBatgirl.PlayTannoyBarkResponse", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInterrupted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyKilledForTannoy;
    /// <summary>
    /// Function: NotifyKilledForTannoy
    /// </summary>
    public unsafe override void NotifyKilledForTannoy(BmSDK.Engine.Pawn KilledPawn, BmSDK.BmGame.RBMRoomAIState RoomState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyKilledForTannoy, "BmScript.MPawnPlayerBatgirl.NotifyKilledForTannoy", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoomState, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyAfterRescue;
    /// <summary>
    /// Function: NotifyAfterRescue
    /// </summary>
    public unsafe override void NotifyAfterRescue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyAfterRescue, "BmScript.MPawnPlayerBatgirl.NotifyAfterRescue", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayAfterRescueBarks;
    /// <summary>
    /// Function: PlayAfterRescueBarks
    /// </summary>
    public unsafe virtual void PlayAfterRescueBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayAfterRescueBarks, "BmScript.MPawnPlayerBatgirl.PlayAfterRescueBarks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayHackInDangerAreaBarks;
    /// <summary>
    /// Function: PlayHackInDangerAreaBarks
    /// </summary>
    public unsafe override void PlayHackInDangerAreaBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayHackInDangerAreaBarks, "BmScript.MPawnPlayerBatgirl.PlayHackInDangerAreaBarks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayBombHackBarks;
    /// <summary>
    /// Function: PlayBombHackBarks
    /// </summary>
    public unsafe override void PlayBombHackBarks(bool havePlayedIntro)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayBombHackBarks, "BmScript.MPawnPlayerBatgirl.PlayBombHackBarks", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(havePlayedIntro, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayDoubleTakedownBarks;
    /// <summary>
    /// Function: PlayDoubleTakedownBarks
    /// </summary>
    public unsafe virtual void PlayDoubleTakedownBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayDoubleTakedownBarks, "BmScript.MPawnPlayerBatgirl.PlayDoubleTakedownBarks", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayTakedownBarks, "BmScript.MPawnPlayerBatgirl.PlayTakedownBarks", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LockLastmanStandingTakedownBarks;
    /// <summary>
    /// Function: LockLastmanStandingTakedownBarks
    /// </summary>
    public unsafe virtual void LockLastmanStandingTakedownBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LockLastmanStandingTakedownBarks, "BmScript.MPawnPlayerBatgirl.LockLastmanStandingTakedownBarks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetSwingChuteSpecialMove;
    /// <summary>
    /// Function: SetSwingChuteSpecialMove
    /// </summary>
    public unsafe override void SetSwingChuteSpecialMove(out BmSDK.BmGame.RSpecialMoveConfig SwingMove, out BmSDK.BmGame.RSpecialMoveConfig GlideMove, out BmSDK.BmGame.RSpecialMoveConfig CrouchInMove, out BmSDK.BmGame.RSpecialMoveConfig RollOutOfChute)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetSwingChuteSpecialMove, "BmScript.MPawnPlayerBatgirl.SetSwingChuteSpecialMove", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SwingMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingMove, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GlideMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlideMove, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CrouchInMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CrouchInMove, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RollOutOfChute);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RollOutOfChute, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SwingMove = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
        GlideMove = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 8);
        CrouchInMove = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 16);
        RollOutOfChute = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetLadderSpecialMove;
    /// <summary>
    /// Function: SetLadderSpecialMove
    /// </summary>
    public unsafe override void SetLadderSpecialMove(out BmSDK.BmGame.RSpecialMoveConfig BatmanClimbRunMove, out BmSDK.BmGame.RSpecialMoveConfig BatmanClimbStandMove, out BmSDK.BmGame.RSpecialMoveConfig BatmanGrateMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetLadderSpecialMove, "BmScript.MPawnPlayerBatgirl.SetLadderSpecialMove", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmanClimbRunMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanClimbRunMove, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmanClimbStandMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanClimbStandMove, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmanGrateMove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanGrateMove, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BatmanClimbRunMove = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
        BatmanClimbStandMove = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 8);
        BatmanGrateMove = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetInHackableMode;
    /// <summary>
    /// Function: SetInHackableMode
    /// </summary>
    public unsafe virtual void SetInHackableMode(bool On, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInHackableMode, "BmScript.MPawnPlayerBatgirl.SetInHackableMode", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnScareComboTakedown;
    /// <summary>
    /// Function: SpawnScareComboTakedown
    /// </summary>
    public unsafe virtual bool SpawnScareComboTakedown(BmSDK.BmGame.RPawnVillain NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnScareComboTakedown, "BmScript.MPawnPlayerBatgirl.SpawnScareComboTakedown", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryStrike;
    /// <summary>
    /// Function: TryStrike
    /// </summary>
    public unsafe override bool TryStrike(float TimeInitiatedByPlayer = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryStrike, "BmScript.MPawnPlayerBatgirl.TryStrike", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideTakedownTarget;
    /// <summary>
    /// Function: OverrideTakedownTarget
    /// </summary>
    public unsafe override void OverrideTakedownTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideTakedownTarget, "BmScript.MPawnPlayerBatgirl.OverrideTakedownTarget", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideTakedown;
    /// <summary>
    /// Function: OverrideTakedown
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.EStealthTakeDownStages OverrideTakedown(BmSDK.FName StateName, BmSDK.BmGame.RPawnPlayer.FPlayerTakedownInfo Info, BmSDK.BmGame.RPawnVillain Victim, BmSDK.BmGame.RPawnVillain Victim2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideTakedown, "BmScript.MPawnPlayerBatgirl.OverrideTakedown", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim2, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(paramsPtr + 52);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsBatmanInsideWhipRappelVolume;
    /// <summary>
    /// Function: IsBatmanInsideWhipRappelVolume
    /// </summary>
    public unsafe virtual bool IsBatmanInsideWhipRappelVolume()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsBatmanInsideWhipRappelVolume, "BmScript.MPawnPlayerBatgirl.IsBatmanInsideWhipRappelVolume", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DropWeaponGrabbed;
    /// <summary>
    /// Function: DropWeaponGrabbed
    /// </summary>
    public unsafe override void DropWeaponGrabbed(bool IsRight, bool bForceInstant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DropWeaponGrabbed, "BmScript.MPawnPlayerBatgirl.DropWeaponGrabbed", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsRight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceInstant, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetWeaponGrabbed;
    /// <summary>
    /// Function: SetWeaponGrabbed
    /// </summary>
    public unsafe override void SetWeaponGrabbed(BmSDK.BmGame.RBMCombatThrownObject WeaponObject, bool IsRight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetWeaponGrabbed, "BmScript.MPawnPlayerBatgirl.SetWeaponGrabbed", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsRight, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowTakedownPrompt;
    /// <summary>
    /// Function: ShowTakedownPrompt
    /// </summary>
    public unsafe override void ShowTakedownPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, BmSDK.FStringArg TakedownPrompt, bool FearTDAvailable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowTakedownPrompt, "BmScript.MPawnPlayerBatgirl.ShowTakedownPrompt", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowFearTakedownPrompt, "BmScript.MPawnPlayerBatgirl.ShowFearTakedownPrompt", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PokeAdditivePipeAnimsIntoIdlePose;
    /// <summary>
    /// Function: PokeAdditivePipeAnimsIntoIdlePose
    /// </summary>
    public unsafe virtual void PokeAdditivePipeAnimsIntoIdlePose(BmSDK.BmGame.RWeaponConfig WeapConfig, bool bRemove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PokeAdditivePipeAnimsIntoIdlePose, "BmScript.MPawnPlayerBatgirl.PokeAdditivePipeAnimsIntoIdlePose", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeapConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRemove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPipeCombatAnimset;
    /// <summary>
    /// Function: GetPipeCombatAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetPipeCombatAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPipeCombatAnimset, "BmScript.MPawnPlayerBatgirl.GetPipeCombatAnimset", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFailedPairedAnimMoveAnimset;
    /// <summary>
    /// Function: GetFailedPairedAnimMoveAnimset
    /// </summary>
    public unsafe override void GetFailedPairedAnimMoveAnimset(out BmSDK.Engine.AnimSet MyAnimset, BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFailedPairedAnimMoveAnimset, "BmScript.MPawnPlayerBatgirl.GetFailedPairedAnimMoveAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MyAnimset);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MyAnimset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MyAnimset = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BreakNewGamePlusLine;
    /// <summary>
    /// Function: BreakNewGamePlusLine
    /// </summary>
    public unsafe virtual void BreakNewGamePlusLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BreakNewGamePlusLine, "BmScript.MPawnPlayerBatgirl.BreakNewGamePlusLine", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayWouldBreakNewGamePlusLine;
    /// <summary>
    /// Function: PlayWouldBreakNewGamePlusLine
    /// </summary>
    public unsafe override void PlayWouldBreakNewGamePlusLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayWouldBreakNewGamePlusLine, "BmScript.MPawnPlayerBatgirl.PlayWouldBreakNewGamePlusLine", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnTakedownAgainst, "BmScript.MPawnPlayerBatgirl.SpawnTakedownAgainst", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawningNextStage, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFearTakedown, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RStealthTakeDownStage>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnBatclawRedirect;
    /// <summary>
    /// Function: SpawnBatclawRedirect
    /// </summary>
    public unsafe override void SpawnBatclawRedirect(BmSDK.BmGame.RPawnCombat TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnBatclawRedirect, "BmScript.MPawnPlayerBatgirl.SpawnBatclawRedirect", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnBatclawSlam;
    /// <summary>
    /// Function: SpawnBatclawSlam
    /// </summary>
    public unsafe override void SpawnBatclawSlam(BmSDK.BmGame.RPawnCombat TargetPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnBatclawSlam, "BmScript.MPawnPlayerBatgirl.SpawnBatclawSlam", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayedHostageInDangerLine;
    /// <summary>
    /// Function: PlayedHostageInDangerLine
    /// </summary>
    public unsafe virtual void PlayedHostageInDangerLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayedHostageInDangerLine, "BmScript.MPawnPlayerBatgirl.PlayedHostageInDangerLine", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriedToUseGadgetOnHostageTaker;
    /// <summary>
    /// Function: TriedToUseGadgetOnHostageTaker
    /// </summary>
    public unsafe override void TriedToUseGadgetOnHostageTaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriedToUseGadgetOnHostageTaker, "BmScript.MPawnPlayerBatgirl.TriedToUseGadgetOnHostageTaker", this);
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasUpgrade, "BmScript.MPawnPlayerBatgirl.HasUpgrade", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUnlockedMeleeArmourLevel, "BmScript.MPawnPlayerBatgirl.GetUnlockedMeleeArmourLevel", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUnlockedBallisticArmourLevel, "BmScript.MPawnPlayerBatgirl.GetUnlockedBallisticArmourLevel", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPersistentMeleeArmour;
    /// <summary>
    /// Function: SetPersistentMeleeArmour
    /// </summary>
    public unsafe override void SetPersistentMeleeArmour(int armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPersistentMeleeArmour, "BmScript.MPawnPlayerBatgirl.SetPersistentMeleeArmour", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPersistentBallisticArmour;
    /// <summary>
    /// Function: SetPersistentBallisticArmour
    /// </summary>
    public unsafe override void SetPersistentBallisticArmour(int armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPersistentBallisticArmour, "BmScript.MPawnPlayerBatgirl.SetPersistentBallisticArmour", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPersistentMeleeArmour;
    /// <summary>
    /// Function: GetPersistentMeleeArmour
    /// </summary>
    public unsafe override int GetPersistentMeleeArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPersistentMeleeArmour, "BmScript.MPawnPlayerBatgirl.GetPersistentMeleeArmour", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPersistentBallisticArmour;
    /// <summary>
    /// Function: GetPersistentBallisticArmour
    /// </summary>
    public unsafe override int GetPersistentBallisticArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPersistentBallisticArmour, "BmScript.MPawnPlayerBatgirl.GetPersistentBallisticArmour", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GiveUnlockableGadget;
    /// <summary>
    /// Function: GiveUnlockableGadget
    /// </summary>
    public unsafe override void GiveUnlockableGadget(BmSDK.FName UnlockName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GiveUnlockableGadget, "BmScript.MPawnPlayerBatgirl.GiveUnlockableGadget", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ThrowFatalBatarang;
    /// <summary>
    /// Function: ThrowFatalBatarang
    /// </summary>
    public unsafe override void ThrowFatalBatarang(BmSDK.BmGame.RPawnVillain Victim, System.Numerics.Vector3 TargetLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ThrowFatalBatarang, "BmScript.MPawnPlayerBatgirl.ThrowFatalBatarang", this);
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateInvClass;
    /// <summary>
    /// Function: UpdateInvClass
    /// </summary>
    public unsafe override BmSDK.Class UpdateInvClass(BmSDK.Class InvClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateInvClass, "BmScript.MPawnPlayerBatgirl.UpdateInvClass", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InvClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InvestigateModeEyes;
    /// <summary>
    /// Function: InvestigateModeEyes
    /// </summary>
    public unsafe override void InvestigateModeEyes(bool bOnOrOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InvestigateModeEyes, "BmScript.MPawnPlayerBatgirl.InvestigateModeEyes", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EyeMaterialUpdated;
    /// <summary>
    /// Function: EyeMaterialUpdated
    /// </summary>
    public unsafe override void EyeMaterialUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EyeMaterialUpdated, "BmScript.MPawnPlayerBatgirl.EyeMaterialUpdated", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnPossessed;
    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe override void UnPossessed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnPossessed, "BmScript.MPawnPlayerBatgirl.UnPossessed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PossessedBy;
    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe override void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PossessedBy, "BmScript.MPawnPlayerBatgirl.PossessedBy", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetSwitchCharacterInXray;
    /// <summary>
    /// Function: SetSwitchCharacterInXray
    /// </summary>
    public unsafe virtual void SetSwitchCharacterInXray(bool On, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetSwitchCharacterInXray, "BmScript.MPawnPlayerBatgirl.SetSwitchCharacterInXray", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeFallingDamage;
    /// <summary>
    /// Function: TakeFallingDamage
    /// </summary>
    public unsafe override void TakeFallingDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeFallingDamage, "BmScript.MPawnPlayerBatgirl.TakeFallingDamage", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DebugGiveFreezeBlast;
    /// <summary>
    /// Function: DebugGiveFreezeBlast
    /// </summary>
    public unsafe override void DebugGiveFreezeBlast()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DebugGiveFreezeBlast, "BmScript.MPawnPlayerBatgirl.DebugGiveFreezeBlast", this);
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DebugGiveAllGadgets, "BmScript.MPawnPlayerBatgirl.DebugGiveAllGadgets", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDefaultInventoryAfterInit;
    /// <summary>
    /// Function: AddDefaultInventoryAfterInit
    /// </summary>
    public unsafe override void AddDefaultInventoryAfterInit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDefaultInventoryAfterInit, "BmScript.MPawnPlayerBatgirl.AddDefaultInventoryAfterInit", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDefaultInventory, "BmScript.MPawnPlayerBatgirl.AddDefaultInventory", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetOwnerNoSee;
    /// <summary>
    /// Function: SetOwnerNoSee
    /// </summary>
    public unsafe override void SetOwnerNoSee(bool bNewOwnerNoSee)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetOwnerNoSee, "BmScript.MPawnPlayerBatgirl.SetOwnerNoSee", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewOwnerNoSee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPlayerHasBeenMoved;
    /// <summary>
    /// Function: OnPlayerHasBeenMoved
    /// </summary>
    public unsafe override void OnPlayerHasBeenMoved()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPlayerHasBeenMoved, "BmScript.MPawnPlayerBatgirl.OnPlayerHasBeenMoved", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AttachTransparentSkeletalMesh;
    /// <summary>
    /// Function: AttachTransparentSkeletalMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent AttachTransparentSkeletalMesh(BmSDK.Engine.SkeletalMesh SkeletalMesh, BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent, BmSDK.Engine.MaterialInterface OverrideMaterial = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AttachTransparentSkeletalMesh, "BmScript.MPawnPlayerBatgirl.AttachTransparentSkeletalMesh", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentAnimComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaterial, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RemoveCloakingAura;
    /// <summary>
    /// Function: RemoveCloakingAura
    /// </summary>
    public unsafe virtual void RemoveCloakingAura()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveCloakingAura, "BmScript.MPawnPlayerBatgirl.RemoveCloakingAura", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ActivateCloakingAura;
    /// <summary>
    /// Function: ActivateCloakingAura
    /// </summary>
    public unsafe virtual void ActivateCloakingAura(BmSDK.Engine.MaterialInterface AuraMat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ActivateCloakingAura, "BmScript.MPawnPlayerBatgirl.ActivateCloakingAura", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuraMat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerHeatConcealEffect;
    /// <summary>
    /// Function: TriggerHeatConcealEffect
    /// </summary>
    public unsafe override void TriggerHeatConcealEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerHeatConcealEffect, "BmScript.MPawnPlayerBatgirl.TriggerHeatConcealEffect", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.MPawnPlayerBatgirl.Tick", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnIceSphere;
    /// <summary>
    /// Function: SpawnIceSphere
    /// </summary>
    public unsafe override BmSDK.Engine.FogVolumeSphericalDensityInfo SpawnIceSphere(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnIceSphere, "BmScript.MPawnPlayerBatgirl.SpawnIceSphere", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.FogVolumeSphericalDensityInfo>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.MPawnPlayerBatgirl.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckDemonDeath;
    /// <summary>
    /// Function: CheckDemonDeath
    /// </summary>
    public unsafe virtual bool CheckDemonDeath(BmSDK.Engine.Actor HitObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckDemonDeath, "BmScript.MPawnPlayerBatgirl.CheckDemonDeath", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitObj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateFingers;
    /// <summary>
    /// Function: UpdateFingers
    /// </summary>
    public unsafe virtual void UpdateFingers(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateFingers, "BmScript.MPawnPlayerBatgirl.UpdateFingers", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EndFingerEffectInstant;
    /// <summary>
    /// Function: EndFingerEffectInstant
    /// </summary>
    public unsafe virtual void EndFingerEffectInstant()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EndFingerEffectInstant, "BmScript.MPawnPlayerBatgirl.EndFingerEffectInstant", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EndFingerEffect;
    /// <summary>
    /// Function: EndFingerEffect
    /// </summary>
    public unsafe virtual void EndFingerEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EndFingerEffect, "BmScript.MPawnPlayerBatgirl.EndFingerEffect", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoFingerEffect;
    /// <summary>
    /// Function: DoFingerEffect
    /// </summary>
    public unsafe virtual void DoFingerEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoFingerEffect, "BmScript.MPawnPlayerBatgirl.DoFingerEffect", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetupPlayerSpecificCombatAnimsets, "BmScript.MPawnPlayerBatgirl.SetupPlayerSpecificCombatAnimsets", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PreBeginPlay, "BmScript.MPawnPlayerBatgirl.PreBeginPlay", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: OverrideWalkSpeed
    /// </summary>
    public unsafe float OverrideWalkSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10308); }
    }

    /// <summary>
    /// FloatProperty: OverrideRunSpeed<br/>
    /// Default: 500
    /// </summary>
    public unsafe float OverrideRunSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10312); }
    }

    /// <summary>
    /// FloatProperty: OverrideStealthSpeed<br/>
    /// Default: 492.96
    /// </summary>
    public unsafe float OverrideStealthSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10316); }
    }

    /// <summary>
    /// BoolProperty: bTempDebugReAddDefaultInventory
    /// </summary>
    public unsafe bool bTempDebugReAddDefaultInventory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10320); }
    }

    /// <summary>
    /// BoolProperty: TurningFingersOn
    /// </summary>
    public unsafe bool TurningFingersOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10320); }
    }

    /// <summary>
    /// BoolProperty: TurningFingersOff
    /// </summary>
    public unsafe bool TurningFingersOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10320); }
    }

    /// <summary>
    /// BoolProperty: bSwitchCharInXRay
    /// </summary>
    public unsafe bool bSwitchCharInXRay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10320); }
    }

    /// <summary>
    /// BoolProperty: bTannoyResponseHasPlayed
    /// </summary>
    public unsafe bool bTannoyResponseHasPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10320); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10320); }
    }

    /// <summary>
    /// FloatProperty: CloakingDuration<br/>
    /// Default: 4
    /// </summary>
    public unsafe float CloakingDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10324); }
    }

    /// <summary>
    /// FloatProperty: CloakingBlend<br/>
    /// Default: 1
    /// </summary>
    public unsafe float CloakingBlend
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10328); }
    }

    /// <summary>
    /// ObjectProperty: FaceMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant FaceMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10332); }
    }

    /// <summary>
    /// ObjectProperty: CloakingMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CloakingMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10340); }
    }

    /// <summary>
    /// ObjectProperty: Map2DRef<br/>
    /// Default: Map_CoreDLCBatgirl.Map_DLCOilrig
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie Map2DRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 10348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10348); }
    }

    /// <summary>
    /// ObjectProperty: TakedownConversation<br/>
    /// Default: Dlc_Bg_Barks_Char_Bg_Takedown.Conversation.Dlc_Bg_Barks_Char_Bg_Takedown
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation TakedownConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10356); }
    }

    /// <summary>
    /// ObjectProperty: DoubleTakedownConversation<br/>
    /// Default: DLC_Bg_Barks_Char_Bg_Doubletakedown.Conversation.DLC_Bg_Barks_Char_Bg_Doubletakedown
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation DoubleTakedownConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10364); }
    }

    /// <summary>
    /// ObjectProperty: BombHackIntroConversation<br/>
    /// Default: DLC_Bg_Barks_Char_Bg_Bombhackbegin.Conversation.DLC_Bg_Barks_Char_Bg_Bombhackbegin
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation BombHackIntroConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10372); }
    }

    /// <summary>
    /// ObjectProperty: BombHackProgressConversation<br/>
    /// Default: DLC_Bg_Barks_Char_Hq_Bombhackprogress.Conversation.DLC_Bg_Barks_Char_Hq_Bombhackprogress
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation BombHackProgressConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10380); }
    }

    /// <summary>
    /// ObjectProperty: HackInDangerAreaConversation<br/>
    /// Default: DLC_BG_BARKS_CHAR_BG_HACK_DANGER.Conversation.DLC_BG_BARKS_CHAR_BG_HACK_DANGER
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation HackInDangerAreaConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10388); }
    }

    /// <summary>
    /// ObjectProperty: AfterRescueConversation<br/>
    /// Default: DLC_BG_BARKS_CHAR_BG_WINDY.Conversation.DLC_BG_BARKS_CHAR_BG_WINDY
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation AfterRescueConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10396); }
    }

    /// <summary>
    /// ComponentProperty: FingersMesh<br/>
    /// Default: BmScript.Default__MPawnPlayerBatgirl.FingersMesh1
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FingersMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10404); }
    }

    /// <summary>
    /// ComponentProperty: CatwomanInteractions<br/>
    /// Default: BmScript.Default__MPawnPlayerBatgirl.Interactions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent CatwomanInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 10412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10412); }
    }

    /// <summary>
    /// ComponentProperty: HackingViewCapeMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HackingViewCapeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10420); }
    }

    /// <summary>
    /// ComponentProperty: HackingViewSecondaryMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HackingViewSecondaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10428); }
    }

    /// <summary>
    /// ComponentProperty: HackingViewMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HackingViewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10436); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraCapeMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CloakingAuraCapeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10444); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraSecondaryMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CloakingAuraSecondaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10452); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CloakingAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10460); }
    }

    /// <summary>
    /// ClassProperty: IceSphereClass<br/>
    /// Default: BmScript.RFreezeBlastIceSphere
    /// </summary>
    public unsafe BmSDK.Class IceSphereClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 10468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10468); }
    }

    /// <summary>
    /// ArrayProperty: IceSpheres
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RFreezeBlastIceSphere> IceSpheres
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RFreezeBlastIceSphere>>(Ptr + 10476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10476); }
    }

    /// <summary>
    /// IntProperty: MaxIceSpheres<br/>
    /// Default: 4
    /// </summary>
    public unsafe int MaxIceSpheres
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10492); }
    }

    /// <summary>
    /// FloatProperty: CurrentFingerTime
    /// </summary>
    public unsafe float CurrentFingerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10496); }
    }

    /// <summary>
    /// FloatProperty: DelayBetweenLastmanStandingTakedownBarks<br/>
    /// Default: 5
    /// </summary>
    public unsafe float DelayBetweenLastmanStandingTakedownBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10500); }
    }
}
