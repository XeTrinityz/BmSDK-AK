using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using BmSDK.BmGame;

namespace BmSDK.Framework;

public static partial class Game
{
    /// <summary>Whether a game world is loaded and being played: not the main menu, not loading.</summary>
    public static bool IsInGame
    {
        get
        {
            try
            {
                return TryGetGameInfo(out var gameInfo) && !gameInfo.IsFrontend();
            }
            catch (Exception)
            {
                // The game info is being torn down, between worlds.
                return false;
            }
        }
    }

    /// <summary>Whether the game is paused (the pause menu, the map, a paused load).</summary>
    public static bool IsPaused => TryGetWorldInfo(out var worldInfo) && worldInfo.Pauser is not null;

    /// <summary>
    /// Where the player's camera was for the frame being drawn. Taken once a frame after the camera
    /// has been placed, so it is right in <see cref="Script.OnCameraUpdated"/> and <see cref="Script.OnDraw"/>.
    /// Not <see cref="GameView.IsValid"/> until the first frame of a world has been drawn.
    /// </summary>
    public static GameView View => WorldWatch.View;

    /// <summary>Seconds since BmSDK started, from the system clock. Never stops.</summary>
    public static double RealTime => Stopwatch.GetElapsedTime(WorldWatch.Started).TotalSeconds;

    /// <summary>
    /// Seconds the game's world has run since BmSDK started. It stands still while the game is paused,
    /// runs slower in slow motion and carries on across loads, where the world's own clock starts over.
    /// Use it for deadlines that shouldn't run out behind the pause menu.
    /// </summary>
    public static double WorldTime => WorldWatch.WorldTime;

    /// <summary>
    /// Runs an action once, after this many seconds of <see cref="WorldTime"/>, or of <see cref="RealTime"/>
    /// when <paramref name="realTime"/> is set. It runs on the engine thread and is cancelled when this mod
    /// unloads or hot reloads.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameTimer After(double seconds, Action action, bool realTime = false)
    {
        var owner = Assembly.GetCallingAssembly();
        return TimerManager.Add(new GameTimer(owner, owner.GetName().Name ?? "timer", Guard.NotNull(action), seconds, false, realTime));
    }

    /// <summary>
    /// Runs an action every so many seconds, the first time that many seconds from now. It runs at most
    /// once per engine tick, and is cancelled when this mod unloads or hot reloads.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameTimer Every(double seconds, Action action, bool realTime = false)
    {
        var owner = Assembly.GetCallingAssembly();
        return TimerManager.Add(new GameTimer(owner, owner.GetName().Name ?? "timer", Guard.NotNull(action), seconds, true, realTime));
    }

    /// <summary>
    /// How many slots the game's object table has. It can't grow: when every slot is taken the game
    /// stops with "FNullAllocator is not allowed to allocate!".
    /// </summary>
    public const int ObjectCapacity = 785000;

    /// <summary>How many objects are alive right now. Counted at most once per engine tick, on asking.</summary>
    public static int ObjectCount => WorldWatch.CountObjects();

    /// <summary>How many more objects the game can hold. Check it before loading a package.</summary>
    public static int ObjectHeadroom => ObjectCapacity - ObjectCount;

    /// <summary>
    /// Loads a package if it is installed and the game has room for it, or finds it if it is loaded
    /// already. The name is the file's, with or without the "_SF" a cooked package has on the end.
    /// Loading a package that isn't installed can leave the game broken, and one too big for the
    /// object table ends it, so both are checked first.
    /// A package can stay in memory after the game has collected the objects in it. Pass the full
    /// path of an object you need as <paramref name="needs"/> and the file is read again when that
    /// object is gone. Then this only returns true if the object is there after the load.
    /// </summary>
    /// <param name="name">The package's file name, without ".upk".</param>
    /// <param name="package">The package, when this returns true.</param>
    /// <param name="spareObjects">Room to leave free on top of what the package needs, for what the
    /// world streams in around it.</param>
    /// <param name="needs">The full path of an object needed from the package, like
    /// "Anim_Scarecrow.Code.Stagg_B3_Anim_SC_BM". Leave it null to accept the package if it is loaded.</param>
    public static bool TryLoadPackage(string name, [NotNullWhen(true)] out Package? package, int spareObjects = 12000, string? needs = null)
    {
        package = null;
        foreach (var candidate in PackageFiles.Candidates(name))
        {
            if (FindObject<Package>(candidate) is { IsValid: true } loaded)
            {
                if (needs is not null && !HasObject(needs))
                {
                    break;
                }

                package = loaded;
                return true;
            }
        }

        if (PackageFiles.Find(name) is not { } file)
        {
            PackageFiles.WarnOnce(name, $"Package {name} isn't installed, so it wasn't loaded.");
            return false;
        }

        var needed = PackageFiles.Exports(file.Path) + spareObjects;
        if (ObjectHeadroom < needed)
        {
            PackageFiles.WarnOnce(name, $"Package {name} wasn't loaded: the game has room for {ObjectHeadroom} more objects and it needs {needed}.");
            return false;
        }

        package = LoadPackage(file.Name);
        if (package is not { IsValid: true })
        {
            return false;
        }

        if (needs is not null && !HasObject(needs))
        {
            PackageFiles.WarnOnce(name, $"Package {name} was loaded but {needs} isn't in it.");
            package = null;
            return false;
        }

        return true;
    }

    private static bool HasObject(string path) => FindObject<GameObject>(path) is { IsValid: true };
}

/// <summary>
/// Keeps track of the world from the engine tick: which world is loaded, the world clock, the camera
/// view and the size of the screen.
/// </summary>
internal static unsafe class WorldWatch
{
    public static readonly long Started = Stopwatch.GetTimestamp();
    public static double WorldTime;
    public static GameView View;
    public static Vector2 ScreenSize;

    private static IntPtr s_world;
    private static float s_worldSeconds;
    private static int s_tick;
    private static int s_countedTick = -1;
    private static int s_count;

    /// <summary>Returns true when a different world has taken over since the last tick.</summary>
    public static bool Tick()
    {
        s_tick++;
        if (!Game.TryGetWorldInfo(out var worldInfo))
        {
            return false;
        }

        var seconds = worldInfo.TimeSeconds;
        if (worldInfo.Ptr == s_world)
        {
            // Only forward steps count: a new world's clock starts over.
            if (seconds > s_worldSeconds)
            {
                WorldTime += seconds - s_worldSeconds;
            }

            s_worldSeconds = seconds;
            return false;
        }

        var changed = s_world != IntPtr.Zero;
        s_world = worldInfo.Ptr;
        s_worldSeconds = seconds;
        View = default;
        return changed;
    }

    /// <summary>Takes the view from the player's camera once it has been placed for the frame.</summary>
    public static void CaptureView(Engine.Camera camera)
    {
        var pov = camera.CameraCache.POV;
        View = new GameView(pov.Location, pov.Rotation, pov.FOV, ScreenSize);
    }

    /// <summary>The screen size from the canvas about to be drawn on, for the view.</summary>
    public static void SetScreen(Engine.Canvas canvas)
    {
        var size = new Vector2(canvas.ClipX, canvas.ClipY);
        if (size != ScreenSize)
        {
            ScreenSize = size;
            if (View.Focal > 0f || View.FieldOfView > 0f)
            {
                View = new GameView(View.Location, View.Rotation, View.FieldOfView, size);
            }
        }
    }

    // A freed slot is left empty, so the live ones are counted.
    public static int CountObjects()
    {
        if (s_countedTick == s_tick)
        {
            return s_count;
        }

        var objects = (TObjArray*)MemUtil.GetPointer(GameDefine.Current.GObjObjects);
        var used = Math.Clamp(objects->Num, 0, Game.ObjectCapacity);
        var alive = 0;
        for (var i = 0; i < used; i++)
        {
            if (objects->Data[i] != 0)
            {
                alive++;
            }
        }

        s_countedTick = s_tick;
        s_count = alive;
        return alive;
    }
}

/// <summary>The game's package files on disk, for <see cref="Game.TryLoadPackage"/>.</summary>
internal static class PackageFiles
{
    // The largest playable character is about 33,000 objects, so a package that can't be sized is
    // taken to be a little more than that.
    private const int UnknownExports = 36000;
    private const long RescanMilliseconds = 30000;

    private static Dictionary<string, string>? s_files;
    private static long s_scannedAt;
    private static readonly HashSet<string> s_warned = new(StringComparer.OrdinalIgnoreCase);

    public static IEnumerable<string> Candidates(string name) =>
        name.EndsWith("_SF", StringComparison.OrdinalIgnoreCase)
            ? [name, name[..^3]]
            : [name + "_SF", name];

    /// <summary>The installed file for a package name, trying the "_SF" form first.</summary>
    public static (string Name, string Path)? Find(string name)
    {
        var files = Files();
        foreach (var candidate in Candidates(name))
        {
            if (files.TryGetValue(candidate, out var path))
            {
                return (candidate, path);
            }
        }

        // Skin and character mods add packages while the game runs, so the folders are listed again
        // now and then.
        if (Environment.TickCount64 - s_scannedAt > RescanMilliseconds)
        {
            s_files = null;
            files = Files();
            foreach (var candidate in Candidates(name))
            {
                if (files.TryGetValue(candidate, out var path))
                {
                    return (candidate, path);
                }
            }
        }

        return null;
    }

    // Every .upk under the base game's CookedPCConsole and the DLC folder, by file name. The game finds
    // packages anywhere under a DLC folder, which is where skin and car mods put theirs.
    private static Dictionary<string, string> Files()
    {
        if (s_files is not null)
        {
            return s_files;
        }

        var files = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var deep = new EnumerationOptions { RecurseSubdirectories = true, IgnoreInaccessible = true, MatchCasing = MatchCasing.CaseInsensitive };
        foreach (var root in new[] { Path.Combine(FileUtils.GetGamePath(), "CookedPCConsole"), Path.Combine(FileUtils.GetBasePath(), "DLC") })
        {
            if (!Directory.Exists(root))
            {
                continue;
            }

            try
            {
                foreach (var file in Directory.EnumerateFiles(root, "*.upk", deep))
                {
                    files.TryAdd(Path.GetFileNameWithoutExtension(file), file);
                }
            }
            catch (Exception e)
            {
                Debug.LogWarning($"The game's packages in {root} couldn't all be listed: {e.Message}");
            }
        }

        s_scannedAt = Environment.TickCount64;
        return s_files = files;
    }

    /// <summary>How many objects a package adds when it loads, read from the start of its file.</summary>
    public static int Exports(string path)
    {
        const uint packageTag = 0x9E2A83C1;
        const int most = 400000;

        try
        {
            using var reader = new BinaryReader(File.OpenRead(path));
            if (reader.ReadUInt32() != packageTag)
            {
                return UnknownExports;
            }

            // Version and header size, then the folder name, the flags and the name table. The export
            // count comes after those. A negative length means wide text.
            reader.BaseStream.Seek(8, SeekOrigin.Current);
            var length = reader.ReadInt32();
            reader.BaseStream.Seek(length >= 0 ? length : -2L * length, SeekOrigin.Current);
            reader.BaseStream.Seek(12, SeekOrigin.Current);
            var exports = reader.ReadInt32();
            return exports is > 0 and < most ? exports : UnknownExports;
        }
        catch (Exception)
        {
            return UnknownExports;
        }
    }

    public static void WarnOnce(string name, string message)
    {
        if (s_warned.Add(name))
        {
            Debug.LogWarning(message);
        }
    }
}
