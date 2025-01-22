using MediatR;
using Microsoft.EntityFrameworkCore;
using Strada.Database.Repositories;
using Strada.Domain.Models;
using Strada.Domain.Models.Employments;
using Strada.Domain.Models.Users;

namespace Strada.Application.Features.Users.Queries
{
    public class UserListQueryHandler : IRequestHandler<UserListQuery, Result<List<UserInfo>>>
    {
        private readonly IRepository<User> _user;
        public UserListQueryHandler(IRepository<User> user)
        {
            _user = user;
        }

        public async Task<Result<List<UserInfo>>> Handle(UserListQuery request, CancellationToken cancellationToken)
        {
           var users = await _user.Query()
               .Include(x => x.Employments)
               .Include(x => x.Address)
               .ToListAsync(cancellationToken);

           var results = users.Select(x => new UserInfo()
           {
               Id = x.Id,
               Email = x.Email,
               FirstName = x.FirstName,
               LastName = x.LastName,
               Address = x.Address,
               Employments = x.Employments.Select(e => new Employment()
               {
                   Id = e.Id,
                   Company = e.Company,
                   EndDate = e.EndDate,
                   MonthsOfExperience = e.MonthsOfExperience,
                   Salary = e.Salary,
                   StartDate = e.StartDate
               }).ToList()
           }).ToList();

           return Result<List<UserInfo>>.Success(results);
        }
    }
}
