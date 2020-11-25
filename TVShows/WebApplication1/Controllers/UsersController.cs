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

        [HttpGet("username={username}&password={password}")]
        public async Task<ActionResult> GetUser(string username, string password)
        {
            var user = await _usersRepository.GetUser(username, password);
            if(user != null)
                return Ok();
            return NotFound();
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

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(int id, User user)
        {
            if (id != user.Id)
                return BadRequest();
            await _usersRepository.UpdateUser(user);
            return NoContent();
        }

    }
}
