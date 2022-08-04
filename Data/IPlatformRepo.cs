using PlatformService.Models;

namespace PlatformService.Data;

/// <summary>
/// Interface of PlatformRepo
/// </summary>
public interface IPlatformRepo
{
    /// <summary>
    /// Method to save changes on database
    /// </summary>
    /// <returns><see cref="bool"/></returns>
    bool SaveChanges();

    /// <summary>
    /// Gets all platforms from database
    /// </summary>
    /// <returns><see cref="IEnumerable"/></returns>
    IEnumerable<Platform> GetAllPlatforms();

    /// <summary>
    /// Gets only one platform by ID
    /// </summary>
    /// <param name="id">Platform Id</param>
    /// <returns><see cref="Platform"/></returns>
    Platform GetPlatformById(int id);

    /// <summary>
    /// Creates a new platform
    /// </summary>
    /// <param name="platform"><see cref="Platform"/></param>
    void CreatePlatform(Platform platform);
}
