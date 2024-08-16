using MyAlbionProject.Samples;
using Xunit;

namespace MyAlbionProject.EntityFrameworkCore.Domains;

[Collection(MyAlbionProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MyAlbionProjectEntityFrameworkCoreTestModule>
{

}
