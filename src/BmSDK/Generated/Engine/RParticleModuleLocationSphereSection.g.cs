#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleModuleLocationSphereSection<br/>
/// (size = 352)
/// (flags = 142618770)
/// </summary>
public partial class RParticleModuleLocationSphereSection : BmSDK.Engine.ParticleModuleLocationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RParticleModuleLocationSphereSection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RParticleModuleLocationSphereSection.
    /// </summary>
    public static RParticleModuleLocationSphereSection DefaultObject => (RParticleModuleLocationSphereSection)StaticClass().DefaultObject;

    internal RParticleModuleLocationSphereSection() { }

    /// <summary>
    /// Constructs a new RParticleModuleLocationSphereSection
    /// </summary>
    public RParticleModuleLocationSphereSection(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleLocationSphereSection Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleLocationSphereSection(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RParticleModuleLocationSphereSection>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleLocationSphereSection>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RParticleModuleLocationSphereSection>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleLocationSphereSection>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleLocationSphereSection>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleLocationSphereSection>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RParticleModuleLocationSphereSection>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleLocationSphereSection>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: RadiusMin<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(75,75,75,75),Distribution=Engine.Default__RParticleModuleLocationSphereSection.DistributionRadiusMin)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat RadiusMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 96);

    /// <summary>
    /// StructProperty: RadiusMax<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(100,100,100,100),Distribution=Engine.Default__RParticleModuleLocationSphereSection.DistributionRadiusMax)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat RadiusMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 132);

    /// <summary>
    /// StructProperty: ThetaMin<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(0,0,0,0),Distribution=Engine.Default__RParticleModuleLocationSphereSection.DistributionThetaMin)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat ThetaMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 168);

    /// <summary>
    /// StructProperty: ThetaMax<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(90,90,90,90),Distribution=Engine.Default__RParticleModuleLocationSphereSection.DistributionThetaMax)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat ThetaMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 204);

    /// <summary>
    /// StructProperty: PhiMin<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(0,0,0,0),Distribution=Engine.Default__RParticleModuleLocationSphereSection.DistributionPhiMin)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat PhiMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 240);

    /// <summary>
    /// StructProperty: PhiMax<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(90,90,90,90),Distribution=Engine.Default__RParticleModuleLocationSphereSection.DistributionPhiMax)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat PhiMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 276);

    /// <summary>
    /// BoolProperty: Velocity
    /// </summary>
    public unsafe bool Velocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: VelocityScale<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(1,1,1,1),Distribution=Engine.Default__RParticleModuleLocationSphereSection.DistributionVelocityScale)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat VelocityScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 316);
}
