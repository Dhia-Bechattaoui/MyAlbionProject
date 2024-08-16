using Volo.Abp.Modularity;

namespace MyAlbionProject;

public abstract class MyAlbionProjectApplicationTestBase<TStartupModule> : MyAlbionProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
