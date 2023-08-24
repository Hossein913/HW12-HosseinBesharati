using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManager.Context.Repositores;
using SchoolManager.Models;
using SchoolManager.Models.Dto;
using SchoolManager.Models.MidleModels;

namespace SchoolManager.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public ActionResult StudentCourses()
        {
           List<StudentCoursesDto> students =_studentRepository.GetStudentWithTokenCourses();
            return View(students);
        }

        public ActionResult StudentTeacher()
        {
            List<StudentTeachersDto> students = _studentRepository.GetStudentWithTokenCoursesTeachers();
            return View(students);
        }

        public ActionResult StudentNotTokenCourses()
        {
            List<StudentCoursesDto> students = _studentRepository.GetStudentWithNotTokenCourses();
            return View(students);
        }

       }
}
