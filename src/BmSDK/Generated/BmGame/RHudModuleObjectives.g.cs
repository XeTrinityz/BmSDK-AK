#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleObjectives<br/>
/// (size = 256)
/// (flags = 18)
/// </summary>
public partial class RHudModuleObjectives : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleObjectives", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleObjectives.
    /// </summary>
    public static RHudModuleObjectives DefaultObject => (RHudModuleObjectives)StaticClass().DefaultObject;

    internal RHudModuleObjectives() { }

    /// <summary>
    /// Constructs a new RHudModuleObjectives
    /// </summary>
    public RHudModuleObjectives(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleObjectives Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleObjectives(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ObjectiveBarFilled;
    /// <summary>
    /// Function: XI_ObjectiveBarFilled
    /// </summary>
    public unsafe virtual void XI_ObjectiveBarFilled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ObjectiveBarFilled, "BmGame.RHudModuleObjectives.XI_ObjectiveBarFilled", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_XI_ObjectiveItemShown;
    /// <summary>
    /// Function: XI_ObjectiveItemShown
    /// </summary>
    public unsafe virtual void XI_ObjectiveItemShown(int arrow_type, BmSDK.FStringArg CustomIconString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_XI_ObjectiveItemShown, "BmGame.RHudModuleObjectives.XI_ObjectiveItemShown", this);
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(arrow_type, paramsPtr + 0);
        CustomIconString.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FlushObjectivePrivate;
    /// <summary>
    /// Function: FlushObjectivePrivate
    /// </summary>
    public unsafe virtual void FlushObjectivePrivate(BmSDK.FStringArg Title)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FlushObjectivePrivate, "BmGame.RHudModuleObjectives.FlushObjectivePrivate", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Title.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddObjectivePrivate;
    /// <summary>
    /// Function: AddObjectivePrivate
    /// </summary>
    public unsafe virtual void AddObjectivePrivate(float Time, BmSDK.FStringArg Title, BmSDK.FStringArg Desc, BmSDK.FStringArg OrgDesc, int ArrowType, bool bForceShowMap, BmSDK.FStringArg BackPrompt, bool bNoDuplicates, bool bPulseCompassIndicatorm, BmSDK.FStringArg mostWantedUnlocksString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddObjectivePrivate, "BmGame.RHudModuleObjectives.AddObjectivePrivate", this);
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        Title.WriteTo(paramsPtr + 4);
        Desc.WriteTo(paramsPtr + 20);
        OrgDesc.WriteTo(paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrowType, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowMap, paramsPtr + 56);
        BackPrompt.WriteTo(paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoDuplicates, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPulseCompassIndicatorm, paramsPtr + 80);
        mostWantedUnlocksString.WriteTo(paramsPtr + 84);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 60);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 84);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ObjectivesPromptCallback;
    /// <summary>
    /// Function: ObjectivesPromptCallback
    /// </summary>
    public unsafe virtual void ObjectivesPromptCallback(BmSDK.FStringArg PadStr, BmSDK.FStringArg KeyStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ObjectivesPromptCallback, "BmGame.RHudModuleObjectives.ObjectivesPromptCallback", this);
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        PadStr.WriteTo(paramsPtr + 0);
        KeyStr.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendQueuedInfo;
    /// <summary>
    /// Function: SendQueuedInfo
    /// </summary>
    public unsafe virtual void SendQueuedInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendQueuedInfo, "BmGame.RHudModuleObjectives.SendQueuedInfo", this);
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Close, "BmGame.RHudModuleObjectives.Close", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FStringArg _ExtensionName, BmSDK.FStringArg _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "BmGame.RHudModuleObjectives.Init", this);
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        _ExtensionName.WriteTo(paramsPtr + 8);
        _ExtensionPath.WriteTo(paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// ArrayProperty: ObjectiveItemAppearanceEvents<br/>
    /// Default: (Ww_UI_InGame.Play_UI_MainStory_Update_Notify,Ww_UI_InGame.Play_UI_MainStory_Complete_Notify,Ww_UI_InGame.Play_UI_Content_Unlocked_Notify,Ww_UI_InGame.Play_UI_SideStory_Update_Notify,Ww_UI_InGame.Play...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> ObjectiveItemAppearanceEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
}
