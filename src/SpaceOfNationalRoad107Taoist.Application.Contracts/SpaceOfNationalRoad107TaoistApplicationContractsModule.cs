using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class SpaceOfNationalRoad107TaoistApplicationContractsModule : AbpModule
{

}
