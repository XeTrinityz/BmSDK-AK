#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Interface: RCarListenerInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RCarListenerInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_BatmanLeftCar;
    /// <summary>
    /// Function: BatmanLeftCar
    /// </summary>
    public unsafe virtual void BatmanLeftCar()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BatmanLeftCar, "BmScript.RCarListenerInterface.BatmanLeftCar", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
