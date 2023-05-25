

namespace SharedProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public long Cellphone { get; set; }
    }
}
