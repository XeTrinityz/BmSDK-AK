#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_Speaker<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface Interface_Speaker : BmSDK.Interface
{
    private static BmSDK.Framework.FunctionCache.CallSite __fn_Speak;
    /// <summary>
    /// Function: Speak
    /// </summary>
    public unsafe virtual void Speak(BmSDK.Engine.SoundCue Cue)
    {
        BmSDK.Framework.Guard.NotDestroyed(((BmSDK.GameObject)this));
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_Speak, "Engine.Interface_Speaker.Speak", ((BmSDK.GameObject)this));
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.CallProcessEvent(((BmSDK.GameObject)this).Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
