using MediatR;
using Strada.Domain.Models;

namespace Strada.Application.Features.Users.Commands
{
    public class CreateUserCommand : IRequest<Result<ActionExecutionResult>>
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
