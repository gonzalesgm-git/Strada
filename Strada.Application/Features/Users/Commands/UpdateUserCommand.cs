using MediatR;
using Strada.Domain.Models;

namespace Strada.Application.Features.Users.Commands
{
    public class UpdateUserCommand : IRequest<Result<ActionExecutionResult>>
    {
        public  int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
