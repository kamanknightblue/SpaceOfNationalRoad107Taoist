using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SpaceOfNationalRoad107Taoist.EntityFrameworkCore;

[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class SpaceOfNationalRoad107TaoistEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<SpaceOfNationalRoad107TaoistDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
