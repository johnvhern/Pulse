using Pulse.Helper;
using Pulse.Model;
using Pulse.Repository.AppointmentRepo;
using Pulse.Repository.DoctorRepo;
using Pulse.Repository.PatientRepo;
using Pulse.UC.Screens;
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

namespace Pulse.Forms.AppointmentFRM
{
    public partial class frmUpdateAppointment : MetroForm
    {
        private readonly Appointment _appointment;
        private readonly IBindingList _bindingList;
        private readonly IPatientRepository _patientRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        public frmUpdateAppointment(Appointment appointment, IBindingList bindingList, IAppointmentRepository appointmentRepository, IPatientRepository patientRepository, IDoctorRepository doctorRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnUpdateAppointment);
            SfButtonStyle.SecondaryButton(btnCancel);
            SfButtonStyle.RedButton(btnDeleteAppointment);

            _appointment = appointment;
            _bindingList = bindingList;
            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;

            LoadAppointmentDetails();
        }

        private void LoadAppointmentDetails()
        {

            if (_appointment != null)
            {
                cbSelectedPatient.Text = _appointment.Patient.FullName;
                cbSelectedDoctor.Text = _appointment.Doctor.FullName;
                dtDate.Value = _appointment.Date;
                txtNotes.Text = _appointment.Notes;
            }
        }

        private async void frmUpdateAppointment_Load(object sender, EventArgs e)
        {
            #region -- Combobox Data Load --

            var _patients = await _patientRepository.GetAll();
            var _doctors = await _doctorRepository.GetAll();

            cbSelectedPatient.DisplayMember = "FullName";
            cbSelectedPatient.ValueMember = "Id";
            cbSelectedPatient.DataSource = _patients.ToList();

            cbSelectedDoctor.DisplayMember = "FullName";
            cbSelectedDoctor.ValueMember = "Id";
            cbSelectedDoctor.DataSource = _doctors.ToList();

            #endregion
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            _appointment.Date = dtDate.Value;
            _appointment.Notes = txtNotes.Text;

            if (cbSelectedPatient.SelectedValue != null && cbSelectedDoctor.SelectedValue != null)
            {
                _appointment.PatientId = (int)cbSelectedPatient.SelectedValue;
                _appointment.DoctorId = (int)cbSelectedDoctor.SelectedValue;

            }
            else
            {
                appointmentDetailError.SetError(cbSelectedPatient, "Patient is required.");
                appointmentDetailError.SetError(cbSelectedDoctor, "Doctor is required.");
            }

            if (string.IsNullOrEmpty(_appointment?.Error))
            {
                _appointmentRepository.Update(_appointment);
                MessageBoxAdv.Show("Appointment updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                ValidateControls(this, _appointment);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbSelectedPatient.Text) || !string.IsNullOrEmpty(cbSelectedDoctor.Text) || !string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                var result = MessageBoxAdv.Show("Are you sure you want to cancel? Unsaved changes will be lost.", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Close();
            }
        }

        private void ValidateControls(Control parent, Appointment appointment)
        {
            foreach (Control control in parent.Controls)
            {
                var tag = control.Tag?.ToString();
                if (!string.IsNullOrEmpty(tag))
                {
                    if (!string.IsNullOrEmpty(appointment[tag]))
                        appointmentDetailError.SetError(control, appointment[tag]);
                    else
                        appointmentDetailError.SetError(control, null);
                }

                // Recurse if the control has children (e.g., Panel, GroupBox, TabPage)
                if (control.HasChildren)
                {
                    ValidateControls(control, appointment);
                }
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            var result = MessageBoxAdv.Show($"Are you sure you want to delete {_appointment.Patient.FullName}'s appointment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _appointmentRepository.Delete(_appointment);
                _bindingList.Remove(_appointment);
                MessageBoxAdv.Show("Appointment deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
