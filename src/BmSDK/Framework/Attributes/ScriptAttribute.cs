using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

[AttributeUsage(AttributeTargets.Class)]
public sealed class ScriptAttribute([CallerFilePath] string? name = null) : Attribute
{
    public string? Name { get; } = IsSourcePath(name) ? Path.GetFileName(name) : name;

    // The compiler passes the path of the source file. In a prebuilt mod that is a path on the author's
    // PC, so on a player's PC the file isn't there to tell it from a name given by hand.
    private static bool IsSourcePath(string? name) =>
        name is not null
        && (
            File.Exists(name)
            || (name.EndsWith(".cs", StringComparison.OrdinalIgnoreCase) && name.AsSpan().IndexOfAny('/', '\\') >= 0)
        );
}
