using Microsoft.AspNetCore.Mvc;
using RentACar.Services.Contracts;
using RentACar.ViewModels.Requests;
using System.Threading.Tasks;

namespace RentACar.Web.Controllers
{
    public class VehiclesValidatedControler : Controller
    {
        private readonly IValidatedVehiclesService validatedvehiclesService;

        public VehiclesValidatedControler(IRequestsService requestsService, IValidatedVehiclesService validatedvehiclesService)
        {
            this.validatedvehiclesService = validatedvehiclesService;
        }
        public async Task<IActionResult> Index(CreateRequestVM createModel, int page = 1, int count = 10)
        {
            var model = await validatedvehiclesService.GetIndexValidatedVehiclesAsync(createModel, page, count);
            return View(model);
        }
    }
}
