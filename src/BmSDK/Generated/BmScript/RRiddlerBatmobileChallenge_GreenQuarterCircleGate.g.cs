#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRiddlerBatmobileChallenge_GreenQuarterCircleGate<br/>
/// (size = 720)
/// (flags = 10486290)
/// </summary>
public partial class RRiddlerBatmobileChallenge_GreenQuarterCircleGate : BmSDK.BmScript.RRiddlerBatmobileChallenge_GreenHalfCircleGate, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRiddlerBatmobileChallenge_GreenQuarterCircleGate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRiddlerBatmobileChallenge_GreenQuarterCircleGate.
    /// </summary>
    public static RRiddlerBatmobileChallenge_GreenQuarterCircleGate DefaultObject => (RRiddlerBatmobileChallenge_GreenQuarterCircleGate)StaticClass().DefaultObject;

    internal RRiddlerBatmobileChallenge_GreenQuarterCircleGate() { }

    /// <summary>
    /// Constructs a new RRiddlerBatmobileChallenge_GreenQuarterCircleGate
    /// </summary>
    public RRiddlerBatmobileChallenge_GreenQuarterCircleGate(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRiddlerBatmobileChallenge_GreenQuarterCircleGate(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRiddlerBatmobileChallenge_GreenQuarterCircleGate>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiddlerBatmobileChallenge_GreenQuarterCircleGate>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRiddlerBatmobileChallenge_GreenQuarterCircleGate>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiddlerBatmobileChallenge_GreenQuarterCircleGate>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiddlerBatmobileChallenge_GreenQuarterCircleGate>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiddlerBatmobileChallenge_GreenQuarterCircleGate>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRiddlerBatmobileChallenge_GreenQuarterCircleGate>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRiddlerBatmobileChallenge_GreenQuarterCircleGate>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
