#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MHudModuleHealthBar_DLCHarleyQuinn<br/>
/// (size = 552)
/// (flags = 18)
/// </summary>
public partial class MHudModuleHealthBar_DLCHarleyQuinn : BmSDK.BmGame.RHudModuleHealthBar, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MHudModuleHealthBar_DLCHarleyQuinn.
    /// </summary>
    public static MHudModuleHealthBar_DLCHarleyQuinn DefaultObject => (MHudModuleHealthBar_DLCHarleyQuinn)StaticClass().DefaultObject;

    internal MHudModuleHealthBar_DLCHarleyQuinn() { }

    /// <summary>
    /// Constructs a new MHudModuleHealthBar_DLCHarleyQuinn
    /// </summary>
    public MHudModuleHealthBar_DLCHarleyQuinn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHudModuleHealthBar_DLCHarleyQuinn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHudModuleHealthBar_DLCHarleyQuinn(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHudModuleHealthBar_DLCHarleyQuinn>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleHealthBar_DLCHarleyQuinn>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHudModuleHealthBar_DLCHarleyQuinn>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleHealthBar_DLCHarleyQuinn>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleHealthBar_DLCHarleyQuinn>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleHealthBar_DLCHarleyQuinn>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHudModuleHealthBar_DLCHarleyQuinn>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleHealthBar_DLCHarleyQuinn>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowPostCombatBreakdown;
    /// <summary>
    /// Function: ShowPostCombatBreakdown
    /// </summary>
    public unsafe override void ShowPostCombatBreakdown(BmSDK.FStringArg breakdown_string, BmSDK.FStringArg title_string, float seconds_per_page)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowPostCombatBreakdown, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.ShowPostCombatBreakdown", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        breakdown_string.WriteTo(paramsPtr + 0);
        title_string.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(seconds_per_page, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ToggleMayhemMeter;
    /// <summary>
    /// Function: ToggleMayhemMeter
    /// </summary>
    public unsafe override void ToggleMayhemMeter(bool Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ToggleMayhemMeter, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.ToggleMayhemMeter", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopTutorialAttractAnim;
    /// <summary>
    /// Function: StopTutorialAttractAnim
    /// </summary>
    public unsafe virtual void StopTutorialAttractAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopTutorialAttractAnim, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.StopTutorialAttractAnim", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayTutorialAttractAnim;
    /// <summary>
    /// Function: PlayTutorialAttractAnim
    /// </summary>
    public unsafe virtual void PlayTutorialAttractAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayTutorialAttractAnim, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.PlayTutorialAttractAnim", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayFirstFillAttractAnim;
    /// <summary>
    /// Function: PlayFirstFillAttractAnim
    /// </summary>
    public unsafe virtual void PlayFirstFillAttractAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayFirstFillAttractAnim, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.PlayFirstFillAttractAnim", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForFirstFillAnim;
    /// <summary>
    /// Function: CheckForFirstFillAnim
    /// </summary>
    public unsafe virtual void CheckForFirstFillAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForFirstFillAnim, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.CheckForFirstFillAnim", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMayhemMeterAnims;
    /// <summary>
    /// Function: UpdateMayhemMeterAnims
    /// </summary>
    public unsafe virtual void UpdateMayhemMeterAnims(float DeltaTime, BmSDK.BmGame.RPlayerController PC, bool ThugsAlive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMayhemMeterAnims, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.UpdateMayhemMeterAnims", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugsAlive, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMayhemMeter;
    /// <summary>
    /// Function: UpdateMayhemMeter
    /// </summary>
    public unsafe virtual void UpdateMayhemMeter(float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMayhemMeter, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.UpdateMayhemMeter", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitialiseMayhemMeter;
    /// <summary>
    /// Function: InitialiseMayhemMeter
    /// </summary>
    public unsafe virtual void InitialiseMayhemMeter(float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitialiseMayhemMeter, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.InitialiseMayhemMeter", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetBounds;
    /// <summary>
    /// Function: SetBounds
    /// </summary>
    public unsafe virtual void SetBounds(float pMin, float pMax)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetBounds, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.SetBounds", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pMin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pMax, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetMayhemMeterReference;
    /// <summary>
    /// Function: SetMayhemMeterReference
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject SetMayhemMeterReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetMayhemMeterReference, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.SetMayhemMeterReference", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitialiseFlash;
    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe override void InitialiseFlash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitialiseFlash, "BmScript.MHudModuleHealthBar_DLCHarleyQuinn.InitialiseFlash", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MayhemMeter
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject MayhemMeter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// BoolProperty: bIsAnimating
    /// </summary>
    public unsafe bool bIsAnimating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bShowMayhemModeBar
    /// </summary>
    public unsafe bool bShowMayhemModeBar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bQueueTutorialAttractAnim
    /// </summary>
    public unsafe bool bQueueTutorialAttractAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bQueueFirstFillAttractAnim
    /// </summary>
    public unsafe bool bQueueFirstFillAttractAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bForceHide
    /// </summary>
    public unsafe bool bForceHide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// IntProperty: CurrentFrame
    /// </summary>
    public unsafe int CurrentFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// IntProperty: AnimTargetFrame
    /// </summary>
    public unsafe int AnimTargetFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// FloatProperty: Min
    /// </summary>
    public unsafe float Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: Max
    /// </summary>
    public unsafe float Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: originalHeight
    /// </summary>
    public unsafe float originalHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }
}
