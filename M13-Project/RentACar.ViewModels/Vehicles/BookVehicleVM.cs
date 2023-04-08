using RentACar.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Vehicles
{
    public class BookVehicleVM:IndexVehiclesVM
    {
        public string RequestId { get; set; }
        public BookVehicleVM()
        {
            this.Vehicles = new List<IndexVehicleVM>();
            this.Action = "CreateSelectCar"; // Change action to "CreateSelectCar"
        }
    }
}

