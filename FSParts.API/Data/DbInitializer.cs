using FSParts.API.Entities;
using FSParts.API.Models;
using Microsoft.AspNetCore.Identity;

namespace FSParts.API.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(FleetSurvey_LocalContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "Harrison",
                    Email = "Harrison@test.com"
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");
                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };
                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });
            }
        }
    }
}
