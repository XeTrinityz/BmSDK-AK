#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMWeaponPredatorRedHoodRifle<br/>
/// (size = 2132)
/// (flags = 10485810)
/// </summary>
public partial class RBMWeaponPredatorRedHoodRifle : BmSDK.BmScript.RBMWeaponRiflePredFull, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMWeaponPredatorRedHoodRifle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMWeaponPredatorRedHoodRifle.
    /// </summary>
    public static RBMWeaponPredatorRedHoodRifle DefaultObject => (RBMWeaponPredatorRedHoodRifle)StaticClass().DefaultObject;

    internal RBMWeaponPredatorRedHoodRifle() { }

    /// <summary>
    /// Constructs a new RBMWeaponPredatorRedHoodRifle
    /// </summary>
    public RBMWeaponPredatorRedHoodRifle(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeaponPredatorRedHoodRifle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponPredatorRedHoodRifle>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponPredatorRedHoodRifle>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponPredatorRedHoodRifle>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponPredatorRedHoodRifle>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponPredatorRedHoodRifle>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponPredatorRedHoodRifle>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponPredatorRedHoodRifle>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponPredatorRedHoodRifle>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RetractGrappleGun;
    /// <summary>
    /// Function: RetractGrappleGun
    /// </summary>
    public unsafe virtual void RetractGrappleGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RetractGrappleGun, "BmScript.RBMWeaponPredatorRedHoodRifle.RetractGrappleGun", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FireGrappleGun;
    /// <summary>
    /// Function: FireGrappleGun
    /// </summary>
    public unsafe virtual void FireGrappleGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FireGrappleGun, "BmScript.RBMWeaponPredatorRedHoodRifle.FireGrappleGun", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTargetGargoyle;
    /// <summary>
    /// Function: SetTargetGargoyle
    /// </summary>
    public unsafe override void SetTargetGargoyle(BmSDK.BmGame.RHidePoint NextGargoyle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTargetGargoyle, "BmScript.RBMWeaponPredatorRedHoodRifle.SetTargetGargoyle", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextGargoyle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CombineGun;
    /// <summary>
    /// Function: CombineGun
    /// </summary>
    public unsafe virtual void CombineGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CombineGun, "BmScript.RBMWeaponPredatorRedHoodRifle.CombineGun", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SplitGun;
    /// <summary>
    /// Function: SplitGun
    /// </summary>
    public unsafe virtual void SplitGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SplitGun, "BmScript.RBMWeaponPredatorRedHoodRifle.SplitGun", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GunShotManagerGetBeamParticle;
    /// <summary>
    /// Function: GunShotManagerGetBeamParticle
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GunShotManagerGetBeamParticle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GunShotManagerGetBeamParticle, "BmScript.RBMWeaponPredatorRedHoodRifle.GunShotManagerGetBeamParticle", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GunShotManangerGetFireAudioEvent;
    /// <summary>
    /// Function: GunShotManangerGetFireAudioEvent
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent GunShotManangerGetFireAudioEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GunShotManangerGetFireAudioEvent, "BmScript.RBMWeaponPredatorRedHoodRifle.GunShotManangerGetFireAudioEvent", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.RBMWeaponPredatorRedHoodRifle.Tick", this);
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCustomEyeLocation;
    /// <summary>
    /// Function: GetCustomEyeLocation
    /// </summary>
    public unsafe override void GetCustomEyeLocation(out System.Numerics.Vector3 EyeLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCustomEyeLocation, "BmScript.RBMWeaponPredatorRedHoodRifle.GetCustomEyeLocation", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EyeLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EyeLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        EyeLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerPPOpacity;
    /// <summary>
    /// Function: GetPlayerPPOpacity
    /// </summary>
    public unsafe virtual float GetPlayerPPOpacity(BmSDK.BmGame.RPlayerControllerCombat RPC, System.Numerics.Vector3 lightPos, System.Numerics.Vector3 LightDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerPPOpacity, "BmScript.RBMWeaponPredatorRedHoodRifle.GetPlayerPPOpacity", this);
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lightPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LightDirection, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateLaserAudioSources;
    /// <summary>
    /// Function: UpdateLaserAudioSources
    /// </summary>
    public unsafe virtual void UpdateLaserAudioSources(float Delta, System.Numerics.Vector3 Loc, BmSDK.Rotator Rot, float angleMultiplier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateLaserAudioSources, "BmScript.RBMWeaponPredatorRedHoodRifle.UpdateLaserAudioSources", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(angleMultiplier, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TraceLaserSound;
    /// <summary>
    /// Function: TraceLaserSound
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 TraceLaserSound(System.Numerics.Vector3 Loc, BmSDK.Rotator Rot, int Spread, float Angle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TraceLaserSound, "BmScript.RBMWeaponPredatorRedHoodRifle.TraceLaserSound", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spread, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Angle, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRECHitReactionAnimName;
    /// <summary>
    /// Function: GetRECHitReactionAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetRECHitReactionAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRECHitReactionAnimName, "BmScript.RBMWeaponPredatorRedHoodRifle.GetRECHitReactionAnimName", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateWeaponConfig;
    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfig(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateWeaponConfig, "BmScript.RBMWeaponPredatorRedHoodRifle.CreateWeaponConfig", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateSniperWeaponConfig;
    /// <summary>
    /// Function: CreateSniperWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateSniperWeaponConfig(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateSniperWeaponConfig, "BmScript.RBMWeaponPredatorRedHoodRifle.CreateSniperWeaponConfig", this);
        byte* paramsPtr = stackalloc byte[1208];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDamage;
    /// <summary>
    /// Function: GetDamage
    /// </summary>
    public unsafe override float GetDamage(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDamage, "BmScript.RBMWeaponPredatorRedHoodRifle.GetDamage", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBeUsedByFriendly;
    /// <summary>
    /// Function: CanBeUsedByFriendly
    /// </summary>
    public unsafe static bool CanBeUsedByFriendly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsedByFriendly, "BmScript.RBMWeaponPredatorRedHoodRifle.CanBeUsedByFriendly");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnOffLaserSight;
    /// <summary>
    /// Function: TurnOffLaserSight
    /// </summary>
    public unsafe override void TurnOffLaserSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnOffLaserSight, "BmScript.RBMWeaponPredatorRedHoodRifle.TurnOffLaserSight", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnOnLaserSight;
    /// <summary>
    /// Function: TurnOnLaserSight
    /// </summary>
    public unsafe override void TurnOnLaserSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnOnLaserSight, "BmScript.RBMWeaponPredatorRedHoodRifle.TurnOnLaserSight", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnOffLaserSightSounds;
    /// <summary>
    /// Function: TurnOffLaserSightSounds
    /// </summary>
    public unsafe virtual void TurnOffLaserSightSounds()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnOffLaserSightSounds, "BmScript.RBMWeaponPredatorRedHoodRifle.TurnOffLaserSightSounds", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnOnLaserSightSounds;
    /// <summary>
    /// Function: TurnOnLaserSightSounds
    /// </summary>
    public unsafe virtual void TurnOnLaserSightSounds()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnOnLaserSightSounds, "BmScript.RBMWeaponPredatorRedHoodRifle.TurnOnLaserSightSounds", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetLightColour;
    /// <summary>
    /// Function: SetLightColour
    /// </summary>
    public unsafe virtual void SetLightColour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetLightColour, "BmScript.RBMWeaponPredatorRedHoodRifle.SetLightColour", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DetachWeapon;
    /// <summary>
    /// Function: DetachWeapon
    /// </summary>
    public unsafe override void DetachWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DetachWeapon, "BmScript.RBMWeaponPredatorRedHoodRifle.DetachWeapon", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AttachLights;
    /// <summary>
    /// Function: AttachLights
    /// </summary>
    public unsafe virtual void AttachLights()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AttachLights, "BmScript.RBMWeaponPredatorRedHoodRifle.AttachLights", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WideBeam;
    /// <summary>
    /// Function: WideBeam
    /// </summary>
    public unsafe override void WideBeam(float BlendSpeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WideBeam, "BmScript.RBMWeaponPredatorRedHoodRifle.WideBeam", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendSpeed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NarrowBeam;
    /// <summary>
    /// Function: NarrowBeam
    /// </summary>
    public unsafe override void NarrowBeam(float BlendSpeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NarrowBeam, "BmScript.RBMWeaponPredatorRedHoodRifle.NarrowBeam", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendSpeed, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.RBMWeaponPredatorRedHoodRifle.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: LeftMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent LeftMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// ComponentProperty: RightMesh<br/>
    /// Default: BmScript.Default__RBMWeaponPredatorRedHoodRifle.RightGunMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// ObjectProperty: LightArchetype<br/>
    /// Default: Pawn_Archetypes.Lights.ArkhamKnight_Rifle_Light
    /// </summary>
    public unsafe BmSDK.Engine.Light LightArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Light>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// ObjectProperty: GunLightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GunLightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGun
    /// </summary>
    public unsafe BmSDK.BmScript.RRedHoodGrappleGun GrappleGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RRedHoodGrappleGun>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGargoyle
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GrappleGargoyle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// ObjectProperty: RedhoodPawn
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainRedHoodPred RedhoodPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainRedHoodPred>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareFX<br/>
    /// Default: BmScript.Default__RBMWeaponPredatorRedHoodRifle.LensFlareFX0
    /// </summary>
    public unsafe BmSDK.Engine.LensFlareComponent LensFlareFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlareComponent>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// ComponentProperty: GunLightMesh<br/>
    /// Default: BmScript.Default__RBMWeaponPredatorRedHoodRifle.SearchLightMesh0
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent GunLightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// ComponentProperty: GunLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent GunLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// StructProperty: GunLightMeshScale3D
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GunLightMeshScale3D
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2020);

    /// <summary>
    /// FloatProperty: LightMeshRadius<br/>
    /// Default: 0.5
    /// </summary>
    public unsafe float LightMeshRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// FloatProperty: DestLightMeshRadius
    /// </summary>
    public unsafe float DestLightMeshRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// FloatProperty: LightMeshRadiusBlendSpeed
    /// </summary>
    public unsafe float LightMeshRadiusBlendSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// FloatProperty: NarrowLightMeshRadius<br/>
    /// Default: 0.15
    /// </summary>
    public unsafe float NarrowLightMeshRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// FloatProperty: WideLightMeshRadius<br/>
    /// Default: 0.5
    /// </summary>
    public unsafe float WideLightMeshRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// FloatProperty: LightInnerAngle<br/>
    /// Default: 4
    /// </summary>
    public unsafe float LightInnerAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// FloatProperty: LightOuterAngle<br/>
    /// Default: 7
    /// </summary>
    public unsafe float LightOuterAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// FloatProperty: LightRadius<br/>
    /// Default: 4096
    /// </summary>
    public unsafe float LightRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// FloatProperty: LightDistanceScale
    /// </summary>
    public unsafe float LightDistanceScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// FloatProperty: LightMeshLength<br/>
    /// Default: 368
    /// </summary>
    public unsafe float LightMeshLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: LightAdditionalLength<br/>
    /// Default: 500
    /// </summary>
    public unsafe float LightAdditionalLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// FloatProperty: LightRollSpeed<br/>
    /// Default: 5000
    /// </summary>
    public unsafe float LightRollSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// FloatProperty: LightForwardProjection<br/>
    /// Default: 200
    /// </summary>
    public unsafe float LightForwardProjection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// FloatProperty: PlayerPPOpacity
    /// </summary>
    public unsafe float PlayerPPOpacity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: PPSpeed<br/>
    /// Default: 2
    /// </summary>
    public unsafe float PPSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// FloatProperty: PPCosAngle<br/>
    /// Default: 0.99
    /// </summary>
    public unsafe float PPCosAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ArrayProperty: LaserSoundEvents<br/>
    /// Default: (Ww_WPN_Rifle_RedHood.Play_Rifle_Redhood_Sniper_Beam_01,Ww_WPN_Rifle_RedHood.Play_Rifle_Redhood_Sniper_Beam_02,Ww_WPN_Rifle_RedHood.Play_Rifle_Redhood_Sniper_Beam_03,Ww_WPN_Rifle_RedHood.Play_Rifle_Re...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> LaserSoundEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// IntProperty: LaserSoundRotation
    /// </summary>
    public unsafe int LaserSoundRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ArrayProperty: LaserAudibles<br/>
    /// Default: (BmScript.Default__RBMWeaponPredatorRedHoodRifle.LaserScopeAudibleLeft,BmScript.Default__RBMWeaponPredatorRedHoodRifle.LaserScopeAudibleRight,BmScript.Default__RBMWeaponPredatorRedHoodRifle.LaserScope...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RAkAudible> LaserAudibles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RAkAudible>>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }
}
