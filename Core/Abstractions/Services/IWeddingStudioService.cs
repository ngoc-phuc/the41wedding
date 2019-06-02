using System.Threading.Tasks;

using Dtos.Ouput;

namespace Abstractions.Services
{
    public interface IWeddingStudioService
    {
        Task<ShortWeddingStudioDto[]> GetWeddingStudioAsync(int weddingStudioGroupId, int? stateProvinceId, int? districtId);
    }
}