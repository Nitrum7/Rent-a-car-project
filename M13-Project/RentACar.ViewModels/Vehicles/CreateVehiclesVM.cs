using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Vehicles
{
    public class CreateVehiclesVM
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int PassengerSeats { get; set; }
        public string Description { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
