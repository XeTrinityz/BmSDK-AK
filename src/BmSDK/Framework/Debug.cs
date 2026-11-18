using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

public static class Debug
{
    // One per thread. A line logged from a mod's own thread, or from a hot reload, would otherwise get
    // the name of whatever script the engine thread is running at that moment.
    [ThreadStatic]
    private static Stack<string>? t_senderStack;

    private static readonly ConsoleColor s_defaultColor = Console.ForegroundColor;

    /// <summary>
    /// Mirrors log output to BmSDK.log.
    /// </summary>
    internal static void InitFileLog()
    {
        // The log can't always be made next to the game: the folder may be read-only (an Epic copy
        // under Program Files) or a game that hasn't finished closing may still hold the file. That
        // isn't worth ending the game over, so the log goes to the temp folder instead.
        string? problem = null;
        foreach (var dir in new[] { FileUtils.GetBinariesPath(), Path.GetTempPath() })
        {
            var path = Path.Combine(dir, "BmSDK.log");
            try
            {
                KeepLastLog(path);
                var writer = new StreamWriter(path) { AutoFlush = true };
                Trace.Listeners.Add(new TextWriterTraceListener(writer));
            }
            catch (Exception e) when (e is IOException or UnauthorizedAccessException)
            {
                problem ??= e.Message;
                continue;
            }

            if (problem != null)
            {
                LogWarning($"BmSDK.log couldn't be written in the game folder, so it is at {path}: {problem}");
            }

            return;
        }
    }

    // After a crash most people start the game again before they look, and that start would wipe the
    // log that says what happened. So the last session's log is kept beside the new one.
    private static void KeepLastLog(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                File.Move(path, Path.ChangeExtension(path, ".prev.log"), overwrite: true);
            }
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException)
        {
            // Still held by a game that hasn't finished closing, or the folder is read-only
        }
    }

    public static void Log(
        object? msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        Trace.WriteLine(FormatLine(msg, skipSender, callerFilePath));
    }

    public static void LogWarning(
        object msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Log(msg, skipSender, callerFilePath);
        Console.ForegroundColor = s_defaultColor;
    }

    public static void LogError(
        object msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        var line = FormatLine(msg, skipSender, callerFilePath);
        ErrorOverlay.Add(line);

        Console.ForegroundColor = ConsoleColor.Red;
        Trace.WriteLine(line);
        Console.ForegroundColor = s_defaultColor;
    }

    private static string FormatLine(object? msg, bool skipSender, string? callerFilePath)
    {
        var msgText = msg?.ToString() ?? "null";
        if (skipSender)
        {
            return msgText;
        }

        // Get sender, else fall back to the source file name.
        if (t_senderStack is not { } senders || !senders.TryPeek(out var sender))
        {
            sender = callerFilePath is null ? "UNKNOWN" : Path.GetFileName(callerFilePath);
        }

        return $"{sender}: {msgText}";
    }

    internal static void PushSender(string sender)
    {
        (t_senderStack ??= new()).Push(sender);
    }

    internal static void PopSender()
    {
        t_senderStack?.Pop();
    }

    internal static void RunWithSender(string sender, Action action)
    {
        PushSender(sender);
        try
        {
            action();
        }
        finally
        {
            PopSender();
        }
    }
}
