namespace SchoolManager.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string FullAddress { get; set; }
        public Province Province { get; set; }
        public int ProvinceId { get; set; }

        public Teacher Teachers { get; set; } 
        public Student Students { get; set; } 
    }
}
