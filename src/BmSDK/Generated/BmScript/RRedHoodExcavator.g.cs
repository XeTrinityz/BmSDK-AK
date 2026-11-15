#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRedHoodExcavator<br/>
/// (size = 2344)
/// (flags = 10486290)
/// </summary>
public partial class RRedHoodExcavator : BmSDK.BmGame.RRedHoodExcavatorBase, BmSDK.BmScript.RCarListenerInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRedHoodExcavator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRedHoodExcavator.
    /// </summary>
    public static RRedHoodExcavator DefaultObject => (RRedHoodExcavator)StaticClass().DefaultObject;

    internal RRedHoodExcavator() { }

    /// <summary>
    /// Constructs a new RRedHoodExcavator
    /// </summary>
    public RRedHoodExcavator(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRedHoodExcavator(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRedHoodExcavator>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRedHoodExcavator>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRedHoodExcavator>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRedHoodExcavator>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRedHoodExcavator>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRedHoodExcavator>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRedHoodExcavator>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRedHoodExcavator>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HitWall, "BmScript.RRedHoodExcavator.HitWall", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RigidBodyCollision, "BmScript.RRedHoodExcavator.RigidBodyCollision", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Bump, "BmScript.RRedHoodExcavator.Bump", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ApplyDamageToBm;
    /// <summary>
    /// Function: ApplyDamageToBm
    /// </summary>
    public unsafe virtual bool ApplyDamageToBm(System.Numerics.Vector3 HitLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ApplyDamageToBm, "BmScript.RRedHoodExcavator.ApplyDamageToBm", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopChaseCamForChase;
    /// <summary>
    /// Function: StopChaseCamForChase
    /// </summary>
    public unsafe virtual void StopChaseCamForChase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopChaseCamForChase, "BmScript.RRedHoodExcavator.StopChaseCamForChase", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Landed;
    /// <summary>
    /// Function: Landed
    /// </summary>
    public unsafe override void Landed(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor FloorActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Landed, "BmScript.RRedHoodExcavator.Landed", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloorActor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanScreenShake;
    /// <summary>
    /// Function: CanScreenShake
    /// </summary>
    public unsafe virtual bool CanScreenShake()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanScreenShake, "BmScript.RRedHoodExcavator.CanScreenShake", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateTracks;
    /// <summary>
    /// Function: UpdateTracks
    /// </summary>
    public unsafe virtual void UpdateTracks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateTracks, "BmScript.RRedHoodExcavator.UpdateTracks", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateChair;
    /// <summary>
    /// Function: UpdateChair
    /// </summary>
    public unsafe virtual void UpdateChair(float UpdateTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateChair, "BmScript.RRedHoodExcavator.UpdateChair", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayEngineRumble;
    /// <summary>
    /// Function: PlayEngineRumble
    /// </summary>
    public unsafe virtual void PlayEngineRumble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayEngineRumble, "BmScript.RRedHoodExcavator.PlayEngineRumble", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ExcavatorOnScreen;
    /// <summary>
    /// Function: ExcavatorOnScreen
    /// </summary>
    public unsafe virtual bool ExcavatorOnScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ExcavatorOnScreen, "BmScript.RRedHoodExcavator.ExcavatorOnScreen", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float UpdateTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Tick, "BmScript.RRedHoodExcavator.Tick", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BeginAnimControl;
    /// <summary>
    /// Function: BeginAnimControl
    /// </summary>
    public unsafe override void BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup, BmSDK.Engine.InterpGroupInst InInterpGroupInst)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeginAnimControl, "BmScript.RRedHoodExcavator.BeginAnimControl", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroupInst, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanAttachCamera;
    /// <summary>
    /// Function: CanAttachCamera
    /// </summary>
    public unsafe virtual bool CanAttachCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanAttachCamera, "BmScript.RRedHoodExcavator.CanAttachCamera", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Destroyed, "BmScript.RRedHoodExcavator.Destroyed", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetExcavatorDamageMesh;
    /// <summary>
    /// Function: SetExcavatorDamageMesh
    /// </summary>
    public unsafe virtual void SetExcavatorDamageMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetExcavatorDamageMesh, "BmScript.RRedHoodExcavator.SetExcavatorDamageMesh", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HeavyCannonSound;
    /// <summary>
    /// Function: HeavyCannonSound
    /// </summary>
    public unsafe virtual void HeavyCannonSound(System.Numerics.Vector3 HeavyCannonLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HeavyCannonSound, "BmScript.RRedHoodExcavator.HeavyCannonSound", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeavyCannonLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideExcavatorHull;
    /// <summary>
    /// Function: HideExcavatorHull
    /// </summary>
    public unsafe virtual void HideExcavatorHull()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideExcavatorHull, "BmScript.RRedHoodExcavator.HideExcavatorHull", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowExcavatorHull;
    /// <summary>
    /// Function: ShowExcavatorHull
    /// </summary>
    public unsafe override void ShowExcavatorHull()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowExcavatorHull, "BmScript.RRedHoodExcavator.ShowExcavatorHull", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateBatmobileDriveAssist;
    /// <summary>
    /// Function: UpdateBatmobileDriveAssist
    /// </summary>
    public unsafe virtual void UpdateBatmobileDriveAssist()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateBatmobileDriveAssist, "BmScript.RRedHoodExcavator.UpdateBatmobileDriveAssist", this);
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnableCameraCollision;
    /// <summary>
    /// Function: EnableCameraCollision
    /// </summary>
    public unsafe virtual void EnableCameraCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnableCameraCollision, "BmScript.RRedHoodExcavator.EnableCameraCollision", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForCameraAttach;
    /// <summary>
    /// Function: CheckForCameraAttach
    /// </summary>
    public unsafe virtual void CheckForCameraAttach()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForCameraAttach, "BmScript.RRedHoodExcavator.CheckForCameraAttach", this);
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayerInBonnectCam;
    /// <summary>
    /// Function: PlayerInBonnectCam
    /// </summary>
    public unsafe virtual bool PlayerInBonnectCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayerInBonnectCam, "BmScript.RRedHoodExcavator.PlayerInBonnectCam", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RunAwayHint;
    /// <summary>
    /// Function: RunAwayHint
    /// </summary>
    public unsafe virtual void RunAwayHint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RunAwayHint, "BmScript.RRedHoodExcavator.RunAwayHint", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceIntroCamera;
    /// <summary>
    /// Function: ForceIntroCamera
    /// </summary>
    public unsafe virtual void ForceIntroCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceIntroCamera, "BmScript.RRedHoodExcavator.ForceIntroCamera", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RestoreExcavatorCollision;
    /// <summary>
    /// Function: RestoreExcavatorCollision
    /// </summary>
    public unsafe virtual void RestoreExcavatorCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RestoreExcavatorCollision, "BmScript.RRedHoodExcavator.RestoreExcavatorCollision", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShrinkExcavatorCollision;
    /// <summary>
    /// Function: ShrinkExcavatorCollision
    /// </summary>
    public unsafe virtual void ShrinkExcavatorCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShrinkExcavatorCollision, "BmScript.RRedHoodExcavator.ShrinkExcavatorCollision", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSeismicLevel;
    /// <summary>
    /// Function: GetSeismicLevel
    /// </summary>
    public unsafe override float GetSeismicLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSeismicLevel, "BmScript.RRedHoodExcavator.GetSeismicLevel", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BatmanLeftCar;
    /// <summary>
    /// Function: BatmanLeftCar
    /// </summary>
    public unsafe virtual void BatmanLeftCar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BatmanLeftCar, "BmScript.RRedHoodExcavator.BatmanLeftCar", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsVisibleOnRadar;
    /// <summary>
    /// Function: IsVisibleOnRadar
    /// </summary>
    public unsafe override bool IsVisibleOnRadar(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsVisibleOnRadar, "BmScript.RRedHoodExcavator.IsVisibleOnRadar", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UseSpotLight;
    /// <summary>
    /// Function: UseSpotLight
    /// </summary>
    public unsafe virtual bool UseSpotLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UseSpotLight, "BmScript.RRedHoodExcavator.UseSpotLight", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateSpotLightBrightness;
    /// <summary>
    /// Function: UpdateSpotLightBrightness
    /// </summary>
    public unsafe virtual void UpdateSpotLightBrightness(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateSpotLightBrightness, "BmScript.RRedHoodExcavator.UpdateSpotLightBrightness", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanSweepLights;
    /// <summary>
    /// Function: CanSweepLights
    /// </summary>
    public unsafe virtual bool CanSweepLights()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanSweepLights, "BmScript.RRedHoodExcavator.CanSweepLights", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateLights;
    /// <summary>
    /// Function: UpdateLights
    /// </summary>
    public unsafe virtual void UpdateLights(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateLights, "BmScript.RRedHoodExcavator.UpdateLights", this);
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetChargeLights;
    /// <summary>
    /// Function: SetChargeLights
    /// </summary>
    public unsafe virtual void SetChargeLights(bool On)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetChargeLights, "BmScript.RRedHoodExcavator.SetChargeLights", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MatineeFinished;
    /// <summary>
    /// Function: MatineeFinished
    /// </summary>
    public unsafe virtual void MatineeFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MatineeFinished, "BmScript.RRedHoodExcavator.MatineeFinished", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartRedHood;
    /// <summary>
    /// Function: StartRedHood
    /// </summary>
    public unsafe virtual void StartRedHood()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartRedHood, "BmScript.RRedHoodExcavator.StartRedHood", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PostGeneratorRespawn;
    /// <summary>
    /// Function: PostGeneratorRespawn
    /// </summary>
    public unsafe virtual void PostGeneratorRespawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostGeneratorRespawn, "BmScript.RRedHoodExcavator.PostGeneratorRespawn", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HitGenerator;
    /// <summary>
    /// Function: HitGenerator
    /// </summary>
    public unsafe virtual void HitGenerator()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HitGenerator, "BmScript.RRedHoodExcavator.HitGenerator", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RestartMaze;
    /// <summary>
    /// Function: RestartMaze
    /// </summary>
    public unsafe virtual void RestartMaze()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RestartMaze, "BmScript.RRedHoodExcavator.RestartMaze", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HelpPlayer;
    /// <summary>
    /// Function: HelpPlayer
    /// </summary>
    public unsafe virtual void HelpPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HelpPlayer, "BmScript.RRedHoodExcavator.HelpPlayer", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AdvanceEnding;
    /// <summary>
    /// Function: AdvanceEnding
    /// </summary>
    public unsafe virtual void AdvanceEnding()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AdvanceEnding, "BmScript.RRedHoodExcavator.AdvanceEnding", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TurnOnLights;
    /// <summary>
    /// Function: TurnOnLights
    /// </summary>
    public unsafe virtual void TurnOnLights()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TurnOnLights, "BmScript.RRedHoodExcavator.TurnOnLights", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartEngine;
    /// <summary>
    /// Function: StartEngine
    /// </summary>
    public unsafe virtual void StartEngine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartEngine, "BmScript.RRedHoodExcavator.StartEngine", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TrappedMoveForward;
    /// <summary>
    /// Function: TrappedMoveForward
    /// </summary>
    public unsafe virtual void TrappedMoveForward()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TrappedMoveForward, "BmScript.RRedHoodExcavator.TrappedMoveForward", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartEnding;
    /// <summary>
    /// Function: StartEnding
    /// </summary>
    public unsafe virtual void StartEnding()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartEnding, "BmScript.RRedHoodExcavator.StartEnding", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartIntro;
    /// <summary>
    /// Function: StartIntro
    /// </summary>
    public unsafe virtual void StartIntro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartIntro, "BmScript.RRedHoodExcavator.StartIntro", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetFloorRotation;
    /// <summary>
    /// Function: SetFloorRotation
    /// </summary>
    public unsafe virtual void SetFloorRotation(float UpdateTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetFloorRotation, "BmScript.RRedHoodExcavator.SetFloorRotation", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ZeroOutFloorPitch;
    /// <summary>
    /// Function: ZeroOutFloorPitch
    /// </summary>
    public unsafe virtual bool ZeroOutFloorPitch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ZeroOutFloorPitch, "BmScript.RRedHoodExcavator.ZeroOutFloorPitch", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReconstructPath;
    /// <summary>
    /// Function: ReconstructPath
    /// </summary>
    public unsafe virtual void ReconstructPath(BmSDK.TArray<int> CameFrom, int CurrentIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReconstructPath, "BmScript.RRedHoodExcavator.ReconstructPath", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameFrom, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PathShorten;
    /// <summary>
    /// Function: PathShorten
    /// </summary>
    public unsafe virtual void PathShorten(System.Numerics.Vector3 StartPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PathShorten, "BmScript.RRedHoodExcavator.PathShorten", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindNearestNeighbour;
    /// <summary>
    /// Function: FindNearestNeighbour
    /// </summary>
    public unsafe virtual void FindNearestNeighbour(int CurrentPoint, int PreviousPoint, System.Numerics.Vector3 GoalPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindNearestNeighbour, "BmScript.RRedHoodExcavator.FindNearestNeighbour", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousPoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalPoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GeneratePathToPoint;
    /// <summary>
    /// Function: GeneratePathToPoint
    /// </summary>
    public unsafe virtual bool GeneratePathToPoint(System.Numerics.Vector3 Start, System.Numerics.Vector3 Goal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GeneratePathToPoint, "BmScript.RRedHoodExcavator.GeneratePathToPoint", this);
        byte* paramsPtr = stackalloc byte[192];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Goal, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NodeToNodeCostEstimate;
    /// <summary>
    /// Function: NodeToNodeCostEstimate
    /// </summary>
    public unsafe virtual float NodeToNodeCostEstimate(System.Numerics.Vector3 Start, System.Numerics.Vector3 Goal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NodeToNodeCostEstimate, "BmScript.RRedHoodExcavator.NodeToNodeCostEstimate", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Goal, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
    }

    /// <summary>
    /// StructProperty: CollisionCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CollisionCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1080);

    /// <summary>
    /// ObjectProperty: UpdateAction
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_UpdateExcavator UpdateAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_UpdateExcavator>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: Redhood
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnFriendly Redhood
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnFriendly>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: Generator
    /// </summary>
    public unsafe BmSDK.Engine.Volume Generator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: Generator1
    /// </summary>
    public unsafe BmSDK.Engine.Volume Generator1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ObjectProperty: Generator2
    /// </summary>
    public unsafe BmSDK.Engine.Volume Generator2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ObjectProperty: Generator3
    /// </summary>
    public unsafe BmSDK.Engine.Volume Generator3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ObjectProperty: GeneratorStart1
    /// </summary>
    public unsafe BmSDK.Engine.Volume GeneratorStart1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ObjectProperty: GeneratorStart2
    /// </summary>
    public unsafe BmSDK.Engine.Volume GeneratorStart2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ObjectProperty: GeneratorStart3
    /// </summary>
    public unsafe BmSDK.Engine.Volume GeneratorStart3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// ObjectProperty: Wall1
    /// </summary>
    public unsafe BmSDK.BmScript.RExcavatorTunnelWall Wall1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RExcavatorTunnelWall>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ObjectProperty: Wall2
    /// </summary>
    public unsafe BmSDK.BmScript.RExcavatorTunnelWall Wall2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RExcavatorTunnelWall>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// ObjectProperty: Wall3
    /// </summary>
    public unsafe BmSDK.BmScript.RExcavatorTunnelWall Wall3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RExcavatorTunnelWall>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ObjectProperty: SafePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor SafePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// ObjectProperty: MainMazeVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume MainMazeVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ObjectProperty: KilledByExcavator
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform KilledByExcavator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ObjectProperty: ExcavatorSearching
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ExcavatorSearching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ObjectProperty: ExcavatorChasing
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ExcavatorChasing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// ObjectProperty: ExcavatorIdling
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ExcavatorIdling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ObjectProperty: ReturnToMaze
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ReturnToMaze
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// ObjectProperty: FrontCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraActor FrontCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraActor>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ObjectProperty: BackCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraActor BackCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraActor>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ObjectProperty: CameraCollisionVol
    /// </summary>
    public unsafe BmSDK.Engine.Volume CameraCollisionVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// ObjectProperty: EndingActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor EndingActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// ObjectProperty: EndingStart
    /// </summary>
    public unsafe BmSDK.Engine.Actor EndingStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// ObjectProperty: EndingArea
    /// </summary>
    public unsafe BmSDK.Engine.Volume EndingArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ObjectProperty: EndingGrappleArea
    /// </summary>
    public unsafe BmSDK.Engine.Volume EndingGrappleArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel1AvoidArea
    /// </summary>
    public unsafe BmSDK.Engine.Volume SideTunnel1AvoidArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel2AvoidArea
    /// </summary>
    public unsafe BmSDK.Engine.Volume SideTunnel2AvoidArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel3AvoidArea
    /// </summary>
    public unsafe BmSDK.Engine.Volume SideTunnel3AvoidArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel1AvoidAreaShimdt
    /// </summary>
    public unsafe BmSDK.Engine.Volume SideTunnel1AvoidAreaShimdt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel2AvoidAreaShimdt
    /// </summary>
    public unsafe BmSDK.Engine.Volume SideTunnel2AvoidAreaShimdt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel3AvoidAreaShimdt
    /// </summary>
    public unsafe BmSDK.Engine.Volume SideTunnel3AvoidAreaShimdt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel1WaitArea
    /// </summary>
    public unsafe BmSDK.Engine.Actor SideTunnel1WaitArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel2WaitArea
    /// </summary>
    public unsafe BmSDK.Engine.Actor SideTunnel2WaitArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ObjectProperty: SideTunnel3WaitArea
    /// </summary>
    public unsafe BmSDK.Engine.Actor SideTunnel3WaitArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ObjectProperty: DebugStartLocator
    /// </summary>
    public unsafe BmSDK.Engine.Actor DebugStartLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ObjectProperty: DebugEndLocator
    /// </summary>
    public unsafe BmSDK.Engine.Actor DebugEndLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// ObjectProperty: Radar
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_BespokeTunnelRadar Radar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_BespokeTunnelRadar>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ObjectProperty: EngineIdleStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EngineIdleStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// ObjectProperty: EngineIdleEnd
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EngineIdleEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// ObjectProperty: EngineRunStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EngineRunStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// ObjectProperty: EngineRunEnd
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EngineRunEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// ObjectProperty: ChargeStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChargeStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// ObjectProperty: ChargeEnd
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChargeEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// ObjectProperty: BladesStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BladesStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// ObjectProperty: BladesEnd
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BladesEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileExplosionSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BatmobileExplosionSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ObjectProperty: VelocityParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName VelocityParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: LastVisitedPoint
    /// </summary>
    public unsafe int LastVisitedPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// IntProperty: NextPoint
    /// </summary>
    public unsafe int NextPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// StructProperty: RealGoal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RealGoal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1492);

    /// <summary>
    /// IntProperty: CurrentMovementPoint
    /// </summary>
    public unsafe int CurrentMovementPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// NameProperty: ChairBoneName
    /// </summary>
    public unsafe BmSDK.FName ChairBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// ArrayProperty: IntroPath
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> IntroPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// FloatProperty: IntroMaxSpeed
    /// </summary>
    public unsafe float IntroMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: IntroMinSpeed
    /// </summary>
    public unsafe float IntroMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: IntroMinDist
    /// </summary>
    public unsafe float IntroMinDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// FloatProperty: IntroMaxDist
    /// </summary>
    public unsafe float IntroMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: IntroMaxTurnSpeed
    /// </summary>
    public unsafe float IntroMaxTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// FloatProperty: IntroMinTurnSpeed
    /// </summary>
    public unsafe float IntroMinTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// FloatProperty: IntroAcceleration
    /// </summary>
    public unsafe float IntroAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenShotAtInIntro
    /// </summary>
    public unsafe bool bHasBeenShotAtInIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bForceIntroCamera
    /// </summary>
    public unsafe bool bForceIntroCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bOnWayToGeneratorChase
    /// </summary>
    public unsafe bool bOnWayToGeneratorChase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bForceRoutePastBM
    /// </summary>
    public unsafe bool bForceRoutePastBM
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bLastGoodRotationSet
    /// </summary>
    public unsafe bool bLastGoodRotationSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bInReverse
    /// </summary>
    public unsafe bool bInReverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bExcavatorHidden
    /// </summary>
    public unsafe bool bExcavatorHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bRespawnAfterGenRequest
    /// </summary>
    public unsafe bool bRespawnAfterGenRequest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDamageLethal
    /// </summary>
    public unsafe bool bDamageLethal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bChargeLightsOn
    /// </summary>
    public unsafe bool bChargeLightsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bWantsToRestartMaze
    /// </summary>
    public unsafe bool bWantsToRestartMaze
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bInChaseCam
    /// </summary>
    public unsafe bool bInChaseCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bNoChaseCam
    /// </summary>
    public unsafe bool bNoChaseCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bInEnding
    /// </summary>
    public unsafe bool bInEnding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: AlwaysShowOnRadar
    /// </summary>
    public unsafe bool AlwaysShowOnRadar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDontAlignFloor
    /// </summary>
    public unsafe bool bDontAlignFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bStartedEngine
    /// </summary>
    public unsafe bool bStartedEngine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bMovingForwardInTrappedIntro
    /// </summary>
    public unsafe bool bMovingForwardInTrappedIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bLightsOn
    /// </summary>
    public unsafe bool bLightsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bMovingForwardInEnding
    /// </summary>
    public unsafe bool bMovingForwardInEnding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bBatmanEscaped
    /// </summary>
    public unsafe bool bBatmanEscaped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDisableAllDamage
    /// </summary>
    public unsafe bool bDisableAllDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bBatmanDied
    /// </summary>
    public unsafe bool bBatmanDied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bPlayingChargeSfx
    /// </summary>
    public unsafe bool bPlayingChargeSfx
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bGlobalDisableCameraAttach
    /// </summary>
    public unsafe bool bGlobalDisableCameraAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bTurningLeft
    /// </summary>
    public unsafe bool bTurningLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bTurningRight
    /// </summary>
    public unsafe bool bTurningRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bNoRumble
    /// </summary>
    public unsafe bool bNoRumble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// FloatProperty: TimeTillWarnPlayerToRun
    /// </summary>
    public unsafe float TimeTillWarnPlayerToRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: DrillBitSpeed
    /// </summary>
    public unsafe float DrillBitSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: RequestedDrillBitSpeed
    /// </summary>
    public unsafe float RequestedDrillBitSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// ArrayProperty: ChasePath1
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ChasePath1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// ArrayProperty: ChasePath2
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ChasePath2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ArrayProperty: ChasePath3
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ChasePath3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// FloatProperty: AutoKillDistanceInChase
    /// </summary>
    public unsafe float AutoKillDistanceInChase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// IntProperty: CurrentGenerator
    /// </summary>
    public unsafe int CurrentGenerator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// FloatProperty: SearchingAcceleration
    /// </summary>
    public unsafe float SearchingAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// FloatProperty: FollowingAcceleration
    /// </summary>
    public unsafe float FollowingAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// FloatProperty: MaxSpeedSearching
    /// </summary>
    public unsafe float MaxSpeedSearching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }

    /// <summary>
    /// ArrayProperty: SearchPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SearchPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// FloatProperty: MinSearchDist
    /// </summary>
    public unsafe float MinSearchDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// FloatProperty: SearchingSightRange
    /// </summary>
    public unsafe float SearchingSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// ArrayProperty: CheatVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Volume> CheatVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// FloatProperty: HeavyCannonSearchDist
    /// </summary>
    public unsafe float HeavyCannonSearchDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// FloatProperty: SearchingTurnSpeed
    /// </summary>
    public unsafe float SearchingTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }

    /// <summary>
    /// FloatProperty: SearchingTurnSpeedOffscreen
    /// </summary>
    public unsafe float SearchingTurnSpeedOffscreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// FloatProperty: TimeTillMoreAggressiveSearching
    /// </summary>
    public unsafe float TimeTillMoreAggressiveSearching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// FloatProperty: TimeOfLastAggressiveSearch
    /// </summary>
    public unsafe float TimeOfLastAggressiveSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// FloatProperty: MaxSpeedFollowing
    /// </summary>
    public unsafe float MaxSpeedFollowing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// FloatProperty: MinSpeedFollowing
    /// </summary>
    public unsafe float MinSpeedFollowing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// FloatProperty: CloseDistForMinSpeed
    /// </summary>
    public unsafe float CloseDistForMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: FarDistForMaxSpeed
    /// </summary>
    public unsafe float FarDistForMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// FloatProperty: MinChaseTimeForFollow
    /// </summary>
    public unsafe float MinChaseTimeForFollow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: MinWaitTimeForFollow
    /// </summary>
    public unsafe float MinWaitTimeForFollow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// FloatProperty: LostBatmanFollowEndTime
    /// </summary>
    public unsafe float LostBatmanFollowEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// FloatProperty: TurnSpeed
    /// </summary>
    public unsafe float TurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// FloatProperty: TurnSpeedOffscreen
    /// </summary>
    public unsafe float TurnSpeedOffscreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// FloatProperty: SlowDownDistance
    /// </summary>
    public unsafe float SlowDownDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// FloatProperty: MinSpeedApproachingTurn
    /// </summary>
    public unsafe float MinSpeedApproachingTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// FloatProperty: CloseDistForTurn
    /// </summary>
    public unsafe float CloseDistForTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// FloatProperty: MazeMaxTurnSpeed
    /// </summary>
    public unsafe float MazeMaxTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// FloatProperty: TimeLostBatmanInFollow
    /// </summary>
    public unsafe float TimeLostBatmanInFollow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// FloatProperty: TimeInFollowBatman
    /// </summary>
    public unsafe float TimeInFollowBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// StructProperty: HeavyCannonSearchPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HeavyCannonSearchPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1764);

    /// <summary>
    /// StructProperty: LastSearchPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSearchPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1776);

    /// <summary>
    /// FloatProperty: CurrentSpeed
    /// </summary>
    public unsafe float CurrentSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// FloatProperty: RealForwardYaw
    /// </summary>
    public unsafe float RealForwardYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// StructProperty: LastGoodRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator LastGoodRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1796);

    /// <summary>
    /// FloatProperty: AlightRotSpeed
    /// </summary>
    public unsafe float AlightRotSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// FloatProperty: AlightHeightSpeed
    /// </summary>
    public unsafe float AlightHeightSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ByteProperty: MovementState
    /// </summary>
    public unsafe BmSDK.BmScript.RRedHoodExcavator.RedHoodMovementState MovementState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RRedHoodExcavator.RedHoodMovementState>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// StructProperty: SavedRotForCloseRange
    /// </summary>
    public unsafe ref BmSDK.Rotator SavedRotForCloseRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1820);

    /// <summary>
    /// FloatProperty: LastTurnDist
    /// </summary>
    public unsafe float LastTurnDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// FloatProperty: MaxSeismicDist
    /// </summary>
    public unsafe float MaxSeismicDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// FloatProperty: CurrentStateTime
    /// </summary>
    public unsafe float CurrentStateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: CloseToBmDist
    /// </summary>
    public unsafe float CloseToBmDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// FloatProperty: BmHitWaitTime
    /// </summary>
    public unsafe float BmHitWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// FloatProperty: BmHitWaitTimeCurrent
    /// </summary>
    public unsafe float BmHitWaitTimeCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// FloatProperty: TunnelWidth
    /// </summary>
    public unsafe float TunnelWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: BmDamage
    /// </summary>
    public unsafe float BmDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// StructProperty: SafeLightColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor SafeLightColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1868);

    /// <summary>
    /// StructProperty: ChargeLightColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor ChargeLightColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1872);

    /// <summary>
    /// StructProperty: SafeLightMatColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor SafeLightMatColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 1876);

    /// <summary>
    /// StructProperty: ChargeLightMatColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor ChargeLightMatColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 1892);

    /// <summary>
    /// FloatProperty: DPropDestroyDist
    /// </summary>
    public unsafe float DPropDestroyDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// NameProperty: FrontCameraSocket
    /// </summary>
    public unsafe BmSDK.FName FrontCameraSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// NameProperty: BackCameraSocket
    /// </summary>
    public unsafe BmSDK.FName BackCameraSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// FloatProperty: MaxChaseCamDist
    /// </summary>
    public unsafe float MaxChaseCamDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: MinChaseCamBatmanSpeed
    /// </summary>
    public unsafe float MinChaseCamBatmanSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// StructProperty: CameraRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1936);

    /// <summary>
    /// StructProperty: InitialCameraRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator InitialCameraRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1948);

    /// <summary>
    /// FloatProperty: CameraRotLerpValue
    /// </summary>
    public unsafe float CameraRotLerpValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// FloatProperty: CameraLocLerpValue
    /// </summary>
    public unsafe float CameraLocLerpValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// FloatProperty: CameraMaxDistFromBatmobile
    /// </summary>
    public unsafe float CameraMaxDistFromBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// FloatProperty: PitchChangeDistanceModifier
    /// </summary>
    public unsafe float PitchChangeDistanceModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// FloatProperty: PitchChangeByZDiff
    /// </summary>
    public unsafe float PitchChangeByZDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// FloatProperty: PitchChangeByDistDiff
    /// </summary>
    public unsafe float PitchChangeByDistDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// StructProperty: SavedCameraRotFront
    /// </summary>
    public unsafe ref BmSDK.Rotator SavedCameraRotFront
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1984);

    /// <summary>
    /// StructProperty: SavedCameraRotBack
    /// </summary>
    public unsafe ref BmSDK.Rotator SavedCameraRotBack
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1996);

    /// <summary>
    /// IntProperty: EndPointIndex
    /// </summary>
    public unsafe int EndPointIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// IntProperty: EndPointPrevIndex
    /// </summary>
    public unsafe int EndPointPrevIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// FloatProperty: EndingSpeed
    /// </summary>
    public unsafe float EndingSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// IntProperty: SavedEndingTunnelWallIndex
    /// </summary>
    public unsafe int SavedEndingTunnelWallIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// FloatProperty: BMHitMomentum
    /// </summary>
    public unsafe float BMHitMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// FloatProperty: TrappedIntroSpeed
    /// </summary>
    public unsafe float TrappedIntroSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// StructProperty: SavedTrappedRot
    /// </summary>
    public unsafe ref BmSDK.Rotator SavedTrappedRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2032);

    /// <summary>
    /// FloatProperty: BatmobileSparkDist
    /// </summary>
    public unsafe float BatmobileSparkDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// FloatProperty: SparkTimeBetween
    /// </summary>
    public unsafe float SparkTimeBetween
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// FloatProperty: LastSparkTime
    /// </summary>
    public unsafe float LastSparkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// StructProperty: DebugAdjustRot
    /// </summary>
    public unsafe ref BmSDK.Rotator DebugAdjustRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2056);

    /// <summary>
    /// StructProperty: DebugPosAdjust
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DebugPosAdjust
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2068);

    /// <summary>
    /// FloatProperty: RadarVisibilityDistance
    /// </summary>
    public unsafe float RadarVisibilityDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// StructProperty: ProximityScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ProximityScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2084);

    /// <summary>
    /// FloatProperty: ProximityShakeDistanceMod
    /// </summary>
    public unsafe float ProximityShakeDistanceMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// FloatProperty: ProximityShakeMultiplierMod
    /// </summary>
    public unsafe float ProximityShakeMultiplierMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileExplosionSFXArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> BatmobileExplosionSFXArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// StructProperty: OldVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OldVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2264);

    /// <summary>
    /// IntProperty: LightXSweep
    /// </summary>
    public unsafe int LightXSweep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// IntProperty: LightYSweep
    /// </summary>
    public unsafe int LightYSweep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// IntProperty: LightYReducation
    /// </summary>
    public unsafe int LightYReducation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// NameProperty: LeftTrackName
    /// </summary>
    public unsafe BmSDK.FName LeftTrackName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// NameProperty: LeftCogName
    /// </summary>
    public unsafe BmSDK.FName LeftCogName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// NameProperty: RightTrackName
    /// </summary>
    public unsafe BmSDK.FName RightTrackName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// NameProperty: RightCogName
    /// </summary>
    public unsafe BmSDK.FName RightCogName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// FloatProperty: SpeedToTrackMul
    /// </summary>
    public unsafe float SpeedToTrackMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// FloatProperty: TurnToTrackMul
    /// </summary>
    public unsafe float TurnToTrackMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// FloatProperty: SavedTurnSpeed
    /// </summary>
    public unsafe float SavedTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// FloatProperty: ChairTimer
    /// </summary>
    public unsafe float ChairTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// FloatProperty: TimeOnScreen
    /// </summary>
    public unsafe float TimeOnScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// FloatProperty: SpotLightLerpVal
    /// </summary>
    public unsafe float SpotLightLerpVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// Enum: RedHoodMovementState
    /// </summary>
    public enum RedHoodMovementState : byte
    {
        RHMS_Normal = 0,
        RHMS_TurnStart = 1,
        RHMS_Turning = 2,
        RHMS_Stopped = 3,
        RHMS_MAX = 4,
    }
}
