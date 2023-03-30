using Microsoft.AspNetCore.Identity;
using RentACar.Common;
using RentACar.Data.Seeder.Contracts;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.Seeder
{
    public class VehicleSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Vehicles.Any())
            {
                return;
            }

            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();

                string brand = SeederConstants.carBrands[random.Next(0, SeederConstants.carBrands.Count - 1)];
                string model = SeederConstants.carModels[random.Next(0, SeederConstants.carModels.Count - 1)];
                int seats = SeederConstants.carSeats[random.Next(0, SeederConstants.carSeats.Count - 1)];
                int range = (DateTime.Today - SeederConstants.start).Days;

                DateTime randomDate = SeederConstants.start.AddDays(random.Next(range));

                Vehicle vehicle = new Vehicle()
                {
                    Brand = brand,
                    Model = model,
                    Year = randomDate,
                    PricePerDay = (decimal)random.NextDouble() * (90.00m - 20.00m) + 20.00m,
                    PassengerSeats = seats,              
                };

                await dbContext.Vehicles.AddAsync(vehicle);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
