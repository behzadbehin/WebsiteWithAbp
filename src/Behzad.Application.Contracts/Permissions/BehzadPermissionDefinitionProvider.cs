using Behzad.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Behzad.Permissions;

public class BehzadPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BehzadPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BehzadPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BehzadResource>(name);
    }
}
