using Pulse.Helper;
using Pulse.Model;
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
        public frmAddDoctor(IBindingList bindingList)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddDoctor);
            SfButtonStyle.SecondaryButton(btnCancel);
            _bindingList = bindingList;
            doctorBindingSource.DataSource = new List<Doctor>();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            var doctor = doctorBindingSource.Current as Doctor;
            if (string.IsNullOrEmpty(doctor?.Error))
            {
                _bindingList.Add(doctor);
                MessageBoxAdv.Show("Doctor added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBoxAdv.Show(doctor.Error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFullName.Text) || !string.IsNullOrWhiteSpace(txtSpecialization.Text) ||
                !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !string.IsNullOrWhiteSpace(txtEmailAddress.Text))
            {
                // If fields are filled, ask for confirmation before closing
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

        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            doctorBindingSource.AddNew();
        }
    }
}
