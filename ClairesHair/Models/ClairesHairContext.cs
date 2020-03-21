using Microsoft.EntityFrameworkCore;

namespace ClairesHair.Models
{
    public class ClairesHairContext : DbContext
    {
        public DbSet<Stylist> Stylists { get; set; }
        public DbSet<Client> Clients { get; set; }

        public ClairesHairContext(DbContextOptions options) : base(options) { }
    }
}