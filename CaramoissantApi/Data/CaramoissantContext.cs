using CaramoissantApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CaramoissantApi.Data
{
    public class CaramoissantContext : DbContext
    {
        public CaramoissantContext(DbContextOptions<CaramoissantContext> options) : base(options)
        {

        }

        public DbSet<Caramoissant> Caramoissants => Set<Caramoissant>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caramoissant>().ToTable("Caramoissants");
        }
    }
}
