using MyAlbionProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyAlbionProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyAlbionProjectController : AbpControllerBase
{
    protected MyAlbionProjectController()
    {
        LocalizationResource = typeof(MyAlbionProjectResource);
    }
}
