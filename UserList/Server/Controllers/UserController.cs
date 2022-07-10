using Microsoft.AspNetCore.Mvc;
using UserList.Infrastructure.Repositories;
using UserList.Shared.Models;
using MediatR;
using UserList.Server.Applications.Queries;
using UserList.Server.Applications.Commands;

namespace UserList.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private IMediator _mediator;
        public UserController(IUserRepository userRepository, IMediator mediator)
        {
            _userRepository = userRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetUserDetailsQuery();
            var results = await _mediator.Send(query);

            if (results == null)
                return NotFound();

            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetUserDataQuery(id);
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            var command = new AddUserCommand(user);
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(User user)
        {
            var command = new UpdateUserDetailsCommand(user);
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteUserCommand(id);
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
