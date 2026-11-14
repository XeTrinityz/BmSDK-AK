#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieOmnitronBase<br/>
/// (size = 724)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieOmnitronBase : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieOmnitronBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieOmnitronBase.
    /// </summary>
    public static RGFxMovieOmnitronBase DefaultObject => (RGFxMovieOmnitronBase)StaticClass().DefaultObject;

    internal RGFxMovieOmnitronBase() { }

    /// <summary>
    /// Constructs a new RGFxMovieOmnitronBase
    /// </summary>
    public RGFxMovieOmnitronBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieOmnitronBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieOmnitronBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieOmnitronBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieOmnitronBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieOmnitronBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieOmnitronBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieOmnitronBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieOmnitronBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieOmnitronBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieOmnitronBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_FindDistanceFromPointToLine;
    /// <summary>
    /// Function: XI_FindDistanceFromPointToLine
    /// </summary>
    public unsafe virtual float XI_FindDistanceFromPointToLine(float nodePointX, float nodePointY, float laserPointX, float laserPointY, float laser_angle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_FindDistanceFromPointToLine, "BmGame.RGFxMovieOmnitronBase.XI_FindDistanceFromPointToLine", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laser_angle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetCurveData;
    /// <summary>
    /// Function: XI_SetCurveData
    /// </summary>
    public unsafe virtual void XI_SetCurveData(float CurveAngleRange, float CurveAngleMin, float CurveAngleMax, float CurveRadiusHorz, float CurveRadiusVert, float CurveCentreX, float CurveCentreY, float CurveFocusX, float CurveFocusY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetCurveData, "BmGame.RGFxMovieOmnitronBase.XI_SetCurveData", this);
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
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_TickIntersect;
    /// <summary>
    /// Function: XI_TickIntersect
    /// </summary>
    public unsafe virtual void XI_TickIntersect(BmSDK.TArray<int> aNodesLeft, BmSDK.TArray<int> aNodesRight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_TickIntersect, "BmGame.RGFxMovieOmnitronBase.XI_TickIntersect", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesRight, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_StickStartsOrStopsMoving;
    /// <summary>
    /// Function: XI_StickStartsOrStopsMoving
    /// </summary>
    public unsafe virtual void XI_StickStartsOrStopsMoving(int stick_index, bool is_moving)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_StickStartsOrStopsMoving, "BmGame.RGFxMovieOmnitronBase.XI_StickStartsOrStopsMoving", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stick_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_moving, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetLaserPositionAndAngle;
    /// <summary>
    /// Function: UC_SetLaserPositionAndAngle
    /// </summary>
    public unsafe virtual void UC_SetLaserPositionAndAngle(int side_index, float fDollyX, float fDollyY, float fAngleToFocus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetLaserPositionAndAngle, "BmGame.RGFxMovieOmnitronBase.UC_SetLaserPositionAndAngle", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fAngleToFocus, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetBeamIntersectNodes;
    /// <summary>
    /// Function: UC_SetBeamIntersectNodes
    /// </summary>
    public unsafe virtual void UC_SetBeamIntersectNodes(int node1, int node2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetBeamIntersectNodes, "BmGame.RGFxMovieOmnitronBase.UC_SetBeamIntersectNodes", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node2, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_DoGameOver;
    /// <summary>
    /// Function: UC_DoGameOver
    /// </summary>
    public unsafe virtual void UC_DoGameOver(bool did_player_win)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_DoGameOver, "BmGame.RGFxMovieOmnitronBase.UC_DoGameOver", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(did_player_win, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetNodeState;
    /// <summary>
    /// Function: UC_SetNodeState
    /// </summary>
    public unsafe virtual void UC_SetNodeState(int side_index, int node_index, int iState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetNodeState, "BmGame.RGFxMovieOmnitronBase.UC_SetNodeState", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iState, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetBombMeterProportion;
    /// <summary>
    /// Function: UC_SetBombMeterProportion
    /// </summary>
    public unsafe virtual void UC_SetBombMeterProportion(float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetBombMeterProportion, "BmGame.RGFxMovieOmnitronBase.UC_SetBombMeterProportion", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetupMadHatterMinigame;
    /// <summary>
    /// Function: UC_SetupMadHatterMinigame
    /// </summary>
    public unsafe virtual void UC_SetupMadHatterMinigame(float fHitArea, float fProportion, float fLaserSpeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetupMadHatterMinigame, "BmGame.RGFxMovieOmnitronBase.UC_SetupMadHatterMinigame", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fHitArea, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fProportion, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fLaserSpeed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_CheckSolution;
    /// <summary>
    /// Function: UC_CheckSolution
    /// </summary>
    public unsafe virtual void UC_CheckSolution()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_CheckSolution, "BmGame.RGFxMovieOmnitronBase.UC_CheckSolution", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_CalibrationComplete;
    /// <summary>
    /// Function: XI_CalibrationComplete
    /// </summary>
    public unsafe virtual void XI_CalibrationComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_CalibrationComplete, "BmGame.RGFxMovieOmnitronBase.XI_CalibrationComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_StopVoicePlayback;
    /// <summary>
    /// Function: XI_StopVoicePlayback
    /// </summary>
    public unsafe virtual void XI_StopVoicePlayback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_StopVoicePlayback, "BmGame.RGFxMovieOmnitronBase.XI_StopVoicePlayback", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_StartVoicePlayback;
    /// <summary>
    /// Function: XI_StartVoicePlayback
    /// </summary>
    public unsafe virtual void XI_StartVoicePlayback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_StartVoicePlayback, "BmGame.RGFxMovieOmnitronBase.XI_StartVoicePlayback", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ClosingDialogueBoxAfterOutro;
    /// <summary>
    /// Function: XI_ClosingDialogueBoxAfterOutro
    /// </summary>
    public unsafe virtual void XI_ClosingDialogueBoxAfterOutro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ClosingDialogueBoxAfterOutro, "BmGame.RGFxMovieOmnitronBase.XI_ClosingDialogueBoxAfterOutro", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ClosingDialogueBoxAfterScan;
    /// <summary>
    /// Function: XI_ClosingDialogueBoxAfterScan
    /// </summary>
    public unsafe virtual void XI_ClosingDialogueBoxAfterScan()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ClosingDialogueBoxAfterScan, "BmGame.RGFxMovieOmnitronBase.XI_ClosingDialogueBoxAfterScan", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ClosingDialogueBoxAfterIntro;
    /// <summary>
    /// Function: XI_ClosingDialogueBoxAfterIntro
    /// </summary>
    public unsafe virtual void XI_ClosingDialogueBoxAfterIntro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ClosingDialogueBoxAfterIntro, "BmGame.RGFxMovieOmnitronBase.XI_ClosingDialogueBoxAfterIntro", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_PlayVoiceNormal;
    /// <summary>
    /// Function: XI_PlayVoiceNormal
    /// </summary>
    public unsafe virtual void XI_PlayVoiceNormal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_PlayVoiceNormal, "BmGame.RGFxMovieOmnitronBase.XI_PlayVoiceNormal", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_PushWaveParams;
    /// <summary>
    /// Function: XI_PushWaveParams
    /// </summary>
    public unsafe virtual void XI_PushWaveParams(float audioLength, float audioValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_PushWaveParams, "BmGame.RGFxMovieOmnitronBase.XI_PushWaveParams", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(audioLength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(audioValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GameReady;
    /// <summary>
    /// Function: XI_GameReady
    /// </summary>
    public unsafe virtual void XI_GameReady()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GameReady, "BmGame.RGFxMovieOmnitronBase.XI_GameReady", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitVoiceSynth;
    /// <summary>
    /// Function: InitVoiceSynth
    /// </summary>
    public unsafe virtual void InitVoiceSynth(float solutionVal, float solutionLength, float barSize, float perfectMargin, float correctMargin, BmSDK.FStringArg localisedName, BmSDK.FStringArg PortraitName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitVoiceSynth, "BmGame.RGFxMovieOmnitronBase.InitVoiceSynth", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(solutionVal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(solutionLength, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(barSize, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(perfectMargin, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(correctMargin, paramsPtr + 16);
        localisedName.WriteTo(paramsPtr + 20);
        PortraitName.WriteTo(paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartPlayhead;
    /// <summary>
    /// Function: StartPlayhead
    /// </summary>
    public unsafe virtual void StartPlayhead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartPlayhead, "BmGame.RGFxMovieOmnitronBase.StartPlayhead", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PushControllerToFlash;
    /// <summary>
    /// Function: PushControllerToFlash
    /// </summary>
    public unsafe virtual void PushControllerToFlash(float left_x, float right_y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PushControllerToFlash, "BmGame.RGFxMovieOmnitronBase.PushControllerToFlash", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_y, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerIntroSound;
    /// <summary>
    /// Function: TriggerIntroSound
    /// </summary>
    public unsafe virtual void TriggerIntroSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerIntroSound, "BmGame.RGFxMovieOmnitronBase.TriggerIntroSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_AnimationEvent;
    /// <summary>
    /// Function: XI_AnimationEvent
    /// </summary>
    public unsafe virtual void XI_AnimationEvent(BmSDK.FStringArg sEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_AnimationEvent, "BmGame.RGFxMovieOmnitronBase.XI_AnimationEvent", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sEvent.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetRumble;
    /// <summary>
    /// Function: XI_SetRumble
    /// </summary>
    public unsafe virtual void XI_SetRumble(float fRumbleL, float fRumbleR)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetRumble, "BmGame.RGFxMovieOmnitronBase.XI_SetRumble", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRumbleL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRumbleR, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_PasswordFound;
    /// <summary>
    /// Function: XI_PasswordFound
    /// </summary>
    public unsafe virtual void XI_PasswordFound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_PasswordFound, "BmGame.RGFxMovieOmnitronBase.XI_PasswordFound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OutroComplete;
    /// <summary>
    /// Function: XI_OutroComplete
    /// </summary>
    public unsafe virtual void XI_OutroComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OutroComplete, "BmGame.RGFxMovieOmnitronBase.XI_OutroComplete", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_PlaySweep;
    /// <summary>
    /// Function: UC_PlaySweep
    /// </summary>
    public unsafe virtual void UC_PlaySweep()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_PlaySweep, "BmGame.RGFxMovieOmnitronBase.UC_PlaySweep", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetStickAngles;
    /// <summary>
    /// Function: UC_SetStickAngles
    /// </summary>
    public unsafe virtual void UC_SetStickAngles(float fLeft, float fRight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetStickAngles, "BmGame.RGFxMovieOmnitronBase.UC_SetStickAngles", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRight, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetDistance;
    /// <summary>
    /// Function: UC_SetDistance
    /// </summary>
    public unsafe virtual void UC_SetDistance(float fDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetDistance, "BmGame.RGFxMovieOmnitronBase.UC_SetDistance", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDistance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetLockOnPercentage;
    /// <summary>
    /// Function: UC_SetLockOnPercentage
    /// </summary>
    public unsafe virtual void UC_SetLockOnPercentage(float fPercent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetLockOnPercentage, "BmGame.RGFxMovieOmnitronBase.UC_SetLockOnPercentage", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fPercent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_LockOn;
    /// <summary>
    /// Function: UC_LockOn
    /// </summary>
    public unsafe virtual void UC_LockOn(BmSDK.FStringArg sState, BmSDK.FStringArg sPrimaryText, BmSDK.FStringArg sSecondaryText, BmSDK.FStringArg sIcon, int nDifficulty)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_LockOn, "BmGame.RGFxMovieOmnitronBase.UC_LockOn", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sState.WriteTo(paramsPtr + 0);
        sPrimaryText.WriteTo(paramsPtr + 16);
        sSecondaryText.WriteTo(paramsPtr + 32);
        sIcon.WriteTo(paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nDifficulty, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_BeginHacking;
    /// <summary>
    /// Function: UC_BeginHacking
    /// </summary>
    public unsafe virtual void UC_BeginHacking(BmSDK.FStringArg sPasswords, int nDifficulty, int nSeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_BeginHacking, "BmGame.RGFxMovieOmnitronBase.UC_BeginHacking", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPasswords.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nDifficulty, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nSeed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BeginHacking;
    /// <summary>
    /// Function: BeginHacking
    /// </summary>
    public unsafe virtual void BeginHacking(BmSDK.BmGame.RRemoteControlHighSecurityInterface the_target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BeginHacking, "BmGame.RGFxMovieOmnitronBase.BeginHacking", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnClose;
    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe override void OnClose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnClose, "BmGame.RGFxMovieOmnitronBase.OnClose", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmGame.RGFxMovieOmnitronBase.Init", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueLeft
    /// </summary>
    public unsafe float FlashRumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueRight
    /// </summary>
    public unsafe float FlashRumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: PasswordFound
    /// </summary>
    public unsafe bool PasswordFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: MinigameComplete
    /// </summary>
    public unsafe bool MinigameComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: SpecialMoveVar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMovieInstance_MinigameBase SpecialMoveVar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMovieInstance_MinigameBase>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfoBrainHacking
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfoBrainHacking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
}
