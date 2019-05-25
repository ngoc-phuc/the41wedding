using Common;
using Dtos;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Abstractions.Services
{
    public interface ITokenService
    {
        Task<JwtTokenResultDto> RequestTokenAsync(ClaimsIdentity identity, ApplicationType application);
    }
}
