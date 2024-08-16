using MyAlbionProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyAlbionProject.Permissions;

public class MyAlbionProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyAlbionProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MyAlbionProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyAlbionProjectResource>(name);
    }
}
