﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.Data;
using RentACar.Models;
using RentACar.Services.Contracts;
using RentACar.ViewModels.Requests;
using RentACar.ViewModels.Vehicles;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentACar.Web.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IRequestsService requestsService;
        private readonly IVehiclesService vehiclesService;
        private readonly ApplicationDbContext context;
        private readonly IUsersService usersService;

        public RequestsController(IRequestsService requestsService, IVehiclesService vehiclesService, ApplicationDbContext context)
        {
            this.requestsService = requestsService;
            this.vehiclesService = vehiclesService;
            this.context = context;
        }

        // GET: RequestsAdmin
        public async Task<IActionResult> Index( int page = 1, int itemsPerPage = 10)
        {
            var model = await requestsService.GetIndexRequestsAdminAsync(page, itemsPerPage);
            return View(model);
        }
        //Get: ReguestsClient
        public async Task<IActionResult> IndexClient(string id, int page = 1, int itemsPerPage = 10)
        {
            id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await requestsService.GetIndexRequestsClientAsync(id,page, itemsPerPage);
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
            var model = await requestsService.GetIndexValidatedVehiclesAsync(createModel, bookModel.Page, bookModel.ItemsPerPage);
            model.RequestId = createModel.RequestId;
            return View(model);
        }

        //Post
        public async Task<IActionResult> BookForAdmin(string requestId, string carId)
        {
            await this.requestsService.UpdateRequestAsync(requestId,carId);
            return Redirect(nameof(Index));
        }
        public async Task<IActionResult> BookForClient(string requestId, string carId)
        {
            await this.requestsService.UpdateRequestAsync(requestId, carId);
            return Redirect(nameof(IndexClient));
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
