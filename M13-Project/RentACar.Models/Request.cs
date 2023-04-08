namespace RentACar.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Request
    {
        public Request()
        {
            this.Id=Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
       
        public virtual Vehicle Vehicle { get; set; }
        public string VehicleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }       
        public virtual User User { get; set; }
        public string UserId { get; set; }
        public bool IsAccept { get; set; } = false;
    }
}
