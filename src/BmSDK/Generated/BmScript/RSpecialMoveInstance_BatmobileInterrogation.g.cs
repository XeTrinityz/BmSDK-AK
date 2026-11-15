#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_BatmobileInterrogation<br/>
/// (size = 1044)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_BatmobileInterrogation : BmSDK.BmGame.RSpecialMoveInstance_BatmobileInterrogationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_BatmobileInterrogation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_BatmobileInterrogation.
    /// </summary>
    public static RSpecialMoveInstance_BatmobileInterrogation DefaultObject => (RSpecialMoveInstance_BatmobileInterrogation)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_BatmobileInterrogation() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_BatmobileInterrogation
    /// </summary>
    public RSpecialMoveInstance_BatmobileInterrogation(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_BatmobileInterrogation(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_BatmobileInterrogation>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_BatmobileInterrogation>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_BatmobileInterrogation>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_BatmobileInterrogation>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_BatmobileInterrogation>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_BatmobileInterrogation>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_BatmobileInterrogation>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_BatmobileInterrogation>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHelpPrompt, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.GetHelpPrompt", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisallowPlayerMove, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.DisallowPlayerMove", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HandleAction, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.HandleAction", this);
        byte* paramsPtr = stackalloc byte[32];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CustomEvent, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.CustomEvent", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PutObjectInSafeLocation, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.PutObjectInSafeLocation", this);
        byte* paramsPtr = stackalloc byte[264];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNearestPointOnSegment, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.GetNearestPointOnSegment", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v0, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v1, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Clip, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAnimSequence;
    /// <summary>
    /// Function: GetAnimSequence
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetAnimSequence(BmSDK.FName AnimName, BmSDK.Engine.AnimSet SetToLookIn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAnimSequence, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.GetAnimSequence", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetToLookIn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSequence>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartLightingRig;
    /// <summary>
    /// Function: StartLightingRig
    /// </summary>
    public unsafe virtual void StartLightingRig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartLightingRig, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.StartLightingRig", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CancelSpecialMove, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.CancelSpecialMove", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeginSecondTransition, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.BeginSecondTransition", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AllowExitNotify;
    /// <summary>
    /// Function: AllowExitNotify
    /// </summary>
    public unsafe virtual void AllowExitNotify()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AllowExitNotify, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.AllowExitNotify", this);
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_KoThug, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.KoThug", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SafeToRestoreBatmobile;
    /// <summary>
    /// Function: SafeToRestoreBatmobile
    /// </summary>
    public unsafe virtual void SafeToRestoreBatmobile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SafeToRestoreBatmobile, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.SafeToRestoreBatmobile", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DropVocoder;
    /// <summary>
    /// Function: DropVocoder
    /// </summary>
    public unsafe virtual void DropVocoder()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DropVocoder, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.DropVocoder", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideVocoder2;
    /// <summary>
    /// Function: HideVocoder2
    /// </summary>
    public unsafe virtual void HideVocoder2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideVocoder2, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.HideVocoder2", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SwitchVocoder;
    /// <summary>
    /// Function: SwitchVocoder
    /// </summary>
    public unsafe virtual void SwitchVocoder()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SwitchVocoder, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.SwitchVocoder", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TakeVocoder;
    /// <summary>
    /// Function: TakeVocoder
    /// </summary>
    public unsafe virtual void TakeVocoder()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TakeVocoder, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.TakeVocoder", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetThingsThatNeedRemoving, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.GetThingsThatNeedRemoving", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TryRemoveDeadBodies, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.TryRemoveDeadBodies", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ActualRemoveDeadBodies;
    /// <summary>
    /// Function: ActualRemoveDeadBodies
    /// </summary>
    public unsafe virtual void ActualRemoveDeadBodies()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ActualRemoveDeadBodies, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.ActualRemoveDeadBodies", this);
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveDeadBodies, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.RemoveDeadBodies", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SafeToMoveBatmobile, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.SafeToMoveBatmobile", this);
        byte* paramsPtr = stackalloc byte[84];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisableCamCollision, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.DisableCamCollision", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EndRedHoodHud;
    /// <summary>
    /// Function: EndRedHoodHud
    /// </summary>
    public unsafe virtual void EndRedHoodHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EndRedHoodHud, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.EndRedHoodHud", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartRedHoodHud;
    /// <summary>
    /// Function: StartRedHoodHud
    /// </summary>
    public unsafe virtual void StartRedHoodHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartRedHoodHud, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.StartRedHoodHud", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FinishSpecialMove, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.FinishSpecialMove", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateSpecialMove;
    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe override bool UpdateSpecialMove(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateSpecialMove, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.UpdateSpecialMove", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PickTransitionInAnimationIndex;
    /// <summary>
    /// Function: PickTransitionInAnimationIndex
    /// </summary>
    public unsafe virtual void PickTransitionInAnimationIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PickTransitionInAnimationIndex, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.PickTransitionInAnimationIndex", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TestPossibleReferencePoints, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.TestPossibleReferencePoints", this);
        byte* paramsPtr = stackalloc byte[76];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FadeIn, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.FadeIn", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FadeOut, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.FadeOut", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TestForCut, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.TestForCut", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindAPC;
    /// <summary>
    /// Function: FindAPC
    /// </summary>
    public unsafe virtual void FindAPC()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindAPC, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.FindAPC", this);
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerSpecialMove, "BmScript.RSpecialMoveInstance_BatmobileInterrogation.TriggerSpecialMove", this);
        byte* paramsPtr = stackalloc byte[468];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: NumThreatensSoFar
    /// </summary>
    public unsafe int NumThreatensSoFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: Thug
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI Thug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: Matinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp Matinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: FakeBatmobile
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshActor FakeBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshActor>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ObjectProperty: Vocoder
    /// </summary>
    public unsafe BmSDK.BmGame.RKActorSpawnable Vocoder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RKActorSpawnable>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: VocoderPt2
    /// </summary>
    public unsafe BmSDK.BmGame.RKActorSpawnable VocoderPt2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RKActorSpawnable>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: Humvee
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC Humvee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bHasFinishedThrow
    /// </summary>
    public unsafe bool bHasFinishedThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCurrentlyThreatening
    /// </summary>
    public unsafe bool bCurrentlyThreatening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bInThreaten
    /// </summary>
    public unsafe bool bInThreaten
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bInThreatenOut
    /// </summary>
    public unsafe bool bInThreatenOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bIsSuccessfullThreaten
    /// </summary>
    public unsafe bool bIsSuccessfullThreaten
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bIsSuperSuccessfullThreaten
    /// </summary>
    public unsafe bool bIsSuperSuccessfullThreaten
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bThreatenAllowed
    /// </summary>
    public unsafe bool bThreatenAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bHasBegun
    /// </summary>
    public unsafe bool bHasBegun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bInCameraAlign
    /// </summary>
    public unsafe bool bInCameraAlign
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bHadToUseCut
    /// </summary>
    public unsafe bool bHadToUseCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bHoodDialogueOver
    /// </summary>
    public unsafe bool bHoodDialogueOver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bRevingEngine
    /// </summary>
    public unsafe bool bRevingEngine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanMoveCar
    /// </summary>
    public unsafe bool bCanMoveCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bRemoveDeadBodiesOnNextFrame
    /// </summary>
    public unsafe bool bRemoveDeadBodiesOnNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bMoveBatmobileOnNextFrame
    /// </summary>
    public unsafe bool bMoveBatmobileOnNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: CurrentThreatenTime
    /// </summary>
    public unsafe float CurrentThreatenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// StructProperty: ReferenceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ReferenceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 944);

    /// <summary>
    /// StructProperty: ReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 956);

    /// <summary>
    /// StructProperty: ThugReferenceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ThugReferenceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 968);

    /// <summary>
    /// StructProperty: ThugReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ThugReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 980);

    /// <summary>
    /// StructProperty: MoveStart
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 992);

    /// <summary>
    /// FloatProperty: LastFrameMatPos
    /// </summary>
    public unsafe float LastFrameMatPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: CameraAlignTime
    /// </summary>
    public unsafe float CameraAlignTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// StructProperty: SavedId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId SavedId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1012);

    /// <summary>
    /// IntProperty: PickedTransIn
    /// </summary>
    public unsafe int PickedTransIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: fadeTime
    /// </summary>
    public unsafe float fadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ArrayProperty: ListOfObjectsToCut
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ListOfObjectsToCut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// IntProperty: RoadLinkIndex
    /// </summary>
    public unsafe int RoadLinkIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
}
