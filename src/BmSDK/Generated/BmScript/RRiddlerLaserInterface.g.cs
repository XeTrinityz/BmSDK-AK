#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Interface: RRiddlerLaserInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RRiddlerLaserInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_LaserNoLongerHitting;
    /// <summary>
    /// Function: LaserNoLongerHitting
    /// </summary>
    public unsafe virtual void LaserNoLongerHitting()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LaserNoLongerHitting, "BmScript.RRiddlerLaserInterface.LaserNoLongerHitting", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_LaserHit;
    /// <summary>
    /// Function: LaserHit
    /// </summary>
    public unsafe virtual void LaserHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_LaserHit, "BmScript.RRiddlerLaserInterface.LaserHit", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
