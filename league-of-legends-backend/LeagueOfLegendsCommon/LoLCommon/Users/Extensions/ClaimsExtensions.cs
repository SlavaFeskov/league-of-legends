using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace LoLCommon.Users
{
    public static class ClaimsExtensions
    {
        internal static string GetClaimValueOrEmpty(this IEnumerable<Claim> claims, string type)
        {
            if (claims == null)
            {
                throw new ArgumentNullException(nameof(claims));
            }

            if (string.IsNullOrEmpty(type))
            {
                throw new ArgumentNullException(nameof(type));
            }

            return claims?.FirstOrDefault(x => x.Type == type)?.Value ?? string.Empty;
        }
    }
}
