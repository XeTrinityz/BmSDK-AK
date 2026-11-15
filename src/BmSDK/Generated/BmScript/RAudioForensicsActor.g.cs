#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RAudioForensicsActor<br/>
/// (size = 792)
/// (flags = 10486290)
/// </summary>
public partial class RAudioForensicsActor : BmSDK.BmGame.RAudioForensicsActorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RAudioForensicsActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAudioForensicsActor.
    /// </summary>
    public static RAudioForensicsActor DefaultObject => (RAudioForensicsActor)StaticClass().DefaultObject;

    internal RAudioForensicsActor() { }

    /// <summary>
    /// Constructs a new RAudioForensicsActor
    /// </summary>
    public RAudioForensicsActor(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAudioForensicsActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAudioForensicsActor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAudioForensicsActor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAudioForensicsActor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAudioForensicsActor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAudioForensicsActor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAudioForensicsActor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAudioForensicsActor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAudioForensicsActor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Const: InteravalToUpdateAudio = 1.f
    /// </summary>
    public const float InteravalToUpdateAudio = 1f;

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateTrack;
    /// <summary>
    /// Function: UpdateTrack
    /// </summary>
    public unsafe virtual void UpdateTrack(float dt, BmSDK.BmScript.RVideoForensicsActor VIDEO_Actor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateTrack, "BmScript.RAudioForensicsActor.UpdateTrack", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VIDEO_Actor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AudioStoppedPlaying;
    /// <summary>
    /// Function: AudioStoppedPlaying
    /// </summary>
    public unsafe virtual void AudioStoppedPlaying(int CallbackFlags, BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, int MarkerID, int MarkerTypeID, float Duration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AudioStoppedPlaying, "BmScript.RAudioForensicsActor.AudioStoppedPlaying", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallbackFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerID, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerTypeID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopTrack;
    /// <summary>
    /// Function: StopTrack
    /// </summary>
    public unsafe virtual void StopTrack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopTrack, "BmScript.RAudioForensicsActor.StopTrack", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartTrack;
    /// <summary>
    /// Function: StartTrack
    /// </summary>
    public unsafe virtual void StartTrack(BmSDK.BmScript.RVideoForensicsActor VIDEO_Actor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartTrack, "BmScript.RAudioForensicsActor.StartTrack", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VIDEO_Actor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Moved;
    /// <summary>
    /// Function: Moved
    /// </summary>
    public unsafe virtual void Moved()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Moved, "BmScript.RAudioForensicsActor.Moved", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayZoomOut;
    /// <summary>
    /// Function: PlayZoomOut
    /// </summary>
    public unsafe virtual void PlayZoomOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayZoomOut, "BmScript.RAudioForensicsActor.PlayZoomOut", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayZoomIn;
    /// <summary>
    /// Function: PlayZoomIn
    /// </summary>
    public unsafe virtual void PlayZoomIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayZoomIn, "BmScript.RAudioForensicsActor.PlayZoomIn", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayScanForEvidence;
    /// <summary>
    /// Function: PlayScanForEvidence
    /// </summary>
    public unsafe virtual void PlayScanForEvidence()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayScanForEvidence, "BmScript.RAudioForensicsActor.PlayScanForEvidence", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayEvidenceLocked;
    /// <summary>
    /// Function: PlayEvidenceLocked
    /// </summary>
    public unsafe virtual void PlayEvidenceLocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayEvidenceLocked, "BmScript.RAudioForensicsActor.PlayEvidenceLocked", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayEvidenceFound;
    /// <summary>
    /// Function: PlayEvidenceFound
    /// </summary>
    public unsafe virtual void PlayEvidenceFound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayEvidenceFound, "BmScript.RAudioForensicsActor.PlayEvidenceFound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopPreviewScan;
    /// <summary>
    /// Function: StopPreviewScan
    /// </summary>
    public unsafe virtual void StopPreviewScan()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopPreviewScan, "BmScript.RAudioForensicsActor.StopPreviewScan", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayPreviewScanBackward;
    /// <summary>
    /// Function: PlayPreviewScanBackward
    /// </summary>
    public unsafe virtual void PlayPreviewScanBackward()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayPreviewScanBackward, "BmScript.RAudioForensicsActor.PlayPreviewScanBackward", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayPreviewScanForward;
    /// <summary>
    /// Function: PlayPreviewScanForward
    /// </summary>
    public unsafe virtual void PlayPreviewScanForward()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayPreviewScanForward, "BmScript.RAudioForensicsActor.PlayPreviewScanForward", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopForensics;
    /// <summary>
    /// Function: StopForensics
    /// </summary>
    public unsafe virtual void StopForensics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopForensics, "BmScript.RAudioForensicsActor.StopForensics", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartForensics;
    /// <summary>
    /// Function: StartForensics
    /// </summary>
    public unsafe virtual void StartForensics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartForensics, "BmScript.RAudioForensicsActor.StartForensics", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: AFA_WhichDirection
    /// </summary>
    public enum AFA_WhichDirection : byte
    {
        AFA_Stopped = 0,
        AFA_Forwards = 1,
        AFA_Backwards = 2,
        AFA_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: ReticuleMove<br/>
    /// Default: Ww_OBJ_CCTV_Scanner.Play_Cell_Reticule_Move
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ReticuleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: ScanBackward<br/>
    /// Default: Ww_OBJ_CCTV_Scanner.Play_CCTV_Scan_Back
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScanBackward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: ScanForward<br/>
    /// Default: Ww_OBJ_CCTV_Scanner.Play_CCTV_Scan_Forward
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScanForward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: ZoomIn<br/>
    /// Default: Ww_OBJ_CCTV_Scanner.Play_CCTV_Zoom_In
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZoomIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: ZoomOut<br/>
    /// Default: Ww_OBJ_CCTV_Scanner.Play_CCTV_Zoom_Out
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZoomOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceFound<br/>
    /// Default: Ww_OBJ_CCTV_Scanner.Play_Evidence_Found
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EvidenceFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceLocked<br/>
    /// Default: Ww_OBJ_CCTV_Scanner.Play_Evidence_Locked
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EvidenceLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: ScanEvidence<br/>
    /// Default: Ww_OBJ_CCTV_Scanner.Play_Scan_Evidence_Cell
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScanEvidence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: AudioTrackEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioTrackEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: AudioTrackSpeedParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName AudioTrackSpeedParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: MaxLengthOfAudioWav
    /// </summary>
    public unsafe float MaxLengthOfAudioWav
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: SilentOffset
    /// </summary>
    public unsafe float SilentOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: CurrentTrackDeltaTime
    /// </summary>
    public unsafe float CurrentTrackDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ByteProperty: PlayHeadDirection
    /// </summary>
    public unsafe BmSDK.BmScript.RAudioForensicsActor.AFA_WhichDirection PlayHeadDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RAudioForensicsActor.AFA_WhichDirection>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ByteProperty: LastPlayHeadDirection
    /// </summary>
    public unsafe BmSDK.BmScript.RAudioForensicsActor.AFA_WhichDirection LastPlayHeadDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RAudioForensicsActor.AFA_WhichDirection>(Ptr + 769); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 769); }
    }

    /// <summary>
    /// StructProperty: TrackHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle TrackHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 772);

    /// <summary>
    /// BoolProperty: ShouldBePlaying
    /// </summary>
    public unsafe bool ShouldBePlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: AudioIsPlaying
    /// </summary>
    public unsafe bool AudioIsPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }
}
