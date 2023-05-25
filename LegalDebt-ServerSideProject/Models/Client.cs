using Microsoft.EntityFrameworkCore;

namespace LegalDebt_ServerSideProject.Models
{
    [PrimaryKey(nameof(Id))]
    public class Client
    {
        public int Id { get; set; }
        public required string FirstNames { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string fileNumber { get; set; }
        public required string CurrentCompany { get; set; }
        public int debtAmount { get; set; }
    }
}
