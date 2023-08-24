using Microsoft.EntityFrameworkCore;
using SchoolManager.Models.Dto;

namespace SchoolManager.Context.Repositores
{
    public interface ICourseRepository
    {
        List<CourseStudentCountDto> GetCourseStudentCountDto();
    }

    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolDbContext _context;
        public CourseRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public List<CourseStudentCountDto> GetCourseStudentCountDto()
        {
            var studentCourses = _context.courses.Include(s => s.StudnetCourse).Select(x =>
                new CourseStudentCountDto
                {
                    CourseName = x.CourseTitle,
                    StudentCount = x.StudnetCourse.Count
                }).ToList();
            return studentCourses;
        }
    }
}
