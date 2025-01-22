using MediatR;
using Microsoft.AspNetCore.Mvc;
using Strada.Application.Features.Employments.Commands;
using Strada.Domain.Models;
using System.Net;
using Strada.Application.Features.Addresses.Commands;

namespace Strada.API.Controllers.Addresses
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : BaseController
    {
        public AddressesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [ProducesResponseType(typeof(ActionExecutionResult), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Post([FromBody] CreateAddressCommand command) => SendAsync(command);
    }
}
