using MediatR;
using Strada.Database.Repositories;
using Strada.Domain.Models;
using Strada.Domain.Models.Users;

namespace Strada.Application.Features.Users.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result<ActionExecutionResult>>
    {
        private readonly IRepository<User> _user;

        public CreateUserCommandHandler(IRepository<User> user)
        {
            _user = user;
        }

        public Task<Result<ActionExecutionResult>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            _user.Add(new User()
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
            });

            return Task.FromResult(Result<ActionExecutionResult>.Success(new ActionExecutionResult
            {
                Successful = true
            }));
        }
    }
}
