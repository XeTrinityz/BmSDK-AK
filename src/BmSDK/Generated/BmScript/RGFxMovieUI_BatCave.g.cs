#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_BatCave<br/>
/// (size = 1192)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_BatCave : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_BatCave", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_BatCave.
    /// </summary>
    public static RGFxMovieUI_BatCave DefaultObject => (RGFxMovieUI_BatCave)StaticClass().DefaultObject;

    internal RGFxMovieUI_BatCave() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_BatCave
    /// </summary>
    public RGFxMovieUI_BatCave(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_BatCave Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_BatCave(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_SetZoom;
    /// <summary>
    /// Function: XI_SetZoom
    /// </summary>
    public unsafe virtual void XI_SetZoom(float InZoom)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_SetZoom, "BmScript.RGFxMovieUI_BatCave.XI_SetZoom", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InZoom, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_BatCave.PopupRequester_Callback", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveCustomContentAction;
    /// <summary>
    /// Function: XI_BatCaveCustomContentAction
    /// </summary>
    public unsafe virtual void XI_BatCaveCustomContentAction(BmSDK.FStringArg sAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveCustomContentAction, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveCustomContentAction", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sAction.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveAnimate;
    /// <summary>
    /// Function: XI_BatCaveAnimate
    /// </summary>
    public unsafe virtual void XI_BatCaveAnimate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveAnimate, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveAnimate", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveNoir;
    /// <summary>
    /// Function: XI_BatCaveNoir
    /// </summary>
    public unsafe virtual void XI_BatCaveNoir()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveNoir, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveNoir", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveLights;
    /// <summary>
    /// Function: XI_BatCaveLights
    /// </summary>
    public unsafe virtual void XI_BatCaveLights()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveLights, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveLights", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveInspect;
    /// <summary>
    /// Function: XI_BatCaveInspect
    /// </summary>
    public unsafe virtual void XI_BatCaveInspect(bool bInspectMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveInspect, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveInspect", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInspectMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveViewedItem;
    /// <summary>
    /// Function: XI_BatCaveViewedItem
    /// </summary>
    public unsafe virtual void XI_BatCaveViewedItem(BmSDK.FStringArg sItem)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveViewedItem, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveViewedItem", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sItem.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveLoadLevels;
    /// <summary>
    /// Function: XI_BatCaveLoadLevels
    /// </summary>
    public unsafe virtual void XI_BatCaveLoadLevels(BmSDK.FStringArg sLevels, BmSDK.FStringArg sFilter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveLoadLevels, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveLoadLevels", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sLevels.WriteTo(paramsPtr + 0);
        sFilter.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveSelectSkin;
    /// <summary>
    /// Function: XI_BatCaveSelectSkin
    /// </summary>
    public unsafe virtual void XI_BatCaveSelectSkin(BmSDK.FStringArg sSkin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveSelectSkin, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveSelectSkin", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sSkin.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveSelectCamera;
    /// <summary>
    /// Function: XI_BatCaveSelectCamera
    /// </summary>
    public unsafe virtual void XI_BatCaveSelectCamera(BmSDK.FStringArg sCamera)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveSelectCamera, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveSelectCamera", this);
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sCamera.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_BatCaveEnumerate;
    /// <summary>
    /// Function: XI_BatCaveEnumerate
    /// </summary>
    public unsafe virtual void XI_BatCaveEnumerate(BmSDK.FStringArg sTargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_BatCaveEnumerate, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveEnumerate", this);
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sTargetPath.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_LevelsLoaded;
    /// <summary>
    /// Function: UC_LevelsLoaded
    /// </summary>
    public unsafe virtual void UC_LevelsLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_LevelsLoaded, "BmScript.RGFxMovieUI_BatCave.UC_LevelsLoaded", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetInspectMode;
    /// <summary>
    /// Function: UC_SetInspectMode
    /// </summary>
    public unsafe virtual void UC_SetInspectMode(bool bInspect)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetInspectMode, "BmScript.RGFxMovieUI_BatCave.UC_SetInspectMode", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInspect, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetActiveSkin;
    /// <summary>
    /// Function: UC_SetActiveSkin
    /// </summary>
    public unsafe virtual void UC_SetActiveSkin(BmSDK.FStringArg sSkinPackage, bool bActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetActiveSkin, "BmScript.RGFxMovieUI_BatCave.UC_SetActiveSkin", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sSkinPackage.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_SetItemImage;
    /// <summary>
    /// Function: UC_SetItemImage
    /// </summary>
    public unsafe virtual void UC_SetItemImage(BmSDK.FStringArg Stab, BmSDK.FStringArg sItem, BmSDK.FStringArg sImage, BmSDK.GFxUI.GFxObject iImage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_SetItemImage, "BmScript.RGFxMovieUI_BatCave.UC_SetItemImage", this);
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Stab.WriteTo(paramsPtr + 0);
        sItem.WriteTo(paramsPtr + 16);
        sImage.WriteTo(paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iImage, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UC_AddItem;
    /// <summary>
    /// Function: UC_AddItem
    /// </summary>
    public unsafe virtual void UC_AddItem(BmSDK.FStringArg sPage, BmSDK.FStringArg sName, BmSDK.FStringArg sLevels, BmSDK.FStringArg sParameters)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UC_AddItem, "BmScript.RGFxMovieUI_BatCave.UC_AddItem", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sPage.WriteTo(paramsPtr + 0);
        sName.WriteTo(paramsPtr + 16);
        sLevels.WriteTo(paramsPtr + 32);
        sParameters.WriteTo(paramsPtr + 48);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CustomContentLoadedSC;
    /// <summary>
    /// Function: CustomContentLoadedSC
    /// </summary>
    public unsafe virtual void CustomContentLoadedSC(bool bWasSuccessful, BmSDK.FStringArg sCustomId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CustomContentLoadedSC, "BmScript.RGFxMovieUI_BatCave.CustomContentLoadedSC", this);
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        sCustomId.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CustomManifestLoadedSC;
    /// <summary>
    /// Function: CustomManifestLoadedSC
    /// </summary>
    public unsafe virtual void CustomManifestLoadedSC(bool bWasSuccessful, BmSDK.FStringArg sCustomId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CustomManifestLoadedSC, "BmScript.RGFxMovieUI_BatCave.CustomManifestLoadedSC", this);
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        sCustomId.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LevelStreamShowActive;
    /// <summary>
    /// Function: LevelStreamShowActive
    /// </summary>
    public unsafe virtual void LevelStreamShowActive(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LevelStreamShowActive, "BmScript.RGFxMovieUI_BatCave.LevelStreamShowActive", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LevelStreamLoadReferences;
    /// <summary>
    /// Function: LevelStreamLoadReferences
    /// </summary>
    public unsafe virtual int LevelStreamLoadReferences(BmSDK.FStringArg sLevels, BmSDK.FStringArg sFilter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LevelStreamLoadReferences, "BmScript.RGFxMovieUI_BatCave.LevelStreamLoadReferences", this);
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sLevels.WriteTo(paramsPtr + 0);
        sFilter.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LevelStreamLoaded;
    /// <summary>
    /// Function: LevelStreamLoaded
    /// </summary>
    public unsafe virtual bool LevelStreamLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LevelStreamLoaded, "BmScript.RGFxMovieUI_BatCave.LevelStreamLoaded", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LevelStreamStoreOriginals;
    /// <summary>
    /// Function: LevelStreamStoreOriginals
    /// </summary>
    public unsafe virtual void LevelStreamStoreOriginals()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LevelStreamStoreOriginals, "BmScript.RGFxMovieUI_BatCave.LevelStreamStoreOriginals", this);
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LevelStreamInArray;
    /// <summary>
    /// Function: LevelStreamInArray
    /// </summary>
    public unsafe virtual bool LevelStreamInArray(BmSDK.TArray<BmSDK.FString> aArray, BmSDK.FStringArg sName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LevelStreamInArray, "BmScript.RGFxMovieUI_BatCave.LevelStreamInArray", this);
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aArray, paramsPtr + 0);
        sName.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ForceLoadTexturesRequestMultiLevel;
    /// <summary>
    /// Function: ForceLoadTexturesRequestMultiLevel
    /// </summary>
    public unsafe virtual void ForceLoadTexturesRequestMultiLevel(BmSDK.TArray<BmSDK.FString> Levels)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ForceLoadTexturesRequestMultiLevel, "BmScript.RGFxMovieUI_BatCave.ForceLoadTexturesRequestMultiLevel", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Levels, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TimerLoadingLevels;
    /// <summary>
    /// Function: TimerLoadingLevels
    /// </summary>
    public unsafe virtual void TimerLoadingLevels()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TimerLoadingLevels, "BmScript.RGFxMovieUI_BatCave.TimerLoadingLevels", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TimerStreamingTextures;
    /// <summary>
    /// Function: TimerStreamingTextures
    /// </summary>
    public unsafe virtual void TimerStreamingTextures()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TimerStreamingTextures, "BmScript.RGFxMovieUI_BatCave.TimerStreamingTextures", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LightsOnDelay;
    /// <summary>
    /// Function: LightsOnDelay
    /// </summary>
    public unsafe virtual void LightsOnDelay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LightsOnDelay, "BmScript.RGFxMovieUI_BatCave.LightsOnDelay", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_OnOut, "BmScript.RGFxMovieUI_BatCave.XI_OnOut", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_BatCave.CloseScreen", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer iPlayer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmScript.RGFxMovieUI_BatCave.Init", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StrProperty: sManifest
    /// </summary>
    public unsafe BmSDK.FString sManifest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: m_sMoviePath
    /// </summary>
    public unsafe BmSDK.FString m_sMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: m_aOriginalLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> m_aOriginalLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: m_aLoadingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> m_aLoadingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: m_aActiveLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> m_aActiveLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: m_bInspectReady
    /// </summary>
    public unsafe bool m_bInspectReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bSaveNeeded
    /// </summary>
    public unsafe bool m_bSaveNeeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bBatmobilesAlwaysAvailable
    /// </summary>
    public unsafe bool m_bBatmobilesAlwaysAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bAllowHarleySkin
    /// </summary>
    public unsafe bool bAllowHarleySkin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bAllowRedhoodSkin
    /// </summary>
    public unsafe bool bAllowRedhoodSkin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: m_nLoadedReferenceCount
    /// </summary>
    public unsafe int m_nLoadedReferenceCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// DelegateProperty: __CustomManifestLoadedSC__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __CustomManifestLoadedSC__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// DelegateProperty: __CustomContentLoadedSC__Delegate
    /// </summary>
    public unsafe BmSDK.FScriptDelegate __CustomContentLoadedSC__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FScriptDelegate>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }
}
