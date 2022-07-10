using Microsoft.AspNetCore.Mvc;
using UserList.Infrastructure.Repositories;
using UserList.Shared.Models;

namespace UserList.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.GetUserDetails();
            return Ok(users.ToList());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user =  await _userRepository.GetUserData(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            await _userRepository.UpdateUserDetails(user);
            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> Put(User user)
        {
            await _userRepository.UpdateUserDetails(user);
            return Ok(user);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _userRepository.DeleteUser(id);
            return Ok(true);
        }
    }
}
