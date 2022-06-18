using Localization.Resources.AbpUi;
using SpaceOfNationalRoad107Taoist.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class SpaceOfNationalRoad107TaoistHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SpaceOfNationalRoad107TaoistHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<SpaceOfNationalRoad107TaoistResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
