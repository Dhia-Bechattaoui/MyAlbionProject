using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyAlbionProject.Data;
using Volo.Abp.DependencyInjection;

namespace MyAlbionProject.EntityFrameworkCore;

public class EntityFrameworkCoreMyAlbionProjectDbSchemaMigrator
    : IMyAlbionProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMyAlbionProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the MyAlbionProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MyAlbionProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
