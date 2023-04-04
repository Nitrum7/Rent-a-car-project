namespace RentACar.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using RentACar.Models;

    // Add-Migration InitialMigration -OutputDir Migrations  -Project RentACar.Data -StartupProject RentACar.Web
    // Update-Database -Project RentACar.Data -StartupProject RentACar.Web
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; }

        public virtual DbSet<Request> Requests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
            
        }
    }
}
