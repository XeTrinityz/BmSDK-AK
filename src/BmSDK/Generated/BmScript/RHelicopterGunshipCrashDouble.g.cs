#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHelicopterGunshipCrashDouble<br/>
/// (size = 1512)
/// (flags = 10486326)
/// </summary>
public partial class RHelicopterGunshipCrashDouble : BmSDK.Engine.Pawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHelicopterGunshipCrashDouble", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHelicopterGunshipCrashDouble.
    /// </summary>
    public static RHelicopterGunshipCrashDouble DefaultObject => (RHelicopterGunshipCrashDouble)StaticClass().DefaultObject;

    internal RHelicopterGunshipCrashDouble() { }

    /// <summary>
    /// Constructs a new RHelicopterGunshipCrashDouble
    /// </summary>
    public RHelicopterGunshipCrashDouble(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopterGunshipCrashDouble(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunshipCrashDouble>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunshipCrashDouble>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunshipCrashDouble>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunshipCrashDouble>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunshipCrashDouble>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunshipCrashDouble>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunshipCrashDouble>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterGunshipCrashDouble>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnOnRBCollision;
    /// <summary>
    /// Function: TurnOnRBCollision
    /// </summary>
    public unsafe virtual void TurnOnRBCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnOnRBCollision, "BmScript.RHelicopterGunshipCrashDouble.TurnOnRBCollision", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeDamage, "BmScript.RHelicopterGunshipCrashDouble.TakeDamage", this);
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeDamageFromWeapon, "BmScript.RHelicopterGunshipCrashDouble.TakeDamageFromWeapon", this);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.RHelicopterGunshipCrashDouble.Tick", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoCrash;
    /// <summary>
    /// Function: DoCrash
    /// </summary>
    public unsafe virtual void DoCrash(System.Numerics.Vector3 initial_location, System.Numerics.Vector3 target_location, float lerp_time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoCrash, "BmScript.RHelicopterGunshipCrashDouble.DoCrash", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(initial_location, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_location, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lerp_time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: FinalLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FinalLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1480);

    /// <summary>
    /// StructProperty: InitialOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitialOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1492);

    /// <summary>
    /// FloatProperty: OffsetTimer
    /// </summary>
    public unsafe float OffsetTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: OffsetPeriodInverse
    /// </summary>
    public unsafe float OffsetPeriodInverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }
}
