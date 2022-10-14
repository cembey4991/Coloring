using Coloring.Entity.Entities;
using Microsoft.AspNetCore.Identity;

namespace Coloring.Web
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager) 
        {
            var memberRole = await roleManager.FindByNameAsync("Member");
            if(memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }
            var memberUser = await userManager.FindByNameAsync("cem");
            if (memberUser == null)
            {
                AppUser user = new AppUser
                {
                    Name="Cem",
                    Surname="Badem",
                    UserName="cembey",
                    Email="cembey4991@gmail.com"

                };
                await userManager.CreateAsync(user,"1");
                await userManager.AddToRoleAsync(user, "Member");
            }
        }

    }
}
