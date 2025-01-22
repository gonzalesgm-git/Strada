using MediatR;
using Microsoft.AspNetCore.Mvc;
using Strada.Domain.Models;

namespace Strada.API.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly IMediator _mediator;

        protected BaseController(IMediator mediator) => _mediator = mediator;

        protected async Task<IActionResult> SendAsync<TResponse>(IRequest<Result<TResponse>> request)
        {
            var result = await _mediator.Send(request);
            return ProcessResponse(result);
        }

        private ActionResult ProcessResponse<TData>(Result<TData> result)
        {
            switch (result.ProcessResult)
            {
                case ProcessResult.Ok:
                    return Ok(result.Data);
                case ProcessResult.NotFound:
                    return NotFound(result.ErrorDetails);
                case ProcessResult.BadRequest:
                    return BadRequest(result.ErrorDetails);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}