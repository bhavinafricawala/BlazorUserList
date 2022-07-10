using MediatR;
using UserList.Infrastructure.Repositories;
using UserList.Shared.Models;

namespace UserList.Server.Applications.Queries
{
    public class GetUserDataQueryHandler : IRequestHandler<GetUserDataQuery, User>
    {
        private IUserRepository _userRepository;

        public GetUserDataQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserDataQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _userRepository.GetUserData(request._userId);
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
