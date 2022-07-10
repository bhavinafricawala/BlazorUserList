using MediatR;
using UserList.Shared.Models;

namespace UserList.Server.Applications.Commands
{
    public class UpdateUserDetailsCommand: IRequest<User>
    {
        public User User { get; private set; }

        public UpdateUserDetailsCommand(User model)
        {
            User = model;
        }
    }
}
