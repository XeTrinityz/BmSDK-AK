#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MSpecialMoveConfig_BatgirlOmnitronPasswordCracking<br/>
/// (size = 460)
/// (flags = 4114)
/// </summary>
public partial class MSpecialMoveConfig_BatgirlOmnitronPasswordCracking : BmSDK.BmGame.RSpecialMoveConfig_OmnitronPasswordCracking, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MSpecialMoveConfig_BatgirlOmnitronPasswordCracking", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MSpecialMoveConfig_BatgirlOmnitronPasswordCracking.
    /// </summary>
    public static MSpecialMoveConfig_BatgirlOmnitronPasswordCracking DefaultObject => (MSpecialMoveConfig_BatgirlOmnitronPasswordCracking)StaticClass().DefaultObject;

    internal MSpecialMoveConfig_BatgirlOmnitronPasswordCracking() { }

    /// <summary>
    /// Constructs a new MSpecialMoveConfig_BatgirlOmnitronPasswordCracking
    /// </summary>
    public MSpecialMoveConfig_BatgirlOmnitronPasswordCracking(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSpecialMoveConfig_BatgirlOmnitronPasswordCracking Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSpecialMoveConfig_BatgirlOmnitronPasswordCracking(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveConfig_BatgirlOmnitronPasswordCracking>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveConfig_BatgirlOmnitronPasswordCracking>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveConfig_BatgirlOmnitronPasswordCracking>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveConfig_BatgirlOmnitronPasswordCracking>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveConfig_BatgirlOmnitronPasswordCracking>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveConfig_BatgirlOmnitronPasswordCracking>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveConfig_BatgirlOmnitronPasswordCracking>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveConfig_BatgirlOmnitronPasswordCracking>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
