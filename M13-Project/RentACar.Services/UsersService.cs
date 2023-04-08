namespace RentACar.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using RentACar.Data;
    using RentACar.Models;
    using RentACar.Services.Contracts;
    using RentACar.ViewModels.Users;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using RentACar.Common;

    public class UsersService : IUsersService
    {
        private ApplicationDbContext context;
        private UserManager<User> userManager;

        public UsersService(ApplicationDbContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task DeleteUserByIdAsync(string id)
        {
            User user = await userManager.FindByIdAsync(id);
            user.Requests.Clear();
            await userManager.DeleteAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task CreateUserAsync(CreateUserVM model)
        {
            User user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                NormalizedUserName = model.UserName,
                Email = model.Email,
                NormalizedEmail = model.Email,
                EmailConfirmed = true,
                PhoneNumber = model.PhoneNumber,
                PersonalNumber = model.PersonalNumber,
                SecurityStamp = string.Empty,
            };

            await userManager.CreateAsync(user, model.Password);
            await userManager.AddToRoleAsync(user, GlobalConstants.ClientRole);
        }

        public async Task UpdateUserAsync(EditUserVM model)
        {
            User user = await context.Users.FindAsync(model.Id);

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.UserName = model.UserName;
            user.Email = model.Email;
            user.PhoneNumber = model.PhoneNumber;
            user.PersonalNumber = model.PersonalNumber;
            await context.SaveChangesAsync();
        }

        public async Task<EditUserVM> GetUserToEditByIdAsync(string id)
        {
            User user = await context.Users.FindAsync(id);
            EditUserVM model = null;
            if (user != null)
            {
                model = new EditUserVM()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    PersonalNumber = user.PersonalNumber,
                };
            }
            return model;
        }
        public async Task<User> GetUserById(string id)
        {
            User user = await context.Users.FindAsync(id);
            return user;
        }
        public async Task<IndexUserVM> GetUserByIdAsync(string id)
        {
            User user = await context.Users.FindAsync(id);

            IndexUserVM model = null;

            if (user != null)
            {
                model = new IndexUserVM()
                {
                    Id = user.Id,
                    FullName = $"{user.FirstName} {user.LastName}",
                    UserName = user.UserName,
                    Email = user.Email,
                    PersonalNumber = user.PersonalNumber,
                    PhoneNumber = user.PhoneNumber,
                };
            }

            return model;
        }

        public async Task<IndexUsersVM> GetUsersAsync(int page = 1, int count = 10)
        {
            IndexUsersVM model = new IndexUsersVM();

            model.ItemsPerPage = count;
            model.Page = page;
            model.ElementsCount = await this.context.Users.CountAsync();

            model.Users = await this.context.Users
                  .Skip((page - 1) * count)
                  .Take(count)
                  .Select(x => new IndexUserVM()
                  {
                      Id = x.Id,
                      FullName = $"{x.FirstName} {x.LastName}",
                      Email = x.Email,
                      PersonalNumber = x.PersonalNumber,
                      PhoneNumber = x.PhoneNumber,
                      UserName = x.UserName,
                  }
              ).ToListAsync();

            return model;
        }
    }
}
