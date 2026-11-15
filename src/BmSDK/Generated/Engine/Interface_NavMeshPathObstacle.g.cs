#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_NavMeshPathObstacle<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface Interface_NavMeshPathObstacle : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetObstacleActor;
    /// <summary>
    /// Function: GetObstacleActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetObstacleActor()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetObstacleActor, "Engine.Interface_NavMeshPathObstacle.GetObstacleActor", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EEdgeHandlingStatus
    /// </summary>
    public enum EEdgeHandlingStatus : byte
    {
        EHS_AddedBothDirs = 0,
        EHS_Added0to1 = 1,
        EHS_Added1to0 = 2,
        EHS_AddedNone = 3,
        EHS_MAX = 4,
    }
}
