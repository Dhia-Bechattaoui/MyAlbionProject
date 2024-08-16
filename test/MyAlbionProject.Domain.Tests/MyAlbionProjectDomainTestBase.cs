using Volo.Abp.Modularity;

namespace MyAlbionProject;

/* Inherit from this class for your domain layer tests. */
public abstract class MyAlbionProjectDomainTestBase<TStartupModule> : MyAlbionProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
