#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: CloudStorageUpgradeHelper<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface CloudStorageUpgradeHelper : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCloudUpgradeKeys;
    /// <summary>
    /// Function: GetCloudUpgradeKeys
    /// </summary>
    public unsafe virtual void GetCloudUpgradeKeys(out BmSDK.TArray<BmSDK.FString> CloudKeys)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCloudUpgradeKeys, "Engine.CloudStorageUpgradeHelper.GetCloudUpgradeKeys", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CloudKeys = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HandleLocalKeyValue;
    /// <summary>
    /// Function: HandleLocalKeyValue
    /// </summary>
    public unsafe virtual void HandleLocalKeyValue(out BmSDK.FString CloudKeyName, out BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceData CloudValue, out int bShouldMoveToCloud, out int bShouldDeleteLocalKey)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HandleLocalKeyValue, "Engine.CloudStorageUpgradeHelper.HandleLocalKeyValue", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShouldMoveToCloud);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldMoveToCloud, paramsPtr + 60);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShouldDeleteLocalKey);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldDeleteLocalKey, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CloudKeyName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        CloudValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceData>(paramsPtr + 16);
        bShouldMoveToCloud = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 60);
        bShouldDeleteLocalKey = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 64);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HandleLocalDocument;
    /// <summary>
    /// Function: HandleLocalDocument
    /// </summary>
    public unsafe virtual void HandleLocalDocument(out BmSDK.FString DocName, out int bShouldMoveToCloud, out int bShouldDeleteLocalFile)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HandleLocalDocument, "Engine.CloudStorageUpgradeHelper.HandleLocalDocument", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShouldMoveToCloud);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldMoveToCloud, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShouldDeleteLocalFile);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldDeleteLocalFile, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DocName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        bShouldMoveToCloud = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        bShouldDeleteLocalFile = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        return;
    }
}
