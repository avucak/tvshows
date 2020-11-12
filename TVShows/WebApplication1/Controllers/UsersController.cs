using Data.Models;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _usersRepository.GetUsers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _usersRepository.GetUser(id);
        }

        //user show controller, not here
        [HttpGet("{id}/shows/{status?}")]
        public async Task<ActionResult<List<UserShow>>> GetUserShows(int id, Status? status)
        {
            return await _usersRepository.GetUserShows(id, status);
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            await _usersRepository.AddUser(user);
            return CreatedAtAction(nameof(User), new { id = user.Id }, user);
        }

        //concurency?
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _usersRepository.DeleteUser(id);
            if (user == null)
                return NotFound();
            return user;
        }

        //TODO: edit user

    }
}
