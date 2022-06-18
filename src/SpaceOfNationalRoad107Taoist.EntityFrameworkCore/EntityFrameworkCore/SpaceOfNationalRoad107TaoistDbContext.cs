using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SpaceOfNationalRoad107Taoist.EntityFrameworkCore;

[ConnectionStringName(SpaceOfNationalRoad107TaoistDbProperties.ConnectionStringName)]
public class SpaceOfNationalRoad107TaoistDbContext : AbpDbContext<SpaceOfNationalRoad107TaoistDbContext>, ISpaceOfNationalRoad107TaoistDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public SpaceOfNationalRoad107TaoistDbContext(DbContextOptions<SpaceOfNationalRoad107TaoistDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureSpaceOfNationalRoad107Taoist();
    }
}
