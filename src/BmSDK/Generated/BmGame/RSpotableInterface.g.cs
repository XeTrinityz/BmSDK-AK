#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RSpotableInterface<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface RSpotableInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetGlanceScore;
    /// <summary>
    /// Function: GetGlanceScore
    /// </summary>
    public unsafe virtual int GetGlanceScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetGlanceScore, "BmGame.RSpotableInterface.GetGlanceScore", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }
}
