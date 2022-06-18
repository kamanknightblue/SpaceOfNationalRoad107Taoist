using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SpaceOfNationalRoad107Taoist.Blazor;

[Dependency(ReplaceServices = true)]
public class SpaceOfNationalRoad107TaoistBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SpaceOfNationalRoad107Taoist";
}
