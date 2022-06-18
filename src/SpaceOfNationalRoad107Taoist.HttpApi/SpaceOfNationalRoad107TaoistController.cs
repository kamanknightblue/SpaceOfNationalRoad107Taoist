using SpaceOfNationalRoad107Taoist.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SpaceOfNationalRoad107Taoist;

public abstract class SpaceOfNationalRoad107TaoistController : AbpControllerBase
{
    protected SpaceOfNationalRoad107TaoistController()
    {
        LocalizationResource = typeof(SpaceOfNationalRoad107TaoistResource);
    }
}
