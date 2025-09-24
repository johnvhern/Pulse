using Pulse.Helper;
using Pulse.Model;
using Pulse.Repository.AppointmentRepo;
using Pulse.Repository.DoctorRepo;
using Pulse.Repository.PatientRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.UC.Screens
{
    public partial class ReportsUC : UserControl
    {
        private readonly IPatientRepository _patienntRepo;
        private readonly IDoctorRepository _doctorRepo;
        private readonly IAppointmentRepository _appointmentRepo;
        public ReportsUC(IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository, IPatientRepository patientRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnGenerate);
            SfButtonStyle.SecondaryButton(btnExportPDF);

            _appointmentRepo = appointmentRepository;
            _patienntRepo = patientRepository;
            _doctorRepo = doctorRepository;
        }

        #region -- Load Doctor Combobox & Status Combobox

        private async void LoadComboBox()
        {
            var doctors = await _doctorRepo.GetAll();

            // Load doctors to combobox
            var allDoctor = new Doctor { Id = 0, FullName = "All Doctors" };
            var doctorList = doctors.ToList();
            doctorList.Insert(0, allDoctor);
            cbDoctorList.DisplayMember = "FullName";
            cbDoctorList.ValueMember = "Id";
            cbDoctorList.DataSource = doctorList;
            cbDoctorList.SelectedIndex = 0;

            List<string> statusList = new List<string>();
            statusList.Add("All Status");
            statusList.Add("Scheduled");
            statusList.Add("Completed");
            statusList.Add("Cancelled");
            statusList.Add("No-show");
            cbStatusList.DataSource = statusList.ToList();
            cbStatusList.SelectedIndex = 0;
        }

        #endregion

        private void ReportsUC_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("D");
            LoadComboBox();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
