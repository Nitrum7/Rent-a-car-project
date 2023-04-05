using RentACar.ViewModels.Requests;
using RentACar.ViewModels.Requsts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services.Contracts
{
    public interface IRequestsService
    {
        Task<IndexRequestsVM> GetIndexRequestsAdminAsync(int page = 1, int count = 10);
        Task CreateRequestAsync(CreateRequestVM model);
        Task DeleteAsync(string id);
        Task<AcceptRequestVM> GetRequestToAcceptAsync(string id);
        Task AcceptRequestAsync(AcceptRequestVM model);
    }
}
