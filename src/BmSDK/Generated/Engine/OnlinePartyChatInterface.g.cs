#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlinePartyChatInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlinePartyChatInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsInPartyChat;
    /// <summary>
    /// Function: IsInPartyChat
    /// </summary>
    public unsafe virtual bool IsInPartyChat(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsInPartyChat, "Engine.OnlinePartyChatInterface.IsInPartyChat", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowCommunitySessionsUI;
    /// <summary>
    /// Function: ShowCommunitySessionsUI
    /// </summary>
    public unsafe virtual bool ShowCommunitySessionsUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowCommunitySessionsUI, "Engine.OnlinePartyChatInterface.ShowCommunitySessionsUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowVoiceChannelUI;
    /// <summary>
    /// Function: ShowVoiceChannelUI
    /// </summary>
    public unsafe virtual bool ShowVoiceChannelUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowVoiceChannelUI, "Engine.OnlinePartyChatInterface.ShowVoiceChannelUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowPartyUI;
    /// <summary>
    /// Function: ShowPartyUI
    /// </summary>
    public unsafe virtual bool ShowPartyUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowPartyUI, "Engine.OnlinePartyChatInterface.ShowPartyUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPartyBandwidth;
    /// <summary>
    /// Function: GetPartyBandwidth
    /// </summary>
    public unsafe virtual int GetPartyBandwidth()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPartyBandwidth, "Engine.OnlinePartyChatInterface.GetPartyBandwidth", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetPartyMemberCustomData;
    /// <summary>
    /// Function: SetPartyMemberCustomData
    /// </summary>
    public unsafe virtual bool SetPartyMemberCustomData(byte LocalUserNum, int Data1, int Data2, int Data3, int Data4)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetPartyMemberCustomData, "Engine.OnlinePartyChatInterface.SetPartyMemberCustomData", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data3, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data4, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearPartyMembersInfoChangedDelegate;
    /// <summary>
    /// Function: ClearPartyMembersInfoChangedDelegate
    /// </summary>
    public unsafe virtual void ClearPartyMembersInfoChangedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate PartyMembersInfoChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearPartyMembersInfoChangedDelegate, "Engine.OnlinePartyChatInterface.ClearPartyMembersInfoChangedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyMembersInfoChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddPartyMembersInfoChangedDelegate;
    /// <summary>
    /// Function: AddPartyMembersInfoChangedDelegate
    /// </summary>
    public unsafe virtual void AddPartyMembersInfoChangedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate PartyMembersInfoChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddPartyMembersInfoChangedDelegate, "Engine.OnlinePartyChatInterface.AddPartyMembersInfoChangedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyMembersInfoChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPartyMembersInfoChanged;
    /// <summary>
    /// Function: OnPartyMembersInfoChanged
    /// </summary>
    public unsafe virtual void OnPartyMembersInfoChanged(BmSDK.FStringArg PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, int CustomData1, int CustomData2, int CustomData3, int CustomData4)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPartyMembersInfoChanged, "Engine.OnlinePartyChatInterface.OnPartyMembersInfoChanged", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        PlayerName.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomData1, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomData2, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomData3, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomData4, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearPartyMemberListChangedDelegate;
    /// <summary>
    /// Function: ClearPartyMemberListChangedDelegate
    /// </summary>
    public unsafe virtual void ClearPartyMemberListChangedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate PartyMemberListChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearPartyMemberListChangedDelegate, "Engine.OnlinePartyChatInterface.ClearPartyMemberListChangedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyMemberListChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddPartyMemberListChangedDelegate;
    /// <summary>
    /// Function: AddPartyMemberListChangedDelegate
    /// </summary>
    public unsafe virtual void AddPartyMemberListChangedDelegate(byte LocalUserNum, BmSDK.FScriptDelegate PartyMemberListChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddPartyMemberListChangedDelegate, "Engine.OnlinePartyChatInterface.AddPartyMemberListChangedDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyMemberListChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnPartyMemberListChanged;
    /// <summary>
    /// Function: OnPartyMemberListChanged
    /// </summary>
    public unsafe virtual void OnPartyMemberListChanged(bool bJoinedOrLeft, BmSDK.FStringArg PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnPartyMemberListChanged, "Engine.OnlinePartyChatInterface.OnPartyMemberListChanged", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bJoinedOrLeft, paramsPtr + 0);
        PlayerName.WriteTo(paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 4);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPartyMemberInformation;
    /// <summary>
    /// Function: GetPartyMemberInformation
    /// </summary>
    public unsafe virtual bool GetPartyMemberInformation(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberId, out BmSDK.Engine.OnlineSubsystem.FOnlinePartyMember PartyMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPartyMemberInformation, "Engine.OnlinePartyChatInterface.GetPartyMemberInformation", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PartyMember = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FOnlinePartyMember>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPartyMembersInformation;
    /// <summary>
    /// Function: GetPartyMembersInformation
    /// </summary>
    public unsafe virtual bool GetPartyMembersInformation(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePartyMember> PartyMembers)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPartyMembersInformation, "Engine.OnlinePartyChatInterface.GetPartyMembersInformation", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PartyMembers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePartyMember>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearSendPartyGameInvitesCompleteDelegate;
    /// <summary>
    /// Function: ClearSendPartyGameInvitesCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearSendPartyGameInvitesCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate SendPartyGameInvitesCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearSendPartyGameInvitesCompleteDelegate, "Engine.OnlinePartyChatInterface.ClearSendPartyGameInvitesCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SendPartyGameInvitesCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddSendPartyGameInvitesCompleteDelegate;
    /// <summary>
    /// Function: AddSendPartyGameInvitesCompleteDelegate
    /// </summary>
    public unsafe virtual void AddSendPartyGameInvitesCompleteDelegate(byte LocalUserNum, BmSDK.FScriptDelegate SendPartyGameInvitesCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddSendPartyGameInvitesCompleteDelegate, "Engine.OnlinePartyChatInterface.AddSendPartyGameInvitesCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SendPartyGameInvitesCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnSendPartyGameInvitesComplete;
    /// <summary>
    /// Function: OnSendPartyGameInvitesComplete
    /// </summary>
    public unsafe virtual void OnSendPartyGameInvitesComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnSendPartyGameInvitesComplete, "Engine.OnlinePartyChatInterface.OnSendPartyGameInvitesComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SendPartyGameInvites;
    /// <summary>
    /// Function: SendPartyGameInvites
    /// </summary>
    public unsafe virtual bool SendPartyGameInvites(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SendPartyGameInvites, "Engine.OnlinePartyChatInterface.SendPartyGameInvites", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }
}
