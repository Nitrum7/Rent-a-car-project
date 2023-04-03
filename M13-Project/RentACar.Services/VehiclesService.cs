using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Services.Contracts;
using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services
{
    public class VehiclesServiceL : IVehiclesService
    {
        private readonly ApplicationDbContext context;

        public VehiclesServiceL(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IndexVehiclesViewModel> GetIndexVehiclesAsync(int page = 1, int count = 10)
        {
            IndexVehiclesViewModel model = new IndexVehiclesViewModel();

            model.ItemsPerPage = count;
            model.Page = page;
            model.Vehicles = await this.context.Vehicles
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexVehicleViewModel()
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
    }
}
