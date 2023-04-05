using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Requests
{
    public class AcceptRequestVM
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string User { get; set; }
        public string BrandOfVehicle { get; set; }
        public string ModelOfVehicle { get; set; }
        public decimal PriceOfVehicle { get; set; }
    }
}
