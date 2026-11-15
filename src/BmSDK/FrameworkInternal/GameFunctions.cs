namespace BmSDK.Framework;

/// <summary>
/// The game's own functions BmSDK calls. Each is called through a plain function pointer, resolved
/// once: a delegate made with GetDelegateForFunctionPointer runs a marshalling stub on every call,
/// and ProcessEvent alone runs for every generated function call.
/// </summary>
internal static unsafe class GameFunctions
{
    // UObject::ProcessEvent(). The delegate stays for code that finds it by reflection; BmSDK itself
    // calls CallProcessEvent.
    public delegate void ProcessEventDelegate(
        IntPtr self,
        IntPtr Function,
        IntPtr Parms,
        IntPtr UnusedResult
    );

    // UObject::ProcessInternal()
    public delegate void ProcessInternalDelegate(IntPtr self, IntPtr Stack, IntPtr Result);

    // FWindowsViewport::ProcessDeferredMessage()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessDeferredMessageDelegate(IntPtr self, ref FDeferredMessage Message);

    // UObject::AddObject()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void AddObjectDelegate(IntPtr self, int InIndex);

    // UObject::~UObject()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ConditionalDestroyDelegate(IntPtr self);

    // FEngineLoop::Tick()
    public delegate IntPtr EngineTickDelegate(IntPtr self);

    // UObject::ConditionalPostLoad()
    public delegate void ConditionalPostLoadDelegate(IntPtr self);

    private static ProcessEventDelegate? _ProcessEvent;

    /// <summary>The game's ProcessEvent as a delegate. Slower than <see cref="CallProcessEvent"/>.</summary>
    public static ProcessEventDelegate ProcessEvent =>
        _ProcessEvent ??= Marshal.GetDelegateForFunctionPointer<ProcessEventDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.ProcessEvent)
        );

    private static IntPtr Address(IntPtr offset) => MemUtil.GetIntPointer(offset);

    private static delegate* unmanaged<IntPtr, IntPtr, FName, GameObject.EObjectFlags, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr> s_staticConstructObject;
    private static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int, IntPtr> s_staticFindObject;
    private static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr> s_loadPackage;
    private static delegate* unmanaged<GameObject.EObjectFlags, int, void> s_collectGarbage;
    private static delegate* unmanaged<IntPtr, IntPtr, IntPtr, IntPtr, void> s_processEvent;
    private static delegate* unmanaged<IntPtr, int, IntPtr> s_getDefaultObject;
    private static delegate* unmanaged<IntPtr, IntPtr, FName, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, int, IntPtr, IntPtr> s_spawnActor;
    private static delegate* unmanaged<IntPtr, IntPtr, int, int, int, void> s_nameInit;
    private static delegate* unmanaged<IntPtr, IntPtr, IntPtr> s_stringCtor;
    private static delegate* unmanaged<IntPtr, int, int, IntPtr> s_appRealloc;
    private static delegate* unmanaged<IntPtr, void> s_appFree;
    private static delegate* unmanaged<IntPtr, IntPtr> s_addToRoot;
    private static delegate* unmanaged<IntPtr, IntPtr> s_removeFromRoot;

    // UObject::StaticConstructObject()
    public static IntPtr StaticConstructObject(
        IntPtr InClass,
        IntPtr InOuter,
        FName InName,
        GameObject.EObjectFlags InFlags,
        IntPtr InTemplate,
        IntPtr Error,
        IntPtr SubobjectRoot,
        IntPtr InInstanceGraph
    )
    {
        if (s_staticConstructObject == null)
        {
            s_staticConstructObject = (delegate* unmanaged<IntPtr, IntPtr, FName, GameObject.EObjectFlags, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)
                Address(GameDefine.Current.StaticConstructObject);
        }

        return s_staticConstructObject(InClass, InOuter, InName, InFlags, InTemplate, Error, SubobjectRoot, InInstanceGraph);
    }

    // UObject::StaticFindObject()
    public static IntPtr StaticFindObject(IntPtr Class, IntPtr InOuter, IntPtr OrigInName, int ExactClass)
    {
        if (s_staticFindObject == null)
        {
            s_staticFindObject = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int, IntPtr>)Address(GameDefine.Current.StaticFindObject);
        }

        return s_staticFindObject(Class, InOuter, OrigInName, ExactClass);
    }

    // UObject::LoadPackage()
    public static IntPtr LoadPackage(IntPtr InOuter, IntPtr Filename, int LoadFlags)
    {
        if (s_loadPackage == null)
        {
            s_loadPackage = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr>)Address(GameDefine.Current.LoadPackage);
        }

        return s_loadPackage(InOuter, Filename, LoadFlags);
    }

    // UObject::CollectGarbage()
    public static void CollectGarbage(GameObject.EObjectFlags KeepFlags, int bPerformFullPurge)
    {
        if (s_collectGarbage == null)
        {
            s_collectGarbage = (delegate* unmanaged<GameObject.EObjectFlags, int, void>)Address(GameDefine.Current.CollectGarbage);
        }

        s_collectGarbage(KeepFlags, bPerformFullPurge);
    }

    /// <summary>UObject::ProcessEvent(), which every generated function call goes through.</summary>
    public static void CallProcessEvent(IntPtr self, IntPtr Function, IntPtr Parms, IntPtr UnusedResult)
    {
        if (s_processEvent == null)
        {
            s_processEvent = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, IntPtr, void>)Address(GameDefine.Current.ProcessEvent);
        }

        s_processEvent(self, Function, Parms, UnusedResult);
    }

    // UClass::GetDefaultObject()
    public static IntPtr GetDefaultObject(IntPtr self, int bForce)
    {
        if (s_getDefaultObject == null)
        {
            s_getDefaultObject = (delegate* unmanaged<IntPtr, int, IntPtr>)Address(GameDefine.Current.GetDefaultObject);
        }

        return s_getDefaultObject(self, bForce);
    }

    // UWorld::SpawnActor()
    public static IntPtr SpawnActor(
        IntPtr self,
        IntPtr Class,
        FName InName,
        IntPtr Location,
        IntPtr Rotation,
        IntPtr Template,
        int bNoCollisionFail,
        int bRemoteOwned,
        IntPtr Owner,
        IntPtr Instigator,
        int bNoFail,
        IntPtr OverrideLevel
    )
    {
        if (s_spawnActor == null)
        {
            s_spawnActor = (delegate* unmanaged<IntPtr, IntPtr, FName, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, int, IntPtr, IntPtr>)
                Address(GameDefine.Current.SpawnActor);
        }

        return s_spawnActor(self, Class, InName, Location, Rotation, Template, bNoCollisionFail, bRemoteOwned, Owner, Instigator, bNoFail, OverrideLevel);
    }

    // FName::Init()
    public static void NameInit(IntPtr self, IntPtr InName, int InNumber, int FindType, int bSplitName)
    {
        if (s_nameInit == null)
        {
            s_nameInit = (delegate* unmanaged<IntPtr, IntPtr, int, int, int, void>)Address(GameDefine.Current.NameInit);
        }

        s_nameInit(self, InName, InNumber, FindType, bSplitName);
    }

    // FString::FString()
    public static IntPtr StringCtor(IntPtr self, IntPtr In)
    {
        if (s_stringCtor == null)
        {
            s_stringCtor = (delegate* unmanaged<IntPtr, IntPtr, IntPtr>)Address(GameDefine.Current.StringCtor);
        }

        return s_stringCtor(self, In);
    }

    // appRealloc()
    public static IntPtr AppRealloc(IntPtr Original, int Count, int Alignment)
    {
        if (s_appRealloc == null)
        {
            s_appRealloc = (delegate* unmanaged<IntPtr, int, int, IntPtr>)Address(GameDefine.Current.AppRealloc);
        }

        return s_appRealloc(Original, Count, Alignment);
    }

    // appFree()
    public static void AppFree(IntPtr Original)
    {
        if (s_appFree == null)
        {
            s_appFree = (delegate* unmanaged<IntPtr, void>)Address(GameDefine.Current.AppFree);
        }

        s_appFree(Original);
    }

    // UObject::AddToRoot()
    public static IntPtr AddToRoot(IntPtr self)
    {
        if (s_addToRoot == null)
        {
            s_addToRoot = (delegate* unmanaged<IntPtr, IntPtr>)Address(GameDefine.Current.AddToRoot);
        }

        return s_addToRoot(self);
    }

    // UObject::RemoveFromRoot()
    public static IntPtr RemoveFromRoot(IntPtr self)
    {
        if (s_removeFromRoot == null)
        {
            s_removeFromRoot = (delegate* unmanaged<IntPtr, IntPtr>)Address(GameDefine.Current.RemoveFromRoot);
        }

        return s_removeFromRoot(self);
    }
}
