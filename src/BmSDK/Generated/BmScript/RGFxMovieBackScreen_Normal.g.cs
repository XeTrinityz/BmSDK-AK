#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieBackScreen_Normal<br/>
/// (size = 2316)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieBackScreen_Normal : BmSDK.BmGame.RGFxMovieBackScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieBackScreen_Normal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieBackScreen_Normal.
    /// </summary>
    public static RGFxMovieBackScreen_Normal DefaultObject => (RGFxMovieBackScreen_Normal)StaticClass().DefaultObject;

    internal RGFxMovieBackScreen_Normal() { }

    /// <summary>
    /// Constructs a new RGFxMovieBackScreen_Normal
    /// </summary>
    public RGFxMovieBackScreen_Normal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieBackScreen_Normal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieBackScreen_Normal(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen_Normal>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen_Normal>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen_Normal>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen_Normal>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen_Normal>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen_Normal>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen_Normal>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieBackScreen_Normal>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetSideOverlay;
    /// <summary>
    /// Function: XI_GetSideOverlay
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetSideOverlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetSideOverlay, "BmScript.RGFxMovieBackScreen_Normal.XI_GetSideOverlay", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnLineStopped;
    /// <summary>
    /// Function: XI_OnLineStopped
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult XI_OnLineStopped(BmSDK.Engine.AkDialogueLine dlgLine, BmSDK.Engine.AkDialogueEvent dlgEvent, BmSDK.GameObject dlgSpeaker, bool interrupted)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnLineStopped, "BmScript.RGFxMovieBackScreen_Normal.XI_OnLineStopped", this);
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnLineStarted;
    /// <summary>
    /// Function: XI_OnLineStarted
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult XI_OnLineStarted(BmSDK.Engine.AkDialogueLine dlgLine, BmSDK.Engine.AkDialogueEvent dlgEvent, BmSDK.GameObject dlgSpeaker, bool bBarkSquelch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnLineStarted, "BmScript.RGFxMovieBackScreen_Normal.XI_OnLineStarted", this);
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBarkSquelch, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnSpeechStopped;
    /// <summary>
    /// Function: XI_OnSpeechStopped
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult XI_OnSpeechStopped(int speechId, bool interrupted)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnSpeechStopped, "BmScript.RGFxMovieBackScreen_Normal.XI_OnSpeechStopped", this);
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnSpeechStarted;
    /// <summary>
    /// Function: XI_OnSpeechStarted
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkDialogue.AkDialogueCallbackResult XI_OnSpeechStarted(int speechId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnSpeechStarted, "BmScript.RGFxMovieBackScreen_Normal.XI_OnSpeechStarted", this);
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_IsDialogActive;
    /// <summary>
    /// Function: XI_IsDialogActive
    /// </summary>
    public unsafe virtual bool XI_IsDialogActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_IsDialogActive, "BmScript.RGFxMovieBackScreen_Normal.XI_IsDialogActive", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_StopDialog;
    /// <summary>
    /// Function: XI_StopDialog
    /// </summary>
    public unsafe virtual void XI_StopDialog()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_StopDialog, "BmScript.RGFxMovieBackScreen_Normal.XI_StopDialog", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_PlayDialog;
    /// <summary>
    /// Function: XI_PlayDialog
    /// </summary>
    public unsafe virtual BmSDK.FString XI_PlayDialog(BmSDK.FStringArg RefName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_PlayDialog, "BmScript.RGFxMovieBackScreen_Normal.XI_PlayDialog", this);
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        RefName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LeaderboardTick;
    /// <summary>
    /// Function: LeaderboardTick
    /// </summary>
    public unsafe virtual void LeaderboardTick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LeaderboardTick, "BmScript.RGFxMovieBackScreen_Normal.LeaderboardTick", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsPollingBoards;
    /// <summary>
    /// Function: IsPollingBoards
    /// </summary>
    public unsafe virtual bool IsPollingBoards()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsPollingBoards, "BmScript.RGFxMovieBackScreen_Normal.IsPollingBoards", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FetchLeaderboard;
    /// <summary>
    /// Function: FetchLeaderboard
    /// </summary>
    public unsafe virtual void FetchLeaderboard()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FetchLeaderboard, "BmScript.RGFxMovieBackScreen_Normal.FetchLeaderboard", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_TriggerLeaderboard;
    /// <summary>
    /// Function: UC_TriggerLeaderboard
    /// </summary>
    public unsafe virtual void UC_TriggerLeaderboard(int FriendCount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_TriggerLeaderboard, "BmScript.RGFxMovieBackScreen_Normal.UC_TriggerLeaderboard", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendLeaderBoardToFlash;
    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe override void SendLeaderBoardToFlash(int Id, int total, BmSDK.TArray<int> FriendIndex, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> NetIDs, BmSDK.TArray<int> Ranks, BmSDK.TArray<BmSDK.FString> NickNames, BmSDK.TArray<int> Medals, BmSDK.TArray<float> Scores, BmSDK.TArray<int> RivalPoints, BmSDK.TArray<float> Story, BmSDK.TArray<float> MW, BmSDK.TArray<float> AR)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendLeaderBoardToFlash, "BmScript.RGFxMovieBackScreen_Normal.SendLeaderBoardToFlash", this);
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetIDs, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ranks, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickNames, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medals, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scores, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RivalPoints, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Story, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MW, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AR, paramsPtr + 152);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetLeaderboardLine;
    /// <summary>
    /// Function: UC_SetLeaderboardLine
    /// </summary>
    public unsafe virtual void UC_SetLeaderboardLine(int Index, int Rank, BmSDK.FStringArg NickName, int Medals, BmSDK.FStringArg Score, bool bIsMe)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetLeaderboardLine, "BmScript.RGFxMovieBackScreen_Normal.UC_SetLeaderboardLine", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rank, paramsPtr + 4);
        NickName.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medals, paramsPtr + 24);
        Score.WriteTo(paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsMe, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RegisterLeaderboardPath;
    /// <summary>
    /// Function: XI_RegisterLeaderboardPath
    /// </summary>
    public unsafe virtual void XI_RegisterLeaderboardPath(BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RegisterLeaderboardPath, "BmScript.RGFxMovieBackScreen_Normal.XI_RegisterLeaderboardPath", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetVideoProgressName;
    /// <summary>
    /// Function: XI_GetVideoProgressName
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetVideoProgressName(BmSDK.FStringArg MissionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetVideoProgressName, "BmScript.RGFxMovieBackScreen_Normal.XI_GetVideoProgressName", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        MissionName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OpenScreen;
    /// <summary>
    /// Function: XI_OpenScreen
    /// </summary>
    public unsafe override void XI_OpenScreen(BmSDK.FStringArg ScreenName, bool bIsFirstScreen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OpenScreen, "BmScript.RGFxMovieBackScreen_Normal.XI_OpenScreen", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        ScreenName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsFirstScreen, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe override void XI_Tick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_Tick, "BmScript.RGFxMovieBackScreen_Normal.XI_Tick", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_PromptClicked;
    /// <summary>
    /// Function: XI_PromptClicked
    /// </summary>
    public unsafe virtual void XI_PromptClicked(int PromptId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_PromptClicked, "BmScript.RGFxMovieBackScreen_Normal.XI_PromptClicked", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnOut, "BmScript.RGFxMovieBackScreen_Normal.XI_OnOut", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetupTabMenu;
    /// <summary>
    /// Function: XI_SetupTabMenu
    /// </summary>
    public unsafe override int XI_SetupTabMenu(BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetupTabMenu, "BmScript.RGFxMovieBackScreen_Normal.XI_SetupTabMenu", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayAzraelMinigameDialogue;
    /// <summary>
    /// Function: PlayAzraelMinigameDialogue
    /// </summary>
    public unsafe virtual void PlayAzraelMinigameDialogue(byte dialogue_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayAzraelMinigameDialogue, "BmScript.RGFxMovieBackScreen_Normal.PlayAzraelMinigameDialogue", this);
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dialogue_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetRumbleFromFlash;
    /// <summary>
    /// Function: XI_SetRumbleFromFlash
    /// </summary>
    public unsafe virtual void XI_SetRumbleFromFlash(float left_rumble, float right_rumble)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetRumbleFromFlash, "BmScript.RGFxMovieBackScreen_Normal.XI_SetRumbleFromFlash", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_rumble, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_rumble, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetMouseCursorEnabled;
    /// <summary>
    /// Function: SetMouseCursorEnabled
    /// </summary>
    public unsafe override void SetMouseCursorEnabled(bool is_enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetMouseCursorEnabled, "BmScript.RGFxMovieBackScreen_Normal.SetMouseCursorEnabled", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PreemptivelyBlockInputForMinigame;
    /// <summary>
    /// Function: PreemptivelyBlockInputForMinigame
    /// </summary>
    public unsafe override void PreemptivelyBlockInputForMinigame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PreemptivelyBlockInputForMinigame, "BmScript.RGFxMovieBackScreen_Normal.PreemptivelyBlockInputForMinigame", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PrepBatmanChallengeRequirements;
    /// <summary>
    /// Function: PrepBatmanChallengeRequirements
    /// </summary>
    public unsafe virtual void PrepBatmanChallengeRequirements(out BmSDK.TArray<int> AreNotPossible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PrepBatmanChallengeRequirements, "BmScript.RGFxMovieBackScreen_Normal.PrepBatmanChallengeRequirements", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AreNotPossible = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RiddlerScreenShowMapItemSecret;
    /// <summary>
    /// Function: XI_RiddlerScreenShowMapItemSecret
    /// </summary>
    public unsafe virtual bool XI_RiddlerScreenShowMapItemSecret(BmSDK.FStringArg sItemName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RiddlerScreenShowMapItemSecret, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenShowMapItemSecret", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sItemName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RiddlerScreenGotoReward;
    /// <summary>
    /// Function: XI_RiddlerScreenGotoReward
    /// </summary>
    public unsafe virtual void XI_RiddlerScreenGotoReward(BmSDK.FStringArg sReward)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RiddlerScreenGotoReward, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenGotoReward", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sReward.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RiddlerScreenUnlockReward;
    /// <summary>
    /// Function: XI_RiddlerScreenUnlockReward
    /// </summary>
    public unsafe virtual void XI_RiddlerScreenUnlockReward(BmSDK.FStringArg sReward)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RiddlerScreenUnlockReward, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenUnlockReward", this);
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sReward.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RiddlerScreenSetPieceCompleted;
    /// <summary>
    /// Function: XI_RiddlerScreenSetPieceCompleted
    /// </summary>
    public unsafe virtual void XI_RiddlerScreenSetPieceCompleted(int nPuzzle, int nPiece)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RiddlerScreenSetPieceCompleted, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenSetPieceCompleted", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPiece, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RiddlerScreenSetPieceViewed;
    /// <summary>
    /// Function: XI_RiddlerScreenSetPieceViewed
    /// </summary>
    public unsafe virtual void XI_RiddlerScreenSetPieceViewed(int nPuzzle, int nPiece)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RiddlerScreenSetPieceViewed, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenSetPieceViewed", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPiece, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RiddlerScreenSetPieceActive;
    /// <summary>
    /// Function: XI_RiddlerScreenSetPieceActive
    /// </summary>
    public unsafe virtual void XI_RiddlerScreenSetPieceActive(int nPuzzle, int nPiece)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RiddlerScreenSetPieceActive, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenSetPieceActive", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPiece, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RiddlerScreenRequestData;
    /// <summary>
    /// Function: XI_RiddlerScreenRequestData
    /// </summary>
    public unsafe virtual void XI_RiddlerScreenRequestData(BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RiddlerScreenRequestData, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenRequestData", this);
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_RiddlerScreenSetSelection;
    /// <summary>
    /// Function: UC_RiddlerScreenSetSelection
    /// </summary>
    public unsafe virtual void UC_RiddlerScreenSetSelection(int nPuzzleId, int nPieceIndex, bool bImmediate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_RiddlerScreenSetSelection, "BmScript.RGFxMovieBackScreen_Normal.UC_RiddlerScreenSetSelection", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzleId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPieceIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_RiddlerScreenAddPuzzle;
    /// <summary>
    /// Function: UC_RiddlerScreenAddPuzzle
    /// </summary>
    public unsafe virtual void UC_RiddlerScreenAddPuzzle(int nId, BmSDK.FStringArg sCategory, BmSDK.FStringArg sPuzzle, BmSDK.FStringArg sPrize)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_RiddlerScreenAddPuzzle, "BmScript.RGFxMovieBackScreen_Normal.UC_RiddlerScreenAddPuzzle", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        sCategory.WriteTo(paramsPtr + 4);
        sPuzzle.WriteTo(paramsPtr + 20);
        sPrize.WriteTo(paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_CitySave;
    /// <summary>
    /// Function: XI_CitySave
    /// </summary>
    public unsafe virtual void XI_CitySave(int Index, int PageIndex, int TapeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_CitySave, "BmScript.RGFxMovieBackScreen_Normal.XI_CitySave", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PageIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TapeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BioSave;
    /// <summary>
    /// Function: XI_BioSave
    /// </summary>
    public unsafe virtual void XI_BioSave(int LocIndex, int Loc0Index, int Loc1Index, int Loc2Index, int PageIndex, int TapeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BioSave, "BmScript.RGFxMovieBackScreen_Normal.XI_BioSave", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc0Index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc1Index, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc2Index, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PageIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TapeIndex, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ClearCityStoryNew;
    /// <summary>
    /// Function: XI_ClearCityStoryNew
    /// </summary>
    public unsafe virtual void XI_ClearCityStoryNew(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ClearCityStoryNew, "BmScript.RGFxMovieBackScreen_Normal.XI_ClearCityStoryNew", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ClearBioNew;
    /// <summary>
    /// Function: XI_ClearBioNew
    /// </summary>
    public unsafe virtual void XI_ClearBioNew(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ClearBioNew, "BmScript.RGFxMovieBackScreen_Normal.XI_ClearBioNew", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestBiosLocNews;
    /// <summary>
    /// Function: XI_RequestBiosLocNews
    /// </summary>
    public unsafe virtual void XI_RequestBiosLocNews(BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestBiosLocNews, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestBiosLocNews", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestBiosData;
    /// <summary>
    /// Function: XI_RequestBiosData
    /// </summary>
    public unsafe virtual void XI_RequestBiosData(int PageId, BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestBiosData, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestBiosData", this);
        byte* paramsPtr = stackalloc byte[176];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PageId, paramsPtr + 0);
        TargetPath.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestBiosBaseData;
    /// <summary>
    /// Function: XI_RequestBiosBaseData
    /// </summary>
    public unsafe virtual void XI_RequestBiosBaseData(BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestBiosBaseData, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestBiosBaseData", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBioCharacterList;
    /// <summary>
    /// Function: GetBioCharacterList
    /// </summary>
    public unsafe virtual void GetBioCharacterList(out BmSDK.TArray<BmSDK.FString> CharList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBioCharacterList, "BmScript.RGFxMovieBackScreen_Normal.GetBioCharacterList", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CharList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_UpgradeScreenCommit;
    /// <summary>
    /// Function: XI_UpgradeScreenCommit
    /// </summary>
    public unsafe virtual void XI_UpgradeScreenCommit(BmSDK.FStringArg sUpgrade, int nValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_UpgradeScreenCommit, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenCommit", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sUpgrade.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nValue, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_UpgradeScreenRequestPage;
    /// <summary>
    /// Function: XI_UpgradeScreenRequestPage
    /// </summary>
    public unsafe virtual void XI_UpgradeScreenRequestPage(BmSDK.FStringArg sPage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_UpgradeScreenRequestPage, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenRequestPage", this);
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPage.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_UpgradeScreenRequestExperience;
    /// <summary>
    /// Function: XI_UpgradeScreenRequestExperience
    /// </summary>
    public unsafe virtual void XI_UpgradeScreenRequestExperience()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_UpgradeScreenRequestExperience, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenRequestExperience", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_UpgradeScreenSetup;
    /// <summary>
    /// Function: XI_UpgradeScreenSetup
    /// </summary>
    public unsafe virtual void XI_UpgradeScreenSetup(BmSDK.FStringArg sPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_UpgradeScreenSetup, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenSetup", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_UpgradeScreenViewedItem;
    /// <summary>
    /// Function: XI_UpgradeScreenViewedItem
    /// </summary>
    public unsafe virtual void XI_UpgradeScreenViewedItem(BmSDK.FStringArg sUpgrade)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_UpgradeScreenViewedItem, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenViewedItem", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sUpgrade.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_UpgradeAddNode;
    /// <summary>
    /// Function: UC_UpgradeAddNode
    /// </summary>
    public unsafe virtual void UC_UpgradeAddNode(int nX, int nY, int nDX, int nDY, BmSDK.FStringArg sUpgrade, BmSDK.FStringArg sIcon, BmSDK.FStringArg sBackground, BmSDK.FStringArg sState, BmSDK.FStringArg sAction, int nValue, int nTotal, float fScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_UpgradeAddNode, "BmScript.RGFxMovieBackScreen_Normal.UC_UpgradeAddNode", this);
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nDX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nDY, paramsPtr + 12);
        sUpgrade.WriteTo(paramsPtr + 16);
        sIcon.WriteTo(paramsPtr + 32);
        sBackground.WriteTo(paramsPtr + 48);
        sState.WriteTo(paramsPtr + 64);
        sAction.WriteTo(paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nValue, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nTotal, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fScale, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 64);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 80);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_UpgradeAddHeader;
    /// <summary>
    /// Function: UC_UpgradeAddHeader
    /// </summary>
    public unsafe virtual void UC_UpgradeAddHeader(int nNodeX, int nNodeY, BmSDK.FStringArg sHeader, bool bLeftJustify, float fOX, float fOY, float fTX, float fTY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_UpgradeAddHeader, "BmScript.RGFxMovieBackScreen_Normal.UC_UpgradeAddHeader", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nNodeX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nNodeY, paramsPtr + 4);
        sHeader.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeftJustify, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fOX, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fOY, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTX, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTY, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_UpgradeSetExperience;
    /// <summary>
    /// Function: UC_UpgradeSetExperience
    /// </summary>
    public unsafe virtual void UC_UpgradeSetExperience(int nAwards, int nPoints, int nTotal, BmSDK.FStringArg sDescription, int iPlayerLevel, int iUpgradesRemaining)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_UpgradeSetExperience, "BmScript.RGFxMovieBackScreen_Normal.UC_UpgradeSetExperience", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nAwards, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPoints, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nTotal, paramsPtr + 8);
        sDescription.WriteTo(paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPlayerLevel, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iUpgradesRemaining, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetFanActive;
    /// <summary>
    /// Function: XI_GetFanActive
    /// </summary>
    public unsafe virtual bool XI_GetFanActive(int FloorNumber)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetFanActive, "BmScript.RGFxMovieBackScreen_Normal.XI_GetFanActive", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloorNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetBatmobileScrewState;
    /// <summary>
    /// Function: XI_GetBatmobileScrewState
    /// </summary>
    public unsafe virtual float XI_GetBatmobileScrewState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetBatmobileScrewState, "BmScript.RGFxMovieBackScreen_Normal.XI_GetBatmobileScrewState", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetStickAngMag;
    /// <summary>
    /// Function: XI_GetStickAngMag
    /// </summary>
    public unsafe virtual void XI_GetStickAngMag(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetStickAngMag, "BmScript.RGFxMovieBackScreen_Normal.XI_GetStickAngMag", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCameraRotation;
    /// <summary>
    /// Function: GetCameraRotation
    /// </summary>
    public unsafe virtual float GetCameraRotation(int Axis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCameraRotation, "BmScript.RGFxMovieBackScreen_Normal.GetCameraRotation", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Axis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPlayerRoomDescription;
    /// <summary>
    /// Function: GetPlayerRoomDescription
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerRoomDescription()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPlayerRoomDescription, "BmScript.RGFxMovieBackScreen_Normal.GetPlayerRoomDescription", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RiddleNameCorrect;
    /// <summary>
    /// Function: XI_RiddleNameCorrect
    /// </summary>
    public unsafe virtual BmSDK.FString XI_RiddleNameCorrect(BmSDK.FStringArg ItemName, BmSDK.FStringArg InName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RiddleNameCorrect, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddleNameCorrect", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        ItemName.WriteTo(paramsPtr + 0);
        InName.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetCustomWaypointSideStoryInfo;
    /// <summary>
    /// Function: XI_SetCustomWaypointSideStoryInfo
    /// </summary>
    public unsafe virtual void XI_SetCustomWaypointSideStoryInfo(BmSDK.FStringArg SS_Character, BmSDK.FStringArg VisibleFlag, BmSDK.FStringArg DoneFlag, BmSDK.FStringArg StatesNew)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetCustomWaypointSideStoryInfo, "BmScript.RGFxMovieBackScreen_Normal.XI_SetCustomWaypointSideStoryInfo", this);
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        SS_Character.WriteTo(paramsPtr + 0);
        VisibleFlag.WriteTo(paramsPtr + 16);
        DoneFlag.WriteTo(paramsPtr + 32);
        StatesNew.WriteTo(paramsPtr + 48);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetIconState;
    /// <summary>
    /// Function: XI_SetIconState
    /// </summary>
    public unsafe override void XI_SetIconState(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetIconState, "BmScript.RGFxMovieBackScreen_Normal.XI_SetIconState", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetCustomWaypoint;
    /// <summary>
    /// Function: XI_SetCustomWaypoint
    /// </summary>
    public unsafe virtual void XI_SetCustomWaypoint(bool bEnabled, float atX, float atY, float atZ, BmSDK.FStringArg WaypointName, BmSDK.FStringArg WaypointTypeName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetCustomWaypoint, "BmScript.RGFxMovieBackScreen_Normal.XI_SetCustomWaypoint", this);
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 12);
        WaypointName.WriteTo(paramsPtr + 16);
        WaypointTypeName.WriteTo(paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnCustomWaypointDisabled;
    /// <summary>
    /// Function: XI_OnCustomWaypointDisabled
    /// </summary>
    public unsafe virtual void XI_OnCustomWaypointDisabled(BmSDK.FStringArg WaypointName, BmSDK.FStringArg WaypointTypeName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnCustomWaypointDisabled, "BmScript.RGFxMovieBackScreen_Normal.XI_OnCustomWaypointDisabled", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        WaypointName.WriteTo(paramsPtr + 0);
        WaypointTypeName.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetFloorZAtPosition;
    /// <summary>
    /// Function: XI_GetFloorZAtPosition
    /// </summary>
    public unsafe virtual void XI_GetFloorZAtPosition(float atX, float atY, float atZ)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetFloorZAtPosition, "BmScript.RGFxMovieBackScreen_Normal.XI_GetFloorZAtPosition", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ChangeIconFilter;
    /// <summary>
    /// Function: XI_ChangeIconFilter
    /// </summary>
    public unsafe virtual void XI_ChangeIconFilter(int FilterId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ChangeIconFilter, "BmScript.RGFxMovieBackScreen_Normal.XI_ChangeIconFilter", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetActiveFilters;
    /// <summary>
    /// Function: GetActiveFilters
    /// </summary>
    public unsafe virtual BmSDK.TArray<int> GetActiveFilters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetActiveFilters, "BmScript.RGFxMovieBackScreen_Normal.GetActiveFilters", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RemoveMapObj;
    /// <summary>
    /// Function: XI_RemoveMapObj
    /// </summary>
    public unsafe virtual void XI_RemoveMapObj(BmSDK.FStringArg ItemName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RemoveMapObj, "BmScript.RGFxMovieBackScreen_Normal.XI_RemoveMapObj", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        ItemName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_MapSave;
    /// <summary>
    /// Function: XI_MapSave
    /// </summary>
    public unsafe virtual void XI_MapSave(int DBIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_MapSave, "BmScript.RGFxMovieBackScreen_Normal.XI_MapSave", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DBIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestMapIconData;
    /// <summary>
    /// Function: XI_RequestMapIconData
    /// </summary>
    public unsafe virtual void XI_RequestMapIconData(BmSDK.FStringArg MapName, BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestMapIconData, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestMapIconData", this);
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        MapName.WriteTo(paramsPtr + 0);
        TargetBasePath.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RequestMapFlagData;
    /// <summary>
    /// Function: RequestMapFlagData
    /// </summary>
    public unsafe virtual void RequestMapFlagData(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RequestMapFlagData, "BmScript.RGFxMovieBackScreen_Normal.RequestMapFlagData", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestMapData;
    /// <summary>
    /// Function: XI_RequestMapData
    /// </summary>
    public unsafe virtual void XI_RequestMapData(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestMapData, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestMapData", this);
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_FetchSelectedItemData;
    /// <summary>
    /// Function: XI_FetchSelectedItemData
    /// </summary>
    public unsafe virtual void XI_FetchSelectedItemData(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_FetchSelectedItemData, "BmScript.RGFxMovieBackScreen_Normal.XI_FetchSelectedItemData", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetIconInfo;
    /// <summary>
    /// Function: UC_SetIconInfo
    /// </summary>
    public unsafe virtual void UC_SetIconInfo(int Index, BmSDK.FStringArg TypeName, BmSDK.FStringArg instancename, int X, int Y, int Z, int Flags, BmSDK.FStringArg RemapTypeName, BmSDK.FStringArg RemapInstanceName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetIconInfo, "BmScript.RGFxMovieBackScreen_Normal.UC_SetIconInfo", this);
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        TypeName.WriteTo(paramsPtr + 4);
        instancename.WriteTo(paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Flags, paramsPtr + 48);
        RemapTypeName.WriteTo(paramsPtr + 52);
        RemapInstanceName.WriteTo(paramsPtr + 68);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 52);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 68);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetHowToUnlockMsg;
    /// <summary>
    /// Function: XI_GetHowToUnlockMsg
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetHowToUnlockMsg(BmSDK.FStringArg instancename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetHowToUnlockMsg, "BmScript.RGFxMovieBackScreen_Normal.XI_GetHowToUnlockMsg", this);
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        instancename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_IsChallengeUnLocked;
    /// <summary>
    /// Function: XI_IsChallengeUnLocked
    /// </summary>
    public unsafe virtual bool XI_IsChallengeUnLocked(BmSDK.FStringArg instancename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_IsChallengeUnLocked, "BmScript.RGFxMovieBackScreen_Normal.XI_IsChallengeUnLocked", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        instancename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_IsChallengeRevealed;
    /// <summary>
    /// Function: XI_IsChallengeRevealed
    /// </summary>
    public unsafe virtual bool XI_IsChallengeRevealed(BmSDK.FStringArg instancename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_IsChallengeRevealed, "BmScript.RGFxMovieBackScreen_Normal.XI_IsChallengeRevealed", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        instancename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetMedalCount;
    /// <summary>
    /// Function: XI_GetMedalCount
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetMedalCount(BmSDK.FStringArg instancename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetMedalCount, "BmScript.RGFxMovieBackScreen_Normal.XI_GetMedalCount", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        instancename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetARChallengeMedalCount;
    /// <summary>
    /// Function: GetARChallengeMedalCount
    /// </summary>
    public unsafe virtual int GetARChallengeMedalCount(BmSDK.FStringArg instancename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetARChallengeMedalCount, "BmScript.RGFxMovieBackScreen_Normal.GetARChallengeMedalCount", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        instancename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetActualChallengeDesc;
    /// <summary>
    /// Function: XI_GetActualChallengeDesc
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetActualChallengeDesc(BmSDK.FStringArg instancename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetActualChallengeDesc, "BmScript.RGFxMovieBackScreen_Normal.XI_GetActualChallengeDesc", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        instancename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetActualChallengeName;
    /// <summary>
    /// Function: XI_GetActualChallengeName
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetActualChallengeName(BmSDK.FStringArg instancename, bool bMixedCase)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetActualChallengeName, "BmScript.RGFxMovieBackScreen_Normal.XI_GetActualChallengeName", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        instancename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMixedCase, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCoOrdStr;
    /// <summary>
    /// Function: GetCoOrdStr
    /// </summary>
    public unsafe virtual BmSDK.FString GetCoOrdStr()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCoOrdStr, "BmScript.RGFxMovieBackScreen_Normal.GetCoOrdStr", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_Map3DMoveBy;
    /// <summary>
    /// Function: XI_Map3DMoveBy
    /// </summary>
    public unsafe virtual int XI_Map3DMoveBy(float DX, float DY, float dRotation, float dElevation, float dDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_Map3DMoveBy, "BmScript.RGFxMovieBackScreen_Normal.XI_Map3DMoveBy", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dRotation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dElevation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dDistance, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ApplyLimits;
    /// <summary>
    /// Function: ApplyLimits
    /// </summary>
    public unsafe virtual int ApplyLimits()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ApplyLimits, "BmScript.RGFxMovieBackScreen_Normal.ApplyLimits", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetScreenSize;
    /// <summary>
    /// Function: XI_GetScreenSize
    /// </summary>
    public unsafe virtual void XI_GetScreenSize(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetScreenSize, "BmScript.RGFxMovieBackScreen_Normal.XI_GetScreenSize", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetMouseCoodinates;
    /// <summary>
    /// Function: XI_GetMouseCoodinates
    /// </summary>
    public unsafe virtual void XI_GetMouseCoodinates(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetMouseCoodinates, "BmScript.RGFxMovieBackScreen_Normal.XI_GetMouseCoodinates", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetbUsingGamepad;
    /// <summary>
    /// Function: XI_GetbUsingGamepad
    /// </summary>
    public unsafe virtual void XI_GetbUsingGamepad(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetbUsingGamepad, "BmScript.RGFxMovieBackScreen_Normal.XI_GetbUsingGamepad", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_Map3DCityArea;
    /// <summary>
    /// Function: UC_Map3DCityArea
    /// </summary>
    public unsafe virtual void UC_Map3DCityArea(BmSDK.FStringArg sArea)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_Map3DCityArea, "BmScript.RGFxMovieBackScreen_Normal.UC_Map3DCityArea", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sArea.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetMap3DCoordinates;
    /// <summary>
    /// Function: XI_GetMap3DCoordinates
    /// </summary>
    public unsafe virtual void XI_GetMap3DCoordinates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetMap3DCoordinates, "BmScript.RGFxMovieBackScreen_Normal.XI_GetMap3DCoordinates", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_Map3DMoved;
    /// <summary>
    /// Function: UC_Map3DMoved
    /// </summary>
    public unsafe virtual void UC_Map3DMoved(float ToPosX, float ToPosY, float ToPosZ, float toRot, float ToElev, float ToDist, BmSDK.FStringArg CoOrdStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_Map3DMoved, "BmScript.RGFxMovieBackScreen_Normal.UC_Map3DMoved", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToPosX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToPosY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToPosZ, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(toRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToElev, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToDist, paramsPtr + 20);
        CoOrdStr.WriteTo(paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_PushCoOrd;
    /// <summary>
    /// Function: UC_PushCoOrd
    /// </summary>
    public unsafe virtual void UC_PushCoOrd(BmSDK.FStringArg CoOrdStr, bool bMoving, bool bTilting)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_PushCoOrd, "BmScript.RGFxMovieBackScreen_Normal.UC_PushCoOrd", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        CoOrdStr.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMoving, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTilting, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindFloor;
    /// <summary>
    /// Function: FindFloor
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindFloor(System.Numerics.Vector3 pos, System.Numerics.Vector3 Dest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindFloor, "BmScript.RGFxMovieBackScreen_Normal.FindFloor", this);
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dest, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_CalcMapScreenStick;
    /// <summary>
    /// Function: XI_CalcMapScreenStick
    /// </summary>
    public unsafe virtual int XI_CalcMapScreenStick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_CalcMapScreenStick, "BmScript.RGFxMovieBackScreen_Normal.XI_CalcMapScreenStick", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetupNextPanTarget;
    /// <summary>
    /// Function: SetupNextPanTarget
    /// </summary>
    public unsafe virtual void SetupNextPanTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetupNextPanTarget, "BmScript.RGFxMovieBackScreen_Normal.SetupNextPanTarget", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPanWait;
    /// <summary>
    /// Function: SetPanWait
    /// </summary>
    public unsafe virtual void SetPanWait()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPanWait, "BmScript.RGFxMovieBackScreen_Normal.SetPanWait", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_PanToXYZ;
    /// <summary>
    /// Function: XI_PanToXYZ
    /// </summary>
    public unsafe virtual void XI_PanToXYZ(float X, float Y, float Z)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_PanToXYZ, "BmScript.RGFxMovieBackScreen_Normal.XI_PanToXYZ", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_CenterMap;
    /// <summary>
    /// Function: XI_CenterMap
    /// </summary>
    public unsafe virtual void XI_CenterMap()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_CenterMap, "BmScript.RGFxMovieBackScreen_Normal.XI_CenterMap", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_CanCenter;
    /// <summary>
    /// Function: XI_CanCenter
    /// </summary>
    public unsafe virtual bool XI_CanCenter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_CanCenter, "BmScript.RGFxMovieBackScreen_Normal.XI_CanCenter", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindItemInList;
    /// <summary>
    /// Function: FindItemInList
    /// </summary>
    public unsafe virtual int FindItemInList(BmSDK.FStringArg ItemName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindItemInList, "BmScript.RGFxMovieBackScreen_Normal.FindItemInList", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        ItemName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetDroneDifficulty;
    /// <summary>
    /// Function: XI_GetDroneDifficulty
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetDroneDifficulty(BmSDK.FStringArg IconInstanceName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetDroneDifficulty, "BmScript.RGFxMovieBackScreen_Normal.XI_GetDroneDifficulty", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        IconInstanceName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetRiddlerInfoFor;
    /// <summary>
    /// Function: XI_GetRiddlerInfoFor
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetRiddlerInfoFor(BmSDK.FStringArg ItemTypeName, BmSDK.FStringArg ItemName, bool bIs2DMap)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetRiddlerInfoFor, "BmScript.RGFxMovieBackScreen_Normal.XI_GetRiddlerInfoFor", this);
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        ItemTypeName.WriteTo(paramsPtr + 0);
        ItemName.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIs2DMap, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_FetchSecretsCountFor;
    /// <summary>
    /// Function: XI_FetchSecretsCountFor
    /// </summary>
    public unsafe virtual bool XI_FetchSecretsCountFor(BmSDK.FStringArg PrevLocName, BmSDK.FStringArg NextLocName, BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_FetchSecretsCountFor, "BmScript.RGFxMovieBackScreen_Normal.XI_FetchSecretsCountFor", this);
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        PrevLocName.WriteTo(paramsPtr + 0);
        NextLocName.WriteTo(paramsPtr + 16);
        TargetPath.WriteTo(paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSecretsLocationName;
    /// <summary>
    /// Function: GetSecretsLocationName
    /// </summary>
    public unsafe virtual BmSDK.FString GetSecretsLocationName(BmSDK.FStringArg sName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSecretsLocationName, "BmScript.RGFxMovieBackScreen_Normal.GetSecretsLocationName", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SecretsCounterAvailable;
    /// <summary>
    /// Function: XI_SecretsCounterAvailable
    /// </summary>
    public unsafe virtual bool XI_SecretsCounterAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SecretsCounterAvailable, "BmScript.RGFxMovieBackScreen_Normal.XI_SecretsCounterAvailable", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetMap3DThreatLevel;
    /// <summary>
    /// Function: SetMap3DThreatLevel
    /// </summary>
    public unsafe virtual void SetMap3DThreatLevel(int Area, bool bAllowThreats)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetMap3DThreatLevel, "BmScript.RGFxMovieBackScreen_Normal.SetMap3DThreatLevel", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Area, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowThreats, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateThreatMeter;
    /// <summary>
    /// Function: UpdateThreatMeter
    /// </summary>
    public unsafe virtual void UpdateThreatMeter(int NewArea, bool TutorialMode = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateThreatMeter, "BmScript.RGFxMovieBackScreen_Normal.UpdateThreatMeter", this);
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewArea, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutorialMode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DoThreatLevelIntroAnim;
    /// <summary>
    /// Function: DoThreatLevelIntroAnim
    /// </summary>
    public unsafe virtual void DoThreatLevelIntroAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DoThreatLevelIntroAnim, "BmScript.RGFxMovieBackScreen_Normal.DoThreatLevelIntroAnim", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetThreatLevel;
    /// <summary>
    /// Function: SetThreatLevel
    /// </summary>
    public unsafe virtual void SetThreatLevel(BmSDK.FStringArg sCityName, BmSDK.FStringArg sThreats, bool bBatmobileAvailable, bool bTutorialMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetThreatLevel, "BmScript.RGFxMovieBackScreen_Normal.SetThreatLevel", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sCityName.WriteTo(paramsPtr + 0);
        sThreats.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatmobileAvailable, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTutorialMode, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RegisterThreatLevelMeter;
    /// <summary>
    /// Function: XI_RegisterThreatLevelMeter
    /// </summary>
    public unsafe virtual void XI_RegisterThreatLevelMeter(BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RegisterThreatLevelMeter, "BmScript.RGFxMovieBackScreen_Normal.XI_RegisterThreatLevelMeter", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RefreshThreatLevelMeter;
    /// <summary>
    /// Function: XI_RefreshThreatLevelMeter
    /// </summary>
    public unsafe virtual void XI_RefreshThreatLevelMeter(int AreaId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RefreshThreatLevelMeter, "BmScript.RGFxMovieBackScreen_Normal.XI_RefreshThreatLevelMeter", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AreaId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RoughlyCalcCityArea;
    /// <summary>
    /// Function: RoughlyCalcCityArea
    /// </summary>
    public unsafe virtual int RoughlyCalcCityArea(float PosX, float PosY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RoughlyCalcCityArea, "BmScript.RGFxMovieBackScreen_Normal.RoughlyCalcCityArea", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosY, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OutroTween;
    /// <summary>
    /// Function: XI_OutroTween
    /// </summary>
    public unsafe virtual bool XI_OutroTween()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OutroTween, "BmScript.RGFxMovieBackScreen_Normal.XI_OutroTween", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnOutro;
    /// <summary>
    /// Function: XI_OnOutro
    /// </summary>
    public unsafe override void XI_OnOutro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnOutro, "BmScript.RGFxMovieBackScreen_Normal.XI_OnOutro", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_IntroTween;
    /// <summary>
    /// Function: XI_IntroTween
    /// </summary>
    public unsafe virtual bool XI_IntroTween()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_IntroTween, "BmScript.RGFxMovieBackScreen_Normal.XI_IntroTween", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnIn;
    /// <summary>
    /// Function: XI_OnIn
    /// </summary>
    public unsafe override void XI_OnIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnIn, "BmScript.RGFxMovieBackScreen_Normal.XI_OnIn", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnIntro;
    /// <summary>
    /// Function: XI_OnIntro
    /// </summary>
    public unsafe override void XI_OnIntro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnIntro, "BmScript.RGFxMovieBackScreen_Normal.XI_OnIntro", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetMap3DRenderingCustomWaypoint;
    /// <summary>
    /// Function: SetMap3DRenderingCustomWaypoint
    /// </summary>
    public unsafe virtual void SetMap3DRenderingCustomWaypoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetMap3DRenderingCustomWaypoint, "BmScript.RGFxMovieBackScreen_Normal.SetMap3DRenderingCustomWaypoint", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Setup3DAutopan;
    /// <summary>
    /// Function: Setup3DAutopan
    /// </summary>
    public unsafe virtual void Setup3DAutopan(bool bIsSubMap)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Setup3DAutopan, "BmScript.RGFxMovieBackScreen_Normal.Setup3DAutopan", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSubMap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RequestStickCameraData;
    /// <summary>
    /// Function: RequestStickCameraData
    /// </summary>
    public unsafe virtual void RequestStickCameraData(BmSDK.FStringArg TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RequestStickCameraData, "BmScript.RGFxMovieBackScreen_Normal.RequestStickCameraData", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateVolumes;
    /// <summary>
    /// Function: UpdateVolumes
    /// </summary>
    public unsafe virtual void UpdateVolumes(BmSDK.FStringArg PlayerMap, BmSDK.FStringArg TargettedIcon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateVolumes, "BmScript.RGFxMovieBackScreen_Normal.UpdateVolumes", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        PlayerMap.WriteTo(paramsPtr + 0);
        TargettedIcon.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearMeshVolumes;
    /// <summary>
    /// Function: ClearMeshVolumes
    /// </summary>
    public unsafe virtual void ClearMeshVolumes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearMeshVolumes, "BmScript.RGFxMovieBackScreen_Normal.ClearMeshVolumes", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FindHighlightVolumeActors;
    /// <summary>
    /// Function: FindHighlightVolumeActors
    /// </summary>
    public unsafe virtual void FindHighlightVolumeActors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FindHighlightVolumeActors, "BmScript.RGFxMovieBackScreen_Normal.FindHighlightVolumeActors", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestMapScreen3DData;
    /// <summary>
    /// Function: XI_RequestMapScreen3DData
    /// </summary>
    public unsafe virtual void XI_RequestMapScreen3DData(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestMapScreen3DData, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestMapScreen3DData", this);
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetObjectiveStyle;
    /// <summary>
    /// Function: GetObjectiveStyle
    /// </summary>
    public unsafe virtual BmSDK.FString GetObjectiveStyle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetObjectiveStyle, "BmScript.RGFxMovieBackScreen_Normal.GetObjectiveStyle", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsOverworldGameplay;
    /// <summary>
    /// Function: IsOverworldGameplay
    /// </summary>
    public unsafe override bool IsOverworldGameplay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsOverworldGameplay, "BmScript.RGFxMovieBackScreen_Normal.IsOverworldGameplay", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestMapScreenData;
    /// <summary>
    /// Function: XI_RequestMapScreenData
    /// </summary>
    public unsafe virtual void XI_RequestMapScreenData(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestMapScreenData, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestMapScreenData", this);
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestObjectiveData;
    /// <summary>
    /// Function: XI_RequestObjectiveData
    /// </summary>
    public unsafe virtual int XI_RequestObjectiveData(BmSDK.FStringArg TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestObjectiveData, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestObjectiveData", this);
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        TargetBasePath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StoreVariablesToPData;
    /// <summary>
    /// Function: StoreVariablesToPData
    /// </summary>
    public unsafe override void StoreVariablesToPData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StoreVariablesToPData, "BmScript.RGFxMovieBackScreen_Normal.StoreVariablesToPData", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetVariablesFromPData;
    /// <summary>
    /// Function: SetVariablesFromPData
    /// </summary>
    public unsafe override void SetVariablesFromPData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetVariablesFromPData, "BmScript.RGFxMovieBackScreen_Normal.SetVariablesFromPData", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetVariablesFromPDD;
    /// <summary>
    /// Function: SetVariablesFromPDD
    /// </summary>
    public unsafe virtual void SetVariablesFromPDD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetVariablesFromPDD, "BmScript.RGFxMovieBackScreen_Normal.SetVariablesFromPDD", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FDialogEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FDialogEntry
    {
        /// <summary>
        /// StrProperty: RefName
        /// </summary>
        public unsafe BmSDK.FString RefName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: AkLineRef
        /// </summary>
        public unsafe BmSDK.Engine.AkHash AkLineRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkHash>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: Who
        /// </summary>
        public unsafe BmSDK.FString Who
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: KillOnClose
        /// </summary>
        public unsafe bool KillOnClose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FPromptEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FPromptEntry
    {
        /// <summary>
        /// ByteProperty: Id
        /// </summary>
        public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Label
        /// </summary>
        public unsafe BmSDK.FString Label
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSubMapDefault
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FSubMapDefault
    {
        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Rotation
        /// </summary>
        public unsafe float Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Elevation
        /// </summary>
        public unsafe float Elevation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// BoolProperty: bReadPending
    /// </summary>
    public unsafe bool bReadPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bMovedUserMarker
    /// </summary>
    public unsafe bool bMovedUserMarker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bCreatedIcons
    /// </summary>
    public unsafe bool bCreatedIcons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanEnabled
    /// </summary>
    public unsafe bool bPanEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanEnabledLast
    /// </summary>
    public unsafe bool bPanEnabledLast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanNoFirstEntryDelay
    /// </summary>
    public unsafe bool bPanNoFirstEntryDelay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanTweenElevationToo
    /// </summary>
    public unsafe bool bPanTweenElevationToo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bUpgradeCommitted
    /// </summary>
    public unsafe bool bUpgradeCommitted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: BioAutoSelect
    /// </summary>
    public unsafe bool BioAutoSelect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: BiobAutoPlay
    /// </summary>
    public unsafe bool BiobAutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: RumbleActive
    /// </summary>
    public unsafe bool RumbleActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bManualOpen
    /// </summary>
    public unsafe bool bManualOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bSaveGameWhenClosed
    /// </summary>
    public unsafe bool bSaveGameWhenClosed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// StrProperty: LeaderboardPath
    /// </summary>
    public unsafe BmSDK.FString LeaderboardPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: LerpRatio
    /// </summary>
    public unsafe float LerpRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// IntProperty: ChapterId
    /// </summary>
    public unsafe int ChapterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// StrProperty: ASClassPathTmp
    /// </summary>
    public unsafe BmSDK.FString ASClassPathTmp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// ArrayProperty: SubMapDefaults
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FSubMapDefault> SubMapDefaults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FSubMapDefault>>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ArrayProperty: Dialogs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FDialogEntry> Dialogs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FDialogEntry>>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ArrayProperty: SpeechIdsActive
    /// </summary>
    public unsafe BmSDK.TArray<int> SpeechIdsActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// IntProperty: IdOfGlobalSpeechPlaying
    /// </summary>
    public unsafe int IdOfGlobalSpeechPlaying
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// IntProperty: IndexOfLastGlobalSpeech
    /// </summary>
    public unsafe int IndexOfLastGlobalSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ArrayProperty: MapRiddleIconsInSubLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapRiddleIconsInSubLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetThreatLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetThreatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// IntProperty: ThreatLevelAreaLast
    /// </summary>
    public unsafe int ThreatLevelAreaLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// ArrayProperty: ThreatLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> ThreatLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ArrayProperty: ThreatLevelsLast
    /// </summary>
    public unsafe BmSDK.TArray<int> ThreatLevelsLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: OW_IncludeTheseExceptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OW_IncludeTheseExceptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: OW_ExcludeTheseExceptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OW_ExcludeTheseExceptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// StrProperty: MapScreenBasePath
    /// </summary>
    public unsafe BmSDK.FString MapScreenBasePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// StrProperty: MapScript
    /// </summary>
    public unsafe BmSDK.FString MapScript
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// StrProperty: MapCallback
    /// </summary>
    public unsafe BmSDK.FString MapCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// FloatProperty: TweenInRate
    /// </summary>
    public unsafe float TweenInRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// FloatProperty: TweenOutRate
    /// </summary>
    public unsafe float TweenOutRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// FloatProperty: DefaultHeight
    /// </summary>
    public unsafe float DefaultHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// FloatProperty: DefaultElevation
    /// </summary>
    public unsafe float DefaultElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// FloatProperty: DefaultDistance
    /// </summary>
    public unsafe float DefaultDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// StructProperty: StickLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StickLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1984);

    /// <summary>
    /// FloatProperty: StickRotation
    /// </summary>
    public unsafe float StickRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// FloatProperty: StickElevation
    /// </summary>
    public unsafe float StickElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// FloatProperty: StickDistance
    /// </summary>
    public unsafe float StickDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// StructProperty: TweenSourceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TweenSourceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2008);

    /// <summary>
    /// StructProperty: TweenSourceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator TweenSourceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2020);

    /// <summary>
    /// FloatProperty: TweenSourceFOV
    /// </summary>
    public unsafe float TweenSourceFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// StructProperty: TweenTargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TweenTargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2036);

    /// <summary>
    /// StructProperty: TweenTargetRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator TweenTargetRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2048);

    /// <summary>
    /// FloatProperty: TweenTargetFOV
    /// </summary>
    public unsafe float TweenTargetFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// StructProperty: CityOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CityOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2064);

    /// <summary>
    /// ArrayProperty: PanToIcons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PanToIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// StructProperty: PanReturnToLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PanReturnToLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2092);

    /// <summary>
    /// StructProperty: PanDelta
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PanDelta
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2104);

    /// <summary>
    /// StructProperty: PanXYZTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PanXYZTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2116);

    /// <summary>
    /// IntProperty: PanStep
    /// </summary>
    public unsafe int PanStep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// IntProperty: PanWait
    /// </summary>
    public unsafe int PanWait
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// FloatProperty: PanRate
    /// </summary>
    public unsafe float PanRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// FloatProperty: PanDeltaElev
    /// </summary>
    public unsafe float PanDeltaElev
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ArrayProperty: VolumeActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RockMapHighlight> VolumeActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RockMapHighlight>>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// StrProperty: TargettedIconLast
    /// </summary>
    public unsafe BmSDK.FString TargettedIconLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItems_InBuildings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerItems_InBuildings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItem_OffsetNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerItem_OffsetNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItem_OffsetValues
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerItem_OffsetValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpgradeScreen
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpgradeScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ArrayProperty: UpgradePrompts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FPromptEntry> UpgradePrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FPromptEntry>>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// IntProperty: BioLocIndex
    /// </summary>
    public unsafe int BioLocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ArrayProperty: BioIndex
    /// </summary>
    public unsafe BmSDK.TArray<int> BioIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// IntProperty: BioPageId
    /// </summary>
    public unsafe int BioPageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// IntProperty: BioTapeId
    /// </summary>
    public unsafe int BioTapeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RiddlerScreen
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RiddlerScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueLeft
    /// </summary>
    public unsafe float FlashRumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueRight
    /// </summary>
    public unsafe float FlashRumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// ObjectProperty: MinigameFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform MinigameFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }
}
