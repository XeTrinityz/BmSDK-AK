#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MStealthTakeDownStage_GrabFromCrouchSuccessBG<br/>
/// (size = 1880)
/// (flags = 10485778)
/// </summary>
public partial class MStealthTakeDownStage_GrabFromCrouchSuccessBG : BmSDK.BmGame.RStealthTakeDownStage_GrabFromCrouchSuccess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MStealthTakeDownStage_GrabFromCrouchSuccessBG", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MStealthTakeDownStage_GrabFromCrouchSuccessBG.
    /// </summary>
    public static MStealthTakeDownStage_GrabFromCrouchSuccessBG DefaultObject => (MStealthTakeDownStage_GrabFromCrouchSuccessBG)StaticClass().DefaultObject;

    internal MStealthTakeDownStage_GrabFromCrouchSuccessBG() { }

    /// <summary>
    /// Constructs a new MStealthTakeDownStage_GrabFromCrouchSuccessBG
    /// </summary>
    public MStealthTakeDownStage_GrabFromCrouchSuccessBG(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MStealthTakeDownStage_GrabFromCrouchSuccessBG(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStage_GrabFromCrouchSuccessBG>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStage_GrabFromCrouchSuccessBG>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStage_GrabFromCrouchSuccessBG>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStage_GrabFromCrouchSuccessBG>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStage_GrabFromCrouchSuccessBG>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStage_GrabFromCrouchSuccessBG>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStage_GrabFromCrouchSuccessBG>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStage_GrabFromCrouchSuccessBG>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
