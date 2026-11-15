#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_BagCarrierDialogue_StaggA1<br/>
/// (size = 424)
/// (flags = 8396818)
/// </summary>
public partial class RSeqAct_BagCarrierDialogue_StaggA1 : BmSDK.BmGame.RSeqAct_BagCarrierDialogue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_BagCarrierDialogue_StaggA1", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_BagCarrierDialogue_StaggA1.
    /// </summary>
    public static RSeqAct_BagCarrierDialogue_StaggA1 DefaultObject => (RSeqAct_BagCarrierDialogue_StaggA1)StaticClass().DefaultObject;

    internal RSeqAct_BagCarrierDialogue_StaggA1() { }

    /// <summary>
    /// Constructs a new RSeqAct_BagCarrierDialogue_StaggA1
    /// </summary>
    public RSeqAct_BagCarrierDialogue_StaggA1(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_BagCarrierDialogue_StaggA1 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_BagCarrierDialogue_StaggA1(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_BagCarrierDialogue_StaggA1>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_BagCarrierDialogue_StaggA1>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_BagCarrierDialogue_StaggA1>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_BagCarrierDialogue_StaggA1>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_BagCarrierDialogue_StaggA1>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_BagCarrierDialogue_StaggA1>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_BagCarrierDialogue_StaggA1>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_BagCarrierDialogue_StaggA1>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RSeqAct_BagCarrierDialogue_StaggA1.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDialogueLocationForPickupPoint;
    /// <summary>
    /// Function: GetDialogueLocationForPickupPoint
    /// </summary>
    public unsafe virtual BmSDK.FName GetDialogueLocationForPickupPoint(BmSDK.BmGame.RLootSourceBase PickupPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDialogueLocationForPickupPoint, "BmScript.RSeqAct_BagCarrierDialogue_StaggA1.GetDialogueLocationForPickupPoint", this);
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PickupPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerLeaderOrders;
    /// <summary>
    /// Function: TriggerLeaderOrders
    /// </summary>
    public unsafe virtual void TriggerLeaderOrders(BmSDK.FName DialogueLocationName, System.Numerics.Vector3 Location)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerLeaderOrders, "BmScript.RSeqAct_BagCarrierDialogue_StaggA1.TriggerLeaderOrders", this);
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLocationName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanTriggerIncidentalDialogue;
    /// <summary>
    /// Function: CanTriggerIncidentalDialogue
    /// </summary>
    public unsafe override bool CanTriggerIncidentalDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanTriggerIncidentalDialogue, "BmScript.RSeqAct_BagCarrierDialogue_StaggA1.CanTriggerIncidentalDialogue", this);
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BagDroppedOff;
    /// <summary>
    /// Function: BagDroppedOff
    /// </summary>
    public unsafe override void BagDroppedOff(BmSDK.BmGame.RPawnVillain bagCarrier, BmSDK.BmGame.RLootDestinationBase dropoffPoint, BmSDK.BmGame.RLootSourceBase nextPickupPoint, bool bagCarryingFinished)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BagDroppedOff, "BmScript.RSeqAct_BagCarrierDialogue_StaggA1.BagDroppedOff", this);
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bagCarrier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dropoffPoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nextPickupPoint, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bagCarryingFinished, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bDoneFirstDropoff
    /// </summary>
    public unsafe bool bDoneFirstDropoff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }
}
