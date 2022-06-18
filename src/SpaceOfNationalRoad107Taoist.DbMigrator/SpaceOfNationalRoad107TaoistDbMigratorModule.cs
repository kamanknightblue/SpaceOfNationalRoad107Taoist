using SpaceOfNationalRoad107Taoist.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SpaceOfNationalRoad107Taoist.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SpaceOfNationalRoad107TaoistEntityFrameworkCoreModule),
    typeof(SpaceOfNationalRoad107TaoistApplicationContractsModule)
    )]
public class SpaceOfNationalRoad107TaoistDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
