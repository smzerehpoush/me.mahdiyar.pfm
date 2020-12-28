using Volo.Abp.Settings;

namespace me.mahdiyar.pfm.Settings
{
    public class pfmSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(pfmSettings.MySetting1));
        }
    }
}
