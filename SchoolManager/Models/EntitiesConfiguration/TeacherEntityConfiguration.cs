using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManager.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace SchoolManager.Models.EntitiesConfiguration
{
    public class TeacherEntityConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasOne(s => s.Address)
            .WithOne(a => a.Teachers)
            .HasForeignKey<Teacher>(s => s.AddressId);

            builder.HasMany(t => t.Course)
            .WithOne(c => c.Teacher)
            .HasForeignKey(c => c.TeacherId);
        }
    }
}
