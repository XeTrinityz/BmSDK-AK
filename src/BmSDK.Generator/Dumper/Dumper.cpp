#include "pch.h"
#include "Dumper.h"
#include "Json.h"
#include "Safe.h"
#include "Runtime.h"
#include "Engine/GameFunctions.h"
#include "Engine/GameOffsets.h"
#include "Engine/UClass.h"
#include "Engine/UEnum.h"
#include "Engine/UFunction.h"
#include "Engine/UProperty.h"

#include <algorithm>
#include <atomic>
#include <cstdio>
#include <fstream>
#include <map>
#include <regex>
#include <share.h>
#include <unordered_map>
#include <unordered_set>

namespace
{
    // Offsets read straight from memory. The UObject, UField and UStruct ones match the engine
    // headers. The linker and interface offsets aren't known, so they are found at runtime.
    constexpr int ObjectHeaderSize = 84;
    constexpr int ObjectLinker = 32;
    constexpr int PropertyFlagsOffset = 96;
    constexpr int PropertyRefs = 148;
    constexpr int ClassFlagsOffset = 244;
    constexpr int ConstValue = 92;
    constexpr int MaxRaw = 2048;
    constexpr int MaxArrayItems = 512;
    constexpr int MaxStructDepth = 8;
    constexpr int ObjectCapacity = 785000;

    // Below this many free object slots the sweep collects garbage first, and stops if that
    // doesn't free enough.
    constexpr int MinHeadroom = 150000;
    constexpr int GcEvery = 40;

    std::atomic<bool> s_snapshotRequested = false;
    std::atomic<bool> s_sweepToggled = false;

    fs::path s_exeDir;
    fs::path s_outDir;
    FILE* s_log = nullptr;
    HWND s_window = nullptr;
    uintptr_t s_imageStart = 0;
    uintptr_t s_imageEnd = 0;

    // Rebuilt before each write: every live object, and each class's default object.
    unordered_set<uintptr_t> s_objects;
    unordered_map<UObject*, UObject*> s_defaults;
    vector<UClass*> s_classes;

    int s_interfacesOffset = -1;
    int s_linkerFileOffset = -1;
    map<int, int> s_interfaceHits;
    map<int, int> s_linkerHits;

    struct SweepState
    {
        bool Active = false;
        FILE* Out = nullptr;
        FILE* Journal = nullptr;
        vector<wstring> Packages;
        size_t Next = 0;
        size_t Total = 0;
        unordered_set<string> Seen;
        unordered_set<string> Versions; // path#signature of every class version written
        int SinceGc = 0;
    } s_sweep;
}

static void Log(const string& text)
{
    SYSTEMTIME t;
    GetLocalTime(&t);
    auto line = std::format("[{:02}:{:02}:{:02}] {}\n", t.wHour, t.wMinute, t.wSecond, text);
    OutputDebugStringA(line.c_str());
    if (s_log)
    {
        fputs(line.c_str(), s_log);
        fflush(s_log);
    }
}

static BOOL CALLBACK FindGameWindow(HWND hwnd, LPARAM)
{
    DWORD pid = 0;
    GetWindowThreadProcessId(hwnd, &pid);
    if (pid == GetCurrentProcessId() && IsWindowVisible(hwnd) && !GetWindow(hwnd, GW_OWNER))
    {
        s_window = hwnd;
        return FALSE;
    }
    return TRUE;
}

// The window title is the only thing the player can see while the game is busy.
static void Status(const string& text)
{
    Log(text);
    if (!s_window)
    {
        EnumWindows(FindGameWindow, 0);
    }
    if (s_window)
    {
        SetWindowTextA(s_window, ("BmSDK dumper: " + text).c_str());
    }
}

static string Narrow(const wstring& text)
{
    if (text.empty())
    {
        return {};
    }
    auto size = WideCharToMultiByte(CP_UTF8, 0, text.data(), (int)text.size(), nullptr, 0, nullptr, nullptr);
    string out(size, '\0');
    WideCharToMultiByte(CP_UTF8, 0, text.data(), (int)text.size(), out.data(), size, nullptr, nullptr);
    return out;
}

static string Stamp()
{
    SYSTEMTIME t;
    GetLocalTime(&t);
    return std::format("{:04}{:02}{:02}-{:02}{:02}{:02}", t.wYear, t.wMonth, t.wDay, t.wHour, t.wMinute, t.wSecond);
}

static bool IsObject(uintptr_t address)
{
    return address && s_objects.contains(address);
}

static int NativeSize(const UObject* obj)
{
    auto cls = (UStruct*)obj->Class;
    return cls ? cls->PropertiesSize : 0;
}

static string NameText(const FName& name)
{
    if (name.Index < 0 || name.Index >= Runtime::GNames->Num || !Runtime::GNames->ElementAt(name.Index))
    {
        return {};
    }
    return name.ToString();
}

static string ObjectRef(uintptr_t address)
{
    auto obj = (UObject*)address;
    return obj->Class->GetName() + " " + obj->GetPathName();
}

static bool ReadFString(uintptr_t address, string& out)
{
    struct
    {
        uintptr_t Data;
        int32_t Num;
        int32_t Max;
    } header;

    if (!Safe::Read(address, header))
    {
        return false;
    }
    if (header.Num == 0)
    {
        out.clear();
        return true;
    }
    if (header.Num < 0 || header.Num > 65536 || header.Max < header.Num || !header.Data)
    {
        return false;
    }

    wstring text(header.Num, L'\0');
    if (!Safe::Copy(text.data(), (void*)header.Data, header.Num * sizeof(wchar_t)))
    {
        return false;
    }
    while (!text.empty() && text.back() == L'\0')
    {
        text.pop_back();
    }
    out = Narrow(text);
    return true;
}

static bool IsInterfaceClass(uintptr_t address)
{
    auto obj = (UObject*)address;
    return obj->Class == UClass::StaticClass() &&
        ((DWORD)((UClass*)obj)->ClassFlags & (DWORD)EClassFlags::CLASS_Interface);
}

static uint64_t Mix(uint64_t hash, uint64_t value)
{
    hash ^= value;
    return hash * 0x100000001B3ull;
}

static uint64_t NameKey(const FName& name)
{
    return (uint64_t)(uint32_t)name.Index << 32 | (uint32_t)name.Number;
}

// A fingerprint of a field's layout: names, kinds, offsets, flags, sizes and what properties
// point at, all the way down. Two copies of a class from different packages differ when this does.
static uint64_t Signature(UField* field, uint64_t hash, int depth)
{
    hash = Mix(hash, NameKey(field->Name));
    hash = Mix(hash, NameKey(field->Class->Name));
    if (depth > 16)
    {
        return hash;
    }

    if (field->IsA(UProperty::StaticClass()))
    {
        auto prop = (UProperty*)field;
        uint64_t flags = 0;
        Safe::Read((uintptr_t)prop + 96, flags);
        hash = Mix(hash, flags);
        hash = Mix(hash, ((uint64_t)prop->Offset << 32) | ((uint64_t)prop->ElementSize << 16) | (uint32_t)prop->ArrayDim);

        auto size = NativeSize(prop);
        for (auto offset = 148; offset + 8 <= size && offset < 164; offset += 8)
        {
            uintptr_t value = 0;
            if (!Safe::Read((uintptr_t)prop + offset, value) || !IsObject(value))
            {
                continue;
            }
            auto target = (UObject*)value;
            hash = Mix(hash, NameKey(target->Name));
            if (target->Outer)
            {
                hash = Mix(hash, NameKey(target->Outer->Name));
            }
            if (value != (uintptr_t)prop && target->IsA(UProperty::StaticClass()))
            {
                hash = Signature((UField*)target, hash, depth + 1);
            }
        }
        if (prop->IsA(UBoolProperty::StaticClass()))
        {
            hash = Mix(hash, (uint32_t)((UBoolProperty*)prop)->BitMask);
        }
    }
    else if (field->IsA(UEnum::StaticClass()))
    {
        auto en = (UEnum*)field;
        for (auto i = 0; i < en->Names.Num; i++)
        {
            hash = Mix(hash, NameKey(en->Names.ElementAt(i)));
        }
    }
    else if (field->IsA(UStruct::StaticClass()))
    {
        auto st = (UStruct*)field;
        hash = Mix(hash, st->PropertiesSize);
        if (st->SuperStruct)
        {
            hash = Mix(hash, NameKey(st->SuperStruct->Name));
        }
        if (field->IsA(UFunction::StaticClass()))
        {
            hash = Mix(hash, (uint32_t)((UFunction*)field)->FunctionFlags);
        }
        auto count = 0;
        for (auto child = st->Children; child && count < 100000; child = child->Next, count++)
        {
            hash = Signature(child, hash, depth + 1);
        }
    }
    return hash;
}

static string VersionKey(UClass* cls, const string& path)
{
    auto hash = Mix(0xCBF29CE484222325ull, (DWORD)cls->ClassFlags);
    return std::format("{}#{:016x}", path, Signature(cls, hash, 0));
}

static void CollectLive()
{
    s_objects.clear();
    s_defaults.clear();
    s_classes.clear();
    s_objects.reserve(Runtime::GObjects->Num * 2);

    auto classClass = UClass::StaticClass();
    for (INT i = 0; i < Runtime::GObjects->Num; i++)
    {
        auto obj = Runtime::GObjects->ElementAt(i);
        if (!obj || Runtime::GObjects->ElementAt(obj->Index) != obj)
        {
            continue;
        }

        s_objects.insert((uintptr_t)obj);

        auto name = obj->GetName();
        if (name.starts_with("Default__"))
        {
            s_defaults[obj->Class] = obj;
        }
        else if (obj->Class == classClass)
        {
            s_classes.push_back((UClass*)obj);
        }
    }
}

static int CountLive()
{
    auto count = 0;
    for (INT i = 0; i < Runtime::GObjects->Num; i++)
    {
        auto obj = Runtime::GObjects->ElementAt(i);
        if (obj && Runtime::GObjects->ElementAt(obj->Index) == obj)
        {
            count++;
        }
    }
    return count;
}

static int BestOffset(const map<int, int>& hits, int minHits)
{
    auto best = -1;
    auto bestHits = minHits - 1;
    for (auto& [offset, count] : hits)
    {
        if (count > bestHits)
        {
            best = offset;
            bestHits = count;
        }
    }
    return best;
}

// UClass holds its interfaces in a TArray of {UClass*, UProperty*}. Look for the one offset where
// that array, across many classes, only ever points at interface classes.
static void ProbeInterfaces()
{
    s_interfaceHits.clear();
    int classSize = ((UStruct*)UClass::StaticClass())->PropertiesSize;
    if (classSize <= ClassFlagsOffset)
    {
        classSize = 1024;
    }

    for (auto cls : s_classes)
    {
        auto base = (uintptr_t)cls;
        for (auto offset = ClassFlagsOffset + 4; offset + 16 <= classSize; offset += 4)
        {
            struct
            {
                uintptr_t Data;
                int32_t Num;
                int32_t Max;
            } arr;

            if (!Safe::Read(base + offset, arr) || arr.Num < 1 || arr.Num > 32 || arr.Max < arr.Num ||
                arr.Max > 256 || !arr.Data)
            {
                continue;
            }

            auto ok = true;
            for (auto i = 0; i < arr.Num && ok; i++)
            {
                uintptr_t entry = 0;
                ok = Safe::Read(arr.Data + i * 16, entry) && IsObject(entry) && IsInterfaceClass(entry);
            }

            if (ok)
            {
                s_interfaceHits[offset]++;
            }
        }
    }

    s_interfacesOffset = BestOffset(s_interfaceHits, 3);
}

// Find where a linker keeps the file it loaded from. Linkers are often gone once loading
// finishes, so this can come up empty.
static void ProbeLinkerFile()
{
    s_linkerHits.clear();
    unordered_set<uintptr_t> linkers;
    for (auto cls : s_classes)
    {
        uintptr_t linker = 0;
        if (Safe::Read((uintptr_t)cls + ObjectLinker, linker) && linker)
        {
            linkers.insert(linker);
        }
        if (linkers.size() >= 300)
        {
            break;
        }
    }

    for (auto linker : linkers)
    {
        for (auto offset = ObjectHeaderSize; offset + 16 <= 0x800; offset += 4)
        {
            string text;
            if (!ReadFString(linker + offset, text) || text.size() < 5)
            {
                continue;
            }

            std::transform(text.begin(), text.end(), text.begin(), ::tolower);
            if (text.ends_with(".upk") || text.ends_with(".u"))
            {
                s_linkerHits[offset]++;
            }
        }
    }

    s_linkerFileOffset = BestOffset(s_linkerHits, 3);
}

static string LinkerFile(const UObject* obj)
{
    uintptr_t linker = 0;
    string text;
    if (s_linkerFileOffset < 0 || !Safe::Read((uintptr_t)obj + ObjectLinker, linker) || !linker ||
        !ReadFString(linker + s_linkerFileOffset, text))
    {
        return {};
    }

    auto file = fs::path(text).stem().string();
    return file;
}

static void WriteHits(JsonWriter& w, const map<int, int>& hits)
{
    w.BeginObject();
    for (auto& [offset, count] : hits)
    {
        w.Key(to_string(offset)).Int(count);
    }
    w.EndObject();
}

static void WriteRaw(JsonWriter& w, const UObject* obj)
{
    static const char digits[] = "0123456789abcdef";
    auto base = (uintptr_t)obj;

    uintptr_t vtable = 0;
    w.Key("vt");
    if (Safe::Read(base, vtable) && vtable >= s_imageStart && vtable < s_imageEnd)
    {
        w.Hex(vtable - s_imageStart);
    }
    else
    {
        w.Null();
    }

    auto size = (std::min)(NativeSize(obj), MaxRaw);
    if (size <= ObjectHeaderSize)
    {
        return;
    }

    vector<uint8_t> bytes(size);
    if (!Safe::Copy(bytes.data(), obj, size))
    {
        return;
    }

    string hex;
    hex.reserve((size - ObjectHeaderSize) * 2);
    for (auto i = ObjectHeaderSize; i < size; i++)
    {
        hex += digits[bytes[i] >> 4];
        hex += digits[bytes[i] & 15];
    }
    w.Key("raw").Str(hex);

    // Every 8 bytes that point at a live object or into the game's code, at any 4-byte step
    w.Key("ptrs").BeginArray();
    for (auto offset = ObjectHeaderSize; offset + 8 <= size; offset += 4)
    {
        uint64_t value = 0;
        memcpy(&value, &bytes[offset], 8);
        if (IsObject(value))
        {
            w.BeginArray();
            w.Int(offset);
            w.Str(ObjectRef(value));
            w.EndArray();
        }
        else if (value >= s_imageStart && value < s_imageEnd)
        {
            w.BeginArray();
            w.Int(offset);
            w.Str(std::format("rva:0x{:X}", value - s_imageStart));
            w.EndArray();
        }
    }
    w.EndArray();
}

static void WriteValue(JsonWriter& w, UProperty* prop, uintptr_t address, int depth);

static void WriteStructValue(JsonWriter& w, UStruct* st, uintptr_t address, int depth)
{
    if (!st || depth > MaxStructDepth)
    {
        w.Null();
        return;
    }

    vector<UStruct*> chain;
    for (auto s = st; s; s = s->SuperStruct)
    {
        chain.insert(chain.begin(), s);
    }

    w.BeginObject();
    for (auto s : chain)
    {
        for (auto field = s->Children; field; field = field->Next)
        {
            if (field->IsA(UProperty::StaticClass()))
            {
                auto member = (UProperty*)field;
                w.Key(member->GetName());
                WriteValue(w, member, address + member->Offset, depth + 1);
            }
        }
    }
    w.EndObject();
}

static void WriteOneValue(JsonWriter& w, UProperty* prop, uintptr_t address, int depth)
{
    auto type = prop->Class->GetName();

    if (type == "IntProperty")
    {
        int32_t v;
        Safe::Read(address, v) ? w.Int(v) : w.Null();
    }
    else if (type == "FloatProperty")
    {
        float v;
        Safe::Read(address, v) ? w.Float(v) : w.Null();
    }
    else if (type == "ByteProperty")
    {
        uint8_t v;
        Safe::Read(address, v) ? w.Int(v) : w.Null();
    }
    else if (type == "BoolProperty")
    {
        uint32_t v;
        Safe::Read(address, v) ? w.Bool(v & (uint32_t)((UBoolProperty*)prop)->BitMask) : w.Null();
    }
    else if (type == "NameProperty")
    {
        FName v;
        Safe::Read(address, v) ? w.Str(NameText(v)) : w.Null();
    }
    else if (type == "StrProperty")
    {
        string v;
        ReadFString(address, v) ? w.Str(v) : w.Null();
    }
    else if (type == "ObjectProperty" || type == "ClassProperty" || type == "ComponentProperty" ||
        type == "InterfaceProperty")
    {
        uintptr_t v = 0;
        if (!Safe::Read(address, v) || !v)
        {
            w.Null();
        }
        else if (IsObject(v))
        {
            w.Str(((UObject*)v)->GetPathName());
        }
        else
        {
            w.Str(std::format("bad:0x{:X}", v));
        }
    }
    else if (type == "DelegateProperty")
    {
        struct
        {
            uintptr_t Object;
            FName Function;
        } v;

        if (!Safe::Read(address, v))
        {
            w.Null();
            return;
        }

        w.BeginObject();
        w.Key("obj");
        IsObject(v.Object) ? w.Str(((UObject*)v.Object)->GetPathName()) : w.Null();
        w.Key("func").Str(NameText(v.Function));
        w.EndObject();
    }
    else if (type == "StructProperty")
    {
        UStruct* st = nullptr;
        Safe::Read((uintptr_t)prop + PropertyRefs, st);
        WriteStructValue(w, IsObject((uintptr_t)st) ? st : nullptr, address, depth);
    }
    else if (type == "ArrayProperty")
    {
        struct
        {
            uintptr_t Data;
            int32_t Num;
            int32_t Max;
        } arr;

        UProperty* inner = nullptr;
        if (!Safe::Read(address, arr) || !Safe::Read((uintptr_t)prop + PropertyRefs, inner) ||
            !IsObject((uintptr_t)inner) || arr.Num < 0 || arr.Num > 1000000 || depth > MaxStructDepth)
        {
            w.Null();
            return;
        }

        auto count = (std::min)(arr.Num, MaxArrayItems);
        w.BeginArray();
        for (auto i = 0; i < count; i++)
        {
            WriteValue(w, inner, arr.Data + (uintptr_t)i * inner->ElementSize, depth + 1);
        }
        if (arr.Num > count)
        {
            w.Str(std::format("...{} more", arr.Num - count));
        }
        w.EndArray();
    }
    else
    {
        w.Null();
    }
}

static void WriteValue(JsonWriter& w, UProperty* prop, uintptr_t address, int depth)
{
    if (prop->ArrayDim <= 1)
    {
        WriteOneValue(w, prop, address, depth);
        return;
    }

    w.BeginArray();
    for (auto i = 0; i < prop->ArrayDim; i++)
    {
        WriteOneValue(w, prop, address + (uintptr_t)i * prop->ElementSize, depth);
    }
    w.EndArray();
}

static void WriteSuper(JsonWriter& w, UStruct* st)
{
    w.Key("super");
    st->SuperStruct ? w.Str(st->SuperStruct->GetPathName()) : w.Null();
}

static void WriteField(JsonWriter& w, UField* field);

static void WriteFields(JsonWriter& w, UStruct* st)
{
    w.Key("fields").BeginArray();
    auto count = 0;
    for (auto field = st->Children; field && count < 100000; field = field->Next, count++)
    {
        WriteField(w, field);
    }
    w.EndArray();
}

static void WriteProperty(JsonWriter& w, UProperty* prop)
{
    w.BeginObject();
    w.Key("k").Str("prop");
    w.Key("name").Str(prop->GetName());
    w.Key("type").Str(prop->Class->GetName());
    w.Key("dim").Int(prop->ArrayDim);

    uint64_t flags = 0;
    Safe::Read((uintptr_t)prop + PropertyFlagsOffset, flags);
    w.Key("flags").Hex(flags);
    w.Key("esz").Int(prop->ElementSize);
    w.Key("off").Int(prop->Offset);

    if (prop->IsA(UBoolProperty::StaticClass()))
    {
        w.Key("mask").Hex((uint32_t)((UBoolProperty*)prop)->BitMask);
    }

    // What the subclass points at: struct, class, inner property, enum, meta class, key/value,
    // or delegate signature.
    w.Key("refs").BeginArray();
    auto size = NativeSize(prop);
    for (auto offset = PropertyRefs; offset + 8 <= size && offset < PropertyRefs + 16; offset += 8)
    {
        uintptr_t value = 0;
        if (Safe::Read((uintptr_t)prop + offset, value) && IsObject(value))
        {
            w.BeginArray();
            w.Int(offset);
            w.Str(ObjectRef(value));
            w.EndArray();
        }
    }
    w.EndArray();

    // Array inners and map keys/values are properties of their own, outside any Children list.
    w.Key("sub").BeginArray();
    for (auto offset = PropertyRefs; offset + 8 <= size && offset < PropertyRefs + 16; offset += 8)
    {
        uintptr_t value = 0;
        if (Safe::Read((uintptr_t)prop + offset, value) && IsObject(value) && value != (uintptr_t)prop &&
            ((UObject*)value)->IsA(UProperty::StaticClass()))
        {
            WriteProperty(w, (UProperty*)value);
        }
    }
    w.EndArray();

    WriteRaw(w, prop);
    w.EndObject();
}

// A script struct keeps its default values in a byte array the size of the struct, somewhere past
// the UStruct part.
static void WriteStructDefaults(JsonWriter& w, UStruct* st)
{
    auto size = NativeSize(st);
    for (auto offset = 164; offset + 16 <= size; offset += 4)
    {
        struct
        {
            uintptr_t Data;
            int32_t Num;
            int32_t Max;
        } arr;

        if (Safe::Read((uintptr_t)st + offset, arr) && arr.Data && arr.Num > 0 && arr.Num == st->PropertiesSize &&
            arr.Max >= arr.Num)
        {
            w.Key("defaultsOffset").Int(offset);
            w.Key("defaults");
            WriteStructValue(w, st, arr.Data, 0);
            return;
        }
    }
}

static void WriteField(JsonWriter& w, UField* field)
{
    if (field->IsA(UProperty::StaticClass()))
    {
        WriteProperty(w, (UProperty*)field);
        return;
    }

    auto kind = field->Class->GetName();
    w.BeginObject();
    w.Key("name").Str(field->GetName());

    if (kind == "Function")
    {
        auto func = (UFunction*)field;
        w.Key("k").Str("func");
        w.Key("flags").Hex((uint32_t)func->FunctionFlags);
        WriteSuper(w, func);
        w.Key("size").Int(func->PropertiesSize);
        WriteRaw(w, func);
        WriteFields(w, func);
    }
    else if (kind == "State")
    {
        auto state = (UStruct*)field;
        w.Key("k").Str("state");
        WriteSuper(w, state);
        w.Key("size").Int(state->PropertiesSize);
        WriteRaw(w, state);
        WriteFields(w, state);
    }
    else if (kind == "ScriptStruct")
    {
        auto st = (UStruct*)field;
        w.Key("k").Str("struct");
        WriteSuper(w, st);
        w.Key("size").Int(st->PropertiesSize);
        w.Key("align").Int(st->MinAlignment);
        WriteStructDefaults(w, st);
        WriteRaw(w, st);
        WriteFields(w, st);
    }
    else if (kind == "Enum")
    {
        auto en = (UEnum*)field;
        w.Key("k").Str("enum");
        w.Key("names").BeginArray();
        for (auto i = 0; i < en->Names.Num; i++)
        {
            w.Str(NameText(en->Names.ElementAt(i)));
        }
        w.EndArray();
    }
    else if (kind == "Const")
    {
        string value;
        w.Key("k").Str("const");
        w.Key("value");
        ReadFString((uintptr_t)field + ConstValue, value) ? w.Str(value) : w.Null();
        WriteRaw(w, field);
    }
    else
    {
        w.Key("k").Str("other");
        w.Key("type").Str(kind);
        WriteRaw(w, field);
    }

    w.EndObject();
}

static void WriteDefaults(JsonWriter& w, UClass* cls)
{
    auto it = s_defaults.find(cls);
    if (it == s_defaults.end())
    {
        w.Null();
        return;
    }

    auto cdo = (uintptr_t)it->second;
    w.BeginObject();
    w.Key("_object").Str(it->second->GetPathName());
    for (auto field = cls->Children; field; field = field->Next)
    {
        if (!field->IsA(UProperty::StaticClass()))
        {
            continue;
        }

        auto prop = (UProperty*)field;
        if (prop->Offset + prop->ElementSize * prop->ArrayDim > cls->PropertiesSize)
        {
            continue;
        }

        w.Key(prop->GetName());
        WriteValue(w, prop, cdo + prop->Offset, 0);
    }
    w.EndObject();
}

static void WriteClass(JsonWriter& w, UClass* cls, const string& source)
{
    w.BeginObject();
    w.Key("t").Str("class");
    w.Key("path").Str(cls->GetPathName());
    w.Key("package").Str(cls->GetPackageName());

    auto file = LinkerFile(cls);
    w.Key("file");
    file.empty() ? w.Null() : w.Str(file);
    w.Key("src");
    source.empty() ? w.Null() : w.Str(source);

    WriteSuper(w, cls);
    w.Key("flags").Hex((DWORD)cls->ClassFlags);
    w.Key("size").Int(cls->PropertiesSize);
    w.Key("align").Int(cls->MinAlignment);

    w.Key("interfaces").BeginArray();
    struct
    {
        uintptr_t Data;
        int32_t Num;
        int32_t Max;
    } arr;
    if (s_interfacesOffset >= 0 && Safe::Read((uintptr_t)cls + s_interfacesOffset, arr) && arr.Num > 0 &&
        arr.Num <= 64)
    {
        for (auto i = 0; i < arr.Num; i++)
        {
            uintptr_t entry = 0;
            if (Safe::Read(arr.Data + i * 16, entry) && IsObject(entry))
            {
                w.Str(((UObject*)entry)->GetPathName());
            }
        }
    }
    w.EndArray();

    WriteRaw(w, cls);
    WriteFields(w, cls);
    w.Key("defaults");
    WriteDefaults(w, cls);
    w.EndObject();
}

static void Emit(FILE* file, JsonWriter& w)
{
    w.Buf += '\n';
    fwrite(w.Buf.data(), 1, w.Buf.size(), file);
    w.Clear();
}

static void WriteMeta(FILE* file, const string& label)
{
    static const char* coreClasses[] = {"Core.Object", "Core.Field", "Core.Struct", "Core.ScriptStruct",
        "Core.Function", "Core.State", "Core.Class", "Core.Enum", "Core.Const", "Core.Property",
        "Core.ByteProperty", "Core.IntProperty", "Core.BoolProperty", "Core.FloatProperty",
        "Core.ObjectProperty", "Core.ComponentProperty", "Core.ClassProperty", "Core.InterfaceProperty",
        "Core.NameProperty", "Core.StrProperty", "Core.ArrayProperty", "Core.MapProperty",
        "Core.StructProperty", "Core.DelegateProperty", "Core.Package", "Core.Linker", "Core.LinkerLoad",
        "Core.TextBuffer", "Core.Component", "Core.Subsystem", "Core.System"};

    JsonWriter w;
    w.BeginObject();
    w.Key("t").Str("meta");
    w.Key("label").Str(label);
    w.Key("time").Str(Stamp());
    w.Key("build").Str(GameOffsets::GObjects == 0x347ACA4 ? "epic" : "steam");
    w.Key("imageSize").Hex(s_imageEnd - s_imageStart);
    w.Key("objects").Int((int64_t)s_objects.size());
    w.Key("capacity").Int(ObjectCapacity);
    w.Key("classes").Int((int64_t)s_classes.size());
    w.Key("interfacesOffset").Int(s_interfacesOffset);
    w.Key("interfaceHits");
    WriteHits(w, s_interfaceHits);
    w.Key("linkerFileOffset").Int(s_linkerFileOffset);
    w.Key("linkerFileHits");
    WriteHits(w, s_linkerHits);

    w.Key("sizes").BeginObject();
    for (auto path : coreClasses)
    {
        auto cls = UObject::FindClass(path);
        if (cls)
        {
            w.Key(path).Int(((UStruct*)cls)->PropertiesSize);
        }
    }
    w.EndObject();
    w.EndObject();
    Emit(file, w);
}

static FILE* OpenOutput(const string& prefix)
{
    auto path = s_outDir / (prefix + "-" + Stamp() + ".jsonl");
    auto file = _wfsopen(path.c_str(), L"wb", _SH_DENYNO);
    if (file)
    {
        setvbuf(file, nullptr, _IOFBF, 4 << 20);
        Log("Writing " + path.string());
    }
    else
    {
        Log("Couldn't open " + path.string());
    }
    return file;
}

static void Snapshot()
{
    Status("taking a snapshot...");
    CollectLive();
    ProbeInterfaces();
    ProbeLinkerFile();

    auto file = OpenOutput("snapshot");
    if (!file)
    {
        Status("snapshot failed, see dumper.log");
        return;
    }

    WriteMeta(file, "snapshot");
    JsonWriter w;
    for (auto cls : s_classes)
    {
        WriteClass(w, cls, "");
        Emit(file, w);
    }
    fclose(file);

    Status(std::format("snapshot done, {} classes, interfaces at {}, linker file at {}", s_classes.size(),
        s_interfacesOffset, s_linkerFileOffset));
}

// Packages that never hold script classes, or are always loaded.
static bool SkipPackage(const wstring& name)
{
    static const wregex skip(
        L"^(Core|Engine|GameFramework|IpDrv|WinDrv|GFxUI|AkAudio|BmGame|BmScript|OnlineSubsystem.*|Startup.*|"
        L"Frontend.*|GlobalPersistentCookerData|GuidCache.*|.*ShaderCache.*|Dlg-.*|WwSpch-.*|LH-.*|Tape.*|"
        L"Synopsis.*|Gallery.*|BARKSET.*|BarkCharDef.*|Wheel_MW_.*|Anim_.*|Bio_.*|CS_.*|CV_.*)$",
        regex_constants::icase);
    return regex_match(name, skip);
}

static vector<wstring> ListPackages()
{
    auto root = s_exeDir.parent_path().parent_path();
    map<wstring, wstring> byLower;

    auto add = [&](const fs::path& dir, bool recursive) {
        error_code ec;
        auto visit = [&](const fs::directory_entry& entry) {
            if (!entry.is_regular_file(ec))
            {
                return;
            }
            auto ext = entry.path().extension().wstring();
            std::transform(ext.begin(), ext.end(), ext.begin(), ::towlower);
            if (ext != L".upk")
            {
                return;
            }
            auto name = entry.path().stem().wstring();
            if (SkipPackage(name))
            {
                return;
            }
            auto lower = name;
            std::transform(lower.begin(), lower.end(), lower.begin(), ::towlower);
            byLower.emplace(lower, name);
        };

        if (recursive)
        {
            for (auto it = fs::recursive_directory_iterator(dir, fs::directory_options::skip_permission_denied, ec);
                !ec && it != fs::recursive_directory_iterator(); it.increment(ec))
            {
                visit(*it);
            }
        }
        else
        {
            for (auto it = fs::directory_iterator(dir, ec); !ec && it != fs::directory_iterator(); it.increment(ec))
            {
                visit(*it);
            }
        }
    };

    add(root / "BmGame" / "CookedPCConsole", false);
    add(root / "DLC", true);

    vector<wstring> names;
    for (auto& [lower, name] : byLower)
    {
        names.push_back(name);
    }
    return names;
}

// The journal says which packages are done. A package that was started but never finished took
// the game down, so it's skipped from then on.
static unordered_set<wstring> ReadJournal(const fs::path& path)
{
    unordered_set<wstring> done;
    wifstream in(path);
    wstring line, started;
    while (getline(in, line))
    {
        auto tab = line.find(L'\t');
        auto next = line.find(L'\t', tab + 1);
        if (tab == wstring::npos)
        {
            continue;
        }
        auto verb = line.substr(0, tab);
        auto name = line.substr(tab + 1, next == wstring::npos ? wstring::npos : next - tab - 1);
        if (verb == L"begin")
        {
            started = name;
        }
        else
        {
            done.insert(name);
            if (name == started)
            {
                started.clear();
            }
        }
    }

    if (!started.empty())
    {
        done.insert(started);
        Log("The last sweep crashed while loading " + Narrow(started) + ", skipping it");
        ofstream(path, ios::app) << "crash\t" << Narrow(started) << "\n";
    }
    return done;
}

static void StopSweep(const string& why)
{
    if (s_sweep.Out)
    {
        fclose(s_sweep.Out);
    }
    if (s_sweep.Journal)
    {
        fclose(s_sweep.Journal);
    }
    s_sweep = SweepState{};
    Status(why);
}

static void StartSweep()
{
    auto journalPath = s_outDir / "sweep.journal";
    auto done = ReadJournal(journalPath);

    s_sweep = SweepState{};
    for (auto& name : ListPackages())
    {
        if (!done.contains(name))
        {
            s_sweep.Packages.push_back(name);
        }
    }
    s_sweep.Total = s_sweep.Packages.size();
    Log(std::format("Sweep: {} packages left, {} done before", s_sweep.Total, done.size()));

    if (s_sweep.Packages.empty())
    {
        Status("sweep already finished. Delete BmSDKDump\\sweep.journal to run it again");
        return;
    }

    s_sweep.Out = OpenOutput("sweep");
    s_sweep.Journal = _wfsopen(journalPath.c_str(), L"ab", _SH_DENYNO);
    if (!s_sweep.Out || !s_sweep.Journal)
    {
        StopSweep("sweep failed to open its files, see dumper.log");
        return;
    }

    // Start with what's already loaded
    CollectLive();
    ProbeInterfaces();
    ProbeLinkerFile();
    WriteMeta(s_sweep.Out, "sweep");
    JsonWriter w;
    for (auto cls : s_classes)
    {
        auto path = cls->GetPathName();
        s_sweep.Seen.insert(path);
        s_sweep.Versions.insert(VersionKey(cls, path));
        WriteClass(w, cls, "");
        Emit(s_sweep.Out, w);
    }
    fflush(s_sweep.Out);
    s_sweep.Active = true;
    Status(std::format("sweep started, {} packages to go", s_sweep.Total));
}

static bool CollectGarbage()
{
    DWORD code = 0;
    s_sweep.SinceGc = 0;
    if (!Safe::CollectGarbage(&code))
    {
        Log(std::format("Garbage collection faulted with 0x{:X}", code));
        return false;
    }
    return true;
}

static void StepSweep()
{
    if (s_sweep.Next >= s_sweep.Packages.size())
    {
        StopSweep(std::format("sweep finished, {} classes in total", s_sweep.Seen.size()));
        return;
    }

    auto headroom = ObjectCapacity - CountLive();
    if (headroom < MinHeadroom || s_sweep.SinceGc >= GcEvery)
    {
        // After a fault the engine can't be trusted, so stop and let a fresh game carry on.
        if (!CollectGarbage())
        {
            StopSweep("garbage collection faulted. Restart the game and press Ctrl+Shift+L to carry on");
            return;
        }
        headroom = ObjectCapacity - CountLive();
        if (headroom < MinHeadroom)
        {
            StopSweep(std::format("object table nearly full ({} free). Restart the game and press Ctrl+Shift+L to carry on", headroom));
            return;
        }
    }

    auto name = s_sweep.Packages[s_sweep.Next++];
    auto nameNarrow = Narrow(name);
    Status(std::format("sweep {}/{} {}", s_sweep.Next, s_sweep.Total, nameNarrow));

    fputs(("begin\t" + nameNarrow + "\n").c_str(), s_sweep.Journal);
    fflush(s_sweep.Journal);

    // A load can garbage collect part way through, which BeginLoad/EndLoad holds off.
    void* package = nullptr;
    DWORD code = 0;
    GameFunctions::BeginLoad();
    auto ok = Safe::LoadPackage(name.c_str(), &package, &code);
    GameFunctions::EndLoad();
    s_sweep.SinceGc++;

    CollectLive();
    if (s_interfacesOffset < 0)
    {
        ProbeInterfaces();
    }
    if (s_linkerFileOffset < 0)
    {
        ProbeLinkerFile();
    }

    // A class already seen can come back from this package as a different copy once the earlier
    // one was collected, so every loaded class is checked again.
    JsonWriter w;
    vector<string> added;
    vector<string> versions;
    for (auto cls : s_classes)
    {
        auto path = cls->GetPathName();
        if (!s_sweep.Versions.insert(VersionKey(cls, path)).second)
        {
            continue;
        }

        (s_sweep.Seen.insert(path).second ? added : versions).push_back(path);
        WriteClass(w, cls, nameNarrow);
        Emit(s_sweep.Out, w);
    }

    w.BeginObject();
    w.Key("t").Str("package");
    w.Key("name").Str(nameNarrow);
    w.Key("ok").Bool(ok);
    w.Key("loaded").Bool(package != nullptr);
    w.Key("code").Hex(code);
    w.Key("objects").Int((int64_t)s_objects.size());
    w.Key("added").BeginArray();
    for (auto& path : added)
    {
        w.Str(path);
    }
    w.EndArray();
    w.Key("versions").BeginArray();
    for (auto& path : versions)
    {
        w.Str(path);
    }
    w.EndArray();
    w.EndObject();
    Emit(s_sweep.Out, w);
    fflush(s_sweep.Out);

    auto result = ok ? std::format("end\t{}\t{}\n", nameNarrow, added.size())
                     : std::format("fail\t{}\t0x{:X}\n", nameNarrow, code);
    fputs(result.c_str(), s_sweep.Journal);
    fflush(s_sweep.Journal);

    if (!ok)
    {
        Log(std::format("{} faulted with 0x{:X}", nameNarrow, code));
        StopSweep(nameNarrow + " faulted and will be skipped. Restart the game and press Ctrl+Shift+L to carry on");
        return;
    }
    else if (!added.empty() || !versions.empty())
    {
        Log(std::format("{}: {} new classes, {} other versions", nameNarrow, added.size(), versions.size()));
    }
}

void Dumper::Init()
{
    wchar_t exePath[MAX_PATH];
    GetModuleFileNameW(nullptr, exePath, MAX_PATH);
    s_exeDir = fs::path(exePath).parent_path();
    s_outDir = s_exeDir / "BmSDKDump";
    fs::create_directories(s_outDir);
    s_log = _wfsopen((s_outDir / "dumper.log").c_str(), L"ab", _SH_DENYNO);

    auto dos = (PIMAGE_DOS_HEADER)Runtime::BaseAddress;
    auto nt = (PIMAGE_NT_HEADERS64)(Runtime::BaseAddress + dos->e_lfanew);
    s_imageStart = Runtime::BaseAddress;
    s_imageEnd = Runtime::BaseAddress + nt->OptionalHeader.SizeOfImage;

    Log("Dumper ready. Ctrl+Shift+O takes a snapshot, Ctrl+Shift+L starts or pauses the package sweep");
}

void Dumper::RequestSnapshot()
{
    s_snapshotRequested = true;
}

void Dumper::ToggleSweep()
{
    s_sweepToggled = true;
}

void Dumper::Tick()
{
    if (s_snapshotRequested.exchange(false))
    {
        if (s_sweep.Active)
        {
            Log("Snapshot skipped, the sweep is running");
        }
        else
        {
            Snapshot();
        }
    }

    if (s_sweepToggled.exchange(false))
    {
        if (s_sweep.Active)
        {
            StopSweep("sweep paused. Ctrl+Shift+L carries on");
        }
        else
        {
            StartSweep();
        }
    }

    if (s_sweep.Active)
    {
        StepSweep();
    }
}
