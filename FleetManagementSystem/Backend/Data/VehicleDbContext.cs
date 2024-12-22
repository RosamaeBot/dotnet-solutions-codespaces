using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options) { }

        public DbSet<VehicleLocation> VehicleLocations { get; set; }
    }
}
