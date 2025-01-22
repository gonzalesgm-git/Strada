using Strada.Domain.Models.Addresses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Strada.Domain.Models.Employments;

namespace Strada.Domain.Models.Users
{
    public class User : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public List<Employment> Employments { get; set; }

    }
}
