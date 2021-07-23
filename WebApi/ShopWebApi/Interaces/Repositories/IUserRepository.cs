using ShopWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApi.Interfaces.Services
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        Task<User> GetUseDetails(int id);
        Task<User> DeleteUser(User user);
    }
}
