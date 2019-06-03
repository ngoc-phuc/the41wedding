using System.Threading.Tasks;

using Dtos.Ouput;

namespace Abstractions.Services
{
    public interface IWeddingStudioGroupService
    {
        //lấy danh sách group có thể lọc theo tỉnh /huyện
        Task<WeddingStudioGroupDto[]> GetWeddingStudioGroupAsync(int? stateProvinceId, int? districtId);
    }
}