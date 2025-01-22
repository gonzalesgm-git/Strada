using MediatR;
using Strada.Database.Repositories;
using Strada.Domain.Models;
using Strada.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strada.Application.Features.Users.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Result<ActionExecutionResult>>
    {
        private readonly IRepository<User> _user;

        public UpdateUserCommandHandler(IRepository<User> user)
        {
            _user = user;
        }

        public Task<Result<ActionExecutionResult>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _user.Query()
                .FirstOrDefault(x => x.Id == request.Id);
            
            user.Email = request.Email;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            _user.Update(user);

            return Task.FromResult(Result<ActionExecutionResult>.Success(new ActionExecutionResult
            {
                Successful = true
            }));
        }
    }
}
