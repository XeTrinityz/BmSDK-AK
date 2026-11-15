#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: SharedCloudFileInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface SharedCloudFileInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteSharedFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteSharedFileCompleteDelegate(BmSDK.FScriptDelegate WriteSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteSharedFileCompleteDelegate, "Engine.SharedCloudFileInterface.ClearWriteSharedFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteSharedFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteSharedFileCompleteDelegate(BmSDK.FScriptDelegate WriteSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteSharedFileCompleteDelegate, "Engine.SharedCloudFileInterface.AddWriteSharedFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteSharedFile;
    /// <summary>
    /// Function: WriteSharedFile
    /// </summary>
    public unsafe virtual bool WriteSharedFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> Contents)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteSharedFile, "Engine.SharedCloudFileInterface.WriteSharedFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        Contents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteSharedFileComplete;
    /// <summary>
    /// Function: OnWriteSharedFileComplete
    /// </summary>
    public unsafe virtual void OnWriteSharedFileComplete(bool bWasSuccessful, BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, BmSDK.FStringArg SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteSharedFileComplete, "Engine.SharedCloudFileInterface.OnWriteSharedFileComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        Filename.WriteTo(paramsPtr + 20);
        SharedHandle.WriteTo(paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadSharedFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadSharedFileCompleteDelegate(BmSDK.FScriptDelegate ReadSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadSharedFileCompleteDelegate, "Engine.SharedCloudFileInterface.ClearReadSharedFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadSharedFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadSharedFileCompleteDelegate(BmSDK.FScriptDelegate ReadSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadSharedFileCompleteDelegate, "Engine.SharedCloudFileInterface.AddReadSharedFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadSharedFile;
    /// <summary>
    /// Function: ReadSharedFile
    /// </summary>
    public unsafe virtual bool ReadSharedFile(BmSDK.FStringArg SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadSharedFile, "Engine.SharedCloudFileInterface.ReadSharedFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        SharedHandle.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadSharedFileComplete;
    /// <summary>
    /// Function: OnReadSharedFileComplete
    /// </summary>
    public unsafe virtual void OnReadSharedFileComplete(bool bWasSuccessful, BmSDK.FStringArg SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadSharedFileComplete, "Engine.SharedCloudFileInterface.OnReadSharedFileComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        SharedHandle.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearSharedFile;
    /// <summary>
    /// Function: ClearSharedFile
    /// </summary>
    public unsafe virtual bool ClearSharedFile(BmSDK.FStringArg SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearSharedFile, "Engine.SharedCloudFileInterface.ClearSharedFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        SharedHandle.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearSharedFiles;
    /// <summary>
    /// Function: ClearSharedFiles
    /// </summary>
    public unsafe virtual bool ClearSharedFiles()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearSharedFiles, "Engine.SharedCloudFileInterface.ClearSharedFiles", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSharedFileContents;
    /// <summary>
    /// Function: GetSharedFileContents
    /// </summary>
    public unsafe virtual bool GetSharedFileContents(BmSDK.FStringArg SharedHandle, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSharedFileContents, "Engine.SharedCloudFileInterface.GetSharedFileContents", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        SharedHandle.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }
}
