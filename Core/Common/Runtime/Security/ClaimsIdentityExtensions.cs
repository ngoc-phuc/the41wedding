using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Security.Principal;

namespace Common.Runtime.Security
{
    public static class ClaimsIdentityExtensions
    {
        public static int GetUserId(this IIdentity identity)
        {
            Guard.NotNull(identity, nameof(identity));

            var userIdClaim = (identity as ClaimsIdentity)?.Claims.FirstOrDefault(c => c.Type == BysClaimTypes.UserId);
            if (string.IsNullOrEmpty(userIdClaim?.Value))
            {
                throw new AuthenticationException();
            }

            int userId;
            if (!int.TryParse(userIdClaim.Value, out userId))
            {
                throw new AuthenticationException();
            }

            return userId;
        }

        public static string GetUserName(this IIdentity identity)
        {
            Guard.NotNull(identity, nameof(identity));

            return (identity as ClaimsIdentity)?.Claims.FirstOrDefault(c => c.Type == BysClaimTypes.UserDisplayName)?.Value;
        }
    }
}