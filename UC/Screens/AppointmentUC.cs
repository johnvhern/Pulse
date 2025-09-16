using Pulse.Forms.AppointmentFRM;
using Pulse.Helper;
using Pulse.Repository.DoctorRepo;
using Pulse.Repository.PatientRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.UC.Screens
{
    public partial class AppointmentUC : UserControl
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IDoctorRepository _doctorRepository;
        public AppointmentUC(IPatientRepository patientRepository, IDoctorRepository doctorRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnScheduleAppointment);

            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            new frmAddAppointment(appointmentBindingSource, _patientRepository, _doctorRepository).ShowDialog();
        }
    }
}
