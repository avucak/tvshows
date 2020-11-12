using Data.Models;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserShowsRepository
    {
        Task AddUserShow(UserShow userShow);
        Task<UserShow> DeleteUserShow(int userId, int showId);
    }
}