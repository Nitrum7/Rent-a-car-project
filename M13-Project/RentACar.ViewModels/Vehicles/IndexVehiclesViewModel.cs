using RentACar.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Vehicles
{
    public class IndexVehiclesViewModel:PagingViewModel
    {
        public ICollection<IndexVehicleViewModel> Vehicles { get; set; }
    }
}
