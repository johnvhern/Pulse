using Pulse.Forms.MainFRM;
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

namespace Pulse.UC.Sidebar
{
    public partial class UCSidebar : UserControl
    {
        SfButtonStyle btnStyle = new SfButtonStyle();
        public UCSidebar()
        {
            InitializeComponent();
            btnStyle.ApplyNavButtonStyle(this);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBoxAdv.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.ParentForm.Close();
                Application.Restart();
            }
            else
            {
                return;
            }
        }
    }
}
