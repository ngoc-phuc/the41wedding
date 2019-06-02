using System.Threading.Tasks;

using Dtos.Shared;

namespace Abstractions.Services
{
    public interface IDataService
    {
        Task<DictionaryItemDto[]> GetAllStateProvinceAsync();

        Task<DictionaryItemDto[]> GetDistrictOfStateProvinceAsync(int stateProvinceId);

        Task<DictionaryItemDto[]> GetCommuneOfDistrictAsync(int districtId);
    }
}