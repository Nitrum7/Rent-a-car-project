using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Services.Contracts;
using RentACar.ViewModels.Requests;
using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services
{
    public class VehiclesValidatedService : IValidatedVehiclesService
    {
        private readonly ApplicationDbContext context;

        public VehiclesValidatedService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IndexVehiclesVM> GetIndexValidatedVehiclesAsync(CreateRequestVM createModel, int page = 1, int count = 10)
        {
            IndexVehiclesVM model = new IndexVehiclesVM();

            model.ItemsPerPage = count;
            model.Page = page;
            model.Vehicles = await this.context.Vehicles
                .Where(x => x.Requests.All(r => (r.StartDate >= createModel.StartDate && r.EndDate <= createModel.StartDate) || (r.StartDate >= createModel.EndDate && r.EndDate <= createModel.EndDate)))
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexVehicleVM()
                {
                    Id = x.Id,
                    Brand = x.Brand,
                    Model = x.Model,
                    PricePerDay = x.PricePerDay.ToString(),
                    Year = x.Year > DateTime.Now.AddYears(-150) ? x.Year.ToString("yyyy MMMM") : "-",
                    Url = x.Url,
                })
                .ToListAsync();

            model.ElementsCount = await this.context.Vehicles.CountAsync();
            return model;
        }
    }
}
