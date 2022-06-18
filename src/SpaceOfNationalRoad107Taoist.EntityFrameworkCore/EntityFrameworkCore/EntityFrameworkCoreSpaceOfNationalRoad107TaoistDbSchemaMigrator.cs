using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpaceOfNationalRoad107Taoist.Data;
using Volo.Abp.DependencyInjection;

namespace SpaceOfNationalRoad107Taoist.EntityFrameworkCore;

public class EntityFrameworkCoreSpaceOfNationalRoad107TaoistDbSchemaMigrator
    : ISpaceOfNationalRoad107TaoistDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSpaceOfNationalRoad107TaoistDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SpaceOfNationalRoad107TaoistDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SpaceOfNationalRoad107TaoistDbContext>()
            .Database
            .MigrateAsync();
    }
}
