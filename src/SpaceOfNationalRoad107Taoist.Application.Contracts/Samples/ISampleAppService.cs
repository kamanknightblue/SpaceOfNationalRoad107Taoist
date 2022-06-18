using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SpaceOfNationalRoad107Taoist.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
