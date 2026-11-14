#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_OptionsControlsKeyboard<br/>
/// (size = 1204)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_OptionsControlsKeyboard : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_OptionsControlsKeyboard.
    /// </summary>
    public static RGFxMovieUI_OptionsControlsKeyboard DefaultObject => (RGFxMovieUI_OptionsControlsKeyboard)StaticClass().DefaultObject;

    internal RGFxMovieUI_OptionsControlsKeyboard() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsControlsKeyboard
    /// </summary>
    public RGFxMovieUI_OptionsControlsKeyboard(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsControlsKeyboard Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsControlsKeyboard(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsControlsKeyboard>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_GetIsLeftCtrlPressed;
    /// <summary>
    /// Function: XI_GetIsLeftCtrlPressed
    /// </summary>
    public unsafe virtual void XI_GetIsLeftCtrlPressed(BmSDK.FStringArg sPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetIsLeftCtrlPressed, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_GetIsLeftCtrlPressed", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_GetIsLeftShiftPressed, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_GetIsLeftShiftPressed", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.CloseScreen", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetCurrentPage;
    /// <summary>
    /// Function: SetCurrentPage
    /// </summary>
    public unsafe virtual void SetCurrentPage(int nPage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetCurrentPage, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.SetCurrentPage", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AppendPage;
    /// <summary>
    /// Function: AppendPage
    /// </summary>
    public unsafe virtual void AppendPage(BmSDK.FStringArg InName, BmSDK.FStringArg InDevice, BmSDK.FStringArg InScheme)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AppendPage, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.AppendPage", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InName.WriteTo(paramsPtr + 0);
        InDevice.WriteTo(paramsPtr + 16);
        InScheme.WriteTo(paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestPages, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_RequestPages", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetBindByAbility, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_SetBindByAbility", this);
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAbilityId, paramsPtr + 0);
        InKeyUnlocalized.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPrimary, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_RequestControlData, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_RequestControlData", this);
        byte* paramsPtr = stackalloc byte[324];
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
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ThrowKeyBindPopup;
    /// <summary>
    /// Function: XI_ThrowKeyBindPopup
    /// </summary>
    public unsafe virtual void XI_ThrowKeyBindPopup(BmSDK.FStringArg InPath, int InTypeId, int InIndex, bool InbIsPrimaryKeyBind)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ThrowKeyBindPopup, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ThrowKeyBindPopup", this);
        byte* paramsPtr = stackalloc byte[61];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbIsPrimaryKeyBind, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDefaultKey;
    /// <summary>
    /// Function: GetDefaultKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetDefaultKey(int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap, bool GetUnlocalized = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDefaultKey, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetDefaultKey", this);
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalized, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCurrentKey;
    /// <summary>
    /// Function: GetCurrentKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentKey(int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCurrentKey, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetCurrentKey", this);
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetKey;
    /// <summary>
    /// Function: GetKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetKey(BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyBindSourceId InSource, int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap, bool GetUnlocalizedDefault = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetKey, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetKey", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalizedDefault, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ThrowAreYouSurePopup;
    /// <summary>
    /// Function: XI_ThrowAreYouSurePopup
    /// </summary>
    public unsafe virtual void XI_ThrowAreYouSurePopup(BmSDK.FStringArg InPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ThrowAreYouSurePopup, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ThrowAreYouSurePopup", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ButtonPCThrowAreYouSurePopup, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ButtonPCThrowAreYouSurePopup", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetKeyButtonBind, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.SetKeyButtonBind", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InKey.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.PopupRequester_Callback", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_KeyBindPopUpResetToDefaultPressed;
    /// <summary>
    /// Function: KeyBindPopUpResetToDefaultPressed
    /// </summary>
    public unsafe virtual void KeyBindPopUpResetToDefaultPressed(BmSDK.FStringArg InDefaultKey)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_KeyBindPopUpResetToDefaultPressed, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyBindPopUpResetToDefaultPressed", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        InDefaultKey.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnBack, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_OnBack", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_OnYPressed;
    /// <summary>
    /// Function: XI_OnYPressed
    /// </summary>
    public unsafe virtual void XI_OnYPressed(BmSDK.FStringArg Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnYPressed, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_OnYPressed", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Path.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetAllKeybindsToDefault, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.ResetAllKeybindsToDefault", this);
        byte* paramsPtr = stackalloc byte[156];
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.Init", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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
        KeyboardBindTypeId_MAX = 3,
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCurrentPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCurrentPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// StrProperty: FunctionPath
    /// </summary>
    public unsafe BmSDK.FString FunctionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: ApplyKeybindingsPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyKeybindingsPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ObjectProperty: KeyButtonRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester KeyButtonRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ObjectProperty: ButtonPCRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ButtonPCRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: SetKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester SetKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: ResetAllToDefaultPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ResetAllToDefaultPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: NoOption
    /// </summary>
    public unsafe int NoOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: CancelOption
    /// </summary>
    public unsafe int CancelOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StrProperty: DefaultKeyBind
    /// </summary>
    public unsafe BmSDK.FString DefaultKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// BoolProperty: bHasModifier
    /// </summary>
    public unsafe bool bHasModifier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1184); }
    }

    /// <summary>
    /// StrProperty: SelectedKeyBind
    /// </summary>
    public unsafe BmSDK.FString SelectedKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
