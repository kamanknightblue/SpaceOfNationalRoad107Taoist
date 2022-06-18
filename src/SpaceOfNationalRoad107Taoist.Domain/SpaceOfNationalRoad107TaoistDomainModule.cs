using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SpaceOfNationalRoad107TaoistDomainSharedModule)
)]
public class SpaceOfNationalRoad107TaoistDomainModule : AbpModule
{

}
