#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RRemoteControlHighSecurityInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RRemoteControlHighSecurityInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_ShouldPlayBombBarks;
    /// <summary>
    /// Function: ShouldPlayBombBarks
    /// </summary>
    public unsafe virtual bool ShouldPlayBombBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_ShouldPlayBombBarks, "BmGame.RRemoteControlHighSecurityInterface.ShouldPlayBombBarks", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_DisallowLongRangeResonator;
    /// <summary>
    /// Function: DisallowLongRangeResonator
    /// </summary>
    public unsafe virtual bool DisallowLongRangeResonator()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_DisallowLongRangeResonator, "BmGame.RRemoteControlHighSecurityInterface.DisallowLongRangeResonator", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDisplayIconName;
    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayIconName()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDisplayIconName, "BmGame.RRemoteControlHighSecurityInterface.GetDisplayIconName", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetInputDialSeed;
    /// <summary>
    /// Function: GetInputDialSeed
    /// </summary>
    public unsafe virtual int GetInputDialSeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetInputDialSeed, "BmGame.RRemoteControlHighSecurityInterface.GetInputDialSeed", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPassword;
    /// <summary>
    /// Function: GetPassword
    /// </summary>
    public unsafe virtual BmSDK.FString GetPassword(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPassword, "BmGame.RRemoteControlHighSecurityInterface.GetPassword", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetPasswordArrayLength;
    /// <summary>
    /// Function: GetPasswordArrayLength
    /// </summary>
    public unsafe virtual int GetPasswordArrayLength()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetPasswordArrayLength, "BmGame.RRemoteControlHighSecurityInterface.GetPasswordArrayLength", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetResonatorMinigameStringReference;
    /// <summary>
    /// Function: GetResonatorMinigameStringReference
    /// </summary>
    public unsafe virtual BmSDK.FString GetResonatorMinigameStringReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetResonatorMinigameStringReference, "BmGame.RRemoteControlHighSecurityInterface.GetResonatorMinigameStringReference", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetResonatorWinScreenStringReference;
    /// <summary>
    /// Function: GetResonatorWinScreenStringReference
    /// </summary>
    public unsafe virtual BmSDK.FString GetResonatorWinScreenStringReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetResonatorWinScreenStringReference, "BmGame.RRemoteControlHighSecurityInterface.GetResonatorWinScreenStringReference", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRawDifficulty;
    /// <summary>
    /// Function: GetRawDifficulty
    /// </summary>
    public unsafe virtual int GetRawDifficulty()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRawDifficulty, "BmGame.RRemoteControlHighSecurityInterface.GetRawDifficulty", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHackingTargetType;
    /// <summary>
    /// Function: GetHackingTargetType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType GetHackingTargetType()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHackingTargetType, "BmGame.RRemoteControlHighSecurityInterface.GetHackingTargetType", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetHackingNetworkType;
    /// <summary>
    /// Function: GetHackingNetworkType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType GetHackingNetworkType()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetHackingNetworkType, "BmGame.RRemoteControlHighSecurityInterface.GetHackingNetworkType", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetActiveFlag;
    /// <summary>
    /// Function: GetActiveFlag
    /// </summary>
    public unsafe virtual BmSDK.FName GetActiveFlag()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetActiveFlag, "BmGame.RRemoteControlHighSecurityInterface.GetActiveFlag", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StopAlarmSound;
    /// <summary>
    /// Function: StopAlarmSound
    /// </summary>
    public unsafe virtual void StopAlarmSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StopAlarmSound, "BmGame.RRemoteControlHighSecurityInterface.StopAlarmSound", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_PlayAlarmSound;
    /// <summary>
    /// Function: PlayAlarmSound
    /// </summary>
    public unsafe virtual void PlayAlarmSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_PlayAlarmSound, "BmGame.RRemoteControlHighSecurityInterface.PlayAlarmSound", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsAlarmed;
    /// <summary>
    /// Function: IsAlarmed
    /// </summary>
    public unsafe virtual bool IsAlarmed()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsAlarmed, "BmGame.RRemoteControlHighSecurityInterface.IsAlarmed", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMaximumInteractionDistance;
    /// <summary>
    /// Function: GetMaximumInteractionDistance
    /// </summary>
    public unsafe virtual float GetMaximumInteractionDistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMaximumInteractionDistance, "BmGame.RRemoteControlHighSecurityInterface.GetMaximumInteractionDistance", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_VeryLowSecurity;
    /// <summary>
    /// Function: VeryLowSecurity
    /// </summary>
    public unsafe virtual bool VeryLowSecurity()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_VeryLowSecurity, "BmGame.RRemoteControlHighSecurityInterface.VeryLowSecurity", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_RequiresHighSecurityResonator;
    /// <summary>
    /// Function: RequiresHighSecurityResonator
    /// </summary>
    public unsafe virtual bool RequiresHighSecurityResonator()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_RequiresHighSecurityResonator, "BmGame.RRemoteControlHighSecurityInterface.RequiresHighSecurityResonator", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetLeftResonantPosition;
    /// <summary>
    /// Function: GetLeftResonantPosition
    /// </summary>
    public unsafe virtual float GetLeftResonantPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetLeftResonantPosition, "BmGame.RRemoteControlHighSecurityInterface.GetLeftResonantPosition", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetRightResonantPosition;
    /// <summary>
    /// Function: GetRightResonantPosition
    /// </summary>
    public unsafe virtual float GetRightResonantPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetRightResonantPosition, "BmGame.RRemoteControlHighSecurityInterface.GetRightResonantPosition", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDifficultyLevel;
    /// <summary>
    /// Function: GetDifficultyLevel
    /// </summary>
    public unsafe virtual int GetDifficultyLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDifficultyLevel, "BmGame.RRemoteControlHighSecurityInterface.GetDifficultyLevel", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_HasMultipleStages;
    /// <summary>
    /// Function: HasMultipleStages
    /// </summary>
    public unsafe virtual bool HasMultipleStages()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_HasMultipleStages, "BmGame.RRemoteControlHighSecurityInterface.HasMultipleStages", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_InResonatorThreshold;
    /// <summary>
    /// Function: InResonatorThreshold
    /// </summary>
    public unsafe virtual void InResonatorThreshold(bool InThreshold)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_InResonatorThreshold, "BmGame.RRemoteControlHighSecurityInterface.InResonatorThreshold", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InThreshold, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StartResonatorMinigame;
    /// <summary>
    /// Function: StartResonatorMinigame
    /// </summary>
    public unsafe virtual void StartResonatorMinigame()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StartResonatorMinigame, "BmGame.RRemoteControlHighSecurityInterface.StartResonatorMinigame", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_FailedToDisrupt;
    /// <summary>
    /// Function: FailedToDisrupt
    /// </summary>
    public unsafe virtual void FailedToDisrupt()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_FailedToDisrupt, "BmGame.RRemoteControlHighSecurityInterface.FailedToDisrupt", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_NextStage;
    /// <summary>
    /// Function: NextStage
    /// </summary>
    public unsafe virtual bool NextStage()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_NextStage, "BmGame.RRemoteControlHighSecurityInterface.NextStage", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_WillExplode;
    /// <summary>
    /// Function: WillExplode
    /// </summary>
    public unsafe virtual bool WillExplode()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_WillExplode, "BmGame.RRemoteControlHighSecurityInterface.WillExplode", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_StillDisruptable;
    /// <summary>
    /// Function: StillDisruptable
    /// </summary>
    public unsafe virtual bool StillDisruptable()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_StillDisruptable, "BmGame.RRemoteControlHighSecurityInterface.StillDisruptable", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetIconLocation;
    /// <summary>
    /// Function: GetIconLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetIconLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetIconLocation, "BmGame.RRemoteControlHighSecurityInterface.GetIconLocation", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SuccessfullyDisrupted;
    /// <summary>
    /// Function: SuccessfullyDisrupted
    /// </summary>
    public unsafe virtual void SuccessfullyDisrupted()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SuccessfullyDisrupted, "BmGame.RRemoteControlHighSecurityInterface.SuccessfullyDisrupted", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetDifficulty;
    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe virtual void GetDifficulty(out float Threshold, out float BuildUpTime, out float LeftMaxAngVelocity, out float RightMaxAngVelocity, int DifficultyMod = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetDifficulty, "BmGame.RRemoteControlHighSecurityInterface.GetDifficulty", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Threshold);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Threshold, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BuildUpTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BuildUpTime, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LeftMaxAngVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftMaxAngVelocity, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RightMaxAngVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightMaxAngVelocity, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DifficultyMod, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Threshold = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        BuildUpTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        LeftMaxAngVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        RightMaxAngVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Enum: DisruptableObjectTargetType
    /// </summary>
    public enum DisruptableObjectTargetType : byte
    {
        DOTT_AccessDoor = 0,
        DOTT_ElevatorControlCall = 1,
        DOTT_ElevatorControlLower = 2,
        DOTT_ElevatorControlRaise = 3,
        DOTT_ElectrifiedFenceDeactivate = 4,
        DOTT_ElectrifiedFenceActivate = 5,
        DOTT_SecurityDoor = 6,
        DOTT_DisplayCabinet = 7,
        DOTT_ControlBox = 8,
        DOTT_TunnelAccess = 9,
        DOTT_TowerMaintenanceHatch = 10,
        DOTT_MaintenanceAccess = 11,
        DOTT_AccessBridge = 12,
        DOTT_DeadshotPda = 13,
        DOTT_RiddlerBarrier = 14,
        DOTT_RiddlerElectricFloor = 15,
        DOTT_MAX = 16,
    }

    /// <summary>
    /// Enum: DisruptableObjectNetworkType
    /// </summary>
    public enum DisruptableObjectNetworkType : byte
    {
        DONT_GothamMunicipalNetwork = 0,
        DONT_RiddlerMatrix = 1,
        DONT_MobileElectronicDevice = 2,
        DONT_MAX = 3,
    }
}
