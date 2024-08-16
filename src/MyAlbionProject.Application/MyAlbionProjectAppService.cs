using System;
using System.Collections.Generic;
using System.Text;
using MyAlbionProject.Localization;
using Volo.Abp.Application.Services;

namespace MyAlbionProject;

/* Inherit your application services from this class.
 */
public abstract class MyAlbionProjectAppService : ApplicationService
{
    protected MyAlbionProjectAppService()
    {
        LocalizationResource = typeof(MyAlbionProjectResource);
    }
}
