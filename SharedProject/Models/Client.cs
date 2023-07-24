
namespace SharedProject.Models
{
    public class Client
    {
        public int Id { get; set; }
        public required string FirstNames { get; set; }
        public required string TitleOfCourtesy { get; set; }
        public required string LastName { get; set; }
        public string? FullName { get; set; }
        public required string Email { get; set; }
        public required string CurrentCompany { get; set; }
        public long PhoneNumber { get; set; } = 000000000;
        public required string City { get; set;}
        public required string Country { get; set;}
    }
}
