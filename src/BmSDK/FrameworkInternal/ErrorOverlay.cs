using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Draws error lines on top of the game viewport. Populated by <see cref="Debug.LogError"/>
/// and cleared on hot reload.
/// </summary>
internal static class ErrorOverlay
{
    private static readonly Lock s_lock = new();
    private static readonly List<string> s_lines = [];

    private const float MarginX = 16f;
    private const float MarginY = 16f;
    private const float LineHeight = 16f;

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
                s_lines.Add(line);
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

        string[] snapshot;
        lock (s_lock)
        {
            if (s_lines.Count == 0)
            {
                return;
            }

            snapshot = s_more == 0 ? [.. s_lines] : [.. s_lines, $"...and {s_more} more. See BmSDK.log."];
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
