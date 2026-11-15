#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Interface: RRiddlerLaserInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RRiddlerLaserInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: LaserNoLongerHitting
    /// </summary>
    public unsafe void LaserNoLongerHitting();

    /// <summary>
    /// Function: LaserHit
    /// </summary>
    public unsafe void LaserHit();
}
