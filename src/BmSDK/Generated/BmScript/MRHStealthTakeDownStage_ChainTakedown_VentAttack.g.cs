#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MRHStealthTakeDownStage_ChainTakedown_VentAttack<br/>
/// (size = 1868)
/// (flags = 10485778)
/// </summary>
public partial class MRHStealthTakeDownStage_ChainTakedown_VentAttack : BmSDK.BmGame.RStealthTakedownStage_ChainTakedown_VentAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MRHStealthTakeDownStage_ChainTakedown_VentAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MRHStealthTakeDownStage_ChainTakedown_VentAttack.
    /// </summary>
    public static MRHStealthTakeDownStage_ChainTakedown_VentAttack DefaultObject => (MRHStealthTakeDownStage_ChainTakedown_VentAttack)StaticClass().DefaultObject;

    internal MRHStealthTakeDownStage_ChainTakedown_VentAttack() { }

    /// <summary>
    /// Constructs a new MRHStealthTakeDownStage_ChainTakedown_VentAttack
    /// </summary>
    public MRHStealthTakeDownStage_ChainTakedown_VentAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MRHStealthTakeDownStage_ChainTakedown_VentAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MRHStealthTakeDownStage_ChainTakedown_VentAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MRHStealthTakeDownStage_ChainTakedown_VentAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MRHStealthTakeDownStage_ChainTakedown_VentAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MRHStealthTakeDownStage_ChainTakedown_VentAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MRHStealthTakeDownStage_ChainTakedown_VentAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MRHStealthTakeDownStage_ChainTakedown_VentAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MRHStealthTakeDownStage_ChainTakedown_VentAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MRHStealthTakeDownStage_ChainTakedown_VentAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
