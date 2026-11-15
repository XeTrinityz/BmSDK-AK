#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCombatMove_BatmanStrike<br/>
/// (size = 1564)
/// (flags = 144703635)
/// </summary>
public partial class RCombatMove_BatmanStrike : BmSDK.BmGame.RCombatMove_BatmanWeaponAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_BatmanStrike.
    /// </summary>
    public static RCombatMove_BatmanStrike DefaultObject => (RCombatMove_BatmanStrike)StaticClass().DefaultObject;

    internal RCombatMove_BatmanStrike() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanStrike(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeOverridenByQuickGadget;
    /// <summary>
    /// Function: CanBeOverridenByQuickGadget
    /// </summary>
    public unsafe override bool CanBeOverridenByQuickGadget(BmSDK.BmGame.RPawnPlayer.EQuickGadgetType QGType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeOverridenByQuickGadget, "BmGame.RCombatMove_BatmanStrike.CanBeOverridenByQuickGadget", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QGType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideSpeedUp;
    /// <summary>
    /// Function: OverrideSpeedUp
    /// </summary>
    public unsafe virtual void OverrideSpeedUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideSpeedUp, "BmGame.RCombatMove_BatmanStrike.OverrideSpeedUp", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanForceSlowStrike;
    /// <summary>
    /// Function: CanForceSlowStrike
    /// </summary>
    public unsafe virtual bool CanForceSlowStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanForceSlowStrike, "BmGame.RCombatMove_BatmanStrike.CanForceSlowStrike", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformFloorStrike;
    /// <summary>
    /// Function: CanPerformFloorStrike
    /// </summary>
    public unsafe override bool CanPerformFloorStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformFloorStrike, "BmGame.RCombatMove_BatmanStrike.CanPerformFloorStrike", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformWeaponDestroy;
    /// <summary>
    /// Function: CanPerformWeaponDestroy
    /// </summary>
    public unsafe override bool CanPerformWeaponDestroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformWeaponDestroy, "BmGame.RCombatMove_BatmanStrike.CanPerformWeaponDestroy", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformPrimaryGroupMove;
    /// <summary>
    /// Function: CanPerformPrimaryGroupMove
    /// </summary>
    public unsafe override bool CanPerformPrimaryGroupMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformPrimaryGroupMove, "BmGame.RCombatMove_BatmanStrike.CanPerformPrimaryGroupMove", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformWeaponSnatchWithRun;
    /// <summary>
    /// Function: CanPerformWeaponSnatchWithRun
    /// </summary>
    public unsafe override bool CanPerformWeaponSnatchWithRun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformWeaponSnatchWithRun, "BmGame.RCombatMove_BatmanStrike.CanPerformWeaponSnatchWithRun", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformTakedownWithStun;
    /// <summary>
    /// Function: CanPerformTakedownWithStun
    /// </summary>
    public unsafe override bool CanPerformTakedownWithStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformTakedownWithStun, "BmGame.RCombatMove_BatmanStrike.CanPerformTakedownWithStun", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformTakedownWithCounter;
    /// <summary>
    /// Function: CanPerformTakedownWithCounter
    /// </summary>
    public unsafe override bool CanPerformTakedownWithCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformTakedownWithCounter, "BmGame.RCombatMove_BatmanStrike.CanPerformTakedownWithCounter", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformThrow;
    /// <summary>
    /// Function: CanPerformThrow
    /// </summary>
    public unsafe override bool CanPerformThrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformThrow, "BmGame.RCombatMove_BatmanStrike.CanPerformThrow", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ExitMove, "BmGame.RCombatMove_BatmanStrike.ExitMove", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformFloorPickupThug;
    /// <summary>
    /// Function: CanPerformFloorPickupThug
    /// </summary>
    public unsafe override bool CanPerformFloorPickupThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformFloorPickupThug, "BmGame.RCombatMove_BatmanStrike.CanPerformFloorPickupThug", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHitReactionLocation;
    /// <summary>
    /// Function: GetHitReactionLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetHitReactionLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHitReactionLocation, "BmGame.RCombatMove_BatmanStrike.GetHitReactionLocation", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHitReactionDirection;
    /// <summary>
    /// Function: GetHitReactionDirection
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetHitReactionDirection(BmSDK.BmGame.RPawnVillain HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHitReactionDirection, "BmGame.RCombatMove_BatmanStrike.GetHitReactionDirection", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanStartFinishedCombatMove;
    /// <summary>
    /// Function: CanStartFinishedCombatMove
    /// </summary>
    public unsafe override bool CanStartFinishedCombatMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanStartFinishedCombatMove, "BmGame.RCombatMove_BatmanStrike.CanStartFinishedCombatMove", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayedJumpOffWall;
    /// <summary>
    /// Function: PlayedJumpOffWall
    /// </summary>
    public unsafe virtual void PlayedJumpOffWall(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewId, float TimeLeftOver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayedJumpOffWall, "BmGame.RCombatMove_BatmanStrike.PlayedJumpOffWall", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldTrackTargetThisFrame;
    /// <summary>
    /// Function: ShouldTrackTargetThisFrame
    /// </summary>
    public unsafe virtual bool ShouldTrackTargetThisFrame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldTrackTargetThisFrame, "BmGame.RCombatMove_BatmanStrike.ShouldTrackTargetThisFrame", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FreeflowFocusTurnedOff;
    /// <summary>
    /// Function: FreeflowFocusTurnedOff
    /// </summary>
    public unsafe override void FreeflowFocusTurnedOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FreeflowFocusTurnedOff, "BmGame.RCombatMove_BatmanStrike.FreeflowFocusTurnedOff", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayStrike;
    /// <summary>
    /// Function: PlayStrike
    /// </summary>
    public unsafe virtual void PlayStrike(bool bQueue, bool bSimulated)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayStrike, "BmGame.RCombatMove_BatmanStrike.PlayStrike", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQueue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSimulated, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayedQueuedStrikeAnimSimulated;
    /// <summary>
    /// Function: PlayedQueuedStrikeAnimSimulated
    /// </summary>
    public unsafe virtual void PlayedQueuedStrikeAnimSimulated(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayedQueuedStrikeAnimSimulated, "BmGame.RCombatMove_BatmanStrike.PlayedQueuedStrikeAnimSimulated", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayedQueuedStrikeAnim;
    /// <summary>
    /// Function: PlayedQueuedStrikeAnim
    /// </summary>
    public unsafe virtual void PlayedQueuedStrikeAnim(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayedQueuedStrikeAnim, "BmGame.RCombatMove_BatmanStrike.PlayedQueuedStrikeAnim", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeStartTime;
    /// <summary>
    /// Function: GetStrikeStartTime
    /// </summary>
    public unsafe virtual float GetStrikeStartTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeStartTime, "BmGame.RCombatMove_BatmanStrike.GetStrikeStartTime", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeAnimSet;
    /// <summary>
    /// Function: GetStrikeAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetStrikeAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeAnimSet, "BmGame.RCombatMove_BatmanStrike.GetStrikeAnimSet", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeDurationScale;
    /// <summary>
    /// Function: GetStrikeDurationScale
    /// </summary>
    public unsafe virtual float GetStrikeDurationScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeDurationScale, "BmGame.RCombatMove_BatmanStrike.GetStrikeDurationScale", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeBoneLocation;
    /// <summary>
    /// Function: GetStrikeBoneLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetStrikeBoneLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeBoneLocation, "BmGame.RCombatMove_BatmanStrike.GetStrikeBoneLocation", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeTargetLocation;
    /// <summary>
    /// Function: GetStrikeTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetStrikeTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeTargetLocation, "BmGame.RCombatMove_BatmanStrike.GetStrikeTargetLocation", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopCapeAnim;
    /// <summary>
    /// Function: StopCapeAnim
    /// </summary>
    public unsafe virtual void StopCapeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopCapeAnim, "BmGame.RCombatMove_BatmanStrike.StopCapeAnim", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayCapeAnim;
    /// <summary>
    /// Function: PlayCapeAnim
    /// </summary>
    public unsafe virtual void PlayCapeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayCapeAnim, "BmGame.RCombatMove_BatmanStrike.PlayCapeAnim", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTrailPS;
    /// <summary>
    /// Function: GetTrailPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetTrailPS()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTrailPS, "BmGame.RCombatMove_BatmanStrike.GetTrailPS", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopTrail;
    /// <summary>
    /// Function: StopTrail
    /// </summary>
    public unsafe virtual void StopTrail()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopTrail, "BmGame.RCombatMove_BatmanStrike.StopTrail", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartTrail;
    /// <summary>
    /// Function: StartTrail
    /// </summary>
    public unsafe virtual void StartTrail()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartTrail, "BmGame.RCombatMove_BatmanStrike.StartTrail", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayBlockedFX;
    /// <summary>
    /// Function: PlayBlockedFX
    /// </summary>
    public unsafe virtual void PlayBlockedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayBlockedFX, "BmGame.RCombatMove_BatmanStrike.PlayBlockedFX", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayHitFX;
    /// <summary>
    /// Function: PlayHitFX
    /// </summary>
    public unsafe virtual void PlayHitFX(float FXScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayHitFX, "BmGame.RCombatMove_BatmanStrike.PlayHitFX", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FXScale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetImpactPS;
    /// <summary>
    /// Function: GetImpactPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetImpactPS(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetImpactPS, "BmGame.RCombatMove_BatmanStrike.GetImpactPS", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ProcessDamageResult;
    /// <summary>
    /// Function: ProcessDamageResult
    /// </summary>
    public unsafe virtual void ProcessDamageResult(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ProcessDamageResult, "BmGame.RCombatMove_BatmanStrike.ProcessDamageResult", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ApplyDamage;
    /// <summary>
    /// Function: ApplyDamage
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult ApplyDamage(BmSDK.BmGame.RPawnCombat TargetPawn, System.Numerics.Vector3 DamageDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ApplyDamage, "BmGame.RCombatMove_BatmanStrike.ApplyDamage", this);
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoHitPawnSimulated;
    /// <summary>
    /// Function: DoHitPawnSimulated
    /// </summary>
    public unsafe virtual void DoHitPawnSimulated(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoHitPawnSimulated, "BmGame.RCombatMove_BatmanStrike.DoHitPawnSimulated", this);
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoHitPawn;
    /// <summary>
    /// Function: DoHitPawn
    /// </summary>
    public unsafe virtual void DoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoHitPawn, "BmGame.RCombatMove_BatmanStrike.DoHitPawn", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerStrikeAttempted;
    /// <summary>
    /// Function: TriggerStrikeAttempted
    /// </summary>
    public unsafe override void TriggerStrikeAttempted(bool bStun = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerStrikeAttempted, "BmGame.RCombatMove_BatmanStrike.TriggerStrikeAttempted", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStun, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayImpactSound;
    /// <summary>
    /// Function: PlayImpactSound
    /// </summary>
    public unsafe virtual void PlayImpactSound(BmSDK.BmGame.RPawnCombat DamageReceiver, BmSDK.BmGame.RPawnCombat.DamageResult DmgResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayImpactSound, "BmGame.RCombatMove_BatmanStrike.PlayImpactSound", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayFirstHitSound;
    /// <summary>
    /// Function: PlayFirstHitSound
    /// </summary>
    public unsafe virtual void PlayFirstHitSound(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayFirstHitSound, "BmGame.RCombatMove_BatmanStrike.PlayFirstHitSound", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DamagePawn;
    /// <summary>
    /// Function: DamagePawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult DamagePawn(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DamagePawn, "BmGame.RCombatMove_BatmanStrike.DamagePawn", this);
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetDamageInfo;
    /// <summary>
    /// Function: SetDamageInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.FDamageInfo SetDamageInfo(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetDamageInfo, "BmGame.RCombatMove_BatmanStrike.SetDamageInfo", this);
        byte* paramsPtr = stackalloc byte[524];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldIncCombo;
    /// <summary>
    /// Function: ShouldIncCombo
    /// </summary>
    public unsafe virtual bool ShouldIncCombo(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldIncCombo, "BmGame.RCombatMove_BatmanStrike.ShouldIncCombo", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ComboIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboIncrease, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpecialMoveCountIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveCountIncrease, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetComboIncrease;
    /// <summary>
    /// Function: GetComboIncrease
    /// </summary>
    public unsafe virtual void GetComboIncrease(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetComboIncrease, "BmGame.RCombatMove_BatmanStrike.GetComboIncrease", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ComboIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboIncrease, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpecialMoveCountIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveCountIncrease, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyDeathCutsceneOfStrike;
    /// <summary>
    /// Function: NotifyDeathCutsceneOfStrike
    /// </summary>
    public unsafe virtual void NotifyDeathCutsceneOfStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyDeathCutsceneOfStrike, "BmGame.RCombatMove_BatmanStrike.NotifyDeathCutsceneOfStrike", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamageAmount;
    /// <summary>
    /// Function: GetDamageAmount
    /// </summary>
    public unsafe virtual float GetDamageAmount(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamageAmount, "BmGame.RCombatMove_BatmanStrike.GetDamageAmount", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateTargetAnimForFinalBlow;
    /// <summary>
    /// Function: UpdateTargetAnimForFinalBlow
    /// </summary>
    public unsafe virtual void UpdateTargetAnimForFinalBlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateTargetAnimForFinalBlow, "BmGame.RCombatMove_BatmanStrike.UpdateTargetAnimForFinalBlow", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFOVModifier;
    /// <summary>
    /// Function: GetFOVModifier
    /// </summary>
    public unsafe override float GetFOVModifier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFOVModifier, "BmGame.RCombatMove_BatmanStrike.GetFOVModifier", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateSlowMo;
    /// <summary>
    /// Function: UpdateSlowMo
    /// </summary>
    public unsafe virtual void UpdateSlowMo(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateSlowMo, "BmGame.RCombatMove_BatmanStrike.UpdateSlowMo", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStartFinalBlowTime;
    /// <summary>
    /// Function: GetStartFinalBlowTime
    /// </summary>
    public unsafe virtual float GetStartFinalBlowTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStartFinalBlowTime, "BmGame.RCombatMove_BatmanStrike.GetStartFinalBlowTime", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetEndSlowMoTime;
    /// <summary>
    /// Function: GetEndSlowMoTime
    /// </summary>
    public unsafe virtual float GetEndSlowMoTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetEndSlowMoTime, "BmGame.RCombatMove_BatmanStrike.GetEndSlowMoTime", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStartSlowMoTime;
    /// <summary>
    /// Function: GetStartSlowMoTime
    /// </summary>
    public unsafe virtual float GetStartSlowMoTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStartSlowMoTime, "BmGame.RCombatMove_BatmanStrike.GetStartSlowMoTime", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopSlowMo;
    /// <summary>
    /// Function: StopSlowMo
    /// </summary>
    public unsafe virtual void StopSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopSlowMo, "BmGame.RCombatMove_BatmanStrike.StopSlowMo", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldSlowMo;
    /// <summary>
    /// Function: ShouldSlowMo
    /// </summary>
    public unsafe virtual bool ShouldSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldSlowMo, "BmGame.RCombatMove_BatmanStrike.ShouldSlowMo", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BatmanTargetted;
    /// <summary>
    /// Function: BatmanTargetted
    /// </summary>
    public unsafe virtual bool BatmanTargetted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BatmanTargetted, "BmGame.RCombatMove_BatmanStrike.BatmanTargetted", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsSliding;
    /// <summary>
    /// Function: IsSliding
    /// </summary>
    public unsafe virtual bool IsSliding()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsSliding, "BmGame.RCombatMove_BatmanStrike.IsSliding", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHitImpactForce;
    /// <summary>
    /// Function: GetHitImpactForce
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHitImpactForce(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHitImpactForce, "BmGame.RCombatMove_BatmanStrike.GetHitImpactForce", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamageDirection;
    /// <summary>
    /// Function: GetDamageDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDamageDirection(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamageDirection, "BmGame.RCombatMove_BatmanStrike.GetDamageDirection", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamagePower;
    /// <summary>
    /// Function: GetDamagePower
    /// </summary>
    public unsafe virtual float GetDamagePower()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamagePower, "BmGame.RCombatMove_BatmanStrike.GetDamagePower", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamageCollisionProjection;
    /// <summary>
    /// Function: GetDamageCollisionProjection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDamageCollisionProjection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamageCollisionProjection, "BmGame.RCombatMove_BatmanStrike.GetDamageCollisionProjection", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamageCollisionDuration;
    /// <summary>
    /// Function: GetDamageCollisionDuration
    /// </summary>
    public unsafe virtual float GetDamageCollisionDuration()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamageCollisionDuration, "BmGame.RCombatMove_BatmanStrike.GetDamageCollisionDuration", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamageCollisionRadius;
    /// <summary>
    /// Function: GetDamageCollisionRadius
    /// </summary>
    public unsafe virtual float GetDamageCollisionRadius()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamageCollisionRadius, "BmGame.RCombatMove_BatmanStrike.GetDamageCollisionRadius", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHitBone;
    /// <summary>
    /// Function: GetHitBone
    /// </summary>
    public unsafe virtual BmSDK.FName GetHitBone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHitBone, "BmGame.RCombatMove_BatmanStrike.GetHitBone", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamageBone;
    /// <summary>
    /// Function: GetDamageBone
    /// </summary>
    public unsafe virtual BmSDK.FName GetDamageBone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamageBone, "BmGame.RCombatMove_BatmanStrike.GetDamageBone", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetImpactBoneEnum;
    /// <summary>
    /// Function: GetImpactBoneEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.BoneNameList GetImpactBoneEnum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetImpactBoneEnum, "BmGame.RCombatMove_BatmanStrike.GetImpactBoneEnum", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.BoneNameList>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamageBoneEnum;
    /// <summary>
    /// Function: GetDamageBoneEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.BoneNameList GetDamageBoneEnum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamageBoneEnum, "BmGame.RCombatMove_BatmanStrike.GetDamageBoneEnum", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.BoneNameList>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetValidTargetStrikeRange;
    /// <summary>
    /// Function: GetValidTargetStrikeRange
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.StrikeRange GetValidTargetStrikeRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetValidTargetStrikeRange, "BmGame.RCombatMove_BatmanStrike.GetValidTargetStrikeRange", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.StrikeRange>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeAnim;
    /// <summary>
    /// Function: GetStrikeAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetStrikeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeAnim, "BmGame.RCombatMove_BatmanStrike.GetStrikeAnim", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeTimeUntilImpact;
    /// <summary>
    /// Function: GetStrikeTimeUntilImpact
    /// </summary>
    public unsafe virtual float GetStrikeTimeUntilImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeTimeUntilImpact, "BmGame.RCombatMove_BatmanStrike.GetStrikeTimeUntilImpact", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeStruckBy;
    /// <summary>
    /// Function: CanBeStruckBy
    /// </summary>
    public unsafe override bool CanBeStruckBy(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.BmGame.RPawnCombat Defender)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeStruckBy, "BmGame.RCombatMove_BatmanStrike.CanBeStruckBy", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Defender, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanReceiveAttackFromPawn, "BmGame.RCombatMove_BatmanStrike.CanReceiveAttackFromPawn", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanPerformNextComboMove, "BmGame.RCombatMove_BatmanStrike.CanPerformNextComboMove", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisallowEarlyExit;
    /// <summary>
    /// Function: DisallowEarlyExit
    /// </summary>
    public unsafe virtual void DisallowEarlyExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisallowEarlyExit, "BmGame.RCombatMove_BatmanStrike.DisallowEarlyExit", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowEarlyExit;
    /// <summary>
    /// Function: AllowEarlyExit
    /// </summary>
    public unsafe virtual void AllowEarlyExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowEarlyExit, "BmGame.RCombatMove_BatmanStrike.AllowEarlyExit", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowMovementExit;
    /// <summary>
    /// Function: AllowMovementExit
    /// </summary>
    public unsafe override void AllowMovementExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowMovementExit, "BmGame.RCombatMove_BatmanStrike.AllowMovementExit", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BotTryNextStrike;
    /// <summary>
    /// Function: BotTryNextStrike
    /// </summary>
    public unsafe virtual void BotTryNextStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BotTryNextStrike, "BmGame.RCombatMove_BatmanStrike.BotTryNextStrike", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowNextNonStrikeMove;
    /// <summary>
    /// Function: AllowNextNonStrikeMove
    /// </summary>
    public unsafe virtual void AllowNextNonStrikeMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowNextNonStrikeMove, "BmGame.RCombatMove_BatmanStrike.AllowNextNonStrikeMove", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe override void AllowNextStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowNextStrike, "BmGame.RCombatMove_BatmanStrike.AllowNextStrike", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisableMotionBlur;
    /// <summary>
    /// Function: DisableMotionBlur
    /// </summary>
    public unsafe virtual void DisableMotionBlur()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisableMotionBlur, "BmGame.RCombatMove_BatmanStrike.DisableMotionBlur", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnableMotionBlur;
    /// <summary>
    /// Function: EnableMotionBlur
    /// </summary>
    public unsafe virtual void EnableMotionBlur()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnableMotionBlur, "BmGame.RCombatMove_BatmanStrike.EnableMotionBlur", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DamageCollisionDeactivated;
    /// <summary>
    /// Function: DamageCollisionDeactivated
    /// </summary>
    public unsafe virtual void DamageCollisionDeactivated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DamageCollisionDeactivated, "BmGame.RCombatMove_BatmanStrike.DamageCollisionDeactivated", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HitTarget;
    /// <summary>
    /// Function: HitTarget
    /// </summary>
    public unsafe virtual void HitTarget(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HitTarget, "BmGame.RCombatMove_BatmanStrike.HitTarget", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceHitTarget;
    /// <summary>
    /// Function: ForceHitTarget
    /// </summary>
    public unsafe virtual void ForceHitTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceHitTarget, "BmGame.RCombatMove_BatmanStrike.ForceHitTarget", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartPreImpact;
    /// <summary>
    /// Function: StartPreImpact
    /// </summary>
    public unsafe virtual void StartPreImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartPreImpact, "BmGame.RCombatMove_BatmanStrike.StartPreImpact", this);
        byte* paramsPtr = stackalloc byte[265];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartImpact;
    /// <summary>
    /// Function: StartImpact
    /// </summary>
    public unsafe virtual void StartImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartImpact, "BmGame.RCombatMove_BatmanStrike.StartImpact", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StrikeContact;
    /// <summary>
    /// Function: StrikeContact
    /// </summary>
    public unsafe override void StrikeContact(bool bPreStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StrikeContact, "BmGame.RCombatMove_BatmanStrike.StrikeContact", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPreStrike, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CombatAnimHit, "BmGame.RCombatMove_BatmanStrike.CombatAnimHit", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StrikeSlowMoStop;
    /// <summary>
    /// Function: StrikeSlowMoStop
    /// </summary>
    public unsafe virtual void StrikeSlowMoStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StrikeSlowMoStop, "BmGame.RCombatMove_BatmanStrike.StrikeSlowMoStop", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StrikeSlowMoStart;
    /// <summary>
    /// Function: StrikeSlowMoStart
    /// </summary>
    public unsafe virtual void StrikeSlowMoStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StrikeSlowMoStart, "BmGame.RCombatMove_BatmanStrike.StrikeSlowMoStart", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe virtual bool ShouldStartFinalBlowCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldStartFinalBlowCam, "BmGame.RCombatMove_BatmanStrike.ShouldStartFinalBlowCam", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoCameraAssistance;
    /// <summary>
    /// Function: DoCameraAssistance
    /// </summary>
    public unsafe override bool DoCameraAssistance(float DelayTime = default, bool bCheckTarget = default, System.Numerics.Vector3 TestOffset = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed LookAtSpeed = default, BmSDK.Engine.Actor ForceTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoCameraAssistance, "BmGame.RCombatMove_BatmanStrike.DoCameraAssistance", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestOffset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAtSpeed, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceTarget, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HaveClearPathToTarget;
    /// <summary>
    /// Function: HaveClearPathToTarget<br/>
    /// Native code at BatmanAK.exe+0x489CD0 in the Steam build
    /// </summary>
    public unsafe virtual bool HaveClearPathToTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HaveClearPathToTarget, "BmGame.RCombatMove_BatmanStrike.HaveClearPathToTarget", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GotoFirstState;
    /// <summary>
    /// Function: GotoFirstState
    /// </summary>
    public unsafe virtual void GotoFirstState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GotoFirstState, "BmGame.RCombatMove_BatmanStrike.GotoFirstState", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPData;
    /// <summary>
    /// Function: GetPData
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentData GetPData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPData, "BmGame.RCombatMove_BatmanStrike.GetPData", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPersistentData>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NoTargetClearCombo;
    /// <summary>
    /// Function: NoTargetClearCombo
    /// </summary>
    public unsafe virtual void NoTargetClearCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NoTargetClearCombo, "BmGame.RCombatMove_BatmanStrike.NoTargetClearCombo", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ModifyDmgTypeFromWeaponGrabbed;
    /// <summary>
    /// Function: ModifyDmgTypeFromWeaponGrabbed
    /// </summary>
    public unsafe virtual void ModifyDmgTypeFromWeaponGrabbed(BmSDK.BmGame.RBMCombatThrownObject WeaponInHand, out BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ModifyDmgTypeFromWeaponGrabbed, "BmGame.RCombatMove_BatmanStrike.ModifyDmgTypeFromWeaponGrabbed", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponInHand, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out dmgType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        dmgType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FrameStrikeWithCamera;
    /// <summary>
    /// Function: FrameStrikeWithCamera
    /// </summary>
    public unsafe virtual void FrameStrikeWithCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FrameStrikeWithCamera, "BmGame.RCombatMove_BatmanStrike.FrameStrikeWithCamera", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Initialise, "BmGame.RCombatMove_BatmanStrike.Initialise", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PreFindStrikeInfo;
    /// <summary>
    /// Function: PreFindStrikeInfo
    /// </summary>
    public unsafe virtual void PreFindStrikeInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PreFindStrikeInfo, "BmGame.RCombatMove_BatmanStrike.PreFindStrikeInfo", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryToFindTarget;
    /// <summary>
    /// Function: TryToFindTarget
    /// </summary>
    public unsafe virtual void TryToFindTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryToFindTarget, "BmGame.RCombatMove_BatmanStrike.TryToFindTarget", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetNoTargetDir;
    /// <summary>
    /// Function: SetNoTargetDir
    /// </summary>
    public unsafe virtual void SetNoTargetDir()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetNoTargetDir, "BmGame.RCombatMove_BatmanStrike.SetNoTargetDir", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCombatMoveVictim;
    /// <summary>
    /// Function: GetCombatMoveVictim
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawn GetCombatMoveVictim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCombatMoveVictim, "BmGame.RCombatMove_BatmanStrike.GetCombatMoveVictim", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawn>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBatmanTransitionId;
    /// <summary>
    /// Function: GetBatmanTransitionId
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetBatmanTransitionId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBatmanTransitionId, "BmGame.RCombatMove_BatmanStrike.GetBatmanTransitionId", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Reset, "BmGame.RCombatMove_BatmanStrike.Reset", this);
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetEnvironmentInfo;
    /// <summary>
    /// Function: GetEnvironmentInfo<br/>
    /// Native code at BatmanAK.exe+0x4D2B90 in the Steam build
    /// </summary>
    public unsafe virtual int GetEnvironmentInfo(BmSDK.BmGame.RPawnVillain TargetPawn, out BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir EnvDir, bool bAllowInvalidWall = default, bool bAllowInNoEnvCounterVolume = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetEnvironmentInfo, "BmGame.RCombatMove_BatmanStrike.GetEnvironmentInfo", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EnvDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnvDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowInvalidWall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowInNoEnvCounterVolume, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        EnvDir = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ModifyInfoSearchParams;
    /// <summary>
    /// Function: ModifyInfoSearchParams<br/>
    /// Native code at BatmanAK.exe+0x479D70 in the Steam build
    /// </summary>
    public unsafe virtual void ModifyInfoSearchParams(out BmSDK.BmGame.RGameInfo.StrikeDirection InfoDir, out BmSDK.BmGame.RGameInfo.StrikeStrength InfoStrength, out BmSDK.BmGame.RGameInfo.StrikeRange InfoRange, out BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir InfoRailingDir, out BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir InfoWallDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ModifyInfoSearchParams, "BmGame.RCombatMove_BatmanStrike.ModifyInfoSearchParams", this);
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InfoDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoDir, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InfoStrength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoStrength, paramsPtr + 1);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InfoRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoRange, paramsPtr + 2);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InfoRailingDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoRailingDir, paramsPtr + 3);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InfoWallDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoWallDir, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InfoDir = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.StrikeDirection>(paramsPtr + 0);
        InfoStrength = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.StrikeStrength>(paramsPtr + 1);
        InfoRange = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.StrikeRange>(paramsPtr + 2);
        InfoRailingDir = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir>(paramsPtr + 3);
        InfoWallDir = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanHitPawn;
    /// <summary>
    /// Function: CanHitPawn<br/>
    /// Native code at BatmanAK.exe+0x4FF230 in the Steam build
    /// </summary>
    public unsafe virtual bool CanHitPawn(BmSDK.BmGame.RPawnCombat TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanHitPawn, "BmGame.RCombatMove_BatmanStrike.CanHitPawn", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForStrikeWeaponPickup;
    /// <summary>
    /// Function: GetScoreForStrikeWeaponPickup<br/>
    /// Native code at BatmanAK.exe+0x479CC0 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForStrikeWeaponPickup(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForStrikeWeaponPickup, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeWeaponPickup", this);
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 140);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForStrikeWeaponGrabbed;
    /// <summary>
    /// Function: GetScoreForStrikeWeaponGrabbed<br/>
    /// Native code at BatmanAK.exe+0x479C10 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForStrikeWeaponGrabbed(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForStrikeWeaponGrabbed, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeWeaponGrabbed", this);
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 140);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForStrikeStartingHeight;
    /// <summary>
    /// Function: GetScoreForStrikeStartingHeight<br/>
    /// Native code at BatmanAK.exe+0x479B60 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForStrikeStartingHeight(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForStrikeStartingHeight, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeStartingHeight", this);
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 140);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForStrikeTurnMotion;
    /// <summary>
    /// Function: GetScoreForStrikeTurnMotion<br/>
    /// Native code at BatmanAK.exe+0x479AB0 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForStrikeTurnMotion(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForStrikeTurnMotion, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeTurnMotion", this);
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 140);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForStrikeSpeed;
    /// <summary>
    /// Function: GetScoreForStrikeSpeed<br/>
    /// Native code at BatmanAK.exe+0x479A00 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForStrikeSpeed(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForStrikeSpeed, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeSpeed", this);
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 140);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForTimeSinceUse;
    /// <summary>
    /// Function: GetScoreForTimeSinceUse<br/>
    /// Native code at BatmanAK.exe+0x479950 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForTimeSinceUse(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForTimeSinceUse, "BmGame.RCombatMove_BatmanStrike.GetScoreForTimeSinceUse", this);
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 140);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForStrikeDir;
    /// <summary>
    /// Function: GetScoreForStrikeDir<br/>
    /// Native code at BatmanAK.exe+0x4798A0 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForStrikeDir(BmSDK.BmGame.RGameInfo.StrikeDirection TestDir, BmSDK.BmGame.RGameInfo.StrikeDirection DesDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForStrikeDir, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeDir", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesDir, paramsPtr + 1);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForStrikeRange;
    /// <summary>
    /// Function: GetScoreForStrikeRange<br/>
    /// Native code at BatmanAK.exe+0x4797F0 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForStrikeRange(BmSDK.BmGame.RGameInfo.StrikeRange TestRange, BmSDK.BmGame.RGameInfo.StrikeRange DesRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForStrikeRange, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeRange", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesRange, paramsPtr + 1);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoreForHandedness;
    /// <summary>
    /// Function: GetScoreForHandedness<br/>
    /// Native code at BatmanAK.exe+0x479740 in the Steam build
    /// </summary>
    public unsafe virtual int GetScoreForHandedness(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoreForHandedness, "BmGame.RCombatMove_BatmanStrike.GetScoreForHandedness", this);
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 140);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetStrikeInfoScore;
    /// <summary>
    /// Function: GetStrikeInfoScore<br/>
    /// Native code at BatmanAK.exe+0x479560 in the Steam build
    /// </summary>
    public unsafe virtual float GetStrikeInfoScore(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike, BmSDK.BmGame.RGameInfo.StrikeDirection StrikeDir, BmSDK.BmGame.RGameInfo.StrikeStrength StrikeStrength, BmSDK.BmGame.RGameInfo.StrikeRange StrikeRange, BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir StrikeRailingDir, BmSDK.BmGame.RPawnPlayerCombat.StrikeEnvironmentDir StrikeWallDir, System.Numerics.Vector3 ControllerDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetStrikeInfoScore, "BmGame.RCombatMove_BatmanStrike.GetStrikeInfoScore", this);
        byte* paramsPtr = stackalloc byte[180];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDir, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeStrength, paramsPtr + 141);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeRange, paramsPtr + 142);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeRailingDir, paramsPtr + 143);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeWallDir, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerDir, paramsPtr + 148);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 160);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetStrikeInfo;
    /// <summary>
    /// Function: SetStrikeInfo<br/>
    /// Native code at BatmanAK.exe+0x46B4B0 in the Steam build
    /// </summary>
    public unsafe virtual int SetStrikeInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetStrikeInfo, "BmGame.RCombatMove_BatmanStrike.SetStrikeInfo", this);
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    /// <summary>
    /// ClassProperty: StrikeDmgType
    /// </summary>
    public unsafe BmSDK.Class StrikeDmgType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: EnvLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EnvLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 876);

    /// <summary>
    /// StructProperty: EnvNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EnvNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 888);

    /// <summary>
    /// BoolProperty: bAnimAlreadyPlaying
    /// </summary>
    public unsafe bool bAnimAlreadyPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bTargetSet
    /// </summary>
    public unsafe bool bTargetSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bQueuedStrike
    /// </summary>
    public unsafe bool bQueuedStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bDisallowEarlyExit
    /// </summary>
    public unsafe bool bDisallowEarlyExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bIncreasedCombo
    /// </summary>
    public unsafe bool bIncreasedCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanBeStruck
    /// </summary>
    public unsafe bool bCanBeStruck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanStartNextNonStrikeMove
    /// </summary>
    public unsafe bool bCanStartNextNonStrikeMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bSlowMo
    /// </summary>
    public unsafe bool bSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlow
    /// </summary>
    public unsafe bool bFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bSpawnFinalBlowCam
    /// </summary>
    public unsafe bool bSpawnFinalBlowCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlowSpawned
    /// </summary>
    public unsafe bool bFinalBlowSpawned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bSpawnFinalBlowNextFrame
    /// </summary>
    public unsafe bool bSpawnFinalBlowNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bFreeflowFocusStrike
    /// </summary>
    public unsafe bool bFreeflowFocusStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanBeCriticalStrike
    /// </summary>
    public unsafe bool bCanBeCriticalStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraAssist
    /// </summary>
    public unsafe bool bDisableCameraAssist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bStrikeContactCalled
    /// </summary>
    public unsafe bool bStrikeContactCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTargetStrike
    /// </summary>
    public unsafe bool bOverrideTargetStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bForceQuickStrike
    /// </summary>
    public unsafe bool bForceQuickStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bForceSlowStrike
    /// </summary>
    public unsafe bool bForceSlowStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bPreStrikeHit
    /// </summary>
    public unsafe bool bPreStrikeHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bNotifiedDeathCutscene
    /// </summary>
    public unsafe bool bNotifiedDeathCutscene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bDoSlowMo
    /// </summary>
    public unsafe bool bDoSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bDoSlowMoSFX
    /// </summary>
    public unsafe bool bDoSlowMoSFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bBatmanIsInRelativeTransition
    /// </summary>
    public unsafe bool bBatmanIsInRelativeTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCanShowTutorial
    /// </summary>
    public unsafe bool bCanShowTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bUsingJokerHallucination
    /// </summary>
    public unsafe bool bUsingJokerHallucination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredJokerHallucinationReaction
    /// </summary>
    public unsafe bool bTriggeredJokerHallucinationReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bCalledHitTarget
    /// </summary>
    public unsafe bool bCalledHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bStrikeDepletesWeapon<br/>
    /// Default: true
    /// </summary>
    public unsafe bool bStrikeDepletesWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bZoomIn
    /// </summary>
    public unsafe bool bZoomIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bKeepCombo
    /// </summary>
    public unsafe bool bKeepCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysRemoveHelmets
    /// </summary>
    public unsafe bool bAlwaysRemoveHelmets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: TargetDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 904);

    /// <summary>
    /// ObjectProperty: PrevTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PrevTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: StrikeAnimSequence
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence StrikeAnimSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ComponentProperty: StrikeRainTrail<br/>
    /// Default: BmGame.Default__RCombatMove_BatmanStrike.StrikeRainTrailBase
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StrikeRainTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ComponentProperty: StrikeTrail<br/>
    /// Default: BmGame.Default__RCombatMove_BatmanStrike.StrikeTrailBase
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StrikeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: SlowMoTimer
    /// </summary>
    public unsafe float SlowMoTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ByteProperty: TargetResponse
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.TargetStrikeResponse>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: StrikeDamageAmount
    /// </summary>
    public unsafe float StrikeDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake<br/>
    /// Default: (TimeDuration=0.3,LocAmplitude=(X=2.7,Y=2.7,Z=2),LocFrequency=(X=20,Y=20,Z=20),RotAmplitude=(X=200,Y=50,Z=50),RotFrequency=(X=5.5,Y=5.5,Z=5.5),FOVMultiplier=1,FOVFrequency=5,AdvancedOptions=(Frequency...
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 976);

    /// <summary>
    /// StructProperty: StrikeInfo<br/>
    /// Default: (bCanPerformWithNoTarget=true,bCanPerformOnBlocker=true,bHitsLow=true,DestCapeStateName=Physics,bActive=true)
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo StrikeInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 1132);

    /// <summary>
    /// StructProperty: PrevStrikeInfo<br/>
    /// Default: (bCanPerformWithNoTarget=true,bCanPerformOnBlocker=true,bHitsLow=true,DestCapeStateName=Physics,bActive=true)
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo PrevStrikeInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 1272);

    /// <summary>
    /// FloatProperty: StrikeDurationScale
    /// </summary>
    public unsafe float StrikeDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: StrikeContactTime<br/>
    /// Default: -1
    /// </summary>
    public unsafe float StrikeContactTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// StructProperty: BatmanStrikeID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId BatmanStrikeID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1420);

    /// <summary>
    /// FloatProperty: StunRadius
    /// </summary>
    public unsafe float StunRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: ChapterNumber
    /// </summary>
    public unsafe float ChapterNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// IntProperty: ComboLevel
    /// </summary>
    public unsafe int ComboLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// StructProperty: TargetHitReactionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetHitReactionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1436);

    /// <summary>
    /// NameProperty: ForceStrikeByName
    /// </summary>
    public unsafe BmSDK.FName ForceStrikeByName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// IntProperty: CapeStateChangeIndex
    /// </summary>
    public unsafe int CapeStateChangeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// IntProperty: ThirdTimeSinceUseThresh<br/>
    /// Default: 20
    /// </summary>
    public unsafe int ThirdTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// IntProperty: SecondTimeSinceUseThresh<br/>
    /// Default: 10
    /// </summary>
    public unsafe int SecondTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// IntProperty: FirstTimeSinceUseThresh<br/>
    /// Default: 3
    /// </summary>
    public unsafe int FirstTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// IntProperty: ThirdTimeSinceUseScore<br/>
    /// Default: 5
    /// </summary>
    public unsafe int ThirdTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// IntProperty: SecondTimeSinceUseScore<br/>
    /// Default: 3
    /// </summary>
    public unsafe int SecondTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: FirstTimeSinceUseScore<br/>
    /// Default: 1
    /// </summary>
    public unsafe int FirstTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// IntProperty: CorrectRangeScore<br/>
    /// Default: 4
    /// </summary>
    public unsafe int CorrectRangeScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// FloatProperty: JokerHallucinationFovModifier
    /// </summary>
    public unsafe float JokerHallucinationFovModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: JokerHallucinationFovTimer
    /// </summary>
    public unsafe float JokerHallucinationFovTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// IntProperty: PickedJokerAnimIndex
    /// </summary>
    public unsafe int PickedJokerAnimIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// ArrayProperty: JokerStrikeAnimName<br/>
    /// Default: (Final_Blow_Strike_Reaction_01,Final_Blow_Strike_Reaction_02,Final_Blow_Strike_Reaction_03,Final_Blow_Strike_Reaction_04)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> JokerStrikeAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// ArrayProperty: JokerStrikeIdleAnimName<br/>
    /// Default: (Final_Blow_Strike_Reaction_01_Idle,Final_Blow_Strike_Reaction_02_Idle,Final_Blow_Strike_Reaction_03_Idle,Final_Blow_Strike_Reaction_04_Idle)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> JokerStrikeIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// FloatProperty: MaxTargetDist<br/>
    /// Default: 250
    /// </summary>
    public unsafe float MaxTargetDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// StructProperty: StartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1536);

    /// <summary>
    /// ArrayProperty: StrikeTrailActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject> StrikeTrailActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject>>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }
}
