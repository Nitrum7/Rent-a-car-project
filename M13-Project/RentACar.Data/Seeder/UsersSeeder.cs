using RentACar.Common;
using RentACar.Data.Seeder.Contracts;
using RentACar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Data.Seeding
{
    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Any())
            {
                return;
            }

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            await SeedUserAsync(dbContext, userManager, roleManager, SeederConstants.AdminFirstName, SeederConstants.AdminLastName, SeederConstants.AdminEmail, SeederConstants.Password, GlobalConstants.AdminRole);


            // Add Users/Clients
            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();

                string firstName = SeederConstants.firstNames[random.Next(0, SeederConstants.firstNames.Count - 1)];
                string lastName = SeederConstants.lastNames[random.Next(0, SeederConstants.lastNames.Count - 1)];
                string email = string.Format(SeederConstants.username, firstName.ToLower(), lastName.ToLower(), i, SeederConstants.mails[random.Next(0, SeederConstants.mails.Count - 1)]);

                await SeedUserAsync(dbContext, userManager, roleManager, firstName, lastName, email, SeederConstants.Password, GlobalConstants.ClientRole);
                await dbContext.SaveChangesAsync();
            }

        }


        private static async Task<User> SeedUserAsync(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, string firstName, string lastName, string email, string password, string roleName)
        {
            User user = await userManager.FindByNameAsync(email);
            if (user == null)
            {
                IdentityResult result = await userManager.CreateAsync(
                    new User()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        UserName = email,
                        Email = email,
                    }, password);


                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }

            user = await userManager.FindByNameAsync(email);

            var roleExists = await roleManager.RoleExistsAsync(roleName);

            if (roleExists)
            {
                var result = await userManager.AddToRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }

            return user;
        }
    }
}
