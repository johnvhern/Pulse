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

        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Doctor)
                .WithMany(d => d.Patients)
                .HasForeignKey(p => p.DoctorId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)  
                .HasForeignKey(a => a.PatientId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments) 
                .HasForeignKey(a => a.DoctorId);

            modelBuilder.Entity<Appointment>()
                .Property(a => a.Status)
                .HasDefaultValue("Scheduled");

            base.OnModelCreating(modelBuilder);
        }
    }
}
