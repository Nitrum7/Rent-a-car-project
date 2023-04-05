using RentACar.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.ViewModels.Users
{
    public class IndexUsersVM:PagingVM
    {
        public ICollection<IndexUserVM> Users { get; set; }
    }
}
