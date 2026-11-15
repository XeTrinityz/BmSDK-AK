using System.Text.Json;

namespace BmSDK.Printer;

// The reflection data of one class as the dumper wrote it, minus the raw memory.
abstract class Node
{
    public required string Name;
    public required string Path;
    public Node? Outer;
}

sealed class ClassNode : Node
{
    public required string Package;
    public string? SuperPath;
    public uint Flags;
    public int Size;
    public int Align;
    public string? Source;
    public List<string> Interfaces = [];
    public List<Node> Fields = [];

    // Property values of the class default object, by property name.
    public Dictionary<string, JsonElement>? Defaults;
}

// Script structs, functions and states.
class StructNode : Node
{
    public required string Kind;
    public string? SuperPath;
    public int Size;
    public int Align;
    public List<Node> Fields = [];

    // A script struct's default member values, by property name.
    public Dictionary<string, JsonElement>? Defaults;
}

sealed class FuncNode : StructNode
{
    public uint Flags;

    // Where the function's code is, as an offset into the game's exe.
    public ulong? CodeRva;
}

sealed class PropNode : Node
{
    public required string Type;
    public int Dim;
    public ulong Flags;
    public int ElementSize;
    public int Offset;
    public uint Mask;
    public Dictionary<int, string> Refs = [];
    public List<PropNode> Sub = [];

    // The object path the subclass points at by offset, without its class name.
    public string? RefPath(int offset) => Refs.TryGetValue(offset, out var r) ? r[(r.IndexOf(' ') + 1)..] : null;

    public string? RefClass(int offset) => Refs.TryGetValue(offset, out var r) ? r[..r.IndexOf(' ')] : null;
}

sealed class EnumNode : Node
{
    public List<string> Names = [];
}

sealed class ConstNode : Node
{
    public string? Value;
}

sealed class OtherNode : Node
{
    public required string Type;
}
