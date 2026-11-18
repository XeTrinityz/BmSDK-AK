using Tomlyn;
using Tomlyn.Model;

namespace BmSDK.Framework;

/// <summary>
/// Settings for BmSDK itself, from an optional BmSDK.toml next to BmSDK.dll. A missing file means the defaults.
/// </summary>
internal static class SdkSettings
{
    private static readonly Lazy<bool> s_checkForUpdates = new(ReadCheckForUpdates);

    /// <summary>Whether BmSDK may ask GitHub once per session if a newer release is out.</summary>
    public static bool CheckForUpdates => s_checkForUpdates.Value;

    private static bool ReadCheckForUpdates()
    {
        var path = Path.Combine(FileUtils.GetBinariesPath(), "sdk", "BmSDK.toml");
        if (!File.Exists(path))
        {
            return true;
        }

        try
        {
            var table = TomlSerializer.Deserialize<TomlTable>(File.ReadAllText(path))!;
            return !table.TryGetValue("check_for_updates", out var value) || value is not bool enabled || enabled;
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException or TomlException)
        {
            Debug.LogWarning($"Couldn't read {path}, so the defaults are used: {e.Message}");
            return true;
        }
    }
}
