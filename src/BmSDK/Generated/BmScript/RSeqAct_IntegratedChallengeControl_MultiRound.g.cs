#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_IntegratedChallengeControl_MultiRound<br/>
/// (size = 580)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_IntegratedChallengeControl_MultiRound : BmSDK.BmScript.RSeqAct_IntegratedChallengeControl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_IntegratedChallengeControl_MultiRound.
    /// </summary>
    public static RSeqAct_IntegratedChallengeControl_MultiRound DefaultObject => (RSeqAct_IntegratedChallengeControl_MultiRound)StaticClass().DefaultObject;

    internal RSeqAct_IntegratedChallengeControl_MultiRound() { }

    /// <summary>
    /// Constructs a new RSeqAct_IntegratedChallengeControl_MultiRound
    /// </summary>
    public RSeqAct_IntegratedChallengeControl_MultiRound(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_IntegratedChallengeControl_MultiRound Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_IntegratedChallengeControl_MultiRound(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_IntegratedChallengeControl_MultiRound>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_IntegratedChallengeControl_MultiRound>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_IntegratedChallengeControl_MultiRound>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_IntegratedChallengeControl_MultiRound>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_IntegratedChallengeControl_MultiRound>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_IntegratedChallengeControl_MultiRound>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_IntegratedChallengeControl_MultiRound>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_IntegratedChallengeControl_MultiRound>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Const: MAX_ROUNDS = 4
    /// </summary>
    public const int MAX_ROUNDS = 4;

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddToBonusSummaryString;
    /// <summary>
    /// Function: AddToBonusSummaryString
    /// </summary>
    public unsafe virtual void AddToBonusSummaryString(out BmSDK.FString SummaryString, out int TotalScore, out float DelayTime, BmSDK.FStringArg Desc, int Multi, int Score, bool bMultiXScore, BmSDK.FStringArg OverrideString = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddToBonusSummaryString, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.AddToBonusSummaryString", this);
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalScore);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalScore, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DelayTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayTime, paramsPtr + 20);
        Desc.WriteTo(paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Multi, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMultiXScore, paramsPtr + 48);
        OverrideString.WriteTo(paramsPtr + 52);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 52);
        SummaryString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        TotalScore = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        DelayTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddToSummaryString;
    /// <summary>
    /// Function: AddToSummaryString
    /// </summary>
    public unsafe virtual void AddToSummaryString(out BmSDK.FString SummaryString, out int TotalXP, out float DelayTime, BmSDK.FStringArg Desc, int Multi, float XPPer, bool bIndent, bool bAddXP = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddToSummaryString, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.AddToSummaryString", this);
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalXP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalXP, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DelayTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayTime, paramsPtr + 20);
        Desc.WriteTo(paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Multi, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPPer, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIndent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddXP, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        SummaryString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        TotalXP = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        DelayTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PerfectKnightBonusEarned;
    /// <summary>
    /// Function: PerfectKnightBonusEarned
    /// </summary>
    public unsafe virtual bool PerfectKnightBonusEarned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PerfectKnightBonusEarned, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.PerfectKnightBonusEarned", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddCombatChallengeSingleRoundBonus;
    /// <summary>
    /// Function: AddCombatChallengeSingleRoundBonus
    /// </summary>
    public unsafe virtual int AddCombatChallengeSingleRoundBonus(out BmSDK.FString SummaryString, int scorePriorToThisRound)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddCombatChallengeSingleRoundBonus, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.AddCombatChallengeSingleRoundBonus", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scorePriorToThisRound, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SummaryString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetStatsBetweenRounds;
    /// <summary>
    /// Function: ResetStatsBetweenRounds
    /// </summary>
    public unsafe virtual void ResetStatsBetweenRounds()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetStatsBetweenRounds, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.ResetStatsBetweenRounds", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetScoresAndSummaryString;
    /// <summary>
    /// Function: GetScoresAndSummaryString
    /// </summary>
    public unsafe virtual void GetScoresAndSummaryString(out BmSDK.FString SummaryString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetScoresAndSummaryString, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.GetScoresAndSummaryString", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SummaryString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateRoundSummary;
    /// <summary>
    /// Function: UpdateRoundSummary
    /// </summary>
    public unsafe virtual void UpdateRoundSummary()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateRoundSummary, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.UpdateRoundSummary", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideRoundSummary;
    /// <summary>
    /// Function: HideRoundSummary
    /// </summary>
    public unsafe virtual void HideRoundSummary()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideRoundSummary, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.HideRoundSummary", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowRoundSummary;
    /// <summary>
    /// Function: ShowRoundSummary
    /// </summary>
    public unsafe virtual void ShowRoundSummary()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowRoundSummary, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.ShowRoundSummary", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InitRoundSummary;
    /// <summary>
    /// Function: InitRoundSummary
    /// </summary>
    public unsafe virtual void InitRoundSummary()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InitRoundSummary, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.InitRoundSummary", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearThingsDuringFade;
    /// <summary>
    /// Function: ClearThingsDuringFade
    /// </summary>
    public unsafe virtual void ClearThingsDuringFade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearThingsDuringFade, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.ClearThingsDuringFade", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Update;
    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float fDeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Update, "BmScript.RSeqAct_IntegratedChallengeControl_MultiRound.Update", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Struct: FindividualRoundScores
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FindividualRoundScores
    {
        /// <summary>
        /// IntProperty: total
        /// </summary>
        public unsafe int total
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Base
        /// </summary>
        public unsafe int Base
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: VariationAmount
        /// </summary>
        public unsafe int VariationAmount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: VariationBonus
        /// </summary>
        public unsafe int VariationBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: perfectRoundBonus
        /// </summary>
        public unsafe int perfectRoundBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: flawlessFreeflowBonus
        /// </summary>
        public unsafe int flawlessFreeflowBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// FloatProperty: timeBeforeRoundSummaryVisible<br/>
    /// Default: 1
    /// </summary>
    public unsafe float timeBeforeRoundSummaryVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: timeBeforeRoundSummarySkippable<br/>
    /// Default: 3
    /// </summary>
    public unsafe float timeBeforeRoundSummarySkippable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: roundSummaryFadeOutTime<br/>
    /// Default: 2
    /// </summary>
    public unsafe float roundSummaryFadeOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: bShowingRoundSummary
    /// </summary>
    public unsafe bool bShowingRoundSummary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 512); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToDisplayRoundSummary
    /// </summary>
    public unsafe bool bWaitingToDisplayRoundSummary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: roundSummaryStartTime
    /// </summary>
    public unsafe float roundSummaryStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: roundSummaryButtonPressTime
    /// </summary>
    public unsafe float roundSummaryButtonPressTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: currentRoundIndex
    /// </summary>
    public unsafe int currentRoundIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: prevChallengeScore
    /// </summary>
    public unsafe int prevChallengeScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StrProperty: roundSummaryString
    /// </summary>
    public unsafe BmSDK.FString roundSummaryString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: roundTotalScores
    /// </summary>
    public InlineArray<int> roundTotalScores => new(4, Ptr + 548, 4, this);

    /// <summary>
    /// IntProperty: roundTotalScores
    /// </summary>
    public unsafe int roundTotalScores_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }
    /// <summary>
    /// IntProperty: roundTotalScores
    /// </summary>
    public unsafe int roundTotalScores_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }
    /// <summary>
    /// IntProperty: roundTotalScores
    /// </summary>
    public unsafe int roundTotalScores_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }
    /// <summary>
    /// IntProperty: roundTotalScores
    /// </summary>
    public unsafe int roundTotalScores_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: bAchievedPerfectKnightPerRound
    /// </summary>
    public InlineArray<int> bAchievedPerfectKnightPerRound => new(4, Ptr + 564, 4, this);

    /// <summary>
    /// IntProperty: bAchievedPerfectKnightPerRound
    /// </summary>
    public unsafe int bAchievedPerfectKnightPerRound_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }
    /// <summary>
    /// IntProperty: bAchievedPerfectKnightPerRound
    /// </summary>
    public unsafe int bAchievedPerfectKnightPerRound_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }
    /// <summary>
    /// IntProperty: bAchievedPerfectKnightPerRound
    /// </summary>
    public unsafe int bAchievedPerfectKnightPerRound_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
    /// <summary>
    /// IntProperty: bAchievedPerfectKnightPerRound
    /// </summary>
    public unsafe int bAchievedPerfectKnightPerRound_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }
}
