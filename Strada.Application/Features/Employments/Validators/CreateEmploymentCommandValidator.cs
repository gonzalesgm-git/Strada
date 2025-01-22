using FluentValidation;
using Strada.Application.Features.Employments.Commands;

namespace Strada.Application.Features.Employments.Validators
{
    public class CreateEmploymentCommandValidator : AbstractValidator<CreateEmploymentCommand>
    {
        public CreateEmploymentCommandValidator()
        {
            RuleFor(x => x.StartDate)
                .NotEmpty()
                .WithMessage("Start date is required");

            RuleFor(x => x.EndDate)
                .GreaterThan(x => x.StartDate)
                .WithMessage("End date should be greater than Start date");

        }
    }
}
