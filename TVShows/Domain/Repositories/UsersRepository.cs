using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly TVShowsContext _context;
        public UsersRepository(TVShowsContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        //get all user shows for user, by categories -> move this to userShow repo
        public async Task<List<UserShow>> GetUserShows(int id, Status? status)
        {
            if(status.HasValue)
                return await _context.UserShows.Where(us => us.UserId == id && us.ShowStatus == status.Value).ToListAsync();
            return await _context.UserShows.Where(us => us.UserId == id).ToListAsync();
        }

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }
    }
}
