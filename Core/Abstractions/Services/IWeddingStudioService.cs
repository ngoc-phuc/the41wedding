using System.Threading.Tasks;

using Dtos.Ouput;

namespace Abstractions.Services
{
    public interface IWeddingStudioService
    {
        // lâý all các studio thuộc group, cho lọc theo tỉnh/ huyện
        Task<ShortWeddingStudioDto[]> GetAllWeddingStudioAsync(int weddingStudioGroupId, int? stateProvinceId, int? districtId);

        //chi tiết studio, có dánh ách sản phẩm của studio
        Task<WeddingStudioDto> GetWeddingStudioAsync(int weddingStudioId);
    }
}