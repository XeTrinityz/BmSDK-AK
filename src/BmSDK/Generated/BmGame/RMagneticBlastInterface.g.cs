#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RMagneticBlastInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RMagneticBlastInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMagTargetTangent;
    /// <summary>
    /// Function: GetMagTargetTangent
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMagTargetTangent()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMagTargetTangent, "BmGame.RMagneticBlastInterface.GetMagTargetTangent", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsSecondaryTarget;
    /// <summary>
    /// Function: IsSecondaryTarget
    /// </summary>
    public unsafe virtual bool IsSecondaryTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsSecondaryTarget, "BmGame.RMagneticBlastInterface.IsSecondaryTarget", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_IsMagActive;
    /// <summary>
    /// Function: IsMagActive
    /// </summary>
    public unsafe virtual bool IsMagActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_IsMagActive, "BmGame.RMagneticBlastInterface.IsMagActive", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetActor;
    /// <summary>
    /// Function: GetActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetActor()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetActor, "BmGame.RMagneticBlastInterface.GetActor", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetMagLocation;
    /// <summary>
    /// Function: GetMagLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMagLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetMagLocation, "BmGame.RMagneticBlastInterface.GetMagLocation", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Framework.FunctionCache.CallSite __fn_SetMagnetStrength;
    /// <summary>
    /// Function: SetMagnetStrength
    /// </summary>
    public unsafe virtual float SetMagnetStrength(BmSDK.BmGame.RMagneticBlastReceiver REC, float MagStr, System.Numerics.Vector3 MagPos, float DeltaTime, bool bInitialImpulse = default, BmSDK.BmGame.RMagneticSurfaceSMBase Surface = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_SetMagnetStrength, "BmGame.RMagneticBlastInterface.SetMagnetStrength", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(REC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MagStr, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MagPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialImpulse, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Surface, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
    }
}
