using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Strada.Domain.Models.Employments;

namespace Strada.Database.EntityConfigurations
{
    public class EmploymentConfiguration : IEntityTypeConfiguration<Employment>
    {
        public void Configure(EntityTypeBuilder<Employment> builder)
        {
            builder
                .ToTable("Employments")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id");

            builder
                .Property(x => x.Company)
                .HasColumnName("Company")
                .HasColumnType("nvarchar(250)");

            builder
                .Property(x => x.MonthsOfExperience)
                .HasColumnName("MonthsOfExperience")
                .HasColumnType("int");

            builder
                .Property(x => x.Salary)
                .HasColumnName("Salary")
                .HasColumnType("int");

            builder
                .Property(x => x.UserId)
                .HasColumnName("UserId")
                .IsRequired()
                .HasColumnType("int");


            builder
                .Property(x => x.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("datetime2");

            builder
                .Property(x => x.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime2");
        }
    }
}
