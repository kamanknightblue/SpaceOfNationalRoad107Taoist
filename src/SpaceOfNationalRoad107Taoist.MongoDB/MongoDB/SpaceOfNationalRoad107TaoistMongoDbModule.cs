using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace SpaceOfNationalRoad107Taoist.MongoDB;

[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class SpaceOfNationalRoad107TaoistMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<SpaceOfNationalRoad107TaoistMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
