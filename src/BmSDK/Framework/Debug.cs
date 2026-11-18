using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

public static class Debug
{
    private static readonly Stack<string> s_senderStack = new();
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
        if (!s_senderStack.TryPeek(out var sender))
        {
            sender = callerFilePath is null ? "UNKNOWN" : Path.GetFileName(callerFilePath);
        }

        return $"{sender}: {msgText}";
    }

    internal static void PushSender(string sender)
    {
        s_senderStack.Push(sender);
    }

    internal static void PopSender()
    {
        s_senderStack.Pop();
    }

    internal static void RunWithSender(string sender, Action action)
    {
        s_senderStack.Push(sender);
        try
        {
            action();
        }
        finally
        {
            s_senderStack.Pop();
        }
    }
}
