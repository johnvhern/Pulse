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

namespace Pulse.Forms.AppointmentFRM
{
    public partial class frmAddAppointment : MetroForm
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IBindingList _bindingList;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;
        public frmAddAppointment(IBindingList bindingList, IAppointmentRepository appointmentRepository, IPatientRepository patientRepository, IDoctorRepository doctorRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddAppointment);
            SfButtonStyle.SecondaryButton(btnCancel);

            _bindingList = bindingList;
            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;
            appointmentBindingSource.DataSource = new List<Appointment>();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            var appointment = appointmentBindingSource.Current as Appointment;
            appointment.Date = dtDate.Value;

            if (cbSelectedPatient.SelectedValue != null && cbSelectedDoctor.SelectedValue != null)
            {
                appointment.PatientId = (int)cbSelectedPatient.SelectedValue;
                appointment.DoctorId = (int)cbSelectedDoctor.SelectedValue;

                if (string.IsNullOrEmpty(appointment?.Error))
                {
                    _bindingList.Add(appointment);
                    _appointmentRepository.Add(appointment);
                    DataUpdateNotifier.NotifyDataUpdated();
                    MessageBoxAdv.Show("Patient added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    ValidateControls(this, appointment);
                }
            }
            else
            {
                appointmentDetailError.SetError(cbSelectedPatient, "Patient is required.");
                appointmentDetailError.SetError(cbSelectedDoctor, "Doctor is required.");
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

        private async void frmAddAppointment_Load(object sender, EventArgs e)
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

            #endregion -- Combobox Data Load --

            appointmentBindingSource.AddNew();
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
    }
}