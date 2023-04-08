using RentACar.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Requsts
{
    public class IndexRequestVM
    {
        public string Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string User { get; set; }
        public string Vehicle { get; set; }
        public string IsAccept { get; set; }
    }
}
