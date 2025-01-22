using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Strada.Domain.Models.Addresses;

namespace Strada.Database.EntityConfigurations
{
    public class AddressConfiguration
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .ToTable("Addresses")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Street)
                .HasColumnName("Street")
                .HasColumnType("nvarchar(250)");

            builder
                .Property(x => x.City)
                .HasColumnName("City")
                .HasColumnType("nvarchar(250)");

            builder
                .Property(x => x.PostCode)
                .HasColumnName("PostCode")
                .HasColumnType("int");

            builder
                .Property(x => x.UserId)
                .HasColumnName("UserId")
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
