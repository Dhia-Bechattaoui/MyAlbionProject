using MyAlbionProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyAlbionProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyAlbionProjectEntityFrameworkCoreModule),
    typeof(MyAlbionProjectApplicationContractsModule)
    )]
public class MyAlbionProjectDbMigratorModule : AbpModule
{
}
