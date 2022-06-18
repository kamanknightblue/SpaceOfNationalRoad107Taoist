using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SpaceOfNationalRoad107Taoist.EntityFrameworkCore;

public class SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContext : AbpDbContext<SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContext>
{
    public SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContext(DbContextOptions<SpaceOfNationalRoad107TaoistHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureSpaceOfNationalRoad107Taoist();
    }
}
