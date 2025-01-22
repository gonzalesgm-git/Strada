using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Strada.Domain.Models.Users;

namespace Strada.Domain.Models.Addresses
{
    public class Address: IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int? PostCode { get; set; }

        public int UserId { get; set; }
    }
}
