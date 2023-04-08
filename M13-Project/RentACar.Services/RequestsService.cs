using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Models;
using RentACar.Services.Contracts;
using RentACar.ViewModels.Requests;
using RentACar.ViewModels.Requsts;
using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services
{
    public class RequestsService : IRequestsService
    {
        private readonly ApplicationDbContext context;

        public RequestsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IndexRequestsVM> GetIndexRequestsAdminAsync(int page = 1, int itemsPerPage = 10)
        {
            IndexRequestsVM model = new IndexRequestsVM();
            model.ItemsPerPage = itemsPerPage;
            model.Page = page;
            model.Requests = await this.context.Requests
                .Where(x=>x.IsAccept==false)
                .Where(x => x.Vehicle != null || x.VehicleId != null)
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexRequestVM()
                {
                    Id = x.Id,
                    StartDate = x.StartDate > DateTime.Now.AddYears(-150) ? x.StartDate.ToString("dd MMMM yyyy") : "-",
                    EndDate = x.EndDate > DateTime.Now.AddYears(-150) ? x.EndDate.ToString("dd MMMM yyyy") : "-",
                    User = $"{x.User.FirstName} {x.User.LastName}",
                    Vehicle = $"{x.Vehicle.Brand} {x.Vehicle.Model}",
                })
                .ToListAsync();

            model.ElementsCount = await this.context.Requests.Where(x => x.IsAccept == false).Where(x => x.Vehicle != null || x.VehicleId != null).CountAsync();

            return model;
        }
        public async Task<BookVehicleVM> GetIndexValidatedVehiclesAsync(CreateRequestVM createModel, int page = 1, int count = 10)
        {
            BookVehicleVM model = new BookVehicleVM();

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

            model.ElementsCount = await this.context.Vehicles
                .Where(x => x.Requests.All(r => (r.StartDate >= createModel.StartDate && r.EndDate <= createModel.StartDate) || (r.StartDate >= createModel.EndDate && r.EndDate <= createModel.EndDate))).CountAsync();
            return model;
        }
        public async Task<string> CreateRequestAsync(CreateRequestVM model)
        {
            User user = this.context.Users.FirstOrDefault(x => x.Id == model.User);

            Request request = new Request()
            {
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                User = user,
            };
            
            await this.context.Requests.AddAsync(request);
            await this.context.SaveChangesAsync();
            return request.Id;
        }

        public async Task DeleteAsync(string id)
        {
            Request request = this.context.Requests.Find(id);
            if (request != null)
            {
                this.context.Requests.Remove(request);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task AcceptRequestAsync(AcceptRequestVM model)
        {
            Request request = await this.context.Requests.FirstOrDefaultAsync(x => x.Id == model.Id);
            request.IsAccept = true;
            this.context.Update(request);
            await this.context.SaveChangesAsync();
        }



        public async Task<AcceptRequestVM> GetRequestToAcceptAsync(string id)
        {
            Request request = await this.context.Requests.FirstOrDefaultAsync(x => x.Id == id);

            return new AcceptRequestVM()
            {
                Id = request.Id,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                User = request.UserId,
                BrandOfVehicle = request.Vehicle.Brand,
                ModelOfVehicle = request.Vehicle.Model,
                PriceOfVehicle = request.Vehicle.PricePerDay,
            };
        }

        public async Task UpdateRequestAsync(string requestId, string carId)
        {
            Request request = await this.context.Requests.FindAsync(requestId);
            Vehicle vehicle = this.context.Vehicles.Find(carId);
            request.Vehicle = vehicle;           
            context.Update(request);
            if (request.Vehicle == null)
            {
                context.Requests.Remove(request);
            }
            await context.SaveChangesAsync();
        }

        public async Task<IndexClientRequestsVM> GetIndexRequestsClientAsync(string id, int page = 1, int itemsPerPage = 10)
        {
            IndexClientRequestsVM model = new IndexClientRequestsVM();
            User user = await context.Users.FindAsync(id);
            model.ItemsPerPage = itemsPerPage;
            model.Page = page;
            model.Requests = await this.context.Requests
                .Where(x => x.User == user)
                .Where(x=>x.Vehicle!=null || x.VehicleId!=null)
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexRequestVM()
                {
                    Id = x.Id,
                    StartDate = x.StartDate > DateTime.Now.AddYears(-150) ? x.StartDate.ToString("dd MMMM yyyy") : "-",
                    EndDate = x.EndDate > DateTime.Now.AddYears(-150) ? x.EndDate.ToString("dd MMMM yyyy") : "-",
                    User = $"{x.User.FirstName} {x.User.LastName}",
                    Vehicle = $"{x.Vehicle.Brand} {x.Vehicle.Model}",
                    IsAccept = x.IsAccept == false ? "Pending" : "Accepted",
                }) 
                .ToListAsync();

            model.ElementsCount = await this.context.Requests.Where(x => x.User == user).Where(x => x.Vehicle != null || x.VehicleId != null).CountAsync();
            return model;
        }
    }
}
