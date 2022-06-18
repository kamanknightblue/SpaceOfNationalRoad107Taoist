using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SpaceOfNationalRoad107Taoist.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SpaceOfNationalRoad107TaoistDbContextFactory : IDesignTimeDbContextFactory<SpaceOfNationalRoad107TaoistDbContext>
{
    public SpaceOfNationalRoad107TaoistDbContext CreateDbContext(string[] args)
    {
        SpaceOfNationalRoad107TaoistEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SpaceOfNationalRoad107TaoistDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SpaceOfNationalRoad107TaoistDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SpaceOfNationalRoad107Taoist.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
