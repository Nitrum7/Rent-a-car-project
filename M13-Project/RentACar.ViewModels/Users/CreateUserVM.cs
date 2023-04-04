using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace RentACar.ViewModels.Users
{
    public class CreateUserVM
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at exactly {2}.", MinimumLength = 10)]
        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$")]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at exactly {2}.", MinimumLength = 10)]
        [Display(Name = "Personal Number")]
        public string PersonalNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
