#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCommandBeaconLights<br/>
/// (size = 964)
/// (flags = 10485778)
/// </summary>
public partial class RCommandBeaconLights : BmSDK.BmGame.RCommandBeaconLightsBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCommandBeaconLights", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCommandBeaconLights.
    /// </summary>
    public static RCommandBeaconLights DefaultObject => (RCommandBeaconLights)StaticClass().DefaultObject;

    internal RCommandBeaconLights() { }

    /// <summary>
    /// Constructs a new RCommandBeaconLights
    /// </summary>
    public RCommandBeaconLights(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCommandBeaconLights(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconLights>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconLights>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconLights>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconLights>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconLights>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconLights>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconLights>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconLights>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetComponentState;
    /// <summary>
    /// Function: SetComponentState
    /// </summary>
    public unsafe override void SetComponentState(BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetComponentState, "BmScript.RCommandBeaconLights.SetComponentState", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.BmGame.RCommandBeaconBase inBeacon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmScript.RCommandBeaconLights.Init", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inBeacon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.RCommandBeaconLights.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: PointLight_Dormant
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent PointLight_Dormant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: PointLight_VirusInProgress
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent PointLight_VirusInProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ComponentProperty: PointLight_VirusSuccessfulCoreExposed
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent PointLight_VirusSuccessfulCoreExposed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: PointLight_Broken
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent PointLight_Broken
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StructProperty: Materials_Dormant
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet Materials_Dormant
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet>(Ptr + 772);

    /// <summary>
    /// StructProperty: Materials_VirusInProgress
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet Materials_VirusInProgress
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet>(Ptr + 804);

    /// <summary>
    /// StructProperty: Materials_VirusSuccessfulCoreExposed
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet Materials_VirusSuccessfulCoreExposed
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet>(Ptr + 836);

    /// <summary>
    /// StructProperty: Materials_Broken
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet Materials_Broken
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet>(Ptr + 868);

    /// <summary>
    /// StructProperty: defaultMaterialSet
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet defaultMaterialSet
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCommandBeaconLightsBase.FCommandBeaconMaterialSet>(Ptr + 900);

    /// <summary>
    /// ObjectProperty: yellowLightSoundLoop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent yellowLightSoundLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: slowRedLightSoundLoop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent slowRedLightSoundLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: fastRedLightSoundLoop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent fastRedLightSoundLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: HUDSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HUDSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
}
