using Microsoft.AspNetCore.Identity;
using WebShopper.Models;

namespace WebShopper.Services
{
    public class DatabaseInitializer
    {
        public static async Task SeedDataAsync(UserManager<ApplicationUser>? userManager,
            RoleManager<IdentityRole>? roleManager)
        {
            if (userManager == null || roleManager == null)
            {
                Console.WriteLine("Brak danych");
                return;
            }

            // check if we have the admin role or not
            var exists = await roleManager.RoleExistsAsync("admin");
            if (!exists)
            {
                Console.WriteLine("Rola administratora nie jest zdefiniowana i zostanie utworzona");
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }

            // check if we have the seller role or not
            exists = await roleManager.RoleExistsAsync("seller");
            if (!exists)
            {
                Console.WriteLine("Rola sprzedawcy nie jest zdefiniowana i zostanie utworzona");
                await roleManager.CreateAsync(new IdentityRole("seller"));
            }


            // check if we have the client role or not
            exists = await roleManager.RoleExistsAsync("client");
            if (!exists)
            {
                Console.WriteLine("Rola klienta nie jest zdefiniowana i zostanie utworzona");
                await roleManager.CreateAsync(new IdentityRole("client"));
            }


            // check if we have at least one admin user or not
            var adminUsers = await userManager.GetUsersInRoleAsync("admin");
            if (adminUsers.Any())
            {
                // Admin user already exists => exit
                Console.WriteLine("Użytkownik admin już istnieje => wyjście");
                return;
            }


            // create the admin user
            var user = new ApplicationUser()
            {
                FirstName = "Admin",
                LastName = "Admin",
                UserName = "admin@admin.com", 
                Email = "admin@admin.com",
                CreatedAt = DateTime.Now,
            };

            string initialPassword = "admin123";


            var result = await userManager.CreateAsync(user, initialPassword);
            if (result.Succeeded)
            {
                // set the user role
                await userManager.AddToRoleAsync(user, "admin");
                Console.WriteLine("Użytkownik admin został pomyślnie utworzony! Proszę zmienić hasło!");
                Console.WriteLine("Email: " + user.Email);
                Console.WriteLine("Hasło: " + initialPassword);
            }
        }
    }
}

