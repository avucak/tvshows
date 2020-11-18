using Data.Models;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        private readonly IShowsRepository _showsRepository;

        public ShowsController(IShowsRepository showsRepository)
        {
            _showsRepository = showsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Show>>> GetShows()
        {
            return await _showsRepository.GetShows();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Show>> GetShow(int id)
        {
            var show = await _showsRepository.GetShow(id);
            if (show == null)
                return NotFound();
            return show;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Show>> DelteShow(int id)
        {
            var show = await _showsRepository.DeleteShow(id);
            if (show == null)
                return NotFound();
            return show;
        }
    }
}
