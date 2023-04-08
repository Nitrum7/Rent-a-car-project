using RentACar.Models;
using RentACar.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services.Contracts
{
    public interface IUsersService
    {
        Task DeleteUserByIdAsync(string id);
        Task CreateUserAsync(CreateUserVM model);
        Task UpdateUserAsync(EditUserVM model);
        Task<EditUserVM> GetUserToEditByIdAsync(string id);
        Task<IndexUserVM> GetUserByIdAsync(string id);
        Task<IndexUsersVM> GetUsersAsync(int page = 1, int count = 10);
        Task<User> GetUserById(string id);
    }
}
