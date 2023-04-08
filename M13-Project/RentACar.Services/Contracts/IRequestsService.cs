using RentACar.ViewModels.Requests;
using RentACar.ViewModels.Requsts;
using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services.Contracts
{
    public interface IRequestsService
    {
        Task<IndexRequestsVM> GetIndexRequestsAdminAsync(int page = 1, int itemsPerPage = 10);
        Task<IndexClientRequestsVM> GetIndexRequestsClientAsync(string id,int page = 1, int itemsPerPage = 10);
        Task<string> CreateRequestAsync(CreateRequestVM model);

        Task UpdateRequestAsync(string requestId, string carId);
        Task DeleteAsync(string id);
        Task<AcceptRequestVM> GetRequestToAcceptAsync(string id);
        Task AcceptRequestAsync(AcceptRequestVM model);

        Task<BookVehicleVM> GetIndexValidatedVehiclesAsync(CreateRequestVM createModel, int page = 1, int count = 10);


    }
}
