using MediatR;
using Strada.Database.Repositories;
using Strada.Domain.Models;
using Strada.Domain.Models.Employments;

namespace Strada.Application.Features.Employments.Commands
{
    public class CreateEmploymentCommandHandler : IRequestHandler<CreateEmploymentCommand, Result<ActionExecutionResult>>
    {
        private readonly IRepository<Employment> _employment;
        public CreateEmploymentCommandHandler(IRepository<Employment> employment)
        {
            _employment = employment;
        }
        public Task<Result<ActionExecutionResult>> Handle(CreateEmploymentCommand request, CancellationToken cancellationToken)
        {
            _employment.Add(new Employment()
            {
                Company = request.Company,
                EndDate = request.EndDate,
                StartDate = request.StartDate,
                MonthsOfExperience = request.MonthsOfExperience,
                Salary = request.Salary,
                UserId = request.UserId
            });

            return Task.FromResult(Result<ActionExecutionResult>.Success(new ActionExecutionResult
            {
                Successful = true
            }));
        }
    }
}
