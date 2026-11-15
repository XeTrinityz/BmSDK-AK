#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RPassThroughAdjustMovementDirectionInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RPassThroughAdjustMovementDirectionInterface : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_AdjustMovementDirection;
    /// <summary>
    /// Function: AdjustMovementDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 AdjustMovementDirection(System.Numerics.Vector3 MovementDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_AdjustMovementDirection, "BmGame.RPassThroughAdjustMovementDirectionInterface.AdjustMovementDirection", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }
}
