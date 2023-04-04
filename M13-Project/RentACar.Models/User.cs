namespace RentACar.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class User:IdentityUser<string>
    {
        public User()
        {
            this.Id= Guid.NewGuid().ToString();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
