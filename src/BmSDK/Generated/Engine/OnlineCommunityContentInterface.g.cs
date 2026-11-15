#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineCommunityContentInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineCommunityContentInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_RateContent;
    /// <summary>
    /// Function: RateContent
    /// </summary>
    public unsafe virtual void RateContent(byte PlayerNum, out BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileToRate, int NewRating)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RateContent, "Engine.OnlineCommunityContentInterface.RateContent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRating, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FileToRate = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearGetContentPayloadCompleteDelegate;
    /// <summary>
    /// Function: ClearGetContentPayloadCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearGetContentPayloadCompleteDelegate(System.IntPtr GetContentPayloadCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearGetContentPayloadCompleteDelegate, "Engine.OnlineCommunityContentInterface.ClearGetContentPayloadCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetContentPayloadCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddGetContentPayloadCompleteDelegate;
    /// <summary>
    /// Function: AddGetContentPayloadCompleteDelegate
    /// </summary>
    public unsafe virtual void AddGetContentPayloadCompleteDelegate(System.IntPtr GetContentPayloadCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddGetContentPayloadCompleteDelegate, "Engine.OnlineCommunityContentInterface.AddGetContentPayloadCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetContentPayloadCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnGetContentPayloadComplete;
    /// <summary>
    /// Function: OnGetContentPayloadComplete
    /// </summary>
    public unsafe virtual void OnGetContentPayloadComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded, out BmSDK.TArray<byte> Payload)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnGetContentPayloadComplete, "Engine.OnlineCommunityContentInterface.OnGetContentPayloadComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileDownloaded, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Payload = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 60);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetContentPayload;
    /// <summary>
    /// Function: GetContentPayload
    /// </summary>
    public unsafe virtual bool GetContentPayload(byte PlayerNum, out BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetContentPayload, "Engine.OnlineCommunityContentInterface.GetContentPayload", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FileDownloaded = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDownloadContentCompleteDelegate;
    /// <summary>
    /// Function: ClearDownloadContentCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDownloadContentCompleteDelegate(System.IntPtr DownloadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDownloadContentCompleteDelegate, "Engine.OnlineCommunityContentInterface.ClearDownloadContentCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DownloadContentCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDownloadContentCompleteDelegate;
    /// <summary>
    /// Function: AddDownloadContentCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDownloadContentCompleteDelegate(System.IntPtr DownloadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDownloadContentCompleteDelegate, "Engine.OnlineCommunityContentInterface.AddDownloadContentCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DownloadContentCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnDownloadContentComplete;
    /// <summary>
    /// Function: OnDownloadContentComplete
    /// </summary>
    public unsafe virtual void OnDownloadContentComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnDownloadContentComplete, "Engine.OnlineCommunityContentInterface.OnDownloadContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileDownloaded, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DownloadContent;
    /// <summary>
    /// Function: DownloadContent
    /// </summary>
    public unsafe virtual bool DownloadContent(byte PlayerNum, out BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileToDownload)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DownloadContent, "Engine.OnlineCommunityContentInterface.DownloadContent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FileToDownload = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearUploadContentCompleteDelegate;
    /// <summary>
    /// Function: ClearUploadContentCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearUploadContentCompleteDelegate(System.IntPtr UploadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearUploadContentCompleteDelegate, "Engine.OnlineCommunityContentInterface.ClearUploadContentCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UploadContentCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddUploadContentCompleteDelegate;
    /// <summary>
    /// Function: AddUploadContentCompleteDelegate
    /// </summary>
    public unsafe virtual void AddUploadContentCompleteDelegate(System.IntPtr UploadContentCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddUploadContentCompleteDelegate, "Engine.OnlineCommunityContentInterface.AddUploadContentCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UploadContentCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnUploadContentComplete;
    /// <summary>
    /// Function: OnUploadContentComplete
    /// </summary>
    public unsafe virtual void OnUploadContentComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile UploadedFile)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnUploadContentComplete, "Engine.OnlineCommunityContentInterface.OnUploadContentComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UploadedFile, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UploadContent;
    /// <summary>
    /// Function: UploadContent
    /// </summary>
    public unsafe virtual bool UploadContent(byte PlayerNum, out BmSDK.TArray<byte> Payload, out BmSDK.Engine.OnlineSubsystem.FCommunityContentMetadata MetaData)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UploadContent, "Engine.OnlineCommunityContentInterface.UploadContent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Payload = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 4);
        MetaData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FCommunityContentMetadata>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetFriendsContentList;
    /// <summary>
    /// Function: GetFriendsContentList
    /// </summary>
    public unsafe virtual bool GetFriendsContentList(byte PlayerNum, out BmSDK.Engine.OnlineSubsystem.FOnlineFriend Friend, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile> ContentFiles)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetFriendsContentList, "Engine.OnlineCommunityContentInterface.GetFriendsContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Friend = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FOnlineFriend>(paramsPtr + 4);
        ContentFiles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 76);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadFriendsContentListCompleteDelegate;
    /// <summary>
    /// Function: ClearReadFriendsContentListCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadFriendsContentListCompleteDelegate(System.IntPtr ReadFriendsContentListCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadFriendsContentListCompleteDelegate, "Engine.OnlineCommunityContentInterface.ClearReadFriendsContentListCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsContentListCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadFriendsContentListCompleteDelegate;
    /// <summary>
    /// Function: AddReadFriendsContentListCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadFriendsContentListCompleteDelegate(System.IntPtr ReadFriendsContentListCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadFriendsContentListCompleteDelegate, "Engine.OnlineCommunityContentInterface.AddReadFriendsContentListCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsContentListCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadFriendsContentListComplete;
    /// <summary>
    /// Function: OnReadFriendsContentListComplete
    /// </summary>
    public unsafe virtual void OnReadFriendsContentListComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadFriendsContentListComplete, "Engine.OnlineCommunityContentInterface.OnReadFriendsContentListComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadFriendsContentList;
    /// <summary>
    /// Function: ReadFriendsContentList
    /// </summary>
    public unsafe virtual bool ReadFriendsContentList(byte PlayerNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> Friends, int StartAt = default, int NumToRead = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadFriendsContentList, "Engine.OnlineCommunityContentInterface.ReadFriendsContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToRead, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Friends = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetContentList;
    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe virtual bool GetContentList(byte PlayerNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile> ContentFiles)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetContentList, "Engine.OnlineCommunityContentInterface.GetContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentFiles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadContentListCompleteDelegate;
    /// <summary>
    /// Function: ClearReadContentListCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadContentListCompleteDelegate(System.IntPtr ReadContentListCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadContentListCompleteDelegate, "Engine.OnlineCommunityContentInterface.ClearReadContentListCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentListCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadContentListCompleteDelegate;
    /// <summary>
    /// Function: AddReadContentListCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadContentListCompleteDelegate(System.IntPtr ReadContentListCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadContentListCompleteDelegate, "Engine.OnlineCommunityContentInterface.AddReadContentListCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentListCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadContentListComplete;
    /// <summary>
    /// Function: OnReadContentListComplete
    /// </summary>
    public unsafe virtual void OnReadContentListComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadContentListComplete, "Engine.OnlineCommunityContentInterface.OnReadContentListComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadContentList;
    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe virtual bool ReadContentList(byte PlayerNum, int StartAt = default, int NumToRead = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadContentList, "Engine.OnlineCommunityContentInterface.ReadContentList", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToRead, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Exit;
    /// <summary>
    /// Function: Exit
    /// </summary>
    public unsafe virtual void Exit()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Exit, "Engine.OnlineCommunityContentInterface.Exit", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual bool Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Init, "Engine.OnlineCommunityContentInterface.Init", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }
}
