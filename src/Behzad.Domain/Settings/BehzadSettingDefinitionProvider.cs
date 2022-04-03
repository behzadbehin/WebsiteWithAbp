using Volo.Abp.Settings;

namespace Behzad.Settings;

public class BehzadSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BehzadSettings.MySetting1));
    }
}
