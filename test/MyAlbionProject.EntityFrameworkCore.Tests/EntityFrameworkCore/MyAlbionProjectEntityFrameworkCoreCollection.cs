using Xunit;

namespace MyAlbionProject.EntityFrameworkCore;

[CollectionDefinition(MyAlbionProjectTestConsts.CollectionDefinitionName)]
public class MyAlbionProjectEntityFrameworkCoreCollection : ICollectionFixture<MyAlbionProjectEntityFrameworkCoreFixture>
{

}
