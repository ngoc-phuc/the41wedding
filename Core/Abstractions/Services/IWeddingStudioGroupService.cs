using System.Threading.Tasks;

using Dtos.Ouput;

namespace Abstractions.Services
{
    public interface IWeddingStudioGroupService
    {
        Task<WeddingStudioGroupDto[]> GetWeddingStudioGroupAsync(int? stateProvinceId, int? districtId);
    }
}