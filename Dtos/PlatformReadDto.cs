namespace PlatformService.Dtos;

/// <summary>
/// PlatformRead Dto
/// </summary>
public class PlatformReadDto
{
    /// <summary>
    /// Id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of platform.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Publisher of the platform.
    /// </summary>
    public string Publisher { get; set; }

    /// <summary>
    /// Cost of the platform.
    /// </summary>
    public string Cost { get; set; }
}
