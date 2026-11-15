using System.Numerics;

namespace BmSDK.Framework;

/// <summary>
/// Where the player's camera was for the frame being drawn, and how the world maps onto the screen
/// from there. Taken once a frame, after the camera has been placed (see <see cref="Script.OnCameraUpdated"/>),
/// so it is the view the frame is rendered with. Get it from <see cref="Game.View"/>.
/// </summary>
/// <remarks>
/// The canvas's own Project doesn't work in <see cref="Script.OnDraw"/>: that canvas has no
/// scene view and gives the middle of the screen for everything. Use <see cref="WorldToScreen"/> instead.
/// Screen positions are in the canvas's pixels, the same units <see cref="Script.OnDraw"/> draws in.
/// </remarks>
public readonly struct GameView
{
    /// <summary>The camera's place in the world.</summary>
    public Vector3 Location { get; }

    /// <summary>Where the camera points.</summary>
    public Rotator Rotation { get; }

    /// <summary>The horizontal field of view in degrees, already fitted to the screen's shape by the game.</summary>
    public float FieldOfView { get; }

    /// <summary>The size of the screen in pixels, from the last canvas drawn on.</summary>
    public Vector2 ScreenSize { get; }

    /// <summary>The way the camera looks.</summary>
    public Vector3 Forward { get; }

    /// <summary>The camera's right on the screen.</summary>
    public Vector3 Right { get; }

    /// <summary>The camera's up on the screen.</summary>
    public Vector3 Up { get; }

    /// <summary>How many pixels one unit covers one unit in front of the camera.</summary>
    public float Focal { get; }

    /// <summary>Whether the view has been taken and the screen size is known.</summary>
    public bool IsValid => Focal > 0f;

    internal GameView(Vector3 location, Rotator rotation, float fieldOfView, Vector2 screenSize)
    {
        Location = location;
        Rotation = rotation;
        FieldOfView = fieldOfView;
        ScreenSize = screenSize;

        // The engine's own rotation matrix: X forward, Y right, Z up.
        var (sp, cp) = MathF.SinCos(rotation.Pitch * MathF.PI / 180f);
        var (sy, cy) = MathF.SinCos(rotation.Yaw * MathF.PI / 180f);
        var (sr, cr) = MathF.SinCos(rotation.Roll * MathF.PI / 180f);
        Forward = new Vector3(cp * cy, cp * sy, sp);
        Right = new Vector3(sr * sp * cy - cr * sy, sr * sp * sy + cr * cy, -sr * cp);
        Up = new Vector3(-(cr * sp * cy + sr * sy), cy * sr - cr * sp * sy, cr * cp);

        var half = Math.Clamp(fieldOfView, 1f, 179f) * MathF.PI / 360f;
        Focal = screenSize.X > 0f ? screenSize.X / 2f / MathF.Tan(half) : 0f;
    }

    /// <summary>
    /// Where a point in the world lands on the screen, in pixels from the top left. False when it is
    /// behind the camera (the position is then meaningless). A point in front of the camera but off
    /// the screen gives a position outside it.
    /// </summary>
    public bool WorldToScreen(Vector3 point, out Vector2 screen)
    {
        var toward = point - Location;
        var depth = Vector3.Dot(toward, Forward);
        if (depth < 1f || Focal <= 0f)
        {
            screen = default;
            return false;
        }

        screen = new Vector2(
            ScreenSize.X / 2f + Vector3.Dot(toward, Right) / depth * Focal,
            ScreenSize.Y / 2f - Vector3.Dot(toward, Up) / depth * Focal
        );
        return true;
    }

    /// <summary>The direction from the camera through a point on the screen, for traces from the cursor or a crosshair.</summary>
    public Vector3 ScreenToDirection(Vector2 screen)
    {
        if (Focal <= 0f)
        {
            return Forward;
        }

        var across = (screen.X - ScreenSize.X / 2f) / Focal;
        var down = (screen.Y - ScreenSize.Y / 2f) / Focal;
        return Vector3.Normalize(Forward + Right * across - Up * down);
    }

    /// <summary>How many pixels one world unit covers at this point, or 0 behind the camera.</summary>
    public float PixelsPerUnit(Vector3 point)
    {
        var depth = Vector3.Dot(point - Location, Forward);
        return depth < 1f ? 0f : Focal / depth;
    }
}
