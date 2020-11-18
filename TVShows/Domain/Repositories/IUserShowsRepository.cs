using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserShowsRepository
    {
        Task<List<UserShow>> GetUserShows(int id, Status? status);
        Task AddUserShow(UserShow userShow);
        Task<UserShow> DeleteUserShow(int userId, int showId);
        Task UpdateUserShow(UserShow userShow);
    }
}