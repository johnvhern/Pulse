using Pulse.Helper;
using Pulse.Model;
using Pulse.Repository.AppointmentRepo;
using Pulse.Repository.DoctorRepo;
using Pulse.Repository.PatientRepo;
using Syncfusion.WinForms.DataGrid.Styles;
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
    public partial class DashboardUC : UserControl
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        public DashboardUC(IPatientRepository patientRepository, IDoctorRepository doctorRepository, IAppointmentRepository appointmentRepository)
        {
            InitializeComponent();

            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;

            DataUpdateNotifier.DataUpdated += ShowPatientDoctor;
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("D");

            ShowPatientDoctor();
        }

        private async void ShowPatientDoctor()
        {
            AppointmentDateFilter filter = AppointmentDateFilter.Today;
            var filteredAppointment = await _appointmentRepository.GetByDate(filter);
            appointmentBindingSource.DataSource = new BindingList<Appointment>(filteredAppointment.ToList());

            #region -- Show Names of Patients and Doctors in DataGrid --

            var _patients = await _patientRepository.GetAll();
            var _doctors = await _doctorRepository.GetAll();

            var patientColumn = (DataGridViewComboBoxColumn)dgvDashboard.Columns["PatientId"];
            patientColumn.DisplayMember = "FullName";
            patientColumn.ValueMember = "Id";
            patientColumn.DataSource = _patients.ToList();

            var doctorColumn = (DataGridViewComboBoxColumn)dgvDashboard.Columns["DoctorId"];
            doctorColumn.DisplayMember = "FullName";
            doctorColumn.ValueMember = "Id";
            doctorColumn.DataSource = _doctors.ToList();

            #endregion

            dgvDashboard.ClearSelection();
        }

        private void dgvDashboard_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvDashboard.Columns["Status"].Index && e.RowIndex >= 0)
            {
                var status = dgvDashboard.Rows[e.RowIndex].Cells["Status"].Value;

                if (status != null)
                {
                    string statusValue = status.ToString();

                    switch (statusValue)
                    {
                        case "Scheduled":
                            e.CellStyle.BackColor = Color.FromArgb(243, 244, 246);
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                        case "Completed":
                            e.CellStyle.BackColor = Color.FromArgb(227, 254, 240);
                            e.CellStyle.ForeColor = Color.FromArgb(0, 213, 99);
                            break;
                        case "Cancelled":
                            e.CellStyle.BackColor = Color.FromArgb(255, 241, 241);
                            e.CellStyle.ForeColor = Color.FromArgb(243, 0, 0);
                            break;
                        case "No-show":
                            e.CellStyle.BackColor = Color.FromArgb(255, 241, 241);
                            e.CellStyle.ForeColor = Color.FromArgb(243, 0, 0);
                            break;
                    }
                }
            }
        }

        private void dgvDashboard_SelectionChanged(object sender, EventArgs e)
        {
            dgvDashboard.ClearSelection();
        }
    }
}
