using Microsoft.EntityFrameworkCore;
using SchoolManager.Models;
using SchoolManager.Models.EntitiesConfiguration;
using SchoolManager.Models.MidleModels;

namespace SchoolManager.Context
{
    public class SchoolDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public SchoolDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public SchoolDbContext()
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<StudnetCourse> studnetCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProvinceEntityConfiguration());
            modelBuilder.ApplyConfiguration(new StudentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherEntityConfiguration());
            modelBuilder.ApplyConfiguration(new StudnetCourseEntityConfiguration());

        }

    }
}
