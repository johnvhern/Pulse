using Pulse.Model;

namespace Pulse.Repository.DoctorRepo
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> GetAll();
        Task Add(Doctor doctor);
        Task Update(Doctor doctor);
        Task Delete(Doctor doctor);
    }
}