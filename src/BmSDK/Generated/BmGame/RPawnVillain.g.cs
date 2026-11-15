#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnVillain<br/>
/// (size = 6664)
/// (flags = 144703671)
/// </summary>
public partial class RPawnVillain : BmSDK.BmGame.RPawnSpeech, BmSDK.BmGame.RSpotableInterface, BmSDK.BmGame.RBatarangableInterface, BmSDK.BmGame.RJammerInterface, BmSDK.BmGame.RInteractInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillain.
    /// </summary>
    public static RPawnVillain DefaultObject => (RPawnVillain)StaticClass().DefaultObject;

    internal RPawnVillain() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillain(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeRedirected;
    /// <summary>
    /// Function: CanBeRedirected
    /// </summary>
    public unsafe override bool CanBeRedirected()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeRedirected, "BmGame.RPawnVillain.CanBeRedirected", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanDetonateGelBomb;
    /// <summary>
    /// Function: CanDetonateGelBomb
    /// </summary>
    public unsafe virtual bool CanDetonateGelBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanDetonateGelBomb, "BmGame.RPawnVillain.CanDetonateGelBomb", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForcePickupTarget;
    /// <summary>
    /// Function: ForcePickupTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain ForcePickupTarget(BmSDK.BmGame.RPawnVillain OldTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForcePickupTarget, "BmGame.RPawnVillain.ForcePickupTarget", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GrateDetectionExtender;
    /// <summary>
    /// Function: GrateDetectionExtender
    /// </summary>
    public unsafe virtual float GrateDetectionExtender()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GrateDetectionExtender, "BmGame.RPawnVillain.GrateDetectionExtender", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyAttackTriggerResult;
    /// <summary>
    /// Function: NotifyAttackTriggerResult
    /// </summary>
    public unsafe virtual void NotifyAttackTriggerResult(bool bSuccess)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyAttackTriggerResult, "BmGame.RPawnVillain.NotifyAttackTriggerResult", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetIncapacitatedCantSpeakReason;
    /// <summary>
    /// Function: GetIncapacitatedCantSpeakReason
    /// </summary>
    public unsafe override BmSDK.FString GetIncapacitatedCantSpeakReason()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetIncapacitatedCantSpeakReason, "BmGame.RPawnVillain.GetIncapacitatedCantSpeakReason", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CombatantShouldRunFromBatmobile;
    /// <summary>
    /// Function: CombatantShouldRunFromBatmobile
    /// </summary>
    public unsafe virtual bool CombatantShouldRunFromBatmobile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CombatantShouldRunFromBatmobile, "BmGame.RPawnVillain.CombatantShouldRunFromBatmobile", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceNearbyThugsIntoCombat;
    /// <summary>
    /// Function: ForceNearbyThugsIntoCombat
    /// </summary>
    public unsafe virtual void ForceNearbyThugsIntoCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceNearbyThugsIntoCombat, "BmGame.RPawnVillain.ForceNearbyThugsIntoCombat", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldForceNearbyThugsIntoCombatWhenAttackedByBatman;
    /// <summary>
    /// Function: ShouldForceNearbyThugsIntoCombatWhenAttackedByBatman
    /// </summary>
    public unsafe virtual bool ShouldForceNearbyThugsIntoCombatWhenAttackedByBatman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldForceNearbyThugsIntoCombatWhenAttackedByBatman, "BmGame.RPawnVillain.ShouldForceNearbyThugsIntoCombatWhenAttackedByBatman", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldForceIntoCombatWhenAttackedByBatman;
    /// <summary>
    /// Function: ShouldForceIntoCombatWhenAttackedByBatman
    /// </summary>
    public unsafe virtual bool ShouldForceIntoCombatWhenAttackedByBatman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldForceIntoCombatWhenAttackedByBatman, "BmGame.RPawnVillain.ShouldForceIntoCombatWhenAttackedByBatman", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceIntoCombat;
    /// <summary>
    /// Function: ForceIntoCombat
    /// </summary>
    public unsafe virtual void ForceIntoCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceIntoCombat, "BmGame.RPawnVillain.ForceIntoCombat", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBeatdownCombatMoveClass;
    /// <summary>
    /// Function: GetBeatdownCombatMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetBeatdownCombatMoveClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBeatdownCombatMoveClass, "BmGame.RPawnVillain.GetBeatdownCombatMoveClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShootProjectile;
    /// <summary>
    /// Function: ShootProjectile
    /// </summary>
    public unsafe virtual void ShootProjectile(BmSDK.Engine.Actor ProjectileToShoot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShootProjectile, "BmGame.RPawnVillain.ShootProjectile", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileToShoot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FinishedGetUp;
    /// <summary>
    /// Function: FinishedGetUp
    /// </summary>
    public unsafe override void FinishedGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FinishedGetUp, "BmGame.RPawnVillain.FinishedGetUp", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetBombThug;
    /// <summary>
    /// Function: ResetBombThug
    /// </summary>
    public unsafe virtual void ResetBombThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetBombThug, "BmGame.RPawnVillain.ResetBombThug", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BombThugScanningStopped;
    /// <summary>
    /// Function: BombThugScanningStopped
    /// </summary>
    public unsafe virtual void BombThugScanningStopped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BombThugScanningStopped, "BmGame.RPawnVillain.BombThugScanningStopped", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BombThugScanningStarted;
    /// <summary>
    /// Function: BombThugScanningStarted
    /// </summary>
    public unsafe virtual void BombThugScanningStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BombThugScanningStarted, "BmGame.RPawnVillain.BombThugScanningStarted", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BombThugScanned;
    /// <summary>
    /// Function: BombThugScanned
    /// </summary>
    public unsafe virtual void BombThugScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BombThugScanned, "BmGame.RPawnVillain.BombThugScanned", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PotentialBombThugScanned;
    /// <summary>
    /// Function: PotentialBombThugScanned
    /// </summary>
    public unsafe virtual bool PotentialBombThugScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PotentialBombThugScanned, "BmGame.RPawnVillain.PotentialBombThugScanned", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasBeenScannedForBombThug;
    /// <summary>
    /// Function: HasBeenScannedForBombThug
    /// </summary>
    public unsafe virtual bool HasBeenScannedForBombThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasBeenScannedForBombThug, "BmGame.RPawnVillain.HasBeenScannedForBombThug", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BombThugRanAway;
    /// <summary>
    /// Function: BombThugRanAway
    /// </summary>
    public unsafe virtual void BombThugRanAway()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BombThugRanAway, "BmGame.RPawnVillain.BombThugRanAway", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetBombThugController;
    /// <summary>
    /// Function: SetBombThugController
    /// </summary>
    public unsafe virtual void SetBombThugController(BmSDK.BmGame.RSeqAct_ActivateBombThugRiots ControllerAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetBombThugController, "BmGame.RPawnVillain.SetBombThugController", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetWeaponFlag;
    /// <summary>
    /// Function: GetWeaponFlag
    /// </summary>
    public unsafe virtual BmSDK.FName GetWeaponFlag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetWeaponFlag, "BmGame.RPawnVillain.GetWeaponFlag", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMyBarkSpeaker;
    /// <summary>
    /// Function: GetMyBarkSpeaker
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetMyBarkSpeaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMyBarkSpeaker, "BmGame.RPawnVillain.GetMyBarkSpeaker", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayCombatBark;
    /// <summary>
    /// Function: PlayCombatBark
    /// </summary>
    public unsafe override void PlayCombatBark(BmSDK.FName EventName, bool bUseWeapon, BmSDK.BmGame.RBMWeapon OverrideWeapon = default, BmSDK.FName OverrideWeaponFlag = default, BmSDK.BmGame.RBarkValDef.FlagTypeEnum FlagType = default, BmSDK.FName FlagValue = default, BmSDK.BmGame.RPawnPlayer OverridePlayer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayCombatBark, "BmGame.RPawnVillain.PlayCombatBark", this);
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseWeapon, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideWeapon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideWeaponFlag, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagType, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagValue, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePlayer, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayCombatBarkTaunt;
    /// <summary>
    /// Function: PlayCombatBarkTaunt
    /// </summary>
    public unsafe virtual void PlayCombatBarkTaunt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayCombatBarkTaunt, "BmGame.RPawnVillain.PlayCombatBarkTaunt", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddCustomPawnCombatBarkFlags;
    /// <summary>
    /// Function: AddCustomPawnCombatBarkFlags
    /// </summary>
    public unsafe virtual void AddCustomPawnCombatBarkFlags(out BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddCustomPawnCombatBarkFlags, "BmGame.RPawnVillain.AddCustomPawnCombatBarkFlags", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ContextFlags);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContextFlags = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBatmanHitThisFight;
    /// <summary>
    /// Function: GetBatmanHitThisFight
    /// </summary>
    public unsafe virtual bool GetBatmanHitThisFight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBatmanHitThisFight, "BmGame.RPawnVillain.GetBatmanHitThisFight", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTirednessState;
    /// <summary>
    /// Function: GetTirednessState
    /// </summary>
    public unsafe virtual BmSDK.FName GetTirednessState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTirednessState, "BmGame.RPawnVillain.GetTirednessState", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateForMayhem;
    /// <summary>
    /// Function: UpdateForMayhem
    /// </summary>
    public unsafe virtual void UpdateForMayhem(bool bUseMayhem, BmSDK.Engine.MaterialInterface MayhemMaterial)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateForMayhem, "BmGame.RPawnVillain.UpdateForMayhem", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseMayhem, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MayhemMaterial, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateMayhemMaskMesh;
    /// <summary>
    /// Function: CreateMayhemMaskMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent CreateMayhemMaskMesh(BmSDK.Engine.SkeletalMeshComponent Template, BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent, BmSDK.Engine.MaterialInterface Material)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateMayhemMaskMesh, "BmGame.RPawnVillain.CreateMayhemMaskMesh", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentAnimComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Material, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldBeIncludedInFinalBlowCamCheck;
    /// <summary>
    /// Function: ShouldBeIncludedInFinalBlowCamCheck
    /// </summary>
    public unsafe virtual bool ShouldBeIncludedInFinalBlowCamCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldBeIncludedInFinalBlowCamCheck, "BmGame.RPawnVillain.ShouldBeIncludedInFinalBlowCamCheck", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetXrayLightColor;
    /// <summary>
    /// Function: GetXrayLightColor
    /// </summary>
    public unsafe override BmSDK.GameObject.FColor GetXrayLightColor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetXrayLightColor, "BmGame.RPawnVillain.GetXrayLightColor", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FColor>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRiddlerTrophy;
    /// <summary>
    /// Function: GetRiddlerTrophy
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetRiddlerTrophy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRiddlerTrophy, "BmGame.RPawnVillain.GetRiddlerTrophy", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RiddlerTrophyPickedUpByPlayer;
    /// <summary>
    /// Function: RiddlerTrophyPickedUpByPlayer
    /// </summary>
    public unsafe virtual void RiddlerTrophyPickedUpByPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RiddlerTrophyPickedUpByPlayer, "BmGame.RPawnVillain.RiddlerTrophyPickedUpByPlayer", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DropRiddlerTrophy;
    /// <summary>
    /// Function: DropRiddlerTrophy
    /// </summary>
    public unsafe virtual void DropRiddlerTrophy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DropRiddlerTrophy, "BmGame.RPawnVillain.DropRiddlerTrophy", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PickupRiddlerTrophy;
    /// <summary>
    /// Function: PickupRiddlerTrophy
    /// </summary>
    public unsafe virtual void PickupRiddlerTrophy(BmSDK.BmGame.RPickup_Riddler Trophy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PickupRiddlerTrophy, "BmGame.RPawnVillain.PickupRiddlerTrophy", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Trophy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasCustomTargetingMinCosAngle;
    /// <summary>
    /// Function: HasCustomTargetingMinCosAngle
    /// </summary>
    public unsafe virtual bool HasCustomTargetingMinCosAngle(out float OutMinCosAngle, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasCustomTargetingMinCosAngle, "BmGame.RPawnVillain.HasCustomTargetingMinCosAngle", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutMinCosAngle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutMinCosAngle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutMinCosAngle = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanAerialAttack;
    /// <summary>
    /// Function: CanAerialAttack
    /// </summary>
    public unsafe virtual bool CanAerialAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanAerialAttack, "BmGame.RPawnVillain.CanAerialAttack", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanWeaponBeGrabbed;
    /// <summary>
    /// Function: CanWeaponBeGrabbed
    /// </summary>
    public unsafe virtual bool CanWeaponBeGrabbed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanWeaponBeGrabbed, "BmGame.RPawnVillain.CanWeaponBeGrabbed", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BeingPickedUpByPlayer;
    /// <summary>
    /// Function: BeingPickedUpByPlayer
    /// </summary>
    public unsafe virtual void BeingPickedUpByPlayer(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RCombatMove PickupMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeingPickedUpByPlayer, "BmGame.RPawnVillain.BeingPickedUpByPlayer", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupMove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HoldCameraOnMeAfterStrike;
    /// <summary>
    /// Function: HoldCameraOnMeAfterStrike
    /// </summary>
    public unsafe virtual bool HoldCameraOnMeAfterStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HoldCameraOnMeAfterStrike, "BmGame.RPawnVillain.HoldCameraOnMeAfterStrike", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowLongRangeInteraction;
    /// <summary>
    /// Function: AllowLongRangeInteraction
    /// </summary>
    public unsafe virtual bool AllowLongRangeInteraction(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowLongRangeInteraction, "BmGame.RPawnVillain.AllowLongRangeInteraction", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GlideKickNoiseResponse;
    /// <summary>
    /// Function: GlideKickNoiseResponse
    /// </summary>
    public unsafe virtual void GlideKickNoiseResponse(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GlideKickNoiseResponse, "BmGame.RPawnVillain.GlideKickNoiseResponse", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanRepelAttack;
    /// <summary>
    /// Function: CanRepelAttack
    /// </summary>
    public unsafe override bool CanRepelAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanRepelAttack, "BmGame.RPawnVillain.CanRepelAttack", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanRepel;
    /// <summary>
    /// Function: CanRepel
    /// </summary>
    public unsafe override bool CanRepel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanRepel, "BmGame.RPawnVillain.CanRepel", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanRepelAttacksFromBehind;
    /// <summary>
    /// Function: CanRepelAttacksFromBehind
    /// </summary>
    public unsafe override bool CanRepelAttacksFromBehind()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanRepelAttacksFromBehind, "BmGame.RPawnVillain.CanRepelAttacksFromBehind", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WarnAboutRiotSurpressorShot;
    /// <summary>
    /// Function: WarnAboutRiotSurpressorShot
    /// </summary>
    public unsafe virtual void WarnAboutRiotSurpressorShot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WarnAboutRiotSurpressorShot, "BmGame.RPawnVillain.WarnAboutRiotSurpressorShot", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetEnvironmentObjectTakedownPriority;
    /// <summary>
    /// Function: GetEnvironmentObjectTakedownPriority
    /// </summary>
    public unsafe virtual float GetEnvironmentObjectTakedownPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetEnvironmentObjectTakedownPriority, "BmGame.RPawnVillain.GetEnvironmentObjectTakedownPriority", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBeatdownHitReactionName;
    /// <summary>
    /// Function: GetBeatdownHitReactionName
    /// </summary>
    public unsafe virtual BmSDK.FName GetBeatdownHitReactionName(BmSDK.FName DefaultName, BmSDK.Class StrikeDmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBeatdownHitReactionName, "BmGame.RPawnVillain.GetBeatdownHitReactionName", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldComboTakedownKill;
    /// <summary>
    /// Function: ShouldComboTakedownKill
    /// </summary>
    public unsafe virtual bool ShouldComboTakedownKill(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldComboTakedownKill, "BmGame.RPawnVillain.ShouldComboTakedownKill", this);
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetOverrideTakedownInfo;
    /// <summary>
    /// Function: GetOverrideTakedownInfo
    /// </summary>
    public unsafe virtual bool GetOverrideTakedownInfo(BmSDK.BmGame.RPawnPlayerCombat Attacker, out BmSDK.BmGame.RPawnPlayerCombat.ETakedownType takedownType, out System.Numerics.Vector3 TakedownLocation, out BmSDK.Rotator TakedownRotation, out int DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetOverrideTakedownInfo, "BmGame.RPawnVillain.GetOverrideTakedownInfo", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out takedownType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedownType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TakedownLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownLocation, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TakedownRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownRotation, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DamageAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        takedownType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat.ETakedownType>(paramsPtr + 8);
        TakedownLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        TakedownRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 24);
        DamageAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceReversedThugPickup;
    /// <summary>
    /// Function: ForceReversedThugPickup
    /// </summary>
    public unsafe virtual bool ForceReversedThugPickup(System.Numerics.Vector3 PickupPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceReversedThugPickup, "BmGame.RPawnVillain.ForceReversedThugPickup", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverridePickupThugDirection;
    /// <summary>
    /// Function: OverridePickupThugDirection
    /// </summary>
    public unsafe virtual int OverridePickupThugDirection(int SuggestedDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverridePickupThugDirection, "BmGame.RPawnVillain.OverridePickupThugDirection", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SuggestedDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanRepelDuringHitReaction;
    /// <summary>
    /// Function: CanRepelDuringHitReaction
    /// </summary>
    public unsafe virtual bool CanRepelDuringHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo NewDmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanRepelDuringHitReaction, "BmGame.RPawnVillain.CanRepelDuringHitReaction", this);
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanAerialRedirect;
    /// <summary>
    /// Function: CanAerialRedirect
    /// </summary>
    public unsafe virtual bool CanAerialRedirect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanAerialRedirect, "BmGame.RPawnVillain.CanAerialRedirect", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAerialAttackClass;
    /// <summary>
    /// Function: GetAerialAttackClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetAerialAttackClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAerialAttackClass, "BmGame.RPawnVillain.GetAerialAttackClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsSickOfImpacts;
    /// <summary>
    /// Function: IsSickOfImpacts
    /// </summary>
    public unsafe virtual bool IsSickOfImpacts(out int HitChainLength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsSickOfImpacts, "BmGame.RPawnVillain.IsSickOfImpacts", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitChainLength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitChainLength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitChainLength = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddToGadgetProjectileImpactHistory;
    /// <summary>
    /// Function: AddToGadgetProjectileImpactHistory
    /// </summary>
    public unsafe virtual void AddToGadgetProjectileImpactHistory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddToGadgetProjectileImpactHistory, "BmGame.RPawnVillain.AddToGadgetProjectileImpactHistory", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RagdollOnREC;
    /// <summary>
    /// Function: RagdollOnREC
    /// </summary>
    public unsafe virtual bool RagdollOnREC()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RagdollOnREC, "BmGame.RPawnVillain.RagdollOnREC", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnSpawnHitParticles;
    /// <summary>
    /// Function: OnSpawnHitParticles
    /// </summary>
    public unsafe virtual void OnSpawnHitParticles(bool StrongHit, bool FinalBlow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnSpawnHitParticles, "BmGame.RPawnVillain.OnSpawnHitParticles", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrongHit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalBlow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetCanOnlyBeHitBy;
    /// <summary>
    /// Function: SetCanOnlyBeHitBy
    /// </summary>
    public unsafe virtual void SetCanOnlyBeHitBy(BmSDK.FName OnlyHitBy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetCanOnlyBeHitBy, "BmGame.RPawnVillain.SetCanOnlyBeHitBy", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyHitBy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeLocationOverride;
    /// <summary>
    /// Function: GetStrikeLocationOverride
    /// </summary>
    public unsafe virtual bool GetStrikeLocationOverride(BmSDK.BmGame.RPawnPlayerCombat Attacker, out System.Numerics.Vector3 OverrideLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeLocationOverride, "BmGame.RPawnVillain.GetStrikeLocationOverride", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverrideLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OverrideLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsDualStrikable;
    /// <summary>
    /// Function: IsDualStrikable
    /// </summary>
    public unsafe virtual bool IsDualStrikable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsDualStrikable, "BmGame.RPawnVillain.IsDualStrikable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanUseEnvironmentBeatdownEnd;
    /// <summary>
    /// Function: CanUseEnvironmentBeatdownEnd
    /// </summary>
    public unsafe virtual bool CanUseEnvironmentBeatdownEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanUseEnvironmentBeatdownEnd, "BmGame.RPawnVillain.CanUseEnvironmentBeatdownEnd", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMultiAttackAnimSets;
    /// <summary>
    /// Function: GetMultiAttackAnimSets
    /// </summary>
    public unsafe virtual void GetMultiAttackAnimSets(BmSDK.BmGame.RPawnCombat PlayerPawn, out BmSDK.Engine.AnimSet VillainAnimSet, out BmSDK.Engine.AnimSet PlayerAnimset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMultiAttackAnimSets, "BmGame.RPawnVillain.GetMultiAttackAnimSets", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out VillainAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainAnimSet, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerAnimset);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerAnimset, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        VillainAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        PlayerAnimset = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMultiAttackAnimNames;
    /// <summary>
    /// Function: GetMultiAttackAnimNames
    /// </summary>
    public unsafe virtual void GetMultiAttackAnimNames(out BmSDK.FName IntroName, out BmSDK.FName AttackName, out BmSDK.FName FailName, out BmSDK.FName CounterName, BmSDK.BmGame.RPawnPlayerCombat Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMultiAttackAnimNames, "BmGame.RPawnVillain.GetMultiAttackAnimNames", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntroName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntroName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AttackName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackName, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FailName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailName, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CounterName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IntroName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        AttackName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        FailName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
        CounterName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddHeadsetToProps;
    /// <summary>
    /// Function: AddHeadsetToProps
    /// </summary>
    public unsafe virtual void AddHeadsetToProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddHeadsetToProps, "BmGame.RPawnVillain.AddHeadsetToProps", this);
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetHasHeadset;
    /// <summary>
    /// Function: SetHasHeadset
    /// </summary>
    public unsafe override void SetHasHeadset(bool HasHeadset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetHasHeadset, "BmGame.RPawnVillain.SetHasHeadset", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HasHeadset, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartTargetedCustomStrike;
    /// <summary>
    /// Function: StartTargetedCustomStrike
    /// </summary>
    public unsafe virtual bool StartTargetedCustomStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartTargetedCustomStrike, "BmGame.RPawnVillain.StartTargetedCustomStrike", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFootstepNotify;
    /// <summary>
    /// Function: OnFootstepNotify
    /// </summary>
    public unsafe override void OnFootstepNotify(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, BmSDK.BmGame.RAnimNotify_Footstep.EFootstepSurfaceFinder SurfaceFinder, System.Numerics.Vector3 FootLocation, float BlendWeight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFootstepNotify, "BmGame.RPawnVillain.OnFootstepNotify", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SurfaceFinder, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendWeight, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearLastValidBatmobileTakedownPos;
    /// <summary>
    /// Function: ClearLastValidBatmobileTakedownPos
    /// </summary>
    public unsafe virtual void ClearLastValidBatmobileTakedownPos()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearLastValidBatmobileTakedownPos, "BmGame.RPawnVillain.ClearLastValidBatmobileTakedownPos", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsLastValidBatmobileTakedownPosValid;
    /// <summary>
    /// Function: IsLastValidBatmobileTakedownPosValid
    /// </summary>
    public unsafe virtual bool IsLastValidBatmobileTakedownPosValid()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsLastValidBatmobileTakedownPosValid, "BmGame.RPawnVillain.IsLastValidBatmobileTakedownPosValid", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsValidBatmobileTakedownTarget;
    /// <summary>
    /// Function: IsValidBatmobileTakedownTarget
    /// </summary>
    public unsafe virtual bool IsValidBatmobileTakedownTarget(BmSDK.BmGame.RPawnPlayerCombat AttackingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsValidBatmobileTakedownTarget, "BmGame.RPawnVillain.IsValidBatmobileTakedownTarget", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackingPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsValidGadgetTarget;
    /// <summary>
    /// Function: IsValidGadgetTarget
    /// </summary>
    public unsafe virtual bool IsValidGadgetTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsValidGadgetTarget, "BmGame.RPawnVillain.IsValidGadgetTarget", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldGoRagdollWhenHitByBaseballBat;
    /// <summary>
    /// Function: ShouldGoRagdollWhenHitByBaseballBat
    /// </summary>
    public unsafe virtual bool ShouldGoRagdollWhenHitByBaseballBat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldGoRagdollWhenHitByBaseballBat, "BmGame.RPawnVillain.ShouldGoRagdollWhenHitByBaseballBat", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetControlledByRobin;
    /// <summary>
    /// Function: SetControlledByRobin
    /// </summary>
    public unsafe virtual void SetControlledByRobin(BmSDK.BmGame.RPawnPlayer RobinPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetControlledByRobin, "BmGame.RPawnVillain.SetControlledByRobin", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RobinPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopCriticalFx;
    /// <summary>
    /// Function: StopCriticalFx
    /// </summary>
    public unsafe virtual void StopCriticalFx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopCriticalFx, "BmGame.RPawnVillain.StopCriticalFx", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartCriticalFx;
    /// <summary>
    /// Function: StartCriticalFx
    /// </summary>
    public unsafe virtual void StartCriticalFx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartCriticalFx, "BmGame.RPawnVillain.StartCriticalFx", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VillainPreAttackNotifyTriggered;
    /// <summary>
    /// Function: VillainPreAttackNotifyTriggered
    /// </summary>
    public unsafe virtual void VillainPreAttackNotifyTriggered(BmSDK.BmGame.RGameInfo.FVillainAttackInfo AttackInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VillainPreAttackNotifyTriggered, "BmGame.RPawnVillain.VillainPreAttackNotifyTriggered", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VillainAttackNotifyTriggered;
    /// <summary>
    /// Function: VillainAttackNotifyTriggered
    /// </summary>
    public unsafe virtual void VillainAttackNotifyTriggered(BmSDK.BmGame.RGameInfo.FVillainAttackInfo AttackInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VillainAttackNotifyTriggered, "BmGame.RPawnVillain.VillainAttackNotifyTriggered", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBePushedBy;
    /// <summary>
    /// Function: CanBePushedBy
    /// </summary>
    public unsafe virtual bool CanBePushedBy(BmSDK.BmGame.RPawnVillain Pusher)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBePushedBy, "BmGame.RPawnVillain.CanBePushedBy", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pusher, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanHelpUpThug;
    /// <summary>
    /// Function: CanHelpUpThug
    /// </summary>
    public unsafe virtual bool CanHelpUpThug(BmSDK.BmGame.RPawnVillain ThugInNeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanHelpUpThug, "BmGame.RPawnVillain.CanHelpUpThug", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugInNeed, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetForwardStepName;
    /// <summary>
    /// Function: GetForwardStepName
    /// </summary>
    public unsafe virtual BmSDK.FName GetForwardStepName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetForwardStepName, "BmGame.RPawnVillain.GetForwardStepName", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStepLength;
    /// <summary>
    /// Function: GetStepLength
    /// </summary>
    public unsafe virtual float GetStepLength()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStepLength, "BmGame.RPawnVillain.GetStepLength", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStepList;
    /// <summary>
    /// Function: GetStepList
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FName> GetStepList(bool bLongStep = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStepList, "BmGame.RPawnVillain.GetStepList", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLongStep, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCombatMovementAnimset;
    /// <summary>
    /// Function: GetCombatMovementAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetCombatMovementAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCombatMovementAnimset, "BmGame.RPawnVillain.GetCombatMovementAnimset", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInNonMedicPreventionVol;
    /// <summary>
    /// Function: IsInNonMedicPreventionVol
    /// </summary>
    public unsafe virtual bool IsInNonMedicPreventionVol()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInNonMedicPreventionVol, "BmGame.RPawnVillain.IsInNonMedicPreventionVol", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInValidPositionToBeChargedUp;
    /// <summary>
    /// Function: IsInValidPositionToBeChargedUp
    /// </summary>
    public unsafe virtual bool IsInValidPositionToBeChargedUp(BmSDK.BmGame.RPawnVillain Medic)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInValidPositionToBeChargedUp, "BmGame.RPawnVillain.IsInValidPositionToBeChargedUp", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medic, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeChargedUp;
    /// <summary>
    /// Function: CanBeChargedUp
    /// </summary>
    public unsafe virtual bool CanBeChargedUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeChargedUp, "BmGame.RPawnVillain.CanBeChargedUp", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopChargeUpVfxInternal;
    /// <summary>
    /// Function: StopChargeUpVfxInternal
    /// </summary>
    public unsafe virtual void StopChargeUpVfxInternal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopChargeUpVfxInternal, "BmGame.RPawnVillain.StopChargeUpVfxInternal", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartChargeUpVfxInternal;
    /// <summary>
    /// Function: StartChargeUpVfxInternal
    /// </summary>
    public unsafe virtual void StartChargeUpVfxInternal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartChargeUpVfxInternal, "BmGame.RPawnVillain.StartChargeUpVfxInternal", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartChargeUpVfx;
    /// <summary>
    /// Function: StartChargeUpVfx
    /// </summary>
    public unsafe virtual void StartChargeUpVfx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartChargeUpVfx, "BmGame.RPawnVillain.StartChargeUpVfx", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ChargeUpOver;
    /// <summary>
    /// Function: ChargeUpOver
    /// </summary>
    public unsafe virtual void ChargeUpOver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ChargeUpOver, "BmGame.RPawnVillain.ChargeUpOver", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ChargeUpStart;
    /// <summary>
    /// Function: ChargeUpStart
    /// </summary>
    public unsafe virtual void ChargeUpStart(BmSDK.BmGame.RPawnVillainThugMedic Medic)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ChargeUpStart, "BmGame.RPawnVillain.ChargeUpStart", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medic, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerRevivedEvents;
    /// <summary>
    /// Function: TriggerRevivedEvents
    /// </summary>
    public unsafe virtual void TriggerRevivedEvents(BmSDK.BmGame.RPawnVillain Casualty)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerRevivedEvents, "BmGame.RPawnVillain.TriggerRevivedEvents", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Casualty, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RevivedThug;
    /// <summary>
    /// Function: RevivedThug
    /// </summary>
    public unsafe virtual void RevivedThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RevivedThug, "BmGame.RPawnVillain.RevivedThug", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsLastMedicActionRevive;
    /// <summary>
    /// Function: IsLastMedicActionRevive
    /// </summary>
    public unsafe virtual bool IsLastMedicActionRevive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsLastMedicActionRevive, "BmGame.RPawnVillain.IsLastMedicActionRevive", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanReviveOtherThug;
    /// <summary>
    /// Function: CanReviveOtherThug
    /// </summary>
    public unsafe override bool CanReviveOtherThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanReviveOtherThug, "BmGame.RPawnVillain.CanReviveOtherThug", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BeingRevivedCancelled;
    /// <summary>
    /// Function: BeingRevivedCancelled
    /// </summary>
    public unsafe virtual void BeingRevivedCancelled(BmSDK.BmGame.RPawnVillain OldMedic)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeingRevivedCancelled, "BmGame.RPawnVillain.BeingRevivedCancelled", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldMedic, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BeingRevivedBy;
    /// <summary>
    /// Function: BeingRevivedBy
    /// </summary>
    public unsafe virtual void BeingRevivedBy(BmSDK.BmGame.RPawnVillain NewMedic)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeingRevivedBy, "BmGame.RPawnVillain.BeingRevivedBy", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMedic, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeRevivedByMedic;
    /// <summary>
    /// Function: CanBeRevivedByMedic
    /// </summary>
    public unsafe virtual bool CanBeRevivedByMedic(BmSDK.BmGame.RPawnVillain NewMedic, BmSDK.BmGame.RPawnCombat NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeRevivedByMedic, "BmGame.RPawnVillain.CanBeRevivedByMedic", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMedic, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SleepInPool;
    /// <summary>
    /// Function: SleepInPool
    /// </summary>
    public unsafe override bool SleepInPool(bool bForce = default, bool bStreamedOut = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SleepInPool, "BmGame.RPawnVillain.SleepInPool", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStreamedOut, paramsPtr + 4);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FinishWakingFromPool;
    /// <summary>
    /// Function: FinishWakingFromPool
    /// </summary>
    public unsafe override bool FinishWakingFromPool(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, BmSDK.Class WeaponClass, bool bRequiresNavMesh = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FinishWakingFromPool, "BmGame.RPawnVillain.FinishWakingFromPool", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequiresNavMesh, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WakeFromPool;
    /// <summary>
    /// Function: WakeFromPool
    /// </summary>
    public unsafe override bool WakeFromPool(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, BmSDK.Class WeaponClass, bool bRequiresNavMesh = default, bool bSetLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WakeFromPool, "BmGame.RPawnVillain.WakeFromPool", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequiresNavMesh, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetLocation, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WakeFromDead;
    /// <summary>
    /// Function: WakeFromDead
    /// </summary>
    public unsafe override void WakeFromDead(BmSDK.BmGame.RPawnCharacter NewGetUpMaster = default, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewGetUpMasterAnimID = default, BmSDK.Engine.AnimSet NewGetUpAnimset = default, BmSDK.FName NewGetUpAnimName = default, BmSDK.FName GetUpMovementStance = default, bool bDoAnim = default, bool bAnimImmediate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WakeFromDead, "BmGame.RPawnVillain.WakeFromDead", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpMaster, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpMasterAnimID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUpMovementStance, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoAnim, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAnimImmediate, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearExitVfx;
    /// <summary>
    /// Function: ClearExitVfx
    /// </summary>
    public unsafe virtual void ClearExitVfx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearExitVfx, "BmGame.RPawnVillain.ClearExitVfx", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPlayerPawnChanged;
    /// <summary>
    /// Function: OnPlayerPawnChanged
    /// </summary>
    public unsafe virtual void OnPlayerPawnChanged(BmSDK.BmGame.RPawnPlayer Pawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPlayerPawnChanged, "BmGame.RPawnVillain.OnPlayerPawnChanged", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DebugDrawDirection;
    /// <summary>
    /// Function: DebugDrawDirection
    /// </summary>
    public unsafe virtual void DebugDrawDirection(out BmSDK.BmGame.RPawnVillain.FLookAtDirection CurrLookAtDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DebugDrawDirection, "BmGame.RPawnVillain.DebugDrawDirection", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CurrLookAtDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain.FLookAtDirection>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLookAtDirections;
    /// <summary>
    /// Function: GetLookAtDirections
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FLookAtDirection> GetLookAtDirections(System.Numerics.Vector3 TestLoc, BmSDK.Rotator TestRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLookAtDirections, "BmGame.RPawnVillain.GetLookAtDirections", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FLookAtDirection>>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPotentialLookAtPoints;
    /// <summary>
    /// Function: GetPotentialLookAtPoints
    /// </summary>
    public unsafe virtual void GetPotentialLookAtPoints(System.Numerics.Vector3 TestLoc, BmSDK.Rotator TestRot, out BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FPotentialLookAtPoint> PotentialPoints, out float AvgDist)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPotentialLookAtPoints, "BmGame.RPawnVillain.GetPotentialLookAtPoints", this);
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRot, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AvgDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvgDist, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PotentialPoints = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FPotentialLookAtPoint>>(paramsPtr + 24);
        AvgDist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBestLookDirection;
    /// <summary>
    /// Function: GetBestLookDirection
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain.eLookDirection GetBestLookDirection(System.Numerics.Vector3 TestLoc, BmSDK.Rotator TestRot, out float AvgDists)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBestLookDirection, "BmGame.RPawnVillain.GetBestLookDirection", this);
        byte* paramsPtr = stackalloc byte[61];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRot, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AvgDists);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvgDists, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AvgDists = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain.eLookDirection>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLookDirectionDistances;
    /// <summary>
    /// Function: GetLookDirectionDistances
    /// </summary>
    public unsafe virtual void GetLookDirectionDistances(System.Numerics.Vector3 TestLoc, BmSDK.Rotator TestRot, out float AvgDists)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLookDirectionDistances, "BmGame.RPawnVillain.GetLookDirectionDistances", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRot, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AvgDists);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvgDists, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AvgDists = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SplitLookAtDirection;
    /// <summary>
    /// Function: SplitLookAtDirection
    /// </summary>
    public unsafe virtual bool SplitLookAtDirection(out BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FLookAtDirection> LookAtDirections, int Idx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SplitLookAtDirection, "BmGame.RPawnVillain.SplitLookAtDirection", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        LookAtDirections = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FLookAtDirection>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindLimitInDirection;
    /// <summary>
    /// Function: FindLimitInDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindLimitInDirection(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 Direction, float MaxDist, float CheckInc = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindLimitInDirection, "BmGame.RPawnVillain.FindLimitInDirection", this);
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckInc, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SnapLocationToGround;
    /// <summary>
    /// Function: SnapLocationToGround
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 SnapLocationToGround(System.Numerics.Vector3 BasePoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SnapLocationToGround, "BmGame.RPawnVillain.SnapLocationToGround", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BasePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCounterLimb;
    /// <summary>
    /// Function: GetCounterLimb
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.CounterLimb GetCounterLimb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCounterLimb, "BmGame.RPawnVillain.GetCounterLimb", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.CounterLimb>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowCounterAfterExitEnd;
    /// <summary>
    /// Function: AllowCounterAfterExitEnd
    /// </summary>
    public unsafe virtual void AllowCounterAfterExitEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowCounterAfterExitEnd, "BmGame.RPawnVillain.AllowCounterAfterExitEnd", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowCounterAfterExit;
    /// <summary>
    /// Function: AllowCounterAfterExit
    /// </summary>
    public unsafe virtual void AllowCounterAfterExit(BmSDK.BmGame.RGameInfo.CounterLimb NewCounterLimb)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowCounterAfterExit, "BmGame.RPawnVillain.AllowCounterAfterExit", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCounterLimb, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetCustomFloorCorrection;
    /// <summary>
    /// Function: ResetCustomFloorCorrection
    /// </summary>
    public unsafe virtual void ResetCustomFloorCorrection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetCustomFloorCorrection, "BmGame.RPawnVillain.ResetCustomFloorCorrection", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanSpeakIncapacitated;
    /// <summary>
    /// Function: CanSpeakIncapacitated
    /// </summary>
    public unsafe override bool CanSpeakIncapacitated(BmSDK.Engine.AkDialogueSpeech Speech)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanSpeakIncapacitated, "BmGame.RPawnVillain.CanSpeakIncapacitated", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speech, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WeaponSwitchCallback;
    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe override void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WeaponSwitchCallback, "BmGame.RPawnVillain.WeaponSwitchCallback", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DodgedProjectile;
    /// <summary>
    /// Function: DodgedProjectile
    /// </summary>
    public unsafe virtual void DodgedProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DodgedProjectile, "BmGame.RPawnVillain.DodgedProjectile", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReceiveCombatEvent;
    /// <summary>
    /// Function: ReceiveCombatEvent
    /// </summary>
    public unsafe virtual void ReceiveCombatEvent(BmSDK.BmGame.RPawnCombat EventInstigator, System.Numerics.Vector3 EventLocation, System.Numerics.Vector3 SightingLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReceiveCombatEvent, "BmGame.RPawnVillain.ReceiveCombatEvent", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SightingLocation, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsWatchingBatarang;
    /// <summary>
    /// Function: IsWatchingBatarang
    /// </summary>
    public unsafe virtual bool IsWatchingBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsWatchingBatarang, "BmGame.RPawnVillain.IsWatchingBatarang", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReenableCollisionWithPlayer;
    /// <summary>
    /// Function: ReenableCollisionWithPlayer
    /// </summary>
    public unsafe virtual void ReenableCollisionWithPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReenableCollisionWithPlayer, "BmGame.RPawnVillain.ReenableCollisionWithPlayer", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateFocusAura;
    /// <summary>
    /// Function: UpdateFocusAura
    /// </summary>
    public unsafe virtual void UpdateFocusAura(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateFocusAura, "BmGame.RPawnVillain.UpdateFocusAura", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnOffAura;
    /// <summary>
    /// Function: TurnOffAura
    /// </summary>
    public unsafe virtual void TurnOffAura()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnOffAura, "BmGame.RPawnVillain.TurnOffAura", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnOnAura;
    /// <summary>
    /// Function: TurnOnAura
    /// </summary>
    public unsafe virtual void TurnOnAura()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnOnAura, "BmGame.RPawnVillain.TurnOnAura", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetCannotBeTargettedByPlayer;
    /// <summary>
    /// Function: SetCannotBeTargettedByPlayer
    /// </summary>
    public unsafe override void SetCannotBeTargettedByPlayer(BmSDK.Engine.PlayerController PC, BmSDK.Engine.MaterialInstanceConstant FocusAuraMat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetCannotBeTargettedByPlayer, "BmGame.RPawnVillain.SetCannotBeTargettedByPlayer", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FocusAuraMat, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PauseAnimTimeScale;
    /// <summary>
    /// Function: PauseAnimTimeScale
    /// </summary>
    public unsafe virtual void PauseAnimTimeScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PauseAnimTimeScale, "BmGame.RPawnVillain.PauseAnimTimeScale", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RevertAnimTimeScale;
    /// <summary>
    /// Function: RevertAnimTimeScale
    /// </summary>
    public unsafe virtual void RevertAnimTimeScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RevertAnimTimeScale, "BmGame.RPawnVillain.RevertAnimTimeScale", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanSeeTargetBatmobile;
    /// <summary>
    /// Function: CanSeeTargetBatmobile
    /// </summary>
    public unsafe virtual bool CanSeeTargetBatmobile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanSeeTargetBatmobile, "BmGame.RPawnVillain.CanSeeTargetBatmobile", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanSeeTargetCombatPawn;
    /// <summary>
    /// Function: CanSeeTargetCombatPawn
    /// </summary>
    public unsafe virtual bool CanSeeTargetCombatPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanSeeTargetCombatPawn, "BmGame.RPawnVillain.CanSeeTargetCombatPawn", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetForceTaunting;
    /// <summary>
    /// Function: SetForceTaunting
    /// </summary>
    public unsafe virtual void SetForceTaunting(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetForceTaunting, "BmGame.RPawnVillain.SetForceTaunting", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanRecoverFromStunned;
    /// <summary>
    /// Function: CanRecoverFromStunned
    /// </summary>
    public unsafe virtual bool CanRecoverFromStunned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanRecoverFromStunned, "BmGame.RPawnVillain.CanRecoverFromStunned", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowGooInGodMode;
    /// <summary>
    /// Function: AllowGooInGodMode
    /// </summary>
    public unsafe virtual bool AllowGooInGodMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowGooInGodMode, "BmGame.RPawnVillain.AllowGooInGodMode", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_ImpactEmote;
    /// <summary>
    /// Function: PlaySound_ImpactEmote
    /// </summary>
    public unsafe virtual void PlaySound_ImpactEmote(bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bForceEmote = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_ImpactEmote, "BmGame.RPawnVillain.PlaySound_ImpactEmote", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceEmote, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_ImpactAI;
    /// <summary>
    /// Function: PlaySound_ImpactAI
    /// </summary>
    public unsafe override void PlaySound_ImpactAI(BmSDK.Engine.Actor playOn, bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bIsQuick = default, bool bPlayerAttacked = default, bool bForceEmote = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_ImpactAI, "BmGame.RPawnVillain.PlaySound_ImpactAI", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playOn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsQuick, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayerAttacked, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceEmote, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanSpawnPredatorFinaleCam;
    /// <summary>
    /// Function: CanSpawnPredatorFinaleCam
    /// </summary>
    public unsafe virtual bool CanSpawnPredatorFinaleCam(int NumTakenDown = default, bool bCanSpawnInCombat = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanSpawnPredatorFinaleCam, "BmGame.RPawnVillain.CanSpawnPredatorFinaleCam", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTakenDown, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanSpawnInCombat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDodgeMovementStance;
    /// <summary>
    /// Function: GetDodgeMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetDodgeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDodgeMovementStance, "BmGame.RPawnVillain.GetDodgeMovementStance", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRedirectWeaponStance;
    /// <summary>
    /// Function: GetRedirectWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetRedirectWeaponStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRedirectWeaponStance, "BmGame.RPawnVillain.GetRedirectWeaponStance", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHealthForBeatdown;
    /// <summary>
    /// Function: GetHealthForBeatdown
    /// </summary>
    public unsafe virtual float GetHealthForBeatdown(bool bBeatdownEndCheck)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHealthForBeatdown, "BmGame.RPawnVillain.GetHealthForBeatdown", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBeatdownEndCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeatdownFinish;
    /// <summary>
    /// Function: CanBeatdownFinish
    /// </summary>
    public unsafe virtual bool CanBeatdownFinish()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeatdownFinish, "BmGame.RPawnVillain.CanBeatdownFinish", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeTargettedByBot;
    /// <summary>
    /// Function: CanBeTargettedByBot
    /// </summary>
    public unsafe virtual bool CanBeTargettedByBot(BmSDK.BmGame.RPawnPlayerCombat NewAttacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeTargettedByBot, "BmGame.RPawnVillain.CanBeTargettedByBot", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryCower;
    /// <summary>
    /// Function: TryCower
    /// </summary>
    public unsafe virtual void TryCower(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RPawnCombat EventInstigator, System.Numerics.Vector3 EventLocation, bool bUseBankExplosionAnims = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryCower, "BmGame.RPawnVillain.TryCower", this);
        byte* paramsPtr = stackalloc byte[320];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 248);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseBankExplosionAnims, paramsPtr + 268);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanCower;
    /// <summary>
    /// Function: CanCower
    /// </summary>
    public unsafe virtual bool CanCower()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanCower, "BmGame.RPawnVillain.CanCower", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsHoldingHostage;
    /// <summary>
    /// Function: IsHoldingHostage
    /// </summary>
    public unsafe virtual bool IsHoldingHostage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsHoldingHostage, "BmGame.RPawnVillain.IsHoldingHostage", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRagdollMass;
    /// <summary>
    /// Function: GetRagdollMass
    /// </summary>
    public unsafe virtual float GetRagdollMass(BmSDK.Engine.SkeletalMeshComponent RagdollSkelComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRagdollMass, "BmGame.RPawnVillain.GetRagdollMass", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollSkelComponent, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetRagdollMassScale;
    /// <summary>
    /// Function: SetRagdollMassScale
    /// </summary>
    public unsafe virtual bool SetRagdollMassScale(BmSDK.Engine.SkeletalMeshComponent RagdollSkelComponent, float Scale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetRagdollMassScale, "BmGame.RPawnVillain.SetRagdollMassScale", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollSkelComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 8);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopSwipingCaltrops;
    /// <summary>
    /// Function: StopSwipingCaltrops
    /// </summary>
    public unsafe virtual void StopSwipingCaltrops()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopSwipingCaltrops, "BmGame.RPawnVillain.StopSwipingCaltrops", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartSwipingCaltrops;
    /// <summary>
    /// Function: StartSwipingCaltrops
    /// </summary>
    public unsafe virtual void StartSwipingCaltrops()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartSwipingCaltrops, "BmGame.RPawnVillain.StartSwipingCaltrops", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_JammerRestored;
    /// <summary>
    /// Function: JammerRestored
    /// </summary>
    public unsafe virtual void JammerRestored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_JammerRestored, "BmGame.RPawnVillain.JammerRestored", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_JammerDisabled;
    /// <summary>
    /// Function: JammerDisabled
    /// </summary>
    public unsafe virtual void JammerDisabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_JammerDisabled, "BmGame.RPawnVillain.JammerDisabled", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TickInCombatTime;
    /// <summary>
    /// Function: TickInCombatTime
    /// </summary>
    public unsafe virtual void TickInCombatTime(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TickInCombatTime, "BmGame.RPawnVillain.TickInCombatTime", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GroupAttackHit;
    /// <summary>
    /// Function: GroupAttackHit
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult GroupAttackHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GroupAttackHit, "BmGame.RPawnVillain.GroupAttackHit", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInPredatorAttack;
    /// <summary>
    /// Function: IsInPredatorAttack
    /// </summary>
    public unsafe virtual bool IsInPredatorAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInPredatorAttack, "BmGame.RPawnVillain.IsInPredatorAttack", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerCowerEvent;
    /// <summary>
    /// Function: TriggerCowerEvent
    /// </summary>
    public unsafe virtual void TriggerCowerEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerCowerEvent, "BmGame.RPawnVillain.TriggerCowerEvent", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBatClawHitReactionClass;
    /// <summary>
    /// Function: GetBatClawHitReactionClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetBatClawHitReactionClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBatClawHitReactionClass, "BmGame.RPawnVillain.GetBatClawHitReactionClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRECHitReactionClass;
    /// <summary>
    /// Function: GetRECHitReactionClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetRECHitReactionClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRECHitReactionClass, "BmGame.RPawnVillain.GetRECHitReactionClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRECHitReactionAnimName;
    /// <summary>
    /// Function: GetRECHitReactionAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetRECHitReactionAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRECHitReactionAnimName, "BmGame.RPawnVillain.GetRECHitReactionAnimName", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetReactAnimSet;
    /// <summary>
    /// Function: GetReactAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetReactAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetReactAnimSet, "BmGame.RPawnVillain.GetReactAnimSet", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetReactAnimName;
    /// <summary>
    /// Function: GetReactAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetReactAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetReactAnimName, "BmGame.RPawnVillain.GetReactAnimName", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRECHitReactionAnimset;
    /// <summary>
    /// Function: GetRECHitReactionAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetRECHitReactionAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRECHitReactionAnimset, "BmGame.RPawnVillain.GetRECHitReactionAnimset", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHitReactionAnimset;
    /// <summary>
    /// Function: GetHitReactionAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetHitReactionAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHitReactionAnimset, "BmGame.RPawnVillain.GetHitReactionAnimset", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetThrownObjectClass;
    /// <summary>
    /// Function: GetThrownObjectClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetThrownObjectClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetThrownObjectClass, "BmGame.RPawnVillain.GetThrownObjectClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CleanupAfterFlashTeleport;
    /// <summary>
    /// Function: CleanupAfterFlashTeleport
    /// </summary>
    public unsafe virtual void CleanupAfterFlashTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CleanupAfterFlashTeleport, "BmGame.RPawnVillain.CleanupAfterFlashTeleport", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFlashTeleportBack;
    /// <summary>
    /// Function: OnFlashTeleportBack
    /// </summary>
    public unsafe virtual void OnFlashTeleportBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFlashTeleportBack, "BmGame.RPawnVillain.OnFlashTeleportBack", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFlashTeleport;
    /// <summary>
    /// Function: OnFlashTeleport
    /// </summary>
    public unsafe virtual void OnFlashTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFlashTeleport, "BmGame.RPawnVillain.OnFlashTeleport", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PrepareForFlashTeleport;
    /// <summary>
    /// Function: PrepareForFlashTeleport
    /// </summary>
    public unsafe virtual void PrepareForFlashTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PrepareForFlashTeleport, "BmGame.RPawnVillain.PrepareForFlashTeleport", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VulnerableToDualTeamTakedown;
    /// <summary>
    /// Function: VulnerableToDualTeamTakedown
    /// </summary>
    public unsafe virtual bool VulnerableToDualTeamTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VulnerableToDualTeamTakedown, "BmGame.RPawnVillain.VulnerableToDualTeamTakedown", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBlockInAnimName;
    /// <summary>
    /// Function: GetBlockInAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetBlockInAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBlockInAnimName, "BmGame.RPawnVillain.GetBlockInAnimName", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBlockIdleAnimName;
    /// <summary>
    /// Function: GetBlockIdleAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetBlockIdleAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBlockIdleAnimName, "BmGame.RPawnVillain.GetBlockIdleAnimName", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAerialAttackCameraAnimSet;
    /// <summary>
    /// Function: GetAerialAttackCameraAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetAerialAttackCameraAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAerialAttackCameraAnimSet, "BmGame.RPawnVillain.GetAerialAttackCameraAnimSet", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAerialEvadeInToTargetAnimName;
    /// <summary>
    /// Function: GetAerialEvadeInToTargetAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetAerialEvadeInToTargetAnimName(BmSDK.BmGame.RPawnPlayerCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAerialEvadeInToTargetAnimName, "BmGame.RPawnVillain.GetAerialEvadeInToTargetAnimName", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAerialAttackAnimName;
    /// <summary>
    /// Function: GetAerialAttackAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetAerialAttackAnimName(bool bFinisher, BmSDK.BmGame.RPawnPlayerCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAerialAttackAnimName, "BmGame.RPawnVillain.GetAerialAttackAnimName", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinisher, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerWeaponBomb;
    /// <summary>
    /// Function: TriggerWeaponBomb
    /// </summary>
    public unsafe virtual bool TriggerWeaponBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerWeaponBomb, "BmGame.RPawnVillain.TriggerWeaponBomb", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsDangerousHostageTaker;
    /// <summary>
    /// Function: IsDangerousHostageTaker
    /// </summary>
    public unsafe virtual bool IsDangerousHostageTaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsDangerousHostageTaker, "BmGame.RPawnVillain.IsDangerousHostageTaker", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsHostageTaker;
    /// <summary>
    /// Function: IsHostageTaker
    /// </summary>
    public unsafe virtual bool IsHostageTaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsHostageTaker, "BmGame.RPawnVillain.IsHostageTaker", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeDisarmedByDirectMagBlast;
    /// <summary>
    /// Function: CanBeDisarmedByDirectMagBlast
    /// </summary>
    public unsafe virtual bool CanBeDisarmedByDirectMagBlast()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeDisarmedByDirectMagBlast, "BmGame.RPawnVillain.CanBeDisarmedByDirectMagBlast", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideMagBlastAttachment;
    /// <summary>
    /// Function: OverrideMagBlastAttachment
    /// </summary>
    public unsafe virtual bool OverrideMagBlastAttachment(BmSDK.BmGame.RMagneticBlastReceiver MagBlast)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideMagBlastAttachment, "BmGame.RPawnVillain.OverrideMagBlastAttachment", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MagBlast, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanMagBlastAttach;
    /// <summary>
    /// Function: CanMagBlastAttach
    /// </summary>
    public unsafe virtual bool CanMagBlastAttach()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanMagBlastAttach, "BmGame.RPawnVillain.CanMagBlastAttach", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldMagBlastLockOn;
    /// <summary>
    /// Function: ShouldMagBlastLockOn
    /// </summary>
    public unsafe virtual bool ShouldMagBlastLockOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldMagBlastLockOn, "BmGame.RPawnVillain.ShouldMagBlastLockOn", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PairedAnimsLoadFailedBot;
    /// <summary>
    /// Function: PairedAnimsLoadFailedBot
    /// </summary>
    public unsafe virtual void PairedAnimsLoadFailedBot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PairedAnimsLoadFailedBot, "BmGame.RPawnVillain.PairedAnimsLoadFailedBot", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PairedAnimsLoadFailed;
    /// <summary>
    /// Function: PairedAnimsLoadFailed
    /// </summary>
    public unsafe virtual void PairedAnimsLoadFailed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PairedAnimsLoadFailed, "BmGame.RPawnVillain.PairedAnimsLoadFailed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PairedAnimsSuccessfullyLoadedBot;
    /// <summary>
    /// Function: PairedAnimsSuccessfullyLoadedBot
    /// </summary>
    public unsafe virtual void PairedAnimsSuccessfullyLoadedBot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PairedAnimsSuccessfullyLoadedBot, "BmGame.RPawnVillain.PairedAnimsSuccessfullyLoadedBot", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PairedAnimsSuccessfullyLoaded;
    /// <summary>
    /// Function: PairedAnimsSuccessfullyLoaded
    /// </summary>
    public unsafe virtual void PairedAnimsSuccessfullyLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PairedAnimsSuccessfullyLoaded, "BmGame.RPawnVillain.PairedAnimsSuccessfullyLoaded", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPlayerSpecificAnimsets;
    /// <summary>
    /// Function: SetPlayerSpecificAnimsets
    /// </summary>
    public unsafe virtual void SetPlayerSpecificAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPlayerSpecificAnimsets, "BmGame.RPawnVillain.SetPlayerSpecificAnimsets", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitialisePlayerSpecificAnimsets;
    /// <summary>
    /// Function: InitialisePlayerSpecificAnimsets
    /// </summary>
    public unsafe virtual void InitialisePlayerSpecificAnimsets(BmSDK.BmGame.RPawnPlayerCombat NewPlayer, int PlayerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitialisePlayerSpecificAnimsets, "BmGame.RPawnVillain.InitialisePlayerSpecificAnimsets", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeRegisterDualStrikes;
    /// <summary>
    /// Function: DeRegisterDualStrikes
    /// </summary>
    public unsafe virtual void DeRegisterDualStrikes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeRegisterDualStrikes, "BmGame.RPawnVillain.DeRegisterDualStrikes", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDualStrike;
    /// <summary>
    /// Function: AddDualStrike
    /// </summary>
    public unsafe virtual void AddDualStrike(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnPlayerCombat BuddyPawn, BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeType TypeToAdd, BmSDK.FName StrikeName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDualStrike, "BmGame.RPawnVillain.AddDualStrike", this);
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BuddyPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeToAdd, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeName, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterDualStrikes;
    /// <summary>
    /// Function: RegisterDualStrikes
    /// </summary>
    public unsafe virtual void RegisterDualStrikes(BmSDK.FName PlayerName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterDualStrikes, "BmGame.RPawnVillain.RegisterDualStrikes", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReRegisterPairedAnimsets;
    /// <summary>
    /// Function: ReRegisterPairedAnimsets
    /// </summary>
    public unsafe virtual void ReRegisterPairedAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReRegisterPairedAnimsets, "BmGame.RPawnVillain.ReRegisterPairedAnimsets", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterPairedAnimsets;
    /// <summary>
    /// Function: RegisterPairedAnimsets
    /// </summary>
    public unsafe virtual void RegisterPairedAnimsets(BmSDK.Engine.AnimSet PlayerAnimset, BmSDK.Engine.AnimSet VillainAnimSet, BmSDK.FName CharacterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterPairedAnimsets, "BmGame.RPawnVillain.RegisterPairedAnimsets", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerAnimset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainAnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetJammerLocation;
    /// <summary>
    /// Function: GetJammerLocation
    /// </summary>
    public unsafe virtual bool GetJammerLocation(out System.Numerics.Vector3 JammerLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetJammerLocation, "BmGame.RPawnVillain.GetJammerLocation", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out JammerLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JammerLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        JammerLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetParameterInterference;
    /// <summary>
    /// Function: GetParameterInterference
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkParameterName GetParameterInterference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetParameterInterference, "BmGame.RPawnVillain.GetParameterInterference", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkParameterName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetParameterAngle;
    /// <summary>
    /// Function: GetParameterAngle
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkParameterName GetParameterAngle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetParameterAngle, "BmGame.RPawnVillain.GetParameterAngle", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkParameterName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryDoingLockedOntoByMinidroneBarks;
    /// <summary>
    /// Function: TryDoingLockedOntoByMinidroneBarks
    /// </summary>
    public unsafe virtual void TryDoingLockedOntoByMinidroneBarks(BmSDK.BmGame.RPawnVillain DroneConPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryDoingLockedOntoByMinidroneBarks, "BmGame.RPawnVillain.TryDoingLockedOntoByMinidroneBarks", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DroneConPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMaximumMiniDroneControllerInteractionDistance;
    /// <summary>
    /// Function: GetMaximumMiniDroneControllerInteractionDistance
    /// </summary>
    public unsafe virtual float GetMaximumMiniDroneControllerInteractionDistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMaximumMiniDroneControllerInteractionDistance, "BmGame.RPawnVillain.GetMaximumMiniDroneControllerInteractionDistance", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMiniDroneTargetingMe;
    /// <summary>
    /// Function: GetMiniDroneTargetingMe
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHelicopterBase GetMiniDroneTargetingMe()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMiniDroneTargetingMe, "BmGame.RPawnVillain.GetMiniDroneTargetingMe", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHelicopterBase>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetMiniDroneTargetingMe;
    /// <summary>
    /// Function: SetMiniDroneTargetingMe
    /// </summary>
    public unsafe virtual void SetMiniDroneTargetingMe(BmSDK.BmGame.RHelicopterBase NewMiniDrone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetMiniDroneTargetingMe, "BmGame.RPawnVillain.SetMiniDroneTargetingMe", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMiniDrone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasDroneRemoteInHand;
    /// <summary>
    /// Function: HasDroneRemoteInHand
    /// </summary>
    public unsafe virtual bool HasDroneRemoteInHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasDroneRemoteInHand, "BmGame.RPawnVillain.HasDroneRemoteInHand", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMyMiniDrone;
    /// <summary>
    /// Function: GetMyMiniDrone
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHelicopterBase GetMyMiniDrone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMyMiniDrone, "BmGame.RPawnVillain.GetMyMiniDrone", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHelicopterBase>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsMinidroneController;
    /// <summary>
    /// Function: IsMinidroneController
    /// </summary>
    public unsafe virtual bool IsMinidroneController()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsMinidroneController, "BmGame.RPawnVillain.IsMinidroneController", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool show, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInXrayMode, "BmGame.RPawnVillain.SetInXrayMode", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RemoveInterrogationInteraction;
    /// <summary>
    /// Function: RemoveInterrogationInteraction
    /// </summary>
    public unsafe virtual void RemoveInterrogationInteraction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveInterrogationInteraction, "BmGame.RPawnVillain.RemoveInterrogationInteraction", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateInterrogationInteraction;
    /// <summary>
    /// Function: UpdateInterrogationInteraction
    /// </summary>
    public unsafe virtual void UpdateInterrogationInteraction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateInterrogationInteraction, "BmGame.RPawnVillain.UpdateInterrogationInteraction", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetOmnitronable;
    /// <summary>
    /// Function: SetOmnitronable
    /// </summary>
    public unsafe virtual void SetOmnitronable(bool bOmnitronable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetOmnitronable, "BmGame.RPawnVillain.SetOmnitronable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOmnitronable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetHostile;
    /// <summary>
    /// Function: SetHostile
    /// </summary>
    public unsafe override void SetHostile(bool bNewValue, BmSDK.FName NewNotHostileReason = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetHostile, "BmGame.RPawnVillain.SetHostile", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNotHostileReason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVoiceForEmote;
    /// <summary>
    /// Function: GetVoiceForEmote
    /// </summary>
    public unsafe override BmSDK.Engine.AkDialogueVoice GetVoiceForEmote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVoiceForEmote, "BmGame.RPawnVillain.GetVoiceForEmote", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogueVoice>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RandomBarkFudgeFactor;
    /// <summary>
    /// Function: RandomBarkFudgeFactor
    /// </summary>
    public unsafe virtual float RandomBarkFudgeFactor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RandomBarkFudgeFactor, "BmGame.RPawnVillain.RandomBarkFudgeFactor", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayBarkFromIndex;
    /// <summary>
    /// Function: PlayBarkFromIndex
    /// </summary>
    public unsafe virtual bool PlayBarkFromIndex(BmSDK.FName EventType, BmSDK.BmGame.RAlertEventCoordinatorBase AEC, BmSDK.Engine.Actor BarkSubject = default, BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase.FBarkFlag> ExtraFlags = default, BmSDK.BmGame.RBarkFlagBase.EBarkDeliveryType DeliveryType = default, System.IntPtr NewBarkFinished = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayBarkFromIndex, "BmGame.RPawnVillain.PlayBarkFromIndex", this);
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkSubject, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraFlags, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeliveryType, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBarkFinished, paramsPtr + 44);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BuildContextFlags;
    /// <summary>
    /// Function: BuildContextFlags
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkFlagBase BuildContextFlags(BmSDK.FName EventType, BmSDK.Engine.Actor BarkSubject = default, BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase.FBarkFlag> ExtraFlags = default, BmSDK.BmGame.RBarkFlagBase.EBarkDeliveryType DeliveryType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BuildContextFlags, "BmGame.RPawnVillain.BuildContextFlags", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkSubject, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraFlags, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeliveryType, paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetIndividualFlags;
    /// <summary>
    /// Function: GetIndividualFlags
    /// </summary>
    public unsafe virtual void GetIndividualFlags(BmSDK.BmGame.RBarkFlagBase OutFlagBase)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetIndividualFlags, "BmGame.RPawnVillain.GetIndividualFlags", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutFlagBase, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayBarkFromIndexIfQuiet;
    /// <summary>
    /// Function: PlayBarkFromIndexIfQuiet
    /// </summary>
    public unsafe virtual void PlayBarkFromIndexIfQuiet(BmSDK.FName EventType, BmSDK.BmGame.RAlertEventCoordinatorBase AEC, BmSDK.Engine.Actor BarkSubject = default, BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase.FBarkFlag> ExtraFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayBarkFromIndexIfQuiet, "BmGame.RPawnVillain.PlayBarkFromIndexIfQuiet", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkSubject, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraFlags, paramsPtr + 24);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayExclaimBark;
    /// <summary>
    /// Function: PlayExclaimBark
    /// </summary>
    public unsafe virtual bool PlayExclaimBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayExclaimBark, "BmGame.RPawnVillain.PlayExclaimBark", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayRandomBark;
    /// <summary>
    /// Function: PlayRandomBark
    /// </summary>
    public unsafe virtual bool PlayRandomBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayRandomBark, "BmGame.RPawnVillain.PlayRandomBark", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAIThoughts;
    /// <summary>
    /// Function: GetAIThoughts
    /// </summary>
    public unsafe override void GetAIThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAIThoughts, "BmGame.RPawnVillain.GetAIThoughts", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetOuterMost;
    /// <summary>
    /// Function: GetOuterMost
    /// </summary>
    public unsafe virtual BmSDK.GameObject GetOuterMost(BmSDK.GameObject A)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetOuterMost, "BmGame.RPawnVillain.GetOuterMost", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTargetPriority;
    /// <summary>
    /// Function: GetTargetPriority
    /// </summary>
    public unsafe override float GetTargetPriority(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTargetPriority, "BmGame.RPawnVillain.GetTargetPriority", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeInSimultaneousAttack;
    /// <summary>
    /// Function: CanBeInSimultaneousAttack
    /// </summary>
    public unsafe virtual bool CanBeInSimultaneousAttack(BmSDK.BmGame.RPawnPlayerCombat AttackingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeInSimultaneousAttack, "BmGame.RPawnVillain.CanBeInSimultaneousAttack", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackingPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HidePickPocketTarget;
    /// <summary>
    /// Function: HidePickPocketTarget
    /// </summary>
    public unsafe virtual void HidePickPocketTarget(bool bHide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HidePickPocketTarget, "BmGame.RPawnVillain.HidePickPocketTarget", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetCanPickPocket;
    /// <summary>
    /// Function: SetCanPickPocket
    /// </summary>
    public unsafe virtual void SetCanPickPocket(bool bEnable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetCanPickPocket, "BmGame.RPawnVillain.SetCanPickPocket", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsPickPocketTarget;
    /// <summary>
    /// Function: IsPickPocketTarget
    /// </summary>
    public unsafe virtual bool IsPickPocketTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsPickPocketTarget, "BmGame.RPawnVillain.IsPickPocketTarget", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VictimInRangeForPickPocket;
    /// <summary>
    /// Function: VictimInRangeForPickPocket
    /// </summary>
    public unsafe virtual bool VictimInRangeForPickPocket()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VictimInRangeForPickPocket, "BmGame.RPawnVillain.VictimInRangeForPickPocket", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ChangeXrayColour;
    /// <summary>
    /// Function: ChangeXrayColour
    /// </summary>
    public unsafe override void ChangeXrayColour(bool bBlue, bool bForced = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ChangeXrayColour, "BmGame.RPawnVillain.ChangeXrayColour", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForced, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetInterrogatable;
    /// <summary>
    /// Function: SetInterrogatable
    /// </summary>
    public unsafe virtual void SetInterrogatable(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInterrogatable, "BmGame.RPawnVillain.SetInterrogatable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckInformantPlayerSwitch;
    /// <summary>
    /// Function: CheckInformantPlayerSwitch
    /// </summary>
    public unsafe virtual void CheckInformantPlayerSwitch(BmSDK.FStringArg NewCharacterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckInformantPlayerSwitch, "BmGame.RPawnVillain.CheckInformantPlayerSwitch", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        NewCharacterName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForAllSecretsFoundOrPlayerChange;
    /// <summary>
    /// Function: CheckForAllSecretsFoundOrPlayerChange
    /// </summary>
    public unsafe virtual void CheckForAllSecretsFoundOrPlayerChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForAllSecretsFoundOrPlayerChange, "BmGame.RPawnVillain.CheckForAllSecretsFoundOrPlayerChange", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MarkInterrogatable;
    /// <summary>
    /// Function: MarkInterrogatable
    /// </summary>
    public unsafe virtual void MarkInterrogatable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MarkInterrogatable, "BmGame.RPawnVillain.MarkInterrogatable", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForAutoInformantScan;
    /// <summary>
    /// Function: CheckForAutoInformantScan
    /// </summary>
    public unsafe virtual void CheckForAutoInformantScan()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForAutoInformantScan, "BmGame.RPawnVillain.CheckForAutoInformantScan", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInterrogatable;
    /// <summary>
    /// Function: IsInterrogatable
    /// </summary>
    public unsafe override bool IsInterrogatable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInterrogatable, "BmGame.RPawnVillain.IsInterrogatable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsPotentiallyInterrogatable;
    /// <summary>
    /// Function: IsPotentiallyInterrogatable
    /// </summary>
    public unsafe virtual bool IsPotentiallyInterrogatable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsPotentiallyInterrogatable, "BmGame.RPawnVillain.IsPotentiallyInterrogatable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitialiseInterrogation;
    /// <summary>
    /// Function: InitialiseInterrogation
    /// </summary>
    public unsafe virtual bool InitialiseInterrogation(BmSDK.BmGame.RSeqEvent_StartInterrogation InterrogEvent, BmSDK.BmGame.RSeqAct_PlayCameraConversation SpeechAction, bool _bCanInterrogateFromFront)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitialiseInterrogation, "BmGame.RPawnVillain.InitialiseInterrogation", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechAction, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bCanInterrogateFromFront, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetNextInterrogationFightBackTrackIndex;
    /// <summary>
    /// Function: SetNextInterrogationFightBackTrackIndex
    /// </summary>
    public unsafe virtual void SetNextInterrogationFightBackTrackIndex(bool bGetNoneLeftOne = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetNextInterrogationFightBackTrackIndex, "BmGame.RPawnVillain.SetNextInterrogationFightBackTrackIndex", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetNoneLeftOne, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetNextInterrogationTrackIndex;
    /// <summary>
    /// Function: SetNextInterrogationTrackIndex
    /// </summary>
    public unsafe virtual void SetNextInterrogationTrackIndex(bool bGetNoneLeftOne = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetNextInterrogationTrackIndex, "BmGame.RPawnVillain.SetNextInterrogationTrackIndex", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetNoneLeftOne, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRiddlerInterrogationFightBackTrack;
    /// <summary>
    /// Function: GetRiddlerInterrogationFightBackTrack
    /// </summary>
    public unsafe virtual BmSDK.FString GetRiddlerInterrogationFightBackTrack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRiddlerInterrogationFightBackTrack, "BmGame.RPawnVillain.GetRiddlerInterrogationFightBackTrack", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRiddlerInterrogationTrack;
    /// <summary>
    /// Function: GetRiddlerInterrogationTrack
    /// </summary>
    public unsafe virtual BmSDK.FString GetRiddlerInterrogationTrack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRiddlerInterrogationTrack, "BmGame.RPawnVillain.GetRiddlerInterrogationTrack", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WeaponGrabbedByPlayerRightHand;
    /// <summary>
    /// Function: WeaponGrabbedByPlayerRightHand
    /// </summary>
    public unsafe virtual void WeaponGrabbedByPlayerRightHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WeaponGrabbedByPlayerRightHand, "BmGame.RPawnVillain.WeaponGrabbedByPlayerRightHand", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WeaponGrabbedByPlayerLeftHand;
    /// <summary>
    /// Function: WeaponGrabbedByPlayerLeftHand
    /// </summary>
    public unsafe virtual void WeaponGrabbedByPlayerLeftHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WeaponGrabbedByPlayerLeftHand, "BmGame.RPawnVillain.WeaponGrabbedByPlayerLeftHand", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GrabStart;
    /// <summary>
    /// Function: GrabStart
    /// </summary>
    public unsafe virtual void GrabStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GrabStart, "BmGame.RPawnVillain.GrabStart", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSimultaneousCounterBehaviourType;
    /// <summary>
    /// Function: GetSimultaneousCounterBehaviourType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType GetSimultaneousCounterBehaviourType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSimultaneousCounterBehaviourType, "BmGame.RPawnVillain.GetSimultaneousCounterBehaviourType", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AirPickupableEnd;
    /// <summary>
    /// Function: AirPickupableEnd
    /// </summary>
    public unsafe virtual void AirPickupableEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AirPickupableEnd, "BmGame.RPawnVillain.AirPickupableEnd", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AirStrikeableEnd;
    /// <summary>
    /// Function: AirStrikeableEnd
    /// </summary>
    public unsafe virtual void AirStrikeableEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AirStrikeableEnd, "BmGame.RPawnVillain.AirStrikeableEnd", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AirStrikeableStart;
    /// <summary>
    /// Function: AirStrikeableStart
    /// </summary>
    public unsafe virtual void AirStrikeableStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AirStrikeableStart, "BmGame.RPawnVillain.AirStrikeableStart", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TargetGoRagdoll;
    /// <summary>
    /// Function: TargetGoRagdoll
    /// </summary>
    public unsafe virtual void TargetGoRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TargetGoRagdoll, "BmGame.RPawnVillain.TargetGoRagdoll", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VillainSimultaneousPreAttackNotifyTriggered;
    /// <summary>
    /// Function: VillainSimultaneousPreAttackNotifyTriggered
    /// </summary>
    public unsafe virtual void VillainSimultaneousPreAttackNotifyTriggered(BmSDK.BmGame.RGameInfo.FVillainAttackInfo AttackInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VillainSimultaneousPreAttackNotifyTriggered, "BmGame.RPawnVillain.VillainSimultaneousPreAttackNotifyTriggered", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VillainSimultaneousAttackNotifyTriggered;
    /// <summary>
    /// Function: VillainSimultaneousAttackNotifyTriggered
    /// </summary>
    public unsafe virtual void VillainSimultaneousAttackNotifyTriggered(BmSDK.BmGame.RGameInfo.FVillainAttackInfo AttackInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VillainSimultaneousAttackNotifyTriggered, "BmGame.RPawnVillain.VillainSimultaneousAttackNotifyTriggered", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CriticalStart;
    /// <summary>
    /// Function: CriticalStart
    /// </summary>
    public unsafe virtual void CriticalStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CriticalStart, "BmGame.RPawnVillain.CriticalStart", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CombatAnimHit;
    /// <summary>
    /// Function: CombatAnimHit
    /// </summary>
    public unsafe virtual void CombatAnimHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CombatAnimHit, "BmGame.RPawnVillain.CombatAnimHit", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GenericGoRagdoll;
    /// <summary>
    /// Function: GenericGoRagdoll
    /// </summary>
    public unsafe virtual void GenericGoRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GenericGoRagdoll, "BmGame.RPawnVillain.GenericGoRagdoll", this);
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceNonCombatSilentTakedown;
    /// <summary>
    /// Function: ForceNonCombatSilentTakedown
    /// </summary>
    public unsafe virtual bool ForceNonCombatSilentTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceNonCombatSilentTakedown, "BmGame.RPawnVillain.ForceNonCombatSilentTakedown", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DLC0_Play_SnareTrap_Out_VFX;
    /// <summary>
    /// Function: DLC0_Play_SnareTrap_Out_VFX
    /// </summary>
    public unsafe virtual void DLC0_Play_SnareTrap_Out_VFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DLC0_Play_SnareTrap_Out_VFX, "BmGame.RPawnVillain.DLC0_Play_SnareTrap_Out_VFX", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AreLegsFrozen;
    /// <summary>
    /// Function: AreLegsFrozen
    /// </summary>
    public unsafe virtual bool AreLegsFrozen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AreLegsFrozen, "BmGame.RPawnVillain.AreLegsFrozen", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFloorFreezeTime;
    /// <summary>
    /// Function: GetFloorFreezeTime
    /// </summary>
    public unsafe virtual float GetFloorFreezeTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFloorFreezeTime, "BmGame.RPawnVillain.GetFloorFreezeTime", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFreezeTime;
    /// <summary>
    /// Function: GetFreezeTime
    /// </summary>
    public unsafe virtual float GetFreezeTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFreezeTime, "BmGame.RPawnVillain.GetFreezeTime", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsFrozen;
    /// <summary>
    /// Function: IsFrozen
    /// </summary>
    public unsafe virtual bool IsFrozen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsFrozen, "BmGame.RPawnVillain.IsFrozen", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopFreezeBlastLegEffect;
    /// <summary>
    /// Function: StopFreezeBlastLegEffect
    /// </summary>
    public unsafe virtual void StopFreezeBlastLegEffect(bool bPlayBreakEffect = default, bool bDeactivatedBehaviour = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopFreezeBlastLegEffect, "BmGame.RPawnVillain.StopFreezeBlastLegEffect", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayBreakEffect, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDeactivatedBehaviour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopFreezeBlastLegEffectLeft;
    /// <summary>
    /// Function: StopFreezeBlastLegEffectLeft
    /// </summary>
    public unsafe virtual void StopFreezeBlastLegEffectLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopFreezeBlastLegEffectLeft, "BmGame.RPawnVillain.StopFreezeBlastLegEffectLeft", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopFreezeBlastLegEffectRight;
    /// <summary>
    /// Function: StopFreezeBlastLegEffectRight
    /// </summary>
    public unsafe virtual void StopFreezeBlastLegEffectRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopFreezeBlastLegEffectRight, "BmGame.RPawnVillain.StopFreezeBlastLegEffectRight", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopFreezeBlastTorso;
    /// <summary>
    /// Function: StopFreezeBlastTorso
    /// </summary>
    public unsafe virtual void StopFreezeBlastTorso()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopFreezeBlastTorso, "BmGame.RPawnVillain.StopFreezeBlastTorso", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartFreezeBlastLegEffect;
    /// <summary>
    /// Function: StartFreezeBlastLegEffect
    /// </summary>
    public unsafe virtual void StartFreezeBlastLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartFreezeBlastLegEffect, "BmGame.RPawnVillain.StartFreezeBlastLegEffect", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartFreezeBlastTorsoEffect;
    /// <summary>
    /// Function: StartFreezeBlastTorsoEffect
    /// </summary>
    public unsafe virtual void StartFreezeBlastTorsoEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartFreezeBlastTorsoEffect, "BmGame.RPawnVillain.StartFreezeBlastTorsoEffect", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFreezeBlastTorsoEffectScale;
    /// <summary>
    /// Function: GetFreezeBlastTorsoEffectScale
    /// </summary>
    public unsafe virtual float GetFreezeBlastTorsoEffectScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFreezeBlastTorsoEffectScale, "BmGame.RPawnVillain.GetFreezeBlastTorsoEffectScale", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeactivateFreezeEffects;
    /// <summary>
    /// Function: DeactivateFreezeEffects
    /// </summary>
    public unsafe virtual void DeactivateFreezeEffects(bool bIsEarlyInterrupt, bool bDeactivatedBehaviour = default, bool bDeactivateTorsoEffects = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeactivateFreezeEffects, "BmGame.RPawnVillain.DeactivateFreezeEffects", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsEarlyInterrupt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDeactivatedBehaviour, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDeactivateTorsoEffects, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeFrozen;
    /// <summary>
    /// Function: CanBeFrozen
    /// </summary>
    public unsafe virtual bool CanBeFrozen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeFrozen, "BmGame.RPawnVillain.CanBeFrozen", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSpecialMoveAnimset;
    /// <summary>
    /// Function: GetSpecialMoveAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetSpecialMoveAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSpecialMoveAnimset, "BmGame.RPawnVillain.GetSpecialMoveAnimset", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BroadCastDamagedBy;
    /// <summary>
    /// Function: BroadCastDamagedBy
    /// </summary>
    public unsafe virtual void BroadCastDamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo Info)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BroadCastDamagedBy, "BmGame.RPawnVillain.BroadCastDamagedBy", this);
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DamagedByTakeDown;
    /// <summary>
    /// Function: DamagedByTakeDown
    /// </summary>
    public unsafe virtual void DamagedByTakeDown(BmSDK.BmGame.RPawnCombat.FDamageInfo Info, bool bIsNoisy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DamagedByTakeDown, "BmGame.RPawnVillain.DamagedByTakeDown", this);
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsNoisy, paramsPtr + 248);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SawThrowFrom;
    /// <summary>
    /// Function: SawThrowFrom
    /// </summary>
    public unsafe virtual bool SawThrowFrom(System.Numerics.Vector3 ThrownFromPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SawThrowFrom, "BmGame.RPawnVillain.SawThrowFrom", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsFloorPickupable;
    /// <summary>
    /// Function: IsFloorPickupable
    /// </summary>
    public unsafe override bool IsFloorPickupable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsFloorPickupable, "BmGame.RPawnVillain.IsFloorPickupable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsFloorStrikeable;
    /// <summary>
    /// Function: IsFloorStrikeable
    /// </summary>
    public unsafe override bool IsFloorStrikeable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsFloorStrikeable, "BmGame.RPawnVillain.IsFloorStrikeable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsJustGettingUp;
    /// <summary>
    /// Function: IsJustGettingUp
    /// </summary>
    public unsafe virtual bool IsJustGettingUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsJustGettingUp, "BmGame.RPawnVillain.IsJustGettingUp", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsAirPickupable;
    /// <summary>
    /// Function: IsAirPickupable
    /// </summary>
    public unsafe virtual bool IsAirPickupable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsAirPickupable, "BmGame.RPawnVillain.IsAirPickupable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsAirStrikeable;
    /// <summary>
    /// Function: IsAirStrikeable
    /// </summary>
    public unsafe override bool IsAirStrikeable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsAirStrikeable, "BmGame.RPawnVillain.IsAirStrikeable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowAttackerTracking;
    /// <summary>
    /// Function: AllowAttackerTracking
    /// </summary>
    public unsafe virtual bool AllowAttackerTracking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowAttackerTracking, "BmGame.RPawnVillain.AllowAttackerTracking", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe virtual bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsAwareOfPlayer, "BmGame.RPawnVillain.IsAwareOfPlayer", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsUnawareOfPlayer;
    /// <summary>
    /// Function: IsUnawareOfPlayer
    /// </summary>
    public unsafe virtual bool IsUnawareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsUnawareOfPlayer, "BmGame.RPawnVillain.IsUnawareOfPlayer", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeGlideKicked;
    /// <summary>
    /// Function: CanBeGlideKicked
    /// </summary>
    public unsafe override bool CanBeGlideKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeGlideKicked, "BmGame.RPawnVillain.CanBeGlideKicked", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideCanDodgeProjectile;
    /// <summary>
    /// Function: OverrideCanDodgeProjectile
    /// </summary>
    public unsafe virtual bool OverrideCanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideCanDodgeProjectile, "BmGame.RPawnVillain.OverrideCanDodgeProjectile", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IgnoreFinalBlowCam;
    /// <summary>
    /// Function: IgnoreFinalBlowCam
    /// </summary>
    public unsafe virtual bool IgnoreFinalBlowCam(BmSDK.Class DamageType, float DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IgnoreFinalBlowCam, "BmGame.RPawnVillain.IgnoreFinalBlowCam", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanDoFinalBlow;
    /// <summary>
    /// Function: CanDoFinalBlow
    /// </summary>
    public unsafe virtual bool CanDoFinalBlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanDoFinalBlow, "BmGame.RPawnVillain.CanDoFinalBlow", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnSpecialStun;
    /// <summary>
    /// Function: SpawnSpecialStun
    /// </summary>
    public unsafe virtual bool SpawnSpecialStun(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnSpecialStun, "BmGame.RPawnVillain.SpawnSpecialStun", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe virtual bool SpawnSpecialAttack(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnSpecialAttack, "BmGame.RPawnVillain.SpawnSpecialAttack", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDodgeClass;
    /// <summary>
    /// Function: GetDodgeClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDodgeClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDodgeClass, "BmGame.RPawnVillain.GetDodgeClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RepelAttack;
    /// <summary>
    /// Function: RepelAttack
    /// </summary>
    public unsafe virtual void RepelAttack(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RepelAttack, "BmGame.RPawnVillain.RepelAttack", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BlockAttack;
    /// <summary>
    /// Function: BlockAttack
    /// </summary>
    public unsafe virtual void BlockAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BlockAttack, "BmGame.RPawnVillain.BlockAttack", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PrepareToBlockAttack;
    /// <summary>
    /// Function: PrepareToBlockAttack
    /// </summary>
    public unsafe virtual void PrepareToBlockAttack(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PrepareToBlockAttack, "BmGame.RPawnVillain.PrepareToBlockAttack", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBlockDamageType;
    /// <summary>
    /// Function: CanBlockDamageType
    /// </summary>
    public unsafe override bool CanBlockDamageType(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBlockDamageType, "BmGame.RPawnVillain.CanBlockDamageType", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBlockDuringHitReaction;
    /// <summary>
    /// Function: CanBlockDuringHitReaction
    /// </summary>
    public unsafe virtual bool CanBlockDuringHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo HitReactionDmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBlockDuringHitReaction, "BmGame.RPawnVillain.CanBlockDuringHitReaction", this);
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReactionDmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBlock;
    /// <summary>
    /// Function: CanBlock
    /// </summary>
    public unsafe override bool CanBlock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBlock, "BmGame.RPawnVillain.CanBlock", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CurrentMoveDodgesAttack;
    /// <summary>
    /// Function: CurrentMoveDodgesAttack
    /// </summary>
    public unsafe virtual bool CurrentMoveDodgesAttack(BmSDK.BmGame.RPawnCombat NewAttacker, BmSDK.BmGame.RPawnCombat NewDefender, BmSDK.Class dmgType, bool bFar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CurrentMoveDodgesAttack, "BmGame.RPawnVillain.CurrentMoveDodgesAttack", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDefender, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TargettedBy;
    /// <summary>
    /// Function: TargettedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargettedBy(BmSDK.BmGame.RPawnCombat NewAttacker, BmSDK.Class dmgType, bool bFar = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TargettedBy, "BmGame.RPawnVillain.TargettedBy", this);
        byte* paramsPtr = stackalloc byte[38];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.TargetStrikeResponse>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideRECMagnetReaction;
    /// <summary>
    /// Function: OverrideRECMagnetReaction
    /// </summary>
    public unsafe virtual bool OverrideRECMagnetReaction(BmSDK.Engine.Actor MagnetSource)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideRECMagnetReaction, "BmGame.RPawnVillain.OverrideRECMagnetReaction", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MagnetSource, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RECFiredAtPawn;
    /// <summary>
    /// Function: RECFiredAtPawn
    /// </summary>
    public unsafe virtual bool RECFiredAtPawn(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RECFiredAtPawn, "BmGame.RPawnVillain.RECFiredAtPawn", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideHarpoonHit;
    /// <summary>
    /// Function: OverrideHarpoonHit
    /// </summary>
    public unsafe virtual bool OverrideHarpoonHit(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideHarpoonHit, "BmGame.RPawnVillain.OverrideHarpoonHit", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnOverrideDualStrike;
    /// <summary>
    /// Function: SpawnOverrideDualStrike
    /// </summary>
    public unsafe virtual bool SpawnOverrideDualStrike(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnOverrideDualStrike, "BmGame.RPawnVillain.SpawnOverrideDualStrike", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnOverrideDualTakedown;
    /// <summary>
    /// Function: SpawnOverrideDualTakedown
    /// </summary>
    public unsafe virtual bool SpawnOverrideDualTakedown(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnOverrideDualTakedown, "BmGame.RPawnVillain.SpawnOverrideDualTakedown", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnOverrideTakedown;
    /// <summary>
    /// Function: SpawnOverrideTakedown
    /// </summary>
    public unsafe virtual bool SpawnOverrideTakedown(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnOverrideTakedown, "BmGame.RPawnVillain.SpawnOverrideTakedown", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnMove;
    /// <summary>
    /// Function: SpawnMove
    /// </summary>
    public unsafe virtual void SpawnMove(BmSDK.Class MoveClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnMove, "BmGame.RPawnVillain.SpawnMove", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AdjustGunToMissTarget;
    /// <summary>
    /// Function: AdjustGunToMissTarget
    /// </summary>
    public unsafe virtual void AdjustGunToMissTarget(BmSDK.Engine.Actor TargetActor, bool bKnowHidden = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AdjustGunToMissTarget, "BmGame.RPawnVillain.AdjustGunToMissTarget", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKnowHidden, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AdjustGunToHitTarget;
    /// <summary>
    /// Function: AdjustGunToHitTarget
    /// </summary>
    public unsafe virtual void AdjustGunToHitTarget(BmSDK.Engine.Actor TargetActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AdjustGunToHitTarget, "BmGame.RPawnVillain.AdjustGunToHitTarget", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTrackTarget;
    /// <summary>
    /// Function: SetTrackTarget
    /// </summary>
    public unsafe virtual void SetTrackTarget(BmSDK.Engine.Actor NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTrackTarget, "BmGame.RPawnVillain.SetTrackTarget", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GunTick_TrackTarget;
    /// <summary>
    /// Function: GunTick_TrackTarget
    /// </summary>
    public unsafe virtual bool GunTick_TrackTarget(float DeltaTime, out BmSDK.BmGame.AlertInstance.VisibilityCategory AmountVisible, bool bCanFire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GunTick_TrackTarget, "BmGame.RPawnVillain.GunTick_TrackTarget", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AmountVisible);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmountVisible, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFire, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        AmountVisible = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.AlertInstance.VisibilityCategory>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PreventEnterCombat;
    /// <summary>
    /// Function: PreventEnterCombat
    /// </summary>
    public unsafe virtual bool PreventEnterCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PreventEnterCombat, "BmGame.RPawnVillain.PreventEnterCombat", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RealiseGunIsJammed;
    /// <summary>
    /// Function: RealiseGunIsJammed
    /// </summary>
    public unsafe virtual void RealiseGunIsJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RealiseGunIsJammed, "BmGame.RPawnVillain.RealiseGunIsJammed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GunTick_DiscoverJam;
    /// <summary>
    /// Function: GunTick_DiscoverJam
    /// </summary>
    public unsafe virtual void GunTick_DiscoverJam(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GunTick_DiscoverJam, "BmGame.RPawnVillain.GunTick_DiscoverJam", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GunTick_Shooting;
    /// <summary>
    /// Function: GunTick_Shooting
    /// </summary>
    public unsafe virtual void GunTick_Shooting(bool bForceMiss, BmSDK.BmGame.AlertInstance.VisibilityCategory AmountVisible, bool bCanFire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GunTick_Shooting, "BmGame.RPawnVillain.GunTick_Shooting", this);
        byte* paramsPtr = stackalloc byte[292];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceMiss, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmountVisible, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFire, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TickGunFire;
    /// <summary>
    /// Function: TickGunFire
    /// </summary>
    public unsafe override void TickGunFire(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TickGunFire, "BmGame.RPawnVillain.TickGunFire", this);
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayerHitByShooting;
    /// <summary>
    /// Function: PlayerHitByShooting
    /// </summary>
    public unsafe virtual void PlayerHitByShooting(BmSDK.BmGame.RPawnPlayer P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayerHitByShooting, "BmGame.RPawnVillain.PlayerHitByShooting", this);
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LockedBySpottedSloMo;
    /// <summary>
    /// Function: LockedBySpottedSloMo
    /// </summary>
    public unsafe virtual bool LockedBySpottedSloMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LockedBySpottedSloMo, "BmGame.RPawnVillain.LockedBySpottedSloMo", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsRagdollAtRest;
    /// <summary>
    /// Function: IsRagdollAtRest
    /// </summary>
    public unsafe virtual bool IsRagdollAtRest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsRagdollAtRest, "BmGame.RPawnVillain.IsRagdollAtRest", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayRagdoll;
    /// <summary>
    /// Function: PlayRagdoll
    /// </summary>
    public unsafe virtual void PlayRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RGameInfo.RagdollStunType NewStunType = default, bool bKill = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayRagdoll, "BmGame.RPawnVillain.PlayRagdoll", this);
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStunType, paramsPtr + 248);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 252);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayHitReaction;
    /// <summary>
    /// Function: PlayHitReaction
    /// </summary>
    public unsafe virtual void PlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayHitReaction, "BmGame.RPawnVillain.PlayHitReaction", this);
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStunType;
    /// <summary>
    /// Function: GetStunType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.RagdollStunType GetStunType(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStunType, "BmGame.RPawnVillain.GetStunType", this);
        byte* paramsPtr = stackalloc byte[266];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.RagdollStunType>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ProcessDamagedBy;
    /// <summary>
    /// Function: ProcessDamagedBy
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult ProcessDamagedBy(out BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ProcessDamagedBy, "BmGame.RPawnVillain.ProcessDamagedBy", this);
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DemoteStrikeToQuickStrike;
    /// <summary>
    /// Function: DemoteStrikeToQuickStrike
    /// </summary>
    public unsafe virtual bool DemoteStrikeToQuickStrike(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DemoteStrikeToQuickStrike, "BmGame.RPawnVillain.DemoteStrikeToQuickStrike", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldGoRagdoll;
    /// <summary>
    /// Function: ShouldGoRagdoll
    /// </summary>
    public unsafe virtual bool ShouldGoRagdoll(BmSDK.Class dmgType, float DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldGoRagdoll, "BmGame.RPawnVillain.ShouldGoRagdoll", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnSmokeBombCombatMove;
    /// <summary>
    /// Function: SpawnSmokeBombCombatMove
    /// </summary>
    public unsafe virtual bool SpawnSmokeBombCombatMove(BmSDK.Class SmokeDamageType, out BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnSmokeBombCombatMove, "BmGame.RPawnVillain.SpawnSmokeBombCombatMove", this);
        byte* paramsPtr = stackalloc byte[316];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokeDamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 256);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSmokeBombReactionClass;
    /// <summary>
    /// Function: GetSmokeBombReactionClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetSmokeBombReactionClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSmokeBombReactionClass, "BmGame.RPawnVillain.GetSmokeBombReactionClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBlockBreakerStunTime;
    /// <summary>
    /// Function: GetBlockBreakerStunTime
    /// </summary>
    public unsafe virtual float GetBlockBreakerStunTime(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBlockBreakerStunTime, "BmGame.RPawnVillain.GetBlockBreakerStunTime", this);
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsTakedownAllowed;
    /// <summary>
    /// Function: IsTakedownAllowed
    /// </summary>
    public unsafe virtual bool IsTakedownAllowed(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages takedown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsTakedownAllowed, "BmGame.RPawnVillain.IsTakedownAllowed", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsBotDamageAllowed;
    /// <summary>
    /// Function: IsBotDamageAllowed
    /// </summary>
    public unsafe virtual bool IsBotDamageAllowed(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsBotDamageAllowed, "BmGame.RPawnVillain.IsBotDamageAllowed", this);
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsDamageAllowed;
    /// <summary>
    /// Function: IsDamageAllowed
    /// </summary>
    public unsafe virtual bool IsDamageAllowed(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsDamageAllowed, "BmGame.RPawnVillain.IsDamageAllowed", this);
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DamagedBy, "BmGame.RPawnVillain.DamagedBy", this);
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DefuseBombThug;
    /// <summary>
    /// Function: DefuseBombThug
    /// </summary>
    public unsafe virtual void DefuseBombThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DefuseBombThug, "BmGame.RPawnVillain.DefuseBombThug", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateHitReactionWeaponConfig;
    /// <summary>
    /// Function: CreateHitReactionWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateHitReactionWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateHitReactionWeaponConfig, "BmGame.RPawnVillain.CreateHitReactionWeaponConfig", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateRagdollWeaponConfig;
    /// <summary>
    /// Function: CreateRagdollWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateRagdollWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateRagdollWeaponConfig, "BmGame.RPawnVillain.CreateRagdollWeaponConfig", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateWritheWeaponConfig;
    /// <summary>
    /// Function: CreateWritheWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateWritheWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateWritheWeaponConfig, "BmGame.RPawnVillain.CreateWritheWeaponConfig", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateAttackedWeaponConfig;
    /// <summary>
    /// Function: CreateAttackedWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateAttackedWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateAttackedWeaponConfig, "BmGame.RPawnVillain.CreateAttackedWeaponConfig", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RecheckFalling;
    /// <summary>
    /// Function: RecheckFalling
    /// </summary>
    public unsafe virtual void RecheckFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RecheckFalling, "BmGame.RPawnVillain.RecheckFalling", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WaitToGetUpFromRagdoll;
    /// <summary>
    /// Function: WaitToGetUpFromRagdoll
    /// </summary>
    public unsafe virtual bool WaitToGetUpFromRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WaitToGetUpFromRagdoll, "BmGame.RPawnVillain.WaitToGetUpFromRagdoll", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartGetUp;
    /// <summary>
    /// Function: StartGetUp
    /// </summary>
    public unsafe override void StartGetUp(bool bImmediate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartGetUp, "BmGame.RPawnVillain.StartGetUp", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LadderTimeout;
    /// <summary>
    /// Function: LadderTimeout
    /// </summary>
    public unsafe virtual void LadderTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LadderTimeout, "BmGame.RPawnVillain.LadderTimeout", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsSkeleton;
    /// <summary>
    /// Function: IsSkeleton
    /// </summary>
    public unsafe virtual bool IsSkeleton()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsSkeleton, "BmGame.RPawnVillain.IsSkeleton", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHeartBeatType;
    /// <summary>
    /// Function: GetHeartBeatType
    /// </summary>
    public unsafe override int GetHeartBeatType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHeartBeatType, "BmGame.RPawnVillain.GetHeartBeatType", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RecentGelDamage;
    /// <summary>
    /// Function: RecentGelDamage
    /// </summary>
    public unsafe virtual void RecentGelDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RecentGelDamage, "BmGame.RPawnVillain.RecentGelDamage", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ProcessKickedNoise;
    /// <summary>
    /// Function: ProcessKickedNoise
    /// </summary>
    public unsafe virtual void ProcessKickedNoise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ProcessKickedNoise, "BmGame.RPawnVillain.ProcessKickedNoise", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopGlideKickFX;
    /// <summary>
    /// Function: StopGlideKickFX
    /// </summary>
    public unsafe override void StopGlideKickFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopGlideKickFX, "BmGame.RPawnVillain.StopGlideKickFX", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartGlideKickFX;
    /// <summary>
    /// Function: StartGlideKickFX
    /// </summary>
    public unsafe override void StartGlideKickFX(BmSDK.Engine.ParticleSystem OverrideFX, BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartGlideKickFX, "BmGame.RPawnVillain.StartGlideKickFX", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RemoveCounterIcon;
    /// <summary>
    /// Function: RemoveCounterIcon
    /// </summary>
    public unsafe virtual void RemoveCounterIcon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveCounterIcon, "BmGame.RPawnVillain.RemoveCounterIcon", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopAttackingFX;
    /// <summary>
    /// Function: StopAttackingFX
    /// </summary>
    public unsafe virtual void StopAttackingFX(bool bSuccessfulCounter = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopAttackingFX, "BmGame.RPawnVillain.StopAttackingFX", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccessfulCounter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SwitchAttackingFXIcon;
    /// <summary>
    /// Function: SwitchAttackingFXIcon
    /// </summary>
    public unsafe virtual void SwitchAttackingFXIcon(BmSDK.Engine.ParticleSystem NewTemplate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SwitchAttackingFXIcon, "BmGame.RPawnVillain.SwitchAttackingFXIcon", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTemplate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartAttackingFX;
    /// <summary>
    /// Function: StartAttackingFX
    /// </summary>
    public unsafe virtual void StartAttackingFX(int CTypeInt, BmSDK.BmGame.RPlayerController PC = default, BmSDK.FName OverrideBoneName = default, bool bForceShow = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartAttackingFX, "BmGame.RPawnVillain.StartAttackingFX", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CTypeInt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideBoneName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShow, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetArmBandMineSynced;
    /// <summary>
    /// Function: SetArmBandMineSynced
    /// </summary>
    public unsafe virtual void SetArmBandMineSynced()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetArmBandMineSynced, "BmGame.RPawnVillain.SetArmBandMineSynced", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetArmBandNormal;
    /// <summary>
    /// Function: SetArmBandNormal
    /// </summary>
    public unsafe virtual void SetArmBandNormal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetArmBandNormal, "BmGame.RPawnVillain.SetArmBandNormal", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_YankMe;
    /// <summary>
    /// Function: YankMe
    /// </summary>
    public unsafe virtual void YankMe()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_YankMe, "BmGame.RPawnVillain.YankMe", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetOverlayAnim;
    /// <summary>
    /// Function: GetOverlayAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetOverlayAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetOverlayAnim, "BmGame.RPawnVillain.GetOverlayAnim", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsBarkPreventedByStunnedRagdoll;
    /// <summary>
    /// Function: IsBarkPreventedByStunnedRagdoll
    /// </summary>
    public unsafe virtual bool IsBarkPreventedByStunnedRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsBarkPreventedByStunnedRagdoll, "BmGame.RPawnVillain.IsBarkPreventedByStunnedRagdoll", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTauntAnim;
    /// <summary>
    /// Function: GetTauntAnim
    /// </summary>
    public unsafe override int GetTauntAnim(out BmSDK.FName AnimName, out BmSDK.Engine.AnimSet AnimSet, out int bAlignRotation, int LastTauntID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTauntAnim, "BmGame.RPawnVillain.GetTauntAnim", this);
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bAlignRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlignRotation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastTauntID, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        AnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        bAlignRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnBatmobileTauntAnim;
    /// <summary>
    /// Function: SpawnBatmobileTauntAnim
    /// </summary>
    public unsafe virtual void SpawnBatmobileTauntAnim(BmSDK.BmGame.RGameRI.FTauntAnimInfo TauntInfo, BmSDK.BmGame.RVehicleBatmobileBase Batmobile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnBatmobileTauntAnim, "BmGame.RPawnVillain.SpawnBatmobileTauntAnim", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TauntInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batmobile, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnPairedTauntAnim;
    /// <summary>
    /// Function: SpawnPairedTauntAnim
    /// </summary>
    public unsafe virtual void SpawnPairedTauntAnim(BmSDK.BmGame.RGameRI.FTauntAnimInfo TauntInfo, BmSDK.BmGame.RPawnVillain PairedThug)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnPairedTauntAnim, "BmGame.RPawnVillain.SpawnPairedTauntAnim", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TauntInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PairedThug, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTauntMovementSpace;
    /// <summary>
    /// Function: GetTauntMovementSpace
    /// </summary>
    public unsafe virtual void GetTauntMovementSpace(out int SpaceLeft, out int SpaceRight, out int SpaceInFront, out int SpaceBehind)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTauntMovementSpace, "BmGame.RPawnVillain.GetTauntMovementSpace", this);
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpaceLeft);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpaceLeft, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpaceRight);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpaceRight, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpaceInFront);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpaceInFront, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpaceBehind);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpaceBehind, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SpaceLeft = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SpaceRight = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        SpaceInFront = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        SpaceBehind = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNearbyThugDirections;
    /// <summary>
    /// Function: GetNearbyThugDirections
    /// </summary>
    public unsafe virtual void GetNearbyThugDirections(out BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsLeft, out BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsRight, out BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsInFront, out BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsBehind, out BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsBehindLeft, out BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsBehindRight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNearbyThugDirections, "BmGame.RPawnVillain.GetNearbyThugDirections", this);
        byte* paramsPtr = stackalloc byte[176];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThugsLeft = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 0);
        ThugsRight = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 16);
        ThugsInFront = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 32);
        ThugsBehind = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 48);
        ThugsBehindLeft = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 64);
        ThugsBehindRight = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 80);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldDoStrungUpBark;
    /// <summary>
    /// Function: ShouldDoStrungUpBark
    /// </summary>
    public unsafe virtual bool ShouldDoStrungUpBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldDoStrungUpBark, "BmGame.RPawnVillain.ShouldDoStrungUpBark", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyRopeCut;
    /// <summary>
    /// Function: NotifyRopeCut
    /// </summary>
    public unsafe virtual void NotifyRopeCut(BmSDK.BmGame.RBatarangProjectile Brang)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyRopeCut, "BmGame.RPawnVillain.NotifyRopeCut", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Brang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopKicking;
    /// <summary>
    /// Function: StopKicking
    /// </summary>
    public unsafe virtual void StopKicking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopKicking, "BmGame.RPawnVillain.StopKicking", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SonicBatarangKill;
    /// <summary>
    /// Function: SonicBatarangKill
    /// </summary>
    public unsafe virtual void SonicBatarangKill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SonicBatarangKill, "BmGame.RPawnVillain.SonicBatarangKill", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInBeatdownAtRangeBy;
    /// <summary>
    /// Function: IsInBeatdownAtRangeBy
    /// </summary>
    public unsafe virtual bool IsInBeatdownAtRangeBy(BmSDK.BmGame.RPawnPlayerCombat TestPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInBeatdownAtRangeBy, "BmGame.RPawnVillain.IsInBeatdownAtRangeBy", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInBeatdownBy;
    /// <summary>
    /// Function: IsInBeatdownBy
    /// </summary>
    public unsafe virtual bool IsInBeatdownBy(BmSDK.BmGame.RPawnPlayerCombat TestPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInBeatdownBy, "BmGame.RPawnVillain.IsInBeatdownBy", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsShieldAttack;
    /// <summary>
    /// Function: IsShieldAttack
    /// </summary>
    public unsafe virtual bool IsShieldAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsShieldAttack, "BmGame.RPawnVillain.IsShieldAttack", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsChargingOrPreparingToCharge;
    /// <summary>
    /// Function: IsChargingOrPreparingToCharge
    /// </summary>
    public unsafe virtual bool IsChargingOrPreparingToCharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsChargingOrPreparingToCharge, "BmGame.RPawnVillain.IsChargingOrPreparingToCharge", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsChargingForward;
    /// <summary>
    /// Function: IsChargingForward
    /// </summary>
    public unsafe virtual bool IsChargingForward()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsChargingForward, "BmGame.RPawnVillain.IsChargingForward", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsCharging;
    /// <summary>
    /// Function: IsCharging
    /// </summary>
    public unsafe virtual bool IsCharging()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsCharging, "BmGame.RPawnVillain.IsCharging", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInCombatRange;
    /// <summary>
    /// Function: IsInCombatRange
    /// </summary>
    public unsafe override bool IsInCombatRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInCombatRange, "BmGame.RPawnVillain.IsInCombatRange", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsLastCombatant;
    /// <summary>
    /// Function: IsLastCombatant
    /// </summary>
    public unsafe virtual bool IsLastCombatant()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsLastCombatant, "BmGame.RPawnVillain.IsLastCombatant", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldCombatantForceCombatCamera;
    /// <summary>
    /// Function: ShouldCombatantForceCombatCamera
    /// </summary>
    public unsafe virtual bool ShouldCombatantForceCombatCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldCombatantForceCombatCamera, "BmGame.RPawnVillain.ShouldCombatantForceCombatCamera", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldCombatantLockDoors;
    /// <summary>
    /// Function: ShouldCombatantLockDoors
    /// </summary>
    public unsafe override bool ShouldCombatantLockDoors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldCombatantLockDoors, "BmGame.RPawnVillain.ShouldCombatantLockDoors", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetIsCurrentCombatant;
    /// <summary>
    /// Function: SetIsCurrentCombatant
    /// </summary>
    public unsafe virtual bool SetIsCurrentCombatant()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetIsCurrentCombatant, "BmGame.RPawnVillain.SetIsCurrentCombatant", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AnimationTriggerCallback;
    /// <summary>
    /// Function: AnimationTriggerCallback
    /// </summary>
    public unsafe override void AnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AnimationTriggerCallback, "BmGame.RPawnVillain.AnimationTriggerCallback", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateFalling;
    /// <summary>
    /// Function: UpdateFalling
    /// </summary>
    public unsafe virtual void UpdateFalling(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateFalling, "BmGame.RPawnVillain.UpdateFalling", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckFalling;
    /// <summary>
    /// Function: CheckFalling
    /// </summary>
    public unsafe virtual void CheckFalling(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckFalling, "BmGame.RPawnVillain.CheckFalling", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanCheckFalling;
    /// <summary>
    /// Function: CanCheckFalling
    /// </summary>
    public unsafe virtual bool CanCheckFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanCheckFalling, "BmGame.RPawnVillain.CanCheckFalling", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFallingPos;
    /// <summary>
    /// Function: GetFallingPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFallingPos()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFallingPos, "BmGame.RPawnVillain.GetFallingPos", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_JustAboveFloor;
    /// <summary>
    /// Function: JustAboveFloor
    /// </summary>
    public unsafe virtual bool JustAboveFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_JustAboveFloor, "BmGame.RPawnVillain.JustAboveFloor", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CannotFindExtendedFloor;
    /// <summary>
    /// Function: CannotFindExtendedFloor
    /// </summary>
    public unsafe virtual bool CannotFindExtendedFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CannotFindExtendedFloor, "BmGame.RPawnVillain.CannotFindExtendedFloor", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CannotFindFloor;
    /// <summary>
    /// Function: CannotFindFloor
    /// </summary>
    public unsafe virtual bool CannotFindFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CannotFindFloor, "BmGame.RPawnVillain.CannotFindFloor", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPelvisVelocity;
    /// <summary>
    /// Function: GetPelvisVelocity
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPelvisVelocity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPelvisVelocity, "BmGame.RPawnVillain.GetPelvisVelocity", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsRagdollFalling;
    /// <summary>
    /// Function: IsRagdollFalling
    /// </summary>
    public unsafe virtual bool IsRagdollFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsRagdollFalling, "BmGame.RPawnVillain.IsRagdollFalling", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBlockCounter;
    /// <summary>
    /// Function: CanBlockCounter
    /// </summary>
    public unsafe override bool CanBlockCounter(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBlockCounter, "BmGame.RPawnVillain.CanBlockCounter", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeHitInCombat;
    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe override bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeHitInCombat, "BmGame.RPawnVillain.CanBeHitInCombat", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanTakeSlideAttack;
    /// <summary>
    /// Function: CanTakeSlideAttack
    /// </summary>
    public unsafe virtual bool CanTakeSlideAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanTakeSlideAttack, "BmGame.RPawnVillain.CanTakeSlideAttack", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanReceiveSuperStun;
    /// <summary>
    /// Function: CanReceiveSuperStun
    /// </summary>
    public unsafe virtual bool CanReceiveSuperStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanReceiveSuperStun, "BmGame.RPawnVillain.CanReceiveSuperStun", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFreezeSprayTargetLocation;
    /// <summary>
    /// Function: GetFreezeSprayTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFreezeSprayTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFreezeSprayTargetLocation, "BmGame.RPawnVillain.GetFreezeSprayTargetLocation", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBatClawPriority;
    /// <summary>
    /// Function: GetBatClawPriority
    /// </summary>
    public unsafe virtual float GetBatClawPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBatClawPriority, "BmGame.RPawnVillain.GetBatClawPriority", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBatarangSpeedBoost;
    /// <summary>
    /// Function: GetBatarangSpeedBoost
    /// </summary>
    public unsafe virtual float GetBatarangSpeedBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBatarangSpeedBoost, "BmGame.RPawnVillain.GetBatarangSpeedBoost", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceHitAtEndOfFlight;
    /// <summary>
    /// Function: ForceHitAtEndOfFlight
    /// </summary>
    public unsafe virtual bool ForceHitAtEndOfFlight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceHitAtEndOfFlight, "BmGame.RPawnVillain.ForceHitAtEndOfFlight", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceBatarangToHitMe;
    /// <summary>
    /// Function: ForceBatarangToHitMe
    /// </summary>
    public unsafe virtual bool ForceBatarangToHitMe()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceBatarangToHitMe, "BmGame.RPawnVillain.ForceBatarangToHitMe", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBatarangPriority;
    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe virtual float GetBatarangPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBatarangPriority, "BmGame.RPawnVillain.GetBatarangPriority", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe virtual bool IsBatarangable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsBatarangable, "BmGame.RPawnVillain.IsBatarangable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetForceMissTarget;
    /// <summary>
    /// Function: SetForceMissTarget
    /// </summary>
    public unsafe virtual void SetForceMissTarget(BmSDK.Engine.Actor NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetForceMissTarget, "BmGame.RPawnVillain.SetForceMissTarget", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetDamageTarget;
    /// <summary>
    /// Function: SetDamageTarget
    /// </summary>
    public unsafe virtual void SetDamageTarget(BmSDK.Engine.Actor NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetDamageTarget, "BmGame.RPawnVillain.SetDamageTarget", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetEnemyPos;
    /// <summary>
    /// Function: SetEnemyPos
    /// </summary>
    public unsafe virtual void SetEnemyPos(System.Numerics.Vector3 NewELocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetEnemyPos, "BmGame.RPawnVillain.SetEnemyPos", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewELocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBatmanGrab;
    /// <summary>
    /// Function: CanBatmanGrab
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.BatmanGrabType CanBatmanGrab()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBatmanGrab, "BmGame.RPawnVillain.CanBatmanGrab", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController.BatmanGrabType>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAlertState;
    /// <summary>
    /// Function: GetAlertState
    /// </summary>
    public unsafe virtual void GetAlertState(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAlertState, "BmGame.RPawnVillain.GetAlertState", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoHitDamage;
    /// <summary>
    /// Function: DoHitDamage
    /// </summary>
    public unsafe virtual void DoHitDamage(BmSDK.BmGame.RKActorSpawnable ColidingObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoHitDamage, "BmGame.RPawnVillain.DoHitDamage", this);
        byte* paramsPtr = stackalloc byte[296];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColidingObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Bump, "BmGame.RPawnVillain.Bump", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Touch, "BmGame.RPawnVillain.Touch", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EncroachedBy;
    /// <summary>
    /// Function: EncroachedBy
    /// </summary>
    public unsafe override void EncroachedBy(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EncroachedBy, "BmGame.RPawnVillain.EncroachedBy", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBatarangTargetPosition;
    /// <summary>
    /// Function: GetBatarangTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBatarangTargetPosition(System.Numerics.Vector3 AimLocation, System.Numerics.Vector3 AimDirection, bool bDuringTargetPhase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBatarangTargetPosition, "BmGame.RPawnVillain.GetBatarangTargetPosition", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringTargetPhase, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetGlanceScore;
    /// <summary>
    /// Function: GetGlanceScore
    /// </summary>
    public unsafe virtual int GetGlanceScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetGlanceScore, "BmGame.RPawnVillain.GetGlanceScore", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRagdollClass;
    /// <summary>
    /// Function: GetRagdollClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetRagdollClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRagdollClass, "BmGame.RPawnVillain.GetRagdollClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoRBFallAlert;
    /// <summary>
    /// Function: DoRBFallAlert
    /// </summary>
    public unsafe override void DoRBFallAlert()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoRBFallAlert, "BmGame.RPawnVillain.DoRBFallAlert", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowStasis;
    /// <summary>
    /// Function: AllowStasis
    /// </summary>
    public unsafe virtual void AllowStasis()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowStasis, "BmGame.RPawnVillain.AllowStasis", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SnapJammerAerial;
    /// <summary>
    /// Function: SnapJammerAerial
    /// </summary>
    public unsafe virtual void SnapJammerAerial()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SnapJammerAerial, "BmGame.RPawnVillain.SnapJammerAerial", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayDying;
    /// <summary>
    /// Function: PlayDying
    /// </summary>
    public unsafe override void PlayDying(BmSDK.Class DamageType, System.Numerics.Vector3 HitLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayDying, "BmGame.RPawnVillain.PlayDying", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerDroneControllerDiedWhileDroneBlindEvents;
    /// <summary>
    /// Function: TriggerDroneControllerDiedWhileDroneBlindEvents
    /// </summary>
    public unsafe virtual void TriggerDroneControllerDiedWhileDroneBlindEvents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerDroneControllerDiedWhileDroneBlindEvents, "BmGame.RPawnVillain.TriggerDroneControllerDiedWhileDroneBlindEvents", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerKOMayhemModeStatusEvents;
    /// <summary>
    /// Function: TriggerKOMayhemModeStatusEvents
    /// </summary>
    public unsafe virtual void TriggerKOMayhemModeStatusEvents(bool bMayhemMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerKOMayhemModeStatusEvents, "BmGame.RPawnVillain.TriggerKOMayhemModeStatusEvents", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMayhemMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Died, "BmGame.RPawnVillain.Died", this);
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterThugDeathForDLCAchievement;
    /// <summary>
    /// Function: RegisterThugDeathForDLCAchievement
    /// </summary>
    public unsafe virtual void RegisterThugDeathForDLCAchievement()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterThugDeathForDLCAchievement, "BmGame.RPawnVillain.RegisterThugDeathForDLCAchievement", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsFunctionalJammer;
    /// <summary>
    /// Function: IsFunctionalJammer
    /// </summary>
    public unsafe virtual bool IsFunctionalJammer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsFunctionalJammer, "BmGame.RPawnVillain.IsFunctionalJammer", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DelayedAwardXP;
    /// <summary>
    /// Function: DelayedAwardXP
    /// </summary>
    public unsafe virtual void DelayedAwardXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DelayedAwardXP, "BmGame.RPawnVillain.DelayedAwardXP", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AwardXP;
    /// <summary>
    /// Function: AwardXP
    /// </summary>
    public unsafe virtual void AwardXP(BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AwardXP, "BmGame.RPawnVillain.AwardXP", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGoodAsDead;
    /// <summary>
    /// Function: SetGoodAsDead
    /// </summary>
    public unsafe virtual void SetGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGoodAsDead, "BmGame.RPawnVillain.SetGoodAsDead", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanThugReact;
    /// <summary>
    /// Function: CanThugReact
    /// </summary>
    public unsafe virtual bool CanThugReact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanThugReact, "BmGame.RPawnVillain.CanThugReact", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AwardRingOut;
    /// <summary>
    /// Function: AwardRingOut
    /// </summary>
    public unsafe virtual void AwardRingOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AwardRingOut, "BmGame.RPawnVillain.AwardRingOut", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakenDownByDroneShock;
    /// <summary>
    /// Function: TakenDownByDroneShock
    /// </summary>
    public unsafe virtual void TakenDownByDroneShock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakenDownByDroneShock, "BmGame.RPawnVillain.TakenDownByDroneShock", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_KillByFall;
    /// <summary>
    /// Function: KillByFall
    /// </summary>
    public unsafe virtual void KillByFall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_KillByFall, "BmGame.RPawnVillain.KillByFall", this);
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReactingToCaltrops;
    /// <summary>
    /// Function: ReactingToCaltrops
    /// </summary>
    public unsafe virtual bool ReactingToCaltrops()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReactingToCaltrops, "BmGame.RPawnVillain.ReactingToCaltrops", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RagdollCaltrops;
    /// <summary>
    /// Function: RagdollCaltrops
    /// </summary>
    public unsafe virtual void RagdollCaltrops()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RagdollCaltrops, "BmGame.RPawnVillain.RagdollCaltrops", this);
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RagdollKillLow;
    /// <summary>
    /// Function: RagdollKillLow
    /// </summary>
    public unsafe virtual void RagdollKillLow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RagdollKillLow, "BmGame.RPawnVillain.RagdollKillLow", this);
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RagdollKill;
    /// <summary>
    /// Function: RagdollKill
    /// </summary>
    public unsafe virtual void RagdollKill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RagdollKill, "BmGame.RPawnVillain.RagdollKill", this);
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanChangeTarget;
    /// <summary>
    /// Function: CanChangeTarget
    /// </summary>
    public unsafe virtual bool CanChangeTarget(BmSDK.BmGame.RPawnPlayerCombat TestTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanChangeTarget, "BmGame.RPawnVillain.CanChangeTarget", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeHitByAntiWeaponGel;
    /// <summary>
    /// Function: CanBeHitByAntiWeaponGel
    /// </summary>
    public unsafe virtual bool CanBeHitByAntiWeaponGel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeHitByAntiWeaponGel, "BmGame.RPawnVillain.CanBeHitByAntiWeaponGel", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BeingTargettedByBatmobileWeapon;
    /// <summary>
    /// Function: BeingTargettedByBatmobileWeapon
    /// </summary>
    public unsafe virtual bool BeingTargettedByBatmobileWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeingTargettedByBatmobileWeapon, "BmGame.RPawnVillain.BeingTargettedByBatmobileWeapon", this);
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BatmanLookingAtMe;
    /// <summary>
    /// Function: BatmanLookingAtMe
    /// </summary>
    public unsafe virtual bool BatmanLookingAtMe()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BatmanLookingAtMe, "BmGame.RPawnVillain.BatmanLookingAtMe", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TickRagdollState;
    /// <summary>
    /// Function: TickRagdollState
    /// </summary>
    public unsafe virtual void TickRagdollState(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TickRagdollState, "BmGame.RPawnVillain.TickRagdollState", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RigidBodyCollision, "BmGame.RPawnVillain.RigidBodyCollision", this);
        byte* paramsPtr = stackalloc byte[360];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeDamage, "BmGame.RPawnVillain.TakeDamage", this);
        byte* paramsPtr = stackalloc byte[116];
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MulticastHitByWhip;
    /// <summary>
    /// Function: MulticastHitByWhip
    /// </summary>
    public unsafe virtual void MulticastHitByWhip(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.FName BoneName, BmSDK.FName BoneName2, BmSDK.BmGame.RPawnPlayer Player = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MulticastHitByWhip, "BmGame.RPawnVillain.MulticastHitByWhip", this);
        byte* paramsPtr = stackalloc byte[332];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName2, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HitByBatarang;
    /// <summary>
    /// Function: HitByBatarang
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult HitByBatarang(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HitByBatarang, "BmGame.RPawnVillain.HitByBatarang", this);
        byte* paramsPtr = stackalloc byte[432];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 92);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CantCombo;
    /// <summary>
    /// Function: CantCombo
    /// </summary>
    public unsafe virtual bool CantCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CantCombo, "BmGame.RPawnVillain.CantCombo", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ImmuneToBatarang;
    /// <summary>
    /// Function: ImmuneToBatarang
    /// </summary>
    public unsafe virtual bool ImmuneToBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ImmuneToBatarang, "BmGame.RPawnVillain.ImmuneToBatarang", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IgnoreOffscreenCheckForOverrideGadgetTarget;
    /// <summary>
    /// Function: IgnoreOffscreenCheckForOverrideGadgetTarget
    /// </summary>
    public unsafe virtual bool IgnoreOffscreenCheckForOverrideGadgetTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IgnoreOffscreenCheckForOverrideGadgetTarget, "BmGame.RPawnVillain.IgnoreOffscreenCheckForOverrideGadgetTarget", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckTakeDamageEvents;
    /// <summary>
    /// Function: CheckTakeDamageEvents
    /// </summary>
    public unsafe virtual void CheckTakeDamageEvents(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckTakeDamageEvents, "BmGame.RPawnVillain.CheckTakeDamageEvents", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DestroySelf;
    /// <summary>
    /// Function: DestroySelf
    /// </summary>
    public unsafe virtual void DestroySelf()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DestroySelf, "BmGame.RPawnVillain.DestroySelf", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyPawnDead;
    /// <summary>
    /// Function: NotifyPawnDead
    /// </summary>
    public unsafe virtual void NotifyPawnDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyPawnDead, "BmGame.RPawnVillain.NotifyPawnDead", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BarkCoordinatorCleanup;
    /// <summary>
    /// Function: BarkCoordinatorCleanup
    /// </summary>
    public unsafe virtual void BarkCoordinatorCleanup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BarkCoordinatorCleanup, "BmGame.RPawnVillain.BarkCoordinatorCleanup", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Destroyed, "BmGame.RPawnVillain.Destroyed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateCasualtyAEC;
    /// <summary>
    /// Function: CreateCasualtyAEC
    /// </summary>
    public unsafe virtual void CreateCasualtyAEC()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateCasualtyAEC, "BmGame.RPawnVillain.CreateCasualtyAEC", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindOverworldInterrogateEvent;
    /// <summary>
    /// Function: FindOverworldInterrogateEvent
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSeqEvent_StartInterrogation FindOverworldInterrogateEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindOverworldInterrogateEvent, "BmGame.RPawnVillain.FindOverworldInterrogateEvent", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSeqEvent_StartInterrogation>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MakeDynamicInformant;
    /// <summary>
    /// Function: MakeDynamicInformant
    /// </summary>
    public unsafe virtual bool MakeDynamicInformant()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MakeDynamicInformant, "BmGame.RPawnVillain.MakeDynamicInformant", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LoadNewPrimaryBarkCharDef;
    /// <summary>
    /// Function: LoadNewPrimaryBarkCharDef
    /// </summary>
    public unsafe virtual void LoadNewPrimaryBarkCharDef(BmSDK.FStringArg NewPrimaryBCDstring)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LoadNewPrimaryBarkCharDef, "BmGame.RPawnVillain.LoadNewPrimaryBarkCharDef", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        NewPrimaryBCDstring.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AsyncLoadDone;
    /// <summary>
    /// Function: AsyncLoadDone
    /// </summary>
    public unsafe override void AsyncLoadDone(BmSDK.FStringArg ObjectFinished)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AsyncLoadDone, "BmGame.RPawnVillain.AsyncLoadDone", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        ObjectFinished.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostInitCharacter, "BmGame.RPawnVillain.PostInitCharacter", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PokeTauntAnimsetIntoTauntPose;
    /// <summary>
    /// Function: PokeTauntAnimsetIntoTauntPose
    /// </summary>
    public unsafe virtual void PokeTauntAnimsetIntoTauntPose(BmSDK.BmGame.RWeaponConfig WeapConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PokeTauntAnimsetIntoTauntPose, "BmGame.RPawnVillain.PokeTauntAnimsetIntoTauntPose", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeapConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetIsValidCombatant;
    /// <summary>
    /// Function: SetIsValidCombatant
    /// </summary>
    public unsafe override void SetIsValidCombatant(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetIsValidCombatant, "BmGame.RPawnVillain.SetIsValidCombatant", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetEquipmentPropSkeletalsIndex;
    /// <summary>
    /// Function: GetEquipmentPropSkeletalsIndex
    /// </summary>
    public unsafe virtual int GetEquipmentPropSkeletalsIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetEquipmentPropSkeletalsIndex, "BmGame.RPawnVillain.GetEquipmentPropSkeletalsIndex", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SwitchEquipmentXrayMaterial;
    /// <summary>
    /// Function: SwitchEquipmentXrayMaterial
    /// </summary>
    public unsafe virtual void SwitchEquipmentXrayMaterial(BmSDK.Engine.MaterialInterface NewMIC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SwitchEquipmentXrayMaterial, "BmGame.RPawnVillain.SwitchEquipmentXrayMaterial", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMIC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RestoreDisruptorDisabledEquipment;
    /// <summary>
    /// Function: RestoreDisruptorDisabledEquipment
    /// </summary>
    public unsafe virtual void RestoreDisruptorDisabledEquipment()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RestoreDisruptorDisabledEquipment, "BmGame.RPawnVillain.RestoreDisruptorDisabledEquipment", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsEquipmentDisrupted;
    /// <summary>
    /// Function: IsEquipmentDisrupted
    /// </summary>
    public unsafe virtual bool IsEquipmentDisrupted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsEquipmentDisrupted, "BmGame.RPawnVillain.IsEquipmentDisrupted", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDisruptedEquipmentLocationAndRotation;
    /// <summary>
    /// Function: GetDisruptedEquipmentLocationAndRotation
    /// </summary>
    public unsafe virtual void GetDisruptedEquipmentLocationAndRotation(out System.Numerics.Vector3 vLocation, out BmSDK.Rotator rRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDisruptedEquipmentLocationAndRotation, "BmGame.RPawnVillain.GetDisruptedEquipmentLocationAndRotation", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        vLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        rRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisruptorDisableEquipment;
    /// <summary>
    /// Function: DisruptorDisableEquipment
    /// </summary>
    public unsafe virtual void DisruptorDisableEquipment()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisruptorDisableEquipment, "BmGame.RPawnVillain.DisruptorDisableEquipment", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasDiscoveredJammedWeapon;
    /// <summary>
    /// Function: HasDiscoveredJammedWeapon
    /// </summary>
    public unsafe virtual bool HasDiscoveredJammedWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasDiscoveredJammedWeapon, "BmGame.RPawnVillain.HasDiscoveredJammedWeapon", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HitByDisruptorGadgetSecondary;
    /// <summary>
    /// Function: HitByDisruptorGadgetSecondary
    /// </summary>
    public unsafe virtual bool HitByDisruptorGadgetSecondary()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HitByDisruptorGadgetSecondary, "BmGame.RPawnVillain.HitByDisruptorGadgetSecondary", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeDisruptedSecondary;
    /// <summary>
    /// Function: CanBeDisruptedSecondary
    /// </summary>
    public unsafe virtual bool CanBeDisruptedSecondary()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeDisruptedSecondary, "BmGame.RPawnVillain.CanBeDisruptedSecondary", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDisruptorOverridePriority;
    /// <summary>
    /// Function: GetDisruptorOverridePriority
    /// </summary>
    public unsafe virtual float GetDisruptorOverridePriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDisruptorOverridePriority, "BmGame.RPawnVillain.GetDisruptorOverridePriority", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeDisrupted;
    /// <summary>
    /// Function: CanBeDisrupted
    /// </summary>
    public unsafe virtual bool CanBeDisrupted(BmSDK.BmGame.RJammerGadget JammerGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeDisrupted, "BmGame.RPawnVillain.CanBeDisrupted", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JammerGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HitByDisruptorGadgetCharge;
    /// <summary>
    /// Function: HitByDisruptorGadgetCharge
    /// </summary>
    public unsafe virtual bool HitByDisruptorGadgetCharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HitByDisruptorGadgetCharge, "BmGame.RPawnVillain.HitByDisruptorGadgetCharge", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDisruptorTargetPosition;
    /// <summary>
    /// Function: GetDisruptorTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDisruptorTargetPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDisruptorTargetPosition, "BmGame.RPawnVillain.GetDisruptorTargetPosition", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeRadiusDamageFromWeapon;
    /// <summary>
    /// Function: TakeRadiusDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeRadiusDamageFromWeapon(BmSDK.Engine.Controller InstigatedBy, float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, bool bFullDamage, BmSDK.Engine.Actor DamageCauser, float DamageFalloffExponent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeRadiusDamageFromWeapon, "BmGame.RPawnVillain.TakeRadiusDamageFromWeapon", this);
        byte* paramsPtr = stackalloc byte[324];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseDamage, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HurtOrigin, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFullDamage, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFalloffExponent, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 56);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterCombatPawnIfRequired;
    /// <summary>
    /// Function: RegisterCombatPawnIfRequired
    /// </summary>
    public unsafe virtual void RegisterCombatPawnIfRequired()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterCombatPawnIfRequired, "BmGame.RPawnVillain.RegisterCombatPawnIfRequired", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MineLayerSpawnedInPredVolume;
    /// <summary>
    /// Function: MineLayerSpawnedInPredVolume
    /// </summary>
    public unsafe virtual void MineLayerSpawnedInPredVolume()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MineLayerSpawnedInPredVolume, "BmGame.RPawnVillain.MineLayerSpawnedInPredVolume", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmGame.RPawnVillain.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HitWater;
    /// <summary>
    /// Function: HitWater
    /// </summary>
    public unsafe virtual void HitWater()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HitWater, "BmGame.RPawnVillain.HitWater", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SplashSoundAndDestroy;
    /// <summary>
    /// Function: SplashSoundAndDestroy
    /// </summary>
    public unsafe virtual void SplashSoundAndDestroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SplashSoundAndDestroy, "BmGame.RPawnVillain.SplashSoundAndDestroy", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RecentlyOnScreen;
    /// <summary>
    /// Function: RecentlyOnScreen
    /// </summary>
    public unsafe virtual bool RecentlyOnScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RecentlyOnScreen, "BmGame.RPawnVillain.RecentlyOnScreen", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_Falling;
    /// <summary>
    /// Function: PlaySound_Falling
    /// </summary>
    public unsafe virtual void PlaySound_Falling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_Falling, "BmGame.RPawnVillain.PlaySound_Falling", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_GlideKicked;
    /// <summary>
    /// Function: PlaySound_GlideKicked
    /// </summary>
    public unsafe virtual void PlaySound_GlideKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_GlideKicked, "BmGame.RPawnVillain.PlaySound_GlideKicked", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_LineLaunchKicked;
    /// <summary>
    /// Function: PlaySound_LineLaunchKicked
    /// </summary>
    public unsafe virtual void PlaySound_LineLaunchKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_LineLaunchKicked, "BmGame.RPawnVillain.PlaySound_LineLaunchKicked", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_Exploded;
    /// <summary>
    /// Function: PlaySound_Exploded
    /// </summary>
    public unsafe virtual void PlaySound_Exploded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_Exploded, "BmGame.RPawnVillain.PlaySound_Exploded", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_Batclawed;
    /// <summary>
    /// Function: PlaySound_Batclawed
    /// </summary>
    public unsafe virtual void PlaySound_Batclawed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_Batclawed, "BmGame.RPawnVillain.PlaySound_Batclawed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_Bataranged;
    /// <summary>
    /// Function: PlaySound_Bataranged
    /// </summary>
    public unsafe virtual void PlaySound_Bataranged(bool bHead, bool bKnockOver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_Bataranged, "BmGame.RPawnVillain.PlaySound_Bataranged", this);
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHead, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKnockOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_ThrownIntoWall;
    /// <summary>
    /// Function: PlaySound_ThrownIntoWall
    /// </summary>
    public unsafe virtual void PlaySound_ThrownIntoWall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_ThrownIntoWall, "BmGame.RPawnVillain.PlaySound_ThrownIntoWall", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_HitByThrownThug;
    /// <summary>
    /// Function: PlaySound_HitByThrownThug
    /// </summary>
    public unsafe virtual void PlaySound_HitByThrownThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_HitByThrownThug, "BmGame.RPawnVillain.PlaySound_HitByThrownThug", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_ThrowPickup;
    /// <summary>
    /// Function: PlaySound_ThrowPickup
    /// </summary>
    public unsafe virtual void PlaySound_ThrowPickup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_ThrowPickup, "BmGame.RPawnVillain.PlaySound_ThrowPickup", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_Splash;
    /// <summary>
    /// Function: PlaySound_Splash
    /// </summary>
    public unsafe virtual void PlaySound_Splash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_Splash, "BmGame.RPawnVillain.PlaySound_Splash", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartMonitoringRagdollVelocity;
    /// <summary>
    /// Function: StartMonitoringRagdollVelocity
    /// </summary>
    public unsafe virtual void StartMonitoringRagdollVelocity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartMonitoringRagdollVelocity, "BmGame.RPawnVillain.StartMonitoringRagdollVelocity", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSentryGunSpawnClass;
    /// <summary>
    /// Function: GetSentryGunSpawnClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetSentryGunSpawnClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSentryGunSpawnClass, "BmGame.RPawnVillain.GetSentryGunSpawnClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSentryGunPlacementBehaviourClass;
    /// <summary>
    /// Function: GetSentryGunPlacementBehaviourClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetSentryGunPlacementBehaviourClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSentryGunPlacementBehaviourClass, "BmGame.RPawnVillain.GetSentryGunPlacementBehaviourClass", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPlaceSentryGun;
    /// <summary>
    /// Function: CanPlaceSentryGun
    /// </summary>
    public unsafe virtual bool CanPlaceSentryGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPlaceSentryGun, "BmGame.RPawnVillain.CanPlaceSentryGun", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInDMDOutTransitionAnim;
    /// <summary>
    /// Function: IsInDMDOutTransitionAnim
    /// </summary>
    public unsafe virtual bool IsInDMDOutTransitionAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInDMDOutTransitionAnim, "BmGame.RPawnVillain.IsInDMDOutTransitionAnim", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DMDOutTransitionStarted;
    /// <summary>
    /// Function: DMDOutTransitionStarted
    /// </summary>
    public unsafe virtual void DMDOutTransitionStarted(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId AnimId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DMDOutTransitionStarted, "BmGame.RPawnVillain.DMDOutTransitionStarted", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AttachDMDToBody;
    /// <summary>
    /// Function: AttachDMDToBody
    /// </summary>
    public unsafe virtual void AttachDMDToBody()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AttachDMDToBody, "BmGame.RPawnVillain.AttachDMDToBody", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AttachDMDToHand;
    /// <summary>
    /// Function: AttachDMDToHand
    /// </summary>
    public unsafe virtual void AttachDMDToHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AttachDMDToHand, "BmGame.RPawnVillain.AttachDMDToHand", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanEverDoBagCarrier;
    /// <summary>
    /// Function: CanEverDoBagCarrier
    /// </summary>
    public unsafe virtual bool CanEverDoBagCarrier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanEverDoBagCarrier, "BmGame.RPawnVillain.CanEverDoBagCarrier", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasDetectiveModeDetector;
    /// <summary>
    /// Function: HasDetectiveModeDetector
    /// </summary>
    public unsafe virtual bool HasDetectiveModeDetector()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasDetectiveModeDetector, "BmGame.RPawnVillain.HasDetectiveModeDetector", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsDualPlayClashable;
    /// <summary>
    /// Function: IsDualPlayClashable
    /// </summary>
    public unsafe virtual bool IsDualPlayClashable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsDualPlayClashable, "BmGame.RPawnVillain.IsDualPlayClashable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsTwoface;
    /// <summary>
    /// Function: IsTwoface
    /// </summary>
    public unsafe virtual bool IsTwoface()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsTwoface, "BmGame.RPawnVillain.IsTwoface", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsRedHood;
    /// <summary>
    /// Function: IsRedHood
    /// </summary>
    public unsafe virtual bool IsRedHood()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsRedHood, "BmGame.RPawnVillain.IsRedHood", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBossTakedown;
    /// <summary>
    /// Function: GetBossTakedown
    /// </summary>
    public unsafe virtual BmSDK.Class GetBossTakedown(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages takedown_stage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBossTakedown, "BmGame.RPawnVillain.GetBossTakedown", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown_stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsVulnerableToTakedown;
    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe virtual bool IsVulnerableToTakedown(BmSDK.FStringArg takedown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsVulnerableToTakedown, "BmGame.RPawnVillain.IsVulnerableToTakedown", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        takedown.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyGlideOrDropAttackBegins;
    /// <summary>
    /// Function: NotifyGlideOrDropAttackBegins
    /// </summary>
    public unsafe virtual void NotifyGlideOrDropAttackBegins()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyGlideOrDropAttackBegins, "BmGame.RPawnVillain.NotifyGlideOrDropAttackBegins", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForOverridenTakedown;
    /// <summary>
    /// Function: CheckForOverridenTakedown
    /// </summary>
    public unsafe virtual bool CheckForOverridenTakedown(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages takedown_stage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForOverridenTakedown, "BmGame.RPawnVillain.CheckForOverridenTakedown", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown_stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsVulnerableToStunStrike;
    /// <summary>
    /// Function: IsVulnerableToStunStrike
    /// </summary>
    public unsafe virtual bool IsVulnerableToStunStrike(BmSDK.BmGame.RPawnPlayerCombat AttackingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsVulnerableToStunStrike, "BmGame.RPawnVillain.IsVulnerableToStunStrike", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackingPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BossCanTakeGooHit;
    /// <summary>
    /// Function: BossCanTakeGooHit
    /// </summary>
    public unsafe virtual bool BossCanTakeGooHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BossCanTakeGooHit, "BmGame.RPawnVillain.BossCanTakeGooHit", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsBoss;
    /// <summary>
    /// Function: IsBoss
    /// </summary>
    public unsafe virtual bool IsBoss()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsBoss, "BmGame.RPawnVillain.IsBoss", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTargetPlayer;
    /// <summary>
    /// Function: SetTargetPlayer
    /// </summary>
    public unsafe virtual void SetTargetPlayer(BmSDK.BmGame.RPawnPlayerCombat NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTargetPlayer, "BmGame.RPawnVillain.SetTargetPlayer", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFreezeBlastDeploy;
    /// <summary>
    /// Function: OnFreezeBlastDeploy
    /// </summary>
    public unsafe virtual void OnFreezeBlastDeploy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFreezeBlastDeploy, "BmGame.RPawnVillain.OnFreezeBlastDeploy", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFreezeBlastPriority;
    /// <summary>
    /// Function: GetFreezeBlastPriority
    /// </summary>
    public unsafe virtual float GetFreezeBlastPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFreezeBlastPriority, "BmGame.RPawnVillain.GetFreezeBlastPriority", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetForcedBeatDownStrikeNo;
    /// <summary>
    /// Function: GetForcedBeatDownStrikeNo
    /// </summary>
    public unsafe virtual int GetForcedBeatDownStrikeNo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetForcedBeatDownStrikeNo, "BmGame.RPawnVillain.GetForcedBeatDownStrikeNo", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldForceBeatDownEnd;
    /// <summary>
    /// Function: ShouldForceBeatDownEnd
    /// </summary>
    public unsafe virtual bool ShouldForceBeatDownEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldForceBeatDownEnd, "BmGame.RPawnVillain.ShouldForceBeatDownEnd", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldForceBeatDown;
    /// <summary>
    /// Function: ShouldForceBeatDown
    /// </summary>
    public unsafe virtual bool ShouldForceBeatDown(BmSDK.BmGame.RPawnPlayerCombat TestPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldForceBeatDown, "BmGame.RPawnVillain.ShouldForceBeatDown", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SuperShouldForceBeatdown;
    /// <summary>
    /// Function: SuperShouldForceBeatdown
    /// </summary>
    public unsafe virtual bool SuperShouldForceBeatdown(BmSDK.BmGame.RPawnPlayerCombat TestPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SuperShouldForceBeatdown, "BmGame.RPawnVillain.SuperShouldForceBeatdown", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe virtual void SetHealth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetHealth, "BmGame.RPawnVillain.SetHealth", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetOverrideStrikeInfo;
    /// <summary>
    /// Function: GetOverrideStrikeInfo
    /// </summary>
    public unsafe virtual void GetOverrideStrikeInfo(BmSDK.BmGame.RPawnVillain PrevTarget, float StrikeDamage, out BmSDK.BmGame.RGameInfo.StrikeRange CurrRange, out BmSDK.BmGame.RGameInfo.StrikeStrength CurrStrength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetOverrideStrikeInfo, "BmGame.RPawnVillain.GetOverrideStrikeInfo", this);
        byte* paramsPtr = stackalloc byte[30];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamage, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CurrRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrRange, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CurrStrength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrStrength, paramsPtr + 13);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CurrRange = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.StrikeRange>(paramsPtr + 12);
        CurrStrength = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.StrikeStrength>(paramsPtr + 13);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetGrenadeSpawnOffset;
    /// <summary>
    /// Function: GetGrenadeSpawnOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrenadeSpawnOffset(BmSDK.Rotator PawnLaunchRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetGrenadeSpawnOffset, "BmGame.RPawnVillain.GetGrenadeSpawnOffset", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnLaunchRot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInCurrentPredatorVolume;
    /// <summary>
    /// Function: IsInCurrentPredatorVolume
    /// </summary>
    public unsafe virtual bool IsInCurrentPredatorVolume()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInCurrentPredatorVolume, "BmGame.RPawnVillain.IsInCurrentPredatorVolume", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GunShouldCauseStaggerFor;
    /// <summary>
    /// Function: GunShouldCauseStaggerFor
    /// </summary>
    public unsafe virtual bool GunShouldCauseStaggerFor(BmSDK.Engine.Pawn TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GunShouldCauseStaggerFor, "BmGame.RPawnVillain.GunShouldCauseStaggerFor", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsPawnRunningTowardsMe;
    /// <summary>
    /// Function: IsPawnRunningTowardsMe
    /// </summary>
    public unsafe virtual bool IsPawnRunningTowardsMe(BmSDK.Engine.Pawn TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsPawnRunningTowardsMe, "BmGame.RPawnVillain.IsPawnRunningTowardsMe", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryGetGrenadeThrowVelocity;
    /// <summary>
    /// Function: TryGetGrenadeThrowVelocity
    /// </summary>
    public unsafe virtual bool TryGetGrenadeThrowVelocity(out System.Numerics.Vector3 ThrowVelocity, out float FlightTime, System.Numerics.Vector3 Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryGetGrenadeThrowVelocity, "BmGame.RPawnVillain.TryGetGrenadeThrowVelocity", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThrowVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVelocity, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FlightTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThrowVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        FlightTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeRegisterPairedAnimsets;
    /// <summary>
    /// Function: DeRegisterPairedAnimsets
    /// </summary>
    public unsafe virtual void DeRegisterPairedAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeRegisterPairedAnimsets, "BmGame.RPawnVillain.DeRegisterPairedAnimsets", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MonitorRagdollForHighVelocity;
    /// <summary>
    /// Function: MonitorRagdollForHighVelocity
    /// </summary>
    public unsafe virtual void MonitorRagdollForHighVelocity(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MonitorRagdollForHighVelocity, "BmGame.RPawnVillain.MonitorRagdollForHighVelocity", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForNeedToMonitorPawnVelocity;
    /// <summary>
    /// Function: CheckForNeedToMonitorPawnVelocity
    /// </summary>
    public unsafe virtual void CheckForNeedToMonitorPawnVelocity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForNeedToMonitorPawnVelocity, "BmGame.RPawnVillain.CheckForNeedToMonitorPawnVelocity", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsIncapacitated;
    /// <summary>
    /// Function: IsIncapacitated
    /// </summary>
    public unsafe override bool IsIncapacitated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsIncapacitated, "BmGame.RPawnVillain.IsIncapacitated", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SwitchingPlayerCharacter;
    /// <summary>
    /// Function: SwitchingPlayerCharacter
    /// </summary>
    public unsafe virtual void SwitchingPlayerCharacter(BmSDK.FStringArg NewCharacterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SwitchingPlayerCharacter, "BmGame.RPawnVillain.SwitchingPlayerCharacter", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        NewCharacterName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReloadPlayerSpecificAnimsets;
    /// <summary>
    /// Function: ReloadPlayerSpecificAnimsets
    /// </summary>
    public unsafe virtual void ReloadPlayerSpecificAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReloadPlayerSpecificAnimsets, "BmGame.RPawnVillain.ReloadPlayerSpecificAnimsets", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearPlayerSpecificAnimsets;
    /// <summary>
    /// Function: ClearPlayerSpecificAnimsets
    /// </summary>
    public unsafe virtual void ClearPlayerSpecificAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearPlayerSpecificAnimsets, "BmGame.RPawnVillain.ClearPlayerSpecificAnimsets", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadyForCombat;
    /// <summary>
    /// Function: ReadyForCombat
    /// </summary>
    public unsafe virtual bool ReadyForCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadyForCombat, "BmGame.RPawnVillain.ReadyForCombat", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LoadPairedAnimsetForBot;
    /// <summary>
    /// Function: LoadPairedAnimsetForBot
    /// </summary>
    public unsafe virtual bool LoadPairedAnimsetForBot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LoadPairedAnimsetForBot, "BmGame.RPawnVillain.LoadPairedAnimsetForBot", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LoadPairedAnimsetForPlayer;
    /// <summary>
    /// Function: LoadPairedAnimsetForPlayer
    /// </summary>
    public unsafe virtual bool LoadPairedAnimsetForPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LoadPairedAnimsetForPlayer, "BmGame.RPawnVillain.LoadPairedAnimsetForPlayer", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanAttachExplosiveGelBomb;
    /// <summary>
    /// Function: CanAttachExplosiveGelBomb
    /// </summary>
    public unsafe virtual bool CanAttachExplosiveGelBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanAttachExplosiveGelBomb, "BmGame.RPawnVillain.CanAttachExplosiveGelBomb", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanTakeSmokeHit;
    /// <summary>
    /// Function: CanTakeSmokeHit
    /// </summary>
    public unsafe virtual bool CanTakeSmokeHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanTakeSmokeHit, "BmGame.RPawnVillain.CanTakeSmokeHit", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsAttractingWeapons;
    /// <summary>
    /// Function: IsAttractingWeapons
    /// </summary>
    public unsafe virtual bool IsAttractingWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsAttractingWeapons, "BmGame.RPawnVillain.IsAttractingWeapons", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RemoveStuckWeapons;
    /// <summary>
    /// Function: RemoveStuckWeapons
    /// </summary>
    public unsafe virtual void RemoveStuckWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveStuckWeapons, "BmGame.RPawnVillain.RemoveStuckWeapons", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DropProps;
    /// <summary>
    /// Function: DropProps
    /// </summary>
    public unsafe override void DropProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DropProps, "BmGame.RPawnVillain.DropProps", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoKismetAttachment;
    /// <summary>
    /// Function: DoKismetAttachment
    /// </summary>
    public unsafe override void DoKismetAttachment(BmSDK.Engine.Actor Attachment, BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoKismetAttachment, "BmGame.RPawnVillain.DoKismetAttachment", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attachment, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldStopControllableBatarang;
    /// <summary>
    /// Function: ShouldStopControllableBatarang
    /// </summary>
    public unsafe virtual bool ShouldStopControllableBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldStopControllableBatarang, "BmGame.RPawnVillain.ShouldStopControllableBatarang", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldShowGadgetHUD;
    /// <summary>
    /// Function: ShouldShowGadgetHUD
    /// </summary>
    public unsafe virtual bool ShouldShowGadgetHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldShowGadgetHUD, "BmGame.RPawnVillain.ShouldShowGadgetHUD", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetKnownNavMeshObstacles;
    /// <summary>
    /// Function: GetKnownNavMeshObstacles
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.Engine.NavMeshObstacle> GetKnownNavMeshObstacles()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetKnownNavMeshObstacles, "BmGame.RPawnVillain.GetKnownNavMeshObstacles", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.NavMeshObstacle>>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CallPropagateRoomwideAlert;
    /// <summary>
    /// Function: CallPropagateRoomwideAlert
    /// </summary>
    public unsafe virtual void CallPropagateRoomwideAlert()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CallPropagateRoomwideAlert, "BmGame.RPawnVillain.CallPropagateRoomwideAlert", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DelayedPropagateRoomwideAlert;
    /// <summary>
    /// Function: DelayedPropagateRoomwideAlert
    /// </summary>
    public unsafe virtual void DelayedPropagateRoomwideAlert(float DelayTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DelayedPropagateRoomwideAlert, "BmGame.RPawnVillain.DelayedPropagateRoomwideAlert", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTunnelTakenDownFrom;
    /// <summary>
    /// Function: GetTunnelTakenDownFrom
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RTunnelFunnel GetTunnelTakenDownFrom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTunnelTakenDownFrom, "BmGame.RPawnVillain.GetTunnelTakenDownFrom", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RTunnelFunnel>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTakedownTunnel;
    /// <summary>
    /// Function: SetTakedownTunnel
    /// </summary>
    public unsafe virtual void SetTakedownTunnel(BmSDK.BmGame.RTunnelFunnel TakedownTunnel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTakedownTunnel, "BmGame.RPawnVillain.SetTakedownTunnel", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownTunnel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetGrateTakenDownFrom;
    /// <summary>
    /// Function: GetGrateTakenDownFrom
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RTunnelGrateBase GetGrateTakenDownFrom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetGrateTakenDownFrom, "BmGame.RPawnVillain.GetGrateTakenDownFrom", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RTunnelGrateBase>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGrateTakenDownFrom;
    /// <summary>
    /// Function: SetGrateTakenDownFrom
    /// </summary>
    public unsafe virtual void SetGrateTakenDownFrom(BmSDK.BmGame.RTunnelGrateBase Grate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGrateTakenDownFrom, "BmGame.RPawnVillain.SetGrateTakenDownFrom", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsBMUnderGrate;
    /// <summary>
    /// Function: IsBMUnderGrate
    /// </summary>
    public unsafe virtual bool IsBMUnderGrate(BmSDK.BmGame.RTunnelGrateBase Grate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsBMUnderGrate, "BmGame.RPawnVillain.IsBMUnderGrate", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsPlayerUnderVisibleGrate;
    /// <summary>
    /// Function: IsPlayerUnderVisibleGrate
    /// </summary>
    public unsafe virtual bool IsPlayerUnderVisibleGrate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsPlayerUnderVisibleGrate, "BmGame.RPawnVillain.IsPlayerUnderVisibleGrate", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateGrateVis;
    /// <summary>
    /// Function: UpdateGrateVis
    /// </summary>
    public unsafe virtual void UpdateGrateVis(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateGrateVis, "BmGame.RPawnVillain.UpdateGrateVis", this);
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearGrateVis;
    /// <summary>
    /// Function: ClearGrateVis
    /// </summary>
    public unsafe virtual void ClearGrateVis()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearGrateVis, "BmGame.RPawnVillain.ClearGrateVis", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAllGratesInVisRange;
    /// <summary>
    /// Function: GetAllGratesInVisRange
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> GetAllGratesInVisRange(System.Numerics.Vector3 ViewLoc, float grateViewRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAllGratesInVisRange, "BmGame.RPawnVillain.GetAllGratesInVisRange", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(grateViewRange, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsGrateInVisionRange;
    /// <summary>
    /// Function: IsGrateInVisionRange
    /// </summary>
    public unsafe virtual bool IsGrateInVisionRange(BmSDK.BmGame.RBMPawnAI.FgrateVisInfo grateInfo, System.Numerics.Vector3 ViewLoc, BmSDK.Rotator ViewRot, float boxLength, float boxWidth, bool bRadiusOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsGrateInVisionRange, "BmGame.RPawnVillain.IsGrateInVisionRange", this);
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(grateInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewRot, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(boxLength, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(boxWidth, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRadiusOnly, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetInteractButton;
    /// <summary>
    /// Function: GetInteractButton
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton GetInteractButton(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetInteractButton, "BmGame.RPawnVillain.GetInteractButton", this);
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverridePreviousLines;
    /// <summary>
    /// Function: OverridePreviousLines
    /// </summary>
    public unsafe virtual bool OverridePreviousLines()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverridePreviousLines, "BmGame.RPawnVillain.OverridePreviousLines", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPrompt;
    /// <summary>
    /// Function: GetPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetPrompt(BmSDK.Engine.PlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPrompt, "BmGame.RPawnVillain.GetPrompt", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetCanInteract;
    /// <summary>
    /// Function: SetCanInteract
    /// </summary>
    public unsafe virtual void SetCanInteract(bool bInter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetCanInteract, "BmGame.RPawnVillain.SetCanInteract", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsActive;
    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe virtual bool IsActive(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsActive, "BmGame.RPawnVillain.IsActive", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsCombatClose;
    /// <summary>
    /// Function: IsCombatClose
    /// </summary>
    public unsafe virtual bool IsCombatClose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsCombatClose, "BmGame.RPawnVillain.IsCombatClose", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsButtonPrompt;
    /// <summary>
    /// Function: IsButtonPrompt
    /// </summary>
    public unsafe virtual bool IsButtonPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsButtonPrompt, "BmGame.RPawnVillain.IsButtonPrompt", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Interact;
    /// <summary>
    /// Function: Interact
    /// </summary>
    public unsafe virtual void Interact(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Interact, "BmGame.RPawnVillain.Interact", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForHitBatman;
    /// <summary>
    /// Function: CheckForHitBatman
    /// </summary>
    public unsafe virtual void CheckForHitBatman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForHitBatman, "BmGame.RPawnVillain.CheckForHitBatman", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLocationOffset;
    /// <summary>
    /// Function: GetLocationOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLocationOffset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLocationOffset, "BmGame.RPawnVillain.GetLocationOffset", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPriority;
    /// <summary>
    /// Function: GetPriority
    /// </summary>
    public unsafe virtual float GetPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPriority, "BmGame.RPawnVillain.GetPriority", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFOVDegrees;
    /// <summary>
    /// Function: GetFOVDegrees
    /// </summary>
    public unsafe virtual float GetFOVDegrees(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFOVDegrees, "BmGame.RPawnVillain.GetFOVDegrees", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MustBeCrouched;
    /// <summary>
    /// Function: MustBeCrouched
    /// </summary>
    public unsafe virtual bool MustBeCrouched(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MustBeCrouched, "BmGame.RPawnVillain.MustBeCrouched", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanUseInCinematicMode;
    /// <summary>
    /// Function: CanUseInCinematicMode
    /// </summary>
    public unsafe virtual bool CanUseInCinematicMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanUseInCinematicMode, "BmGame.RPawnVillain.CanUseInCinematicMode", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUpperPrompt;
    /// <summary>
    /// Function: GetUpperPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetUpperPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUpperPrompt, "BmGame.RPawnVillain.GetUpperPrompt", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanReachItem;
    /// <summary>
    /// Function: CanReachItem
    /// </summary>
    public unsafe virtual bool CanReachItem(BmSDK.Engine.Pawn CheckingPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanReachItem, "BmGame.RPawnVillain.CanReachItem", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckingPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverridesRun;
    /// <summary>
    /// Function: OverridesRun
    /// </summary>
    public unsafe virtual float OverridesRun(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverridesRun, "BmGame.RPawnVillain.OverridesRun", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHeightRange;
    /// <summary>
    /// Function: GetHeightRange
    /// </summary>
    public unsafe virtual float GetHeightRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHeightRange, "BmGame.RPawnVillain.GetHeightRange", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRange;
    /// <summary>
    /// Function: GetRange
    /// </summary>
    public unsafe virtual float GetRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRange, "BmGame.RPawnVillain.GetRange", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanEmote;
    /// <summary>
    /// Function: CanEmote
    /// </summary>
    public unsafe override bool CanEmote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanEmote, "BmGame.RPawnVillain.CanEmote", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForNonDestructibleObstacleMesh;
    /// <summary>
    /// Function: CheckForNonDestructibleObstacleMesh
    /// </summary>
    public unsafe virtual bool CheckForNonDestructibleObstacleMesh(System.Numerics.Vector3 StartPos, System.Numerics.Vector3 EndPos, System.Numerics.Vector3 Extents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForNonDestructibleObstacleMesh, "BmGame.RPawnVillain.CheckForNonDestructibleObstacleMesh", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extents, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NeedToLoadPackagesForPlayer;
    /// <summary>
    /// Function: NeedToLoadPackagesForPlayer
    /// </summary>
    public unsafe virtual bool NeedToLoadPackagesForPlayer(int PlayerIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NeedToLoadPackagesForPlayer, "BmGame.RPawnVillain.NeedToLoadPackagesForPlayer", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIdx, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLineIntersectsVehiclePoint;
    /// <summary>
    /// Function: GetLineIntersectsVehiclePoint
    /// </summary>
    public unsafe virtual bool GetLineIntersectsVehiclePoint(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 Direction, BmSDK.BmGame.RVehicle Car, out float HitDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLineIntersectsVehiclePoint, "BmGame.RPawnVillain.GetLineIntersectsVehiclePoint", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Car, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitDistance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitDistance, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitDistance = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddGeneratedEvent;
    /// <summary>
    /// Function: AddGeneratedEvent
    /// </summary>
    public unsafe virtual void AddGeneratedEvent(BmSDK.Engine.SequenceEvent NewSeqEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddGeneratedEvent, "BmGame.RPawnVillain.AddGeneratedEvent", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSeqEvent, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPairedTauntAnimInfo;
    /// <summary>
    /// Function: GetPairedTauntAnimInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetPairedTauntAnimInfo(BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo> TauntList, out BmSDK.BmGame.RGameRI.FTauntAnimInfo TauntInfo, bool bTargetIsBelow, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsLeft, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsRight, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsInFront, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsBehind, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsBehindLeft, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsBehindRight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPairedTauntAnimInfo, "BmGame.RPawnVillain.GetPairedTauntAnimInfo", this);
        byte* paramsPtr = stackalloc byte[204];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TauntList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTargetIsBelow, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugsLeft, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugsRight, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugsInFront, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugsBehind, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugsBehindLeft, paramsPtr + 148);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugsBehindRight, paramsPtr + 164);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TauntInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI.FTauntAnimInfo>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 180);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTauntAnimInfo;
    /// <summary>
    /// Function: GetTauntAnimInfo
    /// </summary>
    public unsafe virtual bool GetTauntAnimInfo(BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo> TauntList, out BmSDK.BmGame.RGameRI.FTauntAnimInfo TauntInfo, bool bTargetIsBelow, BmSDK.BmGame.RVehicleBatmobileBase Batmobile, bool bThugLeft, bool bThugRight, bool bThugInFront, bool bThugBehind, bool bThugBehindLeft, bool bThugBehindRight, bool bSpaceLeft, bool bSpaceRight, bool bSpaceInFront, bool bSpaceBehind)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTauntAnimInfo, "BmGame.RPawnVillain.GetTauntAnimInfo", this);
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TauntList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTargetIsBelow, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batmobile, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThugLeft, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThugRight, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThugInFront, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThugBehind, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThugBehindLeft, paramsPtr + 108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThugBehindRight, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpaceLeft, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpaceRight, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpaceInFront, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpaceBehind, paramsPtr + 128);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TauntInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI.FTauntAnimInfo>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 132);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PopulateCombatTauntList;
    /// <summary>
    /// Function: PopulateCombatTauntList
    /// </summary>
    public unsafe virtual void PopulateCombatTauntList(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo> outTauntList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PopulateCombatTauntList, "BmGame.RPawnVillain.PopulateCombatTauntList", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outTauntList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PopulateCombatIdleStances;
    /// <summary>
    /// Function: PopulateCombatIdleStances
    /// </summary>
    public unsafe virtual void PopulateCombatIdleStances(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.FName> outCombatIdleStances)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PopulateCombatIdleStances, "BmGame.RPawnVillain.PopulateCombatIdleStances", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outCombatIdleStances = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PopulateCombatStepList;
    /// <summary>
    /// Function: PopulateCombatStepList
    /// </summary>
    public unsafe virtual void PopulateCombatStepList(BmSDK.Engine.AnimSet TestAnimSet, out BmSDK.TArray<BmSDK.FName> outStepList, out BmSDK.TArray<BmSDK.FName> outLongStepList, out BmSDK.FName outForwardStepName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PopulateCombatStepList, "BmGame.RPawnVillain.PopulateCombatStepList", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAnimSet, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outForwardStepName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outForwardStepName, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outStepList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        outLongStepList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 24);
        outForwardStepName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ScriptCustomCalcVisibility;
    /// <summary>
    /// Function: ScriptCustomCalcVisibility
    /// </summary>
    public unsafe virtual BmSDK.BmGame.AlertInstance.VisibilityCategory ScriptCustomCalcVisibility(BmSDK.BmGame.RBMAIController CheckController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ScriptCustomCalcVisibility, "BmGame.RPawnVillain.ScriptCustomCalcVisibility", this);
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckController, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.AlertInstance.VisibilityCategory>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetWeaponAudioSwitch;
    /// <summary>
    /// Function: SetWeaponAudioSwitch
    /// </summary>
    public unsafe virtual void SetWeaponAudioSwitch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetWeaponAudioSwitch, "BmGame.RPawnVillain.SetWeaponAudioSwitch", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForcePairedAnimLoad;
    /// <summary>
    /// Function: ForcePairedAnimLoad
    /// </summary>
    public unsafe override void ForcePairedAnimLoad()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForcePairedAnimLoad, "BmGame.RPawnVillain.ForcePairedAnimLoad", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNonTargetPlayer;
    /// <summary>
    /// Function: GetNonTargetPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayerCombat GetNonTargetPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNonTargetPlayer, "BmGame.RPawnVillain.GetNonTargetPlayer", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTargetPlayer;
    /// <summary>
    /// Function: GetTargetPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayerCombat GetTargetPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTargetPlayer, "BmGame.RPawnVillain.GetTargetPlayer", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTargetActor;
    /// <summary>
    /// Function: GetTargetActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetTargetActor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTargetActor, "BmGame.RPawnVillain.GetTargetActor", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTargetPawn;
    /// <summary>
    /// Function: GetTargetPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetTargetPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTargetPawn, "BmGame.RPawnVillain.GetTargetPawn", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeSeenByBatsForXray;
    /// <summary>
    /// Function: CanBeSeenByBatsForXray
    /// </summary>
    public unsafe override bool CanBeSeenByBatsForXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeSeenByBatsForXray, "BmGame.RPawnVillain.CanBeSeenByBatsForXray", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearThermalMaterials;
    /// <summary>
    /// Function: ClearThermalMaterials
    /// </summary>
    public unsafe virtual void ClearThermalMaterials(BmSDK.Engine.MeshComponent M)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearThermalMaterials, "BmGame.RPawnVillain.ClearThermalMaterials", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerPairedIndex;
    /// <summary>
    /// Function: GetPlayerPairedIndex
    /// </summary>
    public unsafe virtual int GetPlayerPairedIndex(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.FName OverrideCharacterName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerPairedIndex, "BmGame.RPawnVillain.GetPlayerPairedIndex", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideCharacterName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerFloorPickupAnimset;
    /// <summary>
    /// Function: GetPlayerFloorPickupAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerFloorPickupAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerFloorPickupAnimset, "BmGame.RPawnVillain.GetPlayerFloorPickupAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVillainFloorPickupAnimset;
    /// <summary>
    /// Function: GetVillainFloorPickupAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVillainFloorPickupAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVillainFloorPickupAnimset, "BmGame.RPawnVillain.GetVillainFloorPickupAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVillainEnvTakedownAnimset;
    /// <summary>
    /// Function: GetVillainEnvTakedownAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVillainEnvTakedownAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVillainEnvTakedownAnimset, "BmGame.RPawnVillain.GetVillainEnvTakedownAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerEnvTakedownAnimset;
    /// <summary>
    /// Function: GetPlayerEnvTakedownAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerEnvTakedownAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerEnvTakedownAnimset, "BmGame.RPawnVillain.GetPlayerEnvTakedownAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerPredTakedownAnimSet;
    /// <summary>
    /// Function: GetPlayerPredTakedownAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerPredTakedownAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerPredTakedownAnimSet, "BmGame.RPawnVillain.GetPlayerPredTakedownAnimSet", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVillainPredTakedownAnimSet;
    /// <summary>
    /// Function: GetVillainPredTakedownAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVillainPredTakedownAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVillainPredTakedownAnimSet, "BmGame.RPawnVillain.GetVillainPredTakedownAnimSet", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVillainDualPlayAnimset;
    /// <summary>
    /// Function: GetVillainDualPlayAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVillainDualPlayAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVillainDualPlayAnimset, "BmGame.RPawnVillain.GetVillainDualPlayAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerDualPlayAnimset;
    /// <summary>
    /// Function: GetPlayerDualPlayAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerDualPlayAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerDualPlayAnimset, "BmGame.RPawnVillain.GetPlayerDualPlayAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerChargeAnimset;
    /// <summary>
    /// Function: GetPlayerChargeAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerChargeAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerChargeAnimset, "BmGame.RPawnVillain.GetPlayerChargeAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetChargeAnimSet;
    /// <summary>
    /// Function: GetChargeAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetChargeAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetChargeAnimSet, "BmGame.RPawnVillain.GetChargeAnimSet", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBMGrabAnimSet;
    /// <summary>
    /// Function: GetBMGrabAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetBMGrabAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBMGrabAnimSet, "BmGame.RPawnVillain.GetBMGrabAnimSet", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetGrabAnimSet;
    /// <summary>
    /// Function: GetGrabAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetGrabAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetGrabAnimSet, "BmGame.RPawnVillain.GetGrabAnimSet", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCameraAnimset;
    /// <summary>
    /// Function: GetCameraAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetCameraAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCameraAnimset, "BmGame.RPawnVillain.GetCameraAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerFloorTakedownAnimset;
    /// <summary>
    /// Function: GetPlayerFloorTakedownAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerFloorTakedownAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerFloorTakedownAnimset, "BmGame.RPawnVillain.GetPlayerFloorTakedownAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVillainFloorTakedownAnimset;
    /// <summary>
    /// Function: GetVillainFloorTakedownAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVillainFloorTakedownAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVillainFloorTakedownAnimset, "BmGame.RPawnVillain.GetVillainFloorTakedownAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerAerialAttackAnimset;
    /// <summary>
    /// Function: GetPlayerAerialAttackAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetPlayerAerialAttackAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerAerialAttackAnimset, "BmGame.RPawnVillain.GetPlayerAerialAttackAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVillainAerialAttackAnimset;
    /// <summary>
    /// Function: GetVillainAerialAttackAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVillainAerialAttackAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVillainAerialAttackAnimset, "BmGame.RPawnVillain.GetVillainAerialAttackAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBMCounterAnimSet;
    /// <summary>
    /// Function: GetBMCounterAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetBMCounterAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBMCounterAnimSet, "BmGame.RPawnVillain.GetBMCounterAnimSet", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCounterAnimSet;
    /// <summary>
    /// Function: GetCounterAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetCounterAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCounterAnimSet, "BmGame.RPawnVillain.GetCounterAnimSet", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearAnimsets;
    /// <summary>
    /// Function: ClearAnimsets
    /// </summary>
    public unsafe virtual void ClearAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearAnimsets, "BmGame.RPawnVillain.ClearAnimsets", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitAnimsets;
    /// <summary>
    /// Function: InitAnimsets
    /// </summary>
    public unsafe virtual void InitAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitAnimsets, "BmGame.RPawnVillain.InitAnimsets", this);
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

    /// <summary>
    /// Enum: EDamageAllowed
    /// </summary>
    public enum EDamageAllowed : byte
    {
        DA_PipeStrike = 0,
        DA_ShieldStrike = 1,
        DA_CriticalCounter = 2,
        DA_MAX = 3,
    }

    /// <summary>
    /// Enum: eLookDirection
    /// </summary>
    public enum eLookDirection : byte
    {
        ELD_Left = 0,
        ELD_Forward = 1,
        ELD_Right = 2,
        ELD_MAX = 3,
    }

    /// <summary>
    /// Struct: FLookAtDirection
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FLookAtDirection
    {
        /// <summary>
        /// ArrayProperty: Locations
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> Locations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FPotentialLookAtPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FPotentialLookAtPoint
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FBeatdownInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FBeatdownInfo
    {
        /// <summary>
        /// IntProperty: CurrStrike
        /// </summary>
        public unsafe int CurrStrike
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: TotalHitsToKOTarget
        /// </summary>
        public unsafe int TotalHitsToKOTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TimesCountered
        /// </summary>
        public unsafe int TimesCountered
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bStartedBeatdown
        /// </summary>
        public unsafe bool bStartedBeatdown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bWasAtRange
        /// </summary>
        public unsafe bool bWasAtRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: CombatReadinessState
    /// </summary>
    public enum CombatReadinessState : byte
    {
        CRS_None = 0,
        CRS_LoadingAnims = 1,
        CRS_AnimLoadFailed = 2,
        CRS_Ready = 3,
        CRS_MAX = 4,
    }

    /// <summary>
    /// Struct: FRegisteredPairedAnimsetInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FRegisteredPairedAnimsetInfo
    {
        /// <summary>
        /// ObjectProperty: PlayerAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet PlayerAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: VillainAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet VillainAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: CharacterName
        /// </summary>
        public unsafe BmSDK.FName CharacterName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FEnemyPosition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FEnemyPosition
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: AttackCounterTypes
    /// </summary>
    public enum AttackCounterTypes : byte
    {
        ACT_Counter = 0,
        ACT_Unblockable = 1,
        ACT_UnblockableNoIcon = 2,
        ACT_Blade = 3,
        ACT_Fury = 4,
        ACT_DualStrikeable = 5,
        ACT_ThrowCounterSuccess = 6,
        ACT_MAX = 7,
    }

    /// <summary>
    /// Enum: StuckRagdollSolutionType
    /// </summary>
    public enum StuckRagdollSolutionType : byte
    {
        SRST_LeaveStuck = 0,
        SRST_Freeze = 1,
        SRST_RemoveWhenOffScreen = 2,
        SRST_FreezeAndRemoveWhenOffScreen = 3,
        SRST_RemoveImmediately = 4,
        SRST_MAX = 5,
    }

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }

    /// <summary>
    /// ByteProperty: StuckRagdollSolution
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain.StuckRagdollSolutionType StuckRagdollSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain.StuckRagdollSolutionType>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }

    /// <summary>
    /// ByteProperty: BeatdownTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType BeatdownTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType>(Ptr + 4685); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4685); }
    }

    /// <summary>
    /// ByteProperty: AllowCounterAfterExitLimb
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CounterLimb AllowCounterAfterExitLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CounterLimb>(Ptr + 4686); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4686); }
    }

    /// <summary>
    /// ByteProperty: CombatReadiness
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain.CombatReadinessState CombatReadiness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain.CombatReadinessState>(Ptr + 4687); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4687); }
    }

    /// <summary>
    /// ByteProperty: CombatReadinessBot
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain.CombatReadinessState CombatReadinessBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain.CombatReadinessState>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// ByteProperty: SimultaneousAttackCounterLimb
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CounterLimb SimultaneousAttackCounterLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CounterLimb>(Ptr + 4689); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4689); }
    }

    /// <summary>
    /// ByteProperty: InteractButton
    /// </summary>
    public unsafe BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton InteractButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton>(Ptr + 4690); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4690); }
    }

    /// <summary>
    /// ByteProperty: PreChargeUpRagVsNav
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh PreChargeUpRagVsNav
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh>(Ptr + 4691); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4691); }
    }

    /// <summary>
    /// ObjectProperty: V2TakenDownCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_CasualtyBase V2TakenDownCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_CasualtyBase>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }

    /// <summary>
    /// ObjectProperty: IceBreakerCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_IceBreaker IceBreakerCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_IceBreaker>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Ragdoll
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Ragdoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Writhe
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Writhe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Attacked
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Attacked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_HitReaction
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_HitReaction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_HitReaction_Standing
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_HitReaction_Standing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_HitReaction_Combat
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_HitReaction_Combat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }

    /// <summary>
    /// ObjectProperty: TauntAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TauntAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// ObjectProperty: TauntMovementAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TauntMovementAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }

    /// <summary>
    /// ObjectProperty: CombatMovementAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CombatMovementAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// ObjectProperty: ThugInteractionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ThugInteractionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }

    /// <summary>
    /// ObjectProperty: DisableAIAlertsVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume DisableAIAlertsVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }

    /// <summary>
    /// ObjectProperty: SavedKiller
    /// </summary>
    public unsafe BmSDK.Engine.Controller SavedKiller
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// ObjectProperty: PlayerHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// ObjectProperty: RECHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RECHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// ObjectProperty: PlayerRedirectAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerRedirectAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// ObjectProperty: OverrideTargetPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat OverrideTargetPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ObjectProperty: PawnEffect
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnEffectComponent PawnEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnEffectComponent>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideKickPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMat_M
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance GlideKickMat_M
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GlideKickMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// ObjectProperty: BatDistractPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BatDistractPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }

    /// <summary>
    /// ObjectProperty: StoredCounterIconPlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController StoredCounterIconPlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4876); }
    }

    /// <summary>
    /// ObjectProperty: CurrentMedic
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrentMedic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 4884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4884); }
    }

    /// <summary>
    /// ObjectProperty: CurrentThrower
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainMultiStageBase CurrentThrower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainMultiStageBase>(Ptr + 4892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4892); }
    }

    /// <summary>
    /// ObjectProperty: CriticalHitPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CriticalHitPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4900); }
    }

    /// <summary>
    /// ObjectProperty: TrackTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor TrackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4908); }
    }

    /// <summary>
    /// ObjectProperty: DamageTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor DamageTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4916); }
    }

    /// <summary>
    /// ObjectProperty: ForceMissTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor ForceMissTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4924); }
    }

    /// <summary>
    /// ObjectProperty: RelatedHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint RelatedHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 4932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4932); }
    }

    /// <summary>
    /// ObjectProperty: PrimaryBarkCharDef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef PrimaryBarkCharDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }

    /// <summary>
    /// ObjectProperty: MyLevelVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume MyLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(Ptr + 4948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4948); }
    }

    /// <summary>
    /// ObjectProperty: VillainTargetPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer VillainTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }

    /// <summary>
    /// ObjectProperty: CombatTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CombatTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }

    /// <summary>
    /// ObjectProperty: ForceTargetPlayer
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController ForceTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 4972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4972); }
    }

    /// <summary>
    /// ObjectProperty: TargetPlayerOverride
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer TargetPlayerOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }

    /// <summary>
    /// ObjectProperty: ProcessKickedNoisePlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer ProcessKickedNoisePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_StartInterrogation InterrogationEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_StartInterrogation>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlayCameraConversation InterrogationAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlayCameraConversation>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationAura
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance InterrogationAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }

    /// <summary>
    /// ObjectProperty: XrayInterrogationAura
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance XrayInterrogationAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }

    /// <summary>
    /// ObjectProperty: BlockAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BlockAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }

    /// <summary>
    /// ObjectProperty: WalkCycleVariationAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet WalkCycleVariationAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 5036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5036); }
    }

    /// <summary>
    /// ObjectProperty: PauseCheckAreaAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PauseCheckAreaAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }

    /// <summary>
    /// ObjectProperty: StoredCannotBeTargettedByPlayer
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController StoredCannotBeTargettedByPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 5052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5052); }
    }

    /// <summary>
    /// ObjectProperty: SpriteMatIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SpriteMatIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }

    /// <summary>
    /// ObjectProperty: OverridenGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverridenGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }

    /// <summary>
    /// ObjectProperty: CarryingTrophy
    /// </summary>
    public unsafe BmSDK.BmGame.RPickup_Riddler CarryingTrophy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPickup_Riddler>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }

    /// <summary>
    /// ObjectProperty: ControllingRobin
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer ControllingRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }

    /// <summary>
    /// ObjectProperty: GrateTakenDownFrom
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateTakenDownFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }

    /// <summary>
    /// ObjectProperty: TunnelTakenDownFrom
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel TunnelTakenDownFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }

    /// <summary>
    /// ObjectProperty: ChargedUpBy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainThugMedic ChargedUpBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainThugMedic>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }

    /// <summary>
    /// ObjectProperty: ChargedUpShootPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChargedUpShootPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5116); }
    }

    /// <summary>
    /// ObjectProperty: ChargedUpHitPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChargedUpHitPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5124); }
    }

    /// <summary>
    /// ObjectProperty: MiniDroneTargetingMe
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterBase MiniDroneTargetingMe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }

    /// <summary>
    /// ObjectProperty: MyMiniDrone
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterBase MyMiniDrone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }

    /// <summary>
    /// ObjectProperty: SpecialGearDisruptedVFXTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SpecialGearDisruptedVFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }

    /// <summary>
    /// ObjectProperty: CombatLOSCheckVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume CombatLOSCheckVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }

    /// <summary>
    /// ObjectProperty: BombThugController
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_ActivateBombThugRiots BombThugController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_ActivateBombThugRiots>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }

    /// <summary>
    /// ObjectProperty: KnockBackIfShotVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume KnockBackIfShotVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 5172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5172); }
    }

    /// <summary>
    /// ObjectProperty: KnockBackPlayerConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig KnockBackPlayerConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }

    /// <summary>
    /// ObjectProperty: VillainBatclawSlamAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainBatclawSlamAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 5188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5188); }
    }

    /// <summary>
    /// ObjectProperty: DMDAECForBark
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase DMDAECForBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 5196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5196); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractInteraction
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractInteraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }

    /// <summary>
    /// ComponentProperty: DLCXtraMaskHeadMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent DLCXtraMaskHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }

    /// <summary>
    /// ComponentProperty: DLCXtraMaskBodyMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent DLCXtraMaskBodyMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5220); }
    }

    /// <summary>
    /// ClassProperty: BeatdownCombatMoveClass
    /// </summary>
    public unsafe BmSDK.Class BeatdownCombatMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInterrogationPredatorInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInterrogationPredatorInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }

    /// <summary>
    /// ComponentProperty: RHDInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent RHDInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }

    /// <summary>
    /// ComponentProperty: CatVisionParticleFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CatVisionParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// ComponentProperty: DeadParticleFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DeadParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }

    /// <summary>
    /// ComponentProperty: CriticalPfxComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CriticalPfxComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5276); }
    }

    /// <summary>
    /// ClassProperty: WeaponSwitchCallbackToNoneDamageType
    /// </summary>
    public unsafe BmSDK.Class WeaponSwitchCallbackToNoneDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }

    /// <summary>
    /// ClassProperty: LastDamageType
    /// </summary>
    public unsafe BmSDK.Class LastDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5292); }
    }

    /// <summary>
    /// ClassProperty: DeathDamageType
    /// </summary>
    public unsafe BmSDK.Class DeathDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }

    /// <summary>
    /// ComponentProperty: HeadPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HeadPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// ClassProperty: FreezeBlastHitBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class FreezeBlastHitBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }

    /// <summary>
    /// BoolProperty: bPlayedFallingSound
    /// </summary>
    public unsafe bool bPlayedFallingSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bUsesCustomCounterAnims
    /// </summary>
    public unsafe bool bUsesCustomCounterAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bDiedAlready
    /// </summary>
    public unsafe bool bDiedAlready
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bBeingTakenDown
    /// </summary>
    public unsafe bool bBeingTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAwardedRingOut
    /// </summary>
    public unsafe bool bAwardedRingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAwardedXP
    /// </summary>
    public unsafe bool bAwardedXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bCanDieByFalling
    /// </summary>
    public unsafe bool bCanDieByFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bStopSpeechOnDeath
    /// </summary>
    public unsafe bool bStopSpeechOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bCanCombatBark
    /// </summary>
    public unsafe bool bCanCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueWhenHit
    /// </summary>
    public unsafe bool bStopDialogueWhenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAwardDeathScore
    /// </summary>
    public unsafe bool bAwardDeathScore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bFlee
    /// </summary>
    public unsafe bool bFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bNeverFlee
    /// </summary>
    public unsafe bool bNeverFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bDontAlertPawnsInOtherPylons
    /// </summary>
    public unsafe bool bDontAlertPawnsInOtherPylons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bForceNonCombatSilentTakedown
    /// </summary>
    public unsafe bool bForceNonCombatSilentTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bPreventPredatorTakedownCam
    /// </summary>
    public unsafe bool bPreventPredatorTakedownCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bArmoured
    /// </summary>
    public unsafe bool bArmoured
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bBeatdownCountEqualsHealth
    /// </summary>
    public unsafe bool bBeatdownCountEqualsHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bCanPlayEnterCombatBark
    /// </summary>
    public unsafe bool bCanPlayEnterCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bShouldPreventFinalBlowCam
    /// </summary>
    public unsafe bool bShouldPreventFinalBlowCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bWearingExplosiveVest
    /// </summary>
    public unsafe bool bWearingExplosiveVest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bCanTargetBatmobile
    /// </summary>
    public unsafe bool bCanTargetBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bHiddenInXray
    /// </summary>
    public unsafe bool bHiddenInXray
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bHasRegisteredBatmobileKillBonus
    /// </summary>
    public unsafe bool bHasRegisteredBatmobileKillBonus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bGlideKickPSActive
    /// </summary>
    public unsafe bool bGlideKickPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAttackingPSActive
    /// </summary>
    public unsafe bool bAttackingPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAttackingPSShouldBeActive
    /// </summary>
    public unsafe bool bAttackingPSShouldBeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCombatStasisUntilBeenInView
    /// </summary>
    public unsafe bool bSuspendCombatStasisUntilBeenInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCombatStasis
    /// </summary>
    public unsafe bool bSuspendCombatStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bReduceGelForce
    /// </summary>
    public unsafe bool bReduceGelForce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bForceCombatTaunt
    /// </summary>
    public unsafe bool bForceCombatTaunt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToBatclawDisarm
    /// </summary>
    public unsafe bool bImmuneToBatclawDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bInfiniteBeatdown
    /// </summary>
    public unsafe bool bInfiniteBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bInfiniteBeatdownAlways
    /// </summary>
    public unsafe bool bInfiniteBeatdownAlways
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bNoBeatdownComboInc
    /// </summary>
    public unsafe bool bNoBeatdownComboInc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bUseSideStepsInCombat
    /// </summary>
    public unsafe bool bUseSideStepsInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bStartedWithGun
    /// </summary>
    public unsafe bool bStartedWithGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bMedic
    /// </summary>
    public unsafe bool bMedic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bPrioritiseReviving
    /// </summary>
    public unsafe bool bPrioritiseReviving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanBeRevived
    /// </summary>
    public unsafe bool bCanBeRevived
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bBypassStrikeCollisionChecks
    /// </summary>
    public unsafe bool bBypassStrikeCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanHelpUpThugs
    /// </summary>
    public unsafe bool bCanHelpUpThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bDiveAwayCollisionChecks
    /// </summary>
    public unsafe bool bDiveAwayCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanDiveAwayFromCars
    /// </summary>
    public unsafe bool bCanDiveAwayFromCars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanBeZappedByBatmobile
    /// </summary>
    public unsafe bool bCanBeZappedByBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bHitDamageTarget
    /// </summary>
    public unsafe bool bHitDamageTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bGoodAsDead
    /// </summary>
    public unsafe bool bGoodAsDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bAddedTakedownInvestigateInfo
    /// </summary>
    public unsafe bool bAddedTakedownInvestigateInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bHasContributedToFearLevel
    /// </summary>
    public unsafe bool bHasContributedToFearLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bStrungUp
    /// </summary>
    public unsafe bool bStrungUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bStrungUpBark
    /// </summary>
    public unsafe bool bStrungUpBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCutDown
    /// </summary>
    public unsafe bool bCutDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bDontUseEmotes
    /// </summary>
    public unsafe bool bDontUseEmotes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bPlayedImpactEmote
    /// </summary>
    public unsafe bool bPlayedImpactEmote
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanBeatdown
    /// </summary>
    public unsafe bool bCanBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bLoadPairedAnims
    /// </summary>
    public unsafe bool bLoadPairedAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bLoadPairedAnimsBot
    /// </summary>
    public unsafe bool bLoadPairedAnimsBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bLoadedPairedAnimsets
    /// </summary>
    public unsafe bool bLoadedPairedAnimsets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: RiotSurpressorCanKill
    /// </summary>
    public unsafe bool RiotSurpressorCanKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: JustClimbedLadder
    /// </summary>
    public unsafe bool JustClimbedLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bDoPostCutNotify
    /// </summary>
    public unsafe bool bDoPostCutNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bSelfManageTargetSelection
    /// </summary>
    public unsafe bool bSelfManageTargetSelection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bHasThermalGoggles
    /// </summary>
    public unsafe bool bHasThermalGoggles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bIsMobileJammer
    /// </summary>
    public unsafe bool bIsMobileJammer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bJammerDisabled
    /// </summary>
    public unsafe bool bJammerDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bJammerDestroyed
    /// </summary>
    public unsafe bool bJammerDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDetectiveModeDetector
    /// </summary>
    public unsafe bool bDetectiveModeDetector
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bWearingHeadset
    /// </summary>
    public unsafe bool bWearingHeadset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHasMines
    /// </summary>
    public unsafe bool bHasMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHasVantageMines
    /// </summary>
    public unsafe bool bHasVantageMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsNearThugMine
    /// </summary>
    public unsafe bool bIsNearThugMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsMinigunner
    /// </summary>
    public unsafe bool bIsMinigunner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHasStealthSuit
    /// </summary>
    public unsafe bool bHasStealthSuit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHasPredDrone
    /// </summary>
    public unsafe bool bHasPredDrone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsInformant
    /// </summary>
    public unsafe bool bIsInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsRiddlerTutorial
    /// </summary>
    public unsafe bool bIsRiddlerTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bInterrogateable
    /// </summary>
    public unsafe bool bInterrogateable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bBeingInterrogated
    /// </summary>
    public unsafe bool bBeingInterrogated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCanInterrogateFromFront
    /// </summary>
    public unsafe bool bCanInterrogateFromFront
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDontTriggerDynamicTutorial
    /// </summary>
    public unsafe bool bDontTriggerDynamicTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bShownInterrogationTutorial
    /// </summary>
    public unsafe bool bShownInterrogationTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCreatedInterrogateSpriteMat
    /// </summary>
    public unsafe bool bCreatedInterrogateSpriteMat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsPickPocketTarget
    /// </summary>
    public unsafe bool bIsPickPocketTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDisableSimultaneousAttacks
    /// </summary>
    public unsafe bool bDisableSimultaneousAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bInvulnerableToAnitFirearmGel
    /// </summary>
    public unsafe bool bInvulnerableToAnitFirearmGel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bAirStrikeable
    /// </summary>
    public unsafe bool bAirStrikeable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bAirPickupable
    /// </summary>
    public unsafe bool bAirPickupable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCanCheckFalling
    /// </summary>
    public unsafe bool bCanCheckFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowGroundTakedown
    /// </summary>
    public unsafe bool bForceAllowGroundTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bLastRECProjectileWasFromGarg
    /// </summary>
    public unsafe bool bLastRECProjectileWasFromGarg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bReceiveSoftPawnCollision_Old
    /// </summary>
    public unsafe bool bReceiveSoftPawnCollision_Old
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDodgesWhip
    /// </summary>
    public unsafe bool bAlwaysDodgesWhip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bEnteredCombatFromRange
    /// </summary>
    public unsafe bool bEnteredCombatFromRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCanTakeFreezeHit
    /// </summary>
    public unsafe bool bCanTakeFreezeHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCanTakeFreezeClusterHit
    /// </summary>
    public unsafe bool bCanTakeFreezeClusterHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bFocusAuraFlashing
    /// </summary>
    public unsafe bool bFocusAuraFlashing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bStickyBombAttached
    /// </summary>
    public unsafe bool bStickyBombAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bGooMineAttached
    /// </summary>
    public unsafe bool bGooMineAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bNoStrikeTargettingCollisionChecks
    /// </summary>
    public unsafe bool bNoStrikeTargettingCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTargettedForCombatTakedown
    /// </summary>
    public unsafe bool bCanBeTargettedForCombatTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToLineLaunchTakedown
    /// </summary>
    public unsafe bool bImmuneToLineLaunchTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bReportKOTypeGameAction
    /// </summary>
    public unsafe bool bReportKOTypeGameAction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCantTakeSuperBatclawSlam
    /// </summary>
    public unsafe bool bCantTakeSuperBatclawSlam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDisableBatarangHitReaction
    /// </summary>
    public unsafe bool bDisableBatarangHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDoNotStopDialogueOnActivate
    /// </summary>
    public unsafe bool bDoNotStopDialogueOnActivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bOverrideGlideKick
    /// </summary>
    public unsafe bool bOverrideGlideKick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDropAttack
    /// </summary>
    public unsafe bool bOverrideDropAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: isBagCarrier
    /// </summary>
    public unsafe bool isBagCarrier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bBagCarrierDistStartleSpecialCase
    /// </summary>
    public unsafe bool bBagCarrierDistStartleSpecialCase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPredAttackWhitelist
    /// </summary>
    public unsafe bool bPredAttackWhitelist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanBeShoved
    /// </summary>
    public unsafe bool bCanBeShoved
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanThrowCounter
    /// </summary>
    public unsafe bool bCanThrowCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToAntiWeaponGel
    /// </summary>
    public unsafe bool bDontReactToAntiWeaponGel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bLowDamage
    /// </summary>
    public unsafe bool bLowDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBatmobileThreat
    /// </summary>
    public unsafe bool bIgnoreBatmobileThreat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bEnterCombatWhenNextRunAway
    /// </summary>
    public unsafe bool bEnterCombatWhenNextRunAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bUpdateChain
    /// </summary>
    public unsafe bool bUpdateChain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bAllowFearTakedown
    /// </summary>
    public unsafe bool bAllowFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bWasTakendownByAFearTakedown
    /// </summary>
    public unsafe bool bWasTakendownByAFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCurrentFearTakedownTarget
    /// </summary>
    public unsafe bool bCurrentFearTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bNotScaredOfBatmobile
    /// </summary>
    public unsafe bool bNotScaredOfBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDLCIsPlantTarget
    /// </summary>
    public unsafe bool bDLCIsPlantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsDLCSniper
    /// </summary>
    public unsafe bool bIsDLCSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsOnLadder
    /// </summary>
    public unsafe bool bIsOnLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsPuzzleRobot
    /// </summary>
    public unsafe bool bIsPuzzleRobot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanInteract
    /// </summary>
    public unsafe bool bCanInteract
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanInteractWhenDead
    /// </summary>
    public unsafe bool bCanInteractWhenDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bInteractPromptOverridePreviousLines
    /// </summary>
    public unsafe bool bInteractPromptOverridePreviousLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bNoInteractPrompt
    /// </summary>
    public unsafe bool bNoInteractPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bDontAnnounceManDown
    /// </summary>
    public unsafe bool bDontAnnounceManDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bForceIntoTauntASAP
    /// </summary>
    public unsafe bool bForceIntoTauntASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bSpecialGearIsDisrupted
    /// </summary>
    public unsafe bool bSpecialGearIsDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bInDMDOutTransition
    /// </summary>
    public unsafe bool bInDMDOutTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bCanUseEnvironmentPickup
    /// </summary>
    public unsafe bool bCanUseEnvironmentPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bBombThugAuraActive
    /// </summary>
    public unsafe bool bBombThugAuraActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bCanThrowGrenadesIfUnarmed
    /// </summary>
    public unsafe bool bCanThrowGrenadesIfUnarmed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bHasSeenBatman
    /// </summary>
    public unsafe bool bHasSeenBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bHasSeenBatmobile
    /// </summary>
    public unsafe bool bHasSeenBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bKilledByLedgeTakedown
    /// </summary>
    public unsafe bool bKilledByLedgeTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// FloatProperty: FallingTime
    /// </summary>
    public unsafe float FallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5344); }
    }

    /// <summary>
    /// StructProperty: FallingPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FallingPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5348);

    /// <summary>
    /// FloatProperty: FallingStartHeight
    /// </summary>
    public unsafe float FallingStartHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }

    /// <summary>
    /// IntProperty: RetrySplashAndDestroyCount
    /// </summary>
    public unsafe int RetrySplashAndDestroyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// FloatProperty: AntiDodgeFactor
    /// </summary>
    public unsafe float AntiDodgeFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5368); }
    }

    /// <summary>
    /// IntProperty: KillFallSpeed
    /// </summary>
    public unsafe int KillFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }

    /// <summary>
    /// IntProperty: DestroyFallSpeed
    /// </summary>
    public unsafe int DestroyFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5376); }
    }

    /// <summary>
    /// StructProperty: AvoidanceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AvoidanceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5380);

    /// <summary>
    /// ArrayProperty: OverlayAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> OverlayAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5392); }
    }

    /// <summary>
    /// ArrayProperty: ArmouredOverlayAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ArmouredOverlayAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5408); }
    }

    /// <summary>
    /// NameProperty: CanOnlyBeHitBy
    /// </summary>
    public unsafe BmSDK.FName CanOnlyBeHitBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5424); }
    }

    /// <summary>
    /// IntProperty: TauntSetID
    /// </summary>
    public unsafe int TauntSetID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5432); }
    }

    /// <summary>
    /// ArrayProperty: TauntAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo> TauntAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo>>(Ptr + 5436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5436); }
    }

    /// <summary>
    /// ArrayProperty: TauntMovementAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> TauntMovementAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }

    /// <summary>
    /// IntProperty: ForceTauntSetID
    /// </summary>
    public unsafe int ForceTauntSetID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// ArrayProperty: StepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> StepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5472); }
    }

    /// <summary>
    /// FloatProperty: StepLength
    /// </summary>
    public unsafe float StepLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5488); }
    }

    /// <summary>
    /// ArrayProperty: LongStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> LongStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// NameProperty: ForwardStepName
    /// </summary>
    public unsafe BmSDK.FName ForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// FloatProperty: DelayBeforeActiveCombat
    /// </summary>
    public unsafe float DelayBeforeActiveCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// IntProperty: LastComboSizeWhenHit
    /// </summary>
    public unsafe int LastComboSizeWhenHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }

    /// <summary>
    /// FloatProperty: MonitorRagdollForHighVelocityTimer
    /// </summary>
    public unsafe float MonitorRagdollForHighVelocityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// IntProperty: RingOutCombo
    /// </summary>
    public unsafe int RingOutCombo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5528); }
    }

    /// <summary>
    /// FloatProperty: PostHitNoTakedownTimer
    /// </summary>
    public unsafe float PostHitNoTakedownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// FloatProperty: CombatDistance
    /// </summary>
    public unsafe float CombatDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5536); }
    }

    /// <summary>
    /// IntProperty: StoredCounterIconType
    /// </summary>
    public unsafe int StoredCounterIconType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// FloatProperty: RagdollForceMultiplier
    /// </summary>
    public unsafe float RagdollForceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5544); }
    }

    /// <summary>
    /// IntProperty: MedicRevivesRemaining
    /// </summary>
    public unsafe int MedicRevivesRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// FloatProperty: DelayWeaponPickupTime
    /// </summary>
    public unsafe float DelayWeaponPickupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5552); }
    }

    /// <summary>
    /// ArrayProperty: SavedPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FEnemyPosition> SavedPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FEnemyPosition>>(Ptr + 5556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5556); }
    }

    /// <summary>
    /// FloatProperty: TrackHistoryTime
    /// </summary>
    public unsafe float TrackHistoryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }

    /// <summary>
    /// FloatProperty: StoredFearLevel
    /// </summary>
    public unsafe float StoredFearLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5576); }
    }

    /// <summary>
    /// FloatProperty: DodgeCurrent
    /// </summary>
    public unsafe float DodgeCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }

    /// <summary>
    /// StructProperty: HangGrabLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangGrabLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5584);

    /// <summary>
    /// StructProperty: HangRopeEndLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangRopeEndLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5596);

    /// <summary>
    /// StructProperty: HangFloorBelowLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangFloorBelowLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5608);

    /// <summary>
    /// FloatProperty: PawnBatarangStunModifier
    /// </summary>
    public unsafe float PawnBatarangStunModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }

    /// <summary>
    /// StrProperty: PrimaryBCDstring
    /// </summary>
    public unsafe BmSDK.FString PrimaryBCDstring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5624); }
    }

    /// <summary>
    /// ArrayProperty: PreferredBarkSet
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkSet> PreferredBarkSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkSet>>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }

    /// <summary>
    /// FloatProperty: JewelleryValue
    /// </summary>
    public unsafe float JewelleryValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }

    /// <summary>
    /// IntProperty: JewelleryIndex
    /// </summary>
    public unsafe int JewelleryIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPairedAnimsetPackageDefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FPairedAnimsetPackageDef> PlayerPairedAnimsetPackageDefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FPairedAnimsetPackageDef>>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }

    /// <summary>
    /// IntProperty: CurrPairedAnimsetIndex
    /// </summary>
    public unsafe int CurrPairedAnimsetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }

    /// <summary>
    /// IntProperty: CurrPairedAnimsetIndexBot
    /// </summary>
    public unsafe int CurrPairedAnimsetIndexBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredPairedAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FRegisteredPairedAnimsetInfo> RegisteredPairedAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FRegisteredPairedAnimsetInfo>>(Ptr + 5688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5688); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredDualStrikeTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeType> RegisteredDualStrikeTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeType>>(Ptr + 5704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5704); }
    }

    /// <summary>
    /// StrProperty: LoadingPairedAnimsetPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingPairedAnimsetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5720); }
    }

    /// <summary>
    /// StrProperty: LoadingPairedAnimsetPackageBot
    /// </summary>
    public unsafe BmSDK.FString LoadingPairedAnimsetPackageBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5736); }
    }

    /// <summary>
    /// ArrayProperty: CombatAnimsetRefHolders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue> CombatAnimsetRefHolders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue>>(Ptr + 5752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5752); }
    }

    /// <summary>
    /// IntProperty: HitRatioCounter
    /// </summary>
    public unsafe int HitRatioCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5768); }
    }

    /// <summary>
    /// FloatProperty: CustomAntiPersonelStunTime
    /// </summary>
    public unsafe float CustomAntiPersonelStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// IntProperty: GetUpAttempts
    /// </summary>
    public unsafe int GetUpAttempts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5776); }
    }

    /// <summary>
    /// StructProperty: StoredCasPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StoredCasPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5780);

    /// <summary>
    /// FloatProperty: StoredCasPosTime
    /// </summary>
    public unsafe float StoredCasPosTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5792); }
    }

    /// <summary>
    /// NameProperty: RagdollRestTestBone
    /// </summary>
    public unsafe BmSDK.FName RagdollRestTestBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }

    /// <summary>
    /// FloatProperty: LinearRestThreshold
    /// </summary>
    public unsafe float LinearRestThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }

    /// <summary>
    /// FloatProperty: AngularRestThreshold
    /// </summary>
    public unsafe float AngularRestThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5808); }
    }

    /// <summary>
    /// StructProperty: ServerLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ServerLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5812);

    /// <summary>
    /// StructProperty: ServerRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ServerRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 5824);

    /// <summary>
    /// StructProperty: StateAtTimeOfKick
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FAIAwarenessState StateAtTimeOfKick
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FAIAwarenessState>(Ptr + 5836);

    /// <summary>
    /// FloatProperty: InterrogateTutorialTime
    /// </summary>
    public unsafe float InterrogateTutorialTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5964); }
    }

    /// <summary>
    /// StrProperty: InteractPrompt
    /// </summary>
    public unsafe BmSDK.FString InteractPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5968); }
    }

    /// <summary>
    /// NameProperty: AerialAttackAnimName
    /// </summary>
    public unsafe BmSDK.FName AerialAttackAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5984); }
    }

    /// <summary>
    /// ArrayProperty: OverrideStealthTakedown
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> OverrideStealthTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 5992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5992); }
    }

    /// <summary>
    /// ArrayProperty: DualTeamTakedowns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> DualTeamTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }

    /// <summary>
    /// FloatProperty: BatclawReleaseTime
    /// </summary>
    public unsafe float BatclawReleaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6024); }
    }

    /// <summary>
    /// ArrayProperty: BatclawSocketTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BatclawSocketTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 6028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6028); }
    }

    /// <summary>
    /// FloatProperty: FreezeTime
    /// </summary>
    public unsafe float FreezeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6044); }
    }

    /// <summary>
    /// FloatProperty: FloorFreezeTime
    /// </summary>
    public unsafe float FloorFreezeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }

    /// <summary>
    /// FloatProperty: GooSprayImpulseMultiplier
    /// </summary>
    public unsafe float GooSprayImpulseMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }

    /// <summary>
    /// StructProperty: LastBeatdownInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnVillain.FBeatdownInfo LastBeatdownInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnVillain.FBeatdownInfo>(Ptr + 6056);

    /// <summary>
    /// StructProperty: MagnetisedWeaponHitTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId MagnetisedWeaponHitTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 6072);

    /// <summary>
    /// ArrayProperty: MFAAttractReceivers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMagneticBlastReceiver> MFAAttractReceivers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticBlastReceiver>>(Ptr + 6076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6076); }
    }

    /// <summary>
    /// ArrayProperty: MFAStuckWeapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject> MFAStuckWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject>>(Ptr + 6092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6092); }
    }

    /// <summary>
    /// StructProperty: FearGasHitTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId FearGasHitTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 6108);

    /// <summary>
    /// FloatProperty: LastBlockTime
    /// </summary>
    public unsafe float LastBlockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6112); }
    }

    /// <summary>
    /// IntProperty: SurprisedByBatarang
    /// </summary>
    public unsafe int SurprisedByBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6116); }
    }

    /// <summary>
    /// StructProperty: LastRECProjectileSourcePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastRECProjectileSourcePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6120);

    /// <summary>
    /// StructProperty: StartCombatLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartCombatLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6132);

    /// <summary>
    /// NameProperty: RECTargetBone
    /// </summary>
    public unsafe BmSDK.FName RECTargetBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6144); }
    }

    /// <summary>
    /// FloatProperty: LastCowerTime
    /// </summary>
    public unsafe float LastCowerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6152); }
    }

    /// <summary>
    /// ArrayProperty: DropPropsArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> DropPropsArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor>>(Ptr + 6156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6156); }
    }

    /// <summary>
    /// FloatProperty: FocusAuraFlashTimer
    /// </summary>
    public unsafe float FocusAuraFlashTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6172); }
    }

    /// <summary>
    /// IntProperty: CowerProjectileID
    /// </summary>
    public unsafe int CowerProjectileID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6176); }
    }

    /// <summary>
    /// FloatProperty: GettingUpFromRagdollTimer
    /// </summary>
    public unsafe float GettingUpFromRagdollTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6180); }
    }

    /// <summary>
    /// FloatProperty: fOverrideGlideKickStartDuration
    /// </summary>
    public unsafe float fOverrideGlideKickStartDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6184); }
    }

    /// <summary>
    /// FloatProperty: fOverrideDropAttackHeight
    /// </summary>
    public unsafe float fOverrideDropAttackHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6188); }
    }

    /// <summary>
    /// FloatProperty: fOverrideDropAttackMaxHorzDist
    /// </summary>
    public unsafe float fOverrideDropAttackMaxHorzDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6192); }
    }

    /// <summary>
    /// FloatProperty: BatmobileThreatTime
    /// </summary>
    public unsafe float BatmobileThreatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6196); }
    }

    /// <summary>
    /// FloatProperty: timeOfDeath
    /// </summary>
    public unsafe float timeOfDeath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6200); }
    }

    /// <summary>
    /// ArrayProperty: DamageAllowed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain.EDamageAllowed> DamageAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain.EDamageAllowed>>(Ptr + 6204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6204); }
    }

    /// <summary>
    /// ArrayProperty: TakedownAllowed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages> TakedownAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>>(Ptr + 6220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6220); }
    }

    /// <summary>
    /// FloatProperty: InteractPriority
    /// </summary>
    public unsafe float InteractPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6236); }
    }

    /// <summary>
    /// ArrayProperty: GadgetProjHistory
    /// </summary>
    public unsafe BmSDK.TArray<float> GadgetProjHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }

    /// <summary>
    /// StructProperty: vJammedVFXPivotParameter
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vJammedVFXPivotParameter
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6256);

    /// <summary>
    /// FloatProperty: fJammedVFXRadiusParameter
    /// </summary>
    public unsafe float fJammedVFXRadiusParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6268); }
    }

    /// <summary>
    /// FloatProperty: fJammedVFXLengthParameter
    /// </summary>
    public unsafe float fJammedVFXLengthParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6272); }
    }

    /// <summary>
    /// StructProperty: DMDOutAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId DMDOutAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 6276);

    /// <summary>
    /// FloatProperty: DistForMediumThugPickup
    /// </summary>
    public unsafe float DistForMediumThugPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6280); }
    }

    /// <summary>
    /// FloatProperty: DistForFarThugPickup
    /// </summary>
    public unsafe float DistForFarThugPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6284); }
    }

    /// <summary>
    /// StructProperty: LastGrateWatchPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastGrateWatchPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6288);

    /// <summary>
    /// StructProperty: LastValidBatmobileTakedownPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastValidBatmobileTakedownPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6300);

    /// <summary>
    /// FloatProperty: AttackDelay
    /// </summary>
    public unsafe float AttackDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6312); }
    }

    /// <summary>
    /// StructProperty: KnockBackDirection
    /// </summary>
    public unsafe ref BmSDK.Rotator KnockBackDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 6316);

    /// <summary>
    /// ArrayProperty: CounterAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> CounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6328); }
    }

    /// <summary>
    /// ArrayProperty: BMCounterAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> BMCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6344); }
    }

    /// <summary>
    /// ArrayProperty: BeatdownHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> BeatdownHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6360); }
    }

    /// <summary>
    /// ArrayProperty: VillainAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> VillainAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6376); }
    }

    /// <summary>
    /// ArrayProperty: PlayerAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6392); }
    }

    /// <summary>
    /// ArrayProperty: VillainFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> VillainFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6408); }
    }

    /// <summary>
    /// ArrayProperty: PlayerFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6424); }
    }

    /// <summary>
    /// ArrayProperty: CameraAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> CameraAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }

    /// <summary>
    /// ArrayProperty: GrabAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> GrabAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }

    /// <summary>
    /// ArrayProperty: BMGrabAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> BMGrabAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6472); }
    }

    /// <summary>
    /// ArrayProperty: ChargeAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> ChargeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6488); }
    }

    /// <summary>
    /// ArrayProperty: PlayerChargeAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerChargeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// ArrayProperty: PlayerDualPlayAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerDualPlayAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6520); }
    }

    /// <summary>
    /// ArrayProperty: VillainDualPlayAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> VillainDualPlayAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6536); }
    }

    /// <summary>
    /// ArrayProperty: VillainEnvTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> VillainEnvTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6552); }
    }

    /// <summary>
    /// ArrayProperty: PlayerEnvTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerEnvTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6568); }
    }

    /// <summary>
    /// ArrayProperty: VillainPredTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> VillainPredTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6584); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPredTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerPredTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6600); }
    }

    /// <summary>
    /// ArrayProperty: VillainFloorPickupAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> VillainFloorPickupAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6616); }
    }

    /// <summary>
    /// ArrayProperty: PlayerFloorPickupAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerFloorPickupAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 6632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6632); }
    }

    /// <summary>
    /// NameProperty: DMDAttackFailBarkFlag
    /// </summary>
    public unsafe BmSDK.FName DMDAttackFailBarkFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6648); }
    }

    /// <summary>
    /// NameProperty: DMDAttackSuccessBarkFlag
    /// </summary>
    public unsafe BmSDK.FName DMDAttackSuccessBarkFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6656); }
    }
}
