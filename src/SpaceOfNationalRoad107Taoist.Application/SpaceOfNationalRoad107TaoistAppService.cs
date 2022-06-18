using SpaceOfNationalRoad107Taoist.Localization;
using Volo.Abp.Application.Services;

namespace SpaceOfNationalRoad107Taoist;

public abstract class SpaceOfNationalRoad107TaoistAppService : ApplicationService
{
    protected SpaceOfNationalRoad107TaoistAppService()
    {
        LocalizationResource = typeof(SpaceOfNationalRoad107TaoistResource);
        ObjectMapperContext = typeof(SpaceOfNationalRoad107TaoistApplicationModule);
    }
}
