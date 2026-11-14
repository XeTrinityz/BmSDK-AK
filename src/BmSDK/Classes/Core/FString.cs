#pragma warning disable CS0169
#pragma warning disable CS0649

using BmSDK.Framework;

namespace BmSDK;

public unsafe struct FString : IDisposable
{
    private IntPtr AllocatorInstance;
    private int Num;
    private int Max;

    /// <summary>
    /// Creates a new FString from the given managed string.
    /// </summary>
    public FString(string str)
    {
        fixed (FString* thisPtr = &this)
        fixed (char* stringDataPtr = str)
        {
            // Call native ctor
            GameFunctions.StringCtor((IntPtr)thisPtr, (IntPtr)stringDataPtr);
        }
    }

    public static implicit operator FString(string? str) => str is null ? default : new FString(str);

    public override readonly string? ToString()
    {
        if (AllocatorInstance == IntPtr.Zero)
        {
            return null;
        }

        return Marshal.PtrToStringUni(AllocatorInstance, Num - 1);
    }

    /// <summary>
    /// Writes a copy of this string, in its own newly allocated game memory, to the given slot.
    /// </summary>
    internal readonly void CopyTo(void* slot)
    {
        var target = (FString*)slot;
        if (AllocatorInstance == IntPtr.Zero || Num <= 0)
        {
            *target = default;
            return;
        }

        var bytes = Num * sizeof(char);
        var buffer = GameFunctions.AppRealloc(IntPtr.Zero, bytes, 8);
        Buffer.MemoryCopy(AllocatorInstance.ToPointer(), buffer.ToPointer(), bytes, bytes);
        target->AllocatorInstance = buffer;
        target->Num = Num;
        target->Max = Num;
    }

    public void Dispose()
    {
        if (AllocatorInstance != IntPtr.Zero)
        {
            GameFunctions.AppFree(AllocatorInstance);
            AllocatorInstance = IntPtr.Zero;
        }
    }
}
