using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.Shared.Models;
using UserList.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace UserList.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly DatabaseContext _dbContext = new();

        public UserRepository   (DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddUser(User user)
        {
            var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                User? user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();
                    transaction.Commit();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public async Task<User> GetUserData(int id)
        {
            try
            {
               var user = await _dbContext.Users.Where(u=>u.Id == id).FirstOrDefaultAsync();
                if (user != null)
                    return user;
                else
                    throw new ArgumentNullException();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<User>> GetUserDetails()
        {
            try
            {
                return await _dbContext.Users.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateUserDetails(User user)
        {
            var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
    }
}
