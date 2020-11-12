using Data.Models;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserShowsController: ControllerBase
    {
        private readonly IUserShowsRepository _userShowsRepository;
        public UserShowsController(IUserShowsRepository userShowsRepository)
        {
            _userShowsRepository = userShowsRepository;
        }

        [HttpGet("{id}/{status?}")]
        public async Task<ActionResult<List<UserShow>>> GetUserShows(int id, Status? status)
        {
            return await _userShowsRepository.GetUserShows(id, status);
        }

        [HttpPost]
        public async Task<ActionResult<UserShow>> AddUserShow(UserShow userShow)
        {
            await _userShowsRepository.AddUserShow(userShow);
            //return CreatedAtAction("AddUserShow", new { id = new { userId = userShow.ShowId, showId = userShow.ShowId } }, userShow);
            return CreatedAtAction("AddUserShow", new { id = userShow.ShowId + " " + userShow.ShowId } , userShow);
        }

        //concurrency?
        //should the ids be sent in a different way
        [HttpDelete("{userId}&{showId}")]
        public async Task<ActionResult<UserShow>> DeleteUserShow(int userId, int showId)
        {
            var userShow = await _userShowsRepository.DeleteUserShow(userId, showId);
            if (userShow == null)
                return NotFound();
            return userShow;
        }

        //what if the user show doesn't exist?
        //concurrency?
        [HttpPut("{userId}&{showId}")]
        public async Task<ActionResult> UpdateUserShow(int userId, int showId, [FromBody] UserShow userShow)
        {
            if (userId != userShow.UserId || showId != userShow.ShowId)
                return BadRequest();
            await _userShowsRepository.UpdateUserShow(userShow);
            return NoContent();
        }
    }
}
