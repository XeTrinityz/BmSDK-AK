#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor<br/>
/// (size = 1084)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor : BmSDK.BmScript.RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodInnaFace, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor.
    /// </summary>
    public static RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor DefaultObject => (RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor
    /// </summary>
    public RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayGrabCameraAnim;
    /// <summary>
    /// Function: PlayGrabCameraAnim
    /// </summary>
    public unsafe virtual bool PlayGrabCameraAnim(System.Numerics.Vector3 CamRootLocation, BmSDK.Rotator CamRootRotation, BmSDK.FName Anim, BmSDK.Engine.AnimSet TheAnimSet, float BlendInTime, float StartTime, BmSDK.Engine.SkeletalMeshComponent NewSlavedToSkelComponent = default, BmSDK.Engine.AnimSequence NewSlavedToAnim = default, float CamFOV = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayGrabCameraAnim, "BmScript.RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor.PlayGrabCameraAnim", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamRootLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamRootRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheAnimSet, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSlavedToSkelComponent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSlavedToAnim, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamFOV, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayedDrop;
    /// <summary>
    /// Function: PlayedDrop
    /// </summary>
    public unsafe virtual void PlayedDrop(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewId, float TimeLeftOver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayedDrop, "BmScript.RSpecialMoveInstance_SwingToVantagePointAndKickRedHoodToFloor.PlayedDrop", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// NameProperty: FallAnimName
    /// </summary>
    public unsafe BmSDK.FName FallAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ObjectProperty: LandPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatPoint LandPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: ClosestAnim
    /// </summary>
    public unsafe int ClosestAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
}
