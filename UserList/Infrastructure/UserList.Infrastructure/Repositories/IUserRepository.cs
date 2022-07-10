using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.Shared.Models;

namespace UserList.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUserDetails();
        Task<bool> AddUser(User user);
        Task<bool> UpdateUserDetails(User user);
        Task<User> GetUserData(int id);
        Task<bool> DeleteUser(int id);
    }
}
