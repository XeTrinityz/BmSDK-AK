#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleUberLTISIVCL<br/>
/// (size = 412)
/// (flags = 142618770)
/// </summary>
public partial class ParticleModuleUberLTISIVCL : BmSDK.Engine.ParticleModuleUberBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleUberLTISIVCL", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ParticleModuleUberLTISIVCL.
    /// </summary>
    public static ParticleModuleUberLTISIVCL DefaultObject => (ParticleModuleUberLTISIVCL)StaticClass().DefaultObject;

    internal ParticleModuleUberLTISIVCL() { }

    /// <summary>
    /// Constructs a new ParticleModuleUberLTISIVCL
    /// </summary>
    public ParticleModuleUberLTISIVCL(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleUberLTISIVCL Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleUberLTISIVCL(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCL>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCL>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCL>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCL>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCL>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCL>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCL>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleUberLTISIVCL>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: Lifetime<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(1,1,1,1),Distribution=Engine.Default__ParticleModuleUberLTISIVCL.DistributionLifetime)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat Lifetime
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 112);

    /// <summary>
    /// StructProperty: StartSize<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(1,1,1,1,1,1,1,1),Distribution=Engine.Default__ParticleModuleUberLTISIVCL.DistributionStartSize,MinRange=(X=1,Y=1,Z=1),MaxRange=(X=1,Y...
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector StartSize
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 148);

    /// <summary>
    /// StructProperty: StartVelocity<br/>
    /// Default: (Op=2,LookupTableNumElements=2,LookupTableChunkSize=6,LookupTable=(0,10,0,0,0,0,0,10,0,0,0,0,0,10),Distribution=Engine.Default__ParticleModuleUberLTISIVCL.DistributionStartVelocity,MaxRange=(Z=10),Ran...
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector StartVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 212);

    /// <summary>
    /// StructProperty: StartVelocityRadial<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(0,0,0,0),Distribution=Engine.Default__ParticleModuleUberLTISIVCL.DistributionStartVelocityRadial)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat StartVelocityRadial
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 276);

    /// <summary>
    /// StructProperty: ColorOverLife<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(0,0,0,0,0,0,0,0),Distribution=Engine.Default__ParticleModuleUberLTISIVCL.DistributionColorOverLife,RangesCached=true)
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector ColorOverLife
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 312);

    /// <summary>
    /// StructProperty: AlphaOverLife<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=1,LookupTable=(255.9,255.9,255.9,255.9),Distribution=Engine.Default__ParticleModuleUberLTISIVCL.DistributionAlphaOverLife)
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat AlphaOverLife
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 376);
}
