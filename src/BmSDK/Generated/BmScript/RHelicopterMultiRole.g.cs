#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHelicopterMultiRole<br/>
/// (size = 3408)
/// (flags = 10486326)
/// </summary>
public partial class RHelicopterMultiRole : BmSDK.BmScript.RHelicopter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHelicopterMultiRole", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHelicopterMultiRole.
    /// </summary>
    public static RHelicopterMultiRole DefaultObject => (RHelicopterMultiRole)StaticClass().DefaultObject;

    internal RHelicopterMultiRole() { }

    /// <summary>
    /// Constructs a new RHelicopterMultiRole
    /// </summary>
    public RHelicopterMultiRole(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopterMultiRole(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterMultiRole>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterMultiRole>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterMultiRole>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterMultiRole>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterMultiRole>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterMultiRole>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterMultiRole>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterMultiRole>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Destroyed, "BmScript.RHelicopterMultiRole.Destroyed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PreStreamOut, "BmScript.RHelicopterMultiRole.PreStreamOut", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetArmour;
    /// <summary>
    /// Function: GetArmour
    /// </summary>
    public unsafe override float GetArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetArmour, "BmScript.RHelicopterMultiRole.GetArmour", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsPlayerInvisible;
    /// <summary>
    /// Function: IsPlayerInvisible
    /// </summary>
    public unsafe override bool IsPlayerInvisible()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsPlayerInvisible, "BmScript.RHelicopterMultiRole.IsPlayerInvisible", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeDamageFromWeapon;
    /// <summary>
    /// Function: TakeDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeDamageFromWeapon(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, bool bHeadShot = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeDamageFromWeapon, "BmScript.RHelicopterMultiRole.TakeDamageFromWeapon", this);
        byte* paramsPtr = stackalloc byte[125];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeadShot, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 108);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPointOfInterestBatman;
    /// <summary>
    /// Function: SetPointOfInterestBatman
    /// </summary>
    public unsafe override void SetPointOfInterestBatman(bool TrueFalse)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPointOfInterestBatman, "BmScript.RHelicopterMultiRole.SetPointOfInterestBatman", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrueFalse, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPointOfInterest;
    /// <summary>
    /// Function: SetPointOfInterest
    /// </summary>
    public unsafe override void SetPointOfInterest(BmSDK.Engine.Actor TheActor, BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes PoiType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPointOfInterest, "BmScript.RHelicopterMultiRole.SetPointOfInterest", this);
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoiType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpeakLine;
    /// <summary>
    /// Function: SpeakLine
    /// </summary>
    public unsafe virtual void SpeakLine(BmSDK.Engine.AkDialogueLine the_line)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpeakLine, "BmScript.RHelicopterMultiRole.SpeakLine", this);
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_line, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.RHelicopterMultiRole.Tick", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TickPointOfInterest;
    /// <summary>
    /// Function: TickPointOfInterest
    /// </summary>
    public unsafe override void TickPointOfInterest(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TickPointOfInterest, "BmScript.RHelicopterMultiRole.TickPointOfInterest", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsValidPointOfInterest;
    /// <summary>
    /// Function: IsValidPointOfInterest
    /// </summary>
    public unsafe override bool IsValidPointOfInterest(BmSDK.Engine.Actor TheActor, BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes PoiType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsValidPointOfInterest, "BmScript.RHelicopterMultiRole.IsValidPointOfInterest", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoiType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ChinookTick;
    /// <summary>
    /// Function: ChinookTick
    /// </summary>
    public unsafe virtual void ChinookTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ChinookTick, "BmScript.RHelicopterMultiRole.ChinookTick", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WithinRangeOfStateTarget;
    /// <summary>
    /// Function: WithinRangeOfStateTarget
    /// </summary>
    public unsafe virtual bool WithinRangeOfStateTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WithinRangeOfStateTarget, "BmScript.RHelicopterMultiRole.WithinRangeOfStateTarget", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasCompletedState;
    /// <summary>
    /// Function: HasCompletedState
    /// </summary>
    public unsafe virtual bool HasCompletedState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasCompletedState, "BmScript.RHelicopterMultiRole.HasCompletedState", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckStateComplete;
    /// <summary>
    /// Function: CheckStateComplete
    /// </summary>
    public unsafe virtual void CheckStateComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckStateComplete, "BmScript.RHelicopterMultiRole.CheckStateComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateLookAtTarget;
    /// <summary>
    /// Function: UpdateLookAtTarget
    /// </summary>
    public unsafe virtual void UpdateLookAtTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateLookAtTarget, "BmScript.RHelicopterMultiRole.UpdateLookAtTarget", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MoveTowardsWithModifiedAltitude;
    /// <summary>
    /// Function: MoveTowardsWithModifiedAltitude
    /// </summary>
    public unsafe virtual void MoveTowardsWithModifiedAltitude(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MoveTowardsWithModifiedAltitude, "BmScript.RHelicopterMultiRole.MoveTowardsWithModifiedAltitude", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DetachTank;
    /// <summary>
    /// Function: DetachTank
    /// </summary>
    public unsafe virtual void DetachTank()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DetachTank, "BmScript.RHelicopterMultiRole.DetachTank", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AttachTank;
    /// <summary>
    /// Function: AttachTank
    /// </summary>
    public unsafe virtual void AttachTank(BmSDK.BmGame.RVehicleNPC TankActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AttachTank, "BmScript.RHelicopterMultiRole.AttachTank", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TankActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MultiplyMovementVars;
    /// <summary>
    /// Function: MultiplyMovementVars
    /// </summary>
    public unsafe virtual void MultiplyMovementVars(float Scalar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MultiplyMovementVars, "BmScript.RHelicopterMultiRole.MultiplyMovementVars", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scalar, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetStateFromSeqAct;
    /// <summary>
    /// Function: SetStateFromSeqAct
    /// </summary>
    public unsafe virtual void SetStateFromSeqAct(BmSDK.FName the_state, BmSDK.BmScript.RSeqAct_SetMultiroleHelicopterState state_controller)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetStateFromSeqAct, "BmScript.RHelicopterMultiRole.SetStateFromSeqAct", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_state, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(state_controller, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindClosestSafePosition;
    /// <summary>
    /// Function: FindClosestSafePosition
    /// </summary>
    public unsafe virtual void FindClosestSafePosition(System.Numerics.Vector3 TargetPosition, float StartingAngle, float HorzDist, float Altitude, out System.Numerics.Vector3 SafePosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindClosestSafePosition, "BmScript.RHelicopterMultiRole.FindClosestSafePosition", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingAngle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HorzDist, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Altitude, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SafePosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SafePosition, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SafePosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckPointForInVolumeAndLos;
    /// <summary>
    /// Function: CheckPointForInVolumeAndLos
    /// </summary>
    public unsafe virtual bool CheckPointForInVolumeAndLos(System.Numerics.Vector3 test_point, System.Numerics.Vector3 TargetPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckPointForInVolumeAndLos, "BmScript.RHelicopterMultiRole.CheckPointForInVolumeAndLos", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(test_point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetEngaged;
    /// <summary>
    /// Function: SetEngaged
    /// </summary>
    public unsafe virtual void SetEngaged(bool engaged)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetEngaged, "BmScript.RHelicopterMultiRole.SetEngaged", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(engaged, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateWeaponSelection;
    /// <summary>
    /// Function: UpdateWeaponSelection
    /// </summary>
    public unsafe virtual void UpdateWeaponSelection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateWeaponSelection, "BmScript.RHelicopterMultiRole.UpdateWeaponSelection", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetWeaponToChaingun;
    /// <summary>
    /// Function: SetWeaponToChaingun
    /// </summary>
    public unsafe virtual void SetWeaponToChaingun(bool setchaingun)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetWeaponToChaingun, "BmScript.RHelicopterMultiRole.SetWeaponToChaingun", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(setchaingun, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldForceMissedShot;
    /// <summary>
    /// Function: ShouldForceMissedShot
    /// </summary>
    public unsafe override bool ShouldForceMissedShot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldForceMissedShot, "BmScript.RHelicopterMultiRole.ShouldForceMissedShot", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetHelicopterControlVolume;
    /// <summary>
    /// Function: SetHelicopterControlVolume
    /// </summary>
    public unsafe override void SetHelicopterControlVolume(BmSDK.BmGame.RHelicopterControlVolume ControlVolume, bool bEntering)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetHelicopterControlVolume, "BmScript.RHelicopterMultiRole.SetHelicopterControlVolume", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControlVolume, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntering, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FireRocket;
    /// <summary>
    /// Function: FireRocket
    /// </summary>
    public unsafe override BmSDK.BmScript.RHelicopterRocket FireRocket(bool TargetBatman, System.Numerics.Vector3 StaticTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FireRocket, "BmScript.RHelicopterMultiRole.FireRocket", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBatman, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StaticTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RHelicopterRocket>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetRocketInitialSalvoSize;
    /// <summary>
    /// Function: SetRocketInitialSalvoSize
    /// </summary>
    public unsafe override void SetRocketInitialSalvoSize()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetRocketInitialSalvoSize, "BmScript.RHelicopterMultiRole.SetRocketInitialSalvoSize", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsWithinRange;
    /// <summary>
    /// Function: IsWithinRange
    /// </summary>
    public unsafe virtual bool IsWithinRange(System.Numerics.Vector3 TargetPosition, float fMaxRange, float fMinRange = default, bool HorizontalOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsWithinRange, "BmScript.RHelicopterMultiRole.IsWithinRange", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fMaxRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fMinRange, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HorizontalOnly, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsAttackEnabled;
    /// <summary>
    /// Function: IsAttackEnabled
    /// </summary>
    public unsafe override bool IsAttackEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsAttackEnabled, "BmScript.RHelicopterMultiRole.IsAttackEnabled", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetViewingBatmanAuto;
    /// <summary>
    /// Function: SetViewingBatmanAuto
    /// </summary>
    public unsafe virtual void SetViewingBatmanAuto()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetViewingBatmanAuto, "BmScript.RHelicopterMultiRole.SetViewingBatmanAuto", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DrawDebugGraphics;
    /// <summary>
    /// Function: DrawDebugGraphics
    /// </summary>
    public unsafe override void DrawDebugGraphics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DrawDebugGraphics, "BmScript.RHelicopterMultiRole.DrawDebugGraphics", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.RHelicopterMultiRole.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GotoInitialState;
    /// <summary>
    /// Function: GotoInitialState
    /// </summary>
    public unsafe override void GotoInitialState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GotoInitialState, "BmScript.RHelicopterMultiRole.GotoInitialState", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: TankDropState
    /// </summary>
    public enum TankDropState : byte
    {
        TDS_None = 0,
        TDS_MoveToHighPoint = 1,
        TDS_LowerToDropPoint = 2,
        TDS_ReleaseTank = 3,
        TDS_ReturnToHighPoint = 4,
        TDS_DropComplete = 5,
        TDS_MAX = 6,
    }

    /// <summary>
    /// BoolProperty: CanTrackPlayerWithoutVisualContact
    /// </summary>
    public unsafe bool CanTrackPlayerWithoutVisualContact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: OnlyVulnerableToExplosives
    /// </summary>
    public unsafe bool OnlyVulnerableToExplosives
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: EnableRedHoodDialogue
    /// </summary>
    public unsafe bool EnableRedHoodDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: StrafeClockwise
    /// </summary>
    public unsafe bool StrafeClockwise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: UseMoveToRotation
    /// </summary>
    public unsafe bool UseMoveToRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: MaintainLookatEvenWithoutVisualContact
    /// </summary>
    public unsafe bool MaintainLookatEvenWithoutVisualContact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: PayAttentionToPlayer
    /// </summary>
    public unsafe bool PayAttentionToPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: AllowAttack
    /// </summary>
    public unsafe bool AllowAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: SwitchToPursuitIfVisualContactGained
    /// </summary>
    public unsafe bool SwitchToPursuitIfVisualContactGained
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: AbortPursuitIfVisualContactLost
    /// </summary>
    public unsafe bool AbortPursuitIfVisualContactLost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: bChaingunSelected
    /// </summary>
    public unsafe bool bChaingunSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: bAttackEngaged
    /// </summary>
    public unsafe bool bAttackEngaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: Invulnerable
    /// </summary>
    public unsafe bool Invulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: bCurrentlyTalking
    /// </summary>
    public unsafe bool bCurrentlyTalking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Heli_MinorDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Heli_MinorDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Heli_MajorDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Heli_MajorDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Batman_MinorDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Batman_MinorDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Batman_MediumDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Batman_MediumDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Batman_MajorDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Batman_MajorDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// BoolProperty: HelicopterDamageFlag
    /// </summary>
    public unsafe bool HelicopterDamageFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3148); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3148); }
    }

    /// <summary>
    /// FloatProperty: MaxVelocity
    /// </summary>
    public unsafe float MaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }

    /// <summary>
    /// FloatProperty: StrafeVelocity
    /// </summary>
    public unsafe float StrafeVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// FloatProperty: RocketAttackRange
    /// </summary>
    public unsafe float RocketAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// FloatProperty: RocketAttackMinRange
    /// </summary>
    public unsafe float RocketAttackMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// FloatProperty: ChaingunAttackRange
    /// </summary>
    public unsafe float ChaingunAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// FloatProperty: ChaingunAttackMinRange
    /// </summary>
    public unsafe float ChaingunAttackMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }

    /// <summary>
    /// IntProperty: RocketsPerSalvo
    /// </summary>
    public unsafe int RocketsPerSalvo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// IntProperty: RocketsPerSalvoDuringStrafingRun
    /// </summary>
    public unsafe int RocketsPerSalvoDuringStrafingRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// IntProperty: RocketsPerSalvoDuringBlanketAttack
    /// </summary>
    public unsafe int RocketsPerSalvoDuringBlanketAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// IntProperty: RocketsHorizontalSpreadDuringBlanket
    /// </summary>
    public unsafe int RocketsHorizontalSpreadDuringBlanket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }

    /// <summary>
    /// IntProperty: HelicopterArmour
    /// </summary>
    public unsafe int HelicopterArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }
    }

    /// <summary>
    /// ObjectProperty: DoNotLeaveThisVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume DoNotLeaveThisVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStateController
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_SetMultiroleHelicopterState CurrentStateController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_SetMultiroleHelicopterState>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// ObjectProperty: AttachedTank
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC AttachedTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// ArrayProperty: VerticallyAvoidTheseVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterControlVolume> VerticallyAvoidTheseVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterControlVolume>>(Ptr + 3220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3220); }
    }

    /// <summary>
    /// FloatProperty: HeightAboveBatmanForAttack
    /// </summary>
    public unsafe float HeightAboveBatmanForAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3236); }
    }

    /// <summary>
    /// FloatProperty: HorizontalDistanceFromBatmanForAttack
    /// </summary>
    public unsafe float HorizontalDistanceFromBatmanForAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// FloatProperty: lowestDeltaT
    /// </summary>
    public unsafe float lowestDeltaT
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// FloatProperty: OverrideSpeed
    /// </summary>
    public unsafe float OverrideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }
    }

    /// <summary>
    /// StructProperty: FreeMoveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeMoveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3252);

    /// <summary>
    /// FloatProperty: UpdateFreeMoveTimeStamp
    /// </summary>
    public unsafe float UpdateFreeMoveTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3264); }
    }

    /// <summary>
    /// FloatProperty: UpdateFreeMovePeriod
    /// </summary>
    public unsafe float UpdateFreeMovePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3268); }
    }

    /// <summary>
    /// StructProperty: MoveToRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator MoveToRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3272);

    /// <summary>
    /// StructProperty: FreeMoveOrigin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeMoveOrigin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3284);

    /// <summary>
    /// StructProperty: StrafingTargetPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StrafingTargetPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3296);

    /// <summary>
    /// StructProperty: StrafingFireDirectionVector
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StrafingFireDirectionVector
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3308);

    /// <summary>
    /// FloatProperty: StrafingFireDirectionRandomOffsetAngle
    /// </summary>
    public unsafe float StrafingFireDirectionRandomOffsetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// StructProperty: BlanketOrigin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BlanketOrigin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3324);

    /// <summary>
    /// StructProperty: BlanketTargetPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BlanketTargetPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3336);

    /// <summary>
    /// FloatProperty: RocketMaxDistance
    /// </summary>
    public unsafe float RocketMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3348); }
    }

    /// <summary>
    /// FloatProperty: fCurrentWeaponRangeMin
    /// </summary>
    public unsafe float fCurrentWeaponRangeMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// FloatProperty: fCurrentWeaponRangeMax
    /// </summary>
    public unsafe float fCurrentWeaponRangeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }

    /// <summary>
    /// ByteProperty: CurrentWeaponAttackMode
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterIntermediate.HeliAttackMode CurrentWeaponAttackMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterIntermediate.HeliAttackMode>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }

    /// <summary>
    /// ByteProperty: CurrentDropState
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterMultiRole.TankDropState CurrentDropState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterMultiRole.TankDropState>(Ptr + 3361); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3361); }
    }

    /// <summary>
    /// FloatProperty: MovementModifierWhenTankAttached
    /// </summary>
    public unsafe float MovementModifierWhenTankAttached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3364); }
    }

    /// <summary>
    /// IntProperty: BlanketCounter
    /// </summary>
    public unsafe int BlanketCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }
    }

    /// <summary>
    /// FloatProperty: fPostTalkTimer
    /// </summary>
    public unsafe float fPostTalkTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3372); }
    }

    /// <summary>
    /// IntProperty: BatmanHealthValueCached
    /// </summary>
    public unsafe int BatmanHealthValueCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// IntProperty: HelicopterArmourInitial
    /// </summary>
    public unsafe int HelicopterArmourInitial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }

    /// <summary>
    /// FloatProperty: maxPOIDist
    /// </summary>
    public unsafe float maxPOIDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3384); }
    }

    /// <summary>
    /// FloatProperty: TankDropTimer
    /// </summary>
    public unsafe float TankDropTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3388); }
    }

    /// <summary>
    /// FloatProperty: TankDropAltitudeHighBeginEnd
    /// </summary>
    public unsafe float TankDropAltitudeHighBeginEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }

    /// <summary>
    /// FloatProperty: TankDropAltitudeToDropAt
    /// </summary>
    public unsafe float TankDropAltitudeToDropAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3396); }
    }

    /// <summary>
    /// NameProperty: PendingState
    /// </summary>
    public unsafe BmSDK.FName PendingState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }
    }
}
