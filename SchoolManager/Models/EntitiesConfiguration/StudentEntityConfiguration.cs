using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManager.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace SchoolManager.Models.EntitiesConfiguration
{
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(s => s.Address)
                .WithOne(a => a.Students)
                .HasForeignKey<Student>(s => s.AddressId);

           

        }
    }
}
