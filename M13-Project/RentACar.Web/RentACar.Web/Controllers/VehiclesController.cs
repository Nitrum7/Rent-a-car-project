namespace RentACar.Web.Controllers
{
    using System.Threading.Tasks;
    using RentACar.Services.Contracts;
    using Microsoft.AspNetCore.Mvc;
    using RentACar.ViewModels.Vehicles;
    using Microsoft.AspNetCore.Authorization;
    using RentACar.Common;
    using RentACar.ViewModels.Requests;

    [Authorize]
    public class VehiclesController:Controller
    {
        private readonly IVehiclesService vehiclesService;

        public VehiclesController(
           IVehiclesService vehiclesService)
        {
            this.vehiclesService = vehiclesService;
        }
        // GET: Vehicles
        public async Task<IActionResult> Index(int page = 1, int itemsPerPage = 10)
        {
            var model = await vehiclesService.GetIndexVehiclesAsync(page, itemsPerPage);
            return View(model);
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(string id)
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

        // GET: Vehicles/Create
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Create(CreateVehiclesVM vehicle)
        {
            if (ModelState.IsValid)
            {
                await vehiclesService.CreateVehicleAsync(vehicle);
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await vehiclesService.GetVehicleToEditByIdAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Edit(EditVehicleVM car)
        {
            if (car == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await vehiclesService.UpdateVehicleAsync(car);

                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Vehicles/Delete/5
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Delete(string id)
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

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await vehiclesService.DeleteVehicleByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
