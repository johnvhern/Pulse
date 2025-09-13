using Microsoft.EntityFrameworkCore;
using Pulse.Model;

namespace Pulse.Data
{
    public class PulseDbContext : DbContext
    {
        public PulseDbContext(DbContextOptions<PulseDbContext> options) : base(options)
        {
            SQLitePCL.Batteries.Init();
            Database.OpenConnection();
            Database.ExecuteSqlRaw("PRAGMA journal_mode=WAL;");
        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}
