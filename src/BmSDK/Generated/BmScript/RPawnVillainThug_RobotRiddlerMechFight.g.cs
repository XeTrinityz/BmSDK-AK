#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainThug_RobotRiddlerMechFight<br/>
/// (size = 6784)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainThug_RobotRiddlerMechFight : BmSDK.BmScript.RPawnVillainThug_Robot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainThug_RobotRiddlerMechFight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainThug_RobotRiddlerMechFight.
    /// </summary>
    public static RPawnVillainThug_RobotRiddlerMechFight DefaultObject => (RPawnVillainThug_RobotRiddlerMechFight)StaticClass().DefaultObject;

    internal RPawnVillainThug_RobotRiddlerMechFight() { }

    /// <summary>
    /// Constructs a new RPawnVillainThug_RobotRiddlerMechFight
    /// </summary>
    public RPawnVillainThug_RobotRiddlerMechFight(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainThug_RobotRiddlerMechFight(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_RobotRiddlerMechFight>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_RobotRiddlerMechFight>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_RobotRiddlerMechFight>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_RobotRiddlerMechFight>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_RobotRiddlerMechFight>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_RobotRiddlerMechFight>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_RobotRiddlerMechFight>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_RobotRiddlerMechFight>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WakeFromDead;
    /// <summary>
    /// Function: WakeFromDead
    /// </summary>
    public unsafe override void WakeFromDead(BmSDK.BmGame.RPawnCharacter NewGetUpMaster = default, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewGetUpMasterAnimID = default, BmSDK.Engine.AnimSet NewGetUpAnimset = default, BmSDK.FName NewGetUpAnimName = default, BmSDK.FName GetUpMovementStance = default, bool bDoAnim = default, bool bAnimImmediate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WakeFromDead, "BmScript.RPawnVillainThug_RobotRiddlerMechFight.WakeFromDead", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpMaster, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpMasterAnimID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGetUpAnimName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUpMovementStance, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoAnim, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAnimImmediate, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RevivedByMech;
    /// <summary>
    /// Function: RevivedByMech
    /// </summary>
    public unsafe virtual void RevivedByMech()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RevivedByMech, "BmScript.RPawnVillainThug_RobotRiddlerMechFight.RevivedByMech", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BeingRevivedBy;
    /// <summary>
    /// Function: BeingRevivedBy
    /// </summary>
    public unsafe override void BeingRevivedBy(BmSDK.BmGame.RPawnVillain NewMedic)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeingRevivedBy, "BmScript.RPawnVillainThug_RobotRiddlerMechFight.BeingRevivedBy", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMedic, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PreRevive;
    /// <summary>
    /// Function: PreRevive
    /// </summary>
    public unsafe virtual void PreRevive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PreRevive, "BmScript.RPawnVillainThug_RobotRiddlerMechFight.PreRevive", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Died, "BmScript.RPawnVillainThug_RobotRiddlerMechFight.Died", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ProcessDamagedBy;
    /// <summary>
    /// Function: ProcessDamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult ProcessDamagedBy(out BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ProcessDamagedBy, "BmScript.RPawnVillainThug_RobotRiddlerMechFight.ProcessDamagedBy", this);
        byte* paramsPtr = stackalloc byte[309];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 248);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsMechFightRobot;
    /// <summary>
    /// Function: IsMechFightRobot
    /// </summary>
    public unsafe override bool IsMechFightRobot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsMechFightRobot, "BmScript.RPawnVillainThug_RobotRiddlerMechFight.IsMechFightRobot", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: ReviveVFxEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter ReviveVFxEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 6768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6768); }
    }

    /// <summary>
    /// ObjectProperty: Mech
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainRiddlerMechSuitBase Mech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainRiddlerMechSuitBase>(Ptr + 6776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6776); }
    }
}
