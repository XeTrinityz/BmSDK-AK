#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieVideoSurveillanceDumb<br/>
/// (size = 716)
/// (flags = 10486290)
/// </summary>
public partial class RGFxMovieVideoSurveillanceDumb : BmSDK.BmGame.RGFxWorldMovieActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieVideoSurveillanceDumb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieVideoSurveillanceDumb.
    /// </summary>
    public static RGFxMovieVideoSurveillanceDumb DefaultObject => (RGFxMovieVideoSurveillanceDumb)StaticClass().DefaultObject;

    internal RGFxMovieVideoSurveillanceDumb() { }

    /// <summary>
    /// Constructs a new RGFxMovieVideoSurveillanceDumb
    /// </summary>
    public RGFxMovieVideoSurveillanceDumb(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieVideoSurveillanceDumb(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumb>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumb>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumb>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumb>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumb>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumb>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumb>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieVideoSurveillanceDumb>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CodeEntered;
    /// <summary>
    /// Function: CodeEntered
    /// </summary>
    public unsafe virtual void CodeEntered(bool is_correct)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CodeEntered, "BmScript.RGFxMovieVideoSurveillanceDumb.CodeEntered", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_correct, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PressKey;
    /// <summary>
    /// Function: PressKey
    /// </summary>
    public unsafe virtual void PressKey(int KeyIndex, BmSDK.FStringArg key_text)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PressKey, "BmScript.RGFxMovieVideoSurveillanceDumb.PressKey", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyIndex, paramsPtr + 0);
        key_text.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetSelectedKey;
    /// <summary>
    /// Function: SetSelectedKey
    /// </summary>
    public unsafe virtual void SetSelectedKey(int KeyIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetSelectedKey, "BmScript.RGFxMovieVideoSurveillanceDumb.SetSelectedKey", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetKeyPadVisible;
    /// <summary>
    /// Function: SetKeyPadVisible
    /// </summary>
    public unsafe virtual void SetKeyPadVisible(bool IsVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetKeyPadVisible, "BmScript.RGFxMovieVideoSurveillanceDumb.SetKeyPadVisible", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTitle;
    /// <summary>
    /// Function: SetTitle
    /// </summary>
    public unsafe virtual void SetTitle(BmSDK.FStringArg CameraTitle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTitle, "BmScript.RGFxMovieVideoSurveillanceDumb.SetTitle", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        CameraTitle.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPlaySpeed;
    /// <summary>
    /// Function: SetPlaySpeed
    /// </summary>
    public unsafe virtual void SetPlaySpeed(float PlaySpeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPlaySpeed, "BmScript.RGFxMovieVideoSurveillanceDumb.SetPlaySpeed", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaySpeed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTime;
    /// <summary>
    /// Function: SetTime
    /// </summary>
    public unsafe virtual void SetTime(float CurrentTimeMinutes, float TotalTimeMinutes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTime, "BmScript.RGFxMovieVideoSurveillanceDumb.SetTime", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentTimeMinutes, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalTimeMinutes, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetStickAngle;
    /// <summary>
    /// Function: SetStickAngle
    /// </summary>
    public unsafe virtual void SetStickAngle(float StickAngleDegrees)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetStickAngle, "BmScript.RGFxMovieVideoSurveillanceDumb.SetStickAngle", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StickAngleDegrees, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGridSixteenSelection;
    /// <summary>
    /// Function: SetGridSixteenSelection
    /// </summary>
    public unsafe virtual void SetGridSixteenSelection(int column, int Row)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGridSixteenSelection, "BmScript.RGFxMovieVideoSurveillanceDumb.SetGridSixteenSelection", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(column, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Row, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGridFourSelectionPrivate;
    /// <summary>
    /// Function: SetGridFourSelectionPrivate
    /// </summary>
    public unsafe virtual void SetGridFourSelectionPrivate(int column, int Row)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGridFourSelectionPrivate, "BmScript.RGFxMovieVideoSurveillanceDumb.SetGridFourSelectionPrivate", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(column, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Row, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetFlashZoomLevelPrivate;
    /// <summary>
    /// Function: SetFlashZoomLevelPrivate
    /// </summary>
    public unsafe virtual void SetFlashZoomLevelPrivate(BmSDK.BmScript.RGFxMovieVideoSurveillanceDumb.SurveillanceZoomLevel zoom_level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetFlashZoomLevelPrivate, "BmScript.RGFxMovieVideoSurveillanceDumb.SetFlashZoomLevelPrivate", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(zoom_level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetSingleCameraZoomLevel;
    /// <summary>
    /// Function: SetSingleCameraZoomLevel
    /// </summary>
    public unsafe virtual void SetSingleCameraZoomLevel(BmSDK.BmScript.RGFxMovieVideoSurveillanceDumb.SurveillanceZoomLevel zoom_level, int selected_column = default, int selected_row = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetSingleCameraZoomLevel, "BmScript.RGFxMovieVideoSurveillanceDumb.SetSingleCameraZoomLevel", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(zoom_level, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_column, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_row, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetFourCameraZoomLevel;
    /// <summary>
    /// Function: SetFourCameraZoomLevel
    /// </summary>
    public unsafe virtual void SetFourCameraZoomLevel(BmSDK.BmScript.RGFxMovieVideoSurveillanceDumb.SurveillanceZoomLevel zoom_level, int selected_column = default, int selected_row = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetFourCameraZoomLevel, "BmScript.RGFxMovieVideoSurveillanceDumb.SetFourCameraZoomLevel", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(zoom_level, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_column, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_row, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetZoomLevel;
    /// <summary>
    /// Function: SetZoomLevel
    /// </summary>
    public unsafe virtual void SetZoomLevel(bool IsSingleCamera, BmSDK.BmScript.RGFxMovieVideoSurveillanceDumb.SurveillanceZoomLevel zoom_level, int selected_column = default, int selected_row = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetZoomLevel, "BmScript.RGFxMovieVideoSurveillanceDumb.SetZoomLevel", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsSingleCamera, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(zoom_level, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_column, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected_row, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetWaveformLevel;
    /// <summary>
    /// Function: SetWaveformLevel
    /// </summary>
    public unsafe virtual void SetWaveformLevel(int waveform_level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetWaveformLevel, "BmScript.RGFxMovieVideoSurveillanceDumb.SetWaveformLevel", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(waveform_level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayGlyphAnim;
    /// <summary>
    /// Function: PlayGlyphAnim
    /// </summary>
    public unsafe virtual void PlayGlyphAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayGlyphAnim, "BmScript.RGFxMovieVideoSurveillanceDumb.PlayGlyphAnim", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetOverlayVisible;
    /// <summary>
    /// Function: SetOverlayVisible
    /// </summary>
    public unsafe virtual void SetOverlayVisible(BmSDK.FStringArg overlay_frame, bool is_visible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetOverlayVisible, "BmScript.RGFxMovieVideoSurveillanceDumb.SetOverlayVisible", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        overlay_frame.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_visible, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoOverlayScan;
    /// <summary>
    /// Function: DoOverlayScan
    /// </summary>
    public unsafe virtual void DoOverlayScan(BmSDK.FStringArg overlay_frame)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoOverlayScan, "BmScript.RGFxMovieVideoSurveillanceDumb.DoOverlayScan", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        overlay_frame.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoScan;
    /// <summary>
    /// Function: DoScan
    /// </summary>
    public unsafe virtual void DoScan(BmSDK.FStringArg high_res_frame)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoScan, "BmScript.RGFxMovieVideoSurveillanceDumb.DoScan", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        high_res_frame.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShutDown;
    /// <summary>
    /// Function: ShutDown
    /// </summary>
    public unsafe override void ShutDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShutDown, "BmScript.RGFxMovieVideoSurveillanceDumb.ShutDown", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitMovie;
    /// <summary>
    /// Function: InitMovie
    /// </summary>
    public unsafe virtual void InitMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitMovie, "BmScript.RGFxMovieVideoSurveillanceDumb.InitMovie", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.RGFxMovieVideoSurveillanceDumb.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: CurrentZoomLevel
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieVideoSurveillanceDumb.SurveillanceZoomLevel CurrentZoomLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieVideoSurveillanceDumb.SurveillanceZoomLevel>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// IntProperty: SelectedQuadrant
    /// </summary>
    public unsafe int SelectedQuadrant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// IntProperty: SelectedSixteenth
    /// </summary>
    public unsafe int SelectedSixteenth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: HasFourCameras<br/>
    /// Default: true
    /// </summary>
    public unsafe bool HasFourCameras
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bFinished
    /// </summary>
    public unsafe bool bFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// Enum: SurveillanceZoomLevel
    /// </summary>
    public enum SurveillanceZoomLevel : byte
    {
        SZL_CleanDisplay = 0,
        SZL_ShowQuadrantLines = 1,
        SZL_ShowSixteenthLines = 2,
        SZL_FullZoom = 3,
        SZL_MAX = 4,
    }
}
