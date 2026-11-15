#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineStatsInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineStatsInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_CalcAggregateSkill;
    /// <summary>
    /// Function: CalcAggregateSkill
    /// </summary>
    public unsafe virtual void CalcAggregateSkill(BmSDK.TArray<double> Mus, BmSDK.TArray<double> Sigmas, out double OutAggregateMu, out double OutAggregateSigma)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_CalcAggregateSkill, "Engine.OnlineStatsInterface.CalcAggregateSkill", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sigmas, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAggregateMu);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAggregateMu, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAggregateSigma);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAggregateSigma, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAggregateMu = BmSDK.Framework.MarshalUtil.ToManagedParam<double>(paramsPtr + 32);
        OutAggregateSigma = BmSDK.Framework.MarshalUtil.ToManagedParam<double>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterStatGuid;
    /// <summary>
    /// Function: RegisterStatGuid
    /// </summary>
    public unsafe virtual bool RegisterStatGuid(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, out BmSDK.FString ClientStatGuid)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterStatGuid, "Engine.OnlineStatsInterface.RegisterStatGuid", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ClientStatGuid = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetClientStatGuid;
    /// <summary>
    /// Function: GetClientStatGuid
    /// </summary>
    public unsafe virtual BmSDK.FString GetClientStatGuid()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetClientStatGuid, "Engine.OnlineStatsInterface.GetClientStatGuid", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearRegisterHostStatGuidCompleteDelegateDelegate;
    /// <summary>
    /// Function: ClearRegisterHostStatGuidCompleteDelegateDelegate
    /// </summary>
    public unsafe virtual void ClearRegisterHostStatGuidCompleteDelegateDelegate(BmSDK.FScriptDelegate RegisterHostStatGuidCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearRegisterHostStatGuidCompleteDelegateDelegate, "Engine.OnlineStatsInterface.ClearRegisterHostStatGuidCompleteDelegateDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterHostStatGuidCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddRegisterHostStatGuidCompleteDelegate;
    /// <summary>
    /// Function: AddRegisterHostStatGuidCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRegisterHostStatGuidCompleteDelegate(BmSDK.FScriptDelegate RegisterHostStatGuidCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddRegisterHostStatGuidCompleteDelegate, "Engine.OnlineStatsInterface.AddRegisterHostStatGuidCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterHostStatGuidCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnRegisterHostStatGuidComplete;
    /// <summary>
    /// Function: OnRegisterHostStatGuidComplete
    /// </summary>
    public unsafe virtual void OnRegisterHostStatGuidComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnRegisterHostStatGuidComplete, "Engine.OnlineStatsInterface.OnRegisterHostStatGuidComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RegisterHostStatGuid;
    /// <summary>
    /// Function: RegisterHostStatGuid
    /// </summary>
    public unsafe virtual bool RegisterHostStatGuid(out BmSDK.FString HostStatGuid)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RegisterHostStatGuid, "Engine.OnlineStatsInterface.RegisterHostStatGuid", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HostStatGuid = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHostStatGuid;
    /// <summary>
    /// Function: GetHostStatGuid
    /// </summary>
    public unsafe virtual BmSDK.FString GetHostStatGuid()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHostStatGuid, "Engine.OnlineStatsInterface.GetHostStatGuid", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteOnlinePlayerScores;
    /// <summary>
    /// Function: WriteOnlinePlayerScores
    /// </summary>
    public unsafe virtual bool WriteOnlinePlayerScores(BmSDK.FName SessionName, int LeaderboardId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore> PlayerScores)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteOnlinePlayerScores, "Engine.OnlineStatsInterface.WriteOnlinePlayerScores", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayerScores = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore>>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearFlushOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: ClearFlushOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearFlushOnlineStatsCompleteDelegate(BmSDK.FScriptDelegate FlushOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearFlushOnlineStatsCompleteDelegate, "Engine.OnlineStatsInterface.ClearFlushOnlineStatsCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlushOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddFlushOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: AddFlushOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddFlushOnlineStatsCompleteDelegate(BmSDK.FScriptDelegate FlushOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddFlushOnlineStatsCompleteDelegate, "Engine.OnlineStatsInterface.AddFlushOnlineStatsCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlushOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnFlushOnlineStatsComplete;
    /// <summary>
    /// Function: OnFlushOnlineStatsComplete
    /// </summary>
    public unsafe virtual void OnFlushOnlineStatsComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnFlushOnlineStatsComplete, "Engine.OnlineStatsInterface.OnFlushOnlineStatsComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FlushOnlineStats;
    /// <summary>
    /// Function: FlushOnlineStats
    /// </summary>
    public unsafe virtual bool FlushOnlineStats(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FlushOnlineStats, "Engine.OnlineStatsInterface.FlushOnlineStats", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WriteOnlineStats;
    /// <summary>
    /// Function: WriteOnlineStats
    /// </summary>
    public unsafe virtual bool WriteOnlineStats(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, BmSDK.Engine.OnlineStatsWrite StatsWrite)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WriteOnlineStats, "Engine.OnlineStatsInterface.WriteOnlineStats", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsWrite, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FreeStats;
    /// <summary>
    /// Function: FreeStats
    /// </summary>
    public unsafe virtual void FreeStats(BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FreeStats, "Engine.OnlineStatsInterface.FreeStats", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearReadOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadOnlineStatsCompleteDelegate(BmSDK.FScriptDelegate ReadOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearReadOnlineStatsCompleteDelegate, "Engine.OnlineStatsInterface.ClearReadOnlineStatsCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddReadOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: AddReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadOnlineStatsCompleteDelegate(BmSDK.FScriptDelegate ReadOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddReadOnlineStatsCompleteDelegate, "Engine.OnlineStatsInterface.AddReadOnlineStatsCompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnReadOnlineStatsComplete;
    /// <summary>
    /// Function: OnReadOnlineStatsComplete
    /// </summary>
    public unsafe virtual void OnReadOnlineStatsComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnReadOnlineStatsComplete, "Engine.OnlineStatsInterface.OnReadOnlineStatsComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineStatsByRankAroundPlayer;
    /// <summary>
    /// Function: ReadOnlineStatsByRankAroundPlayer
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsByRankAroundPlayer(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead, int NumRows = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineStatsByRankAroundPlayer, "Engine.OnlineStatsInterface.ReadOnlineStatsByRankAroundPlayer", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumRows, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineStatsByRank;
    /// <summary>
    /// Function: ReadOnlineStatsByRank
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsByRank(BmSDK.Engine.OnlineStatsRead StatsRead, int StartIndex = default, int NumToRead = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineStatsByRank, "Engine.OnlineStatsInterface.ReadOnlineStatsByRank", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToRead, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineStatsForFriends;
    /// <summary>
    /// Function: ReadOnlineStatsForFriends
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsForFriends(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineStatsForFriends, "Engine.OnlineStatsInterface.ReadOnlineStatsForFriends", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ReadOnlineStats;
    /// <summary>
    /// Function: ReadOnlineStats
    /// </summary>
    public unsafe virtual bool ReadOnlineStats(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ReadOnlineStats, "Engine.OnlineStatsInterface.ReadOnlineStats", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DebugWriteLBForUser;
    /// <summary>
    /// Function: DebugWriteLBForUser
    /// </summary>
    public unsafe virtual void DebugWriteLBForUser(BmSDK.FStringArg User, int BoardID, int RankValue, BmSDK.TArray<int> StatsArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DebugWriteLBForUser, "Engine.OnlineStatsInterface.DebugWriteLBForUser", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        User.WriteTo(paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RankValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsArray, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.FStringArg.FreeSlot(paramsPtr + 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DropOnlineStatsRead;
    /// <summary>
    /// Function: DropOnlineStatsRead
    /// </summary>
    public unsafe virtual void DropOnlineStatsRead()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DropOnlineStatsRead, "Engine.OnlineStatsInterface.DropOnlineStatsRead", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetOnlineStatsForAllUsers;
    /// <summary>
    /// Function: ResetOnlineStatsForAllUsers
    /// </summary>
    public unsafe virtual bool ResetOnlineStatsForAllUsers(int BoardID)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetOnlineStatsForAllUsers, "Engine.OnlineStatsInterface.ResetOnlineStatsForAllUsers", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ResetOnlineStatsForUser;
    /// <summary>
    /// Function: ResetOnlineStatsForUser
    /// </summary>
    public unsafe virtual bool ResetOnlineStatsForUser(byte LocalUserNum, int BoardID)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ResetOnlineStatsForUser, "Engine.OnlineStatsInterface.ResetOnlineStatsForUser", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }
}
