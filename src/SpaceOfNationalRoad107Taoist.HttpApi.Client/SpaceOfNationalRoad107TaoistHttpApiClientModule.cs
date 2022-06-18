using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class SpaceOfNationalRoad107TaoistHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(SpaceOfNationalRoad107TaoistApplicationContractsModule).Assembly,
            SpaceOfNationalRoad107TaoistRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SpaceOfNationalRoad107TaoistHttpApiClientModule>();
        });

    }
}
