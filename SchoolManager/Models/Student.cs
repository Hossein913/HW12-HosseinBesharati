using SchoolManager.Models.MidleModels;
using System.ComponentModel.DataAnnotations;

namespace SchoolManager.Models
{
    public class Student
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
        public string RegistrationDate { get; set; }
        public string? GraduateDate { get; set; }
        [Required]
        public string StudentCode { get; set; }

        public Address Address { get; set; }
        public int AddressId { get; set; }
        public List<StudnetCourse> StudnetCourse { get; set; }


    }
}
