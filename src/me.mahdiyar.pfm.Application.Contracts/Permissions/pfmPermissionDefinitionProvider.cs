using me.mahdiyar.pfm.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace me.mahdiyar.pfm.Permissions
{
    public class pfmPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(pfmPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(pfmPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<pfmResource>(name);
        }
    }
}
