using System;
using System.Collections.Generic;
using System.Text;
using SpaceOfNationalRoad107Taoist.Localization;
using Volo.Abp.Application.Services;

namespace SpaceOfNationalRoad107Taoist;

/* Inherit your application services from this class.
 */
public abstract class SpaceOfNationalRoad107TaoistAppService : ApplicationService
{
    protected SpaceOfNationalRoad107TaoistAppService()
    {
        LocalizationResource = typeof(SpaceOfNationalRoad107TaoistResource);
    }
}
