#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// ABSTRACT Class: AkSDEntity<br/>
/// (size = 252)
/// (flags = 134221971)
/// </summary>
public partial class AkSDEntity : BmSDK.AkAudio.AkSDNode, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntity", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AkSDEntity.
    /// </summary>
    public static AkSDEntity DefaultObject => (AkSDEntity)StaticClass().DefaultObject;

    internal AkSDEntity() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntity(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkSDEntity>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkSDEntity>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkSDEntity>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkSDEntity>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkSDEntity>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkSDEntity>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkSDEntity>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkSDEntity>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Const: EEntityType_SymbolOrFact = 29
    /// </summary>
    public const int EEntityType_SymbolOrFact = 29;

    /// <summary>
    /// Const: EEntityType_Floats = 13
    /// </summary>
    public const int EEntityType_Floats = 13;

    /// <summary>
    /// Const: EEntityType_Object = 64
    /// </summary>
    public const int EEntityType_Object = 64;

    /// <summary>
    /// Const: EEntityType_Buss = 32
    /// </summary>
    public const int EEntityType_Buss = 32;

    /// <summary>
    /// Const: EEntityType_Symbol = 16
    /// </summary>
    public const int EEntityType_Symbol = 16;

    /// <summary>
    /// Const: EEntityType_GameVariable = 8
    /// </summary>
    public const int EEntityType_GameVariable = 8;

    /// <summary>
    /// Const: EEntityType_Parameter = 4
    /// </summary>
    public const int EEntityType_Parameter = 4;

    /// <summary>
    /// Const: EEntityType_Volume = 2
    /// </summary>
    public const int EEntityType_Volume = 2;

    /// <summary>
    /// Const: EEntityType_Numeric = 1
    /// </summary>
    public const int EEntityType_Numeric = 1;

    /// <summary>
    /// Const: EEntityType_Ignore = 0
    /// </summary>
    public const int EEntityType_Ignore = 0;

    private static BmSDK.Framework.FunctionCache.CallSite __fn_GetVariableName;
    /// <summary>
    /// Function: GetVariableName<br/>
    /// Native code at BatmanAK.exe+0xFDF160 in the Steam build
    /// </summary>
    public unsafe virtual BmSDK.FString GetVariableName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.GetVirtual(ref __fn_GetVariableName, "AkAudio.AkSDEntity.GetVariableName", this);
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.CallProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// BoolProperty: ValidName
    /// </summary>
    public unsafe bool ValidName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: Type
    /// </summary>
    public unsafe int Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
}
