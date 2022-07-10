using MediatR;
namespace UserList.Server.Applications.Commands
{
    public class DeleteUserCommand: IRequest<Boolean>
    {
        public int UserId { get; private set; }

        public DeleteUserCommand(int id)
        {
            UserId = id;
        }
    }
}
