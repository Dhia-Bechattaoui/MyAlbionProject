using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyAlbionProject;

[Dependency(ReplaceServices = true)]
public class MyAlbionProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyAlbionProject";
}
