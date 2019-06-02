using System.Linq;
using System.Threading.Tasks;

using Abstractions.Services;

using Dtos.Ouput;

using Entities.ERP;

using EntityFrameworkCore.Helpers.Linq;
using EntityFrameworkCore.UnitOfWork;

using Microsoft.EntityFrameworkCore;

using Services.Implementations.Helper;

namespace Services.Implementations
{
    public class WeddingStudioService :IWeddingStudioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public WeddingStudioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ShortWeddingStudioDto[]> GetWeddingStudioAsync(int weddingStudioGroupId, int? stateProvinceId, int? districtId)
        {
            return await _unitOfWork.GetRepository<WeddingStudio>()
                .GetAllIncluding(x => x.WeddingStudioReviews, x => x.WeddingStudioProducts)
                .Where(x => x.FK_WeddingStudioGroupID == weddingStudioGroupId)
                .WhereIf(stateProvinceId.HasValue, x => x.FK_StateProvinceID == stateProvinceId)
                .WhereIf(districtId.HasValue, x => x.FK_DistrictID == districtId)
                .Select(x => x.ToWeddingStudioDto())
                .ToArrayAsync();
        }
    }
}