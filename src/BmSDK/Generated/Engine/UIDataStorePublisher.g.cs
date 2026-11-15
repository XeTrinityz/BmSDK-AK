#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: UIDataStorePublisher<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface UIDataStorePublisher : BmSDK.Engine.UIDataStoreSubscriber
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_SaveSubscriberValue;
    /// <summary>
    /// Function: SaveSubscriberValue
    /// </summary>
    public unsafe virtual bool SaveSubscriberValue(out BmSDK.TArray<BmSDK.Engine.UIDataStore> out_BoundDataStores, int BindingIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SaveSubscriberValue, "Engine.UIDataStorePublisher.SaveSubscriberValue", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BindingIndex, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_BoundDataStores = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.UIDataStore>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }
}
