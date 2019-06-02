using System;
using System.Linq;
using System.Threading.Tasks;

using Abstractions.Services;

using Dtos.Shared;

using Entities.ERP;

using EntityFrameworkCore.UnitOfWork;

using Microsoft.EntityFrameworkCore;

using Services.Helpers;

namespace Services.Implementations
{
    public class DataService : IDataService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DataService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DictionaryItemDto[]> GetAllStateProvinceAsync()
        {
            return await _unitOfWork.GetRepository<StateProvince>()
                .GetAll()
                .Select(x => x.ToDictionaryItemDto())
                .ToArrayAsync();
        }

        public async Task<DictionaryItemDto[]> GetDistrictOfStateProvinceAsync(int stateProvinceId)
        {
            return await _unitOfWork.GetRepository<District>()
                .GetAll()
                .Where(x => x.FK_StateProvinceID == stateProvinceId)
                .Select(x => x.ToDictionaryItemDto())
                .ToArrayAsync();
        }

        public async Task<DictionaryItemDto[]> GetCommuneOfDistrictAsync(int districtId)
        {
            return await _unitOfWork.GetRepository<Cummune>()
                .GetAll()
                .Where(x => x.FK_DistrictID == districtId)
                .Select(x => x.ToDictionaryItemDto())
                .ToArrayAsync();
        }
    }
}