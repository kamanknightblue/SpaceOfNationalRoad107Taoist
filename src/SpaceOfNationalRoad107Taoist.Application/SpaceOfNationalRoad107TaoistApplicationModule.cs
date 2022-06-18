using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistDomainModule),
    typeof(SpaceOfNationalRoad107TaoistApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class SpaceOfNationalRoad107TaoistApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<SpaceOfNationalRoad107TaoistApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<SpaceOfNationalRoad107TaoistApplicationModule>(validate: true);
        });
    }
}
