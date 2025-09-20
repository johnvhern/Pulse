using Pulse.Helper;
using Pulse.Model;
using Pulse.Repository.DoctorRepo;
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

namespace Pulse.Forms.DoctorFRM
{
    public partial class frmUpdateDoctor : MetroForm
    {
        private readonly Doctor _doctor;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IBindingList _bindingList;
        public frmUpdateDoctor(Doctor doctor, IBindingList bindingList ,IDoctorRepository doctorRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnUpdateDoctor);
            SfButtonStyle.SecondaryButton(btnCancel);
            SfButtonStyle.RedButton(btnDeleteDoctor);

            _doctor = doctor;
            _bindingList = bindingList;
            _doctorRepository = doctorRepository;

            LoadDoctorDetails();
        }

        private void LoadDoctorDetails()
        {
            if (_doctor != null)
            {
                txtFullName.Text = _doctor.FullName;
                txtSpecialization.Text = _doctor.Specialization;
                txtPhoneNumber.Text = _doctor.PhoneNumber;
                txtEmailAddress.Text = _doctor.EmailAddress;
            }
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            _doctor.FullName = txtFullName.Text;
            _doctor.Specialization = txtSpecialization.Text;
            _doctor.PhoneNumber = txtPhoneNumber.Text;
            _doctor.EmailAddress = txtEmailAddress.Text;

            if (string.IsNullOrEmpty(_doctor.EmailAddress))
                _doctor.EmailAddress = null;

            if (string.IsNullOrEmpty(_doctor?.Error))
            {
                _doctorRepository.Update(_doctor);
                DataUpdateNotifier.NotifyDataUpdated();
                MessageBoxAdv.Show("Doctor updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                ValidateControls(this, _doctor);
            }
        }

        private void ValidateControls(Control parent, Doctor doctor)
        {
            foreach (Control control in parent.Controls)
            {
                var tag = control.Tag?.ToString();
                if (!string.IsNullOrEmpty(tag))
                {
                    if (!string.IsNullOrEmpty(doctor[tag]))
                        doctorDetailError.SetError(control, doctor[tag]);
                    else
                        doctorDetailError.SetError(control, null);
                }

                // Recurse if the control has children (e.g., Panel, GroupBox, TabPage)
                if (control.HasChildren)
                {
                    ValidateControls(control, doctor);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFullName.Text) || !string.IsNullOrWhiteSpace(txtSpecialization.Text) ||
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

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            var result = MessageBoxAdv.Show($"Are you sure you want to delete this doctor {txtFullName.Text}? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _doctorRepository.Delete(_doctor);
                _bindingList.Remove(_doctor);
                DataUpdateNotifier.NotifyDataUpdated();
                MessageBoxAdv.Show("Doctor deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                return;
        }
    }
}
