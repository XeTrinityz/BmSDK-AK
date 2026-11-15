#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsControlsKeyboard<br/>
/// (size = 1760)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsControlsKeyboard : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_PauseOptionsControlsKeyboard.
    /// </summary>
    public static RGFxMovieUI_PauseOptionsControlsKeyboard DefaultObject => (RGFxMovieUI_PauseOptionsControlsKeyboard)StaticClass().DefaultObject;

    internal RGFxMovieUI_PauseOptionsControlsKeyboard() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsControlsKeyboard
    /// </summary>
    public RGFxMovieUI_PauseOptionsControlsKeyboard(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsControlsKeyboard Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsControlsKeyboard(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsControlsKeyboard>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsControlsKeyboard>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsControlsKeyboard>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsControlsKeyboard>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsControlsKeyboard>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsControlsKeyboard>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsControlsKeyboard>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsControlsKeyboard>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetIsLeftCtrlPressed;
    /// <summary>
    /// Function: XI_GetIsLeftCtrlPressed
    /// </summary>
    public unsafe virtual void XI_GetIsLeftCtrlPressed(BmSDK.FStringArg sPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetIsLeftCtrlPressed, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_GetIsLeftCtrlPressed", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetIsLeftShiftPressed;
    /// <summary>
    /// Function: XI_GetIsLeftShiftPressed
    /// </summary>
    public unsafe virtual void XI_GetIsLeftShiftPressed(BmSDK.FStringArg sPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetIsLeftShiftPressed, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_GetIsLeftShiftPressed", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CloseScreen, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.CloseScreen", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetCurrentPage;
    /// <summary>
    /// Function: SetCurrentPage
    /// </summary>
    public unsafe virtual void SetCurrentPage(int nPage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetCurrentPage, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.SetCurrentPage", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AppendPage;
    /// <summary>
    /// Function: AppendPage
    /// </summary>
    public unsafe virtual void AppendPage(BmSDK.FStringArg InName, BmSDK.FStringArg InDevice, BmSDK.FStringArg InScheme)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AppendPage, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.AppendPage", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InName.WriteTo(paramsPtr + 0);
        InDevice.WriteTo(paramsPtr + 16);
        InScheme.WriteTo(paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestPages;
    /// <summary>
    /// Function: XI_RequestPages
    /// </summary>
    public unsafe virtual void XI_RequestPages(BmSDK.FStringArg sPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestPages, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_RequestPages", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetBindByAbility;
    /// <summary>
    /// Function: XI_SetBindByAbility
    /// </summary>
    public unsafe virtual void XI_SetBindByAbility(int InAbilityId, BmSDK.FStringArg InKeyUnlocalized, bool bIsPrimary, int InTypeId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetBindByAbility, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_SetBindByAbility", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAbilityId, paramsPtr + 0);
        InKeyUnlocalized.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPrimary, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_RequestControlData;
    /// <summary>
    /// Function: XI_RequestControlData
    /// </summary>
    public unsafe virtual void XI_RequestControlData(BmSDK.FStringArg BatmanAbilityNamesPath, BmSDK.FStringArg BatmanKey1Path, BmSDK.FStringArg BatmanKey2Path, BmSDK.FStringArg PursuitAbilityNamesPath, BmSDK.FStringArg PursuitKeys1Path, BmSDK.FStringArg PursuitKeys2Path, BmSDK.FStringArg BattleAbilityNamesPath, BmSDK.FStringArg BattleKeys1Path, BmSDK.FStringArg BattleKeys2Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestControlData, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_RequestControlData", this);
        byte* paramsPtr = stackalloc byte[405];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BatmanAbilityNamesPath.WriteTo(paramsPtr + 0);
        BatmanKey1Path.WriteTo(paramsPtr + 16);
        BatmanKey2Path.WriteTo(paramsPtr + 32);
        PursuitAbilityNamesPath.WriteTo(paramsPtr + 48);
        PursuitKeys1Path.WriteTo(paramsPtr + 64);
        PursuitKeys2Path.WriteTo(paramsPtr + 80);
        BattleAbilityNamesPath.WriteTo(paramsPtr + 96);
        BattleKeys1Path.WriteTo(paramsPtr + 112);
        BattleKeys2Path.WriteTo(paramsPtr + 128);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 64);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 80);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 96);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 112);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 128);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnOut, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_OnOut", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ThrowKeyBindPopup;
    /// <summary>
    /// Function: XI_ThrowKeyBindPopup
    /// </summary>
    public unsafe virtual void XI_ThrowKeyBindPopup(BmSDK.FStringArg InPath, int InTypeId, int InIndex, bool InbIsPrimaryKeyBind)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ThrowKeyBindPopup, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_ThrowKeyBindPopup", this);
        byte* paramsPtr = stackalloc byte[61];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbIsPrimaryKeyBind, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDefaultKey;
    /// <summary>
    /// Function: GetDefaultKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetDefaultKey(int InTypeId, int InIndex, BmSDK.BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyMap InKeyMap, bool GetUnlocalized = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDefaultKey, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.GetDefaultKey", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalized, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCurrentKey;
    /// <summary>
    /// Function: GetCurrentKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentKey(int InTypeId, int InIndex, BmSDK.BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyMap InKeyMap)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCurrentKey, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.GetCurrentKey", this);
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetKey;
    /// <summary>
    /// Function: GetKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetKey(BmSDK.BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyBindSourceId InSource, int InTypeId, int InIndex, BmSDK.BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyMap InKeyBind, bool GetUnlocalizedDefault = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetKey, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.GetKey", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyBind, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalizedDefault, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ThrowAreYouSurePopup;
    /// <summary>
    /// Function: XI_ThrowAreYouSurePopup
    /// </summary>
    public unsafe virtual void XI_ThrowAreYouSurePopup(BmSDK.FStringArg InPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ThrowAreYouSurePopup, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_ThrowAreYouSurePopup", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ButtonPCThrowAreYouSurePopup;
    /// <summary>
    /// Function: XI_ButtonPCThrowAreYouSurePopup
    /// </summary>
    public unsafe virtual void XI_ButtonPCThrowAreYouSurePopup(BmSDK.FStringArg InPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ButtonPCThrowAreYouSurePopup, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_ButtonPCThrowAreYouSurePopup", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetKeyButtonBind;
    /// <summary>
    /// Function: SetKeyButtonBind
    /// </summary>
    public unsafe virtual void SetKeyButtonBind(BmSDK.FStringArg InKey)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetKeyButtonBind, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.SetKeyButtonBind", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InKey.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.PopupRequester_Callback", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_KeyBindPopUpResetToDefaultPressed;
    /// <summary>
    /// Function: KeyBindPopUpResetToDefaultPressed
    /// </summary>
    public unsafe virtual void KeyBindPopUpResetToDefaultPressed(BmSDK.FStringArg InDefaultKey)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_KeyBindPopUpResetToDefaultPressed, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyBindPopUpResetToDefaultPressed", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InDefaultKey.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnBack, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_OnBack", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnYPressed;
    /// <summary>
    /// Function: XI_OnYPressed
    /// </summary>
    public unsafe virtual void XI_OnYPressed(BmSDK.FStringArg Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnYPressed, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_OnYPressed", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Path.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetAllKeybindsToDefault;
    /// <summary>
    /// Function: ResetAllKeybindsToDefault
    /// </summary>
    public unsafe virtual void ResetAllKeybindsToDefault()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetAllKeybindsToDefault, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.ResetAllKeybindsToDefault", this);
        byte* paramsPtr = stackalloc byte[188];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.Init", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: KeyMap
    /// </summary>
    public enum KeyMap : byte
    {
        KeyMap_Primary = 0,
        KeyMap_Secondary = 1,
        KeyMap_MAX = 2,
    }

    /// <summary>
    /// Enum: KeyBindSourceId
    /// </summary>
    public enum KeyBindSourceId : byte
    {
        KeyBindSourceId_Default = 0,
        KeyBindSourceId_Current = 1,
        KeyBindSourceId_MAX = 2,
    }

    /// <summary>
    /// Enum: KeyboardBindTypeId
    /// </summary>
    public enum KeyboardBindTypeId : byte
    {
        KeyboardBindTypeId_Batman = 0,
        KeyboardBindTypeId_Pursuit = 1,
        KeyboardBindTypeId_Battle = 2,
        KeyboardBindTypeId_DLC_Harley = 3,
        KeyboardBindTypeId_DLC_RedHood = 4,
        KeyboardBindTypeId_DLC_Batgirl = 5,
        KeyboardBindTypeId_MAX = 6,
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCurrentPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCurrentPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// StructProperty: ControlsScreen<br/>
    /// Default: (TheMovieInstance=PauseMenu.PauseControls,TheClass=BmGame.RGFxMovieUI_PauseOptionsControls)
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI_PauseBase.FScreenDef ControlsScreen
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI_PauseBase.FScreenDef>(Ptr + 1644);

    /// <summary>
    /// StrProperty: FunctionPath
    /// </summary>
    public unsafe BmSDK.FString FunctionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// ObjectProperty: ApplyKeybindingsPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyKeybindingsPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ObjectProperty: KeyButtonRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester KeyButtonRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ObjectProperty: ButtonPCRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ButtonPCRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// ObjectProperty: SetKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester SetKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ObjectProperty: ResetAllToDefaultPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ResetAllToDefaultPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// IntProperty: NoOption<br/>
    /// Default: 1
    /// </summary>
    public unsafe int NoOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// IntProperty: CancelOption<br/>
    /// Default: 3
    /// </summary>
    public unsafe int CancelOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// StrProperty: DefaultKeyBind
    /// </summary>
    public unsafe BmSDK.FString DefaultKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// BoolProperty: bHasModifier
    /// </summary>
    public unsafe bool bHasModifier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1740); }
    }

    /// <summary>
    /// StrProperty: SelectedKeyBind
    /// </summary>
    public unsafe BmSDK.FString SelectedKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }
}
