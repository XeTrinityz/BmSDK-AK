#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: MHackableInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface MHackableInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_SpawnPreviewSubroutine;
    /// <summary>
    /// Function: SpawnPreviewSubroutine
    /// </summary>
    public unsafe virtual void SpawnPreviewSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SpawnPreviewSubroutine, "BmGame.MHackableInterface.SpawnPreviewSubroutine", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisableSubroutineType;
    /// <summary>
    /// Function: DisableSubroutineType
    /// </summary>
    public unsafe virtual void DisableSubroutineType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, bool NewIsDisable)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisableSubroutineType, "BmGame.MHackableInterface.DisableSubroutineType", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewIsDisable, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetSubroutineNameAndDescriptionModifiedByKismet;
    /// <summary>
    /// Function: SetSubroutineNameAndDescriptionModifiedByKismet
    /// </summary>
    public unsafe virtual void SetSubroutineNameAndDescriptionModifiedByKismet(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, BmSDK.FStringArg NewSubroutineName, BmSDK.FStringArg NewSubroutineDescription)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetSubroutineNameAndDescriptionModifiedByKismet, "BmGame.MHackableInterface.SetSubroutineNameAndDescriptionModifiedByKismet", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        NewSubroutineName.WriteTo(paramsPtr + 4);
        NewSubroutineDescription.WriteTo(paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateHackMaskMesh;
    /// <summary>
    /// Function: CreateHackMaskMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.StaticMeshComponent CreateHackMaskMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateHackMaskMesh, "BmGame.MHackableInterface.CreateHackMaskMesh", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.StaticMeshComponent>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetInHackableMode;
    /// <summary>
    /// Function: SetInHackableMode
    /// </summary>
    public unsafe virtual void SetInHackableMode(bool On, bool bForce)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInHackableMode, "BmGame.MHackableInterface.SetInHackableMode", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NotifyOnHack;
    /// <summary>
    /// Function: NotifyOnHack
    /// </summary>
    public unsafe virtual void NotifyOnHack(BmSDK.Engine.Actor HackedObject, BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NotifyOnHack, "BmGame.MHackableInterface.NotifyOnHack", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackedObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAffectedActors;
    /// <summary>
    /// Function: GetAffectedActors
    /// </summary>
    public unsafe virtual void GetAffectedActors(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass, out BmSDK.TArray<BmSDK.Engine.Actor> AffectedActors)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAffectedActors, "BmGame.MHackableInterface.GetAffectedActors", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AffectedActors = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPossibleSubroutineTypes;
    /// <summary>
    /// Function: GetPossibleSubroutineTypes
    /// </summary>
    public unsafe virtual void GetPossibleSubroutineTypes(out BmSDK.TArray<BmSDK.BmGame.MHackableInterface.EHackSubroutineType> PossibleTypes)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPossibleSubroutineTypes, "BmGame.MHackableInterface.GetPossibleSubroutineTypes", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleTypes = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnToggle, "BmGame.MHackableInterface.OnToggle", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSubroutineDefinitionForType;
    /// <summary>
    /// Function: GetSubroutineDefinitionForType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackableInterface.FSubroutineDefinition GetSubroutineDefinitionForType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSubroutineDefinitionForType, "BmGame.MHackableInterface.GetSubroutineDefinitionForType", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPreviewSubroutine;
    /// <summary>
    /// Function: GetPreviewSubroutine
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackSubroutine GetPreviewSubroutine()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPreviewSubroutine, "BmGame.MHackableInterface.GetPreviewSubroutine", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MHackSubroutine>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCurrentSubroutine;
    /// <summary>
    /// Function: GetCurrentSubroutine
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackSubroutine GetCurrentSubroutine()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCurrentSubroutine, "BmGame.MHackableInterface.GetCurrentSubroutine", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MHackSubroutine>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCurrentSubroutineType;
    /// <summary>
    /// Function: GetCurrentSubroutineType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackableInterface.EHackSubroutineType GetCurrentSubroutineType()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCurrentSubroutineType, "BmGame.MHackableInterface.GetCurrentSubroutineType", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHackableState;
    /// <summary>
    /// Function: GetHackableState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackableInterface.EHackableObjectState GetHackableState()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHackableState, "BmGame.MHackableInterface.GetHackableState", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MHackableInterface.EHackableObjectState>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDisplayTargetLocation;
    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDisplayTargetLocation, "BmGame.MHackableInterface.GetDisplayTargetLocation", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSubroutineDescription;
    /// <summary>
    /// Function: GetSubroutineDescription
    /// </summary>
    public unsafe virtual BmSDK.FString GetSubroutineDescription(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSubroutineDescription, "BmGame.MHackableInterface.GetSubroutineDescription", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Definition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 72);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSubroutineName;
    /// <summary>
    /// Function: GetSubroutineName
    /// </summary>
    public unsafe virtual BmSDK.FString GetSubroutineName(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSubroutineName, "BmGame.MHackableInterface.GetSubroutineName", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Definition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 72);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNumberOfSubroutineTypes;
    /// <summary>
    /// Function: GetNumberOfSubroutineTypes
    /// </summary>
    public unsafe virtual int GetNumberOfSubroutineTypes()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNumberOfSubroutineTypes, "BmGame.MHackableInterface.GetNumberOfSubroutineTypes", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerCancelEvent;
    /// <summary>
    /// Function: TriggerCancelEvent
    /// </summary>
    public unsafe virtual bool TriggerCancelEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerCancelEvent, "BmGame.MHackableInterface.TriggerCancelEvent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerCompleteEvent;
    /// <summary>
    /// Function: TriggerCompleteEvent
    /// </summary>
    public unsafe virtual bool TriggerCompleteEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerCompleteEvent, "BmGame.MHackableInterface.TriggerCompleteEvent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_TriggerEvent;
    /// <summary>
    /// Function: TriggerEvent
    /// </summary>
    public unsafe virtual bool TriggerEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_TriggerEvent, "BmGame.MHackableInterface.TriggerEvent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NeedToDisplayNumberOfTargets;
    /// <summary>
    /// Function: NeedToDisplayNumberOfTargets
    /// </summary>
    public unsafe virtual bool NeedToDisplayNumberOfTargets()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NeedToDisplayNumberOfTargets, "BmGame.MHackableInterface.NeedToDisplayNumberOfTargets", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsSubroutineTypeDisable;
    /// <summary>
    /// Function: IsSubroutineTypeDisable
    /// </summary>
    public unsafe virtual bool IsSubroutineTypeDisable(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsSubroutineTypeDisable, "BmGame.MHackableInterface.IsSubroutineTypeDisable", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsObjectEnable;
    /// <summary>
    /// Function: IsObjectEnable
    /// </summary>
    public unsafe virtual bool IsObjectEnable()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsObjectEnable, "BmGame.MHackableInterface.IsObjectEnable", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanBeExecuted;
    /// <summary>
    /// Function: CanBeExecuted
    /// </summary>
    public unsafe virtual bool CanBeExecuted()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanBeExecuted, "BmGame.MHackableInterface.CanBeExecuted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CanInterrupt;
    /// <summary>
    /// Function: CanInterrupt
    /// </summary>
    public unsafe virtual bool CanInterrupt(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CanInterrupt, "BmGame.MHackableInterface.CanInterrupt", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ExecuteSubroutine;
    /// <summary>
    /// Function: ExecuteSubroutine
    /// </summary>
    public unsafe virtual bool ExecuteSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ExecuteSubroutine, "BmGame.MHackableInterface.ExecuteSubroutine", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Struct: FSubroutineDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FSubroutineDefinition
    {
        /// <summary>
        /// ByteProperty: SubroutineType
        /// </summary>
        public unsafe BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: SubroutineContext
        /// </summary>
        public unsafe BmSDK.BmGame.MHackSubroutineContext SubroutineContext
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutineContext>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: SubroutineLocalizedId
        /// </summary>
        public unsafe BmSDK.FString SubroutineLocalizedId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: SubroutineDescriptionLocalizedId
        /// </summary>
        public unsafe BmSDK.FString SubroutineDescriptionLocalizedId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: SubroutineIcon
        /// </summary>
        public unsafe BmSDK.BmGame.MHackableInterface.EHackSubroutineIcon SubroutineIcon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackSubroutineIcon>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ArrayProperty: SubroutineAffectedActors
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SubroutineAffectedActors
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ObjectProperty: SubroutineLookAtActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor SubroutineLookAtActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Enum: EHackSubroutineIcon
    /// </summary>
    public enum EHackSubroutineIcon : byte
    {
        HACKICON_None = 0,
        HACKICON_Generic_Attract = 1,
        HACKICON_Generic_Takedown = 2,
        HACKICON_Generic_Scare = 3,
        HACKICON_Generic_Blind = 4,
        HACKICON_Generic_Control = 5,
        HACKICON_Generic_Door = 6,
        HACKICON_Generic_Deactivate = 7,
        HACKICON_Generic_Activate = 8,
        HACKICON_MAX = 9,
    }

    /// <summary>
    /// Enum: EHackableObjectState
    /// </summary>
    public enum EHackableObjectState : byte
    {
        HOS_Unavailable = 0,
        HOS_Running = 1,
        HOS_Available = 2,
        HOS_MAX = 3,
    }

    /// <summary>
    /// Enum: EHackSubroutineType
    /// </summary>
    public enum EHackSubroutineType : byte
    {
        HACKTYPE_None = 0,
        HACKTYPE_Toggle = 1,
        HACKTYPE_Control = 2,
        HACKTYPE_Takedown = 3,
        HACKTYPE_Attract = 4,
        HACKTYPE_Scare = 5,
        HACKTYPE_Trap = 6,
        HACKTYPE_Blind = 7,
        HACKTYPE_MAX = 8,
    }
}
