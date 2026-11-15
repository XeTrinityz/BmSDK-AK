#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlinePlayerInterfaceEx<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlinePlayerInterfaceEx : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsExternalRemoteDevice;
    /// <summary>
    /// Function: IsExternalRemoteDevice
    /// </summary>
    public unsafe virtual bool IsExternalRemoteDevice()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsExternalRemoteDevice, "Engine.OnlinePlayerInterfaceEx.IsExternalRemoteDevice", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OpenWebBrowser;
    /// <summary>
    /// Function: OpenWebBrowser
    /// </summary>
    public unsafe virtual void OpenWebBrowser(BmSDK.FStringArg sURL)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OpenWebBrowser, "Engine.OnlinePlayerInterfaceEx.OpenWebBrowser", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        sURL.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetNpAvailabilityForUser;
    /// <summary>
    /// Function: GetNpAvailabilityForUser
    /// </summary>
    public unsafe virtual int GetNpAvailabilityForUser(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetNpAvailabilityForUser, "Engine.OnlinePlayerInterfaceEx.GetNpAvailabilityForUser", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CheckNpAvailabilityForUser;
    /// <summary>
    /// Function: CheckNpAvailabilityForUser
    /// </summary>
    public unsafe virtual void CheckNpAvailabilityForUser(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CheckNpAvailabilityForUser, "Engine.OnlinePlayerInterfaceEx.CheckNpAvailabilityForUser", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StreamingInstall_Poll;
    /// <summary>
    /// Function: StreamingInstall_Poll
    /// </summary>
    public unsafe virtual int StreamingInstall_Poll(out int Percent, out int Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StreamingInstall_Poll, "Engine.OnlinePlayerInterfaceEx.StreamingInstall_Poll", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Percent);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percent, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Percent = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StreamingInstall_CheckChunk;
    /// <summary>
    /// Function: StreamingInstall_CheckChunk
    /// </summary>
    public unsafe virtual bool StreamingInstall_CheckChunk(int Chunk)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StreamingInstall_CheckChunk, "Engine.OnlinePlayerInterfaceEx.StreamingInstall_CheckChunk", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Chunk, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StreamingInstall_IsFinished;
    /// <summary>
    /// Function: StreamingInstall_IsFinished
    /// </summary>
    public unsafe virtual bool StreamingInstall_IsFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StreamingInstall_IsFinished, "Engine.OnlinePlayerInterfaceEx.StreamingInstall_IsFinished", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetDurangoKinectState;
    /// <summary>
    /// Function: SetDurangoKinectState
    /// </summary>
    public unsafe virtual void SetDurangoKinectState(bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetDurangoKinectState, "Engine.OnlinePlayerInterfaceEx.SetDurangoKinectState", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGTCStates;
    /// <summary>
    /// Function: SetGTCStates
    /// </summary>
    public unsafe virtual void SetGTCStates(bool bPlayEnabled, bool bPauseEnabled, bool bMenuEnabled, bool bViewEnabled, bool bBackEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGTCStates, "Engine.OnlinePlayerInterfaceEx.SetGTCStates", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPauseEnabled, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMenuEnabled, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bViewEnabled, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBackEnabled, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetGTCState;
    /// <summary>
    /// Function: SetGTCState
    /// </summary>
    public unsafe virtual void SetGTCState(BmSDK.Engine.OnlineSubsystem.EGTCCommand Id, bool bState)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetGTCState, "Engine.OnlinePlayerInterfaceEx.SetGTCState", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearGTCCommandDelegate;
    /// <summary>
    /// Function: ClearGTCCommandDelegate
    /// </summary>
    public unsafe virtual void ClearGTCCommandDelegate(System.IntPtr GTCCommandDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearGTCCommandDelegate, "Engine.OnlinePlayerInterfaceEx.ClearGTCCommandDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GTCCommandDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddGTCCommandDelegate;
    /// <summary>
    /// Function: AddGTCCommandDelegate
    /// </summary>
    public unsafe virtual void AddGTCCommandDelegate(System.IntPtr GTCCommandDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddGTCCommandDelegate, "Engine.OnlinePlayerInterfaceEx.AddGTCCommandDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GTCCommandDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnGTCCommand;
    /// <summary>
    /// Function: OnGTCCommand
    /// </summary>
    public unsafe virtual void OnGTCCommand(BmSDK.Engine.OnlineSubsystem.EGTCCommand NewCommand)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnGTCCommand, "Engine.OnlinePlayerInterfaceEx.OnGTCCommand", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NavigateBack;
    /// <summary>
    /// Function: NavigateBack
    /// </summary>
    public unsafe virtual void NavigateBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NavigateBack, "Engine.OnlinePlayerInterfaceEx.NavigateBack", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OpenHelpManual;
    /// <summary>
    /// Function: OpenHelpManual
    /// </summary>
    public unsafe virtual void OpenHelpManual(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OpenHelpManual, "Engine.OnlinePlayerInterfaceEx.OpenHelpManual", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecordStop;
    /// <summary>
    /// Function: VideoRecordStop
    /// </summary>
    public unsafe virtual bool VideoRecordStop(byte LocalUserNum, byte VideoId, BmSDK.FStringArg TitleStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecordStop, "Engine.OnlinePlayerInterfaceEx.VideoRecordStop", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoId, paramsPtr + 1);
        TitleStr.WriteTo(paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecordStart;
    /// <summary>
    /// Function: VideoRecordStart
    /// </summary>
    public unsafe virtual bool VideoRecordStart(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecordStart, "Engine.OnlinePlayerInterfaceEx.VideoRecordStart", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecord;
    /// <summary>
    /// Function: VideoRecord
    /// </summary>
    public unsafe virtual void VideoRecord(byte LocalUserNum, byte VideoId, BmSDK.FStringArg TitleStr, float TimeStart, float TimeStop)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecord, "Engine.OnlinePlayerInterfaceEx.VideoRecord", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoId, paramsPtr + 1);
        TitleStr.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeStart, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeStop, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecordSetGameSectionId;
    /// <summary>
    /// Function: VideoRecordSetGameSectionId
    /// </summary>
    public unsafe virtual void VideoRecordSetGameSectionId(int SectionId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecordSetGameSectionId, "Engine.OnlinePlayerInterfaceEx.VideoRecordSetGameSectionId", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SectionId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VideoRecordAllowed;
    /// <summary>
    /// Function: VideoRecordAllowed
    /// </summary>
    public unsafe virtual void VideoRecordAllowed(bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VideoRecordAllowed, "Engine.OnlinePlayerInterfaceEx.VideoRecordAllowed", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsVideoRecordAllowed;
    /// <summary>
    /// Function: IsVideoRecordAllowed
    /// </summary>
    public unsafe virtual bool IsVideoRecordAllowed()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsVideoRecordAllowed, "Engine.OnlinePlayerInterfaceEx.IsVideoRecordAllowed", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnBindAllPlayers;
    /// <summary>
    /// Function: UnBindAllPlayers
    /// </summary>
    public unsafe virtual void UnBindAllPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnBindAllPlayers, "Engine.OnlinePlayerInterfaceEx.UnBindAllPlayers", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnBindPlayer;
    /// <summary>
    /// Function: UnBindPlayer
    /// </summary>
    public unsafe virtual void UnBindPlayer(int ControllerId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnBindPlayer, "Engine.OnlinePlayerInterfaceEx.UnBindPlayer", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResumePlayer;
    /// <summary>
    /// Function: ResumePlayer
    /// </summary>
    public unsafe virtual int ResumePlayer(int ControllerId, int ControllerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResumePlayer, "Engine.OnlinePlayerInterfaceEx.ResumePlayer", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReBindPlayer;
    /// <summary>
    /// Function: ReBindPlayer
    /// </summary>
    public unsafe virtual void ReBindPlayer(int ControllerId, int ControllerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReBindPlayer, "Engine.OnlinePlayerInterfaceEx.ReBindPlayer", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_BindPlayer;
    /// <summary>
    /// Function: BindPlayer
    /// </summary>
    public unsafe virtual int BindPlayer(int ControllerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_BindPlayer, "Engine.OnlinePlayerInterfaceEx.BindPlayer", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetBoundCount;
    /// <summary>
    /// Function: GetBoundCount
    /// </summary>
    public unsafe virtual int GetBoundCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetBoundCount, "Engine.OnlinePlayerInterfaceEx.GetBoundCount", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineAvatar;
    /// <summary>
    /// Function: ReadOnlineAvatar
    /// </summary>
    public unsafe virtual void ReadOnlineAvatar(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, int Size, System.IntPtr ReadOnlineAvatarCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineAvatar, "Engine.OnlinePlayerInterfaceEx.ReadOnlineAvatar", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineAvatarCompleteDelegate, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadOnlineAvatarComplete;
    /// <summary>
    /// Function: OnReadOnlineAvatarComplete
    /// </summary>
    public unsafe virtual void OnReadOnlineAvatarComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, BmSDK.Engine.Texture2D Avatar)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadOnlineAvatarComplete, "Engine.OnlinePlayerInterfaceEx.OnReadOnlineAvatarComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Avatar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowCustomMessageUI;
    /// <summary>
    /// Function: ShowCustomMessageUI
    /// </summary>
    public unsafe virtual bool ShowCustomMessageUI(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Recipients, BmSDK.FStringArg MessageTitle, BmSDK.FStringArg NonEditableMessage, BmSDK.FStringArg EditableMessage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowCustomMessageUI, "Engine.OnlinePlayerInterfaceEx.ShowCustomMessageUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        MessageTitle.WriteTo(paramsPtr + 20);
        NonEditableMessage.WriteTo(paramsPtr + 36);
        EditableMessage.WriteTo(paramsPtr + 52);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 52);
        Recipients = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearCrossTitleProfileSettings;
    /// <summary>
    /// Function: ClearCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual void ClearCrossTitleProfileSettings(byte LocalUserNum, int TitleId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearCrossTitleProfileSettings, "Engine.OnlinePlayerInterfaceEx.ClearCrossTitleProfileSettings", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetCrossTitleProfileSettings;
    /// <summary>
    /// Function: GetCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineProfileSettings GetCrossTitleProfileSettings(byte LocalUserNum, int TitleId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetCrossTitleProfileSettings, "Engine.OnlinePlayerInterfaceEx.GetCrossTitleProfileSettings", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineProfileSettings>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadCrossTitleProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadCrossTitleProfileSettingsCompleteDelegate, "Engine.OnlinePlayerInterfaceEx.ClearReadCrossTitleProfileSettingsCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadCrossTitleProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadCrossTitleProfileSettingsCompleteDelegate, "Engine.OnlinePlayerInterfaceEx.AddReadCrossTitleProfileSettingsCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadCrossTitleProfileSettingsComplete;
    /// <summary>
    /// Function: OnReadCrossTitleProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleProfileSettingsComplete(byte LocalUserNum, int TitleId, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadCrossTitleProfileSettingsComplete, "Engine.OnlinePlayerInterfaceEx.OnReadCrossTitleProfileSettingsComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadCrossTitleProfileSettings;
    /// <summary>
    /// Function: ReadCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual bool ReadCrossTitleProfileSettings(byte LocalUserNum, int TitleId, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadCrossTitleProfileSettings, "Engine.OnlinePlayerInterfaceEx.ReadCrossTitleProfileSettings", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnlockAvatarAward;
    /// <summary>
    /// Function: UnlockAvatarAward
    /// </summary>
    public unsafe virtual bool UnlockAvatarAward(byte LocalUserNum, int AvatarItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnlockAvatarAward, "Engine.OnlinePlayerInterfaceEx.UnlockAvatarAward", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarItemId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetTimeSinceGuideLastClosed;
    /// <summary>
    /// Function: GetTimeSinceGuideLastClosed
    /// </summary>
    public unsafe virtual float GetTimeSinceGuideLastClosed()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetTimeSinceGuideLastClosed, "Engine.OnlinePlayerInterfaceEx.GetTimeSinceGuideLastClosed", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_CreateInfocastSystem;
    /// <summary>
    /// Function: CreateInfocastSystem
    /// </summary>
    public unsafe virtual void CreateInfocastSystem()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CreateInfocastSystem, "Engine.OnlinePlayerInterfaceEx.CreateInfocastSystem", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearNewInfocastDelegate;
    /// <summary>
    /// Function: ClearNewInfocastDelegate
    /// </summary>
    public unsafe virtual void ClearNewInfocastDelegate(System.IntPtr InfocastDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearNewInfocastDelegate, "Engine.OnlinePlayerInterfaceEx.ClearNewInfocastDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfocastDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddNewInfocastDelegate;
    /// <summary>
    /// Function: AddNewInfocastDelegate
    /// </summary>
    public unsafe virtual void AddNewInfocastDelegate(System.IntPtr InfocastDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddNewInfocastDelegate, "Engine.OnlinePlayerInterfaceEx.AddNewInfocastDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfocastDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnNewInfocast;
    /// <summary>
    /// Function: OnNewInfocast
    /// </summary>
    public unsafe virtual void OnNewInfocast(BmSDK.FStringArg Infocast)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnNewInfocast, "Engine.OnlinePlayerInterfaceEx.OnNewInfocast", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        Infocast.WriteTo(paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowCustomPlayersUI;
    /// <summary>
    /// Function: ShowCustomPlayersUI
    /// </summary>
    public unsafe virtual bool ShowCustomPlayersUI(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.FStringArg Title, BmSDK.FStringArg Description)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowCustomPlayersUI, "Engine.OnlinePlayerInterfaceEx.ShowCustomPlayersUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        Title.WriteTo(paramsPtr + 20);
        Description.WriteTo(paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 20);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 36);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowPlayersUI;
    /// <summary>
    /// Function: ShowPlayersUI
    /// </summary>
    public unsafe virtual bool ShowPlayersUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowPlayersUI, "Engine.OnlinePlayerInterfaceEx.ShowPlayersUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowGuideUI;
    /// <summary>
    /// Function: ShowGuideUI
    /// </summary>
    public unsafe virtual bool ShowGuideUI()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowGuideUI, "Engine.OnlinePlayerInterfaceEx.ShowGuideUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowFriendsInviteUI;
    /// <summary>
    /// Function: ShowFriendsInviteUI
    /// </summary>
    public unsafe virtual bool ShowFriendsInviteUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowFriendsInviteUI, "Engine.OnlinePlayerInterfaceEx.ShowFriendsInviteUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearProfileDataChangedDelegate;
    /// <summary>
    /// Function: ClearProfileDataChangedDelegate
    /// </summary>
    public unsafe virtual void ClearProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearProfileDataChangedDelegate, "Engine.OnlinePlayerInterfaceEx.ClearProfileDataChangedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileDataChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddProfileDataChangedDelegate;
    /// <summary>
    /// Function: AddProfileDataChangedDelegate
    /// </summary>
    public unsafe virtual void AddProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddProfileDataChangedDelegate, "Engine.OnlinePlayerInterfaceEx.AddProfileDataChangedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileDataChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnProfileDataChanged;
    /// <summary>
    /// Function: OnProfileDataChanged
    /// </summary>
    public unsafe virtual void OnProfileDataChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnProfileDataChanged, "Engine.OnlinePlayerInterfaceEx.OnProfileDataChanged", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UnlockGamerPicture;
    /// <summary>
    /// Function: UnlockGamerPicture
    /// </summary>
    public unsafe virtual bool UnlockGamerPicture(byte LocalUserNum, int PictureId)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UnlockGamerPicture, "Engine.OnlinePlayerInterfaceEx.UnlockGamerPicture", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PictureId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsDeviceValid;
    /// <summary>
    /// Function: IsDeviceValid
    /// </summary>
    public unsafe virtual bool IsDeviceValid(int DeviceID, int SizeNeeded = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsDeviceValid, "Engine.OnlinePlayerInterfaceEx.IsDeviceValid", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SizeNeeded, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDeviceSelectionResults;
    /// <summary>
    /// Function: GetDeviceSelectionResults
    /// </summary>
    public unsafe virtual int GetDeviceSelectionResults(byte LocalUserNum, out BmSDK.FString DeviceName)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDeviceSelectionResults, "Engine.OnlinePlayerInterfaceEx.GetDeviceSelectionResults", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DeviceName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearDeviceSelectionDoneDelegate;
    /// <summary>
    /// Function: ClearDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe virtual void ClearDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearDeviceSelectionDoneDelegate, "Engine.OnlinePlayerInterfaceEx.ClearDeviceSelectionDoneDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddDeviceSelectionDoneDelegate;
    /// <summary>
    /// Function: AddDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe virtual void AddDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddDeviceSelectionDoneDelegate, "Engine.OnlinePlayerInterfaceEx.AddDeviceSelectionDoneDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnDeviceSelectionComplete;
    /// <summary>
    /// Function: OnDeviceSelectionComplete
    /// </summary>
    public unsafe virtual void OnDeviceSelectionComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnDeviceSelectionComplete, "Engine.OnlinePlayerInterfaceEx.OnDeviceSelectionComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowDeviceSelectionUI;
    /// <summary>
    /// Function: ShowDeviceSelectionUI
    /// </summary>
    public unsafe virtual bool ShowDeviceSelectionUI(byte LocalUserNum, int SizeNeeded, bool bForceShowUI = default, bool bManageStorage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowDeviceSelectionUI, "Engine.OnlinePlayerInterfaceEx.ShowDeviceSelectionUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SizeNeeded, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowUI, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bManageStorage, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowMembershipMarketplaceUI;
    /// <summary>
    /// Function: ShowMembershipMarketplaceUI
    /// </summary>
    public unsafe virtual bool ShowMembershipMarketplaceUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowMembershipMarketplaceUI, "Engine.OnlinePlayerInterfaceEx.ShowMembershipMarketplaceUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowContentMarketplaceUI;
    /// <summary>
    /// Function: ShowContentMarketplaceUI
    /// </summary>
    public unsafe virtual bool ShowContentMarketplaceUI(byte LocalUserNum, int CategoryMask = default, int OfferId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowContentMarketplaceUI, "Engine.OnlinePlayerInterfaceEx.ShowContentMarketplaceUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryMask, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OfferId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowInviteUI;
    /// <summary>
    /// Function: ShowInviteUI
    /// </summary>
    public unsafe virtual bool ShowInviteUI(byte LocalUserNum, BmSDK.FStringArg InviteText = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowInviteUI, "Engine.OnlinePlayerInterfaceEx.ShowInviteUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        InviteText.WriteTo(paramsPtr + 4);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowAchievementsUI;
    /// <summary>
    /// Function: ShowAchievementsUI
    /// </summary>
    public unsafe virtual bool ShowAchievementsUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowAchievementsUI, "Engine.OnlinePlayerInterfaceEx.ShowAchievementsUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowMessagesUI;
    /// <summary>
    /// Function: ShowMessagesUI
    /// </summary>
    public unsafe virtual bool ShowMessagesUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowMessagesUI, "Engine.OnlinePlayerInterfaceEx.ShowMessagesUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowTokenRedemptionUI;
    /// <summary>
    /// Function: ShowTokenRedemptionUI
    /// </summary>
    public unsafe virtual bool ShowTokenRedemptionUI(byte LocalUserNum, BmSDK.FStringArg OfferId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowTokenRedemptionUI, "Engine.OnlinePlayerInterfaceEx.ShowTokenRedemptionUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        OfferId.WriteTo(paramsPtr + 4);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowAccountPickerUI;
    /// <summary>
    /// Function: ShowAccountPickerUI
    /// </summary>
    public unsafe virtual bool ShowAccountPickerUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowAccountPickerUI, "Engine.OnlinePlayerInterfaceEx.ShowAccountPickerUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowGamerCardUI;
    /// <summary>
    /// Function: ShowGamerCardUI
    /// </summary>
    public unsafe virtual bool ShowGamerCardUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, BmSDK.FStringArg NickName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowGamerCardUI, "Engine.OnlinePlayerInterfaceEx.ShowGamerCardUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        NickName.WriteTo(paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowFeedbackUI;
    /// <summary>
    /// Function: ShowFeedbackUI
    /// </summary>
    public unsafe virtual bool ShowFeedbackUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowFeedbackUI, "Engine.OnlinePlayerInterfaceEx.ShowFeedbackUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }
}
