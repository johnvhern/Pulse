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