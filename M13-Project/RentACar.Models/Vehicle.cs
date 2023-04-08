namespace RentACar.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Vehicle
    {
        public Vehicle()
        {
            this.Id= Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int PassengerSeats { get; set; }
        public string Description { get; set; }
        public decimal PricePerDay { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
