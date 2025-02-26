using Microsoft.AspNetCore.Identity;

namespace api.Seeders;

public static class IdentityRoleSeederData
{
    public static List<IdentityRole> GetData()
    {
        var roles = new List<IdentityRole>
        {
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER"
            },
        };

        return roles;
    }
}
