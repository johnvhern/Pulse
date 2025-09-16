using Pulse.Forms.AppointmentFRM;
using Pulse.Helper;
using Pulse.Repository.AppointmentRepo;
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
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentUC(IAppointmentRepository appointmentRepository, IPatientRepository patientRepository, IDoctorRepository doctorRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnScheduleAppointment);

            _appointmentRepository = appointmentRepository;
            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            new frmAddAppointment(appointmentBindingSource, _appointmentRepository, _patientRepository, _doctorRepository).ShowDialog();
        }

        private async void AppointmentUC_Load(object sender, EventArgs e)
        {
            var appointment = await _appointmentRepository.GetAll();
            appointmentBindingSource.DataSource = appointment.ToList();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAppointments.Columns["Status"].Index && e.RowIndex >= 0)
            {
                dgvAppointments.BeginEdit(true);
                var combo = dgvAppointments.EditingControl as ComboBox;
                if (combo != null)
                {
                    combo.DroppedDown = true;
                }
            }
        }
    }
}
