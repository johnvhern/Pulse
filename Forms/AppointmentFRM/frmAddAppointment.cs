using Pulse.Helper;
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

namespace Pulse.Forms.AppointmentFRM
{
    public partial class frmAddAppointment : MetroForm
    {
        private readonly IBindingList _bindingList;
        private readonly IPatientRepository _patientRepository;
        private readonly IDoctorRepository _doctorRepository;
        public frmAddAppointment(IBindingList bindingList, IPatientRepository patientRepository, IDoctorRepository doctorRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddAppointment);
            SfButtonStyle.SecondaryButton(btnCancel);

            _bindingList = bindingList;
            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
        }

        private async void frmAddAppointment_Load(object sender, EventArgs e)
        {
            #region -- Combobox Data Load --

            var _patients = await _patientRepository.GetAll();
            var _doctors = await _doctorRepository.GetAll();

            cbSelectedPatient.DataSource = _patients.ToList();
            cbSelectedPatient.DisplayMember = "FullName";
            cbSelectedPatient.ValueMember = "Id";

            cbSelectedDoctor.DataSource = _doctors.ToList();
            cbSelectedDoctor.DisplayMember = "FullName";
            cbSelectedDoctor.ValueMember = "Id";

            #endregion
        }
    }
}
