using System.Reflection;
using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

/// <summary>
/// Keyboard and mouse-button state as the game's window receives it, and swallowing keys so the game
/// never sees them.
/// </summary>
/// <remarks>
/// BmSDK reads key messages before the engine does. A swallowed key still reaches scripts
/// (<see cref="Script.OnKeyDown"/>, <see cref="IsDown"/>) but its press and release are dropped
/// before the engine's input bindings see them, so a mod's menu key no longer also fires the game's
/// action bound to it. A release is only dropped when its press was, so the game never sees a key
/// stuck down. Mouse buttons use the <see cref="Keys.LButton"/>, <see cref="Keys.RButton"/>,
/// <see cref="Keys.MButton"/>, <see cref="Keys.XButton1"/> and <see cref="Keys.XButton2"/> keys.
/// <para/>
/// Input can also be swallowed by its engine name (<see cref="Swallow(string)"/>): the name a key
/// binding uses, such as "MouseX", "MouseScrollUp", "LeftMouseButton" or "SpaceBar". That is the only
/// way to keep the mouse axes and wheel from the game, which are not keys. Named input is stopped in
/// the viewport, after the window message, so scripts still see the key but the game's bindings,
/// console and menus do not.
/// <para/>
/// Swallowing is kept per mod: a key stays swallowed until every mod that asked for it has let go, so one
/// mod unswallowing a key no longer gives it back to the game while another mod still keeps it. Asking
/// twice from the same mod counts once. Whatever a mod still holds is let go when it unloads or
/// hot reloads, so a key can't stay stuck behind a script that failed to clean up. The mod is the
/// assembly of the calling code.
/// </remarks>
public static class Keyboard
{
    /// <summary>
    /// Whether the key is currently held, as far as the game's window knows. Every key counts as
    /// released when the window loses focus, so nothing sticks after switching windows.
    /// </summary>
    public static bool IsDown(Keys key) => InputManager.IsDown(key);

    /// <summary>
    /// Whether the key went down since the previous engine tick, even when it was released again before
    /// the tick that reports it. <see cref="IsDown"/> misses a tap that short.
    /// </summary>
    public static bool WasPressed(Keys key) => InputManager.WasPressed(key);

    /// <summary>Whether the key came up since the previous engine tick.</summary>
    public static bool WasReleased(Keys key) => InputManager.WasReleased(key);

    /// <summary>
    /// Whether the game's window is the one in front. Checked once per engine tick, and false at once
    /// when the window loses focus.
    /// </summary>
    public static bool HasFocus => InputManager.HasFocus;

    /// <summary>Stops the engine seeing this key's presses and releases until <see cref="Unswallow(Keys)"/>.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Swallow(Keys key) => InputManager.SetSwallowed(key, true, Assembly.GetCallingAssembly());

    /// <summary>Stops this mod keeping the key. The engine sees it again once no mod does.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Unswallow(Keys key) => InputManager.SetSwallowed(key, false, Assembly.GetCallingAssembly());

    /// <summary>Stops this mod keeping any key or named input. Other mods' holds are left alone.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnswallowAll() => InputManager.ReleaseOwner(Assembly.GetCallingAssembly());

    /// <summary>Whether the engine is currently kept from seeing this key, by any mod.</summary>
    public static bool IsSwallowed(Keys key) => InputManager.IsSwallowed(key);

    /// <summary>
    /// Stops the game acting on an input by its engine name, until <see cref="Unswallow(string)"/>.
    /// Axes ("MouseX", "MouseY") and the wheel ("MouseScrollUp", "MouseScrollDown") can only be
    /// swallowed this way; keys and mouse buttons can be too ("SpaceBar", "LeftMouseButton").
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Swallow(string inputName) =>
        InputRouting.SetSwallowed(new FName(inputName), true, Assembly.GetCallingAssembly());

    /// <summary>Stops this mod keeping the named input. The game acts on it again once no mod does.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Unswallow(string inputName) =>
        InputRouting.SetSwallowed(new FName(inputName), false, Assembly.GetCallingAssembly());

    /// <summary>
    /// Whether named input is being intercepted right now. Swallowing by name only takes effect while
    /// BmSDK is bound to the viewport's input delegates, which it does not do over a binding the game made.
    /// </summary>
    public static bool NameSwallowingActive => InputRouting.IsBound;

    /// <summary>Whether the game is currently kept from acting on this named input.</summary>
    public static bool IsSwallowed(string inputName) => InputRouting.IsSwallowed(new FName(inputName));
}
