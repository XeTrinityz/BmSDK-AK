namespace BmSDK.Framework;

/// <summary>
/// An action that runs after a delay, once or over and over (see <see cref="Game.After"/> and
/// <see cref="Game.Every"/>). It runs on the engine thread, and stops by itself when the mod that made
/// it unloads or hot reloads.
/// </summary>
public sealed class GameTimer
{
    internal readonly object Owner;
    internal readonly string OwnerName;
    internal readonly Action Action;
    internal readonly double Interval;
    internal readonly bool Repeat;
    internal readonly bool RealTime;
    internal double Due;

    internal GameTimer(object owner, string ownerName, Action action, double seconds, bool repeat, bool realTime)
    {
        Owner = owner;
        OwnerName = ownerName;
        Action = action;
        Interval = Math.Max(seconds, 0);
        Repeat = repeat;
        RealTime = realTime;
        Due = (realTime ? Game.RealTime : Game.WorldTime) + Interval;
    }

    /// <summary>Whether the timer will still run: not cancelled and, for a one-off, not run yet.</summary>
    public bool IsActive { get; internal set; } = true;

    /// <summary>Stops the timer. It never runs again, even if it is due this tick.</summary>
    public void Cancel() => IsActive = false;
}

/// <summary>Runs the due <see cref="GameTimer"/>s once per engine tick.</summary>
internal static class TimerManager
{
    private static readonly List<GameTimer> s_timers = [];
    private static readonly List<GameTimer> s_added = [];
    private static readonly List<GameTimer> s_due = [];

    public static GameTimer Add(GameTimer timer)
    {
        // Timers can be made from any thread (an awaited task's continuation, say), but only run on
        // the engine thread, which takes the new ones in at the start of its next tick.
        lock (s_added)
        {
            s_added.Add(timer);
        }

        return timer;
    }

    public static void Tick()
    {
        lock (s_added)
        {
            s_timers.AddRange(s_added);
            s_added.Clear();
        }

        if (s_timers.Count == 0)
        {
            return;
        }

        var real = Game.RealTime;
        var world = Game.WorldTime;
        foreach (var timer in s_timers)
        {
            if (timer.IsActive && (timer.RealTime ? real : world) >= timer.Due)
            {
                s_due.Add(timer);
            }
        }

        // A timer's action may make or cancel other timers, so the due ones are picked first.
        foreach (var timer in s_due)
        {
            if (!timer.IsActive)
            {
                continue;
            }

            if (timer.Repeat)
            {
                // Runs once a tick at most: a timer far behind (after a long load) catches up by
                // starting its next interval from now rather than firing for every one it missed.
                var now = timer.RealTime ? real : world;
                timer.Due += timer.Interval;
                if (timer.Due <= now)
                {
                    timer.Due = now + timer.Interval;
                }
            }
            else
            {
                timer.IsActive = false;
            }

            ModGuard.Run(timer, timer.OwnerName, "timer", static t => t.Action(), timer);
        }

        s_due.Clear();
        s_timers.RemoveAll(static timer => !timer.IsActive);
    }

    /// <summary>Stops every timer a mod made, when it unloads.</summary>
    public static void CancelOwner(object owner)
    {
        lock (s_added)
        {
            foreach (var timer in s_added)
            {
                if (timer.Owner == owner)
                {
                    timer.IsActive = false;
                }
            }
        }

        foreach (var timer in s_timers)
        {
            if (timer.Owner == owner)
            {
                timer.IsActive = false;
            }
        }
    }
}
