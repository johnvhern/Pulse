using Pulse.Model;

namespace Pulse.Repository.PatientRepo
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAll();
        Task Add(Patient patient);
        Task Update(Patient paitent);
        Task Delete(Patient patient);
        Task<IEnumerable<Patient>> GetByDoctorId(int doctorId);
        // get all patients assigned to a specific doctor

        Task<IEnumerable<Patient>> SearchByName(string name);
        // find patients by name (useful for search bars)
    }
}