using Volo.Abp.Settings;

namespace MyAlbionProject.Settings;

public class MyAlbionProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyAlbionProjectSettings.MySetting1));
    }
}
