#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationDirect<br/>
/// (size = 352)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleLocationDirect : BmSDK.Engine.ParticleModuleLocationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationDirect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ParticleModuleLocationDirect.
    /// </summary>
    public static ParticleModuleLocationDirect DefaultObject => (ParticleModuleLocationDirect)StaticClass().DefaultObject;

    internal ParticleModuleLocationDirect() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationDirect
    /// </summary>
    public ParticleModuleLocationDirect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationDirect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationDirect(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationDirect>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationDirect>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationDirect>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationDirect>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationDirect>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationDirect>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationDirect>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationDirect>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: Location<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(0,0,0,0,0,0,0,0),Distribution=Engine.Default__ParticleModuleLocationDirect.DistributionLocation,RangesCached=true)
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector Location
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 96);

    /// <summary>
    /// StructProperty: LocationOffset<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(0,0,0,0,0,0,0,0),Distribution=Engine.Default__ParticleModuleLocationDirect.DistributionLocationOffset,RangesCached=true)
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector LocationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 160);

    /// <summary>
    /// StructProperty: ScaleFactor<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(1,1,1,1,1,1,1,1),Distribution=Engine.Default__ParticleModuleLocationDirect.DistributionScaleFactor,MinRange=(X=1,Y=1,Z=1),MaxRange=(X...
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector ScaleFactor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 224);

    /// <summary>
    /// StructProperty: Direction<br/>
    /// Default: (Op=1,LookupTableNumElements=1,LookupTableChunkSize=3,LookupTable=(0,0,0,0,0,0,0,0),Distribution=Engine.Default__ParticleModuleLocationDirect.DistributionDirection,RangesCached=true)
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector Direction
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 288);
}
