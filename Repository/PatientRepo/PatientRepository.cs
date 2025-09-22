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

        public Task<IEnumerable<Patient>> SearchByNameEmail(string query)
        {
            var lowerQuery = query?.ToLower() ?? string.Empty;
            var result = _db.Patients
                 .Where(p =>
                     (!string.IsNullOrEmpty(p.FullName) && p.FullName.ToLower().Contains(lowerQuery)) ||
                     (!string.IsNullOrEmpty(p.EmailAddress) && p.EmailAddress.ToLower().Contains(lowerQuery)))
                 .ToList();

            return Task.FromResult(result.AsEnumerable());
        }

        public async Task Update(Patient paitent)
        {
            _db.Patients.Update(paitent);
            await _db.SaveChangesAsync();
        }
    }
}