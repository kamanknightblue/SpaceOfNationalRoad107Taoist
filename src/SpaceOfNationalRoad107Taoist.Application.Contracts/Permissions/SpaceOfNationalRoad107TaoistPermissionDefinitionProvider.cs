using SpaceOfNationalRoad107Taoist.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SpaceOfNationalRoad107Taoist.Permissions;

public class SpaceOfNationalRoad107TaoistPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SpaceOfNationalRoad107TaoistPermissions.GroupName, L("Permission:SpaceOfNationalRoad107Taoist"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SpaceOfNationalRoad107TaoistResource>(name);
    }
}
