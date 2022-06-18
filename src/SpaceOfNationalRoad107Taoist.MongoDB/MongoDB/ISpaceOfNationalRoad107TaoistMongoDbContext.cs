using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace SpaceOfNationalRoad107Taoist.MongoDB;

[ConnectionStringName(SpaceOfNationalRoad107TaoistDbProperties.ConnectionStringName)]
public interface ISpaceOfNationalRoad107TaoistMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
