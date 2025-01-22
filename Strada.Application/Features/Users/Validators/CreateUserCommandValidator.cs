using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Strada.Application.Features.Users.Commands;
using Strada.Database.Repositories;
using Strada.Domain.Models.Users;

namespace Strada.Application.Features.Users.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator(IRepository<User> user)
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("Firstname cannot be empty");
            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Lastname cannot be empty");
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Not valid email address")
                .Must(email =>
                {
                    return !user.Query().Any(x => x.Email == email);
                })
                .WithMessage($"Email already used");

        }
    }
}
