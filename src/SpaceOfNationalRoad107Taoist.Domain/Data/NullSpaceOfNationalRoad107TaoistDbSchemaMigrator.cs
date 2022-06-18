using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SpaceOfNationalRoad107Taoist.Data;

/* This is used if database provider does't define
 * ISpaceOfNationalRoad107TaoistDbSchemaMigrator implementation.
 */
public class NullSpaceOfNationalRoad107TaoistDbSchemaMigrator : ISpaceOfNationalRoad107TaoistDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
