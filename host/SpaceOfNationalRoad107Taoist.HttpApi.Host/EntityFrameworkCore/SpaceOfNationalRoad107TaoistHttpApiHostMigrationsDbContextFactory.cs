using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SpaceOfNationalRoad107Taoist.EntityFrameworkCore;

public class SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContext>
{
    public SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("SpaceOfNationalRoad107Taoist"));

        return new SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
