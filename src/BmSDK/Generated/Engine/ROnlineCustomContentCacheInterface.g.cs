#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: ROnlineCustomContentCacheInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface ROnlineCustomContentCacheInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_FlagObsoleteInRegistry;
    /// <summary>
    /// Function: FlagObsoleteInRegistry
    /// </summary>
    public unsafe virtual bool FlagObsoleteInRegistry(BmSDK.FStringArg Filename, BmSDK.FStringArg Subfolder)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FlagObsoleteInRegistry, "Engine.ROnlineCustomContentCacheInterface.FlagObsoleteInRegistry", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        Subfolder.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdateRegistry;
    /// <summary>
    /// Function: UpdateRegistry
    /// </summary>
    public unsafe virtual void UpdateRegistry(BmSDK.FStringArg Filename, BmSDK.FStringArg Subfolder, int Crc32, int Size, bool bObsolete)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdateRegistry, "Engine.ROnlineCustomContentCacheInterface.UpdateRegistry", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        Subfolder.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Crc32, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bObsolete, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddToDeleteQueue;
    /// <summary>
    /// Function: AddToDeleteQueue
    /// </summary>
    public unsafe virtual void AddToDeleteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddToDeleteQueue, "Engine.ROnlineCustomContentCacheInterface.AddToDeleteQueue", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddToWriteQueue;
    /// <summary>
    /// Function: AddToWriteQueue
    /// </summary>
    public unsafe virtual void AddToWriteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddToWriteQueue, "Engine.ROnlineCustomContentCacheInterface.AddToWriteQueue", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RemoveFromReadQueue;
    /// <summary>
    /// Function: RemoveFromReadQueue
    /// </summary>
    public unsafe virtual void RemoveFromReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RemoveFromReadQueue, "Engine.ROnlineCustomContentCacheInterface.RemoveFromReadQueue", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddToReadQueue;
    /// <summary>
    /// Function: AddToReadQueue
    /// </summary>
    public unsafe virtual void AddToReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddToReadQueue, "Engine.ROnlineCustomContentCacheInterface.AddToReadQueue", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
