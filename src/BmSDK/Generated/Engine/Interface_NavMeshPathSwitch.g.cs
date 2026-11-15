#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_NavMeshPathSwitch<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface Interface_NavMeshPathSwitch : BmSDK.Engine.Interface_NavMeshPathObject
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_AIActivateSwitch;
    /// <summary>
    /// Function: AIActivateSwitch
    /// </summary>
    public unsafe virtual bool AIActivateSwitch(BmSDK.Engine.AIController AI)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AIActivateSwitch, "Engine.Interface_NavMeshPathSwitch.AIActivateSwitch", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }
}
