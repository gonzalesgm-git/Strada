using Strada.Domain.Models.Addresses;
using Strada.Domain.Models.Employments.dtos;

namespace Strada.Domain.Models.Users.dtos
{
    public class UserDto
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<EmploymentDto> Employments { get; set; }
        public Address Address { get; set; }
    }
}
