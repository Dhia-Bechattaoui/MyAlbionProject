using MyAlbionProject.Samples;
using Xunit;

namespace MyAlbionProject.EntityFrameworkCore.Applications;

[Collection(MyAlbionProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MyAlbionProjectEntityFrameworkCoreTestModule>
{

}
