using Data;
using Data.Models;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class UserShowsRepository : IUserShowsRepository
    {
        private readonly TVShowsContext _context;
        public UserShowsRepository(TVShowsContext context)
        {
            _context = context;
        }

        public async Task AddUserShow(UserShow userShow)
        {
            _context.UserShows.Add(userShow);
            await _context.SaveChangesAsync();
        }

        public async Task<UserShow> DeleteUserShow(int userId, int showId)
        {
            var userShow = _context.UserShows.Find(userId, showId);
            if (userShow != null)
            {
                _context.UserShows.Remove(userShow);
                await _context.SaveChangesAsync();
            }
            return userShow;
        }
    }
}
