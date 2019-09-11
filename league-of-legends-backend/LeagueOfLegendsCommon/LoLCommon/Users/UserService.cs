using System;
using System.Linq;
using IdentityModel;
using Microsoft.AspNetCore.Http;

namespace LoLCommon.Users
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public string UserName
        {
            get
            {
                var claims = _httpContextAccessor.GetUserClaimsOrEmpty()
                    .ToArray();

                if (claims.Length > 0)
                {
                    var firstName = claims.GetClaimValueOrEmpty(JwtClaimTypes.Name);
                    var lastName = claims.GetClaimValueOrEmpty(JwtClaimTypes.FamilyName);

                    if (!string.IsNullOrEmpty(firstName)
                        && !string.IsNullOrEmpty(lastName))
                    {
                        return $"{firstName} {lastName}";
                    }
                }

                return Environment.UserName;
            }
        }
    }
}
