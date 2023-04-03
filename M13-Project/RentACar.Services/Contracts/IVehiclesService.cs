using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services.Contracts
{
    public interface IVehiclesService
    {
        Task<IndexVehiclesViewModel> GetIndexVehiclesAsync(int page = 1, int count = 10);
    }
}
