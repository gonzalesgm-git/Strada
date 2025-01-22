using MediatR;
using Strada.Domain.Models;
using Strada.Domain.Models.Users;

namespace Strada.Application.Features.Users.Queries
{
    public record UserListQuery : IRequest<Result<List<UserInfo>>>;
}
