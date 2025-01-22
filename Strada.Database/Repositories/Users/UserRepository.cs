using Strada.Domain.Models.Users;

namespace Strada.Database.Repositories.Users
{
    public class UserRepository: Repository<User>
    {
        public UserRepository(StradaDbContext context): base(context)
        {
        }
    }
}
