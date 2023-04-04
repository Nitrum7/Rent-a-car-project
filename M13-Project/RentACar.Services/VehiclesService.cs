using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RentACar.Common;
using RentACar.Data;
using RentACar.Models;
using RentACar.Services.Contracts;
using RentACar.ViewModels.Users;
using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services
{
    public class VehiclesService : IVehiclesService
    {
        private readonly ApplicationDbContext context;

        public VehiclesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteVehicleByIdAsync(string id)
        {
            Vehicle car = await context.Vehicles.FindAsync(id);
            car.Requests.Clear();
            context.Vehicles.Remove(car);
            await context.SaveChangesAsync();
        }

        public async Task<IndexVehiclesVM> GetIndexVehiclesAsync(int page = 1, int count = 10)
        {
            IndexVehiclesVM model = new IndexVehiclesVM();

            model.ItemsPerPage = count;
            model.Page = page;
            model.Vehicles = await this.context.Vehicles
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexVehicleVM()
                {
                    Id = x.Id,
                    Brand = x.Brand,
                    Model = x.Model,
                    PricePerDay = x.PricePerDay.ToString(),
                    Year = x.Year > DateTime.Now.AddYears(-150) ? x.Year.ToString("yyyy MMMM") : "-",
                })
                .ToListAsync();

            model.ElementsCount = await this.context.Vehicles.CountAsync();


            return model;
        }

        public async Task CreateVehicleAsync(CreateVehiclesVM model)
        {
            Vehicle car = new Vehicle()
            {   
                Brand = model.Brand,
                Model = model.Model,
                Year = model.Year,
                PassengerSeats = model.PassengerSeats,
                Description = model.Description,
                PricePerDay = model.PricePerDay,
            };

            await context.Vehicles.AddAsync(car);
            await context.SaveChangesAsync();
        }

        public async Task<IndexVehicleVM> GetVehicleByIdAsync(string id)
        {
            Vehicle car = await context.Vehicles.FindAsync(id);

            IndexVehicleVM model = null;

            if (car != null)
            {
                model = new IndexVehicleVM()
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year.ToShortDateString(),
                    PassengerSeats = car.PassengerSeats.ToString(),
                    Description = car.Description,
                    PricePerDay = car.PricePerDay.ToString(),
                };
            }

            return model;
        }

        public async Task<EditVehicleVM> GetVehicleToEditByIdAsync(string id)
        {
            Vehicle car = await context.Vehicles.FindAsync(id);
            EditVehicleVM model = null;
            if (car != null)
            {
                model = new EditVehicleVM()
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Model = car.Model,
                    PassengerSeats = car.PassengerSeats,
                    Description = car.Description,
                    PricePerDay = car.PricePerDay,
                    Year = car.Year,
                };
            }
            return model;
        }

        public async Task UpdateVehicleAsync(EditVehicleVM model)
        {
            Vehicle car = await context.Vehicles.FindAsync(model.Id);

            car.Brand = model.Brand;
            car.Model = model.Model;
            car.PassengerSeats = model.PassengerSeats;
            car.Description = model.Description;
            car.Year = model.Year;
            car.PricePerDay = model.PricePerDay;
            context.Vehicles.Update(car);
            await context.SaveChangesAsync();
        }


    }
}
