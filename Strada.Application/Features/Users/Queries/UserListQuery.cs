using MediatR;
using Strada.Domain.Models;
using Strada.Domain.Models.Users.dtos;

namespace Strada.Application.Features.Users.Queries
{
    public record UserListQuery : IRequest<Result<List<UserDto>>>;
}
