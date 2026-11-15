namespace BmSDK.Framework;

/// <summary>
/// Base class for user-defined scripts.
/// </summary>
public abstract class Script
{
    /// <summary>
    /// Name of this script, used mainly for logging. Defaults to the name of
    /// the original .cs file, but can be customized using the [Script] attribute.
    /// </summary>
#nullable disable
    public string Name { get; set; }

    /// <summary>
    /// The mod that this script belongs to.
    /// </summary>
    public Mod Mod { get; internal set; }
#nullable restore

    /// <summary>
    /// Script entry point, called once when the engine first becomes ready.
    /// Should be used to perform basic setup that doesn't need access to the game world.
    /// </summary>
    public virtual void Main() { }

    /// <summary>
    /// Called when we first load into the main menu, after all actors have begun play.
    /// </summary>
    public virtual void OnEnterMenu() { }

    /// <summary>
    /// Called every time we load into a new world, after all actors have begun play, and after a hot
    /// reload while a world is being played (after <see cref="OnLoad"/>).
    /// Does not get called when levels are streamed in dynamically.
    /// </summary>
    public virtual void OnEnterGame() { }

    /// <summary>
    /// Called once every world tick.
    /// </summary>
    public virtual void OnTick() { }

    /// <summary>
    /// Called every time a key or mouse button is pressed, whether or not the key is swallowed
    /// (see <see cref="Keyboard"/>). Delivered from the engine tick, so it fires while the game is
    /// paused or in a cutscene too. A press and release inside one frame still reports both.
    /// </summary>
    public virtual void OnKeyDown(Keys key) { }

    /// <summary>
    /// Called every time a key or mouse button is released. Delivered with <see cref="OnKeyDown"/>,
    /// in the order the events happened, and when the window loses focus for every key that was held.
    /// </summary>
    public virtual void OnKeyUp(Keys key) { }

    /// <summary>
    /// Called once per rendered frame, after the game has drawn its own HUD, with the viewport's
    /// canvas. Runs while the game is paused too. Draw here rather than redirecting
    /// GameViewportClient.PostRender yourself.
    /// </summary>
    public virtual void OnDraw(Engine.Canvas canvas) { }

    /// <summary>
    /// Called when a different world takes over: a load, a restart from a checkpoint, going to or from
    /// the main menu. Every object of the old world is gone or going, so drop what you kept of it.
    /// </summary>
    public virtual void OnWorldChanged() { }

    /// <summary>
    /// Called once a frame after the player's camera has been placed, when every character has been
    /// moved and posed for the frame. Copy a pose or follow a bone here rather than in <see cref="OnTick"/>,
    /// which runs at the start of the frame and sees last frame's poses. <see cref="Game.View"/> is
    /// this frame's view by now.
    /// </summary>
    public virtual void OnCameraUpdated() { }

    /// <summary>
    /// Called once when the game is quitting normally, while the world still exists. Save what needs
    /// saving here. It doesn't run if the game is killed or crashes.
    /// </summary>
    public virtual void OnExit() { }

    /// <summary>
    /// Called when the hot reloading system uninstalls
    /// the old version of the script class
    /// </summary>
    public virtual void OnUnload() { }

    /// <summary>
    /// Called only when the hot reloading system installs
    /// the new version of the scripts class
    /// </summary>
    public virtual void OnLoad() { }
}
