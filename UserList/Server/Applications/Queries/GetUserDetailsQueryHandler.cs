using MediatR;
using UserList.Infrastructure.Repositories;
using UserList.Shared.Models;

namespace UserList.Server.Applications.Queries
{
    public class GetUserDetailsQueryHandler : IRequestHandler<GetUserDetailsQuery, IEnumerable<User>>
    {
        private IUserRepository _userRepository;

        public GetUserDetailsQueryHandler(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _userRepository.GetUserDetails();
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
