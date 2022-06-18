using SpaceOfNationalRoad107Taoist.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SpaceOfNationalRoad107Taoist.Permissions;

public class SpaceOfNationalRoad107TaoistPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SpaceOfNationalRoad107TaoistPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SpaceOfNationalRoad107TaoistPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SpaceOfNationalRoad107TaoistResource>(name);
    }
}
