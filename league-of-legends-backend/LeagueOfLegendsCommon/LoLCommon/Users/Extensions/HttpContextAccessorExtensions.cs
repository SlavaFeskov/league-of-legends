using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace LoLCommon.Users
{
    public static class HttpContextAccessorExtensions
    {
        internal static readonly IEnumerable<Claim> EmptyClaims = Enumerable.Empty<Claim>();

        internal static IEnumerable<Claim> GetUserClaimsOrEmpty(this IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor == null)
            {
                throw new ArgumentNullException(nameof(httpContextAccessor));
            }

            return httpContextAccessor.HttpContext?.User?.Claims ?? EmptyClaims;
        }
    }
}
