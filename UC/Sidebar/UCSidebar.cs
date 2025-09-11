using Pulse.Forms.MainFRM;
using Pulse.Helper;
using Pulse.UC.Screens;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
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
        SfButton activeButton;
        SfButtonStyle btnStyle = new SfButtonStyle();
        frmMain _main;

        #region -- Screen Instances --

        DashboardUC dashboard = new DashboardUC();
        DoctorUC doctor = new DoctorUC();
        PatientUC patient = new PatientUC();
        AppointmentUC appointment = new AppointmentUC();
        ReportsUC reports = new ReportsUC();

        #endregion

        public UCSidebar(frmMain main)
        {
            InitializeComponent();
            btnStyle.ApplyNavButtonStyle(this);
            ColorActiveButton(btnDashboard);
            _main = main;
        }

        private void ColorActiveButton(SfButton button)
        {
            if (activeButton != null)
            {
                activeButton.Style.BackColor = Color.White;
                activeButton.Style.ForeColor = Color.FromArgb(147, 150, 159);
                activeButton.Style.ImageForeColor = Color.FromArgb(147, 150, 159);
            }

            activeButton = button;
            activeButton.Style.BackColor = Color.FromArgb(227, 254, 240);
            activeButton.Style.ForeColor = Color.FromArgb(34, 181, 115);
            activeButton.Style.ImageForeColor = Color.FromArgb(34, 181, 115);
        }

        #region -- Button Click Events --

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(dashboard);
            ColorActiveButton(btnDashboard);

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(doctor);
            ColorActiveButton(btnDoctor);
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(patient);
            ColorActiveButton(btnPatient);
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(appointment);
            ColorActiveButton(btnAppointment);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            _main.OpenScreen(reports);
            ColorActiveButton(btnReports);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ColorActiveButton(btnLogout);
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

        #endregion
    }
}
