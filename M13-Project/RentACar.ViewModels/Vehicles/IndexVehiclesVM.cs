using RentACar.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Vehicles
{
    public class IndexVehiclesVM:PagingVM
    {
        public ICollection<IndexVehicleVM> Vehicles { get; set; }
    }
}
