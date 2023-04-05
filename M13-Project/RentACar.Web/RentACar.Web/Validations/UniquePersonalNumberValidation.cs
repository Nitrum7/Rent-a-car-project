using RentACar.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RentACar.Web.Validations
{
    public class UniquePersonalNumberValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var dbContext = validationContext.GetService(typeof(ApplicationDbContext)) as ApplicationDbContext;
                var personalNumber = value.ToString();

                if (dbContext.Users.Any(u => u.PersonalNumber == personalNumber))
                {
                    return new ValidationResult("Personal Number already exists.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
