using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IShowsRepository
    {
        Task<List<Show>> GetShows();
        Task<Show> GetShow(int id);
        Task<Show> DeleteShow(int id);
    }
}