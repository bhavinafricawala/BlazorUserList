using MediatR;
using UserList.Shared.Models;

namespace UserList.Server.Applications.Commands
{
    public class AddUserCommand: IRequest<User>
    {
        public User User { get; private set; }

        public AddUserCommand(User model)
        {
            User = model;
        }
    }
}
