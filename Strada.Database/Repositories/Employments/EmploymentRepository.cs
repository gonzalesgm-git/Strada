using Strada.Domain.Models.Employments;

namespace Strada.Database.Repositories.Employments
{
    public class EmploymentRepository : Repository<Employment>
    {
        public EmploymentRepository(StradaDbContext context) : base(context)
        {
        }
    }
}
