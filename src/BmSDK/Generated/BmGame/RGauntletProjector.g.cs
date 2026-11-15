#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGauntletProjector<br/>
/// (size = 432)
/// (flags = 142606482)
/// </summary>
public partial class RGauntletProjector : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGauntletProjector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGauntletProjector.
    /// </summary>
    public static RGauntletProjector DefaultObject => (RGauntletProjector)StaticClass().DefaultObject;

    internal RGauntletProjector() { }

    /// <summary>
    /// Constructs a new RGauntletProjector
    /// </summary>
    public RGauntletProjector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGauntletProjector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGauntletProjector(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGauntletProjector>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGauntletProjector>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGauntletProjector>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGauntletProjector>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGauntletProjector>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGauntletProjector>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGauntletProjector>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGauntletProjector>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe virtual void PlayerTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayerTick, "BmGame.RGauntletProjector.PlayerTick", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FlashMovieFinished;
    /// <summary>
    /// Function: FlashMovieFinished
    /// </summary>
    public unsafe virtual void FlashMovieFinished(BmSDK.FStringArg VideoResource)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FlashMovieFinished, "BmGame.RGauntletProjector.FlashMovieFinished", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        VideoResource.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ActuallyTurnOffProjector;
    /// <summary>
    /// Function: ActuallyTurnOffProjector
    /// </summary>
    public unsafe void ActuallyTurnOffProjector()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActuallyTurnOffProjector, "BmGame.RGauntletProjector.ActuallyTurnOffProjector");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopProjection;
    /// <summary>
    /// Function: StopProjection
    /// </summary>
    public unsafe virtual void StopProjection(BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue caller = default, BmSDK.FStringArg VideoResource = default, float fTransitionOutDurationOverride = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopProjection, "BmGame.RGauntletProjector.StopProjection", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(caller, paramsPtr + 0);
        VideoResource.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTransitionOutDurationOverride, paramsPtr + 24);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetOpaque;
    /// <summary>
    /// Function: SetOpaque
    /// </summary>
    public unsafe virtual void SetOpaque(bool is_opaque)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetOpaque, "BmGame.RGauntletProjector.SetOpaque", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_opaque, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn__InitializeHologram;
    /// <summary>
    /// Function: _InitializeHologram
    /// </summary>
    public unsafe virtual void _InitializeHologram(BmSDK.BmGame.RGFxMovie iMovie, BmSDK.Engine.SkeletalMeshComponent iAttachToSkeleton = default, BmSDK.FName sAttachToBone = default, BmSDK.FName sAttachToSocket = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn__InitializeHologram, "BmGame.RGauntletProjector._InitializeHologram", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMovie, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAttachToSkeleton, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAttachToBone, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAttachToSocket, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartHackingProjection;
    /// <summary>
    /// Function: StartHackingProjection
    /// </summary>
    public unsafe virtual void StartHackingProjection(BmSDK.Engine.SkeletalMeshComponent iAttachToSkeleton = default, BmSDK.FName sAttachToBone = default, BmSDK.FName sAttachToSocket = default, bool bBrainHacking = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartHackingProjection, "BmGame.RGauntletProjector.StartHackingProjection", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAttachToSkeleton, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAttachToBone, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAttachToSocket, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBrainHacking, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGauntletConnectionLost;
    /// <summary>
    /// Function: SetGauntletConnectionLost
    /// </summary>
    public unsafe virtual void SetGauntletConnectionLost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGauntletConnectionLost, "BmGame.RGauntletProjector.SetGauntletConnectionLost", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetVideoPortrait;
    /// <summary>
    /// Function: SetVideoPortrait
    /// </summary>
    public unsafe virtual void SetVideoPortrait(BmSDK.FStringArg PortraitName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetVideoPortrait, "BmGame.RGauntletProjector.SetVideoPortrait", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        PortraitName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartVideoProjection;
    /// <summary>
    /// Function: StartVideoProjection
    /// </summary>
    public unsafe virtual void StartVideoProjection(BmSDK.FStringArg sVideoResource, BmSDK.FStringArg sHeaderText, bool bForceOpaque = default, bool bWithOverlay = default, bool bConnectionFailedOn = default, bool bSkipIntro = default, BmSDK.Engine.SkeletalMeshComponent meshToAttachTo = default, bool bNoMovie = default, bool bAutoPause = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartVideoProjection, "BmGame.RGauntletProjector.StartVideoProjection", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sVideoResource.WriteTo(paramsPtr + 0);
        sHeaderText.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOpaque, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWithOverlay, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bConnectionFailedOn, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipIntro, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(meshToAttachTo, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoMovie, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAutoPause, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_QueueVideoProjection;
    /// <summary>
    /// Function: QueueVideoProjection
    /// </summary>
    public unsafe virtual void QueueVideoProjection(BmSDK.FStringArg sVideoResource, BmSDK.FStringArg sHeaderText, bool bForceOpaque = default, bool bWithOverlay = default, bool bConnectionFailedOn = default, bool bSkipIntro = default, BmSDK.FStringArg PortraitName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_QueueVideoProjection, "BmGame.RGauntletProjector.QueueVideoProjection", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sVideoResource.WriteTo(paramsPtr + 0);
        sHeaderText.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOpaque, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWithOverlay, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bConnectionFailedOn, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipIntro, paramsPtr + 44);
        PortraitName.WriteTo(paramsPtr + 48);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise(BmSDK.BmGame.RPlayerController _RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Initialise, "BmGame.RGauntletProjector.Initialise", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: transitionState
    /// </summary>
    public enum transitionState : byte
    {
        eTransIn = 0,
        eTransNone = 1,
        eTransOut = 2,
        transitionState_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: VideoPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieVideoPlayer VideoPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieVideoPlayer>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: VideoOverlay
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieVideoOverlay VideoOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieVideoOverlay>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: HackingDevice
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieOmnitronBase HackingDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieOmnitronBase>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: PrimaryRenderTarget<br/>
    /// Default: Gadgets.Resonator.ProjectionPrimary_RT
    /// </summary>
    public unsafe BmSDK.Engine.TextureRenderTarget2D PrimaryRenderTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTarget2D>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: SecondaryRenderTarget<br/>
    /// Default: Gadgets.Resonator.ProjectionSecondary_RT
    /// </summary>
    public unsafe BmSDK.Engine.TextureRenderTarget2D SecondaryRenderTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTarget2D>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: HologramMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HologramMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: HologramMovieMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HologramMovieMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: RHDInstancedMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant RHDInstancedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: RHDOriginalMaterial<br/>
    /// Default: Gadgets.Resonator.Display_RHD_INST
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant RHDOriginalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: GauntletConvLightingRigArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RLightingRigActor GauntletConvLightingRigArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLightingRigActor>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: GauntletConvLightingRig
    /// </summary>
    public unsafe BmSDK.BmGame.RLightingRigActor GauntletConvLightingRig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLightingRigActor>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: TVOnSound<br/>
    /// Default: Ww_CHR_BatmanGauntlet.Play_Gauntlet_On
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TVOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: TVOffSound<br/>
    /// Default: Ww_CHR_BatmanGauntlet.Play_Gauntlet_Off
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TVOffSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: RHDOnSound<br/>
    /// Default: Ww_CHR_RemoteHackingDevice.Play_RHD_On
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RHDOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: RHDOffSound<br/>
    /// Default: Ww_CHR_RemoteHackingDevice.Play_RHD_Off
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RHDOffSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: StopProjectionCachedCaller
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue StopProjectionCachedCaller
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ComponentProperty: XrayWorldMaskMesh<br/>
    /// Default: BmGame.Default__RGauntletProjector.XrayScreen02
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayWorldMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ComponentProperty: XrayHighlightMaskMesh<br/>
    /// Default: BmGame.Default__RGauntletProjector.XrayScreen01
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayHighlightMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ComponentProperty: ScreenHologramMovieMesh<br/>
    /// Default: BmGame.Default__RGauntletProjector.HologramScreenMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ScreenHologramMovieMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ComponentProperty: ScreenHologramMesh<br/>
    /// Default: BmGame.Default__RGauntletProjector.HologramMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ScreenHologramMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ComponentProperty: ScreenHologram<br/>
    /// Default: BmGame.Default__RGauntletProjector.ScreenHologram0
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxWorldMovieComponent ScreenHologram
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxWorldMovieComponent>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ComponentProperty: ScreenLight<br/>
    /// Default: BmGame.Default__RGauntletProjector.ScreenLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.LightComponent ScreenLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LightComponent>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: QueuedVideoResource
    /// </summary>
    public unsafe BmSDK.FString QueuedVideoResource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StrProperty: QueuedVideoHeaderText
    /// </summary>
    public unsafe BmSDK.FString QueuedVideoHeaderText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: QueuedVideoForceOpaque
    /// </summary>
    public unsafe bool QueuedVideoForceOpaque
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: QueuedWithOverlay
    /// </summary>
    public unsafe bool QueuedWithOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: QueuedConnectionFailedOn
    /// </summary>
    public unsafe bool QueuedConnectionFailedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: QueuedSkipIntro
    /// </summary>
    public unsafe bool QueuedSkipIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: bRHDIsSetInDetectiveMode
    /// </summary>
    public unsafe bool bRHDIsSetInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: ScreenOn
    /// </summary>
    public unsafe bool ScreenOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: ScreenOverLayOn
    /// </summary>
    public unsafe bool ScreenOverLayOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: bDontStop
    /// </summary>
    public unsafe bool bDontStop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: NeedToRestoreHudWhenFinished
    /// </summary>
    public unsafe bool NeedToRestoreHudWhenFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// StrProperty: QueuedPortraitName
    /// </summary>
    public unsafe BmSDK.FString QueuedPortraitName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: ScreenLightBrightness<br/>
    /// Default: 10
    /// </summary>
    public unsafe float ScreenLightBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StructProperty: LeftCornerScreenOffset<br/>
    /// Default: (Y=-4,Z=-2)
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LeftCornerScreenOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 324);

    /// <summary>
    /// StructProperty: LeftCornerScreenRotationOffset<br/>
    /// Default: (Pitch=3094,Yaw=5461,Roll=-2548)
    /// </summary>
    public unsafe ref BmSDK.Rotator LeftCornerScreenRotationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 336);

    /// <summary>
    /// StructProperty: ScreenToMeshOffset_Bone<br/>
    /// Default: (X=-17,Y=2,Z=2.1)
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ScreenToMeshOffset_Bone
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 348);

    /// <summary>
    /// StructProperty: BatmanToMeshOffset_Batmobile<br/>
    /// Default: (X=33,Y=-15,Z=66)
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanToMeshOffset_Batmobile
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 360);

    /// <summary>
    /// StructProperty: BatmanToMeshRotation_Batmobile<br/>
    /// Default: (Pitch=-1456,Yaw=1638,Roll=21845)
    /// </summary>
    public unsafe ref BmSDK.Rotator BatmanToMeshRotation_Batmobile
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 372);

    /// <summary>
    /// StrProperty: lastPlayedVideoResource
    /// </summary>
    public unsafe BmSDK.FString lastPlayedVideoResource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ByteProperty: transState
    /// </summary>
    public unsafe BmSDK.BmGame.RGauntletProjector.transitionState transState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGauntletProjector.transitionState>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: transProportion
    /// </summary>
    public unsafe float transProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: transInDuration<br/>
    /// Default: 2
    /// </summary>
    public unsafe float transInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: transOutDuration<br/>
    /// Default: 0.4
    /// </summary>
    public unsafe float transOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StrProperty: StopProjectionCachedVideoResource
    /// </summary>
    public unsafe BmSDK.FString StopProjectionCachedVideoResource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
}
