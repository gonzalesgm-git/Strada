using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Strada.Domain.Models.Users;
using Strada.Application.Features.Users.Queries;
using Strada.Domain.Models;
using Strada.Application.Features.Users.Commands;

namespace Strada.API.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        public UsersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<UserInfo>), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Get() => SendAsync(new UserListQuery());

        [HttpPost]
        [ProducesResponseType(typeof(ActionExecutionResult), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Post([FromBody] CreateUserCommand command) => SendAsync(command);

        [HttpPut]
        [ProducesResponseType(typeof(ActionExecutionResult), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Put([FromBody] UpdateUserCommand command) => SendAsync(command);
    }
}
