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
        public List<User> GetUserDetails();
        public void AddUser(User user);
        public void UpdateUserDetails(User user);
        public User GetUserData(int id);
        public void DeleteUser(int id);
    }
}
