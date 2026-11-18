using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.RegularExpressions;
using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Asks GitHub once per game session if a newer BmSDK is out and says so for a few seconds on screen.
/// Nothing is downloaded. Turn it off with check_for_updates = false in BmSDK.toml.
/// </summary>
internal static partial class SdkUpdate
{
    private const string Repo = "XeTrinityz/BmSDK-AK";
    private const double ShowSeconds = 8;
    private const float MarginX = 16f;
    private const float MarginBottom = 32f;

    private static int s_started;
    private static volatile string? s_newer;
    private static long s_shownAt;

    /// <summary>
    /// Starts the check on the first call and shows the notice while there is one. Called every frame from
    /// the viewport's PostRender, so the network call only starts once the game is drawing.
    /// </summary>
    public static void Draw(Canvas canvas)
    {
        if (Interlocked.Exchange(ref s_started, 1) == 0)
        {
            if (SdkSettings.CheckForUpdates)
            {
                _ = Task.Run(CheckAsync);
            }
            else
            {
                Debug.Log("Update check is off in BmSDK.toml.");
            }
        }

        var newer = s_newer;
        if (newer is null)
        {
            return;
        }

        var now = Stopwatch.GetTimestamp();
        if (s_shownAt == 0)
        {
            s_shownAt = now;
        }
        else if (Stopwatch.GetElapsedTime(s_shownAt, now).TotalSeconds > ShowSeconds)
        {
            // Once per session
            s_newer = null;
            return;
        }

        canvas.SetDrawColor(140, 200, 255, 255);
        canvas.SetPos(MarginX, canvas.ClipY - MarginBottom, 0f);
        canvas.DrawText($"BmSDK {newer} is out, and this is {Current()}. Update it with BmSDK Manager.", CR: false, XScale: 1f, YScale: 1f, out _);
    }

    private static async Task CheckAsync()
    {
        try
        {
            using var web = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
            // Names the program and its version and nothing else about the player
            web.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("BmSDK", Current().ToString()));
            web.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github+json");

            using var response = await web.GetAsync($"https://api.github.com/repos/{Repo}/releases/latest").ConfigureAwait(false);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return;
            }

            response.EnsureSuccessStatusCode();
            using var json = JsonDocument.Parse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
            var latest = Read(json.RootElement.GetProperty("tag_name").GetString());
            if (latest is null || latest <= Current())
            {
                Debug.Log($"BmSDK {Current()} is up to date.");
                return;
            }

            Debug.Log($"BmSDK {latest} is out, and this is {Current()}. Update it with BmSDK Manager, or get it from https://github.com/{Repo}/releases/latest");
            s_newer = latest.ToString();
        }
        catch (Exception e)
        {
            // Offline or rate limited. A background check must never be a problem for the game.
            Debug.Log($"Couldn't check for a newer BmSDK: {e.GetBaseException().Message}");
        }
    }

    private static Version Current() => Read(typeof(SdkUpdate).Assembly.GetName().Version?.ToString()) ?? new Version(0, 0, 0);

    /// <summary>1.9.0, v1.9 or BmSDK 1.9.0 as three numbers, so 0.24.1 equals 0.24.1.0. Null when there are none.</summary>
    internal static Version? Read(string? text)
    {
        var match = VersionPattern().Match(text ?? "");
        if (!match.Success || !Version.TryParse(match.Value, out var parsed))
        {
            return null;
        }

        return new Version(parsed.Major, parsed.Minor, Math.Max(parsed.Build, 0));
    }

    [GeneratedRegex(@"\d+(\.\d+){1,3}")]
    private static partial Regex VersionPattern();
}
