using MediatR;
using Microsoft.AspNetCore.Mvc;
using Strada.Application.Features.Employments.Commands;
using Strada.Domain.Models;
using System.Net;

namespace Strada.API.Controllers.Employments
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentsController : BaseController
    {
        public EmploymentsController(IMediator mediator) : base(mediator)
        {
        }
        
        [HttpPost]
        [ProducesResponseType(typeof(ActionExecutionResult), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Post([FromBody] CreateEmploymentCommand command) => SendAsync(command);
    }
}
