using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace SpaceOfNationalRoad107Taoist.Samples;

[Area(SpaceOfNationalRoad107TaoistRemoteServiceConsts.ModuleName)]
[RemoteService(Name = SpaceOfNationalRoad107TaoistRemoteServiceConsts.RemoteServiceName)]
[Route("api/SpaceOfNationalRoad107Taoist/sample")]
public class SampleController : SpaceOfNationalRoad107TaoistController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
