using MediatR;
using UserList.Infrastructure.Repositories;
using UserList.Shared.Models;

namespace UserList.Server.Applications.Commands
{
    public class UpdateUserDetailsCommandHandler : IRequestHandler<UpdateUserDetailsCommand, User>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserDetailsCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(UpdateUserDetailsCommand request, CancellationToken cancellationToken)
        {
            await _userRepository.UpdateUserDetails(request.User);
            return request.User;
        }
    }
}
