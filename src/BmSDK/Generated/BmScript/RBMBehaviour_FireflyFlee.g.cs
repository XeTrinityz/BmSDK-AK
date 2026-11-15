#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_FireflyFlee<br/>
/// (size = 1596)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_FireflyFlee : BmSDK.BmGame.RBMBehaviour_FireflyFleeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_FireflyFlee", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_FireflyFlee.
    /// </summary>
    public static RBMBehaviour_FireflyFlee DefaultObject => (RBMBehaviour_FireflyFlee)StaticClass().DefaultObject;

    internal RBMBehaviour_FireflyFlee() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_FireflyFlee
    /// </summary>
    public RBMBehaviour_FireflyFlee(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_FireflyFlee Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_FireflyFlee(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_FireflyFlee>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_FireflyFlee>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_FireflyFlee>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_FireflyFlee>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_FireflyFlee>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_FireflyFlee>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_FireflyFlee>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_FireflyFlee>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RBMBehaviour_FireflyFlee.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckFailCondition;
    /// <summary>
    /// Function: CheckFailCondition
    /// </summary>
    public unsafe virtual void CheckFailCondition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckFailCondition, "BmScript.RBMBehaviour_FireflyFlee.CheckFailCondition", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WarnAboutRiotSurpressorShot;
    /// <summary>
    /// Function: WarnAboutRiotSurpressorShot
    /// </summary>
    public unsafe override void WarnAboutRiotSurpressorShot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WarnAboutRiotSurpressorShot, "BmScript.RBMBehaviour_FireflyFlee.WarnAboutRiotSurpressorShot", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyFFFliesAwayAfterBeatdown;
    /// <summary>
    /// Function: NotifyFFFliesAwayAfterBeatdown
    /// </summary>
    public unsafe override void NotifyFFFliesAwayAfterBeatdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyFFFliesAwayAfterBeatdown, "BmScript.RBMBehaviour_FireflyFlee.NotifyFFFliesAwayAfterBeatdown", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyCityOutOfView;
    /// <summary>
    /// Function: NotifyCityOutOfView
    /// </summary>
    public unsafe override void NotifyCityOutOfView()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyCityOutOfView, "BmScript.RBMBehaviour_FireflyFlee.NotifyCityOutOfView", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyBeatdownFailed;
    /// <summary>
    /// Function: NotifyBeatdownFailed
    /// </summary>
    public unsafe override void NotifyBeatdownFailed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyBeatdownFailed, "BmScript.RBMBehaviour_FireflyFlee.NotifyBeatdownFailed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyBeatdownComplete;
    /// <summary>
    /// Function: NotifyBeatdownComplete
    /// </summary>
    public unsafe override void NotifyBeatdownComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyBeatdownComplete, "BmScript.RBMBehaviour_FireflyFlee.NotifyBeatdownComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyBMMadeContactWithFirefly;
    /// <summary>
    /// Function: NotifyBMMadeContactWithFirefly
    /// </summary>
    public unsafe override void NotifyBMMadeContactWithFirefly()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyBMMadeContactWithFirefly, "BmScript.RBMBehaviour_FireflyFlee.NotifyBMMadeContactWithFirefly", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyTakedownStarted;
    /// <summary>
    /// Function: NotifyTakedownStarted
    /// </summary>
    public unsafe override System.Numerics.Vector3 NotifyTakedownStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyTakedownStarted, "BmScript.RBMBehaviour_FireflyFlee.NotifyTakedownStarted", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.RBMBehaviour_FireflyFlee.Tick", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateSavedThreat;
    /// <summary>
    /// Function: UpdateSavedThreat
    /// </summary>
    public unsafe virtual void UpdateSavedThreat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateSavedThreat, "BmScript.RBMBehaviour_FireflyFlee.UpdateSavedThreat", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryTriggerNextBombInSequence;
    /// <summary>
    /// Function: TryTriggerNextBombInSequence
    /// </summary>
    public unsafe override void TryTriggerNextBombInSequence()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryTriggerNextBombInSequence, "BmScript.RBMBehaviour_FireflyFlee.TryTriggerNextBombInSequence", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CancelMultiBomb;
    /// <summary>
    /// Function: CancelMultiBomb
    /// </summary>
    public unsafe virtual void CancelMultiBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CancelMultiBomb, "BmScript.RBMBehaviour_FireflyFlee.CancelMultiBomb", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTimeTillNextBomb;
    /// <summary>
    /// Function: SetTimeTillNextBomb
    /// </summary>
    public unsafe virtual void SetTimeTillNextBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTimeTillNextBomb, "BmScript.RBMBehaviour_FireflyFlee.SetTimeTillNextBomb", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LaunchBombAtTarget;
    /// <summary>
    /// Function: LaunchBombAtTarget
    /// </summary>
    public unsafe virtual bool LaunchBombAtTarget(System.Numerics.Vector3 TargetLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LaunchBombAtTarget, "BmScript.RBMBehaviour_FireflyFlee.LaunchBombAtTarget", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBombTargetLocationOnSpan;
    /// <summary>
    /// Function: GetBombTargetLocationOnSpan
    /// </summary>
    public unsafe virtual bool GetBombTargetLocationOnSpan(int targetSpan, out System.Numerics.Vector3 TargetLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBombTargetLocationOnSpan, "BmScript.RBMBehaviour_FireflyFlee.GetBombTargetLocationOnSpan", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targetSpan, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSpanNormal;
    /// <summary>
    /// Function: GetSpanNormal
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetSpanNormal(int targetSpan)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSpanNormal, "BmScript.RBMBehaviour_FireflyFlee.GetSpanNormal", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targetSpan, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryTriggerBombAttack;
    /// <summary>
    /// Function: TryTriggerBombAttack
    /// </summary>
    public unsafe virtual bool TryTriggerBombAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryTriggerBombAttack, "BmScript.RBMBehaviour_FireflyFlee.TryTriggerBombAttack", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMaxSpeed;
    /// <summary>
    /// Function: GetMaxSpeed
    /// </summary>
    public unsafe virtual float GetMaxSpeed(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMaxSpeed, "BmScript.RBMBehaviour_FireflyFlee.GetMaxSpeed", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateDistanceFromPlayer;
    /// <summary>
    /// Function: UpdateDistanceFromPlayer
    /// </summary>
    public unsafe virtual void UpdateDistanceFromPlayer(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateDistanceFromPlayer, "BmScript.RBMBehaviour_FireflyFlee.UpdateDistanceFromPlayer", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryMoveAccelTargetTowardsCentreLine;
    /// <summary>
    /// Function: TryMoveAccelTargetTowardsCentreLine
    /// </summary>
    public unsafe virtual void TryMoveAccelTargetTowardsCentreLine(float DeltaTime, out System.Numerics.Vector3 accelTo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryMoveAccelTargetTowardsCentreLine, "BmScript.RBMBehaviour_FireflyFlee.TryMoveAccelTargetTowardsCentreLine", this);
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out accelTo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(accelTo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        accelTo = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMovement;
    /// <summary>
    /// Function: UpdateMovement
    /// </summary>
    public unsafe virtual void UpdateMovement(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMovement, "BmScript.RBMBehaviour_FireflyFlee.UpdateMovement", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FFRefineRacingLine;
    /// <summary>
    /// Function: FFRefineRacingLine
    /// </summary>
    public unsafe virtual void FFRefineRacingLine(int NumIterations)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FFRefineRacingLine, "BmScript.RBMBehaviour_FireflyFlee.FFRefineRacingLine", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumIterations, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FFUpdateRacingLine;
    /// <summary>
    /// Function: FFUpdateRacingLine
    /// </summary>
    public unsafe virtual void FFUpdateRacingLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FFUpdateRacingLine, "BmScript.RBMBehaviour_FireflyFlee.FFUpdateRacingLine", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLinkStartToEnd;
    /// <summary>
    /// Function: GetLinkStartToEnd
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLinkStartToEnd(int Link, int EndPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLinkStartToEnd, "BmScript.RBMBehaviour_FireflyFlee.GetLinkStartToEnd", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLinkLength;
    /// <summary>
    /// Function: GetLinkLength
    /// </summary>
    public unsafe virtual float GetLinkLength(int Link)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLinkLength, "BmScript.RBMBehaviour_FireflyFlee.GetLinkLength", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLinkCentreLoc;
    /// <summary>
    /// Function: GetLinkCentreLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLinkCentreLoc(int Link)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLinkCentreLoc, "BmScript.RBMBehaviour_FireflyFlee.GetLinkCentreLoc", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPointLoc;
    /// <summary>
    /// Function: GetPointLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPointLoc(int Point)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPointLoc, "BmScript.RBMBehaviour_FireflyFlee.GetPointLoc", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPawnLocationOnRoad;
    /// <summary>
    /// Function: GetPawnLocationOnRoad
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPawnLocationOnRoad()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPawnLocationOnRoad, "BmScript.RBMBehaviour_FireflyFlee.GetPawnLocationOnRoad", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTimeAlongLineSegment;
    /// <summary>
    /// Function: GetTimeAlongLineSegment
    /// </summary>
    public unsafe virtual float GetTimeAlongLineSegment(System.Numerics.Vector3 LineStart, System.Numerics.Vector3 LineStartToEnd, System.Numerics.Vector3 TestPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTimeAlongLineSegment, "BmScript.RBMBehaviour_FireflyFlee.GetTimeAlongLineSegment", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineStartToEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRacingLineLocByDistanceAhead;
    /// <summary>
    /// Function: GetRacingLineLocByDistanceAhead
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRacingLineLocByDistanceAhead(float distanceAhead, bool bDrawDebug = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRacingLineLocByDistanceAhead, "BmScript.RBMBehaviour_FireflyFlee.GetRacingLineLocByDistanceAhead", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(distanceAhead, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRacingLineLocOnSpan;
    /// <summary>
    /// Function: GetRacingLineLocOnSpan
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRacingLineLocOnSpan(int routeSpan)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRacingLineLocOnSpan, "BmScript.RBMBehaviour_FireflyFlee.GetRacingLineLocOnSpan", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(routeSpan, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DrawRouteDebug;
    /// <summary>
    /// Function: DrawRouteDebug
    /// </summary>
    public unsafe virtual void DrawRouteDebug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DrawRouteDebug, "BmScript.RBMBehaviour_FireflyFlee.DrawRouteDebug", this);
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetClosestActiveLinkInRouteToFirefly;
    /// <summary>
    /// Function: GetClosestActiveLinkInRouteToFirefly
    /// </summary>
    public unsafe virtual int GetClosestActiveLinkInRouteToFirefly()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetClosestActiveLinkInRouteToFirefly, "BmScript.RBMBehaviour_FireflyFlee.GetClosestActiveLinkInRouteToFirefly", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDistFromLinkToFirefly;
    /// <summary>
    /// Function: GetDistFromLinkToFirefly
    /// </summary>
    public unsafe virtual float GetDistFromLinkToFirefly(int linkNumber)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDistFromLinkToFirefly, "BmScript.RBMBehaviour_FireflyFlee.GetDistFromLinkToFirefly", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(linkNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLocationAtTimeAlongLink;
    /// <summary>
    /// Function: GetLocationAtTimeAlongLink
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLocationAtTimeAlongLink(int Link, int LinkEndPoint, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLocationAtTimeAlongLink, "BmScript.RBMBehaviour_FireflyFlee.GetLocationAtTimeAlongLink", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkEndPoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddLinkToRoute;
    /// <summary>
    /// Function: AddLinkToRoute
    /// </summary>
    public unsafe virtual float AddLinkToRoute()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddLinkToRoute, "BmScript.RBMBehaviour_FireflyFlee.AddLinkToRoute", this);
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFutureLocationOnRoute;
    /// <summary>
    /// Function: GetFutureLocationOnRoute
    /// </summary>
    public unsafe virtual bool GetFutureLocationOnRoute(float distAhead, out System.Numerics.Vector3 futureLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFutureLocationOnRoute, "BmScript.RBMBehaviour_FireflyFlee.GetFutureLocationOnRoute", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(distAhead, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out futureLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(futureLoc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        futureLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRouteLengthReminaining;
    /// <summary>
    /// Function: GetRouteLengthReminaining
    /// </summary>
    public unsafe virtual float GetRouteLengthReminaining()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRouteLengthReminaining, "BmScript.RBMBehaviour_FireflyFlee.GetRouteLengthReminaining", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryLengthenRoute;
    /// <summary>
    /// Function: TryLengthenRoute
    /// </summary>
    public unsafe virtual void TryLengthenRoute()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryLengthenRoute, "BmScript.RBMBehaviour_FireflyFlee.TryLengthenRoute", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCurrentPositionOnRoute;
    /// <summary>
    /// Function: GetCurrentPositionOnRoute
    /// </summary>
    public unsafe virtual bool GetCurrentPositionOnRoute()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCurrentPositionOnRoute, "BmScript.RBMBehaviour_FireflyFlee.GetCurrentPositionOnRoute", this);
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SwitchToNextLinkOnRoute;
    /// <summary>
    /// Function: SwitchToNextLinkOnRoute
    /// </summary>
    public unsafe virtual bool SwitchToNextLinkOnRoute()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SwitchToNextLinkOnRoute, "BmScript.RBMBehaviour_FireflyFlee.SwitchToNextLinkOnRoute", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindFFLinkAndEndPoint;
    /// <summary>
    /// Function: FindFFLinkAndEndPoint
    /// </summary>
    public unsafe virtual bool FindFFLinkAndEndPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindFFLinkAndEndPoint, "BmScript.RBMBehaviour_FireflyFlee.FindFFLinkAndEndPoint", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitialiseRoute;
    /// <summary>
    /// Function: InitialiseRoute
    /// </summary>
    public unsafe virtual bool InitialiseRoute()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitialiseRoute, "BmScript.RBMBehaviour_FireflyFlee.InitialiseRoute", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnHUDOff;
    /// <summary>
    /// Function: TurnHUDOff
    /// </summary>
    public unsafe virtual void TurnHUDOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnHUDOff, "BmScript.RBMBehaviour_FireflyFlee.TurnHUDOff", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnHUDOn;
    /// <summary>
    /// Function: TurnHUDOn
    /// </summary>
    public unsafe virtual void TurnHUDOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnHUDOn, "BmScript.RBMBehaviour_FireflyFlee.TurnHUDOn", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnDeactivate, "BmScript.RBMBehaviour_FireflyFlee.OnDeactivate", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnActivate, "BmScript.RBMBehaviour_FireflyFlee.OnActivate", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyGrenadeDidDamage;
    /// <summary>
    /// Function: NotifyGrenadeDidDamage
    /// </summary>
    public unsafe override void NotifyGrenadeDidDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyGrenadeDidDamage, "BmScript.RBMBehaviour_FireflyFlee.NotifyGrenadeDidDamage", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerFFBark;
    /// <summary>
    /// Function: TriggerFFBark
    /// </summary>
    public unsafe override bool TriggerFFBark(BmSDK.FName eventFlagName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerFFBark, "BmScript.RBMBehaviour_FireflyFlee.TriggerFFBark", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eventFlagName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryTriggerDialogue;
    /// <summary>
    /// Function: TryTriggerDialogue
    /// </summary>
    public unsafe virtual bool TryTriggerDialogue(BmSDK.BmScript.RBMBehaviour_FireflyFlee.FFDialogueType DialogueType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryTriggerDialogue, "BmScript.RBMBehaviour_FireflyFlee.TryTriggerDialogue", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Struct: FdialogueTimingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FdialogueTimingInfo
    {
        /// <summary>
        /// FloatProperty: lastTriggeredTime
        /// </summary>
        public unsafe float lastTriggeredTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: minTimeBetweenTriggers
        /// </summary>
        public unsafe float minTimeBetweenTriggers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: EventFlag
        /// </summary>
        public unsafe BmSDK.FName EventFlag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: FFDialogueType
    /// </summary>
    public enum FFDialogueType : byte
    {
        eFFDialogueType_Ambient = 0,
        eFFDialogueType_LaunchedBomb = 1,
        eFFDialogueType_BombHit = 2,
        eFFDialogueType_BMClose = 3,
        eFFDialogueType_OutOfFuel = 4,
        eFFDialogueType_MAX = 5,
    }

    /// <summary>
    /// StructProperty: offsetFromRoad
    /// </summary>
    public unsafe ref System.Numerics.Vector3 offsetFromRoad
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 864);

    /// <summary>
    /// StructProperty: Restrictions
    /// </summary>
    public unsafe ref BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restrictions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(Ptr + 876);

    /// <summary>
    /// StructProperty: FallbackRestrictions
    /// </summary>
    public unsafe ref BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction FallbackRestrictions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(Ptr + 1044);

    /// <summary>
    /// StructProperty: RoadMoveLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RoadMoveLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1212);

    /// <summary>
    /// StructProperty: ActualMoveLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ActualMoveLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1224);

    /// <summary>
    /// StructProperty: PrevMoveLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevMoveLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1236);

    /// <summary>
    /// ObjectProperty: SavedThreat
    /// </summary>
    public unsafe BmSDK.Engine.Actor SavedThreat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ObjectProperty: RoadNetwork
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork RoadNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ObjectProperty: dummyRacingLineVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle dummyRacingLineVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: LookAheadDist
    /// </summary>
    public unsafe float LookAheadDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// ArrayProperty: Route
    /// </summary>
    public unsafe BmSDK.TArray<int> Route
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// ArrayProperty: PrevRoute
    /// </summary>
    public unsafe BmSDK.TArray<int> PrevRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// IntProperty: CurrentLink
    /// </summary>
    public unsafe int CurrentLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// IntProperty: CurrentPoint
    /// </summary>
    public unsafe int CurrentPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: TimeAlongCurrentLink
    /// </summary>
    public unsafe float TimeAlongCurrentLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// IntProperty: LookBackPoint
    /// </summary>
    public unsafe int LookBackPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// IntProperty: LookAheadPoint
    /// </summary>
    public unsafe int LookAheadPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// StructProperty: LookAheadLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LookAheadLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1328);

    /// <summary>
    /// FloatProperty: bobBasePeriod
    /// </summary>
    public unsafe float bobBasePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: bobPeriodVariance
    /// </summary>
    public unsafe float bobPeriodVariance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: bobBaseMagnitude
    /// </summary>
    public unsafe float bobBaseMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: bobMagnitudeVariance
    /// </summary>
    public unsafe float bobMagnitudeVariance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: bobRange
    /// </summary>
    public unsafe float bobRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: bobTimeToActivate
    /// </summary>
    public unsafe float bobTimeToActivate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// FloatProperty: timeInBobRange
    /// </summary>
    public unsafe float timeInBobRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// FloatProperty: bobCycleProportion
    /// </summary>
    public unsafe float bobCycleProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// FloatProperty: currentBobCyclePeriod
    /// </summary>
    public unsafe float currentBobCyclePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// FloatProperty: currentBobCycleMagnitude
    /// </summary>
    public unsafe float currentBobCycleMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// StructProperty: bobOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 bobOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1380);

    /// <summary>
    /// StructProperty: preTurnOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 preTurnOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1392);

    /// <summary>
    /// StructProperty: prevLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 prevLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1404);

    /// <summary>
    /// IntProperty: numRefinements_NewLink
    /// </summary>
    public unsafe int numRefinements_NewLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: numRefinements_EachFrame
    /// </summary>
    public unsafe int numRefinements_EachFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: DistToNextSpan
    /// </summary>
    public unsafe float DistToNextSpan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bUseVehLookAhead
    /// </summary>
    public unsafe bool bUseVehLookAhead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bDbgNoRemovePastRoute
    /// </summary>
    public unsafe bool bDbgNoRemovePastRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredOutOfFuelDialogue
    /// </summary>
    public unsafe bool bTriggeredOutOfFuelDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bSelectedOnWheel
    /// </summary>
    public unsafe bool bSelectedOnWheel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: vehLookAheadDist
    /// </summary>
    public unsafe float vehLookAheadDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// FloatProperty: rotLookAheadExtra
    /// </summary>
    public unsafe float rotLookAheadExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// FloatProperty: LookBehindDist
    /// </summary>
    public unsafe float LookBehindDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// IntProperty: currentLinkIndexInRoute
    /// </summary>
    public unsafe int currentLinkIndexInRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// IntProperty: accelToHistoryNum
    /// </summary>
    public unsafe int accelToHistoryNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// ArrayProperty: accelToHistory
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> accelToHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// FloatProperty: roadWidthProportionToUseMin
    /// </summary>
    public unsafe float roadWidthProportionToUseMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// FloatProperty: roadWidthProportionToUseMax
    /// </summary>
    public unsafe float roadWidthProportionToUseMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// IntProperty: prevRouteMaxLength
    /// </summary>
    public unsafe int prevRouteMaxLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// FloatProperty: distFromCurrentLink
    /// </summary>
    public unsafe float distFromCurrentLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: returnToCentreTolerance
    /// </summary>
    public unsafe float returnToCentreTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// FloatProperty: returnToCentreRate
    /// </summary>
    public unsafe float returnToCentreRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: timeSinceSpoke
    /// </summary>
    public unsafe float timeSinceSpoke
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenDialogue
    /// </summary>
    public unsafe float MinTimeBetweenDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: dialogueTypeTimes
    /// </summary>
    public InlineArray<BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo> dialogueTypeTimes => new(5, Ptr + 1500, 16, this);

    /// <summary>
    /// StructProperty: dialogueTypeTimes
    /// </summary>
    public unsafe ref BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo dialogueTypeTimes_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo>(Ptr + 1500);
    /// <summary>
    /// StructProperty: dialogueTypeTimes
    /// </summary>
    public unsafe ref BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo dialogueTypeTimes_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo>(Ptr + 1516);
    /// <summary>
    /// StructProperty: dialogueTypeTimes
    /// </summary>
    public unsafe ref BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo dialogueTypeTimes_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo>(Ptr + 1532);
    /// <summary>
    /// StructProperty: dialogueTypeTimes
    /// </summary>
    public unsafe ref BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo dialogueTypeTimes_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo>(Ptr + 1548);
    /// <summary>
    /// StructProperty: dialogueTypeTimes
    /// </summary>
    public unsafe ref BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo dialogueTypeTimes_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RBMBehaviour_FireflyFlee.FdialogueTimingInfo>(Ptr + 1564);

    /// <summary>
    /// IntProperty: distToBM
    /// </summary>
    public unsafe int distToBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// IntProperty: numNarrowSpans
    /// </summary>
    public unsafe int numNarrowSpans
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// IntProperty: numWideSpans
    /// </summary>
    public unsafe int numWideSpans
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// IntProperty: numNormalLengthSpans
    /// </summary>
    public unsafe int numNormalLengthSpans
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }
}
