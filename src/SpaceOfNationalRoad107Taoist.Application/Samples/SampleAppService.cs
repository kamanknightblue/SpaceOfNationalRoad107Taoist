using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace SpaceOfNationalRoad107Taoist.Samples;

public class SampleAppService : SpaceOfNationalRoad107TaoistAppService, ISampleAppService
{
    public Task<SampleDto> GetAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    [Authorize]
    public Task<SampleDto> GetAuthorizedAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }
}
