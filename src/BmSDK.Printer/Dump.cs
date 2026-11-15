using System.Globalization;
using System.Text.Json;

namespace BmSDK.Printer;

// Every class from a set of dump files, merged by path.
//
// Arkham Knight cooks a copy of a script class into each package that uses it, and the copies are
// not always the same. When they differ, the copy a snapshot saw wins, since that is what the game
// itself loaded. After that, the copy found in the most packages. Classes from a package that
// faulted while loading are left out, they can be half built.
sealed class Dump
{
    public readonly Dictionary<string, ClassNode> Classes = new(StringComparer.Ordinal);
    public readonly Dictionary<string, Node> Index = new(StringComparer.Ordinal);
    public readonly List<string> Report = [];

    // The build the dump came from, and the code every script function points at.
    public string Build = "";
    public ulong ScriptCodeRva;

    sealed class Candidate
    {
        public required ClassNode Class;
        public required string Signature;
        public int Snapshots;
        public int Seen;
        public int Order;
        public HashSet<string> Sources = [];
    }

    public static Dump Load(IEnumerable<string> files)
    {
        var candidates = new Dictionary<string, List<Candidate>>(StringComparer.Ordinal);
        var failed = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var order = 0;
        var build = "";

        foreach (var file in files)
        {
            var isSnapshot = Path.GetFileName(file).StartsWith("snapshot", StringComparison.OrdinalIgnoreCase);
            var count = 0;
            foreach (var line in File.ReadLines(file))
            {
                if (line.StartsWith("{\"t\":\"meta\"", StringComparison.Ordinal))
                {
                    using var meta = JsonDocument.Parse(line);
                    build = meta.RootElement.GetProperty("build").GetString() ?? "";
                    continue;
                }
                if (line.StartsWith("{\"t\":\"package\"", StringComparison.Ordinal))
                {
                    using var pkg = JsonDocument.Parse(line);
                    if (!pkg.RootElement.GetProperty("ok").GetBoolean())
                    {
                        failed.Add(pkg.RootElement.GetProperty("name").GetString()!);
                    }
                    continue;
                }
                if (!line.StartsWith("{\"t\":\"class\"", StringComparison.Ordinal))
                {
                    continue;
                }

                using var doc = JsonDocument.Parse(line);
                var cls = ReadClass(doc.RootElement);
                count++;

                var signature = Signature(cls);
                var list = candidates.TryGetValue(cls.Path, out var l) ? l : candidates[cls.Path] = [];
                var match = list.FirstOrDefault(c => c.Signature == signature);
                if (match is null)
                {
                    match = new Candidate { Class = cls, Signature = signature };
                    list.Add(match);
                }
                match.Order = order++;
                match.Seen++;
                match.Snapshots += isSnapshot ? 1 : 0;
                match.Sources.Add(cls.Source ?? (isSnapshot ? "(snapshot)" : "(loaded)"));
            }
            Console.WriteLine($"{Path.GetFileName(file)}: {count} classes");
        }

        var dump = new Dump { Build = build };
        foreach (var (path, list) in candidates)
        {
            var usable = list.Where(c => c.Class.Size > 0 && !c.Sources.All(failed.Contains)).ToList();
            if (usable.Count == 0)
            {
                dump.Report.Add($"{path}: only half-built copies, left out");
                continue;
            }

            var best = usable
                .OrderByDescending(c => c.Snapshots)
                .ThenByDescending(c => c.Sources.Count)
                .ThenByDescending(c => c.Seen)
                .ThenByDescending(c => c.Order)
                .First();
            dump.Classes[path] = best.Class;

            if (list.Count > 1)
            {
                dump.Report.Add($"{path}: {list.Count} versions, using the one from {string.Join(", ", best.Sources.Order().Take(4))}");
                foreach (var other in list.Where(c => c != best))
                {
                    var why = other.Class.Size == 0 ? " (half built)" : other.Sources.All(failed.Contains) ? " (faulted package)" : "";
                    dump.Report.Add($"    not used{why}: size {other.Class.Size}, from {string.Join(", ", other.Sources.Order().Take(4))}");
                }
            }
        }

        foreach (var cls in dump.Classes.Values)
        {
            dump.AddToIndex(cls);
        }

        // Script functions all run through the same code, ProcessInternal
        dump.ScriptCodeRva = dump.Index.Values.OfType<FuncNode>()
            .Where(f => (f.Flags & Flags.FUNC_Native) == 0 && f.CodeRva is not null)
            .GroupBy(f => f.CodeRva!.Value)
            .MaxBy(g => g.Count())?.Key ?? 0;
        return dump;
    }

    // What makes two copies of a class different: everything except where in memory they were.
    static string Signature(ClassNode cls)
    {
        var sb = new System.Text.StringBuilder();
        sb.Append(cls.SuperPath).Append('|').Append(cls.Flags).Append('|').Append(cls.Size).Append('|').Append(cls.Align);
        foreach (var field in cls.Fields)
        {
            AppendSignature(sb, field);
        }
        return Convert.ToHexString(System.Security.Cryptography.SHA1.HashData(System.Text.Encoding.UTF8.GetBytes(sb.ToString())));
    }

    static void AppendSignature(System.Text.StringBuilder sb, Node node)
    {
        sb.Append('{').Append(node.Name).Append('|');
        switch (node)
        {
            case PropNode p:
                sb.Append(p.Type).Append('|').Append(p.Dim).Append('|').Append(p.Flags).Append('|').Append(p.ElementSize)
                    .Append('|').Append(p.Offset).Append('|').Append(p.Mask);
                foreach (var (offset, target) in p.Refs.OrderBy(r => r.Key))
                {
                    sb.Append('|').Append(offset).Append('=').Append(target);
                }
                foreach (var sub in p.Sub)
                {
                    AppendSignature(sb, sub);
                }
                break;
            case FuncNode f:
                sb.Append("func|").Append(f.Flags).Append('|').Append(f.SuperPath).Append('|').Append(f.Size);
                f.Fields.ForEach(c => AppendSignature(sb, c));
                break;
            case StructNode s:
                sb.Append(s.Kind).Append('|').Append(s.SuperPath).Append('|').Append(s.Size).Append('|').Append(s.Align);
                s.Fields.ForEach(c => AppendSignature(sb, c));
                break;
            case EnumNode e:
                sb.Append("enum|").Append(string.Join(',', e.Names));
                break;
            case ConstNode c:
                sb.Append("const|").Append(c.Value);
                break;
            case OtherNode o:
                sb.Append(o.Type);
                break;
        }
        sb.Append('}');
    }

    // Dump files are named prefix-yyyyMMdd-HHmmss.jsonl, so order them by the time part.
    public static IEnumerable<string> FilesIn(string dir) =>
        Directory.GetFiles(dir, "*.jsonl").OrderBy(f => Path.GetFileNameWithoutExtension(f)[(Path.GetFileNameWithoutExtension(f).IndexOf('-') + 1)..], StringComparer.Ordinal);

    public Node? Find(string? path) => path is not null && Index.TryGetValue(path, out var node) ? node : null;

    void AddToIndex(Node node)
    {
        Index[node.Path] = node;
        var fields = node switch
        {
            ClassNode c => c.Fields,
            StructNode s => s.Fields,
            _ => null,
        };
        if (fields is not null)
        {
            foreach (var field in fields)
            {
                AddToIndex(field);
            }
        }
        if (node is PropNode p)
        {
            foreach (var sub in p.Sub)
            {
                AddToIndex(sub);
            }
        }
    }

    static ClassNode ReadClass(JsonElement e)
    {
        var path = e.GetProperty("path").GetString()!;
        var cls = new ClassNode
        {
            Path = path,
            Name = path[(path.LastIndexOf('.') + 1)..],
            Package = e.GetProperty("package").GetString()!,
            SuperPath = Str(e, "super"),
            Flags = (uint)Hex(e, "flags"),
            Size = e.GetProperty("size").GetInt32(),
            Align = e.GetProperty("align").GetInt32(),
            Source = Str(e, "src"),
        };

        foreach (var i in e.GetProperty("interfaces").EnumerateArray())
        {
            cls.Interfaces.Add(i.GetString()!);
        }
        ReadFields(e, cls, cls.Fields);
        cls.Defaults = ReadDefaults(e);
        return cls;
    }

    static void ReadFields(JsonElement e, Node outer, List<Node> into)
    {
        foreach (var f in e.GetProperty("fields").EnumerateArray())
        {
            into.Add(ReadField(f, outer));
        }
    }

    static Node ReadField(JsonElement f, Node outer)
    {
        var name = f.GetProperty("name").GetString()!;
        var path = outer.Path + "." + name;
        var kind = f.GetProperty("k").GetString();

        switch (kind)
        {
            case "prop":
                return ReadProp(f, outer);

            case "func":
            case "state":
            case "struct":
            {
                StructNode node = kind == "func"
                    ? new FuncNode { Name = name, Path = path, Outer = outer, Kind = kind, Flags = (uint)Hex(f, "flags") }
                    : new StructNode { Name = name, Path = path, Outer = outer, Kind = kind };
                node.SuperPath = Str(f, "super");
                node.Size = f.GetProperty("size").GetInt32();
                if (node is FuncNode func && f.TryGetProperty("ptrs", out var ptrs))
                {
                    func.CodeRva = CodeRva(ptrs);
                }
                node.Align = f.TryGetProperty("align", out var a) ? a.GetInt32() : 0;
                ReadFields(f, node, node.Fields);
                node.Defaults = ReadDefaults(f);
                return node;
            }

            case "enum":
            {
                var node = new EnumNode { Name = name, Path = path, Outer = outer };
                foreach (var n in f.GetProperty("names").EnumerateArray())
                {
                    node.Names.Add(n.GetString()!);
                }
                return node;
            }

            case "const":
                return new ConstNode { Name = name, Path = path, Outer = outer, Value = Str(f, "value") };

            default:
                return new OtherNode { Name = name, Path = path, Outer = outer, Type = Str(f, "type") ?? "" };
        }
    }

    static PropNode ReadProp(JsonElement f, Node outer)
    {
        var name = f.GetProperty("name").GetString()!;
        var node = new PropNode
        {
            Name = name,
            Path = outer.Path + "." + name,
            Outer = outer,
            Type = f.GetProperty("type").GetString()!,
            Dim = f.GetProperty("dim").GetInt32(),
            Flags = Hex(f, "flags"),
            ElementSize = f.GetProperty("esz").GetInt32(),
            Offset = f.GetProperty("off").GetInt32(),
            Mask = f.TryGetProperty("mask", out _) ? (uint)Hex(f, "mask") : 0,
        };

        foreach (var r in f.GetProperty("refs").EnumerateArray())
        {
            node.Refs[r[0].GetInt32()] = r[1].GetString()!;
        }
        if (f.TryGetProperty("sub", out var sub))
        {
            foreach (var s in sub.EnumerateArray())
            {
                node.Sub.Add(ReadProp(s, node));
            }
        }
        return node;
    }

    // A UFunction holds the pointer to its code at offset 188.
    const int FunctionCode = 188;

    static ulong? CodeRva(JsonElement ptrs)
    {
        foreach (var ptr in ptrs.EnumerateArray())
        {
            var target = ptr[1].GetString()!;
            if (ptr[0].GetInt32() == FunctionCode && target.StartsWith("rva:0x", StringComparison.Ordinal))
            {
                return ulong.Parse(target.AsSpan(6), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }
        }
        return null;
    }

    static Dictionary<string, JsonElement>? ReadDefaults(JsonElement e)
    {
        if (!e.TryGetProperty("defaults", out var defaults) || defaults.ValueKind != JsonValueKind.Object)
        {
            return null;
        }

        var values = new Dictionary<string, JsonElement>(StringComparer.Ordinal);
        foreach (var value in defaults.EnumerateObject())
        {
            if (value.Name != "_object")
            {
                values[value.Name] = value.Value.Clone();
            }
        }
        return values;
    }

    static string? Str(JsonElement e, string key) =>
        e.TryGetProperty(key, out var v) && v.ValueKind == JsonValueKind.String ? v.GetString() : null;

    static ulong Hex(JsonElement e, string key) =>
        ulong.Parse(e.GetProperty(key).GetString()!.AsSpan(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
}
