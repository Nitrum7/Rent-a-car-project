
using RentACar.Models;
using RentACar.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Requsts
{
    public class IndexRequestsVM:PagingVM
    {
        public ICollection<IndexRequestVM> Requests { get; set; } = new List<IndexRequestVM>();       
    }
}
