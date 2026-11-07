#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_MainMenu<br/>
/// (size = 1264)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_MainMenu : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_MainMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_MainMenu.
    /// </summary>
    public static RGFxMovieUI_MainMenu DefaultObject => (RGFxMovieUI_MainMenu)StaticClass().DefaultObject;

    internal RGFxMovieUI_MainMenu() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_MainMenu
    /// </summary>
    public RGFxMovieUI_MainMenu(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_MainMenu Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_MainMenu(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CheckForExternallyModifiedInis;
    /// <summary>
    /// Function: CheckForExternallyModifiedInis
    /// </summary>
    public unsafe virtual void CheckForExternallyModifiedInis()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForExternallyModifiedInis, "BmScript.RGFxMovieUI_MainMenu.CheckForExternallyModifiedInis");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckSystemMinSpecs;
    /// <summary>
    /// Function: CheckSystemMinSpecs
    /// </summary>
    public unsafe virtual void CheckSystemMinSpecs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSystemMinSpecs, "BmScript.RGFxMovieUI_MainMenu.CheckSystemMinSpecs");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckGiftRewardsPatch1;
    /// <summary>
    /// Function: CheckGiftRewardsPatch1
    /// </summary>
    public unsafe virtual void CheckGiftRewardsPatch1()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckGiftRewardsPatch1, "BmScript.RGFxMovieUI_MainMenu.CheckGiftRewardsPatch1");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetRivalIndex;
    /// <summary>
    /// Function: XI_SetRivalIndex
    /// </summary>
    public unsafe virtual void XI_SetRivalIndex(int Index, bool bChallengeData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetRivalIndex, "BmScript.RGFxMovieUI_MainMenu.XI_SetRivalIndex");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeData, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetRivalIndex;
    /// <summary>
    /// Function: XI_GetRivalIndex
    /// </summary>
    public unsafe virtual int XI_GetRivalIndex(bool bChallengeData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetRivalIndex, "BmScript.RGFxMovieUI_MainMenu.XI_GetRivalIndex");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_GetSelfIndex;
    /// <summary>
    /// Function: XI_GetSelfIndex
    /// </summary>
    public unsafe virtual int XI_GetSelfIndex(bool bChallengeData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetSelfIndex, "BmScript.RGFxMovieUI_MainMenu.XI_GetSelfIndex");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UC_ShowBeatenBy;
    /// <summary>
    /// Function: UC_ShowBeatenBy
    /// </summary>
    public unsafe virtual void UC_ShowBeatenBy(BmSDK.FString NewMsg)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_ShowBeatenBy, "BmScript.RGFxMovieUI_MainMenu.UC_ShowBeatenBy");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMsg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_CheckBeatenBy;
    /// <summary>
    /// Function: XI_CheckBeatenBy
    /// </summary>
    public unsafe virtual void XI_CheckBeatenBy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_CheckBeatenBy, "BmScript.RGFxMovieUI_MainMenu.XI_CheckBeatenBy");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckBeatenBy;
    /// <summary>
    /// Function: CheckBeatenBy
    /// </summary>
    public unsafe virtual void CheckBeatenBy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBeatenBy, "BmScript.RGFxMovieUI_MainMenu.CheckBeatenBy");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_RegisterBeatenBy;
    /// <summary>
    /// Function: XI_RegisterBeatenBy
    /// </summary>
    public unsafe virtual void XI_RegisterBeatenBy(BmSDK.FString TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_RegisterBeatenBy, "BmScript.RGFxMovieUI_MainMenu.XI_RegisterBeatenBy");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFriendBeatYou;
    /// <summary>
    /// Function: NotifyFriendBeatYou
    /// </summary>
    public unsafe override void NotifyFriendBeatYou()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFriendBeatYou, "BmScript.RGFxMovieUI_MainMenu.NotifyFriendBeatYou");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_MOTDSetPageImage;
    /// <summary>
    /// Function: UC_MOTDSetPageImage
    /// </summary>
    public unsafe virtual void UC_MOTDSetPageImage(int nPage, BmSDK.GFxUI.GFxObject iImage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_MOTDSetPageImage, "BmScript.RGFxMovieUI_MainMenu.UC_MOTDSetPageImage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iImage, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_MOTDAddPage;
    /// <summary>
    /// Function: UC_MOTDAddPage
    /// </summary>
    public unsafe virtual void UC_MOTDAddPage(BmSDK.FString sTitle, BmSDK.FString sPrompt, BmSDK.FString sAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_MOTDAddPage, "BmScript.RGFxMovieUI_MainMenu.UC_MOTDAddPage");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sTitle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPrompt, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAction, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_MOTDAllowInput;
    /// <summary>
    /// Function: UC_MOTDAllowInput
    /// </summary>
    public unsafe virtual void UC_MOTDAllowInput(bool bInput)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_MOTDAllowInput, "BmScript.RGFxMovieUI_MainMenu.UC_MOTDAllowInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInput, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_MOTDRefresh;
    /// <summary>
    /// Function: UC_MOTDRefresh
    /// </summary>
    public unsafe virtual void UC_MOTDRefresh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_MOTDRefresh, "BmScript.RGFxMovieUI_MainMenu.UC_MOTDRefresh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_MOTDShow;
    /// <summary>
    /// Function: UC_MOTDShow
    /// </summary>
    public unsafe virtual void UC_MOTDShow(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_MOTDShow, "BmScript.RGFxMovieUI_MainMenu.UC_MOTDShow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MOTDBlocker;
    /// <summary>
    /// Function: MOTDBlocker
    /// </summary>
    public unsafe virtual void MOTDBlocker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MOTDBlocker, "BmScript.RGFxMovieUI_MainMenu.MOTDBlocker");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_MOTDAction;
    /// <summary>
    /// Function: XI_MOTDAction
    /// </summary>
    public unsafe virtual void XI_MOTDAction(BmSDK.FString sAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_MOTDAction, "BmScript.RGFxMovieUI_MainMenu.XI_MOTDAction");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_RegisterMOTD;
    /// <summary>
    /// Function: XI_RegisterMOTD
    /// </summary>
    public unsafe virtual void XI_RegisterMOTD(BmSDK.FString sPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_RegisterMOTD, "BmScript.RGFxMovieUI_MainMenu.XI_RegisterMOTD");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CustomManifestLoadedMOTD;
    /// <summary>
    /// Function: CustomManifestLoadedMOTD
    /// </summary>
    public unsafe virtual void CustomManifestLoadedMOTD(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomManifestLoadedMOTD, "BmScript.RGFxMovieUI_MainMenu.CustomManifestLoadedMOTD");
        byte* paramsPtr = stackalloc byte[180];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CustomContentLoadedMOTD;
    /// <summary>
    /// Function: CustomContentLoadedMOTD
    /// </summary>
    public unsafe virtual void CustomContentLoadedMOTD(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomContentLoadedMOTD, "BmScript.RGFxMovieUI_MainMenu.CustomContentLoadedMOTD");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnX;
    /// <summary>
    /// Function: XI_OnX
    /// </summary>
    public unsafe override void XI_OnX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnX, "BmScript.RGFxMovieUI_MainMenu.XI_OnX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ClosedMainBoard;
    /// <summary>
    /// Function: XI_ClosedMainBoard
    /// </summary>
    public unsafe virtual void XI_ClosedMainBoard()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ClosedMainBoard, "BmScript.RGFxMovieUI_MainMenu.XI_ClosedMainBoard");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_OpenMWMainBoard;
    /// <summary>
    /// Function: UC_OpenMWMainBoard
    /// </summary>
    public unsafe virtual void UC_OpenMWMainBoard()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_OpenMWMainBoard, "BmScript.RGFxMovieUI_MainMenu.UC_OpenMWMainBoard");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ShowMWGamercard;
    /// <summary>
    /// Function: XI_ShowMWGamercard
    /// </summary>
    public unsafe virtual void XI_ShowMWGamercard(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ShowMWGamercard, "BmScript.RGFxMovieUI_MainMenu.XI_ShowMWGamercard");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_WillASetRival;
    /// <summary>
    /// Function: XI_WillASetRival
    /// </summary>
    public unsafe virtual void XI_WillASetRival(int Status)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_WillASetRival, "BmScript.RGFxMovieUI_MainMenu.XI_WillASetRival");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Status, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_PS4CanAccessLB;
    /// <summary>
    /// Function: XI_PS4CanAccessLB
    /// </summary>
    public unsafe virtual bool XI_PS4CanAccessLB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PS4CanAccessLB, "BmScript.RGFxMovieUI_MainMenu.XI_PS4CanAccessLB");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UC_GotMWLeaderboardData;
    /// <summary>
    /// Function: UC_GotMWLeaderboardData
    /// </summary>
    public unsafe virtual void UC_GotMWLeaderboardData(int Count)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_GotMWLeaderboardData, "BmScript.RGFxMovieUI_MainMenu.UC_GotMWLeaderboardData");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMWLeaderboardRead;
    /// <summary>
    /// Function: OnMWLeaderboardRead
    /// </summary>
    public unsafe override void OnMWLeaderboardRead(bool bWasSuccessful, BmSDK.BmGame.ROnlineStatsReadMostWanted MWStats)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMWLeaderboardRead, "BmScript.RGFxMovieUI_MainMenu.OnMWLeaderboardRead");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MWStats, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPollingBoards;
    /// <summary>
    /// Function: IsPollingBoards
    /// </summary>
    public unsafe virtual bool IsPollingBoards()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPollingBoards, "BmScript.RGFxMovieUI_MainMenu.IsPollingBoards");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MWLeaderboardTick;
    /// <summary>
    /// Function: MWLeaderboardTick
    /// </summary>
    public unsafe virtual void MWLeaderboardTick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MWLeaderboardTick, "BmScript.RGFxMovieUI_MainMenu.MWLeaderboardTick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_FetchMWBoard;
    /// <summary>
    /// Function: XI_FetchMWBoard
    /// </summary>
    public unsafe virtual void XI_FetchMWBoard(BmSDK.FString TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_FetchMWBoard, "BmScript.RGFxMovieUI_MainMenu.XI_FetchMWBoard");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetMWBoardRef;
    /// <summary>
    /// Function: XI_SetMWBoardRef
    /// </summary>
    public unsafe virtual void XI_SetMWBoardRef(BmSDK.FString TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetMWBoardRef, "BmScript.RGFxMovieUI_MainMenu.XI_SetMWBoardRef");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckInfoTicker;
    /// <summary>
    /// Function: CheckInfoTicker
    /// </summary>
    public unsafe virtual BmSDK.FString CheckInfoTicker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckInfoTicker, "BmScript.RGFxMovieUI_MainMenu.CheckInfoTicker");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentPercentage;
    /// <summary>
    /// Function: GetCurrentPercentage
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentPercentage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentPercentage, "BmScript.RGFxMovieUI_MainMenu.GetCurrentPercentage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FetchNickname;
    /// <summary>
    /// Function: FetchNickname
    /// </summary>
    public unsafe virtual BmSDK.FString FetchNickname()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchNickname, "BmScript.RGFxMovieUI_MainMenu.FetchNickname");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SendLeaderBoardToFlash;
    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe override void SendLeaderBoardToFlash(int Id, int total, BmSDK.TArray<int> FriendIndex, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> NetIDs, BmSDK.TArray<int> Ranks, BmSDK.TArray<BmSDK.FString> NickNames, BmSDK.TArray<int> Medals, BmSDK.TArray<float> Scores, BmSDK.TArray<int> RivalPoints, BmSDK.TArray<float> Story, BmSDK.TArray<float> MW, BmSDK.TArray<float> AR)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLeaderBoardToFlash, "BmScript.RGFxMovieUI_MainMenu.SendLeaderBoardToFlash");
        byte* paramsPtr = stackalloc byte[184];
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
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePrompts;
    /// <summary>
    /// Function: UpdatePrompts
    /// </summary>
    public unsafe virtual void UpdatePrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePrompts, "BmScript.RGFxMovieUI_MainMenu.UpdatePrompts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe override void XI_Tick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Tick, "BmScript.RGFxMovieUI_MainMenu.XI_Tick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe override void OnFadeCompleted_Callback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmScript.RGFxMovieUI_MainMenu.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OrbisSignIn;
    /// <summary>
    /// Function: OrbisSignIn
    /// </summary>
    public unsafe virtual void OrbisSignIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OrbisSignIn, "BmScript.RGFxMovieUI_MainMenu.OrbisSignIn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_MainMenu.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeTrigger;
    /// <summary>
    /// Function: FadeTrigger
    /// </summary>
    public unsafe virtual void FadeTrigger(int Mode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeTrigger, "BmScript.RGFxMovieUI_MainMenu.FadeTrigger");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ControllerImageLoaded_CB;
    /// <summary>
    /// Function: ControllerImageLoaded_CB
    /// </summary>
    public unsafe override void ControllerImageLoaded_CB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControllerImageLoaded_CB, "BmScript.RGFxMovieUI_MainMenu.ControllerImageLoaded_CB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnClicked;
    /// <summary>
    /// Function: XI_OnClicked
    /// </summary>
    public unsafe override void XI_OnClicked(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnClicked, "BmScript.RGFxMovieUI_MainMenu.XI_OnClicked");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainPackInstalled;
    /// <summary>
    /// Function: VillainPackInstalled
    /// </summary>
    public unsafe virtual bool VillainPackInstalled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainPackInstalled, "BmScript.RGFxMovieUI_MainMenu.VillainPackInstalled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowGameUpdateNeeded;
    /// <summary>
    /// Function: ShowGameUpdateNeeded
    /// </summary>
    public unsafe virtual void ShowGameUpdateNeeded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGameUpdateNeeded, "BmScript.RGFxMovieUI_MainMenu.ShowGameUpdateNeeded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLevelNotAvailable;
    /// <summary>
    /// Function: ShowLevelNotAvailable
    /// </summary>
    public unsafe virtual void ShowLevelNotAvailable(BmSDK.FString LevelName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLevelNotAvailable, "BmScript.RGFxMovieUI_MainMenu.ShowLevelNotAvailable");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckNp;
    /// <summary>
    /// Function: CheckNp
    /// </summary>
    public unsafe virtual bool CheckNp(BmSDK.FString SubPrefix = default, BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes WithPopupType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckNp, "BmScript.RGFxMovieUI_MainMenu.CheckNp");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubPrefix, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WithPopupType, paramsPtr + 16);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SelectedBatmobileAvailableForGameMode;
    /// <summary>
    /// Function: SelectedBatmobileAvailableForGameMode
    /// </summary>
    public unsafe virtual bool SelectedBatmobileAvailableForGameMode(bool bNewGame = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectedBatmobileAvailableForGameMode, "BmScript.RGFxMovieUI_MainMenu.SelectedBatmobileAvailableForGameMode");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewGame, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckChunksInstalled;
    /// <summary>
    /// Function: CheckChunksInstalled
    /// </summary>
    public unsafe virtual bool CheckChunksInstalled(int FromId, int ChunkId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckChunksInstalled, "BmScript.RGFxMovieUI_MainMenu.CheckChunksInstalled");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChunkId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnStreamingInstall_Callback;
    /// <summary>
    /// Function: OnStreamingInstall_Callback
    /// </summary>
    public unsafe override void OnStreamingInstall_Callback(bool bWasCancelled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStreamingInstall_Callback, "BmScript.RGFxMovieUI_MainMenu.OnStreamingInstall_Callback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasCancelled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowInstallerUI;
    /// <summary>
    /// Function: ShowInstallerUI
    /// </summary>
    public unsafe virtual void ShowInstallerUI(int FromId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowInstallerUI, "BmScript.RGFxMovieUI_MainMenu.ShowInstallerUI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreBatmanBatmobileSkinsPresent;
    /// <summary>
    /// Function: AreBatmanBatmobileSkinsPresent
    /// </summary>
    public unsafe virtual bool AreBatmanBatmobileSkinsPresent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreBatmanBatmobileSkinsPresent, "BmScript.RGFxMovieUI_MainMenu.AreBatmanBatmobileSkinsPresent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOut, "BmScript.RGFxMovieUI_MainMenu.XI_OnOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMOTDRequest;
    /// <summary>
    /// Function: StartMOTDRequest
    /// </summary>
    public unsafe virtual void StartMOTDRequest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMOTDRequest, "BmScript.RGFxMovieUI_MainMenu.StartMOTDRequest");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerWBIDStatus;
    /// <summary>
    /// Function: TimerWBIDStatus
    /// </summary>
    public unsafe virtual void TimerWBIDStatus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerWBIDStatus, "BmScript.RGFxMovieUI_MainMenu.TimerWBIDStatus");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnBack, "BmScript.RGFxMovieUI_MainMenu.XI_OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetupMenu;
    /// <summary>
    /// Function: XI_SetupMenu
    /// </summary>
    public unsafe override void XI_SetupMenu(BmSDK.FString TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetupMenu, "BmScript.RGFxMovieUI_MainMenu.XI_SetupMenu");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoWBPlay;
    /// <summary>
    /// Function: GotoWBPlay
    /// </summary>
    public unsafe virtual void GotoWBPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoWBPlay, "BmScript.RGFxMovieUI_MainMenu.GotoWBPlay");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoWBRewards2;
    /// <summary>
    /// Function: GotoWBRewards2
    /// </summary>
    public unsafe virtual void GotoWBRewards2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoWBRewards2, "BmScript.RGFxMovieUI_MainMenu.GotoWBRewards2");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoWBRewards;
    /// <summary>
    /// Function: GotoWBRewards
    /// </summary>
    public unsafe virtual void GotoWBRewards()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoWBRewards, "BmScript.RGFxMovieUI_MainMenu.GotoWBRewards");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoCalendar;
    /// <summary>
    /// Function: GotoCalendar
    /// </summary>
    public unsafe virtual void GotoCalendar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoCalendar, "BmScript.RGFxMovieUI_MainMenu.GotoCalendar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoStore;
    /// <summary>
    /// Function: GotoStore
    /// </summary>
    public unsafe virtual void GotoStore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoStore, "BmScript.RGFxMovieUI_MainMenu.GotoStore");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoChallenge2;
    /// <summary>
    /// Function: GotoChallenge2
    /// </summary>
    public unsafe virtual void GotoChallenge2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoChallenge2, "BmScript.RGFxMovieUI_MainMenu.GotoChallenge2");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoChallenge;
    /// <summary>
    /// Function: GotoChallenge
    /// </summary>
    public unsafe virtual void GotoChallenge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoChallenge, "BmScript.RGFxMovieUI_MainMenu.GotoChallenge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoContinuePlus2;
    /// <summary>
    /// Function: GotoContinuePlus2
    /// </summary>
    public unsafe virtual void GotoContinuePlus2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoContinuePlus2, "BmScript.RGFxMovieUI_MainMenu.GotoContinuePlus2");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoContinuePlus;
    /// <summary>
    /// Function: GotoContinuePlus
    /// </summary>
    public unsafe virtual void GotoContinuePlus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoContinuePlus, "BmScript.RGFxMovieUI_MainMenu.GotoContinuePlus");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoNewGamePlus2;
    /// <summary>
    /// Function: GotoNewGamePlus2
    /// </summary>
    public unsafe virtual void GotoNewGamePlus2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoNewGamePlus2, "BmScript.RGFxMovieUI_MainMenu.GotoNewGamePlus2");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoNewGamePlus;
    /// <summary>
    /// Function: GotoNewGamePlus
    /// </summary>
    public unsafe virtual void GotoNewGamePlus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoNewGamePlus, "BmScript.RGFxMovieUI_MainMenu.GotoNewGamePlus");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoContinue2;
    /// <summary>
    /// Function: GotoContinue2
    /// </summary>
    public unsafe virtual void GotoContinue2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoContinue2, "BmScript.RGFxMovieUI_MainMenu.GotoContinue2");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoContinue;
    /// <summary>
    /// Function: GotoContinue
    /// </summary>
    public unsafe virtual void GotoContinue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoContinue, "BmScript.RGFxMovieUI_MainMenu.GotoContinue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoNewGame2;
    /// <summary>
    /// Function: GotoNewGame2
    /// </summary>
    public unsafe virtual void GotoNewGame2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoNewGame2, "BmScript.RGFxMovieUI_MainMenu.GotoNewGame2");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoNewGame;
    /// <summary>
    /// Function: GotoNewGame
    /// </summary>
    public unsafe virtual void GotoNewGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoNewGame, "BmScript.RGFxMovieUI_MainMenu.GotoNewGame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenStore;
    /// <summary>
    /// Function: OpenStore
    /// </summary>
    public unsafe virtual void OpenStore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenStore, "BmScript.RGFxMovieUI_MainMenu.OpenStore");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckIfUnlockCompleteSuit;
    /// <summary>
    /// Function: CheckIfUnlockCompleteSuit
    /// </summary>
    public unsafe virtual void CheckIfUnlockCompleteSuit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckIfUnlockCompleteSuit, "BmScript.RGFxMovieUI_MainMenu.CheckIfUnlockCompleteSuit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_PurgeNetworkDebugCheat;
    /// <summary>
    /// Function: XI_PurgeNetworkDebugCheat
    /// </summary>
    public unsafe virtual void XI_PurgeNetworkDebugCheat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PurgeNetworkDebugCheat, "BmScript.RGFxMovieUI_MainMenu.XI_PurgeNetworkDebugCheat");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_DetectNetworkDebugCheat;
    /// <summary>
    /// Function: XI_DetectNetworkDebugCheat
    /// </summary>
    public unsafe override void XI_DetectNetworkDebugCheat(int charCode, bool bIsRepeat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_DetectNetworkDebugCheat, "BmScript.RGFxMovieUI_MainMenu.XI_DetectNetworkDebugCheat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(charCode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsRepeat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenDebugLevelSelect;
    /// <summary>
    /// Function: OpenDebugLevelSelect
    /// </summary>
    public unsafe virtual void OpenDebugLevelSelect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenDebugLevelSelect, "BmScript.RGFxMovieUI_MainMenu.OpenDebugLevelSelect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWBIDOverlayClosed;
    /// <summary>
    /// Function: OnWBIDOverlayClosed
    /// </summary>
    public unsafe virtual void OnWBIDOverlayClosed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWBIDOverlayClosed, "BmScript.RGFxMovieUI_MainMenu.OnWBIDOverlayClosed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BootOverlays;
    /// <summary>
    /// Function: BootOverlays
    /// </summary>
    public unsafe virtual void BootOverlays()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BootOverlays, "BmScript.RGFxMovieUI_MainMenu.BootOverlays");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnContentChange;
    /// <summary>
    /// Function: OnContentChange
    /// </summary>
    public unsafe virtual void OnContentChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnContentChange, "BmScript.RGFxMovieUI_MainMenu.OnContentChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadInGameStoreContentComplete;
    /// <summary>
    /// Function: OnReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnReadInGameStoreContentComplete(bool bWasSuccessful, bool bTimeout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadInGameStoreContentComplete, "BmScript.RGFxMovieUI_MainMenu.OnReadInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTimeout, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_MainMenu.CloseScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_MainMenu.Init");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionForwards;
    /// <summary>
    /// Function: TransitionForwards
    /// </summary>
    public unsafe override void TransitionForwards(BmSDK.FString EventName, bool bClose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionForwards, "BmScript.RGFxMovieUI_MainMenu.TransitionForwards");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClose, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: FadeMode
    /// </summary>
    public unsafe int FadeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ByteProperty: m_eWBIDStatus
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager.WBIDStatus m_eWBIDStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager.WBIDStatus>(Ptr + 1077); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1077); }
    }

    /// <summary>
    /// ByteProperty: m_eWBIDStatusWhenOpeningWBPlayFlow
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager.WBIDStatus m_eWBIDStatusWhenOpeningWBPlayFlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager.WBIDStatus>(Ptr + 1078); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1078); }
    }

    /// <summary>
    /// ByteProperty: NetworkDebugCheatSequence
    /// </summary>
    public unsafe byte NetworkDebugCheatSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1079); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1079); }
    }

    /// <summary>
    /// BoolProperty: bWBPlayGiftsChecked
    /// </summary>
    public unsafe bool bWBPlayGiftsChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bOrbisBeginSignIn
    /// </summary>
    public unsafe bool bOrbisBeginSignIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsSaveInProgress
    /// </summary>
    public unsafe bool bIsSaveInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsPC
    /// </summary>
    public unsafe bool bIsPC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsDurango
    /// </summary>
    public unsafe bool bIsDurango
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsOrbis
    /// </summary>
    public unsafe bool bIsOrbis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsDemo
    /// </summary>
    public unsafe bool bIsDemo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bInGameStore
    /// </summary>
    public unsafe bool bInGameStore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bEventCalendar
    /// </summary>
    public unsafe bool bEventCalendar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bRequestedMWRating
    /// </summary>
    public unsafe bool bRequestedMWRating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWReadPending
    /// </summary>
    public unsafe bool bMWReadPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWFetchSuccess
    /// </summary>
    public unsafe bool bMWFetchSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWMainBoard
    /// </summary>
    public unsafe bool bMWMainBoard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bBeatenByActive
    /// </summary>
    public unsafe bool bBeatenByActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bNewDLCMsg
    /// </summary>
    public unsafe bool bNewDLCMsg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: MOTDRequested
    /// </summary>
    public unsafe bool MOTDRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bCheatHoldLock
    /// </summary>
    public unsafe bool bCheatHoldLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeManager CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeManager>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: InstallerGFxMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie InstallerGFxMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: InstallerMovieUI
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_InstallationMessage InstallerMovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_InstallationMessage>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: WBIDOverlays
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxMovieUI_WBIDMain WBIDOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxMovieUI_WBIDMain>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDDataMessage DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDDataMessage>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: UnlockedChallengeCount
    /// </summary>
    public unsafe int UnlockedChallengeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: LatentInstallFromId
    /// </summary>
    public unsafe int LatentInstallFromId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: ASetRivalState
    /// </summary>
    public unsafe int ASetRivalState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// StrProperty: MWTargetPath
    /// </summary>
    public unsafe BmSDK.FString MWTargetPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// StrProperty: BeatenByPath
    /// </summary>
    public unsafe BmSDK.FString BeatenByPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// StrProperty: MOTDPath
    /// </summary>
    public unsafe BmSDK.FString MOTDPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ArrayProperty: WBIDMovieInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.SwfMovie> WBIDMovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.SwfMovie>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadInGameStoreContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadInGameStoreContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// DelegateProperty: __CustomContentLoadedMOTD__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomContentLoadedMOTD__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// DelegateProperty: __CustomManifestLoadedMOTD__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomManifestLoadedMOTD__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// Enum: MMFadeAndTypes
    /// </summary>
    public enum MMFadeAndTypes : byte
    {
        FadeAnd_None = 0,
        FadeAnd_Exit = 1,
        FadeAnd_NewGame = 2,
        FadeAnd_Continue = 3,
        FadeAnd_StartVSlice = 4,
        FadeAnd_ContinueVSlice = 5,
        FadeAnd_FreeRoam = 6,
        FadeAnd_NewGamePlus = 7,
        FadeAnd_MAX = 8,
    }

    /// <summary>
    /// Enum: MMPopTypes
    /// </summary>
    public enum MMPopTypes : byte
    {
        MMPopType_None = 0,
        MMPopType_Exit = 1,
        MMPopType_BackFromMain = 2,
        MMPopType_NewGame = 3,
        MMPopType_NewGamePlus = 4,
        MMPopType_NewGame_VS = 5,
        MMPopType_Continue_VS = 6,
        MMPopType_NewGame_FreeRoam = 7,
        MMPopType_GoOnlineForStore = 8,
        MMPopType_OrbisNewGameSignIn = 9,
        MMPopType_OrbisContinueGameSignIn = 10,
        MMPopType_OrbisNewGamePlusSignIn = 11,
        MMPopType_OrbisContinueGamePlusSignIn = 12,
        MMPopType_OrbisChallengeSignIn = 13,
        MMPopType_OrbisSignIn = 14,
        MMPopType_Orbis_WBID = 15,
        MMPopType_NewGame_NP = 16,
        MMPopType_ContinueGame_NP = 17,
        MMPopType_NewGamePlus_NP = 18,
        MMPopType_ContinueGamePlus_NP = 19,
        MMPopType_Challenge_NP = 20,
        MMPopType_WBPlay = 21,
        MMPopType_WBPlay_GiftReward = 22,
        MMPopType_OrbisWBRewardsSignIn = 23,
        MMPopType_MinSpecWarning = 24,
        MMPopType_ModifiedIniWarning = 25,
        MMPopType_PCWBRewardsSignIn = 26,
        MMPopType_MAX = 27,
    }
}
