using Pulse.Helper;
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

        public frmAddDoctor()
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddDoctor);
            SfButtonStyle.SecondaryButton(btnCancel);
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {

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
                    this.Close();
                }
             
            }
            else
            {
                // If any field is empty, close the form without confirmation
                this.Close();
            }
        }
    }
}
