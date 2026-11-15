#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHudModuleBespokeTunnelRadar<br/>
/// (size = 292)
/// (flags = 18)
/// </summary>
public partial class RHudModuleBespokeTunnelRadar : BmSDK.BmGame.RHudModuleBespokeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHudModuleBespokeTunnelRadar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleBespokeTunnelRadar.
    /// </summary>
    public static RHudModuleBespokeTunnelRadar DefaultObject => (RHudModuleBespokeTunnelRadar)StaticClass().DefaultObject;

    internal RHudModuleBespokeTunnelRadar() { }

    /// <summary>
    /// Constructs a new RHudModuleBespokeTunnelRadar
    /// </summary>
    public RHudModuleBespokeTunnelRadar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleBespokeTunnelRadar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleBespokeTunnelRadar(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeTunnelRadar>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeTunnelRadar>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeTunnelRadar>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeTunnelRadar>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeTunnelRadar>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeTunnelRadar>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeTunnelRadar>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBespokeTunnelRadar>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetDamage;
    /// <summary>
    /// Function: SetDamage
    /// </summary>
    public unsafe virtual void SetDamage(int damage_level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetDamage, "BmScript.RHudModuleBespokeTunnelRadar.SetDamage", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(damage_level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe virtual void TakeDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeDamage, "BmScript.RHudModuleBespokeTunnelRadar.TakeDamage", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetDistanceToExcavator;
    /// <summary>
    /// Function: SetDistanceToExcavator
    /// </summary>
    public unsafe virtual void SetDistanceToExcavator(float num_metres, bool flashing_red, bool fast_flash)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetDistanceToExcavator, "BmScript.RHudModuleBespokeTunnelRadar.SetDistanceToExcavator", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_metres, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(flashing_red, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fast_flash, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DestroyBlockage;
    /// <summary>
    /// Function: DestroyBlockage
    /// </summary>
    public unsafe virtual void DestroyBlockage(float BlockageX, float BlockageY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DestroyBlockage, "BmScript.RHudModuleBespokeTunnelRadar.DestroyBlockage", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlockageX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlockageY, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InstantlyEliminateTunnel;
    /// <summary>
    /// Function: InstantlyEliminateTunnel
    /// </summary>
    public unsafe virtual void InstantlyEliminateTunnel(int TunnelIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InstantlyEliminateTunnel, "BmScript.RHudModuleBespokeTunnelRadar.InstantlyEliminateTunnel", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TunnelIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EliminateTunnel;
    /// <summary>
    /// Function: EliminateTunnel
    /// </summary>
    public unsafe override void EliminateTunnel(int TunnelIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EliminateTunnel, "BmScript.RHudModuleBespokeTunnelRadar.EliminateTunnel", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TunnelIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetCharacterPositions;
    /// <summary>
    /// Function: SetCharacterPositions
    /// </summary>
    public unsafe virtual void SetCharacterPositions(float BatmobileX, float BatmobileY, float BatmobileRot, float ExcavatorX, float ExcavatorY, float ExcavatorRot, bool ExcavatorIsVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetCharacterPositions, "BmScript.RHudModuleBespokeTunnelRadar.SetCharacterPositions", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmobileX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmobileY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmobileRot, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcavatorX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcavatorY, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcavatorRot, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcavatorIsVisible, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoOutro;
    /// <summary>
    /// Function: DoOutro
    /// </summary>
    public unsafe override void DoOutro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoOutro, "BmScript.RHudModuleBespokeTunnelRadar.DoOutro", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitialiseFlash;
    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe override void InitialiseFlash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitialiseFlash, "BmScript.RHudModuleBespokeTunnelRadar.InitialiseFlash", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetAlreadyDestroyedTunnels;
    /// <summary>
    /// Function: SetAlreadyDestroyedTunnels
    /// </summary>
    public unsafe virtual void SetAlreadyDestroyedTunnels(bool _NorthDestroyed, bool _EastDestroyed, bool _SouthDestroyed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetAlreadyDestroyedTunnels, "BmScript.RHudModuleBespokeTunnelRadar.SetAlreadyDestroyedTunnels", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_NorthDestroyed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_EastDestroyed, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_SouthDestroyed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FStringArg _ExtensionName, BmSDK.FStringArg _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmScript.RHudModuleBespokeTunnelRadar.Init", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        _ExtensionName.WriteTo(paramsPtr + 8);
        _ExtensionPath.WriteTo(paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCharacterPositions
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCharacterPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSeismicLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSeismicLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: NorthDestroyed
    /// </summary>
    public unsafe bool NorthDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: EastDestroyed
    /// </summary>
    public unsafe bool EastDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: SouthDestroyed
    /// </summary>
    public unsafe bool SouthDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ExcavatorDistanceFlashingRed
    /// </summary>
    public unsafe bool ExcavatorDistanceFlashingRed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ExcavatorDistanceFlashingRedFast
    /// </summary>
    public unsafe bool ExcavatorDistanceFlashingRedFast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: CurrentDamage
    /// </summary>
    public unsafe int CurrentDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: DistanceToExcavator
    /// </summary>
    public unsafe float DistanceToExcavator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
}
