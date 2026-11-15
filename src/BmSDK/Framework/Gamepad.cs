using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

/// <summary>A controller button. The values are XInput's own button bits, plus the two triggers.</summary>
[Flags]
public enum GamepadButton : ushort
{
    None = 0,
    DPadUp = 0x0001,
    DPadDown = 0x0002,
    DPadLeft = 0x0004,
    DPadRight = 0x0008,
    Start = 0x0010,
    Back = 0x0020,
    LeftStick = 0x0040,
    RightStick = 0x0080,
    LeftShoulder = 0x0100,
    RightShoulder = 0x0200,

    // XInput leaves these two bits unused. The triggers count as pressed past halfway.
    LeftTrigger = 0x0400,
    RightTrigger = 0x0800,

    A = 0x1000,
    B = 0x2000,
    X = 0x4000,
    Y = 0x8000,
}

/// <summary>
/// Xbox controllers, and anything Steam Input presents as one, read once per engine tick. Every
/// connected controller is merged, so a button counts as down when it is down on any of them and a
/// stick reads the one pushed furthest.
/// </summary>
/// <remarks>
/// The controllers are read whether or not the game's window is in front, as the game itself can be
/// set to. Check <see cref="Keyboard.HasFocus"/> when that matters.
/// <para/>
/// <see cref="Swallow"/> keeps a button from the game the same way <see cref="Keyboard.Swallow(string)"/>
/// does, by its engine names, and is held per mod like a key.
/// </remarks>
public static class Gamepad
{
    /// <summary>Whether any controller is connected.</summary>
    public static bool IsConnected => GamepadManager.Connected;

    /// <summary>Whether every button in <paramref name="buttons"/> is held.</summary>
    public static bool IsDown(GamepadButton buttons) =>
        buttons != GamepadButton.None && (GamepadManager.Held & buttons) == buttons;

    /// <summary>Whether the button went down since the previous engine tick.</summary>
    public static bool WasPressed(GamepadButton button) => (GamepadManager.Pressed & button) != 0;

    /// <summary>Whether the button came up since the previous engine tick.</summary>
    public static bool WasReleased(GamepadButton button) => (GamepadManager.Released & button) != 0;

    /// <summary>Every button held right now.</summary>
    public static GamepadButton Held => GamepadManager.Held;

    /// <summary>The left stick, -1 to 1 on each axis with the dead zone taken out. Up is positive Y.</summary>
    public static Vector2 LeftStick => GamepadManager.LeftStick;

    /// <summary>The right stick, -1 to 1 on each axis with the dead zone taken out. Up is positive Y.</summary>
    public static Vector2 RightStick => GamepadManager.RightStick;

    /// <summary>How far the left trigger is pulled, 0 to 1.</summary>
    public static float LeftTrigger => GamepadManager.LeftTrigger;

    /// <summary>How far the right trigger is pulled, 0 to 1.</summary>
    public static float RightTrigger => GamepadManager.RightTrigger;

    /// <summary>Stops the game acting on the button (or every button in the set) until this mod unswallows it.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Swallow(GamepadButton buttons) => Hold(buttons, true, Assembly.GetCallingAssembly());

    /// <summary>Stops this mod keeping the button. The game acts on it again once no mod does.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Unswallow(GamepadButton buttons) => Hold(buttons, false, Assembly.GetCallingAssembly());

    /// <summary>Whether the game is kept from acting on the button, by any mod.</summary>
    public static bool IsSwallowed(GamepadButton button)
    {
        var names = EngineNames(button);
        return names.Length > 0 && InputRouting.IsSwallowed(new FName(names[0]));
    }

    /// <summary>
    /// The names the game's input bindings know a single button by. The game uses the Xbox names for
    /// every kind of controller. A trigger is both a button and an axis, and the game reads both.
    /// </summary>
    public static string[] EngineNames(GamepadButton button) => button switch
    {
        GamepadButton.DPadUp => ["XboxTypeS_DPad_Up"],
        GamepadButton.DPadDown => ["XboxTypeS_DPad_Down"],
        GamepadButton.DPadLeft => ["XboxTypeS_DPad_Left"],
        GamepadButton.DPadRight => ["XboxTypeS_DPad_Right"],
        GamepadButton.Start => ["XboxTypeS_Start"],
        GamepadButton.Back => ["XboxTypeS_Back"],
        GamepadButton.LeftStick => ["XboxTypeS_LeftThumbstick"],
        GamepadButton.RightStick => ["XboxTypeS_RightThumbstick"],
        GamepadButton.LeftShoulder => ["XboxTypeS_LeftShoulder"],
        GamepadButton.RightShoulder => ["XboxTypeS_RightShoulder"],
        GamepadButton.LeftTrigger => ["XboxTypeS_LeftTrigger", "XboxTypeS_LeftTriggerAxis"],
        GamepadButton.RightTrigger => ["XboxTypeS_RightTrigger", "XboxTypeS_RightTriggerAxis"],
        GamepadButton.A => ["XboxTypeS_A"],
        GamepadButton.B => ["XboxTypeS_B"],
        GamepadButton.X => ["XboxTypeS_X"],
        GamepadButton.Y => ["XboxTypeS_Y"],
        _ => [],
    };

    private static void Hold(GamepadButton buttons, bool swallow, object owner)
    {
        for (var bit = 1; bit <= 0x8000; bit <<= 1)
        {
            if (((ushort)buttons & bit) == 0)
            {
                continue;
            }

            foreach (var name in EngineNames((GamepadButton)bit))
            {
                InputRouting.SetSwallowed(new FName(name), swallow, owner);
            }
        }
    }
}

/// <summary>Reads the controllers once per engine tick, for <see cref="Gamepad"/>.</summary>
internal static class GamepadManager
{
    [StructLayout(LayoutKind.Sequential)]
    private struct XInputState
    {
        public uint Packet;
        public ushort Buttons;
        public byte LeftTrigger;
        public byte RightTrigger;
        public short LeftX;
        public short LeftY;
        public short RightX;
        public short RightY;
    }

    [DllImport("xinput1_4.dll")]
    private static extern uint XInputGetState(uint slot, out XInputState state);

    private const int Slots = 4;

    // Asking about an empty slot is slow, so empty slots are only looked at now and then.
    private const long ScanMilliseconds = 2000;

    // XInput's recommended dead zones.
    private const float LeftDeadZone = 7849f;
    private const float RightDeadZone = 8689f;
    private const float TriggerDeadZone = 30f;
    private const byte TriggerPressed = 128;

    private static readonly bool[] s_present = new bool[Slots];
    private static long s_nextScan;
    private static bool s_unavailable;

    public static bool Connected;
    public static GamepadButton Held;
    public static GamepadButton Pressed;
    public static GamepadButton Released;
    public static Vector2 LeftStick;
    public static Vector2 RightStick;
    public static float LeftTrigger;
    public static float RightTrigger;

    public static void Tick()
    {
        if (s_unavailable)
        {
            return;
        }

        var now = Environment.TickCount64;
        var scan = now >= s_nextScan;
        if (scan)
        {
            s_nextScan = now + ScanMilliseconds;
        }

        var held = GamepadButton.None;
        var any = false;
        Vector2 left = default, right = default;
        float leftTrigger = 0, rightTrigger = 0;

        for (var slot = 0; slot < Slots; slot++)
        {
            if (!s_present[slot] && !scan)
            {
                continue;
            }

            uint result;
            XInputState state;
            try
            {
                result = XInputGetState((uint)slot, out state);
            }
            catch (Exception ex) when (ex is DllNotFoundException or EntryPointNotFoundException)
            {
                s_unavailable = true;
                Debug.LogWarning("XInput isn't available, so controllers can't be read.");
                return;
            }

            s_present[slot] = result == 0;
            if (result != 0)
            {
                continue;
            }

            any = true;
            held |= (GamepadButton)state.Buttons & ~(GamepadButton.LeftTrigger | GamepadButton.RightTrigger);
            if (state.LeftTrigger > TriggerPressed)
            {
                held |= GamepadButton.LeftTrigger;
            }

            if (state.RightTrigger > TriggerPressed)
            {
                held |= GamepadButton.RightTrigger;
            }

            left = Furthest(left, Stick(state.LeftX, state.LeftY, LeftDeadZone));
            right = Furthest(right, Stick(state.RightX, state.RightY, RightDeadZone));
            leftTrigger = MathF.Max(leftTrigger, Trigger(state.LeftTrigger));
            rightTrigger = MathF.Max(rightTrigger, Trigger(state.RightTrigger));
        }

        Pressed = held & ~Held;
        Released = Held & ~held;
        Held = held;
        Connected = any;
        LeftStick = left;
        RightStick = right;
        LeftTrigger = leftTrigger;
        RightTrigger = rightTrigger;
    }

    private static Vector2 Furthest(Vector2 a, Vector2 b) => b.LengthSquared() > a.LengthSquared() ? b : a;

    // The dead zone is taken out of the length, so the stick still reaches 1 and moves smoothly from 0.
    private static Vector2 Stick(short x, short y, float deadZone)
    {
        var raw = new Vector2(x, y);
        var length = raw.Length();
        if (length <= deadZone)
        {
            return Vector2.Zero;
        }

        var scaled = MathF.Min((length - deadZone) / (32767f - deadZone), 1f);
        return raw / length * scaled;
    }

    private static float Trigger(byte value) =>
        value <= TriggerDeadZone ? 0f : MathF.Min((value - TriggerDeadZone) / (255f - TriggerDeadZone), 1f);
}
