using MediatR;
using Strada.Domain.Models;

namespace Strada.Application.Features.Employments.Commands
{
    public class CreateEmploymentCommand : IRequest<Result<ActionExecutionResult>>
    {
        public string? Company { get; set; }
        public int MonthsOfExperience { get; set; }
        public int Salary { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int UserId { get; set; }
    }
}
