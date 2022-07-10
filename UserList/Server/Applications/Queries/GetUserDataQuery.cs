using MediatR;
using UserList.Shared.Models;

namespace UserList.Server.Applications.Queries
{
    public class GetUserDataQuery :IRequest<User>
    {
        public int _userId { get; set; }

        public GetUserDataQuery(int userId)
        {
            _userId = userId;
        }
    }
}
