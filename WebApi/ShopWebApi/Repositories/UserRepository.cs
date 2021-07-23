using ShopWebApi.Interfaces.Services;
using ShopWebApi.Models;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace ShopWebApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly postgresContext _context;
        public UserRepository(postgresContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUser(User user)
        {
            using (var transaction= _context.Database.BeginTransaction())
            {
                try
                {
                    
                   // _context.Adresses.FirstOrDefault(x=>x.Equals(user.UserAdresses.First().Adress))

                   var newUser= await _context.Users.AddAsync(user);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return newUser.Entity;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Task<User> DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUseDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
