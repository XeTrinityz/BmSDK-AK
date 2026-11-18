using System.Diagnostics;
using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Draws error lines on top of the game viewport. Populated by <see cref="Debug.LogError"/>
/// and cleared on hot reload.
/// </summary>
internal static class ErrorOverlay
{
    private static readonly Lock s_lock = new();

    // Shown is 0 until the line is first drawn, so a line logged during a load still gets its full time.
    private static readonly List<(string Text, long Shown)> s_lines = [];

    private const float MarginX = 16f;
    private const float MarginY = 16f;
    private const float LineHeight = 16f;

    // A player can't fix a mod's error and a prebuilt mod never reloads, so a line that stayed for good
    // would sit over the game until it closed. Every line is in BmSDK.log as well.
    private const double ShowSeconds = 20;

    // Every line is a draw call each frame, and a mod that no longer compiles can log hundreds. The
    // first ones say what went wrong, the rest are counted and stay in BmSDK.log.
    private const int MaxLines = 30;
    private static int s_more;

    public static void Add(string line)
    {
        lock (s_lock)
        {
            if (s_lines.Count < MaxLines)
            {
                s_lines.Add((line, 0));
            }
            else
            {
                s_more++;
            }
        }
    }

    public static void Clear()
    {
        lock (s_lock)
        {
            s_lines.Clear();
            s_more = 0;
        }
    }

    [Redirect(typeof(GameViewportClient), nameof(GameViewportClient.PostRender))]
    private static void PostRenderRedirect(GameViewportClient self, Canvas canvas)
    {
        // Let the engine do its normal HUD/console/transition rendering first so our
        // banner draws on top.
        self.PostRender(canvas);

        // Scripts draw next, under the error banner.
        Loader.DispatchDraw(canvas);
        SdkUpdate.Draw(canvas);

        string[] snapshot;
        lock (s_lock)
        {
            if (s_lines.Count == 0)
            {
                return;
            }

            var now = Stopwatch.GetTimestamp();
            for (var i = 0; i < s_lines.Count; i++)
            {
                if (s_lines[i].Shown == 0)
                {
                    s_lines[i] = (s_lines[i].Text, now);
                }
            }

            s_lines.RemoveAll(line => Stopwatch.GetElapsedTime(line.Shown, now).TotalSeconds > ShowSeconds);
            if (s_lines.Count == 0)
            {
                // The lines that didn't fit go with the last of the ones shown, so new errors get the room
                s_more = 0;
                return;
            }

            var lines = s_lines.Select(line => line.Text);
            snapshot = s_more == 0 ? [.. lines] : [.. lines, $"...and {s_more} more. See BmSDK.log."];
        }

        Draw(canvas, snapshot);
    }

    private static void Draw(Canvas canvas, string[] lines)
    {
        canvas.SetDrawColor(255, 64, 64, 255);

        var y = MarginY;
        foreach (var line in lines)
        {
            canvas.SetPos(MarginX, y, 0f);
            canvas.DrawText(line, CR: false, XScale: 1f, YScale: 1f, out _);
            y += LineHeight;
        }
    }
}
