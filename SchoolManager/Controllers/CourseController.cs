using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManager.Context.Repositores;
using SchoolManager.Models;
using SchoolManager.Models.Dto;
using SchoolManager.Models.MidleModels;

namespace SchoolManager.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public ActionResult CourseStudentCount()
        {
           List<CourseStudentCountDto> students = _courseRepository.GetCourseStudentCountDto();
            return View(students);
        }


       }
}
