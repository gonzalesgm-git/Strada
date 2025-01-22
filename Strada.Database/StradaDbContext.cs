using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strada.Domain.Models.Addresses;
using Strada.Domain.Models.Employments;
using Strada.Domain.Models.Users;

namespace Strada.Database
{
    public class StradaDbContext : DbContext
    {
        public StradaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
