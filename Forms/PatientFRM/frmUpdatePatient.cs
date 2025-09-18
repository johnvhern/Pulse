using Pulse.Helper;
using Pulse.Model;
using Pulse.Repository.DoctorRepo;
using Pulse.Repository.PatientRepo;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.Forms.PatientFRM
{
    public partial class frmUpdatePatient : MetroForm
    {
        private readonly Patient _patient;
        private readonly IPatientRepository _patientRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IBindingList _bindingList;
        public frmUpdatePatient(Patient patient, IBindingList bindingList, IDoctorRepository doctorRepository, IPatientRepository patientRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnUpdatePatient);
            SfButtonStyle.SecondaryButton(btnCancel);
            SfButtonStyle.RedButton(btnDeletePatient);

            _patient = patient;
            _bindingList = bindingList;
            _doctorRepository = doctorRepository;
            _patientRepository = patientRepository;

            LoadPatientDetails();
        }

        private void LoadPatientDetails()
        {
            if (_patient != null)
            {
                txtFullName.Text = _patient.FullName;
                txtPhoneNumber.Text = _patient.PhoneNumber;
                cbAssignedDoctor.Text = _patient.Doctor.FullName;
                txtAddress.Text = _patient.Address;
                txtEmailAddress.Text = _patient.EmailAddress;
                dtDOB.Value = _patient.DateOfBirth.Value;
            }
        }

        private async void frmUpdatePatient_Load(object sender, EventArgs e)
        {
            var doctor = await _doctorRepository.GetAll();
            cbAssignedDoctor.DisplayMember = "FullName";
            cbAssignedDoctor.ValueMember = "Id";
            cbAssignedDoctor.DataSource = doctor.ToList();
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            _patient.FullName = txtFullName.Text;
            _patient.PhoneNumber = txtPhoneNumber.Text;
            _patient.Address = txtAddress.Text;
            _patient.EmailAddress = txtEmailAddress.Text;
            _patient.DateOfBirth = dtDOB.Value;


            if (cbAssignedDoctor.SelectedValue != null && (int)cbAssignedDoctor.SelectedValue > 0)
            {
                _patient.DoctorId = (int)cbAssignedDoctor.SelectedValue;

                if (string.IsNullOrEmpty(_patient?.Error))
                {
                    _patientRepository.Update(_patient);
                    MessageBoxAdv.Show("Patient added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    ValidateControls(this, _patient);
                }
            }
            else
            {
                patientDetailError.SetError(cbAssignedDoctor, "Assigned doctor is required.");
            }
        }

        private void ValidateControls(Control parent, Patient patient)
        {
            foreach (Control control in parent.Controls)
            {
                var tag = control.Tag?.ToString();
                if (!string.IsNullOrEmpty(tag))
                {
                    if (!string.IsNullOrEmpty(patient[tag]))
                        patientDetailError.SetError(control, patient[tag]);
                    else
                        patientDetailError.SetError(control, null);
                }

                // Recurse if the control has children (e.g., Panel, GroupBox, TabPage)
                if (control.HasChildren)
                {
                    ValidateControls(control, patient);
                }
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            var result = MessageBoxAdv.Show($"Are you sure you want to delete patient {_patient.FullName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _patientRepository.Delete(_patient);
                _bindingList.Remove(_patient);
                MessageBoxAdv.Show("Patient deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFullName.Text) || !string.IsNullOrWhiteSpace(txtAddress.Text) ||
              !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !string.IsNullOrWhiteSpace(txtEmailAddress.Text))
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
    }
}
