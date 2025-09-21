using Pulse.Forms.MainFRM;
using Pulse.Helper;
using Pulse.Model;
using Pulse.Repository.AppointmentRepo;
using Pulse.Repository.DoctorRepo;
using Pulse.Repository.PatientRepo;
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
        frmMain _main;

        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IAppointmentRepository _appointmentRepository;

        #region -- Screen Instances --

        DashboardUC dashboard;
        DoctorUC doctor;
        PatientUC patient;
        AppointmentUC appointment;
        ReportsUC reports;

        #endregion

        public UCSidebar(frmMain main, IDoctorRepository doctorRepository, IPatientRepository patientRepository, IAppointmentRepository appointmentRepository)
        {
            InitializeComponent();
            SfButtonStyle.ApplyNavButtonStyle(this);
            ColorActiveButton(btnDashboard);
            _main = main;
            _doctorRepository = doctorRepository;
            _patientRepository = patientRepository;
            _appointmentRepository = appointmentRepository;

            dashboard = new DashboardUC(_patientRepository, _doctorRepository, _appointmentRepository);
            doctor = new DoctorUC(_doctorRepository);
            patient = new PatientUC(_doctorRepository, _patientRepository);
            appointment = new AppointmentUC(_appointmentRepository, _patientRepository, _doctorRepository);
            reports = new ReportsUC();
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
                UserSession.Clear();
                File.Delete(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usersession.dat"));
                this.ParentForm.Close();
                Application.Restart();
            }
            else
            {
                return;
            }
        }

        #endregion

        private void UCSidebar_Load(object sender, EventArgs e)
        {
        }
    }
}
