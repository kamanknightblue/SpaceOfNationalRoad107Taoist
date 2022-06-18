using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace SpaceOfNationalRoad107Taoist.MongoDB;

[ConnectionStringName(SpaceOfNationalRoad107TaoistDbProperties.ConnectionStringName)]
public class SpaceOfNationalRoad107TaoistMongoDbContext : AbpMongoDbContext, ISpaceOfNationalRoad107TaoistMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureSpaceOfNationalRoad107Taoist();
    }
}
