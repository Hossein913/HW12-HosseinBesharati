namespace SchoolManager.Models
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Address> Address { get; set; } 
    }
}
