namespace SchoolManager.Models.MidleModels
{
    public class StudnetCourse
    {
        public Student Student { get; set; }
        public int StudnetId { get; set; } 

        public Course Course { get; set;}
        public int CourseId { get; set; }
    }
}
