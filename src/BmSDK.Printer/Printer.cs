using System.Text;

namespace BmSDK.Printer;

// Writes the C# for one class. It follows Printer.cpp line for line, so a run over the same classes
// gives the same files.
sealed class Printer
{
    readonly StringBuilder _out = new();
    int _indent;

    public override string ToString() => _out.ToString();

    StringBuilder Indent()
    {
        _out.Append(' ', _indent * 4);
        return _out;
    }

    StringBuilder Line(string text = "")
    {
        if (text.Length > 0)
        {
            Indent().Append(text);
        }
        return _out.Append('\n');
    }

    void Endl() => _out.Append('\n');

    public void PrintFile(ClassInfo cls)
    {
        Line("#pragma warning disable CS0108");
        Line("#pragma warning disable CS1591");
        Endl();

        Line($"namespace {cls.PackageNameManaged};");
        Endl();

        if (cls.IsInterface)
        {
            PrintInterface(cls);
        }
        else
        {
            PrintClass(cls);
            PrintStatics(cls);
        }
    }

    // A static native may read the object it is called on (the game calls them on live instances),
    // and faults when run on the class default object the way the static wrapper does. So each one
    // is also offered as an extension method on an instance. Object's statics are the pure maths and
    // string library, which stay static only.
    void PrintStatics(ClassInfo cls)
    {
        if (cls.IsIntrinsic || cls.IsInterface || cls.Name == "Object")
        {
            return;
        }

        var funcs = cls.Members.OfType<FunctionInfo>().Where(f => f.IsStatic && f.IsNative).ToList();
        if (funcs.Count == 0)
        {
            return;
        }

        Endl();
        Line("/// <summary>");
        Line($"/// The static native functions of {cls.ManagedName}, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.");
        Line("/// </summary>");
        Line($"public static class {cls.ManagedName}Statics");
        Line("{");
        _indent++;
        for (var i = 0; i < funcs.Count; i++)
        {
            PrintFunction(funcs[i], false, cls);
            if (i < funcs.Count - 1)
            {
                Endl();
            }
        }
        _indent--;
        Line("}");
    }

    void PrintInterface(ClassInfo cls)
    {
        Line("/// <summary>");
        Line($"/// Interface: {cls.ManagedName}<br/>");
        Line($"/// (size = {cls.PropertiesSize})");
        Line($"/// (flags = {cls.Flags})");
        Line("/// </summary>");

        Indent().Append($"public partial interface {cls.ManagedName}");

        // Workaround to prevent Core.Interface from trying to inherit GameObject
        if (cls.PathName != "Core.Interface" && cls.Super is not null)
        {
            _out.Append($" : {cls.Super.PackageNameManaged}.{cls.Super.ManagedName}");
        }
        Endl();

        Line("{");
        _indent++;
        for (var i = 0; i < cls.Members.Count; i++)
        {
            var member = cls.Members[i];
            if (member is not PropertyInfo)
            {
                PrintMember(member, true);
                if (i < cls.Members.Count - 1)
                {
                    Endl();
                }
            }
        }
        _indent--;
        Line("}");
    }

    void PrintClass(ClassInfo cls)
    {
        var name = cls.ManagedName;

        Line("/// <summary>");
        Indent().Append("/// ");
        if (cls.IsAbstract)
        {
            _out.Append("ABSTRACT ");
        }
        Line($"Class: {name}<br/>");
        Line($"/// (size = {cls.PropertiesSize})");
        Line($"/// (flags = {cls.Flags})");
        Line("/// </summary>");

        Indent().Append($"public partial class {name} : ");
        if (cls.Super is not null)
        {
            _out.Append($"{cls.Super.PackageNameManaged}.{cls.Super.ManagedName}, ");
        }
        foreach (var iface in cls.Interfaces)
        {
            _out.Append(iface).Append(", ");
        }
        _out.Append("BmSDK.IGameObject\n");

        Line("{");
        _indent++;

        Line("static BmSDK.Class s_staticClass = null;");
        Line("public static BmSDK.Class StaticClass()");
        Line("{");
        _indent++;
        Line("if (s_staticClass is null)");
        Line("{");
        _indent++;
        Line($"s_staticClass = StaticFindObjectChecked<Class>(null, null, \"{cls.PathName}\", false);");
        Line("s_staticClass.AddToRoot();");
        _indent--;
        Line("}");
        Line("return s_staticClass;");
        _indent--;
        Line("}");
        Endl();

        if (name != "Class")
        {
            Line("/// <summary>");
            Line($"/// Gets the class default object as {name}.");
            Line("/// </summary>");
            Line($"public static {name} DefaultObject => ({name})StaticClass().DefaultObject;");
            Endl();
        }

        Line($"internal {name}() {{ }}");
        Endl();

        if (!cls.IsAbstract)
        {
            Line("/// <summary>");
            Line($"/// Constructs a new {name}");
            Line("/// </summary>");

            if (cls.IsActor)
            {
                Line($"public {name}(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) {{ }}");
            }
            else
            {
                Line($"public {name}(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, {name} Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) {{ }}");
            }
            Endl();
        }

        Line("/// <summary>");
        Line("/// Constructs a new wrapper instance from the given object pointer.");
        Line("/// </summary>");
        Indent().Append($"protected {name}(nint ptr)");
        if (cls.Name == "Object")
        {
            // Only script code gets here, by making an object itself. The wrapper is registered so
            // it is marked invalid when the game destroys the object.
            _out.Append(" { Ptr = ptr; BmSDK.Framework.MarshalUtil.RegisterConstructed(this); }\n");
        }
        else
        {
            _out.Append(" : base(ptr) { }\n");
        }
        Endl();

        PrintScHelpers(cls);

        // Don't print any members for intrinsic classes. They occasionally exist at runtime, but we
        // just want their declaration so we can reference them.
        if (!cls.IsIntrinsic)
        {
            for (var i = 0; i < cls.Members.Count; i++)
            {
                PrintMember(cls.Members[i], false);
                if (i < cls.Members.Count - 1)
                {
                    Endl();
                }
            }
        }

        _indent--;
        Line("}");
    }

    void PrintScHelpers(ClassInfo cls)
    {
        var type = cls.ManagedName;
        PrintScHelper("void", "AttachScriptComponent", false, false, false, type);
        PrintScHelper("TComponent", "AttachScriptComponent", true, true, true, type);
        PrintScHelper("bool", "HasScriptComponent", false, false, false, type);
        PrintScHelper("bool", "HasScriptComponent", true, false, false, type);
        PrintScHelper("TComponent", "GetScriptComponent", true, false, true, type);

        Line("/// <inheritdoc cref=\"GameObject.GetScriptComponents(Type)\"/>");
        Line("public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()");
        _indent++;
        Line($"where TComponent : class, Framework.IScriptComponent<{type}>");
        Line("=> ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();");
        _indent--;
        Endl();

        PrintScHelper("void", "DetachScriptComponent", false, false, false, type);
        PrintScHelper("void", "DetachScriptComponents", true, false, false, type);
    }

    void PrintScHelper(string returnType, string helper, bool generic, bool ctor, bool cast, string type)
    {
        if (generic)
        {
            Line($"/// <inheritdoc cref=\"GameObject.{helper}(Type)\"/>");
            Line($"public {returnType} {helper}<TComponent>()");
            _indent++;
            Line($"where TComponent : class, Framework.IScriptComponent<{type}>{(ctor ? ", new()" : "")}");
            Line($"=> {(cast ? "(TComponent)" : "")}((GameObject)this).{helper}(typeof(TComponent));");
            _indent--;
        }
        else
        {
            Line($"/// <inheritdoc cref=\"GameObject.{helper}(Framework.IScriptComponent)\"/>");
            Line($"public {returnType} {helper}<TComponent>(TComponent component)");
            _indent++;
            Line($"where TComponent : class, Framework.IScriptComponent<{type}>");
            Line($"=> ((GameObject)this).{helper}((Framework.IScriptComponent)component);");
            _indent--;
        }
        Endl();
    }

    void PrintStruct(StructInfo st)
    {
        Line("/// <summary>");
        Line($"/// Struct: {st.ManagedName}");
        Line("/// </summary>");

        // The size is the array stride (PropertiesSize rounded up to the struct's alignment), so
        // TArray<T> and inline arrays of this struct index correctly.
        Line($"[StructLayout(LayoutKind.Explicit, Size = {st.AlignedSize})]");
        Line($"public partial record struct {st.ManagedName}");

        Line("{");
        _indent++;
        for (var i = 0; i < st.Members.Count; i++)
        {
            PrintMember(st.Members[i], false);
            if (i < st.Members.Count - 1)
            {
                Endl();
            }
        }
        _indent--;
        Line("}");
    }

    void PrintConst(ConstInfo c)
    {
        Line("/// <summary>");
        Line($"/// Const: {c.Name} = {System.Security.SecurityElement.Escape(c.Text)}");
        Line("/// </summary>");
        Line($"public const {c.Type} {c.ManagedName} = {c.Literal};");
    }

    void PrintEnum(EnumInfo en)
    {
        Line("/// <summary>");
        Line($"/// Enum: {en.Name}");
        Line("/// </summary>");
        Line($"public enum {en.ManagedName} : byte");
        Line("{");
        _indent++;
        for (var i = 0; i < en.Names.Count; i++)
        {
            Line($"{en.Names[i]} = {i},");
        }
        _indent--;
        Line("}");
    }

    void PrintProperty(PropertyInfo prop)
    {
        if (!prop.IsInStruct && prop.ArrayDim > 1)
        {
            Line("/// <summary>");
            Line($"/// InlineArray{{{prop.ClassName}}}: {prop.Name}");
            Line("/// </summary>");
            Line($"public InlineArray<{prop.TypeName}> {prop.ManagedName} => new({prop.ArrayDim}, Ptr + {prop.Offset}, {prop.ElementSize}, this);");
            Endl();
        }

        for (var i = 0; i < prop.ArrayDim; i++)
        {
            var offset = prop.Offset + i * prop.ElementSize;
            var name = prop.ArrayDim > 1 ? prop.ManagedName + "_" + i : prop.ManagedName;

            Line("/// <summary>");
            Line($"/// {prop.ClassName}: {prop.Name}");
            Line("/// </summary>");

            if (prop.ShouldReturnByRef)
            {
                Line($"public unsafe ref {prop.TypeName} {name}");
                _indent++;
                Line($"=> ref BmSDK.Framework.MarshalUtil.AsRef<{prop.TypeName}>(Ptr + {offset});");
                _indent--;
                continue;
            }

            Line($"public unsafe {prop.TypeName} {name}");
            Line("{");
            _indent++;

            // Make Ptr available locally in a struct so the same getter and setter code works
            var open = prop.IsInStruct ? "fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; " : "";
            var close = prop.IsInStruct ? " };" : "";

            // Booleans are stored as bitmasks
            var get = prop.IsBool
                ? $"return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + {offset}) & {prop.BitMask}) != 0;"
                : $"return BmSDK.Framework.MarshalUtil.ToManaged<{prop.TypeName}>(Ptr + {offset});";
            Line($"get {{ {open}{get}{close} }}");

            var set = prop.IsBool
                ? $"var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + {offset}); var newMask = value ? (currentMask | {prop.BitMask}) : (currentMask & ~{prop.BitMask}); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + {offset});"
                : $"BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + {offset});";
            Line($"set {{ {open}{set}{close} }}");

            _indent--;
            Line("}");
        }
    }

    // A string passed to a function by value.
    static bool IsStringArg(PropertyInfo param) => !param.IsOutParam && param.TypeName == "BmSDK.FString";

    void PrintFunction(FunctionInfo func, bool isInInterface, ClassInfo? instanceOf = null)
    {
        // An instance call runs the function the object's own class declares under this name, the
        // way UnrealScript dispatches, so a subclass without a managed binding still runs its
        // override. Static and private functions can't be overridden, and keep the exact lookup.
        var dispatches = !func.IsStatic && !func.IsPrivate && instanceOf is null;

        // An interface function has a body that makes the same call, so a class needn't bind it
        // itself. A class whose own binding has the same signature replaces it.
        var self = isInInterface ? "((BmSDK.GameObject)this)" : "this";

        Line((dispatches
            ? "private static BmSDK.Framework.FunctionCache.CallSite __fn_"
            : "private static BmSDK.Function __fn_") + func.ManagedName + ";");

        Line("/// <summary>");
        Indent().Append($"/// Function: {func.Name}");
        if (instanceOf is not null)
        {
            // The extension-method form of a static native (see PrintStatics)
            _out.Append(", run on <paramref name=\"self\"/> rather than the class default object");
        }
        Endl();
        Line("/// </summary>");

        Indent().Append("public unsafe ");
        if (func.IsStatic)
        {
            _out.Append("static ");
        }
        else if (isInInterface)
        {
            _out.Append("virtual ");
        }
        else if (!func.IsPrivate)
        {
            if (func.IsOverride)
            {
                _out.Append("override ");
            }
            else
            {
                // A script function named like one of object's own methods hides it on purpose.
                if (func.Params.Count == 0 && func.ManagedName is "ToString" or "GetHashCode" or "GetType")
                {
                    _out.Append("new ");
                }
                _out.Append("virtual ");
            }
        }

        _out.Append(func.HasReturnParam ? func.ReturnParam.TypeName : "void").Append(' ');
        _out.Append(func.ManagedName).Append('(');
        if (instanceOf is not null)
        {
            _out.Append($"this {instanceOf.PackageNameManaged}.{instanceOf.ManagedName} self");
            if (func.Params.Count > 0)
            {
                _out.Append(", ");
            }
        }
        for (var i = 0; i < func.Params.Count; i++)
        {
            var param = func.Params[i];
            if (param.IsOutParam)
            {
                _out.Append("out ");
            }

            // A string passed by value is an FStringArg: the call builds the game's copy and frees
            // it afterwards (see FStringArg).
            _out.Append(IsStringArg(param) ? "BmSDK.FStringArg" : param.TypeName).Append(' ').Append(param.ManagedName);
            if (param.IsOptionalParam && !func.ShouldSuppressOptional)
            {
                _out.Append(" = default");
            }
            if (i < func.Params.Count - 1)
            {
                _out.Append(", ");
            }
        }
        _out.Append(')');
        Endl();

        Line("{");
        _indent++;

        var ptrText = instanceOf is not null ? "self.Ptr" : func.IsStatic ? "StaticClass().DefaultObject.Ptr" : isInInterface ? self + ".Ptr" : "Ptr";

        // A destroyed object's wrapper has a null Ptr. The engine would fault on it, so fail in C#.
        if (instanceOf is not null)
        {
            Line("BmSDK.Framework.Guard.NotDestroyed(self);");
        }
        else if (!func.IsStatic)
        {
            Line($"BmSDK.Framework.Guard.NotDestroyed({self});");
        }

        Line(dispatches
            ? $"var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_{func.ManagedName}, \"{func.PathName}\", {self});"
            : $"var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_{func.ManagedName}, \"{func.PathName}\");");

        // The engine 16-aligns its own parameter frames, and natives rely on it (an FQuat or FMatrix
        // return is stored with movdqa). A constant-size stackalloc is only 8-aligned, so
        // over-allocate and round the pointer up.
        Line($"byte* paramsPtr = stackalloc byte[{func.PropertiesSize + 16}];");
        Line("paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);");
        foreach (var param in func.Params)
        {
            // UnrealScript 'out' params are in/out: pass in the caller's current value. Reading a C#
            // 'out' param is legal once SkipInit marks it assigned (it never writes to it). Values
            // that own memory stay zeroed: the callee may free that memory when it reassigns the
            // param, and a C# caller doesn't expect an 'out' argument to be read.
            if (param.IsOutParam)
            {
                if (param.OwnsMemory)
                {
                    continue;
                }
                Line($"System.Runtime.CompilerServices.Unsafe.SkipInit(out {param.ManagedName});");
            }

            if (IsStringArg(param))
            {
                Line($"{param.ManagedName}.WriteTo(paramsPtr + {param.Offset});");
                continue;
            }

            Line($"BmSDK.Framework.MarshalUtil.ToUnmanaged({param.ManagedName}, paramsPtr + {param.Offset});");
        }

        // ProcessEvent would free an optional string/array argument of a script function before the
        // call runs (see OptionalParms.cs), so suspend the optional params around the call.
        var suspendsOptional = func.Params.Any(p => !func.IsNative && p.IsOptionalParam && p.OwnsMemory);
        if (suspendsOptional)
        {
            Line("var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);");
        }

        if (func.IsNative)
        {
            Line("var oldFlags = funcManaged.FunctionFlags;");
            Line("var oldNative = funcManaged.iNative;");
            Line("funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;");
            Line("funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;");
            Line("funcManaged.iNative = 0;");
        }

        Line($"BmSDK.Framework.GameFunctions.CallProcessEvent({ptrText}, funcManaged.Ptr, (nint)paramsPtr, 0);");

        if (func.IsNative)
        {
            Line("funcManaged.iNative = oldNative;");
            Line("funcManaged.FunctionFlags = oldFlags;");
        }

        if (suspendsOptional)
        {
            Line("BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);");
        }

        // The slot of a string passed by value holds the buffer to free, which is the one the
        // function left there if it assigned to the parameter.
        foreach (var param in func.Params)
        {
            if (IsStringArg(param))
            {
                Line($"BmSDK.FStringArg.FreeSlot(paramsPtr + {param.Offset});");
            }
        }

        foreach (var param in func.Params)
        {
            if (param.IsOutParam)
            {
                Line($"{param.ManagedName} = BmSDK.Framework.MarshalUtil.ToManagedParam<{param.TypeName}>(paramsPtr + {param.Offset});");
            }
        }

        Line(func.HasReturnParam
            ? $"return BmSDK.Framework.MarshalUtil.ToManagedParam<{func.ReturnParam.TypeName}>(paramsPtr + {func.ReturnParam.Offset});"
            : "return;");

        _indent--;
        Line("}");
    }

    void PrintMember(MemberInfo member, bool isInInterface)
    {
        switch (member)
        {
            case PropertyInfo prop:
                PrintProperty(prop);
                break;
            case ConstInfo c:
                PrintConst(c);
                break;
            case EnumInfo en:
                PrintEnum(en);
                break;
            case FunctionInfo func:
                PrintFunction(func, isInInterface);
                break;
            case StructInfo st:
                PrintStruct(st);
                break;
        }
    }

    public static string StaticInit(IEnumerable<ClassInfo> classes)
    {
        var p = new Printer();
        p.Line("using System.Collections.Generic;");
        p.Endl();
        p.Line("namespace BmSDK.Framework;");
        p.Endl();
        p.Line("internal static partial class StaticInit");
        p.Line("{");
        p._indent++;
        p.Line("private static Dictionary<string, Type> _classPathToManagedTypeMap = [];");
        p.Line("private static Dictionary<Type, string> _managedTypeToClassPathMap = [];");
        p.Endl();
        p.Line("public static void StaticInitClasses()");
        p.Line("{");
        p._indent++;
        foreach (var cls in classes)
        {
            var type = $"{cls.PackageNameManaged}.{cls.ManagedName}";
            p.Line($"_classPathToManagedTypeMap[\"{cls.PathName}\"] = typeof({type});");
            p.Line($"_managedTypeToClassPathMap[typeof({type})] = \"{cls.PathName}\";");
        }
        p._indent--;
        p.Line("}");
        p._indent--;
        p.Line("}");
        return p.ToString();
    }
}
