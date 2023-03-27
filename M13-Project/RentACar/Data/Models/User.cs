using Microsoft.AspNetCore.Identity;
using System;

namespace RentACar.Data.Models
{
    public class User: IdentityUser<string>
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
    }
}
