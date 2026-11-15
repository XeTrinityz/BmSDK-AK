#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineContentInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineContentInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearSaveGames;
    /// <summary>
    /// Function: ClearSaveGames
    /// </summary>
    public unsafe virtual bool ClearSaveGames(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearSaveGames, "Engine.OnlineContentInterface.ClearSaveGames", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DeleteSaveGame;
    /// <summary>
    /// Function: DeleteSaveGame
    /// </summary>
    public unsafe virtual bool DeleteSaveGame(byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DeleteSaveGame, "Engine.OnlineContentInterface.DeleteSaveGame", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        FriendlyName.WriteTo(paramsPtr + 8);
        Filename.WriteTo(paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearWriteSaveGameDataComplete;
    /// <summary>
    /// Function: ClearWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearWriteSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate WriteSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearWriteSaveGameDataComplete, "Engine.OnlineContentInterface.ClearWriteSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddWriteSaveGameDataComplete;
    /// <summary>
    /// Function: AddWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddWriteSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate WriteSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddWriteSaveGameDataComplete, "Engine.OnlineContentInterface.AddWriteSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnWriteSaveGameDataComplete;
    /// <summary>
    /// Function: OnWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnWriteSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnWriteSaveGameDataComplete, "Engine.OnlineContentInterface.OnWriteSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        FriendlyName.WriteTo(paramsPtr + 12);
        Filename.WriteTo(paramsPtr + 28);
        SaveFileName.WriteTo(paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteSaveGameData;
    /// <summary>
    /// Function: WriteSaveGameData
    /// </summary>
    public unsafe virtual bool WriteSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName, out BmSDK.TArray<byte> SaveGameData)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteSaveGameData, "Engine.OnlineContentInterface.WriteSaveGameData", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        FriendlyName.WriteTo(paramsPtr + 8);
        Filename.WriteTo(paramsPtr + 24);
        SaveFileName.WriteTo(paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 40);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 56);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadSaveGameDataComplete;
    /// <summary>
    /// Function: ClearReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearReadSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadSaveGameDataComplete, "Engine.OnlineContentInterface.ClearReadSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadSaveGameDataComplete;
    /// <summary>
    /// Function: AddReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddReadSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadSaveGameDataComplete, "Engine.OnlineContentInterface.AddReadSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadSaveGameDataComplete;
    /// <summary>
    /// Function: OnReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnReadSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadSaveGameDataComplete, "Engine.OnlineContentInterface.OnReadSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        FriendlyName.WriteTo(paramsPtr + 12);
        Filename.WriteTo(paramsPtr + 28);
        SaveFileName.WriteTo(paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetSaveGameData;
    /// <summary>
    /// Function: GetSaveGameData
    /// </summary>
    public unsafe virtual bool GetSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetSaveGameData, "Engine.OnlineContentInterface.GetSaveGameData", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        FriendlyName.WriteTo(paramsPtr + 8);
        Filename.WriteTo(paramsPtr + 24);
        SaveFileName.WriteTo(paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bIsValid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsValid, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 40);
        bIsValid = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 56);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 76);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadSaveGameData;
    /// <summary>
    /// Function: ReadSaveGameData
    /// </summary>
    public unsafe virtual bool ReadSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadSaveGameData, "Engine.OnlineContentInterface.ReadSaveGameData", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        FriendlyName.WriteTo(paramsPtr + 8);
        Filename.WriteTo(paramsPtr + 24);
        SaveFileName.WriteTo(paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 24);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 56);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetAvailableDownloadCounts;
    /// <summary>
    /// Function: GetAvailableDownloadCounts
    /// </summary>
    public unsafe virtual void GetAvailableDownloadCounts(byte LocalUserNum, out int NewDownloads, out int TotalDownloads)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetAvailableDownloadCounts, "Engine.OnlineContentInterface.GetAvailableDownloadCounts", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewDownloads);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDownloads, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalDownloads);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalDownloads, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewDownloads = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        TotalDownloads = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: ClearQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void ClearQueryAvailableDownloadsComplete(byte LocalUserNum, BmSDK.FScriptDelegate QueryDownloadsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearQueryAvailableDownloadsComplete, "Engine.OnlineContentInterface.ClearQueryAvailableDownloadsComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDownloadsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: AddQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void AddQueryAvailableDownloadsComplete(byte LocalUserNum, BmSDK.FScriptDelegate QueryDownloadsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddQueryAvailableDownloadsComplete, "Engine.OnlineContentInterface.AddQueryAvailableDownloadsComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDownloadsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: OnQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void OnQueryAvailableDownloadsComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnQueryAvailableDownloadsComplete, "Engine.OnlineContentInterface.OnQueryAvailableDownloadsComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_QueryAvailableDownloads;
    /// <summary>
    /// Function: QueryAvailableDownloads
    /// </summary>
    public unsafe virtual bool QueryAvailableDownloads(byte LocalUserNum, int CategoryMask = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_QueryAvailableDownloads, "Engine.OnlineContentInterface.QueryAvailableDownloads", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryMask, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearCrossTitleSaveGames;
    /// <summary>
    /// Function: ClearCrossTitleSaveGames
    /// </summary>
    public unsafe virtual bool ClearCrossTitleSaveGames(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearCrossTitleSaveGames, "Engine.OnlineContentInterface.ClearCrossTitleSaveGames", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: ClearReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadCrossTitleSaveGameDataComplete, "Engine.OnlineContentInterface.ClearReadCrossTitleSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: AddReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddReadCrossTitleSaveGameDataComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadSaveGameDataCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadCrossTitleSaveGameDataComplete, "Engine.OnlineContentInterface.AddReadCrossTitleSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: OnReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadCrossTitleSaveGameDataComplete, "Engine.OnlineContentInterface.OnReadCrossTitleSaveGameDataComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 12);
        FriendlyName.WriteTo(paramsPtr + 16);
        Filename.WriteTo(paramsPtr + 32);
        SaveFileName.WriteTo(paramsPtr + 48);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 16);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 32);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 48);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCrossTitleSaveGameData;
    /// <summary>
    /// Function: GetCrossTitleSaveGameData
    /// </summary>
    public unsafe virtual bool GetCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCrossTitleSaveGameData, "Engine.OnlineContentInterface.GetCrossTitleSaveGameData", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 8);
        FriendlyName.WriteTo(paramsPtr + 12);
        Filename.WriteTo(paramsPtr + 28);
        SaveFileName.WriteTo(paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bIsValid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsValid, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        bIsValid = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 60);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 80);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadCrossTitleSaveGameData;
    /// <summary>
    /// Function: ReadCrossTitleSaveGameData
    /// </summary>
    public unsafe virtual bool ReadCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FStringArg FriendlyName, BmSDK.FStringArg Filename, BmSDK.FStringArg SaveFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadCrossTitleSaveGameData, "Engine.OnlineContentInterface.ReadCrossTitleSaveGameData", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 8);
        FriendlyName.WriteTo(paramsPtr + 12);
        Filename.WriteTo(paramsPtr + 28);
        SaveFileName.WriteTo(paramsPtr + 44);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 28);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 44);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadCrossTitleContentCompleteDelegate;
    /// <summary>
    /// Function: ClearReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, BmSDK.FScriptDelegate ReadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadCrossTitleContentCompleteDelegate, "Engine.OnlineContentInterface.ClearReadCrossTitleContentCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadCrossTitleContentCompleteDelegate;
    /// <summary>
    /// Function: AddReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, BmSDK.FScriptDelegate ReadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadCrossTitleContentCompleteDelegate, "Engine.OnlineContentInterface.AddReadCrossTitleContentCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadCrossTitleContentComplete;
    /// <summary>
    /// Function: OnReadCrossTitleContentComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleContentComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadCrossTitleContentComplete, "Engine.OnlineContentInterface.OnReadCrossTitleContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCrossTitleContentList;
    /// <summary>
    /// Function: GetCrossTitleContentList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent> ContentList)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCrossTitleContentList, "Engine.OnlineContentInterface.GetCrossTitleContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearCrossTitleContentList;
    /// <summary>
    /// Function: ClearCrossTitleContentList
    /// </summary>
    public unsafe virtual void ClearCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearCrossTitleContentList, "Engine.OnlineContentInterface.ClearCrossTitleContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadCrossTitleContentList;
    /// <summary>
    /// Function: ReadCrossTitleContentList
    /// </summary>
    public unsafe virtual bool ReadCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int TitleId = default, int DeviceID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadCrossTitleContentList, "Engine.OnlineContentInterface.ReadCrossTitleContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUserLanguage;
    /// <summary>
    /// Function: GetUserLanguage
    /// </summary>
    public unsafe virtual BmSDK.FString GetUserLanguage()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUserLanguage, "Engine.OnlineContentInterface.GetUserLanguage", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetUserCountryCode;
    /// <summary>
    /// Function: GetUserCountryCode
    /// </summary>
    public unsafe virtual BmSDK.FString GetUserCountryCode()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetUserCountryCode, "Engine.OnlineContentInterface.GetUserCountryCode", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowPS4DownloadList;
    /// <summary>
    /// Function: ShowPS4DownloadList
    /// </summary>
    public unsafe virtual void ShowPS4DownloadList(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowPS4DownloadList, "Engine.OnlineContentInterface.ShowPS4DownloadList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowPS4StoreIcon;
    /// <summary>
    /// Function: ShowPS4StoreIcon
    /// </summary>
    public unsafe virtual void ShowPS4StoreIcon(bool bShow, int Position = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowPS4StoreIcon, "Engine.OnlineContentInterface.ShowPS4StoreIcon", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BrowseInGameStoreItem;
    /// <summary>
    /// Function: BrowseInGameStoreItem
    /// </summary>
    public unsafe virtual void BrowseInGameStoreItem(byte LocalUserNum, BmSDK.FStringArg ItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BrowseInGameStoreItem, "Engine.OnlineContentInterface.BrowseInGameStoreItem", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        ItemId.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PurchaseInGameStoreItem;
    /// <summary>
    /// Function: PurchaseInGameStoreItem
    /// </summary>
    public unsafe virtual void PurchaseInGameStoreItem(byte LocalUserNum, BmSDK.FStringArg ItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PurchaseInGameStoreItem, "Engine.OnlineContentInterface.PurchaseInGameStoreItem", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        ItemId.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: ClearPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void ClearPurchaseInGameStoreContentComplete(byte LocalUserNum, BmSDK.FScriptDelegate PurchaseInGameStoreContentComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearPurchaseInGameStoreContentComplete, "Engine.OnlineContentInterface.ClearPurchaseInGameStoreContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: AddPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void AddPurchaseInGameStoreContentComplete(byte LocalUserNum, BmSDK.FScriptDelegate PurchaseInGameStoreContentComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddPurchaseInGameStoreContentComplete, "Engine.OnlineContentInterface.AddPurchaseInGameStoreContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: OnPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnPurchaseInGameStoreContentComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPurchaseInGameStoreContentComplete, "Engine.OnlineContentInterface.OnPurchaseInGameStoreContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetInGameStoreContentList;
    /// <summary>
    /// Function: GetInGameStoreContentList
    /// </summary>
    public unsafe virtual void GetInGameStoreContentList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent> ContentList)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetInGameStoreContentList, "Engine.OnlineContentInterface.GetInGameStoreContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadInGameStoreContentList;
    /// <summary>
    /// Function: ReadInGameStoreContentList
    /// </summary>
    public unsafe virtual bool ReadInGameStoreContentList(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadInGameStoreContentList, "Engine.OnlineContentInterface.ReadInGameStoreContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearInGameStoreContentList;
    /// <summary>
    /// Function: ClearInGameStoreContentList
    /// </summary>
    public unsafe virtual void ClearInGameStoreContentList(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearInGameStoreContentList, "Engine.OnlineContentInterface.ClearInGameStoreContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadInGameStoreContentComplete;
    /// <summary>
    /// Function: ClearReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void ClearReadInGameStoreContentComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadInGameStoreContentComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadInGameStoreContentComplete, "Engine.OnlineContentInterface.ClearReadInGameStoreContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadInGameStoreContentComplete;
    /// <summary>
    /// Function: AddReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void AddReadInGameStoreContentComplete(byte LocalUserNum, BmSDK.FScriptDelegate ReadInGameStoreContentComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadInGameStoreContentComplete, "Engine.OnlineContentInterface.AddReadInGameStoreContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadInGameStoreContentComplete;
    /// <summary>
    /// Function: OnReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnReadInGameStoreContentComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadInGameStoreContentComplete, "Engine.OnlineContentInterface.OnReadInGameStoreContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearContentStatusChangeDelegate;
    /// <summary>
    /// Function: ClearContentStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearContentStatusChangeDelegate(BmSDK.FScriptDelegate ContentStatusChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearContentStatusChangeDelegate, "Engine.OnlineContentInterface.ClearContentStatusChangeDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentStatusChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddContentStatusChangeDelegate;
    /// <summary>
    /// Function: AddContentStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddContentStatusChangeDelegate(BmSDK.FScriptDelegate ContentStatusChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddContentStatusChangeDelegate, "Engine.OnlineContentInterface.AddContentStatusChangeDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentStatusChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnContentStatusChange;
    /// <summary>
    /// Function: OnContentStatusChange
    /// </summary>
    public unsafe virtual void OnContentStatusChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnContentStatusChange, "Engine.OnlineContentInterface.OnContentStatusChange", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetContentList;
    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> ContentList)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetContentList, "Engine.OnlineContentInterface.GetContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearContentList;
    /// <summary>
    /// Function: ClearContentList
    /// </summary>
    public unsafe virtual void ClearContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearContentList, "Engine.OnlineContentInterface.ClearContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadContentList;
    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe virtual bool ReadContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int DeviceID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadContentList, "Engine.OnlineContentInterface.ReadContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasContentUpdated;
    /// <summary>
    /// Function: HasContentUpdated
    /// </summary>
    public unsafe virtual bool HasContentUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasContentUpdated, "Engine.OnlineContentInterface.HasContentUpdated", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadContentComplete;
    /// <summary>
    /// Function: ClearReadContentComplete
    /// </summary>
    public unsafe virtual void ClearReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, BmSDK.FScriptDelegate ReadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadContentComplete, "Engine.OnlineContentInterface.ClearReadContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadContentComplete;
    /// <summary>
    /// Function: AddReadContentComplete
    /// </summary>
    public unsafe virtual void AddReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, BmSDK.FScriptDelegate ReadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadContentComplete, "Engine.OnlineContentInterface.AddReadContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadContentComplete;
    /// <summary>
    /// Function: OnReadContentComplete
    /// </summary>
    public unsafe virtual void OnReadContentComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadContentComplete, "Engine.OnlineContentInterface.OnReadContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearContentChangeDelegate;
    /// <summary>
    /// Function: ClearContentChangeDelegate
    /// </summary>
    public unsafe virtual void ClearContentChangeDelegate(BmSDK.FScriptDelegate ContentDelegate, byte LocalUserNum = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearContentChangeDelegate, "Engine.OnlineContentInterface.ClearContentChangeDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddContentChangeDelegate;
    /// <summary>
    /// Function: AddContentChangeDelegate
    /// </summary>
    public unsafe virtual void AddContentChangeDelegate(BmSDK.FScriptDelegate ContentDelegate, byte LocalUserNum = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddContentChangeDelegate, "Engine.OnlineContentInterface.AddContentChangeDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnContentChange;
    /// <summary>
    /// Function: OnContentChange
    /// </summary>
    public unsafe virtual void OnContentChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnContentChange, "Engine.OnlineContentInterface.OnContentChange", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
