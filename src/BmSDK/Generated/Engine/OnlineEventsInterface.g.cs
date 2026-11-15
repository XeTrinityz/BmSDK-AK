#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineEventsInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineEventsInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_UpdatePlaylistPopulation;
    /// <summary>
    /// Function: UpdatePlaylistPopulation
    /// </summary>
    public unsafe virtual bool UpdatePlaylistPopulation(int PlaylistId, int NumPlayers)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UpdatePlaylistPopulation, "Engine.OnlineEventsInterface.UpdatePlaylistPopulation", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaylistId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPlayers, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UploadGameplayEventsData;
    /// <summary>
    /// Function: UploadGameplayEventsData
    /// </summary>
    public unsafe virtual bool UploadGameplayEventsData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.TArray<byte> Payload)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UploadGameplayEventsData, "Engine.OnlineEventsInterface.UploadGameplayEventsData", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Payload = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_UploadPlayerData;
    /// <summary>
    /// Function: UploadPlayerData
    /// </summary>
    public unsafe virtual bool UploadPlayerData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, BmSDK.FStringArg PlayerNick, BmSDK.Engine.OnlineProfileSettings ProfileSettings, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_UploadPlayerData, "Engine.OnlineEventsInterface.UploadPlayerData", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        PlayerNick.WriteTo(paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }
}
