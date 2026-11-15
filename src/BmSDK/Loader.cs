global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Framework.Redirection;
using MoreLinq;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK.Framework;

internal static unsafe class Loader
{
    private const string InitFuncName = "Engine.GameInfo:InitGame";
    private const string EnterMenuFuncName = "BmScript.RSeqAct_GFxStartFrontend:Activated";
    private const string EnterGameFuncName = "BmGame.RPlayerStartInLevel:PreloadLevelsForEntering";
    private const string PostBeginPlayFuncName = ":PostBeginPlay";
    private const string TickFuncName = "BmGame.RGameInfo:Tick";

    // The player's camera, placed once a frame after every mesh is posed (when driving too).
    private const string CameraFuncName = "BmGame.R3rdPersonCamera:UpdateCamera";
    private const string ExitFuncSuffix = ":PreExit";

    // The game's own functions behind each detour. The detours are [UnmanagedCallersOnly] and the
    // originals plain function pointers: ProcessInternal runs for every UnrealScript call in the game,
    // and a delegate detour paid a marshalling stub both ways on each one.
    private static delegate* unmanaged<IntPtr, IntPtr> s_engineTickBase;
    private static delegate* unmanaged<IntPtr, IntPtr, IntPtr, void> s_processInternalBase;
    private static delegate* unmanaged<IntPtr, FDeferredMessage*, void> s_processDeferredMessageBase;
    private static delegate* unmanaged<IntPtr, int, void> s_addObjectBase;
    private static delegate* unmanaged<IntPtr, void> s_conditionalPostLoadBase;
    private static delegate* unmanaged<IntPtr, void> s_conditionalDestroyBase;

    /// <summary>
    /// Main .NET entry point, called from BmSDK.Host.
    /// This is done when FEngineLoop::PreInit() is executed.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void GuardedDllMain() => Debug.RunWithSender("Loader", () => RunGuarded(DllMain));

    private static void DllMain()
    {
        EngineSynchronizationContext.InitOnThread();

        Debug.InitFileLog();
        Debug.Log($"Detected {GameDefine.Current.Name} build");

        // Perform static init (before engine load)
        StaticInit.StaticInitClasses();

        // Find/load scripts
        ScriptManager.Init();

        // Register BmSDK's internal redirectors.
        RedirectManager.Global.RegisterRedirectors(typeof(Loader).Assembly);

        // Create function detours
        s_engineTickBase = (delegate* unmanaged<IntPtr, IntPtr>)DetourUtil.NewDetour(
            GameDefine.Current.EngineTick,
            (IntPtr)(delegate* unmanaged<IntPtr, IntPtr>)&EngineTickDetour
        );

        s_processInternalBase = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, void>)DetourUtil.NewDetour(
            GameDefine.Current.ProcessInternal,
            (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, IntPtr, void>)&ProcessInternalDetour
        );

        s_processDeferredMessageBase = (delegate* unmanaged<IntPtr, FDeferredMessage*, void>)DetourUtil.NewDetour(
            GameDefine.Current.ProcessDeferredMessage,
            (IntPtr)(delegate* unmanaged<IntPtr, FDeferredMessage*, void>)&ProcessDeferredMessageDetour
        );

        s_addObjectBase = (delegate* unmanaged<IntPtr, int, void>)DetourUtil.NewDetour(
            GameDefine.Current.AddObject,
            (IntPtr)(delegate* unmanaged<IntPtr, int, void>)&AddObjectDetour
        );

        s_conditionalPostLoadBase = (delegate* unmanaged<IntPtr, void>)DetourUtil.NewDetour(
            GameDefine.Current.ConditionalPostLoad,
            (IntPtr)(delegate* unmanaged<IntPtr, void>)&ConditionalPostLoadDetour
        );

        s_conditionalDestroyBase = (delegate* unmanaged<IntPtr, void>)DetourUtil.NewDetour(
            GameDefine.Current.ConditionalDestroy,
            (IntPtr)(delegate* unmanaged<IntPtr, void>)&ConditionalDestroyDetour
        );
    }

    [UnmanagedCallersOnly]
    private static IntPtr EngineTickDetour(IntPtr self)
    {
        FrameStats.BeginFrame();

        // Run the scheduled callbacks
        EngineSynchronizationContext.Instance.ExecutePending();

        // Key presses are delivered from here rather than the world tick, so they still arrive while
        // the game is paused or in a cutscene. Scripts hear about them once they have run Main().
        try
        {
            InputManager.Tick(dispatch: s_hasGameInited);
            InputRouting.Tick();
            TickHelpers();
        }
        catch (Exception ex)
        {
            Abort(ex);
        }

        var result = s_engineTickBase(self);
        try
        {
            FrameStats.EndFrame();
        }
        catch (Exception ex)
        {
            Abort(ex);
        }

        return result;
    }

    private static bool s_hasGameStarted = false;
    private static bool s_hasGameInited = false;

    // Detour for UObject::ProcessInternal(). Runs on every UnrealScript call in the game, so it must
    // not allocate: a function's path and lifecycle role are worked out once per UFunction (see
    // Classify), whether any redirect targets it is cached until the set of redirects changes, and
    // the guard is a plain try/catch rather than a captured lambda.
    [UnmanagedCallersOnly]
    private static void ProcessInternalDetour(IntPtr self, IntPtr Stack, IntPtr Result)
    {
        // Kept outside the try so a native fault inside the game's own function body can be named below.
        string? funcName = null;
        GameObject? selfObj = null;
        try
        {
            FFrame* stackPtr = (FFrame*)Stack.ToPointer();
            var funcObj = FunctionWrapper(stackPtr->Node);
            funcName = funcObj.CachedPath ?? Classify(funcObj);

            switch (funcObj.LifecycleKind)
            {
                // Notify scripts that the game is quitting, once
                case Function.Lifecycle.Exit when !s_hasExited && s_hasGameInited:
                    s_hasExited = true;
                    Debug.Log("The game is quitting.");
                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "OnExit", static s => s.OnExit(), script);
                    }
                    break;

                // Notify scripts of game init
                case Function.Lifecycle.Init when !s_hasGameInited:
                    // Kick off DLC scanning early
                    var dlcManager = Game.GetEngine().DLCManager;
                    dlcManager.RefreshDLC();

                    // Preload packages and root keep-alive objects before any world loads
                    PreloadManager.Run();

                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "Main", static s => s.Main(), script);
                    }
                    s_hasGameInited = true;
                    break;

                // Notify scripts of game start
                case Function.Lifecycle.EnterMenu when !s_hasGameStarted:
                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "OnEnterMenu", static s => s.OnEnterMenu(), script);
                    }
                    s_hasGameStarted = true;
                    break;

                // Notify scripts of game begin play
                case Function.Lifecycle.EnterGame:
                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "OnEnterGame", static s => s.OnEnterGame(), script);
                    }
                    break;

                // Notify scripts of game tick
                case Function.Lifecycle.Tick:
                    // Call OnTick() for scripts
                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "OnTick", static s => s.OnTick(), script);
                    }

                    // Call OnTick() for script components
                    if (GameObject.AllScriptComponents.Count > 0)
                    {
                        foreach (var scriptComponent in GameObject.AllScriptComponents.ToArray())
                        {
                            ModGuard.Run(scriptComponent, scriptComponent.GetType().Name, "OnTick", static c => c.OnTick(), scriptComponent);
                        }
                    }
                    break;
            }

            // Run redirect and skip base implementation if applicable to this function
            // The camera's update can run again inside itself when a mod's redirect runs the original, so
            // scripts hear about it once, when the outermost one is done.
            var camera = funcObj.LifecycleKind == Function.Lifecycle.CameraUpdated;
            if (camera)
            {
                s_cameraDepth++;
            }

            try
            {
                var redirected = false;
                if (RedirectManager.MayRedirect(funcObj, funcName))
                {
                    selfObj = MarshalUtil.GetOrCreateWrapper(self);
                    redirected = RedirectManager.ExecuteRedirector(selfObj, funcObj, funcName, stackPtr, Result);
                }

                // Call base impl. Redirected implementations are expected to reach this by calling "themselves" a second time.
                if (!redirected)
                {
                    s_processInternalBase(self, Stack, Result);
                }
            }
            finally
            {
                if (camera && --s_cameraDepth == 0)
                {
                    AfterCamera(self);
                }
            }
        }
        catch (Exception ex)
        {
            // A hardware fault in the game's code surfaces here as an SEHException with no clue where it was: name
            // the UnrealScript function that was running and the object it ran on, which is usually enough to find it.
            string where = "?";
            try
            {
                selfObj ??= MarshalUtil.GetOrCreateWrapper(self);
                where = (funcName ?? "?") + " on " + selfObj.GetPathName();
            }
            catch
            {
                // Naming the object must never hide the original failure.
            }

            Debug.LogError("ProcessInternal failed while the game ran " + where);
            Abort(ex);
        }
    }

    // Function wrappers by UFunction address, for the game thread only. The wrapper table takes a lock
    // the loading threads also take, and every UnrealScript call in the game comes through here. A
    // wrapper dies with its function, so a stale entry has a zero Ptr and is looked up again.
    private static readonly Dictionary<IntPtr, Function> s_functions = [];

    private static Function FunctionWrapper(IntPtr funcPtr)
    {
        if (Environment.CurrentManagedThreadId != EngineSynchronizationContext.Instance.MainThreadId)
        {
            return (Function)MarshalUtil.GetOrCreateWrapper(funcPtr);
        }

        if (s_functions.TryGetValue(funcPtr, out var func) && func.Ptr == funcPtr)
        {
            return func;
        }

        func = (Function)MarshalUtil.GetOrCreateWrapper(funcPtr);
        s_functions[funcPtr] = func;
        return func;
    }

    // Controllers, the world watch and timers. A failure in one is logged and the game carries on,
    // where a fault in BmSDK's core detour work still ends it.
    private static void TickHelpers()
    {
        try
        {
            GamepadManager.Tick();

            if (s_hasGameInited)
            {
                if (WorldWatch.Tick())
                {
                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "OnWorldChanged", static s => s.OnWorldChanged(), script);
                    }
                }

                TimerManager.Tick();
            }
        }
        catch (Exception ex)
        {
            if (!s_helperFailed)
            {
                s_helperFailed = true;
                Debug.LogError("BmSDK's tick helpers failed: " + ex);
            }
        }
    }

    private static bool s_helperFailed;
    private static bool s_hasExited;
    private static int s_cameraDepth;

    // The view is only taken from the local player's camera, and scripts only told about that one.
    private static void AfterCamera(IntPtr self)
    {
        if (!s_hasGameInited)
        {
            return;
        }

        try
        {
            if (MarshalUtil.GetOrCreateWrapper(self) is not Engine.Camera camera
                || !Game.TryGetPlayerController(out var controller)
                || camera.PCOwner != controller)
            {
                return;
            }

            WorldWatch.CaptureView(camera);
        }
        catch (Exception ex)
        {
            Debug.LogError("The camera view couldn't be read: " + ex.Message);
            return;
        }

        foreach (var script in ScriptManager.Scripts)
        {
            ModGuard.Run(script, script.Name, "OnCameraUpdated", static s => s.OnCameraUpdated(), script);
        }
    }

    /// <summary>Works out a function's path and lifecycle role, once per UFunction wrapper.</summary>
    private static string Classify(Function func)
    {
        var path = func.GetPathName();
        func.LifecycleKind = path switch
        {
            InitFuncName => Function.Lifecycle.Init,
            EnterMenuFuncName => Function.Lifecycle.EnterMenu,
            EnterGameFuncName => Function.Lifecycle.EnterGame,
            TickFuncName => Function.Lifecycle.Tick,
            CameraFuncName => Function.Lifecycle.CameraUpdated,
            _ when path.EndsWith(ExitFuncSuffix, StringComparison.Ordinal) && IsGameInfoFunction(func) => Function.Lifecycle.Exit,
            _ => Function.Lifecycle.None,
        };
        func.CachedPath = path;
        return path;
    }

    // Detour for FWindowsViewport::ProcessDeferredMessage(). Key and mouse-button messages are
    // recorded for scripts, and dropped before the engine sees them when a mod swallowed the key.
    [UnmanagedCallersOnly]
    private static void ProcessDeferredMessageDetour(IntPtr self, FDeferredMessage* messagePtr)
    {
        ref var message = ref *messagePtr;

        // WM_KILLFOCUS, or WM_ACTIVATE with WA_INACTIVE: every key counts as released.
        if (message.Message == 0x08 || (message.Message == 0x06 && (message.WParam & 0xFFFF) == 0))
        {
            InputManager.OnFocusLost();
        }

        var swallow = message.Message switch
        {
            // WM_KEYDOWN, WM_SYSKEYDOWN
            0x100 or 0x104 => InputManager.OnKeyDown((Keys)(uint)message.WParam),
            // WM_KEYUP, WM_SYSKEYUP
            0x101 or 0x105 => InputManager.OnKeyUp((Keys)(uint)message.WParam),
            // WM_CHAR, WM_DEADCHAR, WM_SYSCHAR, WM_SYSDEADCHAR: the text form of the press before it
            0x102 or 0x103 or 0x106 or 0x107 => InputManager.OnChar(),
            // WM_LBUTTONDOWN, WM_LBUTTONDBLCLK / WM_LBUTTONUP
            0x201 or 0x203 => InputManager.OnKeyDown(Keys.LButton),
            0x202 => InputManager.OnKeyUp(Keys.LButton),
            // WM_RBUTTONDOWN, WM_RBUTTONDBLCLK / WM_RBUTTONUP
            0x204 or 0x206 => InputManager.OnKeyDown(Keys.RButton),
            0x205 => InputManager.OnKeyUp(Keys.RButton),
            // WM_MBUTTONDOWN, WM_MBUTTONDBLCLK / WM_MBUTTONUP
            0x207 or 0x209 => InputManager.OnKeyDown(Keys.MButton),
            0x208 => InputManager.OnKeyUp(Keys.MButton),
            // WM_XBUTTONDOWN, WM_XBUTTONDBLCLK / WM_XBUTTONUP (button in the high word of wParam)
            0x20B or 0x20D => InputManager.OnKeyDown(XButton(message.WParam)),
            0x20C => InputManager.OnKeyUp(XButton(message.WParam)),
            _ => false,
        };

        if (swallow)
        {
            return;
        }

        // Call base impl
        s_processDeferredMessageBase(self, messagePtr);
    }

    private static Keys XButton(nuint wParam) =>
        ((wParam >> 16) & 0xFFFF) == 2 ? Keys.XButton2 : Keys.XButton1;

    // GameInfo's PreExit, or a subclass's override of it.
    private static bool IsGameInfoFunction(Function func) =>
        func.Outer is Class owner && MarshalUtil.GetManagedTypeForClassPtr(owner.Ptr).IsAssignableTo(typeof(Engine.GameInfo));

    /// <summary>Gives every script its OnDraw, from BmSDK's PostRender redirect.</summary>
    internal static void DispatchDraw(Engine.Canvas canvas)
    {
        WorldWatch.SetScreen(canvas);

        foreach (var script in ScriptManager.Scripts)
        {
            ModGuard.Run(script, script.Name, "OnDraw", static state => state.Script.OnDraw(state.Canvas), (Script: script, Canvas: canvas));
        }
    }

    // Detour for UObject::AddObject()
    [UnmanagedCallersOnly]
    private static void AddObjectDetour(IntPtr self, int InIndex)
    {
        // Call base impl to instantiate UObject
        s_addObjectBase(self, InIndex);

        // Runs for every object the game creates: no captured lambda here.
        try
        {
            var obj = MarshalUtil.GetOrCreateWrapper(self);

            // Auto-attach script components to non-serialized objs
            if (!obj.IsClassDefaultObject && ScriptComponentManager.HasAutoAttachTypes())
            {
                ScriptComponentManager.TryAutoAttachComponents(obj, objNotLoaded: true);
            }
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    // Detour for UObject::ConditionalPostLoad()
    [UnmanagedCallersOnly]
    private static void ConditionalPostLoadDetour(IntPtr self)
    {
        // Call base impl to set default func flags first
        s_conditionalPostLoadBase(self);

        // BM4: This is sometimes called from non-main threads
        if (Environment.CurrentManagedThreadId != EngineSynchronizationContext.Instance.MainThreadId)
        {
            return;
        }

        // Configure redirected functions
        try
        {
            var obj = MarshalUtil.GetOrCreateWrapper(self);
            if (obj is Function func)
            {
                RedirectManager.TryConfigureFunction(func);
            }

            // Auto-attach script components to serialized objs
            if (!obj.IsClassDefaultObject && ScriptComponentManager.HasAutoAttachTypes())
            {
                ScriptComponentManager.TryAutoAttachComponents(obj, objNotLoaded: true);
            }
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    // Detour for UObject::ConditionalDestroy()
    [UnmanagedCallersOnly]
    private static void ConditionalDestroyDetour(IntPtr self)
    {
        // Destroy this object's managed instance
        try
        {
            MarshalUtil.DestroyManagedWrapper(self);
        }
        catch (Exception ex)
        {
            Abort(ex);
        }

        // Call base impl
        s_conditionalDestroyBase(self);
    }

    private static void RunGuarded(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    /// <summary>A fault inside BmSDK itself (mod exceptions are handled by <see cref="ModGuard"/>).</summary>
    private static void Abort(Exception ex)
    {
        // Just abort, because otherwise UE3 will crash anyway but print
        // its more-or-less useless DBGHELP messages.
        Debug.LogError(ex.ToString());
        Environment.Exit(1);
    }
}
