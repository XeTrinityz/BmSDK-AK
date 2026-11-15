#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_AudioImpact<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface Interface_AudioImpact : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetImpactAudioEvent;
    /// <summary>
    /// Function: GetImpactAudioEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetImpactAudioEvent(BmSDK.Engine.AkWwise.EAkWorldMaterial Mat)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetImpactAudioEvent, "Engine.Interface_AudioImpact.GetImpactAudioEvent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }
}
