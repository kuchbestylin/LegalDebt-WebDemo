using LegalDebt_ServerSideProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LegalDebt_ServerSideProject.Data
{
    public class LegalDebtDbContext : DbContext
    {
        public LegalDebtDbContext(DbContextOptions<LegalDebtDbContext> options) : base(options){}

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Company>().HasData(
                    new Company { Id=1, Name="IkanaLegal", Address="123 @ address", Cellphone=00000}
                );
        }

    }
}
