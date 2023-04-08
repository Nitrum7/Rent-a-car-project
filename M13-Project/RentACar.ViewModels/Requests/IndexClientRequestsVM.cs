
using RentACar.Models;
using RentACar.ViewModels.Shared;
using RentACar.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Requsts
{
    public class IndexClientRequestsVM:IndexRequestsVM
    {
       
        public IndexClientRequestsVM()
        {
            this.Requests = new List<IndexRequestVM>();
            this.Action = "IndexClient"; // Change action to "CreateSelectCar"
        }
    }
}
