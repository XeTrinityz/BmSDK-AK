#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MHudModuleDetectiveMode_DLCHarleyQuinn<br/>
/// (size = 448)
/// (flags = 18)
/// </summary>
public partial class MHudModuleDetectiveMode_DLCHarleyQuinn : BmSDK.BmGame.RHudModuleDetectiveMode, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MHudModuleDetectiveMode_DLCHarleyQuinn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MHudModuleDetectiveMode_DLCHarleyQuinn.
    /// </summary>
    public static MHudModuleDetectiveMode_DLCHarleyQuinn DefaultObject => (MHudModuleDetectiveMode_DLCHarleyQuinn)StaticClass().DefaultObject;

    internal MHudModuleDetectiveMode_DLCHarleyQuinn() { }

    /// <summary>
    /// Constructs a new MHudModuleDetectiveMode_DLCHarleyQuinn
    /// </summary>
    public MHudModuleDetectiveMode_DLCHarleyQuinn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHudModuleDetectiveMode_DLCHarleyQuinn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHudModuleDetectiveMode_DLCHarleyQuinn(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHudModuleDetectiveMode_DLCHarleyQuinn>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleDetectiveMode_DLCHarleyQuinn>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHudModuleDetectiveMode_DLCHarleyQuinn>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleDetectiveMode_DLCHarleyQuinn>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleDetectiveMode_DLCHarleyQuinn>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleDetectiveMode_DLCHarleyQuinn>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHudModuleDetectiveMode_DLCHarleyQuinn>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHudModuleDetectiveMode_DLCHarleyQuinn>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Detective_InfoBoxOpenSound;
    /// <summary>
    /// Function: Detective_InfoBoxOpenSound
    /// </summary>
    public unsafe override void Detective_InfoBoxOpenSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Detective_InfoBoxOpenSound, "BmScript.MHudModuleDetectiveMode_DLCHarleyQuinn.Detective_InfoBoxOpenSound", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateNPCCounts;
    /// <summary>
    /// Function: UpdateNPCCounts
    /// </summary>
    public unsafe override void UpdateNPCCounts(int Armed, int UnArmed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateNPCCounts, "BmScript.MHudModuleDetectiveMode_DLCHarleyQuinn.UpdateNPCCounts", this);
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HideInfoText;
    /// <summary>
    /// Function: HideInfoText
    /// </summary>
    public unsafe override void HideInfoText()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HideInfoText, "BmScript.MHudModuleDetectiveMode_DLCHarleyQuinn.HideInfoText", this);
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetInfoText;
    /// <summary>
    /// Function: SetInfoText
    /// </summary>
    public unsafe override void SetInfoText(float location_x, float location_y, float location_depth, BmSDK.FStringArg Heading, BmSDK.FStringArg Description, bool Warning)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInfoText, "BmScript.MHudModuleDetectiveMode_DLCHarleyQuinn.SetInfoText", this);
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        Heading.WriteTo(paramsPtr + 12);
        Description.WriteTo(paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Warning, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        return;
    }
}
