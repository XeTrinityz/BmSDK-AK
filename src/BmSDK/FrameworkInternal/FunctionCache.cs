namespace BmSDK.Framework;

/// <summary>
/// Caches the UFunction looked up by each generated function wrapper.
/// </summary>
/// <remarks>
/// Every generated call used to run <c>StaticFindObject</c> on its function's path string.
/// Each wrapper now keeps the result in its own static field. A wrapper is invalidated
/// (<see cref="GameObject.Ptr"/> set to zero) when its object is destroyed, so a stale
/// entry is looked up again rather than used.
/// <para/>
/// A call on an instance is dispatched on the object's real class (see <see cref="GetVirtual"/>), the way
/// UnrealScript does it, so a subclass without a managed binding still runs its own override.
/// </remarks>
internal static class FunctionCache
{
    /// <summary>One generated function's lookups: the function it was declared as, and what it resolved to.</summary>
    internal sealed class CallSite(Function declared)
    {
        public readonly Function Declared = declared;
        public IntPtr LastClass;
        public Function? LastResolved;
        public Dictionary<IntPtr, Function>? ByClass;
        public int Generation;
    }

    // Bumped when a class is destroyed: its address can be reused by another class, which may
    // override a function differently, so every call site forgets what it resolved.
    private static int s_generation;

    public static void ClassDestroyed() => s_generation++;

    public static Function Get(ref Function? slot, string path)
    {
        var func = slot;
        if (func is not null && func.Ptr != IntPtr.Zero)
        {
            return func;
        }

        return slot = GameObject.StaticFindObjectChecked<Function>(
            Function.StaticClass(),
            null,
            path,
            true
        );
    }

    /// <summary>
    /// The function an instance call really runs: the one the object's own class (or the closest
    /// superclass) declares under the same name, which is the declared function itself unless a
    /// subclass overrides it. Resolved once per class and call site.
    /// </summary>
    public static unsafe Function GetVirtual(ref CallSite? slot, string path, GameObject self)
    {
        var site = slot;
        if (site is null || site.Declared.Ptr == IntPtr.Zero)
        {
            site = slot = new CallSite(GameObject.StaticFindObjectChecked<Function>(Function.StaticClass(), null, path, true));
        }

        var cls = *(IntPtr*)(self.Ptr + GameDefine.MemberOffsets.Object__Class).ToPointer();
        if (site.Generation != s_generation)
        {
            site.Generation = s_generation;
            site.LastClass = IntPtr.Zero;
            site.LastResolved = null;
            site.ByClass?.Clear();
        }

        if (cls == site.LastClass && site.LastResolved is { Ptr: not 0 } last)
        {
            return last;
        }

        if (site.ByClass is not null && site.ByClass.TryGetValue(cls, out var known) && known.Ptr != IntPtr.Zero)
        {
            site.LastClass = cls;
            site.LastResolved = known;
            return known;
        }

        var resolved = Resolve(site.Declared, self);
        (site.ByClass ??= [])[cls] = resolved;
        site.LastClass = cls;
        site.LastResolved = resolved;
        return resolved;
    }

    // The class chain only (Global = 1): the object's current state can't be part of a cached answer.
    private static unsafe Function Resolve(Function declared, GameObject self)
    {
        var name = *(FName*)(declared.Ptr + GameDefine.MemberOffsets.Object__Name).ToPointer();
        var found = GameFunctions.FindFunction(self.Ptr, name, 1);
        if (found == IntPtr.Zero || found == declared.Ptr)
        {
            return declared;
        }

        return MarshalUtil.GetOrCreateWrapper(found) as Function ?? declared;
    }
}
