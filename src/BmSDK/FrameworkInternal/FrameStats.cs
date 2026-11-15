using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BmSDK.Framework;

/// <summary>
/// Reports frames that take too long, with where the time went: each mod callback and redirect, and
/// BmSDK's own lookups. One line per slow frame goes to BmSDK.log, so a stutter can be put down to a
/// mod, to BmSDK or to the game itself (a frame that is slow with little time in mods).
/// </summary>
/// <remarks>
/// Only the game thread records. Times are inclusive, so a redirect a callback set off counts in both.
/// </remarks>
internal static class FrameStats
{
    private const double SlowMs = 50;
    private const double LogGapSeconds = 1;
    private const int MaxLines = 300;
    private const int ShownEntries = 6;

    private static readonly Dictionary<(string Who, string What), long> s_spent = [];
    private static readonly List<KeyValuePair<(string Who, string What), long>> s_sorted = [];
    private static long s_frameStart;
    private static long s_lastLog;
    private static int s_lines;
    private static int s_mainThread = -1;

    // BmSDK's own work this frame.
    private static int s_resolves;
    private static long s_resolveTicks;
    private static int s_newSites;
    private static long s_newSiteTicks;
    private static int s_classesDestroyed;

    private static bool OnGameThread => Environment.CurrentManagedThreadId == s_mainThread;

    public static long Now => Stopwatch.GetTimestamp();

    public static void BeginFrame()
    {
        s_mainThread = Environment.CurrentManagedThreadId;
        s_frameStart = Now;
        s_spent.Clear();
        s_resolves = 0;
        s_resolveTicks = 0;
        s_newSites = 0;
        s_newSiteTicks = 0;
    }

    public static void Add(string who, string what, long started)
    {
        if (OnGameThread)
        {
            CollectionsMarshal.GetValueRefOrAddDefault(s_spent, (who, what), out _) += Now - started;
        }
    }

    public static void AddResolve(long started)
    {
        if (OnGameThread)
        {
            s_resolves++;
            s_resolveTicks += Now - started;
        }
    }

    public static void AddNewSite(long started)
    {
        if (OnGameThread)
        {
            s_newSites++;
            s_newSiteTicks += Now - started;
        }
    }

    // Loading threads destroy classes too, so this one is only counted.
    public static void ClassDestroyed() => Interlocked.Increment(ref s_classesDestroyed);

    public static void EndFrame()
    {
        var end = Now;
        var classes = Interlocked.Exchange(ref s_classesDestroyed, 0);
        var frameMs = Ms(end - s_frameStart);
        if (frameMs < SlowMs || s_lines >= MaxLines || Stopwatch.GetElapsedTime(s_lastLog, end).TotalSeconds < LogGapSeconds)
        {
            return;
        }

        s_lastLog = end;
        s_lines++;

        s_sorted.Clear();
        s_sorted.AddRange(s_spent);
        s_sorted.Sort(static (a, b) => b.Value.CompareTo(a.Value));

        var line = new System.Text.StringBuilder();
        line.Append($"Slow frame {frameMs:0} ms.");
        for (var i = 0; i < s_sorted.Count && i < ShownEntries; i++)
        {
            var ((who, what), ticks) = s_sorted[i];
            line.Append($" {who} {what} {Ms(ticks):0.0} ms,");
        }

        line.Append($" override lookups {s_resolves} ({Ms(s_resolveTicks):0.0} ms),");
        line.Append($" new call sites {s_newSites} ({Ms(s_newSiteTicks):0.0} ms),");
        line.Append($" classes destroyed {classes}.");
        Debug.Log(line.ToString(), skipSender: true);
    }

    private static double Ms(long ticks) => ticks * 1000.0 / Stopwatch.Frequency;
}
