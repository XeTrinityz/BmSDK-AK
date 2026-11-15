#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerNightwing<br/>
/// (size = 10152)
/// (flags = 10486326)
/// </summary>
public partial class RPawnPlayerNightwing : BmSDK.BmGame.RPawnPlayerNightwingBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerNightwing", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerNightwing.
    /// </summary>
    public static RPawnPlayerNightwing DefaultObject => (RPawnPlayerNightwing)StaticClass().DefaultObject;

    internal RPawnPlayerNightwing() { }

    /// <summary>
    /// Constructs a new RPawnPlayerNightwing
    /// </summary>
    public RPawnPlayerNightwing(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerNightwing(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwing>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwing>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwing>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwing>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwing>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwing>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwing>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwing>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSuperStunAnimSet;
    /// <summary>
    /// Function: GetSuperStunAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetSuperStunAnimSet(bool bHasWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSuperStunAnimSet, "BmScript.RPawnPlayerNightwing.GetSuperStunAnimSet", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnBatclawRedirect;
    /// <summary>
    /// Function: SpawnBatclawRedirect
    /// </summary>
    public unsafe override void SpawnBatclawRedirect(BmSDK.BmGame.RPawnCombat TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnBatclawRedirect, "BmScript.RPawnPlayerNightwing.SpawnBatclawRedirect", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeTrailPS;
    /// <summary>
    /// Function: GetStrikeTrailPS
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GetStrikeTrailPS(BmSDK.Class StrikeDmgType, bool bIsSuperStrike, int ComboLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeTrailPS, "BmScript.RPawnPlayerNightwing.GetStrikeTrailPS", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSuperStrike, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboLevel, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBetweenHandsPosition;
    /// <summary>
    /// Function: GetBetweenHandsPosition
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetBetweenHandsPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBetweenHandsPosition, "BmScript.RPawnPlayerNightwing.GetBetweenHandsPosition", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFailedPairedAnimMoveAnimset;
    /// <summary>
    /// Function: GetFailedPairedAnimMoveAnimset
    /// </summary>
    public unsafe override void GetFailedPairedAnimMoveAnimset(out BmSDK.Engine.AnimSet MyAnimset, BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFailedPairedAnimMoveAnimset, "BmScript.RPawnPlayerNightwing.GetFailedPairedAnimMoveAnimset", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MyAnimset);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MyAnimset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MyAnimset = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateBetweenSticksBeam;
    /// <summary>
    /// Function: UpdateBetweenSticksBeam
    /// </summary>
    public unsafe virtual void UpdateBetweenSticksBeam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateBetweenSticksBeam, "BmScript.RPawnPlayerNightwing.UpdateBetweenSticksBeam", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideBeamBetweenSticks;
    /// <summary>
    /// Function: HideBeamBetweenSticks
    /// </summary>
    public unsafe virtual void HideBeamBetweenSticks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideBeamBetweenSticks, "BmScript.RPawnPlayerNightwing.HideBeamBetweenSticks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowBeamBetweenSticks;
    /// <summary>
    /// Function: ShowBeamBetweenSticks
    /// </summary>
    public unsafe virtual void ShowBeamBetweenSticks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowBeamBetweenSticks, "BmScript.RPawnPlayerNightwing.ShowBeamBetweenSticks", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUnlockedMeleeArmourLevel;
    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedMeleeArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUnlockedMeleeArmourLevel, "BmScript.RPawnPlayerNightwing.GetUnlockedMeleeArmourLevel", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUnlockedBallisticArmourLevel, "BmScript.RPawnPlayerNightwing.GetUnlockedBallisticArmourLevel", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySound_Impact;
    /// <summary>
    /// Function: PlaySound_Impact
    /// </summary>
    public unsafe override void PlaySound_Impact(BmSDK.BmGame.RPawnCombat Villain, bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bIsQuick = default, bool bPlayerAttacked = default, bool bForceEmote = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySound_Impact, "BmScript.RPawnPlayerNightwing.PlaySound_Impact", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVenomHitReactionAnimSet;
    /// <summary>
    /// Function: GetVenomHitReactionAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetVenomHitReactionAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVenomHitReactionAnimSet, "BmScript.RPawnPlayerNightwing.GetVenomHitReactionAnimSet", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeMovementStance;
    /// <summary>
    /// Function: GetStrikeMovementStance
    /// </summary>
    public unsafe override BmSDK.FName GetStrikeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeMovementStance, "BmScript.RPawnPlayerNightwing.GetStrikeMovementStance", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCinematicModeMovementStance;
    /// <summary>
    /// Function: GetCinematicModeMovementStance
    /// </summary>
    public unsafe override BmSDK.FName GetCinematicModeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCinematicModeMovementStance, "BmScript.RPawnPlayerNightwing.GetCinematicModeMovementStance", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetWalkingModeMovementStance;
    /// <summary>
    /// Function: GetWalkingModeMovementStance
    /// </summary>
    public unsafe override BmSDK.FName GetWalkingModeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetWalkingModeMovementStance, "BmScript.RPawnPlayerNightwing.GetWalkingModeMovementStance", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NofifyBeginStateBatarangPrimed;
    /// <summary>
    /// Function: NofifyBeginStateBatarangPrimed
    /// </summary>
    public unsafe override void NofifyBeginStateBatarangPrimed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NofifyBeginStateBatarangPrimed, "BmScript.RPawnPlayerNightwing.NofifyBeginStateBatarangPrimed", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyGadgetEquip;
    /// <summary>
    /// Function: NotifyGadgetEquip
    /// </summary>
    public unsafe override void NotifyGadgetEquip(bool equip)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyGadgetEquip, "BmScript.RPawnPlayerNightwing.NotifyGadgetEquip", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(equip, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnBatclawSlam, "BmScript.RPawnPlayerNightwing.SpawnBatclawSlam", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Died, "BmScript.RPawnPlayerNightwing.Died", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAfterCombatAnim;
    /// <summary>
    /// Function: GetAfterCombatAnim
    /// </summary>
    public unsafe override BmSDK.FName GetAfterCombatAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAfterCombatAnim, "BmScript.RPawnPlayerNightwing.GetAfterCombatAnim", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBeforeAndAfterCombatAnimset;
    /// <summary>
    /// Function: GetBeforeAndAfterCombatAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetBeforeAndAfterCombatAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBeforeAndAfterCombatAnimset, "BmScript.RPawnPlayerNightwing.GetBeforeAndAfterCombatAnimset", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PounceOnThug;
    /// <summary>
    /// Function: PounceOnThug
    /// </summary>
    public unsafe override void PounceOnThug(BmSDK.BmGame.RPawnVillain Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PounceOnThug, "BmScript.RPawnPlayerNightwing.PounceOnThug", this);
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HopOffVantagePoint;
    /// <summary>
    /// Function: HopOffVantagePoint
    /// </summary>
    public unsafe override void HopOffVantagePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HopOffVantagePoint, "BmScript.RPawnPlayerNightwing.HopOffVantagePoint", this);
        byte* paramsPtr = stackalloc byte[240];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideWeaponRight;
    /// <summary>
    /// Function: HideWeaponRight
    /// </summary>
    public unsafe virtual void HideWeaponRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideWeaponRight, "BmScript.RPawnPlayerNightwing.HideWeaponRight", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowWeaponRightSmall;
    /// <summary>
    /// Function: ShowWeaponRightSmall
    /// </summary>
    public unsafe virtual void ShowWeaponRightSmall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowWeaponRightSmall, "BmScript.RPawnPlayerNightwing.ShowWeaponRightSmall", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowWeaponRight;
    /// <summary>
    /// Function: ShowWeaponRight
    /// </summary>
    public unsafe virtual void ShowWeaponRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowWeaponRight, "BmScript.RPawnPlayerNightwing.ShowWeaponRight", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideWeaponLeft;
    /// <summary>
    /// Function: HideWeaponLeft
    /// </summary>
    public unsafe virtual void HideWeaponLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideWeaponLeft, "BmScript.RPawnPlayerNightwing.HideWeaponLeft", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowWeaponLeftSmall;
    /// <summary>
    /// Function: ShowWeaponLeftSmall
    /// </summary>
    public unsafe virtual void ShowWeaponLeftSmall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowWeaponLeftSmall, "BmScript.RPawnPlayerNightwing.ShowWeaponLeftSmall", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowWeaponLeft;
    /// <summary>
    /// Function: ShowWeaponLeft
    /// </summary>
    public unsafe virtual void ShowWeaponLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowWeaponLeft, "BmScript.RPawnPlayerNightwing.ShowWeaponLeft", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayStickAnimRight;
    /// <summary>
    /// Function: PlayStickAnimRight
    /// </summary>
    public unsafe virtual void PlayStickAnimRight(BmSDK.FName AnimName, float Speed = default, float StartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayStickAnimRight, "BmScript.RPawnPlayerNightwing.PlayStickAnimRight", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayStickAnimLeft;
    /// <summary>
    /// Function: PlayStickAnimLeft
    /// </summary>
    public unsafe virtual void PlayStickAnimLeft(BmSDK.FName AnimName, float Speed = default, float StartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayStickAnimLeft, "BmScript.RPawnPlayerNightwing.PlayStickAnimLeft", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayStowSticksAnim;
    /// <summary>
    /// Function: PlayStowSticksAnim
    /// </summary>
    public unsafe virtual bool PlayStowSticksAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayStowSticksAnim, "BmScript.RPawnPlayerNightwing.PlayStowSticksAnim", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideWeapons;
    /// <summary>
    /// Function: HideWeapons
    /// </summary>
    public unsafe virtual void HideWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideWeapons, "BmScript.RPawnPlayerNightwing.HideWeapons", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideWeaponsWithFlourish;
    /// <summary>
    /// Function: HideWeaponsWithFlourish
    /// </summary>
    public unsafe virtual void HideWeaponsWithFlourish()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideWeaponsWithFlourish, "BmScript.RPawnPlayerNightwing.HideWeaponsWithFlourish", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowWeaponsSmall;
    /// <summary>
    /// Function: ShowWeaponsSmall
    /// </summary>
    public unsafe virtual void ShowWeaponsSmall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowWeaponsSmall, "BmScript.RPawnPlayerNightwing.ShowWeaponsSmall", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowWeapons;
    /// <summary>
    /// Function: ShowWeapons
    /// </summary>
    public unsafe virtual void ShowWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowWeapons, "BmScript.RPawnPlayerNightwing.ShowWeapons", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShrinkWeapons;
    /// <summary>
    /// Function: ShrinkWeapons
    /// </summary>
    public unsafe virtual void ShrinkWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShrinkWeapons, "BmScript.RPawnPlayerNightwing.ShrinkWeapons", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GrowWeapons;
    /// <summary>
    /// Function: GrowWeapons
    /// </summary>
    public unsafe virtual void GrowWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GrowWeapons, "BmScript.RPawnPlayerNightwing.GrowWeapons", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StrikeStanceReversed;
    /// <summary>
    /// Function: StrikeStanceReversed
    /// </summary>
    public unsafe virtual void StrikeStanceReversed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StrikeStanceReversed, "BmScript.RPawnPlayerNightwing.StrikeStanceReversed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisablePostCombatStance;
    /// <summary>
    /// Function: DisablePostCombatStance
    /// </summary>
    public unsafe virtual void DisablePostCombatStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisablePostCombatStance, "BmScript.RPawnPlayerNightwing.DisablePostCombatStance", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeInitAttackMoveWeaponsFromCancelSpecialMove;
    /// <summary>
    /// Function: DeInitAttackMoveWeaponsFromCancelSpecialMove
    /// </summary>
    public unsafe override void DeInitAttackMoveWeaponsFromCancelSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeInitAttackMoveWeaponsFromCancelSpecialMove, "BmScript.RPawnPlayerNightwing.DeInitAttackMoveWeaponsFromCancelSpecialMove", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeInitAttackMoveWeaponsFromFinishSpecialMove;
    /// <summary>
    /// Function: DeInitAttackMoveWeaponsFromFinishSpecialMove
    /// </summary>
    public unsafe override void DeInitAttackMoveWeaponsFromFinishSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeInitAttackMoveWeaponsFromFinishSpecialMove, "BmScript.RPawnPlayerNightwing.DeInitAttackMoveWeaponsFromFinishSpecialMove", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeInitAttackMoveWeapons;
    /// <summary>
    /// Function: DeInitAttackMoveWeapons
    /// </summary>
    public unsafe override void DeInitAttackMoveWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeInitAttackMoveWeapons, "BmScript.RPawnPlayerNightwing.DeInitAttackMoveWeapons", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitAttackMoveWeapons;
    /// <summary>
    /// Function: InitAttackMoveWeapons
    /// </summary>
    public unsafe override void InitAttackMoveWeapons(bool bMirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitAttackMoveWeapons, "BmScript.RPawnPlayerNightwing.InitAttackMoveWeapons", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowWeaponsForPenguinCacheC5;
    /// <summary>
    /// Function: ShowWeaponsForPenguinCacheC5
    /// </summary>
    public unsafe virtual void ShowWeaponsForPenguinCacheC5()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowWeaponsForPenguinCacheC5, "BmScript.RPawnPlayerNightwing.ShowWeaponsForPenguinCacheC5", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideWeaponsForPenguinCacheC5;
    /// <summary>
    /// Function: HideWeaponsForPenguinCacheC5
    /// </summary>
    public unsafe virtual void HideWeaponsForPenguinCacheC5()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideWeaponsForPenguinCacheC5, "BmScript.RPawnPlayerNightwing.HideWeaponsForPenguinCacheC5", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideWeaponsForWeaponGrab;
    /// <summary>
    /// Function: HideWeaponsForWeaponGrab
    /// </summary>
    public unsafe override void HideWeaponsForWeaponGrab()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideWeaponsForWeaponGrab, "BmScript.RPawnPlayerNightwing.HideWeaponsForWeaponGrab", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideChangeRunningModeStance;
    /// <summary>
    /// Function: OverrideChangeRunningModeStance
    /// </summary>
    public unsafe override bool OverrideChangeRunningModeStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideChangeRunningModeStance, "BmScript.RPawnPlayerNightwing.OverrideChangeRunningModeStance", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideChangeWalkingModeStance;
    /// <summary>
    /// Function: OverrideChangeWalkingModeStance
    /// </summary>
    public unsafe override bool OverrideChangeWalkingModeStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideChangeWalkingModeStance, "BmScript.RPawnPlayerNightwing.OverrideChangeWalkingModeStance", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayRicochetCatchAnim;
    /// <summary>
    /// Function: PlayRicochetCatchAnim
    /// </summary>
    public unsafe virtual void PlayRicochetCatchAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayRicochetCatchAnim, "BmScript.RPawnPlayerNightwing.PlayRicochetCatchAnim", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnCatchRicochetStick;
    /// <summary>
    /// Function: OnCatchRicochetStick
    /// </summary>
    public unsafe virtual void OnCatchRicochetStick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnCatchRicochetStick, "BmScript.RPawnPlayerNightwing.OnCatchRicochetStick", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe override void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CombatMoveInitialised, "BmScript.RPawnPlayerNightwing.CombatMoveInitialised", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnThrowRicochetStick;
    /// <summary>
    /// Function: OnThrowRicochetStick
    /// </summary>
    public unsafe virtual void OnThrowRicochetStick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnThrowRicochetStick, "BmScript.RPawnPlayerNightwing.OnThrowRicochetStick", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDefaultInventory, "BmScript.RPawnPlayerNightwing.AddDefaultInventory", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddNightwingMovesToWeaponConfig;
    /// <summary>
    /// Function: AddNightwingMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddNightwingMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddNightwingMovesToWeaponConfig, "BmScript.RPawnPlayerNightwing.AddNightwingMovesToWeaponConfig", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddMovementMovesToWeaponConfig;
    /// <summary>
    /// Function: AddMovementMovesToWeaponConfig
    /// </summary>
    public unsafe override void AddMovementMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddMovementMovesToWeaponConfig, "BmScript.RPawnPlayerNightwing.AddMovementMovesToWeaponConfig", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DrawHUD, "BmScript.RPawnPlayerNightwing.DrawHUD", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DrawScreenBar;
    /// <summary>
    /// Function: DrawScreenBar
    /// </summary>
    public unsafe virtual void DrawScreenBar(BmSDK.Engine.Canvas HudCanvas, float centre_x, float centre_y, float proportion_width, float proportion_height, float proportion_border, float proportion_fill, float col_r, float col_g, float col_b, float col_a)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DrawScreenBar, "BmScript.RPawnPlayerNightwing.DrawScreenBar", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(centre_x, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(centre_y, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(proportion_width, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(proportion_height, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(proportion_border, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(proportion_fill, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(col_r, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(col_g, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(col_b, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(col_a, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DrawScreenRect;
    /// <summary>
    /// Function: DrawScreenRect
    /// </summary>
    public unsafe virtual void DrawScreenRect(BmSDK.Engine.Canvas HudCanvas, float topleft_x, float topleft_y, float width_x, float width_y, float col_r, float col_g, float col_b, float col_a)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DrawScreenRect, "BmScript.RPawnPlayerNightwing.DrawScreenRect", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(topleft_x, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(topleft_y, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(width_x, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(width_y, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(col_r, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(col_g, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(col_b, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(col_a, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FillProximityScannerArray;
    /// <summary>
    /// Function: FillProximityScannerArray
    /// </summary>
    public unsafe virtual void FillProximityScannerArray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FillProximityScannerArray, "BmScript.RPawnPlayerNightwing.FillProximityScannerArray", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TickProximityScanner;
    /// <summary>
    /// Function: TickProximityScanner
    /// </summary>
    public unsafe virtual void TickProximityScanner(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TickProximityScanner, "BmScript.RPawnPlayerNightwing.TickProximityScanner", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInXrayMode, "BmScript.RPawnPlayerNightwing.SetInXrayMode", this);
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeFallingDamage, "BmScript.RPawnPlayerNightwing.TakeFallingDamage", this);
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetOwnerNoSee, "BmScript.RPawnPlayerNightwing.SetOwnerNoSee", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewOwnerNoSee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CombatMoveFinished;
    /// <summary>
    /// Function: CombatMoveFinished
    /// </summary>
    public unsafe override void CombatMoveFinished(BmSDK.BmGame.RCombatMove FinishedMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CombatMoveFinished, "BmScript.RPawnPlayerNightwing.CombatMoveFinished", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedMove, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.RPawnPlayerNightwing.Tick", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsStowingMoveWeapon;
    /// <summary>
    /// Function: IsStowingMoveWeapon
    /// </summary>
    public unsafe override bool IsStowingMoveWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsStowingMoveWeapon, "BmScript.RPawnPlayerNightwing.IsStowingMoveWeapon", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnBeginStateSpecialMove;
    /// <summary>
    /// Function: OnBeginStateSpecialMove
    /// </summary>
    public unsafe override void OnBeginStateSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnBeginStateSpecialMove, "BmScript.RPawnPlayerNightwing.OnBeginStateSpecialMove", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetupPlayerSpecificCombatAnimsets, "BmScript.RPawnPlayerNightwing.SetupPlayerSpecificCombatAnimsets", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPipeCombatAnimset, "BmScript.RPawnPlayerNightwing.GetPipeCombatAnimset", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.RPawnPlayerNightwing.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FHealthBarEnemyInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FHealthBarEnemyInfo
    {
        /// <summary>
        /// FloatProperty: Countdown
        /// </summary>
        public unsafe float Countdown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: TheEnemy
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnVillain TheEnemy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: LeftWeapon
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent LeftWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10092); }
    }

    /// <summary>
    /// ComponentProperty: RightWeapon
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RightWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10100); }
    }

    /// <summary>
    /// BoolProperty: LeftWeaponEquipped
    /// </summary>
    public unsafe bool LeftWeaponEquipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10108); }
    }

    /// <summary>
    /// BoolProperty: RightWeaponEquipped
    /// </summary>
    public unsafe bool RightWeaponEquipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10108); }
    }

    /// <summary>
    /// BoolProperty: RicochetStickInFlight
    /// </summary>
    public unsafe bool RicochetStickInFlight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10108); }
    }

    /// <summary>
    /// BoolProperty: UseStrikeMirrored
    /// </summary>
    public unsafe bool UseStrikeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10108); }
    }

    /// <summary>
    /// BoolProperty: CurrentStrikeMirrored
    /// </summary>
    public unsafe bool CurrentStrikeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10108); }
    }

    /// <summary>
    /// BoolProperty: UsePostCombatStance
    /// </summary>
    public unsafe bool UsePostCombatStance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10108); }
    }

    /// <summary>
    /// BoolProperty: PostCombatStanceDisabled
    /// </summary>
    public unsafe bool PostCombatStanceDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10108); }
    }

    /// <summary>
    /// StructProperty: PutAwaySticksId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PutAwaySticksId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 10112);

    /// <summary>
    /// StructProperty: CatchStickTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CatchStickTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 10116);

    /// <summary>
    /// IntProperty: NextPutAwaySticksFromCombat
    /// </summary>
    public unsafe int NextPutAwaySticksFromCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10120); }
    }

    /// <summary>
    /// ArrayProperty: ProximityScannerEnemies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RPawnPlayerNightwing.FHealthBarEnemyInfo> ProximityScannerEnemies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RPawnPlayerNightwing.FHealthBarEnemyInfo>>(Ptr + 10124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10124); }
    }

    /// <summary>
    /// FloatProperty: ProximityScannerRange
    /// </summary>
    public unsafe float ProximityScannerRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10140); }
    }

    /// <summary>
    /// ObjectProperty: BetweenSticksBeam
    /// </summary>
    public unsafe BmSDK.Engine.Emitter BetweenSticksBeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 10144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10144); }
    }

    /// <summary>
    /// Enum: ENightwingGadgetList
    /// </summary>
    public enum ENightwingGadgetList : byte
    {
        NWGL_Batarang = 0,
        NWGL_SticksAreaStun = 1,
        NWGL_SticksRicochet = 2,
        NWGL_WristDart = 3,
        NWGL_BatClaw = 4,
        NWGL_MAX = 5,
    }
}
