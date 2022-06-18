using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using SpaceOfNationalRoad107Taoist.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(AbpValidationModule)
)]
public class SpaceOfNationalRoad107TaoistDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SpaceOfNationalRoad107TaoistDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<SpaceOfNationalRoad107TaoistResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/SpaceOfNationalRoad107Taoist");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("SpaceOfNationalRoad107Taoist", typeof(SpaceOfNationalRoad107TaoistResource));
        });
    }
}
