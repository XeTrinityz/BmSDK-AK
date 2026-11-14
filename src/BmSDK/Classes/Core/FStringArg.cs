using BmSDK.Framework;

namespace BmSDK;

/// <summary>
/// A string passed by value to a game function. Generated calls take this instead of <see cref="FString"/>:
/// it holds no native memory itself, the call builds a fresh game string into the parameter slot and frees
/// whatever buffer the slot holds once the function has returned. Converts implicitly from <see cref="string"/>
/// (nothing is allocated until the call) and from an <see cref="FString"/> (which is copied, never freed).
/// </summary>
/// <remarks>
/// The engine gives a function its own copy of every by-value parameter and copies the final value back into
/// the caller's slot afterwards, so the slot's buffer is the caller's to free even when the function assigned
/// to the parameter and replaced it. Sharing a caller-owned buffer instead let such a function free it under us.
/// </remarks>
public readonly unsafe struct FStringArg
{
    private readonly string? _text;
    private readonly FString _native;

    private FStringArg(string? text, FString native)
    {
        _text = text;
        _native = native;
    }

    public static implicit operator FStringArg(string? text) => new(text, default);

    public static implicit operator FStringArg(FString native) => new(null, native);

    /// <summary>Builds the game string in a parameter slot.</summary>
    public void WriteTo(void* slot)
    {
        if (_text is not null)
        {
            fixed (char* chars = _text)
            {
                GameFunctions.StringCtor((IntPtr)slot, (IntPtr)chars);
            }

            return;
        }

        _native.CopyTo(slot);
    }

    /// <summary>Frees the buffer a parameter slot holds after the call.</summary>
    public static void FreeSlot(void* slot)
    {
        var buffer = *(IntPtr*)slot;
        if (buffer != IntPtr.Zero)
        {
            GameFunctions.AppFree(buffer);
            *(IntPtr*)slot = IntPtr.Zero;
        }
    }

    public override string? ToString() => _text ?? _native.ToString();
}
