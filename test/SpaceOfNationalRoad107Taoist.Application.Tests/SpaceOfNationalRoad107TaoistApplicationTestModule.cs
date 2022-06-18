using Volo.Abp.Modularity;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistApplicationModule),
    typeof(SpaceOfNationalRoad107TaoistDomainTestModule)
    )]
public class SpaceOfNationalRoad107TaoistApplicationTestModule : AbpModule
{

}
