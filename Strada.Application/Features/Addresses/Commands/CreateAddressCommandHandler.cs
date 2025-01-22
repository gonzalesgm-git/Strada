using MediatR;
using Strada.Database.Repositories;
using Strada.Domain.Models;
using Strada.Domain.Models.Addresses;

namespace Strada.Application.Features.Addresses.Commands
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, Result<ActionExecutionResult>>
    {
        private readonly IRepository<Address> _address;
        public CreateAddressCommandHandler(IRepository<Address> address)
        {
            _address = address;
        }
        public Task<Result<ActionExecutionResult>> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            _address.Add(new Address()
            {
                City = request.City,
                PostCode = request.PostCode,
                Street = request.Street,
                UserId = request.UserId
            });

            return Task.FromResult(Result<ActionExecutionResult>.Success(new ActionExecutionResult
            {
                Successful = true
            }));
        }
    }
}
