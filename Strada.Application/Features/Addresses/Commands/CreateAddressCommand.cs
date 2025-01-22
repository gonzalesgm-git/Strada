using MediatR;
using Strada.Domain.Models;

namespace Strada.Application.Features.Addresses.Commands
{
    public class CreateAddressCommand : IRequest<Result<ActionExecutionResult>>
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int? PostCode { get; set; }
        public int UserId { get; set; }
    }
}
