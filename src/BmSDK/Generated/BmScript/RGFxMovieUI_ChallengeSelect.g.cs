#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_ChallengeSelect<br/>
/// (size = 1136)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_ChallengeSelect : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_ChallengeSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_ChallengeSelect.
    /// </summary>
    public static RGFxMovieUI_ChallengeSelect DefaultObject => (RGFxMovieUI_ChallengeSelect)StaticClass().DefaultObject;

    internal RGFxMovieUI_ChallengeSelect() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_ChallengeSelect
    /// </summary>
    public RGFxMovieUI_ChallengeSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_ChallengeSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_ChallengeSelect(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_ChallengeSelect>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendLeaderBoardToFlash;
    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe override void SendLeaderBoardToFlash(int nId, int nTotal, BmSDK.TArray<int> aFriendIndex, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> aNetIDs, BmSDK.TArray<int> aRanks, BmSDK.TArray<BmSDK.FString> aNames, BmSDK.TArray<int> aStars, BmSDK.TArray<float> aScores, BmSDK.TArray<int> aRivalPoints, BmSDK.TArray<float> aStory, BmSDK.TArray<float> aMW, BmSDK.TArray<float> aAR)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendLeaderBoardToFlash, "BmScript.RGFxMovieUI_ChallengeSelect.SendLeaderBoardToFlash", this);
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nTotal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aFriendIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNetIDs, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aRanks, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNames, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aStars, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aScores, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aRivalPoints, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aStory, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aMW, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aAR, paramsPtr + 152);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_UpdatePrompts;
    /// <summary>
    /// Function: XI_UpdatePrompts
    /// </summary>
    public unsafe virtual void XI_UpdatePrompts(int nId, bool bLeaderboard, bool bEmpty = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_UpdatePrompts, "BmScript.RGFxMovieUI_ChallengeSelect.XI_UpdatePrompts", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeaderboard, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEmpty, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsDefaultCharacter;
    /// <summary>
    /// Function: IsDefaultCharacter
    /// </summary>
    public unsafe virtual bool IsDefaultCharacter(int nId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsDefaultCharacter, "BmScript.RGFxMovieUI_ChallengeSelect.IsDefaultCharacter", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ShowGamerCard;
    /// <summary>
    /// Function: XI_ShowGamerCard
    /// </summary>
    public unsafe virtual void XI_ShowGamerCard(int nFriendIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ShowGamerCard, "BmScript.RGFxMovieUI_ChallengeSelect.XI_ShowGamerCard", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nFriendIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_FetchLeaderboardData;
    /// <summary>
    /// Function: XI_FetchLeaderboardData
    /// </summary>
    public unsafe virtual bool XI_FetchLeaderboardData(int RequestedMode, int ChallengeID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_FetchLeaderboardData, "BmScript.RGFxMovieUI_ChallengeSelect.XI_FetchLeaderboardData", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestedMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ChallengeHasLeaderboard;
    /// <summary>
    /// Function: XI_ChallengeHasLeaderboard
    /// </summary>
    public unsafe virtual bool XI_ChallengeHasLeaderboard(int ChallengeID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ChallengeHasLeaderboard, "BmScript.RGFxMovieUI_ChallengeSelect.XI_ChallengeHasLeaderboard", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TimerPollingLeaderboards;
    /// <summary>
    /// Function: TimerPollingLeaderboards
    /// </summary>
    public unsafe virtual void TimerPollingLeaderboards()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TimerPollingLeaderboards, "BmScript.RGFxMovieUI_ChallengeSelect.TimerPollingLeaderboards", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsPollingBoards;
    /// <summary>
    /// Function: IsPollingBoards
    /// </summary>
    public unsafe virtual bool IsPollingBoards()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsPollingBoards, "BmScript.RGFxMovieUI_ChallengeSelect.IsPollingBoards", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_ShowLeaderboard;
    /// <summary>
    /// Function: UC_ShowLeaderboard
    /// </summary>
    public unsafe virtual void UC_ShowLeaderboard()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_ShowLeaderboard, "BmScript.RGFxMovieUI_ChallengeSelect.UC_ShowLeaderboard", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetLeaderboardError;
    /// <summary>
    /// Function: UC_SetLeaderboardError
    /// </summary>
    public unsafe virtual void UC_SetLeaderboardError(BmSDK.FStringArg sError)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetLeaderboardError, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetLeaderboardError", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sError.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetLeaderboardLine;
    /// <summary>
    /// Function: UC_SetLeaderboardLine
    /// </summary>
    public unsafe virtual void UC_SetLeaderboardLine(int nIndex, int nRank, BmSDK.FStringArg sName, int nStars, BmSDK.FStringArg sScore, int nRivalPoints, bool bIsSelf, bool bIsRival)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetLeaderboardLine, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetLeaderboardLine", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRank, paramsPtr + 4);
        sName.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nStars, paramsPtr + 24);
        sScore.WriteTo(paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRivalPoints, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSelf, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsRival, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyFriendBeatYou;
    /// <summary>
    /// Function: NotifyFriendBeatYou
    /// </summary>
    public unsafe override void NotifyFriendBeatYou()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyFriendBeatYou, "BmScript.RGFxMovieUI_ChallengeSelect.NotifyFriendBeatYou", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_ShowBeatenByMessage;
    /// <summary>
    /// Function: UC_ShowBeatenByMessage
    /// </summary>
    public unsafe virtual void UC_ShowBeatenByMessage(BmSDK.FStringArg sMessage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_ShowBeatenByMessage, "BmScript.RGFxMovieUI_ChallengeSelect.UC_ShowBeatenByMessage", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sMessage.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe override void OnFadeCompleted_Callback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFadeCompleted_Callback, "BmScript.RGFxMovieUI_ChallengeSelect.OnFadeCompleted_Callback", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_FilterCharacter;
    /// <summary>
    /// Function: XI_FilterCharacter
    /// </summary>
    public unsafe virtual bool XI_FilterCharacter(BmSDK.FStringArg Stab, int nId, BmSDK.FStringArg sCharacter, bool bDefault)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_FilterCharacter, "BmScript.RGFxMovieUI_ChallengeSelect.XI_FilterCharacter", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Stab.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 16);
        sCharacter.WriteTo(paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDefault, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetActorListPackage;
    /// <summary>
    /// Function: XI_GetActorListPackage
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetActorListPackage(BmSDK.FStringArg sCharacter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetActorListPackage, "BmScript.RGFxMovieUI_ChallengeSelect.XI_GetActorListPackage", this);
        byte* paramsPtr = stackalloc byte[212];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sCharacter.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetExtraStars;
    /// <summary>
    /// Function: XI_GetExtraStars
    /// </summary>
    public unsafe virtual int XI_GetExtraStars(int iChallenge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetExtraStars, "BmScript.RGFxMovieUI_ChallengeSelect.XI_GetExtraStars", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iChallenge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetChallengeStars;
    /// <summary>
    /// Function: XI_GetChallengeStars
    /// </summary>
    public unsafe virtual int XI_GetChallengeStars(int nId, BmSDK.FStringArg sCharacter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetChallengeStars, "BmScript.RGFxMovieUI_ChallengeSelect.XI_GetChallengeStars", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        sCharacter.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RefreshChallengeScores;
    /// <summary>
    /// Function: XI_RefreshChallengeScores
    /// </summary>
    public unsafe virtual void XI_RefreshChallengeScores(int nId, BmSDK.FStringArg sCharacter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RefreshChallengeScores, "BmScript.RGFxMovieUI_ChallengeSelect.XI_RefreshChallengeScores", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        sCharacter.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_LaunchChallenge;
    /// <summary>
    /// Function: XI_LaunchChallenge
    /// </summary>
    public unsafe virtual void XI_LaunchChallenge(int nId, BmSDK.FStringArg sCharacter, bool bDefault)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_LaunchChallenge, "BmScript.RGFxMovieUI_ChallengeSelect.XI_LaunchChallenge", this);
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        sCharacter.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDefault, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ChallengeSelectEnumerate;
    /// <summary>
    /// Function: XI_ChallengeSelectEnumerate
    /// </summary>
    public unsafe virtual void XI_ChallengeSelectEnumerate(BmSDK.FStringArg sTargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ChallengeSelectEnumerate, "BmScript.RGFxMovieUI_ChallengeSelect.XI_ChallengeSelectEnumerate", this);
        byte* paramsPtr = stackalloc byte[204];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sTargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_FetchExtremeModeToggle;
    /// <summary>
    /// Function: XI_FetchExtremeModeToggle
    /// </summary>
    public unsafe virtual void XI_FetchExtremeModeToggle(int nId, bool bOnSelected = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_FetchExtremeModeToggle, "BmScript.RGFxMovieUI_ChallengeSelect.XI_FetchExtremeModeToggle", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnSelected, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ToggleExtremeMode;
    /// <summary>
    /// Function: XI_ToggleExtremeMode
    /// </summary>
    public unsafe virtual void XI_ToggleExtremeMode(int nId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ToggleExtremeMode, "BmScript.RGFxMovieUI_ChallengeSelect.XI_ToggleExtremeMode", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetExtremeInfo;
    /// <summary>
    /// Function: UC_SetExtremeInfo
    /// </summary>
    public unsafe virtual void UC_SetExtremeInfo(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetExtremeInfo, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetExtremeInfo", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetChallengeScores;
    /// <summary>
    /// Function: UC_SetChallengeScores
    /// </summary>
    public unsafe virtual void UC_SetChallengeScores(int nId, int nMedals, BmSDK.FStringArg sScore, int nRivalPoints)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetChallengeScores, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetChallengeScores", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nMedals, paramsPtr + 4);
        sScore.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRivalPoints, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_AddChallenge;
    /// <summary>
    /// Function: UC_AddChallenge
    /// </summary>
    public unsafe virtual void UC_AddChallenge(BmSDK.FStringArg Stab, int nId, BmSDK.FStringArg sStatus, BmSDK.FStringArg sMode, int nMedals, BmSDK.FStringArg sScore, int nRivalPoints, BmSDK.FStringArg sActiveCharacter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_AddChallenge, "BmScript.RGFxMovieUI_ChallengeSelect.UC_AddChallenge", this);
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Stab.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 16);
        sStatus.WriteTo(paramsPtr + 20);
        sMode.WriteTo(paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nMedals, paramsPtr + 52);
        sScore.WriteTo(paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRivalPoints, paramsPtr + 72);
        sActiveCharacter.WriteTo(paramsPtr + 76);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 56);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 76);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_AddAvailableCharacter;
    /// <summary>
    /// Function: UC_AddAvailableCharacter
    /// </summary>
    public unsafe virtual void UC_AddAvailableCharacter(BmSDK.FStringArg sName, int nId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_AddAvailableCharacter, "BmScript.RGFxMovieUI_ChallengeSelect.UC_AddAvailableCharacter", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetDefaultChallenge;
    /// <summary>
    /// Function: UC_SetDefaultChallenge
    /// </summary>
    public unsafe virtual void UC_SetDefaultChallenge(int nId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetDefaultChallenge, "BmScript.RGFxMovieUI_ChallengeSelect.UC_SetDefaultChallenge", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnOut, "BmScript.RGFxMovieUI_ChallengeSelect.XI_OnOut", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_ChallengeSelect.CloseScreen", this);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmScript.RGFxMovieUI_ChallengeSelect.Init", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StrProperty: m_sMoviePath
    /// </summary>
    public unsafe BmSDK.FString m_sMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: m_sOverridePlayers
    /// </summary>
    public unsafe BmSDK.FString m_sOverridePlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// StrProperty: m_sOverrideBatmobiles
    /// </summary>
    public unsafe BmSDK.FString m_sOverrideBatmobiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ByteProperty: m_eLeaderboardFetchType
    /// </summary>
    public unsafe BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType m_eLeaderboardFetchType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// IntProperty: m_nLeaderboardChallengeId
    /// </summary>
    public unsafe int m_nLeaderboardChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: m_nLeaderboardId
    /// </summary>
    public unsafe int m_nLeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bBeatenByActive
    /// </summary>
    public unsafe bool bBeatenByActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bRePollingLeaderboard
    /// </summary>
    public unsafe bool bRePollingLeaderboard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bSaveOptions
    /// </summary>
    public unsafe bool bSaveOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bAllowCharacterFilter
    /// </summary>
    public unsafe bool bAllowCharacterFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bExtremeModeToggle
    /// </summary>
    public unsafe bool bExtremeModeToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bLastFetchEmpty
    /// </summary>
    public unsafe bool bLastFetchEmpty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// Enum: CSLBMode
    /// </summary>
    public enum CSLBMode : byte
    {
        CSLBMode_Friends = 0,
        CSLBMode_Ranked = 1,
        CSLBMode_Top100 = 2,
        CSLBMode_MAX = 3,
    }
}
