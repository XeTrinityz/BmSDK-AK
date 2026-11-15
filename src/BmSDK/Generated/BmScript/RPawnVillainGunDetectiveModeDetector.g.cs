#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainGunDetectiveModeDetector<br/>
/// (size = 6928)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainGunDetectiveModeDetector : BmSDK.BmScript.RPawnVillainGunPredFull, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainGunDetectiveModeDetector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainGunDetectiveModeDetector.
    /// </summary>
    public static RPawnVillainGunDetectiveModeDetector DefaultObject => (RPawnVillainGunDetectiveModeDetector)StaticClass().DefaultObject;

    internal RPawnVillainGunDetectiveModeDetector() { }

    /// <summary>
    /// Constructs a new RPawnVillainGunDetectiveModeDetector
    /// </summary>
    public RPawnVillainGunDetectiveModeDetector(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunDetectiveModeDetector(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunDetectiveModeDetector>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunDetectiveModeDetector>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunDetectiveModeDetector>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunDetectiveModeDetector>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunDetectiveModeDetector>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunDetectiveModeDetector>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunDetectiveModeDetector>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunDetectiveModeDetector>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyAttackTriggerResult;
    /// <summary>
    /// Function: NotifyAttackTriggerResult
    /// </summary>
    public unsafe override void NotifyAttackTriggerResult(bool bSuccess)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyAttackTriggerResult, "BmScript.RPawnVillainGunDetectiveModeDetector.NotifyAttackTriggerResult", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetEquipmentPropSkeletalsIndex;
    /// <summary>
    /// Function: GetEquipmentPropSkeletalsIndex
    /// </summary>
    public unsafe override int GetEquipmentPropSkeletalsIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetEquipmentPropSkeletalsIndex, "BmScript.RPawnVillainGunDetectiveModeDetector.GetEquipmentPropSkeletalsIndex", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WakeFromDead;
    /// <summary>
    /// Function: WakeFromDead
    /// </summary>
    public unsafe override void WakeFromDead(BmSDK.BmGame.RPawnCharacter NewGetUpMaster = default, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewGetUpMasterAnimID = default, BmSDK.Engine.AnimSet NewGetUpAnimset = default, BmSDK.FName NewGetUpAnimName = default, BmSDK.FName GetUpMovementStance = default, bool bDoAnim = default, bool bAnimImmediate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WakeFromDead, "BmScript.RPawnVillainGunDetectiveModeDetector.WakeFromDead", this);
        byte* paramsPtr = stackalloc byte[60];
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Died, "BmScript.RPawnVillainGunDetectiveModeDetector.Died", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryTriggerStartle;
    /// <summary>
    /// Function: TryTriggerStartle
    /// </summary>
    public unsafe virtual bool TryTriggerStartle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryTriggerStartle, "BmScript.RPawnVillainGunDetectiveModeDetector.TryTriggerStartle", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDisruptedEquipmentLocationAndRotation;
    /// <summary>
    /// Function: GetDisruptedEquipmentLocationAndRotation
    /// </summary>
    public unsafe override void GetDisruptedEquipmentLocationAndRotation(out System.Numerics.Vector3 vLocation, out BmSDK.Rotator rRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDisruptedEquipmentLocationAndRotation, "BmScript.RPawnVillainGunDetectiveModeDetector.GetDisruptedEquipmentLocationAndRotation", this);
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
    public unsafe override void DisruptorDisableEquipment()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisruptorDisableEquipment, "BmScript.RPawnVillainGunDetectiveModeDetector.DisruptorDisableEquipment", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnJammedExplosion;
    /// <summary>
    /// Function: SpawnJammedExplosion
    /// </summary>
    public unsafe virtual void SpawnJammedExplosion()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnJammedExplosion, "BmScript.RPawnVillainGunDetectiveModeDetector.SpawnJammedExplosion", this);
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisruptedDMDExplode;
    /// <summary>
    /// Function: DisruptedDMDExplode
    /// </summary>
    public unsafe override void DisruptedDMDExplode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisruptedDMDExplode, "BmScript.RPawnVillainGunDetectiveModeDetector.DisruptedDMDExplode", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AttachDMDToBody;
    /// <summary>
    /// Function: AttachDMDToBody
    /// </summary>
    public unsafe override void AttachDMDToBody()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AttachDMDToBody, "BmScript.RPawnVillainGunDetectiveModeDetector.AttachDMDToBody", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AttachDMDToHand;
    /// <summary>
    /// Function: AttachDMDToHand
    /// </summary>
    public unsafe override void AttachDMDToHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AttachDMDToHand, "BmScript.RPawnVillainGunDetectiveModeDetector.AttachDMDToHand", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDMDCharSkelPropIndex;
    /// <summary>
    /// Function: GetDMDCharSkelPropIndex
    /// </summary>
    public unsafe virtual int GetDMDCharSkelPropIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDMDCharSkelPropIndex, "BmScript.RPawnVillainGunDetectiveModeDetector.GetDMDCharSkelPropIndex", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDMDMeshComp;
    /// <summary>
    /// Function: GetDMDMeshComp
    /// </summary>
    public unsafe virtual void GetDMDMeshComp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDMDMeshComp, "BmScript.RPawnVillainGunDetectiveModeDetector.GetDMDMeshComp", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AttachProps;
    /// <summary>
    /// Function: AttachProps
    /// </summary>
    public unsafe override void AttachProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AttachProps, "BmScript.RPawnVillainGunDetectiveModeDetector.AttachProps", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateFXParams;
    /// <summary>
    /// Function: UpdateFXParams
    /// </summary>
    public unsafe virtual void UpdateFXParams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateFXParams, "BmScript.RPawnVillainGunDetectiveModeDetector.UpdateFXParams", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DMDOutTransitionStarted;
    /// <summary>
    /// Function: DMDOutTransitionStarted
    /// </summary>
    public unsafe override void DMDOutTransitionStarted(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId AnimId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DMDOutTransitionStarted, "BmScript.RPawnVillainGunDetectiveModeDetector.DMDOutTransitionStarted", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimId, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.RPawnVillainGunDetectiveModeDetector.Tick", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddPawnProps;
    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe override void AddPawnProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddPawnProps, "BmScript.RPawnVillainGunDetectiveModeDetector.AddPawnProps", this);
        byte* paramsPtr = stackalloc byte[200];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasDetectiveModeDetector;
    /// <summary>
    /// Function: HasDetectiveModeDetector
    /// </summary>
    public unsafe override bool HasDetectiveModeDetector()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasDetectiveModeDetector, "BmScript.RPawnVillainGunDetectiveModeDetector.HasDetectiveModeDetector", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: DMDMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh DMDMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// ObjectProperty: DMDPhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset DMDPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 6816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6816); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplosionVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JammedExplosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplodeEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent JammedExplodeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// ObjectProperty: DisruptedDMDXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DisruptedDMDXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// ObjectProperty: NormalDMDXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant NormalDMDXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// ComponentProperty: FXComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FXComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// ComponentProperty: DMDMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent DMDMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }

    /// <summary>
    /// StructProperty: DMDPropScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DMDPropScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6872);

    /// <summary>
    /// StructProperty: DMDAttachToBodyOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DMDAttachToBodyOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6884);

    /// <summary>
    /// StructProperty: DMDAttachToBodyRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator DMDAttachToBodyRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 6896);

    /// <summary>
    /// BoolProperty: bDMDHasExploded
    /// </summary>
    public unsafe bool bDMDHasExploded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6908) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6908); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6908); }
    }

    /// <summary>
    /// BoolProperty: bHasDetectorEquipped
    /// </summary>
    public unsafe bool bHasDetectorEquipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6908) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6908); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6908); }
    }

    /// <summary>
    /// NameProperty: nHandBoneToAttachDetectorTo
    /// </summary>
    public unsafe BmSDK.FName nHandBoneToAttachDetectorTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6912); }
    }

    /// <summary>
    /// NameProperty: nBeltBoneToAttachDetectorTo
    /// </summary>
    public unsafe BmSDK.FName nBeltBoneToAttachDetectorTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6920); }
    }
}
