using BmSDK.Framework;

namespace BmSDK;

/// <summary>
/// A script delegate: the object to call and the name of the function to call on it. This is the
/// value of every delegate property and parameter.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public record struct FScriptDelegate
{
    /// <summary>The object the function is called on. Zero for an unbound delegate.</summary>
    public IntPtr ObjectPtr;

    /// <summary>The name of the function to call.</summary>
    public FName FunctionName;

    /// <summary>
    /// Binds a delegate to a script function of <paramref name="target"/>.
    /// </summary>
    public FScriptDelegate(GameObject? target, FName functionName)
    {
        ObjectPtr = target?.Ptr ?? IntPtr.Zero;
        FunctionName = functionName;
    }

    /// <inheritdoc cref="FScriptDelegate(GameObject?, FName)"/>
    public FScriptDelegate(GameObject? target, string functionName)
        : this(target, new FName(functionName)) { }

    /// <summary>The object the function is called on, or null when unbound.</summary>
    public readonly GameObject? Object => ObjectPtr == IntPtr.Zero ? null : MarshalUtil.GetOrCreateWrapper(ObjectPtr);

    /// <summary>True when the delegate names a function to call.</summary>
    public readonly bool IsBound => ObjectPtr != IntPtr.Zero && FunctionName.Index != FName.None.Index;

    public override readonly string ToString() =>
        IsBound ? $"{Object?.GetPathName()}.{FunctionName}" : "(unbound)";
}
