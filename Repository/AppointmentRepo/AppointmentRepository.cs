using Microsoft.EntityFrameworkCore;
using Pulse.Data;
using Pulse.Model;

namespace Pulse.Repository.AppointmentRepo
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly PulseDbContext _db;
        public AppointmentRepository(PulseDbContext db)
        {
            _db = db;
        }
        public async Task Add(Appointment appointment)
        {
            _db.Add(appointment);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Appointment appointment)
        {
            _db.Remove(appointment);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            return await _db.Appointments.ToListAsync();
        }

        public Task<IEnumerable<Appointment>> GetByDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Appointment>> SearchAppointment(string name)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Appointment appointment)
        {
            _db.Update(appointment);
            await _db.SaveChangesAsync();
        }
    }
}