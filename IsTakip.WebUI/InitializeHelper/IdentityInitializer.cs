using IsTakip.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace IsTakip.WebUI.InitializeHelper
{
    public static class IdentityInitializer
    {

        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {

            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }


            var adminUser = await userManager.FindByNameAsync("lbilinmis");
            if (adminUser == null)
            {
                AppUser user = new AppUser
                {
                    UserName = "lbilinmis",
                    Name = "Levent",
                    SurName = "BİLİNMİŞ",
                    Email = "lbilinmis@bilinmis.com",Picture=""
                };

                await userManager.CreateAsync(user,"1");

                await userManager.AddToRoleAsync(user, "Admin");
            }

        }
    }
}
