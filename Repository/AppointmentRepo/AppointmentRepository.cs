using Microsoft.EntityFrameworkCore;
using Pulse.Data;
using Pulse.Helper;
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

        public async Task<IEnumerable<Appointment>> GetByDate(AppointmentDateFilter filter)
        {
            var phTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Manila");
            DateTime nowPH = TimeZoneInfo.ConvertTime(DateTime.UtcNow, phTimeZone);
            DateTime today = nowPH.Date;
            IQueryable<Appointment> query = _db.Appointments;

            switch (filter)
            {
                case AppointmentDateFilter.Today:
                    query = query.Where(a => a.Date == today);
                    break;
                case AppointmentDateFilter.ThisWeek:
                    var startOfWeek = today.AddDays(-(int)today.DayOfWeek);
                    var endOfWeek = startOfWeek.AddDays(6);
                    query = query.Where(a => a.Date >= startOfWeek && a.Date <= endOfWeek);
                    break;
                case AppointmentDateFilter.ThisMonth:
                    var firstOfMonth = new DateTime(today.Year, today.Month, 1);
                    var lastOfMonth = firstOfMonth.AddMonths(1).AddDays(-1);
                    query = query.Where(a => a.Date >= firstOfMonth && a.Date <= lastOfMonth);
                    break;
                case AppointmentDateFilter.AllTime:
                    // no filter, return all
                    break;
            }

            return await query.ToListAsync();
        }

        public Task<IEnumerable<Appointment>> SearchAppointment(string query)
        {
            var lowerQuery = query?.ToLower() ?? string.Empty;
            var result = _db.Appointments
                 .Where(p =>
                     (!string.IsNullOrEmpty(p.Patient.FullName) && p.Patient.FullName.ToLower().Contains(lowerQuery)) ||
                     (!string.IsNullOrEmpty(p.Doctor.FullName) && p.Doctor.FullName.ToLower().Contains(lowerQuery)))
                 .ToList();

            return Task.FromResult(result.AsEnumerable());
        }

        public async Task Update(Appointment appointment)
        {
            _db.Update(appointment);
            await _db.SaveChangesAsync();
        }
    }
}