using RentACar.ViewModels.Requests;
using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services.Contracts
{
    public interface IValidatedVehiclesService
    {
        Task<IndexVehiclesVM> GetIndexValidatedVehiclesAsync(CreateRequestVM createModel, int page = 1, int count = 10);
    }
}
