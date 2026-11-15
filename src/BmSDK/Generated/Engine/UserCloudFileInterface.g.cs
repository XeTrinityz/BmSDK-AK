#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: UserCloudFileInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface UserCloudFileInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteFileToScatch;
    /// <summary>
    /// Function: WriteFileToScatch
    /// </summary>
    public unsafe virtual bool WriteFileToScatch(byte LocalUserNum, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteFileToScatch, "Engine.UserCloudFileInterface.WriteFileToScatch", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadFileFromScatch;
    /// <summary>
    /// Function: ReadFileFromScatch
    /// </summary>
    public unsafe virtual bool ReadFileFromScatch(byte LocalUserNum, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> OutFileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadFileFromScatch, "Engine.UserCloudFileInterface.ReadFileFromScatch", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        OutFileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearAllDelegates;
    /// <summary>
    /// Function: ClearAllDelegates
    /// </summary>
    public unsafe virtual void ClearAllDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearAllDelegates, "Engine.UserCloudFileInterface.ClearAllDelegates", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CancelDownloadFileIO;
    /// <summary>
    /// Function: CancelDownloadFileIO
    /// </summary>
    public unsafe virtual void CancelDownloadFileIO()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CancelDownloadFileIO, "Engine.UserCloudFileInterface.CancelDownloadFileIO", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDeleteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearDeleteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDeleteDownloadFileCompleteDelegate(BmSDK.FScriptDelegate DeleteDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDeleteDownloadFileCompleteDelegate, "Engine.UserCloudFileInterface.ClearDeleteDownloadFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDeleteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddDeleteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDeleteDownloadFileCompleteDelegate(BmSDK.FScriptDelegate DeleteDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDeleteDownloadFileCompleteDelegate, "Engine.UserCloudFileInterface.AddDeleteDownloadFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnDeleteDownloadFileComplete;
    /// <summary>
    /// Function: OnDeleteDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteDownloadFileComplete(bool bWasSuccessful, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnDeleteDownloadFileComplete, "Engine.UserCloudFileInterface.OnDeleteDownloadFileComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteDownloadFile;
    /// <summary>
    /// Function: DeleteDownloadFile
    /// </summary>
    public unsafe virtual bool DeleteDownloadFile(BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteDownloadFile, "Engine.UserCloudFileInterface.DeleteDownloadFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteDownloadFileCompleteDelegate(BmSDK.FScriptDelegate WriteDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteDownloadFileCompleteDelegate, "Engine.UserCloudFileInterface.ClearWriteDownloadFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteDownloadFileCompleteDelegate(BmSDK.FScriptDelegate WriteDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteDownloadFileCompleteDelegate, "Engine.UserCloudFileInterface.AddWriteDownloadFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteDownloadFileComplete;
    /// <summary>
    /// Function: OnWriteDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnWriteDownloadFileComplete(bool bWasSuccessful, BmSDK.FStringArg Filename, int bytesProcessed)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteDownloadFileComplete, "Engine.UserCloudFileInterface.OnWriteDownloadFileComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteDownloadFile;
    /// <summary>
    /// Function: WriteDownloadFile
    /// </summary>
    public unsafe virtual bool WriteDownloadFile(BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents, out BmSDK.FString FileCRC)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteDownloadFile, "Engine.UserCloudFileInterface.WriteDownloadFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        FileCRC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadDownloadFileCompleteDelegate(BmSDK.FScriptDelegate ReadDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadDownloadFileCompleteDelegate, "Engine.UserCloudFileInterface.ClearReadDownloadFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadDownloadFileCompleteDelegate(BmSDK.FScriptDelegate ReadDownloadFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadDownloadFileCompleteDelegate, "Engine.UserCloudFileInterface.AddReadDownloadFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadDownloadFileComplete;
    /// <summary>
    /// Function: OnReadDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnReadDownloadFileComplete(bool bWasSuccessful, BmSDK.FStringArg Filename, int bytesProcessed)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadDownloadFileComplete, "Engine.UserCloudFileInterface.OnReadDownloadFileComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadDownloadFile;
    /// <summary>
    /// Function: ReadDownloadFile
    /// </summary>
    public unsafe virtual bool ReadDownloadFile(BmSDK.FStringArg Filename, out BmSDK.TArray<byte> OutFileContents, out BmSDK.FString OutFileCRC)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadDownloadFile, "Engine.UserCloudFileInterface.ReadDownloadFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        OutFileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 16);
        OutFileCRC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDownloadFileSize;
    /// <summary>
    /// Function: GetDownloadFileSize
    /// </summary>
    public unsafe virtual int GetDownloadFileSize(BmSDK.FStringArg Filename, bool KeepHandle = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDownloadFileSize, "Engine.UserCloudFileInterface.GetDownloadFileSize", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Filename.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeepHandle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnumerateDownloadFiles;
    /// <summary>
    /// Function: EnumerateDownloadFiles
    /// </summary>
    public unsafe virtual void EnumerateDownloadFiles(out BmSDK.TArray<BmSDK.FString> OutFiles, BmSDK.FStringArg Subfolder)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnumerateDownloadFiles, "Engine.UserCloudFileInterface.EnumerateDownloadFiles", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Subfolder.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        OutFiles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnumerateDownloadFolders;
    /// <summary>
    /// Function: EnumerateDownloadFolders
    /// </summary>
    public unsafe virtual void EnumerateDownloadFolders(out BmSDK.TArray<BmSDK.FString> OutFolders)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnumerateDownloadFolders, "Engine.UserCloudFileInterface.EnumerateDownloadFolders", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutFolders = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDeleteUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDeleteUserFileCompleteDelegate(BmSDK.FScriptDelegate DeleteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDeleteUserFileCompleteDelegate, "Engine.UserCloudFileInterface.ClearDeleteUserFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDeleteUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDeleteUserFileCompleteDelegate(BmSDK.FScriptDelegate DeleteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDeleteUserFileCompleteDelegate, "Engine.UserCloudFileInterface.AddDeleteUserFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteUserFile;
    /// <summary>
    /// Function: DeleteUserFile
    /// </summary>
    public unsafe virtual bool DeleteUserFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, bool bShouldCloudDelete, bool bShouldLocallyDelete)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteUserFile, "Engine.UserCloudFileInterface.DeleteUserFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldCloudDelete, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldLocallyDelete, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnDeleteUserFileComplete;
    /// <summary>
    /// Function: OnDeleteUserFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteUserFileComplete(bool bWasSuccessful, BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnDeleteUserFileComplete, "Engine.UserCloudFileInterface.OnDeleteUserFileComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        Filename.WriteTo(paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteUserFileCompleteDelegate(BmSDK.FScriptDelegate WriteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteUserFileCompleteDelegate, "Engine.UserCloudFileInterface.ClearWriteUserFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteUserFileCompleteDelegate(BmSDK.FScriptDelegate WriteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteUserFileCompleteDelegate, "Engine.UserCloudFileInterface.AddWriteUserFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteUserFile;
    /// <summary>
    /// Function: WriteUserFile
    /// </summary>
    public unsafe virtual bool WriteUserFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteUserFile, "Engine.UserCloudFileInterface.WriteUserFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteUserFileComplete;
    /// <summary>
    /// Function: OnWriteUserFileComplete
    /// </summary>
    public unsafe virtual void OnWriteUserFileComplete(bool bWasSuccessful, BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteUserFileComplete, "Engine.UserCloudFileInterface.OnWriteUserFileComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        Filename.WriteTo(paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadUserFileCompleteDelegate(BmSDK.FScriptDelegate ReadUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadUserFileCompleteDelegate, "Engine.UserCloudFileInterface.ClearReadUserFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadUserFileCompleteDelegate(BmSDK.FScriptDelegate ReadUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadUserFileCompleteDelegate, "Engine.UserCloudFileInterface.AddReadUserFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadUserFile;
    /// <summary>
    /// Function: ReadUserFile
    /// </summary>
    public unsafe virtual bool ReadUserFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadUserFile, "Engine.UserCloudFileInterface.ReadUserFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadUserFileComplete;
    /// <summary>
    /// Function: OnReadUserFileComplete
    /// </summary>
    public unsafe virtual void OnReadUserFileComplete(bool bWasSuccessful, BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadUserFileComplete, "Engine.UserCloudFileInterface.OnReadUserFileComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        Filename.WriteTo(paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUserFileList;
    /// <summary>
    /// Function: GetUserFileList
    /// </summary>
    public unsafe virtual void GetUserFileList(BmSDK.FStringArg UserId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserFiles)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUserFileList, "Engine.UserCloudFileInterface.GetUserFileList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        UserFiles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearEnumerateUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearEnumerateUserFileCompleteDelegate(BmSDK.FScriptDelegate EnumerateUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearEnumerateUserFileCompleteDelegate, "Engine.UserCloudFileInterface.ClearEnumerateUserFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnumerateUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddEnumerateUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddEnumerateUserFileCompleteDelegate(BmSDK.FScriptDelegate EnumerateUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddEnumerateUserFileCompleteDelegate, "Engine.UserCloudFileInterface.AddEnumerateUserFileCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnumerateUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_EnumerateUserFiles;
    /// <summary>
    /// Function: EnumerateUserFiles
    /// </summary>
    public unsafe virtual void EnumerateUserFiles(BmSDK.FStringArg UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_EnumerateUserFiles, "Engine.UserCloudFileInterface.EnumerateUserFiles", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnEnumerateUserFilesComplete;
    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe virtual void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FStringArg UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnEnumerateUserFilesComplete, "Engine.UserCloudFileInterface.OnEnumerateUserFilesComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        UserId.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFile;
    /// <summary>
    /// Function: ClearFile
    /// </summary>
    public unsafe virtual bool ClearFile(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFile, "Engine.UserCloudFileInterface.ClearFile", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFiles;
    /// <summary>
    /// Function: ClearFiles
    /// </summary>
    public unsafe virtual bool ClearFiles(BmSDK.FStringArg UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFiles, "Engine.UserCloudFileInterface.ClearFiles", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFileContents;
    /// <summary>
    /// Function: GetFileContents
    /// </summary>
    public unsafe virtual bool GetFileContents(BmSDK.FStringArg UserId, BmSDK.FStringArg Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFileContents, "Engine.UserCloudFileInterface.GetFileContents", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        UserId.WriteTo(paramsPtr + 0);
        Filename.WriteTo(paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }
}
