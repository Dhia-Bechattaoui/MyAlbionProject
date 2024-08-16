using Volo.Abp.Modularity;

namespace MyAlbionProject;

[DependsOn(
    typeof(MyAlbionProjectApplicationModule),
    typeof(MyAlbionProjectDomainTestModule)
)]
public class MyAlbionProjectApplicationTestModule : AbpModule
{

}
