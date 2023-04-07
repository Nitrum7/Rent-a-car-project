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
    public class RequestsService:IRequestsService
    {
        private readonly ApplicationDbContext context;

        public RequestsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IndexRequestsVM> GetIndexRequestsAdminAsync(int page = 1, int count = 10)
        {
            IndexRequestsVM model = new IndexRequestsVM();

            model.ItemsPerPage = count;
            model.Page = page;
            model.Requests = await this.context.Requests
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

            model.ElementsCount = await this.context.Requests.CountAsync();

            return model;
        }

        public async Task CreateRequestAsync(CreateRequestVM model)
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
            request.Vehicle.IsFreeOnDate = false;

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
        
    }
}
