using Strada.Domain.Models.Employments;

namespace Strada.Domain.Models.Users
{
    public class UserInfo
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<Employment> Employments { get; set; }

    }
}
