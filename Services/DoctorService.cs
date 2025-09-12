using Pulse.Model;
using Pulse.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Services
{
    public class DoctorService
    {
        private readonly IRepository<Doctor> _doctorRepository;

        public DoctorService(IRepository<Doctor> repository)
        {
            _doctorRepository = repository;
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            return await _doctorRepository.GetAll();
        }

        public async Task AddDoctorAsync(Doctor doctor)
        {
            await _doctorRepository.Add(doctor); 
        }

        public async Task UpdateDoctorAsync(Doctor doctor)
        {
            await _doctorRepository.Update(doctor);
        }

        public async Task DeleteDoctor(Doctor doctor)
        {
            await _doctorRepository.Delete(doctor);
        }
    }
}
