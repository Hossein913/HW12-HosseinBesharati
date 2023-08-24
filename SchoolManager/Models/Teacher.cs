using System.ComponentModel.DataAnnotations;

namespace SchoolManager.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string BirthDate { get; set; }
        [Required]
        public string Nationalcode { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string EducationFild { get; set; }
        [Required]
        public string RegistrationDate { get; set; }
        [Required]
        public string TeacherCode { get; set; }

        public Address Address { get; set; }
        public int AddressId { get; set; }

        public List<Course> Course { get; set; }

    }
}
