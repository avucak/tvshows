using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class ShowsRepository : IShowsRepository
    {
        private readonly TVShowsContext _context;

        public ShowsRepository(TVShowsContext context)
        {
            _context = context;
        }

        public async Task<List<Show>> GetShows()
        {
            return await _context.Shows.ToListAsync();
        }

        public async Task<Show> GetShow(int id)
        {
            return await _context.Shows.FindAsync(id);
        }

        public async Task<Show> DeleteShow(int id)
        {
            var show = _context.Shows.Find(id);
            if (show != null)
            {
                _context.Shows.Remove(show);
                await _context.SaveChangesAsync();
            }
            return show;
        }

        //move to userShows; unneeded?
        //public async Task<List<User>> GetUsersForShow(int id)
        //{ 
        //    var userIds = _context.UserShows.Where(us => us.ShowId == id).Select(us => us.UserId);
        //    return await _context.Users.Where(u => userIds.Contains(u.Id)).ToListAsync();
        //}
    }
}
