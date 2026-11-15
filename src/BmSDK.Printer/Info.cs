namespace BmSDK.Printer;

// What the printer needs from the dump, worked out the way the in-game generator did it
// (ClassInfo.cpp and UProperty.cpp), so the output matches it.

abstract class MemberInfo;

sealed class PropertyInfo : MemberInfo
{
    public string Name = "";
    public string ManagedName = "";
    public string TypeName = "";
    public string ClassName = "";
    public int ArrayDim;
    public int Offset;
    public int ElementSize;
    public int BitMask;
    public ulong Flags;
    public bool IsInStruct;
    public bool IsBool;
    public bool IsParam;
    public bool IsOptionalParam;
    public bool IsOutParam;
    public bool IsReturnParam;
    public bool ShouldReturnByRef;
    public bool OwnsMemory;
}

class StructInfo : MemberInfo
{
    public string ManagedName = "";
    public int PropertiesSize;
    public int MinAlignment = 1;
    public List<MemberInfo> Members = [];

    // The size of one element in a TArray or a C array of this struct: PropertiesSize rounded up
    // to MinAlignment, the way the engine lays them out.
    public int AlignedSize
    {
        get
        {
            var align = MinAlignment > 0 ? MinAlignment : 1;
            return (PropertiesSize + align - 1) / align * align;
        }
    }
}

sealed class ConstInfo : MemberInfo
{
    public string Name = "";
    public string ManagedName = "";
    public string Type = "";
    public string Literal = "";
    public string Text = "";
}

sealed class EnumInfo : MemberInfo
{
    public string Name = "";
    public string ManagedName = "";
    public List<string> Names = [];
}

sealed class FunctionInfo : MemberInfo
{
    public string Name = "";
    public string ManagedName = "";
    public string PathName = "";
    public int PropertiesSize;
    public uint Flags;
    public bool IsStatic;
    public bool IsNative;
    public bool IsPrivate;
    public bool IsOverride;
    public bool ShouldSuppressOptional;
    public bool HasReturnParam;
    public PropertyInfo ReturnParam = new();
    public List<PropertyInfo> Params = [];
}

sealed class ClassInfo : StructInfo
{
    public string Name = "";
    public string PathName = "";
    public string PackageName = "";
    public string PackageNameManaged = "";
    public ClassInfo? Super;
    public string? SuperPath;
    public uint Flags;
    public bool IsAbstract;
    public bool IsInterface;
    public bool IsIntrinsic;
    public bool IsActor;
    public List<string> Interfaces = [];
}

static class Flags
{
    public const ulong CPF_Parm = 0x8;
    public const ulong CPF_OptionalParm = 0x10;
    public const ulong CPF_OutParm = 0x20;
    public const ulong CPF_ReturnParm = 0x80;

    public const uint FUNC_Iterator = 0x4;
    public const uint FUNC_Native = 0x400;
    public const uint FUNC_Operator = 0x1000;
    public const uint FUNC_Static = 0x2000;
    public const uint FUNC_Private = 0x40000;

    public const uint CLASS_Abstract = 0x1;
    public const uint CLASS_Interface = 0x4000;
    public const uint CLASS_Intrinsic = 0x10000000;
}

sealed class InfoBuilder(Dump dump)
{
    // Offsets of what a property subclass points at.
    const int Ref0 = 148;

    public string FieldNameManaged(Node field)
    {
        // Manually rename some classes to avoid conflicts with the System namespace
        switch (field.Path)
        {
            case "Core.Object": return "GameObject";
            case "Core.System": return "_System";
            case "Engine.Console": return "_Console";
        }

        if (field is StructNode { Kind: "struct" })
        {
            return "F" + field.Name;
        }

        // Workaround fields with same name as their outer
        var outerName = field is ClassNode c ? c.Package : field.Outer?.Name;
        if (outerName is not null && field.Name == outerName)
        {
            return "_" + field.Name;
        }

        // Ensure that every function override will have the same name
        if (field is FuncNode func && func.SuperPath is not null && dump.Find(func.SuperPath) is FuncNode super)
        {
            return FieldNameManaged(super);
        }

        // De-duplicate prop names for structs and functions
        if (field is PropNode && field.Outer is StructNode { Kind: "func" or "struct" } owner)
        {
            var duplicates = 0;
            foreach (var sibling in owner.Fields)
            {
                if (sibling == field)
                {
                    break;
                }
                if (sibling.Name == field.Name)
                {
                    duplicates++;
                }
            }
            if (duplicates > 0)
            {
                return field.Name + "_" + duplicates;
            }
        }

        return field.Name;
    }

    public static string PackageNameManaged(string package) => package == "Core" ? "BmSDK" : "BmSDK." + package;

    public string FieldPathNameManaged(Node field)
    {
        var managed = FieldNameManaged(field);
        if (field is ClassNode c)
        {
            return PackageNameManaged(c.Package) + "." + managed;
        }
        if (field.Outer is not null)
        {
            return FieldPathNameManaged(field.Outer) + "." + managed;
        }
        return managed;
    }

    // A class that isn't in the dump still has a name the generator would have given it.
    string ClassPathManaged(string path)
    {
        if (dump.Find(path) is ClassNode c)
        {
            return FieldPathNameManaged(c);
        }

        var dot = path.IndexOf('.');
        var package = path[..dot];
        var name = path[(dot + 1)..];
        var managed = path switch
        {
            "Core.Object" => "GameObject",
            "Core.System" => "_System",
            "Engine.Console" => "_Console",
            _ => name == package ? "_" + name : name,
        };
        return PackageNameManaged(package) + "." + managed;
    }

    public string InnerTypeNameManaged(PropNode prop)
    {
        if (prop.Path == "Core.Object.ObjectFlags")
        {
            return "BmSDK.GameObject.EObjectFlags";
        }

        switch (prop.Type)
        {
            case "IntProperty":
                return "int";

            case "ByteProperty":
                // Try to use proper type for enums
                return dump.Find(prop.RefPath(Ref0)) is EnumNode en ? FieldPathNameManaged(en) : "byte";

            case "FloatProperty":
                return "float";

            case "BoolProperty":
                return "bool";

            case "StrProperty":
            case "StringProperty":
                return "BmSDK.FString";

            case "NameProperty":
                return "BmSDK.FName";

            case "StructProperty":
            {
                var structPath = prop.RefPath(Ref0) ?? "";
                var structName = structPath[(structPath.LastIndexOf('.') + 1)..];

                // Manually swap out some structs
                switch (structName)
                {
                    case "Pointer": return "System.IntPtr";
                    case "Double": return "double";
                    case "QWord": return "ulong";
                    case "Vector": return "System.Numerics.Vector3";
                    case "Vector4": return "System.Numerics.Vector4";
                    case "Vector2D": return "System.Numerics.Vector2";
                    case "Rotator": return "BmSDK.Rotator";
                }

                if (dump.Find(structPath) is { } st)
                {
                    return FieldPathNameManaged(st);
                }

                // A struct of a class that isn't in the dump
                var lastDot = structPath.LastIndexOf('.');
                return ClassPathManaged(structPath[..lastDot]) + ".F" + structName;
            }

            case "ObjectProperty":
            case "ComponentProperty":
            case "ClassProperty":
            case "InterfaceProperty":
            {
                // BM4: Investigate why this happens
                var classPath = prop.RefPath(Ref0);
                return classPath is null ? "BmSDK.GameObject" : ClassPathManaged(classPath);
            }

            case "ArrayProperty":
            {
                var inner = prop.Sub.FirstOrDefault();
                return "BmSDK.TArray<" + (inner is null ? "UNKNOWN_INNER" : InnerTypeNameManaged(inner)) + ">";
            }

            case "MapProperty":
                return "BmSDK.TMap<object, object> /* TODO */";

            case "DelegateProperty":
                return "System.IntPtr";
        }

        return "UNKNOWN";
    }

    bool ShouldReturnByRef(PropNode prop)
    {
        if (prop.Type != "StructProperty")
        {
            return false;
        }

        // Omit UE3 structs that are actually generated as non-struct C# types
        var managed = InnerTypeNameManaged(prop);
        return managed != "System.IntPtr" && managed != "double" && managed != "ulong";
    }

    // True when a value of this property owns heap memory: a string, array or map, or a struct
    // holding one. Structs that extend another struct count as owning, because their inherited
    // members aren't printed.
    bool OwnsMemory(PropNode prop)
    {
        if (prop.Type is "StrProperty" or "ArrayProperty" or "MapProperty")
        {
            return true;
        }

        if (prop.Type == "StructProperty" && dump.Find(prop.RefPath(Ref0)) is StructNode st)
        {
            if (st.SuperPath is not null)
            {
                return true;
            }
            foreach (var field in st.Fields)
            {
                if (field is PropNode p && OwnsMemory(p))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public PropertyInfo Property(PropNode prop, bool isInStruct)
    {
        var info = new PropertyInfo
        {
            Name = prop.Name,
            ManagedName = FieldNameManaged(prop),
            TypeName = InnerTypeNameManaged(prop),
            ClassName = prop.Type,
            ArrayDim = prop.Dim,
            Offset = prop.Offset,
            ElementSize = prop.ElementSize,
            // The in-game generator kept only the low 32 bits
            Flags = prop.Flags & 0xFFFFFFFF,
            IsInStruct = isInStruct,
            IsBool = prop.Type == "BoolProperty",
            OwnsMemory = OwnsMemory(prop),
        };

        info.IsParam = (info.Flags & Flags.CPF_Parm) != 0;
        info.IsOptionalParam = (info.Flags & Flags.CPF_OptionalParm) != 0;
        info.IsOutParam = (info.Flags & Flags.CPF_OutParm) != 0;
        info.IsReturnParam = (info.Flags & Flags.CPF_ReturnParm) != 0;
        info.ShouldReturnByRef = ShouldReturnByRef(prop) && !isInStruct;
        if (info.IsBool)
        {
            info.BitMask = (int)prop.Mask;
        }
        return info;
    }

    StructInfo Struct(StructNode st)
    {
        var info = new StructInfo
        {
            ManagedName = FieldNameManaged(st),
            PropertiesSize = st.Size,
            MinAlignment = st.Align,
        };

        // A struct that extends another struct holds its parent's members at the same offsets, so
        // print the whole chain, outermost parent first. C# record structs can't inherit.
        var chain = new List<StructNode>();
        for (StructNode? s = st; s is not null; s = dump.Find(s.SuperPath) as StructNode)
        {
            chain.Insert(0, s);
        }

        foreach (var s in chain)
        {
            foreach (var field in s.Fields)
            {
                if (field is PropNode p)
                {
                    info.Members.Add(Property(p, true));
                }
            }
        }
        return info;
    }

    EnumInfo Enum(EnumNode en)
    {
        var info = new EnumInfo { Name = en.Name, ManagedName = FieldNameManaged(en) };
        var freqs = new Dictionary<string, int>();
        foreach (var name in en.Names)
        {
            freqs[name] = freqs.GetValueOrDefault(name) + 1;
            info.Names.Add(freqs[name] > 1 ? name + "_" + freqs[name] : name);
        }
        return info;
    }

    FunctionInfo Function(FuncNode func)
    {
        var info = new FunctionInfo
        {
            Name = func.Name,
            ManagedName = FieldNameManaged(func),
            PathName = func.Path,
            PropertiesSize = func.Size,
            Flags = func.Flags,
            IsStatic = (func.Flags & Flags.FUNC_Static) != 0,
            IsNative = (func.Flags & Flags.FUNC_Native) != 0,
            IsPrivate = (func.Flags & Flags.FUNC_Private) != 0,
            IsOverride = func.SuperPath is not null,
        };

        foreach (var field in func.Fields)
        {
            if (field is not PropNode p)
            {
                continue;
            }

            var param = Property(p, false);
            if (param.IsReturnParam)
            {
                info.ReturnParam = param;
                info.HasReturnParam = true;
            }
            else if (param.IsParam)
            {
                info.Params.Add(param);
            }
        }

        info.ShouldSuppressOptional = info.Params.Any(p => p.IsOptionalParam && p.IsOutParam);
        return info;
    }

    public ClassInfo Class(ClassNode cls)
    {
        var info = new ClassInfo
        {
            ManagedName = FieldNameManaged(cls),
            PropertiesSize = cls.Size,
            MinAlignment = cls.Align,
            Name = cls.Name,
            PathName = cls.Path,
            PackageName = cls.Package,
            PackageNameManaged = PackageNameManaged(cls.Package),
            SuperPath = cls.SuperPath,
            Flags = cls.Flags,
            IsAbstract = (cls.Flags & Flags.CLASS_Abstract) != 0,
            IsInterface = (cls.Flags & Flags.CLASS_Interface) != 0,
            IsIntrinsic = (cls.Flags & Flags.CLASS_Intrinsic) != 0,
        };

        // The engine lists inherited interfaces on every class. Only the ones this class adds are
        // printed, the rest come with the base class.
        var inherited = (dump.Find(cls.SuperPath) as ClassNode)?.Interfaces ?? [];
        foreach (var iface in cls.Interfaces)
        {
            if (!inherited.Contains(iface) && dump.Find(iface) is ClassNode ifaceClass &&
                (ifaceClass.Flags & Flags.CLASS_Interface) != 0)
            {
                info.Interfaces.Add(FieldPathNameManaged(ifaceClass));
            }
        }

        for (var super = dump.Find(cls.SuperPath) as ClassNode; super is not null; super = dump.Find(super.SuperPath) as ClassNode)
        {
            if (super.Path == "Engine.Actor")
            {
                info.IsActor = true;
                break;
            }
        }

        foreach (var field in cls.Fields)
        {
            switch (field)
            {
                case PropNode p:
                    info.Members.Add(Property(p, false));
                    break;
                case FuncNode f when (f.Flags & (Flags.FUNC_Operator | Flags.FUNC_Iterator)) == 0:
                    info.Members.Add(Function(f));
                    break;
                case FuncNode:
                    break;
                case StructNode { Kind: "struct" } s:
                    info.Members.Add(Struct(s));
                    break;
                case EnumNode e:
                    info.Members.Add(Enum(e));
                    break;
            }
        }

        // Consts go first in the class, and only take names nothing else uses.
        var taken = new HashSet<string>(StringComparer.Ordinal) { info.ManagedName };
        foreach (var member in info.Members)
        {
            switch (member)
            {
                case PropertyInfo p:
                    taken.Add(p.ManagedName);
                    for (var i = 0; i < p.ArrayDim; i++)
                    {
                        taken.Add(p.ManagedName + "_" + i);
                    }
                    break;
                case FunctionInfo f:
                    taken.Add(f.ManagedName);
                    taken.Add("__fn_" + f.ManagedName);
                    break;
                case EnumInfo e:
                    taken.Add(e.ManagedName);
                    break;
                case StructInfo s:
                    taken.Add(s.ManagedName);
                    break;
            }
        }

        var consts = new List<MemberInfo>();
        foreach (var field in cls.Fields)
        {
            if (field is ConstNode c && Const(c) is { } constInfo && taken.Add(constInfo.ManagedName))
            {
                consts.Add(constInfo);
            }
        }
        info.Members.InsertRange(0, consts);
        return info;
    }

    // UnrealScript keeps a const as the text it was written with. Numbers and booleans get their
    // C# type, anything else stays a string.
    ConstInfo? Const(ConstNode c)
    {
        var text = c.Value?.Trim();
        if (text is null)
        {
            return null;
        }

        var info = new ConstInfo { Name = c.Name, ManagedName = FieldNameManaged(c), Text = text };
        if (int.TryParse(text, System.Globalization.NumberStyles.AllowLeadingSign, System.Globalization.CultureInfo.InvariantCulture, out _))
        {
            (info.Type, info.Literal) = ("int", text);
        }
        else if (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase) &&
            uint.TryParse(text.AsSpan(2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out var hex))
        {
            (info.Type, info.Literal) = ("int", hex > int.MaxValue ? $"unchecked((int)0x{hex:X})" : text);
        }
        else if (float.TryParse(text.TrimEnd('f', 'F'), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out var number) && float.IsFinite(number))
        {
            (info.Type, info.Literal) = ("float", number.ToString("R", System.Globalization.CultureInfo.InvariantCulture) + "f");
        }
        else if (text is "true" or "false" or "True" or "False")
        {
            (info.Type, info.Literal) = ("bool", text.ToLowerInvariant());
        }
        else
        {
            // A name is written 'Name', a string "text". Both come out as the text inside.
            var inner = text.Length >= 2 && (text[0] == '\'' || text[0] == '"') && text[^1] == text[0] ? text[1..^1] : text;
            (info.Type, info.Literal) = ("string", "\"" + inner.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"");
        }
        return info;
    }
}
