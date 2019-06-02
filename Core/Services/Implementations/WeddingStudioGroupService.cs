using System.Linq;
using System.Threading.Tasks;

using Abstractions.Services;

using Dtos.Ouput;

using Entities.ERP;

using EntityFrameworkCore.UnitOfWork;

using Microsoft.EntityFrameworkCore;

using Services.Implementations.Helper;

namespace Services.Implementations
{
    public class WeddingStudioGroupService : IWeddingStudioGroupService
    {
        private readonly IUnitOfWork _unitOfWork;

        public WeddingStudioGroupService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<WeddingStudioGroupDto[]> GetWeddingStudioGroupAsync(int? stateProvinceId, int? districtId)
        {
            return await _unitOfWork.GetRepository<WeddingStudioGroup>()
                .GetAllIncluding(x => x.WeddingStudios)
                .Select(x => x.ToWeddingStudioGroupDto(stateProvinceId, districtId))
                .ToArrayAsync();
        }
    }
}