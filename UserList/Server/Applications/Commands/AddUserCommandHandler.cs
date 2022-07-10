using MediatR;
using UserList.Infrastructure.Repositories;
using UserList.Shared.Models;

namespace UserList.Server.Applications.Commands
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, User>
    {
        private readonly IUserRepository _userRepository;

        public AddUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _userRepository.AddUser(request.User);
                return request.User;
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
