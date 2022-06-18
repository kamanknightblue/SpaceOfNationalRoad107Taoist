using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SpaceOfNationalRoad107TaoistHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class SpaceOfNationalRoad107TaoistConsoleApiClientModule : AbpModule
{

}
