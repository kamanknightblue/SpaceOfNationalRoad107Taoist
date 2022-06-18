using SpaceOfNationalRoad107Taoist.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SpaceOfNationalRoad107Taoist.Blazor;

public abstract class SpaceOfNationalRoad107TaoistComponentBase : AbpComponentBase
{
    protected SpaceOfNationalRoad107TaoistComponentBase()
    {
        LocalizationResource = typeof(SpaceOfNationalRoad107TaoistResource);
    }
}
