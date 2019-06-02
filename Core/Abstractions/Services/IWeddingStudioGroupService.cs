using Dtos.Ouput;
using Dtos.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Services
{
    public interface IWeddingStudioGroupService
    {
        Task<WeddingStudioGroupDto[]> GetAllStudioGroupAsync();
    }
}
