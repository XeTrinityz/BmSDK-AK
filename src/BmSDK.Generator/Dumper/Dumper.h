#pragma once

// Writes everything the engine knows about its script classes to JSON lines files, for building
// the bindings offline. It runs on the game thread from the engine tick.
namespace Dumper
{
    void Init();
    void Tick();

    // Safe to call from any thread. The work happens on the next engine tick.
    void RequestSnapshot();
    void ToggleSweep();
}
