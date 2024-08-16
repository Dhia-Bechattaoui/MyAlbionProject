using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyAlbionProject.Data;

/* This is used if database provider does't define
 * IMyAlbionProjectDbSchemaMigrator implementation.
 */
public class NullMyAlbionProjectDbSchemaMigrator : IMyAlbionProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
