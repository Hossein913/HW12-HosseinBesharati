using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManager.Models.MidleModels;
using System.Reflection.Emit;

namespace SchoolManager.Models.EntitiesConfiguration
{
    public class StudnetCourseEntityConfiguration : IEntityTypeConfiguration<StudnetCourse>
    {
        public void Configure(EntityTypeBuilder<StudnetCourse> builder)
        {
            builder.HasKey(sc => new { sc.StudnetId, sc.CourseId });

            builder.HasOne<Student>(sc => sc.Student)
            .WithMany(s => s.StudnetCourse)
            .HasForeignKey(sc => sc.StudnetId)
            .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Course>(sc => sc.Course)
            .WithMany(s => s.StudnetCourse)
            .HasForeignKey(sc => sc.CourseId)
            .OnDelete(DeleteBehavior.NoAction);
        }


    }
}
