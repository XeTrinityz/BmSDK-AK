#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleUberLTISIVCLILIRSSBLIRR<br/>
/// (size = 616)
/// (flags = 142618770)
/// </summary>
public partial class ParticleModuleUberLTISIVCLILIRSSBLIRR : BmSDK.Engine.ParticleModuleUberBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ParticleModuleUberLTISIVCLILIRSSBLIRR.
    /// </summary>
    public static ParticleModuleUberLTISIVCLILIRSSBLIRR DefaultObject => (ParticleModuleUberLTISIVCLILIRSSBLIRR)StaticClass().DefaultObject;

    internal ParticleModuleUberLTISIVCLILIRSSBLIRR() { }

    /// <summary>
    /// Constructs a new ParticleModuleUberLTISIVCLILIRSSBLIRR
    /// </summary>
    public ParticleModuleUberLTISIVCLILIRSSBLIRR(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleUberLTISIVCLILIRSSBLIRR Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleUberLTISIVCLILIRSSBLIRR(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCLILIRSSBLIRR>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCLILIRSSBLIRR>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCLILIRSSBLIRR>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCLILIRSSBLIRR>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCLILIRSSBLIRR>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCLILIRSSBLIRR>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCLILIRSSBLIRR>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCLILIRSSBLIRR>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: Lifetime<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(1,1,1,1),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionLifetime)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat Lifetime
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 112);

    /// <summary>
    /// StructProperty: StartSize<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(1,1,1,1,1,1,1,1),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionStartSize,MinRange=(X=1,Y=1,Z=1),MaxR...
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector StartSize
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 148);

    /// <summary>
    /// StructProperty: StartVelocity<br/>
    /// Default: (Op=2,LookupTableNumElements=2,LookupTableChunkSize=6,LookupTable=(0,10,0,0,0,0,0,10,0,0,0,0,0,10),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionStartVelocity,MaxRange...
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector StartVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 212);

    /// <summary>
    /// StructProperty: StartVelocityRadial<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(0,0,0,0),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionStartVelocityRadial)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat StartVelocityRadial
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 276);

    /// <summary>
    /// StructProperty: ColorOverLife<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(0,0,0,0,0,0,0,0),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionColorOverLife,RangesCached=true)
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector ColorOverLife
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 312);

    /// <summary>
    /// StructProperty: AlphaOverLife<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(255.9,255.9,255.9,255.9),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionAlphaOverLife)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat AlphaOverLife
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 376);

    /// <summary>
    /// StructProperty: StartLocation<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(0,0,0,0,0,0,0,0),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionStartLocation,RangesCached=true)
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector StartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 412);

    /// <summary>
    /// StructProperty: StartRotation<br/>
    /// Default: (Op=2,LookupTableNumElements=2,LookupTableChunkSize=2,LookupTable=(0,1,0,1,0,1),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionStartRotation)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat StartRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 476);

    /// <summary>
    /// StructProperty: SizeLifeMultiplier<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(1,1,1,1,1,1,1,1),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionLifeMultiplier,MinRange=(X=1,Y=1,Z=1)...
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector SizeLifeMultiplier
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 512);

    /// <summary>
    /// BoolProperty: SizeMultiplyX<br/>
    /// Default: true
    /// </summary>
    public unsafe bool SizeMultiplyX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: SizeMultiplyY<br/>
    /// Default: true
    /// </summary>
    public unsafe bool SizeMultiplyY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: SizeMultiplyZ<br/>
    /// Default: true
    /// </summary>
    public unsafe bool SizeMultiplyZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// StructProperty: StartRotationRate<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(0,0,0,0),Distribution=Engine.Default__ParticleModuleUberLTISIVCLILIRSSBLIRR.DistributionStartRotationRate)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat StartRotationRate
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 580);
}
