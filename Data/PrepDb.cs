using PlatformService.Models;

namespace PlatformService.Data;

/// <summary>
/// Prepare database static class
/// this class gonna generate migrations in SQL Server
/// </summary>
public static class PrepDb
{
    /// <summary>
    /// Prepopulates the inmemory database.
    /// </summary>
    /// <param name="app"><see cref="IApplicationBuilder"/></param>
    public static void PrepPopulation(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }
    }

    private static void SeedData(AppDbContext context)
    {
        if (!context.Platforms.Any())
        {
            context.Platforms.AddRange(
                new Platform { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free?"},
                new Platform { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free"},
                new Platform { Name = "Kubernetes", Publisher = "CNCF (Cloud Native Computing Foundation)", Cost = "Free"}
                );

            context.SaveChanges();
        }
    }
}
