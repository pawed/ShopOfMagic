using ShopWebApi.Models;
using System.Threading.Tasks;

namespace ShopWebApi.Repositories
{
    public interface IAuthService
    {
        Task<User> Login(string email, string password);
        Task<User> Register(User user, string password);
        Task<bool> UserExists(string email);
    }
}