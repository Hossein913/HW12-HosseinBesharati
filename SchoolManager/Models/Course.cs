using Microsoft.Identity.Client;
using SchoolManager.Models.MidleModels;

namespace SchoolManager.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public string References { get; set; }
        public byte Hour { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public ICollection<StudnetCourse> StudnetCourse { get; set; }
    }
}
