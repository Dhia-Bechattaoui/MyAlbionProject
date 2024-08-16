using System.Threading.Tasks;

namespace MyAlbionProject.Data;

public interface IMyAlbionProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
