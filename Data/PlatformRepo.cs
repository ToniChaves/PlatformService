using PlatformService.Models;
using System.Linq;

namespace PlatformService.Data;

/// <summary>
/// Class that implements IPlatformRepo
/// <see cref="IPlatformRepo"/>
/// </summary>
public class PlatformRepo : IPlatformRepo
{
    private readonly AppDbContext context;

    /// <summary>
    /// PlatformRepo constructor
    /// </summary>
    /// <param name="context"><see cref="AppDbContext"/></param>
    public PlatformRepo(AppDbContext context)
    {
        this.context=context;
    }

    /// <inheritdoc/>
    public void CreatePlatform(Platform platform)
    {
        if (platform == null)
        {
            throw new ArgumentNullException(nameof(platform));
        }

        context.Platforms.Add(platform);
    }

    /// <inheritdoc/>
    public IEnumerable<Platform> GetAllPlatforms()
    {
        return context.Platforms.ToList();
    }

    /// <inheritdoc/>
    public Platform GetPlatformById(int id)
    {
        return context.Platforms.FirstOrDefault(x => x.Id == id);
    }

    /// <inheritdoc/>
    public bool SaveChanges()
    {
        return (context.SaveChanges() > 0);
    }
}
