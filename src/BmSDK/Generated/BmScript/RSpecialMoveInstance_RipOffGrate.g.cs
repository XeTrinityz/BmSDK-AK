#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_RipOffGrate<br/>
/// (size = 1060)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_RipOffGrate : BmSDK.BmGame.RSpecialMoveInstance_RelativeAnimWithAlignment, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_RipOffGrate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_RipOffGrate.
    /// </summary>
    public static RSpecialMoveInstance_RipOffGrate DefaultObject => (RSpecialMoveInstance_RipOffGrate)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_RipOffGrate() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_RipOffGrate
    /// </summary>
    public RSpecialMoveInstance_RipOffGrate(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_RipOffGrate(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RipOffGrate>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RipOffGrate>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RipOffGrate>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RipOffGrate>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RipOffGrate>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RipOffGrate>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RipOffGrate>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RipOffGrate>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PressingButtons;
    /// <summary>
    /// Function: PressingButtons
    /// </summary>
    public unsafe virtual void PressingButtons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PressingButtons, "BmScript.RSpecialMoveInstance_RipOffGrate.PressingButtons", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FinishSpecialMove, "BmScript.RSpecialMoveInstance_RipOffGrate.FinishSpecialMove", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlaySpecialCameraAnim;
    /// <summary>
    /// Function: PlaySpecialCameraAnim
    /// </summary>
    public unsafe override bool PlaySpecialCameraAnim(BmSDK.BmGame.RPlayerController InController, BmSDK.FName AnimName, bool bPlaying, bool bCamMirrored, float FOV = default, bool bLoop = default, float AnimStartTime = default, bool bProportionalMotion = default, float fBlendInTime = default, BmSDK.Engine.SkeletalMeshComponent SlavedToSkelComponent = default, BmSDK.Engine.AnimSequence SlavedToAnim = default, bool bIgnoreBlend = default, bool bBlendEvenIfInactive = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlaySpecialCameraAnim, "BmScript.RSpecialMoveInstance_RipOffGrate.PlaySpecialCameraAnim", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InController, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaying, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoop, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProportionalMotion, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fBlendInTime, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlavedToSkelComponent, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlavedToAnim, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreBlend, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlendEvenIfInactive, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceShootStumble;
    /// <summary>
    /// Function: ForceShootStumble
    /// </summary>
    public unsafe override bool ForceShootStumble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceShootStumble, "BmScript.RSpecialMoveInstance_RipOffGrate.ForceShootStumble", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayGrateAnim;
    /// <summary>
    /// Function: PlayGrateAnim
    /// </summary>
    public unsafe virtual void PlayGrateAnim(BmSDK.FName AnimName, bool bAnimMirrored = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayGrateAnim, "BmScript.RSpecialMoveInstance_RipOffGrate.PlayGrateAnim", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAnimMirrored, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayCameraAnim;
    /// <summary>
    /// Function: PlayCameraAnim
    /// </summary>
    public unsafe override bool PlayCameraAnim(BmSDK.FName AnimName, bool bAnimMirrored = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayCameraAnim, "BmScript.RSpecialMoveInstance_RipOffGrate.PlayCameraAnim", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAnimMirrored, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CancelSpecialMove, "BmScript.RSpecialMoveInstance_RipOffGrate.CancelSpecialMove", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayPlayerAnim;
    /// <summary>
    /// Function: PlayPlayerAnim
    /// </summary>
    public unsafe virtual void PlayPlayerAnim(BmSDK.FName TransitionAnim, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig IdleConfig = default, float MeetingTime = default, BmSDK.FName Stance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayPlayerAnim, "BmScript.RSpecialMoveInstance_RipOffGrate.PlayPlayerAnim", this);
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleConfig, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeetingTime, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerSpecialMove, "BmScript.RSpecialMoveInstance_RipOffGrate.TriggerSpecialMove", this);
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AnimationStarted;
    /// <summary>
    /// Function: AnimationStarted
    /// </summary>
    public unsafe override void AnimationStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AnimationStarted, "BmScript.RSpecialMoveInstance_RipOffGrate.AnimationStarted", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: StruggleScore
    /// </summary>
    public unsafe float StruggleScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: StruggleSpeed
    /// </summary>
    public unsafe float StruggleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bFirstFrameSucceeded
    /// </summary>
    public unsafe bool bFirstFrameSucceeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bNoiseBoxFlash
    /// </summary>
    public unsafe bool bNoiseBoxFlash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bNoisyRemove
    /// </summary>
    public unsafe bool bNoisyRemove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bStraining
    /// </summary>
    public unsafe bool bStraining
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bRipButtonPressed
    /// </summary>
    public unsafe bool bRipButtonPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: FlashTime
    /// </summary>
    public unsafe float FlashTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ObjectProperty: MyGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoveableGrate MyGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRemoveableGrate>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: StrainAmount
    /// </summary>
    public unsafe float StrainAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: TimeAtMinSpeed
    /// </summary>
    public unsafe float TimeAtMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: TimeAtMaxSpeed
    /// </summary>
    public unsafe float TimeAtMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: LastButtonSpeed
    /// </summary>
    public unsafe float LastButtonSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }
}
