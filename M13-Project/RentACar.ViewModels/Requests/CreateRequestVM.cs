using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Requests
{
    public class CreateRequestVM
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string User { get; set; }

        public string RequestId  { get; set; }
    }
}
