using RentACar.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RentACar.Web.Validations
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var dbContext = validationContext.GetService(typeof(ApplicationDbContext)) as ApplicationDbContext;
                var email = value.ToString();

                if (dbContext.Users.Any(u => u.Email == email))
                {
                    return new ValidationResult("Email already exists in the database.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
