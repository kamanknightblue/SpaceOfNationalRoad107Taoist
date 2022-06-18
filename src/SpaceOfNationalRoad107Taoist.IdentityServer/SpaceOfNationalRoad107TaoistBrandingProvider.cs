using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SpaceOfNationalRoad107Taoist;

[Dependency(ReplaceServices = true)]
public class SpaceOfNationalRoad107TaoistBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SpaceOfNationalRoad107Taoist";
}
