using Ganymede.Entities;
using Ganymede.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ganymede.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : Controller
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<User>> Register([FromBody] User user)
        {
            User userExists = await _userRepository.GetUserByEmail(user.Email);

            if(userExists != null)
            {
                return Conflict("User already exists");
            }

            return await _userRepository.Register(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(Guid id)
        {
            User user = await _userRepository.GetUserById(id); 

            if(user == null)
            {
                return NotFound();
            }

            return user;
        }
    }
}
