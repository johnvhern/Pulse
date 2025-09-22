using Microsoft.EntityFrameworkCore;
using Pulse.Data;
using Pulse.Model;

namespace Pulse.Repository.DoctorRepo
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly PulseDbContext _db;

        public DoctorRepository(PulseDbContext db)
        {
            _db = db;
        }
        public async Task Add(Doctor doctor)
        {
            _db.Doctors.Add(doctor);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Doctor doctor)
        {
            bool hasPatients = await _db.Patients.AnyAsync(p => p.DoctorId == doctor.Id);
            bool hasAppointments = await _db.Appointments.AnyAsync(a => a.DoctorId == doctor.Id);

            if (hasPatients && hasAppointments)
            {
                throw new InvalidOperationException("Doctor cannot be deleted because they have both patients and appointments.");
            }
            else if (hasPatients)
            {
                throw new InvalidOperationException("Doctor cannot be deleted because they have patients assigned.");
            }
            else if (hasAppointments)
            {
                throw new InvalidOperationException("Doctor cannot be deleted because they have appointments scheduled.");
            }

            _db.Doctors.Remove(doctor);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            return await _db.Doctors.ToListAsync();
        }

        public async Task Update(Doctor doctor)
        {
            _db.Doctors.Update(doctor);
            await _db.SaveChangesAsync();
        }
    }
}