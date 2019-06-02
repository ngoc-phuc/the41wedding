using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions.Services;
using Dtos.Ouput;
using Dtos.Shared;
using Entities.ERP;
using EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Services.Implementations.Helper;

namespace Services.Implementations
{
    public class WeddingStudioGroupService : IWeddingStudioGroupService
    {
        private readonly IUnitOfWork unitOfWork;

        public WeddingStudioGroupService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<WeddingStudioGroupDto[]> GetAllStudioGroupAsync()
        {
            return await unitOfWork.GetRepository<WeddingStudioGroup>()
                .GetAll()
                .Select(x => x.ToWeddingStudioGroupDto())
                .ToArrayAsync();
        }
    }
}
