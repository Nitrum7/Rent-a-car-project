using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.ViewModels.Vehicles
{
    public class IndexVehicleVM
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string PassengerSeats { get; set; }
        public string Description { get; set; }
        public string PricePerDay { get; set; }
        public string Url { get; set; }
        [BindProperty]
        public IFormFile Picture { get; set; }
    }
}
