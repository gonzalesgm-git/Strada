using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strada.Domain.Models.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Strada.Database.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Users")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id");

            builder
                .Property(x => x.Email)
                .HasColumnName("Email")
                .IsRequired()
                .HasColumnType("nvarchar(250)");

            builder
                .Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasColumnType("nvarchar(250)");

            builder
                .Property(x => x.LastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasColumnType("nvarchar(250)");
        }
    }
}
