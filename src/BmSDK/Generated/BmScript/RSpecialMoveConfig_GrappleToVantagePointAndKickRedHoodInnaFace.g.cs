#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace<br/>
/// (size = 464)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace : BmSDK.BmGame.RSpecialMoveConfig_VantageGrapple, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace.
    /// </summary>
    public static RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace DefaultObject => (RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace)StaticClass().DefaultObject;

    internal RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace
    /// </summary>
    public RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_GrappleToVantagePointAndKickRedHoodInnaFace>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: KickingRedHoodAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet KickingRedHoodAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }
}
