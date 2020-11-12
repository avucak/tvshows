using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUsersRepository
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<List<UserShow>> GetUserShows(int id, Status? status);
        Task AddUser(User user);
        Task<User> DeleteUser(int id);
    }
}