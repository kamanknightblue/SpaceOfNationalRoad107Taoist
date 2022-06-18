using Volo.Abp.Reflection;

namespace SpaceOfNationalRoad107Taoist.Permissions;

public class SpaceOfNationalRoad107TaoistPermissions
{
    public const string GroupName = "SpaceOfNationalRoad107Taoist";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(SpaceOfNationalRoad107TaoistPermissions));
    }
}
