#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_InterrogateThugInOverworld<br/>
/// (size = 988)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_InterrogateThugInOverworld : BmSDK.BmGame.RSpecialMoveInstance_BatmobileInterrogationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_InterrogateThugInOverworld.
    /// </summary>
    public static RSpecialMoveInstance_InterrogateThugInOverworld DefaultObject => (RSpecialMoveInstance_InterrogateThugInOverworld)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_InterrogateThugInOverworld() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_InterrogateThugInOverworld
    /// </summary>
    public RSpecialMoveInstance_InterrogateThugInOverworld(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_InterrogateThugInOverworld(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_InterrogateThugInOverworld>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_InterrogateThugInOverworld>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_InterrogateThugInOverworld>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_InterrogateThugInOverworld>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_InterrogateThugInOverworld>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_InterrogateThugInOverworld>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_InterrogateThugInOverworld>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_InterrogateThugInOverworld>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHelpPrompt, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.GetHelpPrompt", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisallowPlayerMove;
    /// <summary>
    /// Function: DisallowPlayerMove
    /// </summary>
    public unsafe override bool DisallowPlayerMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisallowPlayerMove, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.DisallowPlayerMove", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HandleAction;
    /// <summary>
    /// Function: HandleAction
    /// </summary>
    public unsafe override void HandleAction(BmSDK.FName actionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HandleAction, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.HandleAction", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CustomEvent;
    /// <summary>
    /// Function: CustomEvent
    /// </summary>
    public unsafe override void CustomEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CustomEvent, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.CustomEvent", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PutBatmobileInSafeLocation;
    /// <summary>
    /// Function: PutBatmobileInSafeLocation
    /// </summary>
    public unsafe virtual void PutBatmobileInSafeLocation(System.Numerics.Vector3 TestPosition, BmSDK.Rotator TestRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PutBatmobileInSafeLocation, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.PutBatmobileInSafeLocation", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PutHumveeInSafeLocation;
    /// <summary>
    /// Function: PutHumveeInSafeLocation
    /// </summary>
    public unsafe virtual void PutHumveeInSafeLocation(System.Numerics.Vector3 TestPosition, BmSDK.Rotator TestRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PutHumveeInSafeLocation, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.PutHumveeInSafeLocation", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PutObjectInSafeLocation;
    /// <summary>
    /// Function: PutObjectInSafeLocation
    /// </summary>
    public unsafe virtual void PutObjectInSafeLocation(System.Numerics.Vector3 TestPosition, BmSDK.Rotator TestRotation, bool bToLeft, BmSDK.Engine.Actor ThisObject, out System.Numerics.Vector3 OutVec, out BmSDK.Rotator OutRot, float DistAway)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PutObjectInSafeLocation, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.PutObjectInSafeLocation", this);
        byte* paramsPtr = stackalloc byte[248];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bToLeft, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisObject, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutVec);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutVec, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRot, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistAway, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutVec = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        OutRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 48);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNearestPointOnSegment;
    /// <summary>
    /// Function: GetNearestPointOnSegment
    /// </summary>
    public unsafe virtual float GetNearestPointOnSegment(System.Numerics.Vector3 pt, System.Numerics.Vector3 v0, System.Numerics.Vector3 v1, bool Clip = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNearestPointOnSegment, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.GetNearestPointOnSegment", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v0, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v1, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Clip, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanSetRadioMode;
    /// <summary>
    /// Function: CanSetRadioMode
    /// </summary>
    public unsafe override bool CanSetRadioMode(BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue act)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanSetRadioMode, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.CanSetRadioMode", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(act, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RealignToFloor;
    /// <summary>
    /// Function: RealignToFloor
    /// </summary>
    public unsafe virtual void RealignToFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RealignToFloor, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.RealignToFloor", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAnimSequence;
    /// <summary>
    /// Function: GetAnimSequence
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetAnimSequence(BmSDK.FName AnimName, BmSDK.Engine.AnimSet SetToLookIn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAnimSequence, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.GetAnimSequence", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetToLookIn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSequence>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CancelSpecialMove, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.CancelSpecialMove", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BeginSecondTransition;
    /// <summary>
    /// Function: BeginSecondTransition
    /// </summary>
    public unsafe virtual void BeginSecondTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeginSecondTransition, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.BeginSecondTransition", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_KoThug;
    /// <summary>
    /// Function: KoThug
    /// </summary>
    public unsafe virtual void KoThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_KoThug, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.KoThug", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetThingsThatNeedRemoving;
    /// <summary>
    /// Function: GetThingsThatNeedRemoving
    /// </summary>
    public unsafe virtual void GetThingsThatNeedRemoving()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetThingsThatNeedRemoving, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.GetThingsThatNeedRemoving", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TryRemoveDeadBodies;
    /// <summary>
    /// Function: TryRemoveDeadBodies
    /// </summary>
    public unsafe virtual void TryRemoveDeadBodies()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryRemoveDeadBodies, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.TryRemoveDeadBodies", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLastRenderTime;
    /// <summary>
    /// Function: GetLastRenderTime
    /// </summary>
    public unsafe virtual float GetLastRenderTime(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLastRenderTime, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.GetLastRenderTime", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ActualRemoveDeadBodies;
    /// <summary>
    /// Function: ActualRemoveDeadBodies
    /// </summary>
    public unsafe virtual void ActualRemoveDeadBodies()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ActualRemoveDeadBodies, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.ActualRemoveDeadBodies", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RemoveDeadBodies;
    /// <summary>
    /// Function: RemoveDeadBodies
    /// </summary>
    public unsafe virtual void RemoveDeadBodies()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveDeadBodies, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.RemoveDeadBodies", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldMoveBatmobile;
    /// <summary>
    /// Function: ShouldMoveBatmobile
    /// </summary>
    public unsafe virtual bool ShouldMoveBatmobile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldMoveBatmobile, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.ShouldMoveBatmobile", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldMoveHumvee;
    /// <summary>
    /// Function: ShouldMoveHumvee
    /// </summary>
    public unsafe virtual bool ShouldMoveHumvee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldMoveHumvee, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.ShouldMoveHumvee", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ActualSafeToMoveBatmobile;
    /// <summary>
    /// Function: ActualSafeToMoveBatmobile
    /// </summary>
    public unsafe virtual void ActualSafeToMoveBatmobile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ActualSafeToMoveBatmobile, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.ActualSafeToMoveBatmobile", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SafeToMoveBatmobile;
    /// <summary>
    /// Function: SafeToMoveBatmobile
    /// </summary>
    public unsafe virtual void SafeToMoveBatmobile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SafeToMoveBatmobile, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.SafeToMoveBatmobile", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FinishSpecialMove, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.FinishSpecialMove", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PickTransitionInAnimationIndex;
    /// <summary>
    /// Function: PickTransitionInAnimationIndex
    /// </summary>
    public unsafe virtual void PickTransitionInAnimationIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PickTransitionInAnimationIndex, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.PickTransitionInAnimationIndex", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TestPossibleReferencePoints;
    /// <summary>
    /// Function: TestPossibleReferencePoints
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 TestPossibleReferencePoints(BmSDK.TArray<System.Numerics.Vector3> PossibleRefPoints)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TestPossibleReferencePoints, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.TestPossibleReferencePoints", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PossibleRefPoints, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FadeIn;
    /// <summary>
    /// Function: FadeIn
    /// </summary>
    public unsafe virtual void FadeIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FadeIn, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.FadeIn", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FadeOut;
    /// <summary>
    /// Function: FadeOut
    /// </summary>
    public unsafe virtual void FadeOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FadeOut, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.FadeOut", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EndXray;
    /// <summary>
    /// Function: EndXray
    /// </summary>
    public unsafe virtual void EndXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EndXray, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.EndXray", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GotoXray;
    /// <summary>
    /// Function: GotoXray
    /// </summary>
    public unsafe virtual void GotoXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GotoXray, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.GotoXray", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TestForCut;
    /// <summary>
    /// Function: TestForCut
    /// </summary>
    public unsafe virtual bool TestForCut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TestForCut, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.TestForCut", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindHumvee;
    /// <summary>
    /// Function: FindHumvee
    /// </summary>
    public unsafe virtual void FindHumvee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindHumvee, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.FindHumvee", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisableCamCollision;
    /// <summary>
    /// Function: DisableCamCollision
    /// </summary>
    public unsafe virtual void DisableCamCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisableCamCollision, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.DisableCamCollision", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerSpecialMove, "BmScript.RSpecialMoveInstance_InterrogateThugInOverworld.TriggerSpecialMove", this);
        byte* paramsPtr = stackalloc byte[468];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Thug
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI Thug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: MovieUI
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieKismetNoInput MovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieKismetNoInput>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: Humvee
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC Humvee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// StructProperty: ReferenceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ReferenceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 900);

    /// <summary>
    /// StructProperty: ReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 912);

    /// <summary>
    /// StructProperty: ThugReferenceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ThugReferenceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);

    /// <summary>
    /// StructProperty: ThugReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ThugReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 936);

    /// <summary>
    /// BoolProperty: bInCameraAlign
    /// </summary>
    public unsafe bool bInCameraAlign
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bHadToUseCut
    /// </summary>
    public unsafe bool bHadToUseCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDialogueOver
    /// </summary>
    public unsafe bool bDialogueOver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bMovedHumvee
    /// </summary>
    public unsafe bool bMovedHumvee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bMovedBatmobile
    /// </summary>
    public unsafe bool bMovedBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bRemoveDeadBodiesOnNextFrame
    /// </summary>
    public unsafe bool bRemoveDeadBodiesOnNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bMoveBatmobileOnNextFrame
    /// </summary>
    public unsafe bool bMoveBatmobileOnNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: CameraAlignTime
    /// </summary>
    public unsafe float CameraAlignTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// StructProperty: SavedId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId SavedId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 956);

    /// <summary>
    /// IntProperty: PickedTransIn
    /// </summary>
    public unsafe int PickedTransIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: fadeTime
    /// </summary>
    public unsafe float fadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: ListOfObjectsToCut
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ListOfObjectsToCut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// IntProperty: RoadLinkIndex
    /// </summary>
    public unsafe int RoadLinkIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
}
