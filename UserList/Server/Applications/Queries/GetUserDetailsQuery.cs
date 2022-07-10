using MediatR;
using UserList.Shared.Models;

namespace UserList.Server.Applications.Queries
{
    public class GetUserDetailsQuery: IRequest<IEnumerable<User>>
    {
        public GetUserDetailsQuery()
        {

        }
    }
}
