using System.Data;
using System.Linq;
using System.Threading.Tasks;
using RentACar.Models;
using RentACar.Services.Contracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RentACar.Services;
using RentACar.ViewModels;
namespace RentACar.Web.Controllers
{
    public class VehiclesController:Controller
    {
        private readonly IVehiclesService vehiclesService;

        public VehiclesController(
           IVehiclesService vehiclesService)
        {
            this.vehiclesService = vehiclesService;
        }
        // GET: Users
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var model = await vehiclesService.GetIndexVehiclesAsync(page, count);
            return View(model);
        }
    }
}
