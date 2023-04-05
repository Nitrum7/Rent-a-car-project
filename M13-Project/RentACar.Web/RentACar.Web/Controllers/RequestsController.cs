using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.Services.Contracts;
using RentACar.ViewModels.Requests;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentACar.Web.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IRequestsService requestsService;
        private readonly IVehiclesService vehiclesService;

        public RequestsController(IRequestsService requestsService, IVehiclesService vehiclesService)
        {
            this.requestsService = requestsService;
            this.vehiclesService = vehiclesService;
        }

        // GET: RequestsAdmin
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var model = await requestsService.GetIndexRequestsAdminAsync(page, count);
            return View(model);
        }

        // GET: Create
        public async Task<IActionResult> Create()
        {
            CreateRequestVM model = new CreateRequestVM();
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            model.VehiclesList = await this.vehiclesService.GetVehiclesSelectListAsync();
            return this.View(model);
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateRequestVM model)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            model.User = userId;
            if (this.ModelState.IsValid)
            {
                await this.requestsService.CreateRequestAsync(model);
                return this.RedirectToAction(nameof(this.Index));
            }

            model.VehiclesList = await this.vehiclesService.GetVehiclesSelectListAsync();
            return this.View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Accept(string id)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            AcceptRequestVM model = await this.requestsService.GetRequestToAcceptAsync(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Accept(AcceptRequestVM model)
        {
            if (ModelState.IsValid)
            {
                await requestsService.AcceptRequestAsync(model);
                return RedirectToAction(nameof(Index));
            }
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(model);
        }

        //GET: Decline
        [HttpGet]
        public async Task<IActionResult> Decline(string id)
        {
            await requestsService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
