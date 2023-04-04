using RentACar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace RentACar.ViewModels.Vehicles
{
    public class EditVehicleVM
    {
        public string Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "Brand")]
        public string Brand { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM}", ApplyFormatInEditMode = true)]
        [YearAfter1886Validation]
        [Display(Name = "Model")]
        public DateTime Year { get; set; }
        [Required]
        [Range(1, 12)]
        [Display(Name = "Passenger Seats")]
        public int PassengerSeats { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        [Range(30, 100000)]
        public decimal PricePerDay { get; set; }
    }
}
