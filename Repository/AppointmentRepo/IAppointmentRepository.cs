using Pulse.Helper;
using Pulse.Model;

namespace Pulse.Repository.AppointmentRepo
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment>> GetAll();
        Task Add(Appointment appointment);
        Task Update(Appointment appointment);
        Task Delete(Appointment appointment);
        Task<IEnumerable<Appointment>> GetByDate(AppointmentDateFilter dateFilter);
        // get all patients assigned to a specific doctor

        Task<IEnumerable<Appointment>> SearchAppointment(string name);
        // find appointments by name (useful for search bars)
    }
}