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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.Forms.PatientFRM
{
    public partial class frmAddPatient : MetroForm
    {
        private readonly IBindingList _bindingList;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;
        public frmAddPatient(IBindingList bindingList, IDoctorRepository doctorRepository, IPatientRepository patientRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddPatient);
            SfButtonStyle.SecondaryButton(btnCancel);

            _bindingList = bindingList;
            _doctorRepository = doctorRepository;
            _patientRepository = patientRepository;
            patientBindingSource.DataSource = new List<Patient>();
        }

        private async void frmAddPatient_Load(object sender, EventArgs e)
        {
            cbAssignedDoctor.DisplayMember = "FullName";
            cbAssignedDoctor.ValueMember = "Id";
            cbAssignedDoctor.DataSource = await _doctorRepository.GetAll();

            patientBindingSource.AddNew();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            var patient = patientBindingSource.Current as Patient;
            patient.DateOfBirth = dtDOB.Value;

            if (cbAssignedDoctor.SelectedValue != null && (int)cbAssignedDoctor.SelectedValue > 0)
            {
                patient.DoctorId = (int)cbAssignedDoctor.SelectedValue;

                if (string.IsNullOrEmpty(patient?.Error))
                {

                    _bindingList.Add(patient);
                    _patientRepository.Add(patient);
                    MessageBoxAdv.Show("Patient added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    ValidateControls(this, patient);
                }
            }
            else
            {
                patientDetailError.SetError(cbAssignedDoctor, "Assigned doctor is required.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFullName.Text) || !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !string.IsNullOrWhiteSpace(txtEmailAddress.Text) || !string.IsNullOrEmpty(txtAddress.Text))
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
    }
}
