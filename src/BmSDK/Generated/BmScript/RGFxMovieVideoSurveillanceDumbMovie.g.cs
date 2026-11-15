#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieVideoSurveillanceDumbMovie<br/>
/// (size = 708)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieVideoSurveillanceDumbMovie : BmSDK.BmGame.RGFxMovieWorldBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieVideoSurveillanceDumbMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieVideoSurveillanceDumbMovie.
    /// </summary>
    public static RGFxMovieVideoSurveillanceDumbMovie DefaultObject => (RGFxMovieVideoSurveillanceDumbMovie)StaticClass().DefaultObject;

    internal RGFxMovieVideoSurveillanceDumbMovie() { }

    /// <summary>
    /// Constructs a new RGFxMovieVideoSurveillanceDumbMovie
    /// </summary>
    public RGFxMovieVideoSurveillanceDumbMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieVideoSurveillanceDumbMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieVideoSurveillanceDumbMovie(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumbMovie>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumbMovie>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumbMovie>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumbMovie>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumbMovie>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumbMovie>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumbMovie>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumbMovie>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_MakeScanForEvidenceSound;
    /// <summary>
    /// Function: XI_MakeScanForEvidenceSound
    /// </summary>
    public unsafe virtual void XI_MakeScanForEvidenceSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_MakeScanForEvidenceSound, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_MakeScanForEvidenceSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_MakeZoomOutSound;
    /// <summary>
    /// Function: XI_MakeZoomOutSound
    /// </summary>
    public unsafe virtual void XI_MakeZoomOutSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_MakeZoomOutSound, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_MakeZoomOutSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_MakeZoomInSound;
    /// <summary>
    /// Function: XI_MakeZoomInSound
    /// </summary>
    public unsafe virtual void XI_MakeZoomInSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_MakeZoomInSound, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_MakeZoomInSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_MakeMoveSound;
    /// <summary>
    /// Function: XI_MakeMoveSound
    /// </summary>
    public unsafe virtual void XI_MakeMoveSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_MakeMoveSound, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_MakeMoveSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GlyphAnimComplete;
    /// <summary>
    /// Function: XI_GlyphAnimComplete
    /// </summary>
    public unsafe virtual void XI_GlyphAnimComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GlyphAnimComplete, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_GlyphAnimComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OutroComplete;
    /// <summary>
    /// Function: XI_OutroComplete
    /// </summary>
    public unsafe virtual void XI_OutroComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OutroComplete, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_OutroComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_IntroComplete;
    /// <summary>
    /// Function: XI_IntroComplete
    /// </summary>
    public unsafe virtual void XI_IntroComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_IntroComplete, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_IntroComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetQueueBusy;
    /// <summary>
    /// Function: XI_SetQueueBusy
    /// </summary>
    public unsafe virtual void XI_SetQueueBusy(bool Busy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetQueueBusy, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_SetQueueBusy", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Busy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ReadyToCallFunctions;
    /// <summary>
    /// Function: XI_ReadyToCallFunctions
    /// </summary>
    public unsafe virtual void XI_ReadyToCallFunctions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ReadyToCallFunctions, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.XI_ReadyToCallFunctions", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetCameraNames;
    /// <summary>
    /// Function: UC_SetCameraNames
    /// </summary>
    public unsafe virtual void UC_SetCameraNames(BmSDK.FStringArg cam1, BmSDK.FStringArg cam2, BmSDK.FStringArg cam3, BmSDK.FStringArg cam4)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetCameraNames, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.UC_SetCameraNames", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        cam1.WriteTo(paramsPtr + 0);
        cam2.WriteTo(paramsPtr + 16);
        cam3.WriteTo(paramsPtr + 32);
        cam4.WriteTo(paramsPtr + 48);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_HideCameraNames;
    /// <summary>
    /// Function: UC_HideCameraNames
    /// </summary>
    public unsafe virtual void UC_HideCameraNames()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_HideCameraNames, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.UC_HideCameraNames", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetInterfaceVisible;
    /// <summary>
    /// Function: UC_SetInterfaceVisible
    /// </summary>
    public unsafe virtual void UC_SetInterfaceVisible(bool MakeVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetInterfaceVisible, "BmScript.RGFxMovieVideoSurveillanceDumbMovie.UC_SetInterfaceVisible", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MakeVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: AudioData
    /// </summary>
    public unsafe BmSDK.BmScript.RAudioForensicsActor AudioData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RAudioForensicsActor>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bIntroComplete
    /// </summary>
    public unsafe bool bIntroComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bFinishedGFx
    /// </summary>
    public unsafe bool bFinishedGFx
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bQueueBusy
    /// </summary>
    public unsafe bool bQueueBusy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bGlyphAnimComplete
    /// </summary>
    public unsafe bool bGlyphAnimComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }
}
