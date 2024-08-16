using Volo.Abp.Modularity;

namespace MyAlbionProject;

[DependsOn(
    typeof(MyAlbionProjectDomainModule),
    typeof(MyAlbionProjectTestBaseModule)
)]
public class MyAlbionProjectDomainTestModule : AbpModule
{

}
