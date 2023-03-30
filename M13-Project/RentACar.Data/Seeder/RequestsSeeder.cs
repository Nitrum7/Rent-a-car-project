using RentACar.Data.Seeder.Contracts;
using RentACar.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.Seeding
{
    public class RequestsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Requests.Any())
            {
                return;
            }

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                User client = dbContext.Users.Skip(random.Next(0, dbContext.Users.Count())).FirstOrDefault();
                Vehicle vehicle = dbContext.Vehicles.Skip(random.Next(0, dbContext.Vehicles.Count())).FirstOrDefault();


                if (client != null && vehicle != null)
                {
                    Request request = new Request()
                    {
                        User = client,
                        Vehicle= vehicle,
                        StartDate = DateTime.UtcNow,
                        EndDate=DateTime.UtcNow.AddDays(random.Next(0, 25))
                    };
                    dbContext.Requests.Add(request);
                }
            }           
            await dbContext.SaveChangesAsync();
        }
    }
}
