using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SpaceOfNationalRoad107Taoist.EntityFrameworkCore;

[ConnectionStringName(SpaceOfNationalRoad107TaoistDbProperties.ConnectionStringName)]
public interface ISpaceOfNationalRoad107TaoistDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
