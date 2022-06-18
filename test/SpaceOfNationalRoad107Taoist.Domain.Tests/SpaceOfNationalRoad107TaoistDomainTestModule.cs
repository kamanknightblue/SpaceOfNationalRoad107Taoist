using SpaceOfNationalRoad107Taoist.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SpaceOfNationalRoad107Taoist;

[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistEntityFrameworkCoreTestModule)
    )]
public class SpaceOfNationalRoad107TaoistDomainTestModule : AbpModule
{

}
