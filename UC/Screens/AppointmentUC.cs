using Microsoft.EntityFrameworkCore.Diagnostics;
using Pulse.Forms.AppointmentFRM;
using Pulse.Helper;
using Pulse.Model;
using Pulse.Repository.AppointmentRepo;
using Pulse.Repository.DoctorRepo;
using Pulse.Repository.PatientRepo;
using Syncfusion.Windows.Forms;
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

            DataUpdateNotifier.DataUpdated += LoadAppointmentsByDate;
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            new frmAddAppointment(appointmentBindingSource, _appointmentRepository, _patientRepository, _doctorRepository).ShowDialog();
        }

        private async void AppointmentUC_Load(object sender, EventArgs e)
        {
            var appointment = await _appointmentRepository.GetAll();
            appointmentBindingSource.DataSource = appointment.ToList();

            #region -- Show Names of Patients and Doctors in DataGrid --

            var _patients = await _patientRepository.GetAll();
            var _doctors = await _doctorRepository.GetAll();

            var patientColumn = (DataGridViewComboBoxColumn)dgvAppointments.Columns["PatientId"];
            patientColumn.DisplayMember = "FullName";
            patientColumn.ValueMember = "Id";
            patientColumn.DataSource = _patients.ToList();

            var doctorColumn = (DataGridViewComboBoxColumn)dgvAppointments.Columns["DoctorId"];
            doctorColumn.DisplayMember = "FullName";
            doctorColumn.ValueMember = "Id";
            doctorColumn.DataSource = _doctors.ToList();

            #endregion

            #region -- Filter Date Range --

            List<string> dateRange = new List<string>();
            dateRange.Add("Today");
            dateRange.Add("This Week");
            dateRange.Add("This Month");
            dateRange.Add("All Time");
            cbDateRange.DataSource = dateRange;
            cbDateRange.SelectedIndex = 0;

            #endregion
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

            if (e.ColumnIndex == dgvAppointments.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var appointment = dgvAppointments.Rows[e.RowIndex].DataBoundItem as Appointment;

                if (appointment != null)
                {
                    new frmUpdateAppointment(appointment, appointmentBindingSource, _appointmentRepository, _patientRepository, _doctorRepository).ShowDialog();
                }
            }
        }

        private void dgvAppointments_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                // Detach previous event handlers to avoid multiple subscriptions
                combo.SelectionChangeCommitted -= ComboBox_SelectionChangeCommitted;
                combo.SelectionChangeCommitted += ComboBox_SelectionChangeCommitted;
            }
        }

        private void ComboBox_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                var selectedItem = comboBox.SelectedItem;
                var appointment = appointmentBindingSource.Current as Appointment;
                if (selectedItem != null && appointment != null)
                {
                    appointment.Status = selectedItem.ToString();
                    _appointmentRepository.Update(appointment);
                    MessageBoxAdv.Show("Status updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataUpdateNotifier.NotifyDataUpdated();
                }
                else
                {
                    MessageBoxAdv.Show("Cannot save changes. Please try again later");
                }
                // Commit the edit to register the change immediately
                dgvAppointments.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvAppointments_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvAppointments.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var img = Properties.Resources.square_pen__1_;

                int imgWidth = 16;
                int imgHeight = 16;

                int x = e.CellBounds.Left + (e.CellBounds.Width - imgWidth) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - imgHeight) / 2;

                e.Graphics.DrawImage(img, new Rectangle(x, y, imgWidth, imgHeight));

                e.Handled = true;
            }
        }

        private async void cbDateRange_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadAppointmentsByDate();
        }

        private async void LoadAppointmentsByDate()
        {
            if (cbDateRange.SelectedItem == null)
            {
                return;
            }

            AppointmentDateFilter filter = AppointmentDateFilter.Today;

            switch (cbDateRange.SelectedItem.ToString())
            {
                case "Today":
                    filter = AppointmentDateFilter.Today;
                    break;
                case "This Week":
                    filter = AppointmentDateFilter.ThisWeek;
                    break;
                case "This Month":
                    filter = AppointmentDateFilter.ThisMonth;
                    break;
                case "All Time":
                    filter = AppointmentDateFilter.AllTime;
                    break;
            }

            var filteredAppointment = await _appointmentRepository.GetByDate(filter);
            appointmentBindingSource.DataSource = filteredAppointment.ToList();
        }

        private void txtSearchAppointments_TextChanged(object sender, EventArgs e)
        {
            timerSearch.Stop();
            timerSearch.Start();
        }

        private async void timerSearch_Tick(object sender, EventArgs e)
        {
            timerSearch.Stop();

            string query = txtSearchAppointments.Text.Trim();
            var appointments = await _appointmentRepository.GetAll();

            if (cbDateRange.SelectedItem == null)
            {
                appointmentBindingSource.DataSource = new BindingList<Appointment>(appointments.ToList());
            }

            if (string.IsNullOrEmpty(query))
            {
                AppointmentDateFilter filter = AppointmentDateFilter.Today;

                switch (cbDateRange.SelectedItem.ToString())
                {
                    case "Today":
                        filter = AppointmentDateFilter.Today;
                        break;
                    case "This Week":
                        filter = AppointmentDateFilter.ThisWeek;
                        break;
                    case "This Month":
                        filter = AppointmentDateFilter.ThisMonth;
                        break;
                    case "All Time":
                        filter = AppointmentDateFilter.AllTime;
                        break;
                }

                var filteredAppointment = await _appointmentRepository.GetByDate(filter);
                appointmentBindingSource.DataSource = new BindingList<Appointment>(filteredAppointment.ToList());
            }
            else
            {
                var results = await _appointmentRepository.SearchAppointment(query);
                appointmentBindingSource.DataSource = new BindingList<Appointment>(results.ToList());
            }
        }
    }
}
