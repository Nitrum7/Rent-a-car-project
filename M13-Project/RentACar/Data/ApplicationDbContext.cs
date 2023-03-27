using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACar.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Create user - administrator
            User adminG = CreateUser("gagov@abv.bg");
            User adminM = CreateUser("murtin@abv.bg");
            User adminS = CreateUser("syuleymezyan@abv.bg");

            builder.Entity<User>().HasData(adminG);
            builder.Entity<User>().HasData(adminM);
            builder.Entity<User>().HasData(adminS);

            // Create roles
            IdentityRole adminRole = CreateRole("Admin");

            IdentityRole customerRole = CreateRole("Customer");

            builder.Entity<IdentityRole>(
                option =>
                {
                    option.HasData(new IdentityRole[]
                    {
                        adminRole,
                        customerRole
                    }
                    );
                });


            //Add user to role
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = adminG.Id
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = adminM.Id
            }); builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = adminS.Id
            });
            Random random = new Random();

            //Add customers
            for (int i = 0; i < 100; i++)
            {
                User user = CreateUser($"customer{i}@abv.bg");               

                builder.Entity<User>().HasData(user);              

                builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = customerRole.Id,
                    UserId = user.Id
                });
            }
           
        }
        private User CreateUser(string email, string password = "123456")
        {
            List<string> firstName = new List<string>() { "Peter", "Nikolay", "Nasko", "Kiro" };
            List<string> lastName = new List<string>() { "Gagov", "Noto", "Murtin", "Tsanov", "Syuleymezyan" };
            string[] egeneto = new string[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                egeneto[i] = random.Next(0, 9).ToString();
            }
            var hasher = new PasswordHasher<IdentityUser>();
            //Create user
            User user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = email,
                NormalizedUserName = email,
                Email = email,
                NormalizedEmail = email,
                EGN = string.Join("", egeneto),
                EmailConfirmed = false,
                PasswordHash = hasher.HashPassword(null, password),
                SecurityStamp = string.Empty,
                FirstName = firstName[random.Next(0, firstName.Count)],
                LastName = lastName[random.Next(0, lastName.Count)]
            };
            return user;
        }
        private static IdentityRole CreateRole(string roleName)
        {
            return new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = roleName, NormalizedName = roleName };
        }
    }
}
