#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBarkValDef<br/>
/// (size = 436)
/// (flags = 134217875)
/// </summary>
public partial class RBarkValDef : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkValDef", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBarkValDef.
    /// </summary>
    public static RBarkValDef DefaultObject => (RBarkValDef)StaticClass().DefaultObject;

    internal RBarkValDef() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkValDef(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkValDef>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkValDef>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkValDef>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkValDef>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkValDef>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkValDef>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkValDef>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkValDef>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: TrueFalseFlagList<br/>
    /// Default: (FV_True,FV_False)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TrueFalseFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: EventFlagList<br/>
    /// Default: (FV_EVENT_HeardNoise,FV_EVENT_SEARCH_Checkin,FV_EVENT_SEARCH_Chat,FV_EVENT_SEARCH_BuddyBump,FV_EVENT_SEARCH_LoneThug,FV_EVENT_SEARCH_BuddyBanter,FV_EVENT_AARem_Buddy,FV_EVENT_AARem_Grates,FV_EVENT_AAR...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> EventFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: FearFlagList<br/>
    /// Default: (FV_FEAR_COCKY,FV_FEAR_Nervous,FV_FEAR_Terrified)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FearFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: DeliveryFlagList<br/>
    /// Default: (FV_DELIVERY_Spoken,FV_DELIVERY_Shouted)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DeliveryFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: PlayerNameFlagList<br/>
    /// Default: (FV_PlayerName_Batman,FV_PLAYERNAME_Catwoman,FV_PLAYERNAME_Nightwing,FV_PLAYERNAME_Robin,FV_PLAYERNAME_RedHood,FV_PLAYERNAME_HarleyQuinn,FV_PLAYERNAME_Batgirl,FV_PLAYERNAME_Joker,FV_PLAYERNAME_Azrael)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PlayerNameFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: PlayerGenderFlagList<br/>
    /// Default: (FV_PLAYERGENDER_Male,FV_PLAYERGENDER_Female)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PlayerGenderFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: MiniManDownTimeFlagList<br/>
    /// Default: (FV_MiniManDownTime_Recent,FV_MiniManDownTime_Old)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MiniManDownTimeFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: WeaponFlagList<br/>
    /// Default: (FV_WEAPON_Unarmed,FV_WEAPON_Pipe,FV_WEAPON_Knife,FV_WEAPON_Taser,FV_WEAPON_Projectile,FV_WEAPON_Gun,FV_WEAPON_Shield)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> WeaponFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ArrayProperty: InjurySourceFlagList<br/>
    /// Default: (FV_INJURYSOURCE_Grate,FV_INJURYSOURCE_Silent,FV_INJURYSOURCE_Ledge,FV_INJURYSOURCE_GelWall,FV_INJURYSOURCE_GlideKick,FV_INJURYSOURCE_Drop,FV_INJURYSOURCE_Inverted,FV_INJURYSOURCE_Tunnel,FV_INJURYSOUR...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> InjurySourceFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: FractureTypeList<br/>
    /// Default: (FV_FRACTURETYPE_Wall,FV_FRACTURETYPE_Floor,FV_FRACTURETYPE_Ceiling)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FractureTypeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: SubjectLocationFlagList<br/>
    /// Default: (FV_LOCATION_MiddleOfRoom,FV_LOCATION_NearDoor,FV_LOCATION_OnStairs,FV_LOCATION_NearStairs,FV_LOCATION_InStairwell,FV_LOCATION_Walkway,FV_LOCATION_GroundFloor,FV_LOCATION_TopFloor,FV_LOCATION_NorthSid...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SubjectLocationFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ArrayProperty: CountFlagList<br/>
    /// Default: (FV_COUNT_Zero,FV_COUNT_One,FV_COUNT_Two,FV_COUNT_Three,FV_COUNT_Four,FV_COUNT_Five,FV_COUNT_Six,FV_COUNT_Seven,FV_COUNT_Eight,FV_COUNT_Nine,FV_COUNT_Ten,FV_COUNT_Eleven,FV_COUNT_Twelve,FV_COUNT_Thirt...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CountFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: StartleSourceFlagList<br/>
    /// Default: (FV_STARTLE_Alarm,FV_STARTLE_RobotArm,FV_STARTLE_Centrifuge,FV_STARTLE_Explosives,FV_STARTLE_Generator,FV_STARTLE_RoboTrex)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> StartleSourceFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ArrayProperty: InvestigateTargetFlagList<br/>
    /// Default: (FV_INVTARGET_Grate,FV_INVTARGET_WallVent,FV_INVTARGET_WallOpening,FV_INVTARGET_Mine,FV_INVTARGET_WeaponCrate,FV_INVTARGET_WeakWall,FV_INVTARGET_Window,FV_INVTARGET_AlarmSystem,FV_INVTARGET_RobotArm,F...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> InvestigateTargetFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ArrayProperty: GuardTypeFlagList<br/>
    /// Default: (FV_GUARDTYPE_Zone,FV_GUARDTYPE_Door,FV_GUARDTYPE_ChemCarrier,FV_GUARDTYPE_Uplink,FV_GUARDTYPE_TopFloor)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> GuardTypeFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: MapNameFlagList<br/>
    /// Default: (FV_MAPNAME_CityX_01,FV_MAPNAME_CityX_03,FV_MAPNAME_CityX_06,FV_MAPNAME_CityX_08,FV_MAPNAME_CityX_09,FV_MAPNAME_CityX_14,FV_MAPNAME_CityX_19,FV_MAPNAME_CityX_U16,FV_MAPNAME_CityY_02,FV_MAPNAME_CityY_0...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MapNameFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: IslandFlagList<br/>
    /// Default: (FV_ISLAND_X,FV_ISLAND_Y,FV_ISLAND_Z,FV_ISLAND_Stagg,FV_ISLAND_VPKillerCroc)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> IslandFlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ArrayProperty: DroneTypeList<br/>
    /// Default: (FV_DRONETYPE_Rattler,FV_DRONETYPE_Mamba,FV_DRONETYPE_Boa,FV_DRONETYPE_Cobra,FV_DRONETYPE_TwinRattler,FV_DRONETYPE_Diamondback,FV_DRONETYPE_Dragon,FV_DRONETYPE_Python,FV_DRONETYPE_Serpent)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DroneTypeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ArrayProperty: TankBattleList<br/>
    /// Default: (FV_TANKBATTLE_ClockTower,FV_TANKBATTLE_HeavyCannon,FV_TANKBATTLE_Graveyard,FV_TANKBATTLE_GCPD,FV_TANKBATTLE_Beacon,FV_TANKBATTLE_Beacon1,FV_TANKBATTLE_BotanicalDropOff,FV_TANKBATTLE_Botanical,FV_TANK...
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TankBattleList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ArrayProperty: DroneCommanderList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DroneCommanderList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: CombatTirednessList<br/>
    /// Default: (FV_COMBATTIREDNESS_Knackered,FV_COMBATTIREDNESS_Tired,FV_COMBATTIREDNESS_Normal)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CombatTirednessList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ArrayProperty: TakedownTypeList<br/>
    /// Default: (FV_TAKEDOWNTYPE_Generic,FV_TAKEDOWNTYPE_Arm,FV_TAKEDOWNTYPE_Leg,FV_TAKEDOWNTYPE_Head,FV_TAKEDOWNTYPE_BigGuy)
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TakedownTypeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// Enum: FlagTypeEnum
    /// </summary>
    public enum FlagTypeEnum : byte
    {
        FT_Fail = 0,
        FT_Event = 1,
        FT_Fear = 2,
        FT_Group = 3,
        FT_Delivery = 4,
        FT_PlayerName = 5,
        FT_PlayerGender = 6,
        FT_AwareOfPlayer = 7,
        FT_CanRespond = 8,
        FT_PlayerSeenBefore = 9,
        FT_PlayerSeenThisChase = 10,
        FT_PlayerSeenRecently = 11,
        FT_PlayerCloseToLastSighting = 12,
        FT_PlayerUnderGrate = 13,
        FT_DoingJobThemself = 14,
        FT_DoneManDown = 15,
        FT_DoneManyManDowns = 16,
        FT_IsGoingToBeRevived = 17,
        FT_MedicShovingIn = 18,
        FT_MedicIsClose = 19,
        FT_CasualtyIsMedic = 20,
        FT_CasualtyIsMinigunner = 21,
        FT_ObviousInjury = 22,
        FT_MultipleManDownsNearby = 23,
        FT_MedicHasArrived = 24,
        FT_MiniManDownTime = 25,
        FT_MiniManDownInstCloseToCas = 26,
        FT_MiniManDownSupportCloseToInst = 27,
        FT_IsMiniManDown = 28,
        FT_RetryingInterruptedCheckin = 29,
        FT_PlayerSeenBeforeTakedown = 30,
        FT_ActiveCount = 31,
        FT_CasualtyCount = 32,
        FT_IsLastMan = 33,
        FT_KnowsLastMan = 34,
        FT_Weapon = 35,
        FT_Challenge = 36,
        FT_Armoured = 37,
        FT_Medic = 38,
        FT_InjurySource = 39,
        FT_BMBLEverSeen = 40,
        FT_FractureType = 41,
        FT_SubjectLocation = 42,
        FT_Count = 43,
        FT_BankSeenBody = 44,
        FT_StartleSource = 45,
        FT_InvestigateTarget = 46,
        FT_IsExtinguisher = 47,
        FT_GuardType = 48,
        FT_RoomHasLeader = 49,
        FT_RoomHasStealthThug = 50,
        FT_StealthThugLinePlayedRecently = 51,
        FT_MiniDroneUsedInRoom = 52,
        FT_MiniDroneActive = 53,
        FT_ThugNoticedDroneScanBefore = 54,
        FT_VoiceSynthUseDetected = 55,
        FT_ControllerDown = 56,
        FT_SeenPlantAttack = 57,
        FT_ScarecrowImpliedThreatToThugs = 58,
        FT_HardDriveLeaderActive = 59,
        FT_ArkhamKnightIsInPlay = 60,
        FT_ArkhamKnightIsAlone = 61,
        FT_MapName = 62,
        FT_Chapter = 63,
        FT_Island = 64,
        FT_IsDemo = 65,
        FT_DroneType = 66,
        FT_TankBattle = 67,
        FT_DroneCommander = 68,
        FT_CombatTiredness = 69,
        FT_BatmanHit = 70,
        FT_TargetHasAlly = 71,
        FT_TakedownType = 72,
        FT_FightIntensity = 73,
        FT_IsDLCDuo = 74,
        FT_NightWingPresent = 75,
        FT_NeedToOpenGate = 76,
        FT_MoneyHasBeenDumped = 77,
        FT_CoreStory = 78,
        FT_SmokeIsReallySmoke = 79,
        FT_RoomHasMoreThanOneStealthThug = 80,
        FT_MAX = 81,
    }
}
