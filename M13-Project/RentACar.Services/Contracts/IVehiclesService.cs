using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.ViewModels.Requests;
using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services.Contracts
{
    public interface IVehiclesService
    {
        Task<IndexVehiclesVM> GetIndexVehiclesAsync(int page = 1, int count = 10);
        Task DeleteVehicleByIdAsync(string id);
        Task CreateVehicleAsync(CreateVehiclesVM model);
        Task<IndexVehicleVM> GetVehicleByIdAsync(string id);
        Task<EditVehicleVM> GetVehicleToEditByIdAsync(string id);
        Task UpdateVehicleAsync(EditVehicleVM model);
    }
}
