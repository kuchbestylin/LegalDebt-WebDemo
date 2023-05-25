using Microsoft.EntityFrameworkCore;

namespace LegalDebt_ServerSideProject.Models
{
    [PrimaryKey(nameof(Id))]
    public class Company
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public int Cellphone { get; set; }
    }
}
