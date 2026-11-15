#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHelicopterGunship<br/>
/// (size = 3444)
/// (flags = 10486326)
/// </summary>
public partial class RHelicopterGunship : BmSDK.BmScript.RHelicopterIntermediate, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHelicopterGunship", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHelicopterGunship.
    /// </summary>
    public static RHelicopterGunship DefaultObject => (RHelicopterGunship)StaticClass().DefaultObject;

    internal RHelicopterGunship() { }

    /// <summary>
    /// Constructs a new RHelicopterGunship
    /// </summary>
    public RHelicopterGunship(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopterGunship(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunship>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunship>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunship>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunship>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunship>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunship>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunship>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunship>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_KeepBatmobileInCombat;
    /// <summary>
    /// Function: KeepBatmobileInCombat
    /// </summary>
    public unsafe virtual void KeepBatmobileInCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_KeepBatmobileInCombat, "BmScript.RHelicopterGunship.KeepBatmobileInCombat", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OverrideFireImpulse;
    /// <summary>
    /// Function: OverrideFireImpulse
    /// </summary>
    public unsafe override void OverrideFireImpulse(System.Numerics.Vector3 Position, BmSDK.Engine.RB_RadialImpulseComponent RadialImpulseComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OverrideFireImpulse, "BmScript.RHelicopterGunship.OverrideFireImpulse", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadialImpulseComponent, paramsPtr + 12);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetArmour, "BmScript.RHelicopterGunship.GetArmour", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnCrashDouble;
    /// <summary>
    /// Function: SpawnCrashDouble
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RHelicopterGunshipCrashDouble SpawnCrashDouble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnCrashDouble, "BmScript.RHelicopterGunship.SpawnCrashDouble", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RHelicopterGunshipCrashDouble>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetConstrainedY;
    /// <summary>
    /// Function: GetConstrainedY
    /// </summary>
    public unsafe virtual float GetConstrainedY(float raw_y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetConstrainedY, "BmScript.RHelicopterGunship.GetConstrainedY", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(raw_y, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpeakLine;
    /// <summary>
    /// Function: SpeakLine
    /// </summary>
    public unsafe virtual void SpeakLine(BmSDK.Engine.AkDialogueLine the_line)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpeakLine, "BmScript.RHelicopterGunship.SpeakLine", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.RHelicopterGunship.Tick", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateGunshipRotation;
    /// <summary>
    /// Function: UpdateGunshipRotation
    /// </summary>
    public unsafe virtual void UpdateGunshipRotation(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateGunshipRotation, "BmScript.RHelicopterGunship.UpdateGunshipRotation", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateLight;
    /// <summary>
    /// Function: UpdateLight
    /// </summary>
    public unsafe virtual void UpdateLight(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateLight, "BmScript.RHelicopterGunship.UpdateLight", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateLookAtTarget, "BmScript.RHelicopterGunship.UpdateLookAtTarget", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MoveTowardsWithModifiedAltitude;
    /// <summary>
    /// Function: MoveTowardsWithModifiedAltitude
    /// </summary>
    public unsafe virtual bool MoveTowardsWithModifiedAltitude(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MoveTowardsWithModifiedAltitude, "BmScript.RHelicopterGunship.MoveTowardsWithModifiedAltitude", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Defeated;
    /// <summary>
    /// Function: Defeated
    /// </summary>
    public unsafe virtual void Defeated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Defeated, "BmScript.RHelicopterGunship.Defeated", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ExplodeEffect;
    /// <summary>
    /// Function: ExplodeEffect
    /// </summary>
    public unsafe virtual void ExplodeEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ExplodeEffect, "BmScript.RHelicopterGunship.ExplodeEffect", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckTriggerArmourBreach;
    /// <summary>
    /// Function: CheckTriggerArmourBreach
    /// </summary>
    public unsafe virtual void CheckTriggerArmourBreach()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckTriggerArmourBreach, "BmScript.RHelicopterGunship.CheckTriggerArmourBreach", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeDamageFromWeapon;
    /// <summary>
    /// Function: TakeDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeDamageFromWeapon(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, bool bHeadShot = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeDamageFromWeapon, "BmScript.RHelicopterGunship.TakeDamageFromWeapon", this);
        byte* paramsPtr = stackalloc byte[136];
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindClosestSafePosition;
    /// <summary>
    /// Function: FindClosestSafePosition
    /// </summary>
    public unsafe virtual void FindClosestSafePosition(System.Numerics.Vector3 TargetPosition, float HorzDist, out System.Numerics.Vector3 SafePosition, bool random_drift = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindClosestSafePosition, "BmScript.RHelicopterGunship.FindClosestSafePosition", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HorzDist, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SafePosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SafePosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(random_drift, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SafePosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckPointForInVolumeAndLos;
    /// <summary>
    /// Function: CheckPointForInVolumeAndLos
    /// </summary>
    public unsafe virtual bool CheckPointForInVolumeAndLos(System.Numerics.Vector3 test_point, System.Numerics.Vector3 TargetPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckPointForInVolumeAndLos, "BmScript.RHelicopterGunship.CheckPointForInVolumeAndLos", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetEngaged, "BmScript.RHelicopterGunship.SetEngaged", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(engaged, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TickWeapons;
    /// <summary>
    /// Function: TickWeapons
    /// </summary>
    public unsafe override void TickWeapons(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TickWeapons, "BmScript.RHelicopterGunship.TickWeapons", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SalvoComplete;
    /// <summary>
    /// Function: SalvoComplete
    /// </summary>
    public unsafe virtual void SalvoComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SalvoComplete, "BmScript.RHelicopterGunship.SalvoComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetRocketInitialSalvoSize;
    /// <summary>
    /// Function: SetRocketInitialSalvoSize
    /// </summary>
    public unsafe override void SetRocketInitialSalvoSize()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetRocketInitialSalvoSize, "BmScript.RHelicopterGunship.SetRocketInitialSalvoSize", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeployRocketPods;
    /// <summary>
    /// Function: DeployRocketPods
    /// </summary>
    public unsafe override void DeployRocketPods(bool do_deploy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeployRocketPods, "BmScript.RHelicopterGunship.DeployRocketPods", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(do_deploy, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldForceMissedShot, "BmScript.RHelicopterGunship.ShouldForceMissedShot", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsWithinRange;
    /// <summary>
    /// Function: IsWithinRange
    /// </summary>
    public unsafe virtual bool IsWithinRange(System.Numerics.Vector3 TargetPosition, float fMaxRange, float fMinRange = default, bool HorizontalOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsWithinRange, "BmScript.RHelicopterGunship.IsWithinRange", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fMaxRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fMinRange, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HorizontalOnly, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsPlayerInvisible;
    /// <summary>
    /// Function: IsPlayerInvisible
    /// </summary>
    public unsafe override bool IsPlayerInvisible()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsPlayerInvisible, "BmScript.RHelicopterGunship.IsPlayerInvisible", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsAttackEnabled;
    /// <summary>
    /// Function: IsAttackEnabled
    /// </summary>
    public unsafe override bool IsAttackEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsAttackEnabled, "BmScript.RHelicopterGunship.IsAttackEnabled", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetViewingBatmanAuto, "BmScript.RHelicopterGunship.SetViewingBatmanAuto", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FireGunshipRocket;
    /// <summary>
    /// Function: FireGunshipRocket
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RHelicopterRocket FireGunshipRocket()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FireGunshipRocket, "BmScript.RHelicopterGunship.FireGunshipRocket", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RHelicopterRocket>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SelectRandomAttack;
    /// <summary>
    /// Function: SelectRandomAttack
    /// </summary>
    public unsafe virtual void SelectRandomAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SelectRandomAttack, "BmScript.RHelicopterGunship.SelectRandomAttack", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGunshipWeapon;
    /// <summary>
    /// Function: SetGunshipWeapon
    /// </summary>
    public unsafe virtual void SetGunshipWeapon(BmSDK.BmScript.RHelicopterGunship.GunshipWeapon NewWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGunshipWeapon, "BmScript.RHelicopterGunship.SetGunshipWeapon", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoMoveToward;
    /// <summary>
    /// Function: DoMoveToward
    /// </summary>
    public unsafe override bool DoMoveToward(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoMoveToward, "BmScript.RHelicopterGunship.DoMoveToward", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLerpedX;
    /// <summary>
    /// Function: GetLerpedX
    /// </summary>
    public unsafe virtual float GetLerpedX(float x_position, int right_enum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLerpedX, "BmScript.RHelicopterGunship.GetLerpedX", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(x_position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_enum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAltitudeForX;
    /// <summary>
    /// Function: GetAltitudeForX
    /// </summary>
    public unsafe virtual float GetAltitudeForX(float x_position)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAltitudeForX, "BmScript.RHelicopterGunship.GetAltitudeForX", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(x_position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetupGunshipWithX;
    /// <summary>
    /// Function: SetupGunshipWithX
    /// </summary>
    public unsafe virtual void SetupGunshipWithX(BmSDK.BmScript.RHelicopterGunship.GunshipXPoint array_enum, BmSDK.TArray<BmSDK.BmScript.RHelicopterGunshipCalibrationPoint> actor_array, bool use_highest_x)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetupGunshipWithX, "BmScript.RHelicopterGunship.SetupGunshipWithX", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(array_enum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actor_array, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(use_highest_x, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DebugSquare;
    /// <summary>
    /// Function: DebugSquare
    /// </summary>
    public unsafe virtual void DebugSquare(BmSDK.BmScript.RHelicopterGunship.GunshipXPoint CurveEnum1, BmSDK.BmScript.RHelicopterGunship.GunshipXPoint CurveEnum2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DebugSquare, "BmScript.RHelicopterGunship.DebugSquare", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveEnum1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveEnum2, paramsPtr + 1);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DrawDebugGraphics, "BmScript.RHelicopterGunship.DrawDebugGraphics", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitialiseGunshipParams;
    /// <summary>
    /// Function: InitialiseGunshipParams
    /// </summary>
    public unsafe virtual void InitialiseGunshipParams(BmSDK.BmScript.RSeqAct_HelicopterGunshipCalibrateAndBegin seq_act)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitialiseGunshipParams, "BmScript.RHelicopterGunship.InitialiseGunshipParams", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(seq_act, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnableMissiles;
    /// <summary>
    /// Function: EnableMissiles
    /// </summary>
    public unsafe virtual void EnableMissiles()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnableMissiles, "BmScript.RHelicopterGunship.EnableMissiles", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetupPlayerGrapplePoint;
    /// <summary>
    /// Function: SetupPlayerGrapplePoint
    /// </summary>
    public unsafe override void SetupPlayerGrapplePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetupPlayerGrapplePoint, "BmScript.RHelicopterGunship.SetupPlayerGrapplePoint", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoArmourCalculations;
    /// <summary>
    /// Function: DoArmourCalculations
    /// </summary>
    public unsafe virtual void DoArmourCalculations()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoArmourCalculations, "BmScript.RHelicopterGunship.DoArmourCalculations", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ApplyVisualDamage;
    /// <summary>
    /// Function: ApplyVisualDamage
    /// </summary>
    public unsafe virtual void ApplyVisualDamage(System.Numerics.Vector3 WorldPos, float Radius, float Amount, float PartBreakOffImpulse)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ApplyVisualDamage, "BmScript.RHelicopterGunship.ApplyVisualDamage", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartBreakOffImpulse, paramsPtr + 20);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.RHelicopterGunship.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetDroneSpawner;
    /// <summary>
    /// Function: SetDroneSpawner
    /// </summary>
    public unsafe override void SetDroneSpawner(BmSDK.BmScript.RSeqAct_SpawnDrone SpawnAct)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetDroneSpawner, "BmScript.RHelicopterGunship.SetDroneSpawner", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnAct, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsBatmanInBatmobile;
    /// <summary>
    /// Function: IsBatmanInBatmobile
    /// </summary>
    public unsafe virtual bool IsBatmanInBatmobile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsBatmanInBatmobile, "BmScript.RHelicopterGunship.IsBatmanInBatmobile", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GotoInitialState;
    /// <summary>
    /// Function: GotoInitialState
    /// </summary>
    public unsafe override void GotoInitialState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GotoInitialState, "BmScript.RHelicopterGunship.GotoInitialState", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: GunshipArmourState
    /// </summary>
    public enum GunshipArmourState : byte
    {
        GAS_HasArmour = 0,
        GAS_ArmourDepleted = 1,
        GAS_ArmourBreached = 2,
        GAS_MAX = 3,
    }

    /// <summary>
    /// Enum: GunshipWeapon
    /// </summary>
    public enum GunshipWeapon : byte
    {
        GW_None = 0,
        GW_HomingMissiles = 1,
        GW_MortarMissiles = 2,
        GW_SwarmMissiles = 3,
        GW_MAX = 4,
    }

    /// <summary>
    /// Enum: GunshipXPoint
    /// </summary>
    public enum GunshipXPoint : byte
    {
        GXP_Left_ChargeStartPoint = 0,
        GXP_Left_AboveWall = 1,
        GXP_Left_LowPoint = 2,
        GXP_Right_LowPoint = 3,
        GXP_Right_AboveWall = 4,
        GXP_Right_ChargeStartPoint = 5,
        GXP_MAX = 6,
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// IntProperty: DamageMaterialIndex
    /// </summary>
    public unsafe int DamageMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// ObjectProperty: DamageMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DamageMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// ObjectProperty: MissileProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile MissileProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// ObjectProperty: SwarmerProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SwarmerProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// ObjectProperty: MortarProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile MortarProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// ObjectProperty: Spawner
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_SpawnDrone Spawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_SpawnDrone>(Ptr + 3192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }
    }

    /// <summary>
    /// ObjectProperty: lightsArchetype
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterGunshipSelfLight lightsArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterGunshipSelfLight>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// ObjectProperty: SelfLight
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterGunshipSelfLight SelfLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterGunshipSelfLight>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// ObjectProperty: HoverLoop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HoverLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }

    /// <summary>
    /// ComponentProperty: explosionImpulse
    /// </summary>
    public unsafe BmSDK.Engine.RB_RadialImpulseComponent explosionImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_RadialImpulseComponent>(Ptr + 3224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }
    }

    /// <summary>
    /// ComponentProperty: VisualDamageComp
    /// </summary>
    public unsafe BmSDK.BmGame.RVisualDamageComponent VisualDamageComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVisualDamageComponent>(Ptr + 3232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3232); }
    }

    /// <summary>
    /// FloatProperty: RocketAttackRange
    /// </summary>
    public unsafe float RocketAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// FloatProperty: RocketAttackMinRange
    /// </summary>
    public unsafe float RocketAttackMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// FloatProperty: ChaingunAttackRange
    /// </summary>
    public unsafe float ChaingunAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }
    }

    /// <summary>
    /// FloatProperty: ChaingunAttackMinRange
    /// </summary>
    public unsafe float ChaingunAttackMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// IntProperty: RocketsPerSalvo
    /// </summary>
    public unsafe int RocketsPerSalvo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3256); }
    }

    /// <summary>
    /// IntProperty: SwarmerMissilesPerSalvo
    /// </summary>
    public unsafe int SwarmerMissilesPerSalvo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3260); }
    }

    /// <summary>
    /// FloatProperty: StartOfLevelSalvoMultiplier
    /// </summary>
    public unsafe float StartOfLevelSalvoMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3264); }
    }

    /// <summary>
    /// FloatProperty: StartOfLevelSalvosUntilHealthProportionIs
    /// </summary>
    public unsafe float StartOfLevelSalvosUntilHealthProportionIs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3268); }
    }

    /// <summary>
    /// FloatProperty: CurrentSalvoMultiplier
    /// </summary>
    public unsafe float CurrentSalvoMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }
    }

    /// <summary>
    /// FloatProperty: DeathDisappearTime
    /// </summary>
    public unsafe float DeathDisappearTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }

    /// <summary>
    /// IntProperty: HelicopterArmour
    /// </summary>
    public unsafe int HelicopterArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3280); }
    }

    /// <summary>
    /// FloatProperty: VisibleArmourProportionWhenDepleted
    /// </summary>
    public unsafe float VisibleArmourProportionWhenDepleted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3284); }
    }

    /// <summary>
    /// IntProperty: HelicopterArmourBreachThreshold
    /// </summary>
    public unsafe int HelicopterArmourBreachThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3288); }
    }

    /// <summary>
    /// FloatProperty: HelicopterArmourInitialInverse
    /// </summary>
    public unsafe float HelicopterArmourInitialInverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3292); }
    }

    /// <summary>
    /// FloatProperty: HorizontalDistanceFromBatmanForAttack
    /// </summary>
    public unsafe float HorizontalDistanceFromBatmanForAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }

    /// <summary>
    /// BoolProperty: EnableRedHoodDialogue
    /// </summary>
    public unsafe bool EnableRedHoodDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: StrafeClockwise
    /// </summary>
    public unsafe bool StrafeClockwise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: AllowAttack
    /// </summary>
    public unsafe bool AllowAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bChaingunSelected
    /// </summary>
    public unsafe bool bChaingunSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bAttackEngaged
    /// </summary>
    public unsafe bool bAttackEngaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bCurrentlyTalking
    /// </summary>
    public unsafe bool bCurrentlyTalking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Heli_MinorDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Heli_MinorDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Heli_MajorDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Heli_MajorDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Batman_MinorDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Batman_MinorDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Batman_MediumDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Batman_MediumDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLine_Batman_MajorDamage
    /// </summary>
    public unsafe bool bHasPlayedLine_Batman_MajorDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: HelicopterDamageFlag
    /// </summary>
    public unsafe bool HelicopterDamageFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bIsScarecrowGunship
    /// </summary>
    public unsafe bool bIsScarecrowGunship
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: bGunshipParamsInitialised
    /// </summary>
    public unsafe bool bGunshipParamsInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: HomingMissilesEnabled
    /// </summary>
    public unsafe bool HomingMissilesEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// BoolProperty: ChargeAttackFromLowEnd
    /// </summary>
    public unsafe bool ChargeAttackFromLowEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3300); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3300); }
    }

    /// <summary>
    /// FloatProperty: CurrentStateSpeed
    /// </summary>
    public unsafe float CurrentStateSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3304); }
    }

    /// <summary>
    /// StructProperty: FreeMoveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeMoveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3308);

    /// <summary>
    /// StructProperty: LastFreeMoveTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastFreeMoveTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3320);

    /// <summary>
    /// FloatProperty: UpdateFreeMoveTimeStamp
    /// </summary>
    public unsafe float UpdateFreeMoveTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }

    /// <summary>
    /// FloatProperty: UpdateFreeMovePeriod
    /// </summary>
    public unsafe float UpdateFreeMovePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// FloatProperty: fCurrentWeaponRangeMin
    /// </summary>
    public unsafe float fCurrentWeaponRangeMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3340); }
    }

    /// <summary>
    /// FloatProperty: fCurrentWeaponRangeMax
    /// </summary>
    public unsafe float fCurrentWeaponRangeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3344); }
    }

    /// <summary>
    /// ByteProperty: CurrentWeaponAttackMode
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterIntermediate.HeliAttackMode CurrentWeaponAttackMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterIntermediate.HeliAttackMode>(Ptr + 3348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3348); }
    }

    /// <summary>
    /// ByteProperty: CurrentGunshipWeapon
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterGunship.GunshipWeapon CurrentGunshipWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterGunship.GunshipWeapon>(Ptr + 3349); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3349); }
    }

    /// <summary>
    /// ByteProperty: CurrentStateWeapon
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterGunship.GunshipWeapon CurrentStateWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterGunship.GunshipWeapon>(Ptr + 3350); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3350); }
    }

    /// <summary>
    /// ByteProperty: CurrentArmourState
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterGunship.GunshipArmourState CurrentArmourState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterGunship.GunshipArmourState>(Ptr + 3351); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3351); }
    }

    /// <summary>
    /// FloatProperty: fPostTalkTimer
    /// </summary>
    public unsafe float fPostTalkTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// IntProperty: BatmanHealthValueCached
    /// </summary>
    public unsafe int BatmanHealthValueCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }

    /// <summary>
    /// IntProperty: HelicopterArmourInitial
    /// </summary>
    public unsafe int HelicopterArmourInitial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }

    /// <summary>
    /// ArrayProperty: GunshipCurvePosition
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> GunshipCurvePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 3364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3364); }
    }

    /// <summary>
    /// StructProperty: PoolMiddlePoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PoolMiddlePoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3380);

    /// <summary>
    /// FloatProperty: PoolHalfWidth
    /// </summary>
    public unsafe float PoolHalfWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }

    /// <summary>
    /// FloatProperty: PoolHalfLength
    /// </summary>
    public unsafe float PoolHalfLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3396); }
    }

    /// <summary>
    /// FloatProperty: CrashFloorHeight
    /// </summary>
    public unsafe float CrashFloorHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }
    }

    /// <summary>
    /// FloatProperty: GunshipFireTimer
    /// </summary>
    public unsafe float GunshipFireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3404); }
    }

    /// <summary>
    /// IntProperty: SwarmAttackCounter
    /// </summary>
    public unsafe int SwarmAttackCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3408); }
    }

    /// <summary>
    /// IntProperty: SwarmAttackSide
    /// </summary>
    public unsafe int SwarmAttackSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3412); }
    }

    /// <summary>
    /// FloatProperty: ChargeAttackPointToFacePlayer
    /// </summary>
    public unsafe float ChargeAttackPointToFacePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3416); }
    }

    /// <summary>
    /// StructProperty: ChargeAttackDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChargeAttackDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3420);

    /// <summary>
    /// FloatProperty: GeneralPurposeStateTimer
    /// </summary>
    public unsafe float GeneralPurposeStateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }
    }

    /// <summary>
    /// FloatProperty: CrashGravity
    /// </summary>
    public unsafe float CrashGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3436); }
    }

    /// <summary>
    /// FloatProperty: CrashGroundLevel
    /// </summary>
    public unsafe float CrashGroundLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }
}
