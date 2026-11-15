#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCrimeScene<br/>
/// (size = 1344)
/// (flags = 10486290)
/// </summary>
public partial class RCrimeScene : BmSDK.BmGame.RCrimeSceneBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCrimeScene", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCrimeScene.
    /// </summary>
    public static RCrimeScene DefaultObject => (RCrimeScene)StaticClass().DefaultObject;

    internal RCrimeScene() { }

    /// <summary>
    /// Constructs a new RCrimeScene
    /// </summary>
    public RCrimeScene(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCrimeScene(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrimeScene>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeScene>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrimeScene>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeScene>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeScene>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeScene>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrimeScene>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeScene>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPerimeterBlockingActive;
    /// <summary>
    /// Function: SetPerimeterBlockingActive
    /// </summary>
    public unsafe override void SetPerimeterBlockingActive(bool are_active)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPerimeterBlockingActive, "BmScript.RCrimeScene.SetPerimeterBlockingActive", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(are_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetDeepScanActorsVisible;
    /// <summary>
    /// Function: SetDeepScanActorsVisible
    /// </summary>
    public unsafe virtual void SetDeepScanActorsVisible(BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> actor_array, out float destVal, bool make_visible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetDeepScanActorsVisible, "BmScript.RCrimeScene.SetDeepScanActorsVisible", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actor_array, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out destVal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destVal, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(make_visible, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        destVal = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AutoSetDeepScanActorsVisible;
    /// <summary>
    /// Function: AutoSetDeepScanActorsVisible
    /// </summary>
    public unsafe override void AutoSetDeepScanActorsVisible()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AutoSetDeepScanActorsVisible, "BmScript.RCrimeScene.AutoSetDeepScanActorsVisible", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeepScanResetObjectStates;
    /// <summary>
    /// Function: DeepScanResetObjectStates
    /// </summary>
    public unsafe override void DeepScanResetObjectStates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeepScanResetObjectStates, "BmScript.RCrimeScene.DeepScanResetObjectStates", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateMaterials;
    /// <summary>
    /// Function: UpdateMaterials
    /// </summary>
    public unsafe virtual void UpdateMaterials(BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> aMI, float currentAlpha, int LayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateMaterials, "BmScript.RCrimeScene.UpdateMaterials", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aMI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentAlpha, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LayerID, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeepScanHideAll;
    /// <summary>
    /// Function: DeepScanHideAll
    /// </summary>
    public unsafe override void DeepScanHideAll(bool bSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeepScanHideAll, "BmScript.RCrimeScene.DeepScanHideAll", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetupMaterials;
    /// <summary>
    /// Function: SetupMaterials
    /// </summary>
    public unsafe virtual void SetupMaterials(out BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> aMI, BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> aActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetupMaterials, "BmScript.RCrimeScene.SetupMaterials", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aActor, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        aMI = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeepScanTick;
    /// <summary>
    /// Function: DeepScanTick
    /// </summary>
    public unsafe override void DeepScanTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeepScanTick, "BmScript.RCrimeScene.DeepScanTick", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InterpVal;
    /// <summary>
    /// Function: InterpVal
    /// </summary>
    public unsafe virtual float InterpVal(float Current, float Target, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InterpVal, "BmScript.RCrimeScene.InterpVal", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SmoothCurve;
    /// <summary>
    /// Function: SmoothCurve
    /// </summary>
    public unsafe virtual float SmoothCurve(float X)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SmoothCurve, "BmScript.RCrimeScene.SmoothCurve", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeepScanLevelPlusMinus;
    /// <summary>
    /// Function: DeepScanLevelPlusMinus
    /// </summary>
    public unsafe override bool DeepScanLevelPlusMinus(BmSDK.BmGame.RPlayerController RPC, int plus_minus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeepScanLevelPlusMinus, "BmScript.RCrimeScene.DeepScanLevelPlusMinus", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(plus_minus, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindIntersectionVector;
    /// <summary>
    /// Function: FindIntersectionVector
    /// </summary>
    public unsafe virtual void FindIntersectionVector(out System.Numerics.Vector3 IntersectionVector, System.Numerics.Vector3 SpokeOrigin_A, float SpokeAngle_A, System.Numerics.Vector3 SpokeOrigin_B, float SpokeAngle_B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindIntersectionVector, "BmScript.RCrimeScene.FindIntersectionVector", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionVector);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionVector, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpokeOrigin_A, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpokeAngle_A, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpokeOrigin_B, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpokeAngle_B, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IntersectionVector = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVectorAngle2D;
    /// <summary>
    /// Function: GetVectorAngle2D
    /// </summary>
    public unsafe virtual float GetVectorAngle2D(System.Numerics.Vector3 ChordVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVectorAngle2D, "BmScript.RCrimeScene.GetVectorAngle2D", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChordVector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TestConstrainToArc;
    /// <summary>
    /// Function: TestConstrainToArc
    /// </summary>
    public unsafe virtual void TestConstrainToArc()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TestConstrainToArc, "BmScript.RCrimeScene.TestConstrainToArc", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindVectorByAngle;
    /// <summary>
    /// Function: FindVectorByAngle
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindVectorByAngle(System.Numerics.Vector3 origin_vector, float the_angle, float the_radius)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindVectorByAngle, "BmScript.RCrimeScene.FindVectorByAngle", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(origin_vector, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_angle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_radius, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetConstrainVectorFromProportion;
    /// <summary>
    /// Function: GetConstrainVectorFromProportion
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetConstrainVectorFromProportion(float in_proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetConstrainVectorFromProportion, "BmScript.RCrimeScene.GetConstrainVectorFromProportion", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(in_proportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetConstrainProportionFromVector;
    /// <summary>
    /// Function: GetConstrainProportionFromVector
    /// </summary>
    public unsafe override float GetConstrainProportionFromVector(System.Numerics.Vector3 in_vector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetConstrainProportionFromVector, "BmScript.RCrimeScene.GetConstrainProportionFromVector", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(in_vector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ConstrainVectorToCurve;
    /// <summary>
    /// Function: ConstrainVectorToCurve
    /// </summary>
    public unsafe override System.Numerics.Vector3 ConstrainVectorToCurve(System.Numerics.Vector3 in_vector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ConstrainVectorToCurve, "BmScript.RCrimeScene.ConstrainVectorToCurve", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(in_vector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCurrentMissingPersonsNumber;
    /// <summary>
    /// Function: GetCurrentMissingPersonsNumber
    /// </summary>
    public unsafe virtual int GetCurrentMissingPersonsNumber()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCurrentMissingPersonsNumber, "BmScript.RCrimeScene.GetCurrentMissingPersonsNumber", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FoundMissingPersonsEvidenceForCurrentLayer;
    /// <summary>
    /// Function: FoundMissingPersonsEvidenceForCurrentLayer
    /// </summary>
    public unsafe override void FoundMissingPersonsEvidenceForCurrentLayer(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FoundMissingPersonsEvidenceForCurrentLayer, "BmScript.RCrimeScene.FoundMissingPersonsEvidenceForCurrentLayer", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitMissingPersonsDataOnHud;
    /// <summary>
    /// Function: InitMissingPersonsDataOnHud
    /// </summary>
    public unsafe override void InitMissingPersonsDataOnHud(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitMissingPersonsDataOnHud, "BmScript.RCrimeScene.InitMissingPersonsDataOnHud", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PostBeginPlay, "BmScript.RCrimeScene.PostBeginPlay", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: DeepScanActors_0_Skin
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> DeepScanActors_0_Skin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: DeepScanActors_0_Surfaces
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> DeepScanActors_0_Surfaces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: DeepScanActors_0_SurfaceEvidence
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> DeepScanActors_0_SurfaceEvidence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor>>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: DeepScanActors_1_Muscles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> DeepScanActors_1_Muscles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor>>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ArrayProperty: DeepScanActors_2_Bones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> DeepScanActors_2_Bones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor>>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ArrayProperty: DeepScanFilterStrings_Surface_Muscle_Bone<br/>
    /// Default: ("Surface Scan**","Muscle Scan**","Bone Scan**")
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DeepScanFilterStrings_Surface_Muscle_Bone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ArrayProperty: DeepScanFilterProportions_Surface_Muscle_Bone<br/>
    /// Default: (5,7,4)
    /// </summary>
    public unsafe BmSDK.TArray<float> DeepScanFilterProportions_Surface_Muscle_Bone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// IntProperty: DeepScanMissingPersonsTotalPopulation
    /// </summary>
    public unsafe int DeepScanMissingPersonsTotalPopulation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// IntProperty: DeepScanFinalDisplayFrameIndex<br/>
    /// Default: 1
    /// </summary>
    public unsafe int DeepScanFinalDisplayFrameIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: NumDeepScanEvidenceScanned
    /// </summary>
    public unsafe int NumDeepScanEvidenceScanned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StrProperty: FirstScannedEvidence
    /// </summary>
    public unsafe BmSDK.FString FirstScannedEvidence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StrProperty: SecondScannedEvidence
    /// </summary>
    public unsafe BmSDK.FString SecondScannedEvidence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ArrayProperty: PerimeterBlockingActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> PerimeterBlockingActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ArrayProperty: MaterialInstances_0
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MaterialInstances_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: MaterialInstances_1
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MaterialInstances_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ArrayProperty: MaterialInstances_2
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MaterialInstances_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: MaterialInstances_3
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MaterialInstances_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: MaterialInstances_4
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MaterialInstances_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: visibleCurrent_0
    /// </summary>
    public unsafe float visibleCurrent_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// FloatProperty: visibleCurrent_1
    /// </summary>
    public unsafe float visibleCurrent_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: visibleCurrent_2
    /// </summary>
    public unsafe float visibleCurrent_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: visibleDest_0
    /// </summary>
    public unsafe float visibleDest_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: visibleDest_1
    /// </summary>
    public unsafe float visibleDest_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: visibleDest_2
    /// </summary>
    public unsafe float visibleDest_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: ActiveOuterAlpha<br/>
    /// Default: (1,0,0,0,0)
    /// </summary>
    public unsafe BmSDK.TArray<float> ActiveOuterAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: ActiveInnerAlpha<br/>
    /// Default: (0,1,1,1,1)
    /// </summary>
    public unsafe BmSDK.TArray<float> ActiveInnerAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ArrayProperty: InactiveOuterAlpha<br/>
    /// Default: (1,0,0,0,0)
    /// </summary>
    public unsafe BmSDK.TArray<float> InactiveOuterAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ArrayProperty: InactiveInnerAlpha<br/>
    /// Default: (1,0.2,0.2,0.2,0.2)
    /// </summary>
    public unsafe BmSDK.TArray<float> InactiveInnerAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMaskInner<br/>
    /// Default: (0.1,0.1,0.1,0.1,0.1)
    /// </summary>
    public unsafe BmSDK.TArray<float> ActiveMaskInner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMaskOuter<br/>
    /// Default: (0.115,0.115,0.115,0.115,0.115)
    /// </summary>
    public unsafe BmSDK.TArray<float> ActiveMaskOuter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ArrayProperty: InactiveMaskInner<br/>
    /// Default: (0,0.1,0.1,0.1,0.1)
    /// </summary>
    public unsafe BmSDK.TArray<float> InactiveMaskInner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ArrayProperty: InactiveMaskOuter<br/>
    /// Default: (0.001,0.115,0.115,0.115,0.115)
    /// </summary>
    public unsafe BmSDK.TArray<float> InactiveMaskOuter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ArrayProperty: ActiveFadeToCenter<br/>
    /// Default: (1,1,1,1,1)
    /// </summary>
    public unsafe BmSDK.TArray<float> ActiveFadeToCenter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// ArrayProperty: InactiveFadeToCenter<br/>
    /// Default: (0.4,0.4,0.4,0.4,0.4)
    /// </summary>
    public unsafe BmSDK.TArray<float> InactiveFadeToCenter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// ObjectProperty: RefPoint_ConstrainToArcLeft
    /// </summary>
    public unsafe BmSDK.Engine.Actor RefPoint_ConstrainToArcLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ObjectProperty: RefPoint_ConstrainToArcMiddle
    /// </summary>
    public unsafe BmSDK.Engine.Actor RefPoint_ConstrainToArcMiddle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ObjectProperty: RefPoint_ConstrainToArcRight
    /// </summary>
    public unsafe BmSDK.Engine.Actor RefPoint_ConstrainToArcRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ObjectProperty: TempRPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController TempRPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }
}
