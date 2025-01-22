using Strada.Domain.Models.Addresses;

namespace Strada.Database.Repositories.Addresses
{
    public class AddressRepository : Repository<Address>
    {
        public AddressRepository(StradaDbContext context) : base(context)
        {
        }
    }
}
