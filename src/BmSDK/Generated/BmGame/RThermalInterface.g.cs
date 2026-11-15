#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RThermalInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RThermalInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetInThermalMode;
    /// <summary>
    /// Function: SetInThermalMode
    /// </summary>
    public unsafe virtual void SetInThermalMode(bool On, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetInThermalMode, "BmGame.RThermalInterface.SetInThermalMode", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
