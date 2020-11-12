using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<UserShow>> GetUserShows(int id, Status? status)
        {
            if (status.HasValue)
                return await _context.UserShows.Where(us => us.UserId == id && us.ShowStatus == status.Value).ToListAsync();
            return await _context.UserShows.Where(us => us.UserId == id).ToListAsync();
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

        public async Task UpdateUserShow(UserShow userShow)
        {
            _context.UserShows.Update(userShow);
            await _context.SaveChangesAsync();
        }
    }
}
