#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GFxMovieBenchmarking<br/>
/// (size = 700)
/// (flags = 22)
/// </summary>
public partial class GFxMovieBenchmarking : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GFxMovieBenchmarking", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GFxMovieBenchmarking.
    /// </summary>
    public static GFxMovieBenchmarking DefaultObject => (GFxMovieBenchmarking)StaticClass().DefaultObject;

    internal GFxMovieBenchmarking() { }

    /// <summary>
    /// Constructs a new GFxMovieBenchmarking
    /// </summary>
    public GFxMovieBenchmarking(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxMovieBenchmarking Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxMovieBenchmarking(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_IsEscapeTextShowing;
    /// <summary>
    /// Function: XI_IsEscapeTextShowing
    /// </summary>
    public unsafe virtual void XI_IsEscapeTextShowing(bool IsEscapeTextShowing)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_IsEscapeTextShowing, "BmScript.GFxMovieBenchmarking.XI_IsEscapeTextShowing", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsEscapeTextShowing, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendStatusToFlashWithVsyncWarning;
    /// <summary>
    /// Function: SendStatusToFlashWithVsyncWarning
    /// </summary>
    public unsafe virtual void SendStatusToFlashWithVsyncWarning(bool BenchmarkingActive, int BenchmarkMin, BmSDK.FStringArg BenchmarkMax, int BenchmarkAverage, int BenchmarkCurrent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendStatusToFlashWithVsyncWarning, "BmScript.GFxMovieBenchmarking.SendStatusToFlashWithVsyncWarning", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkingActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkMin, paramsPtr + 4);
        BenchmarkMax.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkAverage, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkCurrent, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendStatusToFlash;
    /// <summary>
    /// Function: SendStatusToFlash
    /// </summary>
    public unsafe virtual void SendStatusToFlash(bool BenchmarkingActive, int BenchmarkMin, int BenchmarkMax, int BenchmarkAverage, int BenchmarkCurrent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendStatusToFlash, "BmScript.GFxMovieBenchmarking.SendStatusToFlash", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkingActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkMin, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkMax, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkAverage, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkCurrent, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendFlashClearScreen;
    /// <summary>
    /// Function: SendFlashClearScreen
    /// </summary>
    public unsafe virtual void SendFlashClearScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendFlashClearScreen, "BmScript.GFxMovieBenchmarking.SendFlashClearScreen", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FlashEscTextToUser;
    /// <summary>
    /// Function: FlashEscTextToUser
    /// </summary>
    public unsafe virtual void FlashEscTextToUser()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FlashEscTextToUser, "BmScript.GFxMovieBenchmarking.FlashEscTextToUser", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendEscStringToFlash;
    /// <summary>
    /// Function: SendEscStringToFlash
    /// </summary>
    public unsafe virtual void SendEscStringToFlash(BmSDK.FStringArg Prompt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendEscStringToFlash, "BmScript.GFxMovieBenchmarking.SendEscStringToFlash", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Prompt.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GeneratePromptString;
    /// <summary>
    /// Function: GeneratePromptString
    /// </summary>
    public unsafe virtual BmSDK.FString GeneratePromptString(int controlIcon, bool bGamepad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GeneratePromptString, "BmScript.GFxMovieBenchmarking.GeneratePromptString", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(controlIcon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGamepad, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetEscString;
    /// <summary>
    /// Function: SetEscString
    /// </summary>
    public unsafe virtual void SetEscString(bool bGamepad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetEscString, "BmScript.GFxMovieBenchmarking.SetEscString", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGamepad, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnAspectRatioChanged;
    /// <summary>
    /// Function: OnAspectRatioChanged
    /// </summary>
    public unsafe override void OnAspectRatioChanged(float aspect_ratio)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnAspectRatioChanged, "BmScript.GFxMovieBenchmarking.OnAspectRatioChanged", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aspect_ratio, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmScript.GFxMovieBenchmarking.Init", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bCanEscapeEarly
    /// </summary>
    public unsafe bool bCanEscapeEarly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }
}
