using Microsoft.EntityFrameworkCore;
using Pulse.Data;
using Pulse.Model;

namespace Pulse.Repository.PatientRepo
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PulseDbContext _db;

        public PatientRepository(PulseDbContext db)
        {
            _db = db;
        }

        public async Task Add(Patient patient)
        {
            _db.Patients.Add(patient);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Patient patient)
        {
            _db.Patients.Remove(patient);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await _db.Patients.ToListAsync();
        }

        public async Task<IEnumerable<Patient>> GetByDoctorId(int doctorId)
        {
            return await _db.Patients
                           .Where(p => p.DoctorId == doctorId)
                           .ToListAsync();
        }

        public Task<IEnumerable<Patient>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Patient paitent)
        {
            _db.Patients.Update(paitent);
            await _db.SaveChangesAsync();
        }
    }
}