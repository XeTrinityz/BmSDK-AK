#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_HatterBrainGame<br/>
/// (size = 1600)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_HatterBrainGame : BmSDK.BmGame.RSpecialMovieInstance_MinigameBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_HatterBrainGame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_HatterBrainGame.
    /// </summary>
    public static RSpecialMoveInstance_HatterBrainGame DefaultObject => (RSpecialMoveInstance_HatterBrainGame)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_HatterBrainGame() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_HatterBrainGame
    /// </summary>
    public RSpecialMoveInstance_HatterBrainGame(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_HatterBrainGame(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HatterBrainGame>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HatterBrainGame>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HatterBrainGame>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HatterBrainGame>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HatterBrainGame>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HatterBrainGame>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HatterBrainGame>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HatterBrainGame>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Const: NUM_SIDES = 2
    /// </summary>
    public const int NUM_SIDES = 2;

    /// <summary>
    /// Const: NUM_NODES_PER_SIDE = 5
    /// </summary>
    public const int NUM_NODES_PER_SIDE = 5;

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindDistanceFromPointToLine;
    /// <summary>
    /// Function: FindDistanceFromPointToLine
    /// </summary>
    public unsafe override float FindDistanceFromPointToLine(float nodePointX, float nodePointY, float laserPointX, float laserPointY, float laser_angle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindDistanceFromPointToLine, "BmScript.RSpecialMoveInstance_HatterBrainGame.FindDistanceFromPointToLine", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laser_angle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetEndControllerState;
    /// <summary>
    /// Function: GetEndControllerState
    /// </summary>
    public unsafe override BmSDK.FName GetEndControllerState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetEndControllerState, "BmScript.RSpecialMoveInstance_HatterBrainGame.GetEndControllerState", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetTimerParam;
    /// <summary>
    /// Function: SetTimerParam
    /// </summary>
    public unsafe virtual void SetTimerParam(float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetTimerParam, "BmScript.RSpecialMoveInstance_HatterBrainGame.SetTimerParam", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateDifficulty;
    /// <summary>
    /// Function: UpdateDifficulty
    /// </summary>
    public unsafe virtual void UpdateDifficulty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateDifficulty, "BmScript.RSpecialMoveInstance_HatterBrainGame.UpdateDifficulty", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResonatorLookAt;
    /// <summary>
    /// Function: ResonatorLookAt
    /// </summary>
    public unsafe virtual void ResonatorLookAt(System.Numerics.Vector3 LookAt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResonatorLookAt, "BmScript.RSpecialMoveInstance_HatterBrainGame.ResonatorLookAt", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RemoveResonator;
    /// <summary>
    /// Function: RemoveResonator
    /// </summary>
    public unsafe virtual void RemoveResonator()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveResonator, "BmScript.RSpecialMoveInstance_HatterBrainGame.RemoveResonator", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PowerOffScreen;
    /// <summary>
    /// Function: PowerOffScreen
    /// </summary>
    public unsafe virtual void PowerOffScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PowerOffScreen, "BmScript.RSpecialMoveInstance_HatterBrainGame.PowerOffScreen", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BlendOutCinematicCamera;
    /// <summary>
    /// Function: BlendOutCinematicCamera
    /// </summary>
    public unsafe virtual void BlendOutCinematicCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BlendOutCinematicCamera, "BmScript.RSpecialMoveInstance_HatterBrainGame.BlendOutCinematicCamera", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FinishSpecialMove, "BmScript.RSpecialMoveInstance_HatterBrainGame.FinishSpecialMove", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayGadgetInAnim;
    /// <summary>
    /// Function: PlayGadgetInAnim
    /// </summary>
    public unsafe virtual void PlayGadgetInAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayGadgetInAnim, "BmScript.RSpecialMoveInstance_HatterBrainGame.PlayGadgetInAnim", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SuccessfullActivateDisruptor;
    /// <summary>
    /// Function: SuccessfullActivateDisruptor
    /// </summary>
    public unsafe virtual void SuccessfullActivateDisruptor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SuccessfullActivateDisruptor, "BmScript.RSpecialMoveInstance_HatterBrainGame.SuccessfullActivateDisruptor", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetRumble;
    /// <summary>
    /// Function: SetRumble
    /// </summary>
    public unsafe virtual void SetRumble(float left_rumble, float right_rumble)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetRumble, "BmScript.RSpecialMoveInstance_HatterBrainGame.SetRumble", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_rumble, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_rumble, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateSpecialMove, "BmScript.RSpecialMoveInstance_HatterBrainGame.UpdateSpecialMove", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetFlashAngles;
    /// <summary>
    /// Function: SetFlashAngles
    /// </summary>
    public unsafe virtual void SetFlashAngles(float ang_left, float ang_right)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetFlashAngles, "BmScript.RSpecialMoveInstance_HatterBrainGame.SetFlashAngles", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ang_left, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ang_right, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EndXray, "BmScript.RSpecialMoveInstance_HatterBrainGame.EndXray", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartXray;
    /// <summary>
    /// Function: StartXray
    /// </summary>
    public unsafe virtual void StartXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartXray, "BmScript.RSpecialMoveInstance_HatterBrainGame.StartXray", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerSpecialMove, "BmScript.RSpecialMoveInstance_HatterBrainGame.TriggerSpecialMove", this);
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetLaserPositionAndAngle;
    /// <summary>
    /// Function: SetLaserPositionAndAngle
    /// </summary>
    public unsafe override void SetLaserPositionAndAngle(int side_index, float fDollyX, float fDollyY, float fAngleToFocus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetLaserPositionAndAngle, "BmScript.RSpecialMoveInstance_HatterBrainGame.SetLaserPositionAndAngle", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fAngleToFocus, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoGameOver;
    /// <summary>
    /// Function: DoGameOver
    /// </summary>
    public unsafe override void DoGameOver(bool did_player_win)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoGameOver, "BmScript.RSpecialMoveInstance_HatterBrainGame.DoGameOver", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(did_player_win, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetNodeState;
    /// <summary>
    /// Function: SetNodeState
    /// </summary>
    public unsafe override void SetNodeState(int side_index, int node_index, int iState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetNodeState, "BmScript.RSpecialMoveInstance_HatterBrainGame.SetNodeState", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iState, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetBeamIntersectNodes;
    /// <summary>
    /// Function: SetBeamIntersectNodes
    /// </summary>
    public unsafe override void SetBeamIntersectNodes(int leftIndex, int rightIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetBeamIntersectNodes, "BmScript.RSpecialMoveInstance_HatterBrainGame.SetBeamIntersectNodes", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(leftIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rightIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindAndSetBeamIntersectNodes;
    /// <summary>
    /// Function: FindAndSetBeamIntersectNodes
    /// </summary>
    public unsafe virtual void FindAndSetBeamIntersectNodes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindAndSetBeamIntersectNodes, "BmScript.RSpecialMoveInstance_HatterBrainGame.FindAndSetBeamIntersectNodes", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetupMadHatterMinigame;
    /// <summary>
    /// Function: SetupMadHatterMinigame
    /// </summary>
    public unsafe override void SetupMadHatterMinigame(float fHitArea, float fProportion, float fLaserSpeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetupMadHatterMinigame, "BmScript.RSpecialMoveInstance_HatterBrainGame.SetupMadHatterMinigame", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fHitArea, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fProportion, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fLaserSpeed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetCurveData;
    /// <summary>
    /// Function: SetCurveData
    /// </summary>
    public unsafe override void SetCurveData(float CurveAngleRange, float CurveAngleMin, float CurveAngleMax, float CurveRadiusHorz, float CurveRadiusVert, float CurveCentreX, float CurveCentreY, float CurveFocusX, float CurveFocusY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetCurveData, "BmScript.RSpecialMoveInstance_HatterBrainGame.SetCurveData", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleRange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleMin, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleMax, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveRadiusHorz, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveRadiusVert, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveCentreX, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveCentreY, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveFocusX, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveFocusY, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TickIntersect;
    /// <summary>
    /// Function: TickIntersect
    /// </summary>
    public unsafe override void TickIntersect(BmSDK.TArray<int> aNodesLeft, BmSDK.TArray<int> aNodesRight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TickIntersect, "BmScript.RSpecialMoveInstance_HatterBrainGame.TickIntersect", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesRight, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInteruptable;
    /// <summary>
    /// Function: IsInteruptable
    /// </summary>
    public unsafe override bool IsInteruptable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInteruptable, "BmScript.RSpecialMoveInstance_HatterBrainGame.IsInteruptable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopLoopingSounds;
    /// <summary>
    /// Function: StopLoopingSounds
    /// </summary>
    public unsafe virtual void StopLoopingSounds()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopLoopingSounds, "BmScript.RSpecialMoveInstance_HatterBrainGame.StopLoopingSounds", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopRightStickSound;
    /// <summary>
    /// Function: StopRightStickSound
    /// </summary>
    public unsafe virtual void StopRightStickSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopRightStickSound, "BmScript.RSpecialMoveInstance_HatterBrainGame.StopRightStickSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartRightStickSound;
    /// <summary>
    /// Function: StartRightStickSound
    /// </summary>
    public unsafe virtual void StartRightStickSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartRightStickSound, "BmScript.RSpecialMoveInstance_HatterBrainGame.StartRightStickSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopLeftStickSound;
    /// <summary>
    /// Function: StopLeftStickSound
    /// </summary>
    public unsafe virtual void StopLeftStickSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopLeftStickSound, "BmScript.RSpecialMoveInstance_HatterBrainGame.StopLeftStickSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartLeftStickSound;
    /// <summary>
    /// Function: StartLeftStickSound
    /// </summary>
    public unsafe virtual void StartLeftStickSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartLeftStickSound, "BmScript.RSpecialMoveInstance_HatterBrainGame.StartLeftStickSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartTargetLostSound;
    /// <summary>
    /// Function: StartTargetLostSound
    /// </summary>
    public unsafe virtual void StartTargetLostSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartTargetLostSound, "BmScript.RSpecialMoveInstance_HatterBrainGame.StartTargetLostSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartHighlightSound;
    /// <summary>
    /// Function: StartHighlightSound
    /// </summary>
    public unsafe virtual void StartHighlightSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartHighlightSound, "BmScript.RSpecialMoveInstance_HatterBrainGame.StartHighlightSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ActiveNodeChanges;
    /// <summary>
    /// Function: ActiveNodeChanges
    /// </summary>
    public unsafe virtual void ActiveNodeChanges(int side_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ActiveNodeChanges, "BmScript.RSpecialMoveInstance_HatterBrainGame.ActiveNodeChanges", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StickOnOrOffTarget;
    /// <summary>
    /// Function: StickOnOrOffTarget
    /// </summary>
    public unsafe virtual void StickOnOrOffTarget(int stick_index, bool is_on_target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StickOnOrOffTarget, "BmScript.RSpecialMoveInstance_HatterBrainGame.StickOnOrOffTarget", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stick_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_on_target, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StickStartsOrStopsMoving;
    /// <summary>
    /// Function: StickStartsOrStopsMoving
    /// </summary>
    public unsafe override void StickStartsOrStopsMoving(int stick_index, bool is_moving)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StickStartsOrStopsMoving, "BmScript.RSpecialMoveInstance_HatterBrainGame.StickStartsOrStopsMoving", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stick_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_moving, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_MiniGameBarProportion;
    /// <summary>
    /// Function: MiniGameBarProportion
    /// </summary>
    public unsafe override void MiniGameBarProportion(float barProportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_MiniGameBarProportion, "BmScript.RSpecialMoveInstance_HatterBrainGame.MiniGameBarProportion", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(barProportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckForStateChange;
    /// <summary>
    /// Function: CheckForStateChange
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.ENodeState CheckForStateChange(int sideIndex, int NodeIndex, bool bLaserOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckForStateChange, "BmScript.RSpecialMoveInstance_HatterBrainGame.CheckForStateChange", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sideIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NodeIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLaserOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.ENodeState>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoesNodeContributeToScore;
    /// <summary>
    /// Function: DoesNodeContributeToScore
    /// </summary>
    public unsafe virtual bool DoesNodeContributeToScore(BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo inNodeInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoesNodeContributeToScore, "BmScript.RSpecialMoveInstance_HatterBrainGame.DoesNodeContributeToScore", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inNodeInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanAnyNodesBlockBeam;
    /// <summary>
    /// Function: CanAnyNodesBlockBeam
    /// </summary>
    public unsafe virtual bool CanAnyNodesBlockBeam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanAnyNodesBlockBeam, "BmScript.RSpecialMoveInstance_HatterBrainGame.CanAnyNodesBlockBeam", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanNodeBlockBeam;
    /// <summary>
    /// Function: CanNodeBlockBeam
    /// </summary>
    public unsafe virtual bool CanNodeBlockBeam(BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo inNodeInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanNodeBlockBeam, "BmScript.RSpecialMoveInstance_HatterBrainGame.CanNodeBlockBeam", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inNodeInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanNodeActivate;
    /// <summary>
    /// Function: CanNodeActivate
    /// </summary>
    public unsafe virtual bool CanNodeActivate(BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo inNodeInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanNodeActivate, "BmScript.RSpecialMoveInstance_HatterBrainGame.CanNodeActivate", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inNodeInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Struct: FNodeStatesForOneSide
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FNodeStatesForOneSide
    {
        /// <summary>
        /// StructProperty: Nodes
        /// </summary>
        public unsafe BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo Nodes_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: Nodes
        /// </summary>
        public unsafe BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo Nodes_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// StructProperty: Nodes
        /// </summary>
        public unsafe BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo Nodes_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// StructProperty: Nodes
        /// </summary>
        public unsafe BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo Nodes_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// StructProperty: Nodes
        /// </summary>
        public unsafe BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo Nodes_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeInfo>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FNodeInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FNodeInfo
    {
        /// <summary>
        /// ByteProperty: CurrentState
        /// </summary>
        public unsafe BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.ENodeState CurrentState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.ENodeState>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: lastStateChangeTime
        /// </summary>
        public unsafe float lastStateChangeTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: ENodeState
    /// </summary>
    public enum ENodeState : byte
    {
        ENodeState_Invisible = 0,
        ENodeState_Appear = 1,
        ENodeState_WarmingUp = 2,
        ENodeState_Active = 3,
        ENodeState_Suppressed = 4,
        ENodeState_Fail = 5,
        ENodeState_Success = 6,
        ENodeState_MAX = 7,
    }

    /// <summary>
    /// Struct: FDifficultySettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FDifficultySettings
    {
        /// <summary>
        /// FloatProperty: timeBetweenNodeActivations
        /// </summary>
        public unsafe float timeBetweenNodeActivations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: laserDeactivateNodeTime
        /// </summary>
        public unsafe float laserDeactivateNodeTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: nodeWarmupTime
        /// </summary>
        public unsafe float nodeWarmupTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: nodeActiveLifetime
        /// </summary>
        public unsafe float nodeActiveLifetime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: nodeActivationScoreChange
        /// </summary>
        public unsafe float nodeActivationScoreChange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: nodeDestructionScoreChange
        /// </summary>
        public unsafe float nodeDestructionScoreChange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: nodeTimeoutScoreChange
        /// </summary>
        public unsafe float nodeTimeoutScoreChange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: barMovementRate_NoNodesActive
        /// </summary>
        public unsafe float barMovementRate_NoNodesActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: barMovementRate_OneNodeActive
        /// </summary>
        public unsafe float barMovementRate_OneNodeActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: barMovementRate_MultipleNodesActive
        /// </summary>
        public unsafe float barMovementRate_MultipleNodesActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: ImpossibleModeStartLevel
        /// </summary>
        public unsafe float ImpossibleModeStartLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: ImpossibleModeBlendDuration
        /// </summary>
        public unsafe float ImpossibleModeBlendDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: CurrentTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: TunerFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform TunerFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ObjectProperty: TheOmnitronMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieOmnitronBase TheOmnitronMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieOmnitronBase>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: leftStickMovingSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent leftStickMovingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: rightStickMovingSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent rightStickMovingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: targetHighlightSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent targetHighlightSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: targetLostSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent targetLostSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ObjectProperty: musicParameterName
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName musicParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: nodeSuccessSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent nodeSuccessSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: nodeFailSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent nodeFailSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// StructProperty: FinishLookAt
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FinishLookAt
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 976);

    /// <summary>
    /// FloatProperty: LeftThumbPos
    /// </summary>
    public unsafe float LeftThumbPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: RightThumbPos
    /// </summary>
    public unsafe float RightThumbPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: fThumbPadLightIntensity
    /// </summary>
    public unsafe float fThumbPadLightIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: fBootUpTime
    /// </summary>
    public unsafe float fBootUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: fShutDownTime
    /// </summary>
    public unsafe float fShutDownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: RumbleValueLeft
    /// </summary>
    public unsafe float RumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: RumbleValueRight
    /// </summary>
    public unsafe float RumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// NameProperty: EndControllerState
    /// </summary>
    public unsafe BmSDK.FName EndControllerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// NameProperty: SuccessOutAnim
    /// </summary>
    public unsafe BmSDK.FName SuccessOutAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// NameProperty: ActivePose
    /// </summary>
    public unsafe BmSDK.FName ActivePose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// NameProperty: HolsteredPose
    /// </summary>
    public unsafe BmSDK.FName HolsteredPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ByteProperty: HolsteredMirroredNess
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.EMirrorChoice HolsteredMirroredNess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: FlashAngleLeft
    /// </summary>
    public unsafe float FlashAngleLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: FlashAngleRight
    /// </summary>
    public unsafe float FlashAngleRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: LaserMovementSpeed
    /// </summary>
    public unsafe float LaserMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: currentBarProportion
    /// </summary>
    public unsafe float currentBarProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// BoolProperty: bFailed
    /// </summary>
    public unsafe bool bFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bSucceeded
    /// </summary>
    public unsafe bool bSucceeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bSentGameOver
    /// </summary>
    public unsafe bool bSentGameOver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bStartedTransitionToImpossibleMode
    /// </summary>
    public unsafe bool bStartedTransitionToImpossibleMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bDiscretiseInput
    /// </summary>
    public unsafe bool bDiscretiseInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bLerpInput
    /// </summary>
    public unsafe bool bLerpInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bLeftStickMoveSoundPlaying
    /// </summary>
    public unsafe bool bLeftStickMoveSoundPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bRightStickMoveSoundPlaying
    /// </summary>
    public unsafe bool bRightStickMoveSoundPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bDebugNeverEnding
    /// </summary>
    public unsafe bool bDebugNeverEnding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bLeftLaserHittingNode
    /// </summary>
    public unsafe bool bLeftLaserHittingNode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: bRightLaserHittingNode
    /// </summary>
    public unsafe bool bRightLaserHittingNode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1068); }
    }

    /// <summary>
    /// FloatProperty: impossibleModeStartTime
    /// </summary>
    public unsafe float impossibleModeStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: m_aNodesLeft
    /// </summary>
    public unsafe BmSDK.TArray<int> m_aNodesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: m_aNodesRight
    /// </summary>
    public unsafe BmSDK.TArray<int> m_aNodesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ArrayProperty: orderedNodeList_Left
    /// </summary>
    public unsafe BmSDK.TArray<int> orderedNodeList_Left
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ArrayProperty: orderedNodeList_Right
    /// </summary>
    public unsafe BmSDK.TArray<int> orderedNodeList_Right
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: m_CurveAngleRange
    /// </summary>
    public unsafe float m_CurveAngleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: m_CurveAngleMin
    /// </summary>
    public unsafe float m_CurveAngleMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: m_CurveAngleMax
    /// </summary>
    public unsafe float m_CurveAngleMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: m_CurveRadiusHorz
    /// </summary>
    public unsafe float m_CurveRadiusHorz
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: m_CurveRadiusVert
    /// </summary>
    public unsafe float m_CurveRadiusVert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: m_CurveCentreX
    /// </summary>
    public unsafe float m_CurveCentreX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: m_CurveCentreY
    /// </summary>
    public unsafe float m_CurveCentreY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: m_CurveFocusX
    /// </summary>
    public unsafe float m_CurveFocusX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: m_CurveFocusY
    /// </summary>
    public unsafe float m_CurveFocusY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: timeUntilNextNodeActivation
    /// </summary>
    public unsafe float timeUntilNextNodeActivation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: ImpossibleModeStartLevel
    /// </summary>
    public InlineArray<float> ImpossibleModeStartLevel => new(3, Ptr + 1180, 4, this);

    /// <summary>
    /// FloatProperty: ImpossibleModeStartLevel
    /// </summary>
    public unsafe float ImpossibleModeStartLevel_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }
    /// <summary>
    /// FloatProperty: ImpossibleModeStartLevel
    /// </summary>
    public unsafe float ImpossibleModeStartLevel_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }
    /// <summary>
    /// FloatProperty: ImpossibleModeStartLevel
    /// </summary>
    public unsafe float ImpossibleModeStartLevel_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: allSettings
    /// </summary>
    public InlineArray<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings> allSettings => new(4, Ptr + 1192, 48, this);

    /// <summary>
    /// StructProperty: allSettings
    /// </summary>
    public unsafe ref BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings allSettings_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings>(Ptr + 1192);
    /// <summary>
    /// StructProperty: allSettings
    /// </summary>
    public unsafe ref BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings allSettings_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings>(Ptr + 1240);
    /// <summary>
    /// StructProperty: allSettings
    /// </summary>
    public unsafe ref BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings allSettings_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings>(Ptr + 1288);
    /// <summary>
    /// StructProperty: allSettings
    /// </summary>
    public unsafe ref BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings allSettings_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings>(Ptr + 1336);

    /// <summary>
    /// StructProperty: CurrentDifficulty
    /// </summary>
    public unsafe ref BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings CurrentDifficulty
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FDifficultySettings>(Ptr + 1384);

    /// <summary>
    /// FloatProperty: laserIntersectThreshold
    /// </summary>
    public unsafe float laserIntersectThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// FloatProperty: nodeIntroAnimDuration
    /// </summary>
    public unsafe float nodeIntroAnimDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// FloatProperty: timeFromNodeOutroTriggerToDeactivation
    /// </summary>
    public unsafe float timeFromNodeOutroTriggerToDeactivation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// IntProperty: lastSideCheckedForActivation
    /// </summary>
    public unsafe int lastSideCheckedForActivation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: ModLeftAngle
    /// </summary>
    public unsafe float ModLeftAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// FloatProperty: ModRightAngle
    /// </summary>
    public unsafe float ModRightAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// FloatProperty: desiredModLeftAngle
    /// </summary>
    public unsafe float desiredModLeftAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// FloatProperty: desiredModRightAngle
    /// </summary>
    public unsafe float desiredModRightAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// FloatProperty: LaserLerpSpeed
    /// </summary>
    public unsafe float LaserLerpSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// IntProperty: numInputSlots
    /// </summary>
    public unsafe int numInputSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// FloatProperty: maxInputDelta
    /// </summary>
    public unsafe float maxInputDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: LeftThumbOffset
    /// </summary>
    public unsafe float LeftThumbOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// FloatProperty: RightThumbOffset
    /// </summary>
    public unsafe float RightThumbOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: leftThumbLightOffset
    /// </summary>
    public unsafe float leftThumbLightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// FloatProperty: rightThumbLightOffset
    /// </summary>
    public unsafe float rightThumbLightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: rumbleMod_Laser
    /// </summary>
    public unsafe float rumbleMod_Laser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// FloatProperty: rumbleThreshold_Score
    /// </summary>
    public unsafe float rumbleThreshold_Score
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: rumbleMod_Score
    /// </summary>
    public unsafe float rumbleMod_Score
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: transitionToImpossibleModeProportion
    /// </summary>
    public unsafe float transitionToImpossibleModeProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: Timer
    /// </summary>
    public unsafe float Timer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: delayBeforeFirstNodeSpawn
    /// </summary>
    public unsafe float delayBeforeFirstNodeSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: Sides
    /// </summary>
    public InlineArray<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeStatesForOneSide> Sides => new(2, Ptr + 1520, 40, this);

    /// <summary>
    /// StructProperty: Sides
    /// </summary>
    public unsafe ref BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeStatesForOneSide Sides_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeStatesForOneSide>(Ptr + 1520);
    /// <summary>
    /// StructProperty: Sides
    /// </summary>
    public unsafe ref BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeStatesForOneSide Sides_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RSpecialMoveInstance_HatterBrainGame.FNodeStatesForOneSide>(Ptr + 1560);
}
