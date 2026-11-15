#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineSuppliedUIInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineSuppliedUIInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowMatchmakingUI;
    /// <summary>
    /// Function: ShowMatchmakingUI
    /// </summary>
    public unsafe virtual bool ShowMatchmakingUI(byte SearchingPlayerNum, BmSDK.Engine.OnlineGameSearch SearchSettings, BmSDK.Engine.OnlineGameSettings GameSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowMatchmakingUI, "Engine.OnlineSuppliedUIInterface.ShowMatchmakingUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchSettings, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameSettings, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ClearShowOnlineStatsUICompleteDelegate;
    /// <summary>
    /// Function: ClearShowOnlineStatsUICompleteDelegate
    /// </summary>
    public unsafe virtual void ClearShowOnlineStatsUICompleteDelegate(System.IntPtr ShowOnlineStatsUICompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ClearShowOnlineStatsUICompleteDelegate, "Engine.OnlineSuppliedUIInterface.ClearShowOnlineStatsUICompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowOnlineStatsUICompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_AddShowOnlineStatsUICompleteDelegate;
    /// <summary>
    /// Function: AddShowOnlineStatsUICompleteDelegate
    /// </summary>
    public unsafe virtual void AddShowOnlineStatsUICompleteDelegate(System.IntPtr ShowOnlineStatsUICompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AddShowOnlineStatsUICompleteDelegate, "Engine.OnlineSuppliedUIInterface.AddShowOnlineStatsUICompleteDelegate", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowOnlineStatsUICompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShowOnlineStatsUI;
    /// <summary>
    /// Function: ShowOnlineStatsUI
    /// </summary>
    public unsafe virtual bool ShowOnlineStatsUI(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShowOnlineStatsUI, "Engine.OnlineSuppliedUIInterface.ShowOnlineStatsUI", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_OnShowOnlineStatsUIComplete;
    /// <summary>
    /// Function: OnShowOnlineStatsUIComplete
    /// </summary>
    public unsafe virtual void OnShowOnlineStatsUIComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_OnShowOnlineStatsUIComplete, "Engine.OnlineSuppliedUIInterface.OnShowOnlineStatsUIComplete", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
