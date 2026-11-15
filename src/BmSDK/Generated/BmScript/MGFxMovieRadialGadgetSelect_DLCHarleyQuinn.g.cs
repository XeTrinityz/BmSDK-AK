#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxMovieRadialGadgetSelect_DLCHarleyQuinn<br/>
/// (size = 1488)
/// (flags = 22)
/// </summary>
public partial class MGFxMovieRadialGadgetSelect_DLCHarleyQuinn : BmSDK.BmGame.RGFxMovieRadialGadgetSelect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxMovieRadialGadgetSelect_DLCHarleyQuinn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxMovieRadialGadgetSelect_DLCHarleyQuinn.
    /// </summary>
    public static MGFxMovieRadialGadgetSelect_DLCHarleyQuinn DefaultObject => (MGFxMovieRadialGadgetSelect_DLCHarleyQuinn)StaticClass().DefaultObject;

    internal MGFxMovieRadialGadgetSelect_DLCHarleyQuinn() { }

    /// <summary>
    /// Constructs a new MGFxMovieRadialGadgetSelect_DLCHarleyQuinn
    /// </summary>
    public MGFxMovieRadialGadgetSelect_DLCHarleyQuinn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxMovieRadialGadgetSelect_DLCHarleyQuinn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxMovieRadialGadgetSelect_DLCHarleyQuinn(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieRadialGadgetSelect_DLCHarleyQuinn>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieRadialGadgetSelect_DLCHarleyQuinn>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieRadialGadgetSelect_DLCHarleyQuinn>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieRadialGadgetSelect_DLCHarleyQuinn>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieRadialGadgetSelect_DLCHarleyQuinn>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieRadialGadgetSelect_DLCHarleyQuinn>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieRadialGadgetSelect_DLCHarleyQuinn>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieRadialGadgetSelect_DLCHarleyQuinn>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
