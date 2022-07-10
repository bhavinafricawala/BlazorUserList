using MediatR;
using UserList.Infrastructure.Repositories;

namespace UserList.Server.Applications.Commands
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Boolean>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return await _userRepository.DeleteUser(request.UserId); ;
            }
            catch (Exception)
            {

                throw;
            }            
        }
      
    }
}
