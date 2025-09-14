using Pulse.Data;
using Pulse.Forms.PatientFRM;
using Pulse.Helper;
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
    public partial class PatientUC : UserControl
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;
        public PatientUC(IDoctorRepository doctorRepository, IPatientRepository patientRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddPatient);

            _doctorRepository = doctorRepository;
            _patientRepository = patientRepository;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new frmAddPatient(patientBindingSource, _doctorRepository, _patientRepository).ShowDialog();
        }

        private async void PatientUC_Load(object sender, EventArgs e)
        {
            // Get doctors
            var doctors = await _doctorRepository.GetAll();

            // Assign doctors to the ComboBox column
            var doctorColumn = (DataGridViewComboBoxColumn)dgvPatients.Columns["AssignedDoctor"];
            doctorColumn.DataSource = doctors.ToList();
            doctorColumn.DisplayMember = "FullName";
            doctorColumn.ValueMember = "Id";

            // Load patients
            var patients = await _patientRepository.GetAll();
            patientBindingSource.DataSource = patients.ToList();
        }
    }
}
