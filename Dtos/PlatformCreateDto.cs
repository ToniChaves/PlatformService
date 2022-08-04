using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos;

/// <summary>
/// PlatformDto to create platforms
/// </summary>
public class PlatformCreateDto
{
    /// <summary>
    /// Name of platform.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Publisher of the platform.
    /// </summary>
    [Required]
    public string Publisher { get; set; }

    /// <summary>
    /// Cost of the platform.
    /// </summary>
    [Required]
    public string Cost { get; set; }
}
