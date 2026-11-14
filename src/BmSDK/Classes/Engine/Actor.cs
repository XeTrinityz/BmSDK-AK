using BmSDK.Framework;

namespace BmSDK.Engine;

public partial class Actor
{
    /// <inheritdoc/>
    public override bool IsAlive => IsValid && !bDeleteMe && !bPendingDelete;

    /// <inheritdoc cref="GameObject.Clone"/>
    public new Actor Clone() =>
        Game.SpawnActor(
            Class,
            Location: Location,
            Rotation: Rotation,
            Template: this,
            Owner: Owner
        );
}
