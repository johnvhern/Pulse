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
    public partial class frmAddDoctor : MetroForm
    {
        private readonly IBindingList _bindingList;
        private readonly IDoctorRepository _doctorRepository;

        public frmAddDoctor(IBindingList bindingList, IDoctorRepository doctorRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddDoctor);
            SfButtonStyle.SecondaryButton(btnCancel);
            _doctorRepository = doctorRepository;
            _bindingList = bindingList;
            doctorBindingSource.DataSource = new List<Doctor>();
        }

        private async void btnAddDoctor_Click(object sender, EventArgs e)
        {
            var doctor = doctorBindingSource.Current as Doctor;
            if (string.IsNullOrEmpty(doctor?.Error))
            {
                try
                {
                    await _doctorRepository.Add(doctor);

                    if (doctor.Id != null)
                    {
                        _bindingList.Add(doctor);
                        DataUpdateNotifier.NotifyDataUpdated();
                        MessageBoxAdv.Show("Doctor added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.Show($"{doctor.FullName} is already in the list. Please add another doctor.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                ValidateControls(this, doctor);
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


        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            doctorBindingSource.AddNew();
        }
    }
}