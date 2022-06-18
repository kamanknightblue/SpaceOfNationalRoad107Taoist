using SpaceOfNationalRoad107Taoist.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SpaceOfNationalRoad107Taoist;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(SpaceOfNationalRoad107TaoistEntityFrameworkCoreTestModule)
    )]
public class SpaceOfNationalRoad107TaoistDomainTestModule : AbpModule
{

}
