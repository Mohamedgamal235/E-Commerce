using E_Commerce.Models;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce.DataSeeding
{
    public class DataSeeder
    {
        public static async Task SeedRolesAndAdminAsync(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            string[] roleNames = { "Admin", "Seller", "Customer" };
            //"Finance", "Shipper", "Customer_Support",
            //"Marketer", "Analytical", "Store_Admin",
            //"Super_Admin", "Warehouse_Manager"


            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            string adminEmail = "admin@shop.com";
            string adminPassword = "Admin@123";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                var newAdmin = new User
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(newAdmin, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newAdmin, "Admin");
                }
            }
        }
    }
}
