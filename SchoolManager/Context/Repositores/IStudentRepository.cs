using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SchoolManager.Models;
using SchoolManager.Models.Dto;
using SchoolManager.Models.MidleModels;

namespace SchoolManager.Context.Repositores
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        List<StudentCoursesDto> GetStudentWithTokenCourses();
        List<StudentCoursesDto> GetStudentWithNotTokenCourses();
        List<StudentTeachersDto> GetStudentWithTokenCoursesTeachers();

    }

    public class StudentRepository : IStudentRepository
    {

        private readonly SchoolDbContext _context;
        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Students;
        }

        public List<StudentCoursesDto> GetStudentWithNotTokenCourses()
        {
            var courses = _context.courses;
            var studentCourses = _context.Students.Include(s => s.StudnetCourse).Select(x =>
   
                new StudentCoursesDto
                {
                    Name = x.FirstName + " " + x.LastName,
                    Courses = courses.Where(c => !x.StudnetCourse.Any(i => i.CourseId == c.Id)).Select(x => x.CourseTitle).ToArray()
                }).ToList();
            return studentCourses;
            
        }
        
        public List<StudentCoursesDto> GetStudentWithTokenCourses()
        {
            var studentCourses = _context.Students.Include(s => s.StudnetCourse).Select(x =>
            new StudentCoursesDto
            {
                Name = x.FirstName + " " + x.LastName,
                Courses = x.StudnetCourse.Select(x => x.Course.CourseTitle).ToArray()
            }).ToList();
            return studentCourses;


            var AllCourses = _context.courses;


        }


        public List<StudentTeachersDto> GetStudentWithTokenCoursesTeachers()
        {
            var studentTeachers = _context.Students.Include(s => s.StudnetCourse).ThenInclude(c =>c.Course.Teacher).Select(x =>
                new StudentTeachersDto
                {
                    Name = x.FirstName + " " + x.LastName,
                    Teachers = x.StudnetCourse.Select(x => x.Course.Teacher.FirstName+" "+ x.Course.Teacher.LastName).ToArray()
                }).ToList();
            return studentTeachers;
        }
    }
}
