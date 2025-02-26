using System.Security.Claims;

namespace api.Extensions
{
    public static class ClaimExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            var claim = user.FindFirst(ClaimTypes.GivenName);
            
            return claim?.Value ?? string.Empty;
        }    
    }
}
