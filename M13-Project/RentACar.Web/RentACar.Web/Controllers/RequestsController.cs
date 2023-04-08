using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.Services.Contracts;
using RentACar.ViewModels.Requests;
using RentACar.ViewModels.Vehicles;
using System;
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
            model.StartDate = DateTime.Now;
            model.EndDate = DateTime.Now.AddDays(7);
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
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
                model.RequestId = await this.requestsService.CreateRequestAsync(model);
                return RedirectToAction("CreateSelectCar", model);
            }
            return this.View(model);
        }

        // GET: Create
        public async Task<IActionResult> CreateSelectCar(CreateRequestVM createModel, BookVehicleVM bookModel)
        {
            int items =  bookModel.ItemsPerPage = 10;
            var model = await requestsService.GetIndexValidatedVehiclesAsync(createModel, bookModel.Page, items);
            model.RequestId = createModel.RequestId;
            return View(model);
        }

        //Post
        public async Task<IActionResult> Book(string requestId, string carId)
        {

            await this.requestsService.UpdateRequestAsync(requestId,carId);

            return Redirect(nameof(Index));
        }
        //Car from the Book
        public async Task<IActionResult> BookDetails(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await vehiclesService.GetVehicleByIdAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
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
