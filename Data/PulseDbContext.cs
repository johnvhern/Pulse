using Microsoft.EntityFrameworkCore;
using Pulse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Data
{
    public class PulseDbContext : DbContext
    {
        public PulseDbContext(DbContextOptions<PulseDbContext> options) : base(options)
        {
            SQLitePCL.Batteries.Init();
        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}
