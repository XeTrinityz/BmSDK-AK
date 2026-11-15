using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Security.Cryptography;
using System.Text;
using BmSDK.Framework.Redirection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;
using ReferenceAssemblies = Basic.Reference.Assemblies;

namespace BmSDK.Framework;

/// <summary>
/// Provides the plugin loading system--compilation and instantiation of user scripts,
/// organized as individual mods with per-mod hot reload.
/// </summary>
internal static class ScriptManager
{
    public const LanguageVersion LangVer = LanguageVersion.CSharp14;
    public static readonly CSharpParseOptions ParseOptions = CSharpParseOptions
        .Default.WithLanguageVersion(LangVer)
        .WithPreprocessorSymbols("BATMAN4");
    public static readonly ImmutableArray<PortableExecutableReference> DotNetAssemblies =
        ReferenceAssemblies.Net100.References.All;
    public static readonly ImmutableList<MetadataReference> MetadataReferences =
    [
        .. DotNetAssemblies,
        // MoreLINQ.dll
        MetadataReference.CreateFromFile(typeof(MoreLinq.MoreEnumerable).Assembly.Location),
        // BmSDK.dll
        MetadataReference.CreateFromFile(typeof(GameObject).Assembly.Location),
        // Tomlyn.dll
        MetadataReference.CreateFromFile(typeof(Tomlyn.TomlSerializer).Assembly.Location),
    ];
    public const string GlobalUsings = """
        global using global::System;
        global using global::System.Collections.Generic;
        global using global::System.IO;
        global using global::System.Linq;
        global using global::System.Net.Http;
        global using global::System.Threading;
        global using global::System.Threading.Tasks;

        global using global::BmSDK.Framework;
        global using global::Tomlyn.Model;
        """;
    public const string GlobalUsingsPath = "Scripts.GlobalUsings.g.cs";
    public static readonly SyntaxTree GlobalUsingsTree = CSharpSyntaxTree.ParseText(
        SourceText.From(GlobalUsings, Encoding.UTF8),
        ParseOptions,
        GlobalUsingsPath
    );
    public static readonly CSharpCompilationOptions CompilerOptions = new(
        OutputKind.DynamicallyLinkedLibrary,
        platform: Platform.X64,
        allowUnsafe: true
    );

    private record LoadedMod(Mod Mod, AssemblyLoadContext Alc, List<Script> Scripts);

    private sealed class ScriptLoadContext(string name)
        : AssemblyLoadContext(name, isCollectible: true)
    {
        private static readonly AssemblyLoadContext s_hostAlc = GetLoadContext(
            typeof(GameObject).Assembly
        )!;

        protected override Assembly? Load(AssemblyName assemblyName)
        {
            return s_hostAlc.Assemblies.FirstOrDefault(asm =>
                asm.GetName().Name == assemblyName.Name
            );
        }
    }

    private static readonly Dictionary<string, LoadedMod> s_loadedMods = [];
    private static readonly Dictionary<string, Timer> s_debounceTimers = [];
    private static readonly Lock s_lockObj = new();

    private const int DebounceMillis = 500;

    // Every loaded script, rebuilt when a mod loads or unloads. The tick, draw and key callbacks walk
    // it every frame, and an array is walked without allocating.
    private static Script[] s_scripts = [];

    public static Script[] Scripts => s_scripts;

    private static void RebuildScripts() => s_scripts = [.. s_loadedMods.Values.SelectMany(m => m.Scripts)];

    public static IEnumerable<Mod> Mods => s_loadedMods.Values.Select(m => m.Mod);

    private static bool s_isInitialized = false;

    /// <summary>
    /// Initializes the script system and begins monitoring for script changes.
    /// </summary>
    public static void Init()
    {
        if (s_isInitialized)
        {
            return;
        }

        PrepareCompilation();
        LoadAllMods();
        WatchForChanges();
        s_isInitialized = true;
    }

    private static void PrepareCompilation()
    {
        AppDomain.CurrentDomain.AssemblyResolve += (sender, e) =>
            AppDomain
                .CurrentDomain.GetAssemblies()
                .ToList()
                .FirstOrDefault(asm => asm.GetName().ToString() == e.Name);
    }

    private static void LoadAllMods()
    {
        var modsDir = FileUtils.GetModsPath();
        var scriptsDir = FileUtils.GetScriptsPath();
        var jobs = new List<(Mod Mod, string ScriptsDir, string What)>();

        // Implicit "Scripts" mod from BmGame/Scripts/
        if (Directory.Exists(scriptsDir))
        {
            jobs.Add((Mod.CreateDefault(scriptsDir), scriptsDir, "loose scripts"));
        }

        // Explicit mods from BmGame/Mods/*/
        if (Directory.Exists(modsDir))
        {
            foreach (var modDir in Directory.EnumerateDirectories(modsDir))
            {
                if (!File.Exists(Path.Combine(modDir, "mod.toml")))
                {
                    continue;
                }

                try
                {
                    jobs.Add((Mod.FromDirectory(modDir), Path.Combine(modDir, "scripts"), $"mod at {Path.GetFileName(modDir)}"));
                }
                catch (Exception e)
                {
                    Debug.LogError($"Failed to load mod at {Path.GetFileName(modDir)}: {e.Message}");
                }
            }
        }

        // Compiling is the slow part of starting up and each mod's is its own, so they run side by side.
        // The mods are still loaded one by one, in the same order as before.
        var compiled = new (MemoryStream? Pe, MemoryStream? Pdb)[jobs.Count];
        Parallel.For(0, jobs.Count, i =>
        {
            try
            {
                compiled[i] = CompileMod(jobs[i].Mod, jobs[i].ScriptsDir);
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to load {jobs[i].What}: {e.Message}");
            }
        });

        for (var i = 0; i < jobs.Count; i++)
        {
            if (compiled[i] is { Pe: { } pe, Pdb: { } pdb })
            {
                try
                {
                    LoadCompiled(jobs[i].Mod, pe, pdb);
                }
                catch (Exception e)
                {
                    Debug.LogError($"Failed to load {jobs[i].What}: {e.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Compiles and loads a single mod.
    /// </summary>
    private static bool LoadMod(Mod mod, string scriptsDir)
    {
        var (peStream, pdbStream) = CompileMod(mod, scriptsDir);
        if (peStream == null || pdbStream == null)
        {
            return false;
        }

        LoadCompiled(mod, peStream, pdbStream);
        return true;
    }

    /// <summary>
    /// Loads a mod's compiled assembly and starts its scripts on the engine thread.
    /// </summary>
    private static void LoadCompiled(Mod mod, MemoryStream peStream, MemoryStream pdbStream)
    {
        var targetName = $"{mod.Name}.dll";
        var modAlc = new ScriptLoadContext(targetName);
        var asm = modAlc.LoadFromStream(peStream, pdbStream);

        EngineSynchronizationContext.Instance.Post(
            _ =>
            {
                // If reloading, unload old version first
                if (s_loadedMods.TryGetValue(mod.DirectoryPath, out var oldMod))
                {
                    UnloadMod(oldMod);
                }

                var scripts = CreateScriptInstances(asm, mod);
                var loaded = new LoadedMod(mod, modAlc, scripts);
                s_loadedMods[mod.DirectoryPath] = loaded;
                RebuildScripts();

                RedirectManager.Global.RegisterRedirectors(asm);
                ScriptComponentManager.RegisterTypes(asm);

                if (s_isInitialized)
                {
                    ModGuard.Reset();
                    RedirectManager.ConfigureAllRedirectedFunctions();
                    ScriptComponentManager.AutoAttachTypesToExistingObjs();
                    scripts.ForEach(script => ModGuard.Run(script, script.Name, "OnLoad", script.OnLoad));
                }
            },
            state: null
        );
    }

    /// <summary>
    /// Unloads a single mod, removing its scripts, components, and redirectors.
    /// </summary>
    private static void UnloadMod(LoadedMod loaded)
    {
        var asm = loaded.Alc.Assemblies.FirstOrDefault();

        // Call OnUnload on this mod's scripts
        loaded.Scripts.ForEach(script => ModGuard.Run(script, script.Name, "OnUnload", script.OnUnload));

        if (asm != null)
        {
            // Whatever input the mod still keeps from the game goes back to it
            InputManager.ReleaseOwner(asm);

            // Detach components and clear registrations for this mod's assembly
            ScriptComponentManager.UnregisterTypes(asm);
            RedirectManager.Global.UnregisterRedirectors(asm);
            RedirectManager.Local.ClearCacheForAssembly(asm);
        }

        // Unload the assembly context
        loaded.Alc.Unload();
        s_loadedMods.Remove(loaded.Mod.DirectoryPath);
        RebuildScripts();
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    /// <summary>
    /// Reloads a single mod by its directory path.
    /// </summary>
    private static void ReloadMod(string modDirPath)
    {
        lock (s_lockObj)
        {
            ErrorOverlay.Clear();

            try
            {
                var scriptsDir = FileUtils.GetScriptsPath();

                if (modDirPath == scriptsDir)
                {
                    // Reload implicit Scripts mod
                    var mod = Mod.CreateDefault(scriptsDir);
                    LoadMod(mod, scriptsDir);
                }
                else
                {
                    // Reload explicit mod
                    var tomlPath = Path.Combine(modDirPath, "mod.toml");
                    if (!File.Exists(tomlPath))
                    {
                        // mod.toml was deleted — unload if loaded
                        if (s_loadedMods.TryGetValue(modDirPath, out var oldMod))
                        {
                            EngineSynchronizationContext.Instance.Post(
                                _ => UnloadMod(oldMod),
                                state: null
                            );
                        }

                        return;
                    }

                    var mod = Mod.FromDirectory(modDirPath);
                    var modScriptsDir = Path.Combine(modDirPath, "scripts");
                    LoadMod(mod, modScriptsDir);
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to reload mod: {e.Message}");
            }
        }
    }

    /// <summary>
    /// Compiles all C# script files for a single mod into an in-memory assembly.
    /// </summary>
    private static (MemoryStream?, MemoryStream?) CompileMod(Mod mod, string scriptsDir)
    {
        var baseDir = FileUtils.GetBasePath();

        if (!Directory.Exists(scriptsDir))
        {
            return (null, null);
        }

        var sourceFilePaths = Directory
            .EnumerateFiles(scriptsDir, "*.cs", SearchOption.AllDirectories)
            .Where(filePath => !filePath.Replace("\\", "/").Contains("/obj/"))
            .ToList();

        if (sourceFilePaths.Count == 0)
        {
            Debug.LogWarning(
                $"[{mod.Name}] No script files found in .\\{Path.GetRelativePath(baseDir, scriptsDir)}"
            );
            return (null, null);
        }

        // Each file is read once, for the cache key and for the compiler.
        var sources = sourceFilePaths.Select(filePath => (Path: filePath, Bytes: File.ReadAllBytes(filePath))).ToList();
        var cacheKey = CacheKey(mod, scriptsDir, sources);
        if (TryLoadCached(mod, cacheKey, out var cachedPe, out var cachedPdb))
        {
            Debug.Log(
                $"[{mod.Name}] {sourceFilePaths.Count} {CommonUtils.FormatPlural(sourceFilePaths.Count, "script")} unchanged, loaded the last build"
            );
            return (cachedPe, cachedPdb);
        }

        var syntaxTrees = sources
            .Select(source =>
            {
                using var stream = new MemoryStream(source.Bytes, writable: false);
                return CSharpSyntaxTree.ParseText(
                    SourceText.From(stream, Encoding.UTF8),
                    ParseOptions,
                    source.Path
                );
            })
            .ToList();

        syntaxTrees.Insert(index: 0, GlobalUsingsTree);

        Debug.Log(
            $"[{mod.Name}] Compiling {sourceFilePaths.Count} {CommonUtils.FormatPlural(sourceFilePaths.Count, "script")}"
        );
        Debug.Log("(...)");

        var watch = Stopwatch.StartNew();

        var targetName = $"{mod.Name}.dll";
        var compilation = CSharpCompilation
            .Create(targetName)
            .WithOptions(CompilerOptions)
            .AddReferences(MetadataReferences)
            .AddSyntaxTrees(syntaxTrees);

        var peStream = new MemoryStream();
        var pdbStream = new MemoryStream();
        var emitResult = compilation.Emit(peStream, pdbStream);

        if (!emitResult.Success)
        {
            PrintErrors(emitResult, scriptsDir, mod.Name);
            return (null, null);
        }

        watch.Stop();
        Debug.Log(
            $"[{mod.Name}] Success! {sourceFilePaths.Count} {CommonUtils.FormatPlural(sourceFilePaths.Count, "script")} compiled in {watch.Elapsed.FormatDuration()}"
        );

        SaveCached(mod, cacheKey, peStream, pdbStream);

        peStream.Position = 0;
        pdbStream.Position = 0;
        return (peStream, pdbStream);
    }

    // --- Build cache ---

    // A mod whose sources haven't changed since its last build loads that build from here, so starting
    // the game skips the compiler (and loading it) for every unchanged mod. A key covers each source
    // file, the mod's name and the compiler setup, and this BmSDK build, so anything else that would
    // change the output makes a new key. A cache that can't be read or written is only skipped.
    private const int CacheFormat = 1;

    private static string CacheDir => Path.Combine(FileUtils.GetBinariesPath(), "BmSDKCache");

    private static string CachePrefix(Mod mod)
    {
        var name = Path.GetFileName(mod.DirectoryPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
        foreach (var bad in Path.GetInvalidFileNameChars())
        {
            name = name.Replace(bad, '_');
        }

        return name + "-";
    }

    private static string CacheKey(Mod mod, string scriptsDir, List<(string Path, byte[] Bytes)> sources)
    {
        using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
        void Add(string text) => hash.AppendData(Encoding.UTF8.GetBytes(text + "\n"));

        Add($"format {CacheFormat}");
        Add(typeof(GameObject).Assembly.ManifestModule.ModuleVersionId.ToString());
        Add(typeof(CSharpCompilation).Assembly.GetName().Version?.ToString() ?? "");
        Add(LangVer.ToString());
        Add(GlobalUsings);
        Add(mod.Name);
        foreach (var (filePath, bytes) in sources.OrderBy(s => s.Path, StringComparer.OrdinalIgnoreCase))
        {
            Add(Path.GetRelativePath(scriptsDir, filePath));
            Add(bytes.Length.ToString());
            hash.AppendData(bytes);
        }

        return Convert.ToHexString(hash.GetHashAndReset(), 0, 16);
    }

    private static bool TryLoadCached(Mod mod, string key, out MemoryStream? pe, out MemoryStream? pdb)
    {
        pe = pdb = null;
        try
        {
            var stem = Path.Combine(CacheDir, CachePrefix(mod) + key);
            if (!File.Exists(stem + ".dll") || !File.Exists(stem + ".pdb"))
            {
                return false;
            }

            pe = new MemoryStream(File.ReadAllBytes(stem + ".dll"));
            pdb = new MemoryStream(File.ReadAllBytes(stem + ".pdb"));
            return true;
        }
        catch (Exception e)
        {
            Debug.LogWarning($"[{mod.Name}] The last build couldn't be read, compiling instead: {e.Message}");
            pe = pdb = null;
            return false;
        }
    }

    private static void SaveCached(Mod mod, string key, MemoryStream pe, MemoryStream pdb)
    {
        try
        {
            Directory.CreateDirectory(CacheDir);
            var prefix = CachePrefix(mod);
            foreach (var old in Directory.EnumerateFiles(CacheDir, prefix + "*"))
            {
                File.Delete(old);
            }

            var stem = Path.Combine(CacheDir, prefix + key);
            WriteAtomically(stem + ".pdb", pdb);
            WriteAtomically(stem + ".dll", pe);
        }
        catch (Exception e)
        {
            Debug.LogWarning($"[{mod.Name}] The build couldn't be kept for the next start: {e.Message}");
        }
    }

    private static void WriteAtomically(string path, MemoryStream data)
    {
        var temp = path + ".tmp";
        File.WriteAllBytes(temp, data.ToArray());
        File.Move(temp, path, overwrite: true);
    }

    private static void PrintErrors(EmitResult emitResult, string scriptsDir, string modName)
    {
        var errors = GetErrors(emitResult);
        var errorsByFilePath = errors
            .GroupBy(error => error.Location.SourceTree?.FilePath ?? "(no file)")
            .ToDictionary(group => group.Key, group => group.ToArray());

        foreach (var filePath in errorsByFilePath.Keys)
        {
            var shortPath = Path.GetRelativePath(scriptsDir, filePath);
            Debug.LogError(
                $"[{modName}] {shortPath}: {errorsByFilePath[filePath].Length} errors:",
                skipSender: true
            );

            foreach (var error in errorsByFilePath[filePath])
            {
                var lineSpan = error.Location.GetLineSpan();
                var mappedLineSpan = error.Location.GetMappedLineSpan();
                if (mappedLineSpan.HasMappedPath)
                {
                    lineSpan = mappedLineSpan;
                }

                var locationText = "";
                if (lineSpan.IsValid)
                {
                    var pos = lineSpan.StartLinePosition;
                    locationText = $"({pos.Line + 1}) ";
                }

                Debug.LogError(
                    $"  {locationText}{error.Id}: {error.GetMessage()}",
                    skipSender: true
                );
            }
        }

        Debug.LogError($"[{modName}] Compilation failed!");
    }

    private static Diagnostic[] GetErrors(EmitResult emitResult)
    {
        var diags = emitResult.Diagnostics;
        return diags
            .Where(diag => diag.IsWarningAsError || diag.Severity == DiagnosticSeverity.Error)
            .ToArray();
    }

    private static List<Script> CreateScriptInstances(Assembly asm, Mod mod)
    {
        var scriptTypes = asm.GetTypes()
            .Where(t => !t.IsAbstract)
            .Where(t => t.GetCustomAttribute<ScriptAttribute>() != null)
            .Where(t => t.IsAssignableTo(typeof(Script)));

        var scripts = new List<Script>();
        foreach (var scriptType in scriptTypes)
        {
            var scriptAttribute = scriptType.GetCustomAttribute<ScriptAttribute>()!;
            var scriptName = scriptAttribute.Name ?? scriptType.Name;

            try
            {
                // Create script instance without running constructor
                var script = (Script)
                    Guard.NotNull(RuntimeHelpers.GetUninitializedObject(scriptType));
                // Set fields so they become available during initialization
                script.Name = scriptName;
                script.Mod = mod;
                // Initialize object
                scriptType.GetConstructor(Type.EmptyTypes)?.Invoke(script, null);

                scripts.Add(script);
            }
            catch (Exception e)
            {
                Debug.LogError(
                    $"[{mod.Name}] Failed to create instance of script {scriptName}: {e.Message}",
                    skipSender: true
                );

                continue;
            }
        }

        return scripts;
    }

    // --- File watching ---

    private static FileSystemWatcher? s_modsWatcher;
    private static FileSystemWatcher? s_scriptsWatcher;

    private static void WatchForChanges()
    {
        var modsDir = FileUtils.GetModsPath();
        var scriptsDir = FileUtils.GetScriptsPath();

        if (Directory.Exists(modsDir))
        {
            s_modsWatcher = new FileSystemWatcher(modsDir)
            {
                Filter = "*.cs",
                IncludeSubdirectories = true,
                NotifyFilter =
                    NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName,
            };

            s_modsWatcher.Changed += OnModsFileChanged;
            s_modsWatcher.Created += OnModsFileChanged;
            s_modsWatcher.Deleted += OnModsFileChanged;
            s_modsWatcher.Renamed += OnModsFileChanged;
            s_modsWatcher.EnableRaisingEvents = true;
        }

        if (Directory.Exists(scriptsDir))
        {
            s_scriptsWatcher = new FileSystemWatcher(scriptsDir)
            {
                Filter = "*.cs",
                IncludeSubdirectories = true,
                NotifyFilter =
                    NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName,
            };

            s_scriptsWatcher.Changed += OnScriptsFileChanged;
            s_scriptsWatcher.Created += OnScriptsFileChanged;
            s_scriptsWatcher.Deleted += OnScriptsFileChanged;
            s_scriptsWatcher.Renamed += OnScriptsFileChanged;
            s_scriptsWatcher.EnableRaisingEvents = true;
        }
    }

    private static void OnModsFileChanged(object sender, FileSystemEventArgs e)
    {
        var modDir = ResolveModDirectory(e.FullPath);
        if (modDir == null)
        {
            return;
        }

        // Only a mod's scripts folder is compiled, so a .cs file anywhere else in the mod (a project
        // for the IDE, a build's obj folder, notes) doesn't reload it.
        var scriptsDir = Path.Combine(modDir, "scripts");
        if (!IsUnder(e.FullPath, scriptsDir) && !(e is RenamedEventArgs renamed && IsUnder(renamed.OldFullPath, scriptsDir)))
        {
            return;
        }

        ScheduleReload(modDir);
    }

    private static bool IsUnder(string filePath, string dir)
    {
        var relative = Path.GetRelativePath(dir, filePath);
        return relative != "." && !relative.StartsWith("..", StringComparison.Ordinal) && !Path.IsPathRooted(relative);
    }

    private static void OnScriptsFileChanged(object sender, FileSystemEventArgs e)
    {
        ScheduleReload(FileUtils.GetScriptsPath());
    }

    private static string? ResolveModDirectory(string changedFilePath)
    {
        var modsDir = FileUtils.GetModsPath();
        var relative = Path.GetRelativePath(modsDir, changedFilePath);
        var parts = relative.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

        if (parts.Length < 2)
        {
            return null;
        }

        return Path.Combine(modsDir, parts[0]);
    }

    private static void ScheduleReload(string modDirPath)
    {
        if (!s_debounceTimers.TryGetValue(modDirPath, out var timer))
        {
            timer = new Timer(_ => ReloadMod(modDirPath));
            s_debounceTimers[modDirPath] = timer;
        }

        timer.Change(DebounceMillis, Timeout.Infinite);
    }
}
