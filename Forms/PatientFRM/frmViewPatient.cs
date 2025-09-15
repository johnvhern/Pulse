using Pulse.Model;
using Pulse.Repository.PatientRepo;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.Forms.PatientFRM
{
    public partial class frmViewPatient : MetroForm
    {
        private readonly Patient _patient;
        private readonly IBindingList _bindingList;
        private IPatientRepository _patientRepository;
        public frmViewPatient(Patient patient, IBindingList bindingList, IPatientRepository patientRepository)
        {
            InitializeComponent();
            _patient = patient;
            _bindingList = bindingList;
            _patientRepository = patientRepository;

            LoadPatientDetails();
        }

        private void LoadPatientDetails()
        {
            #region -- Calculate Age --

            var dob = DateTime.ParseExact(_patient.DateOfBirth.Value.ToString("MM/dd/yyyy"), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var today = DateTime.Today;

            int age = today.Year - dob.Year;

            // If the birthday hasn't occurred this year yet, subtract 1 from age
            if (dob.Date > today.AddYears(-age))
            {
                age--;
            }

            #endregion


            if (_patient != null)
            {
                lblFullName.Text = _patient.FullName;
                lblPhoneNumber.Text = _patient.PhoneNumber;
                lblAssignedDoctor.Text = _patient.Doctor.FullName;
                lblAddress.Text = _patient.Address;
                lblAge.Text = age.ToString();
                lblEmailAddress.Text = _patient.EmailAddress;
                lblDOB.Text = _patient.DateOfBirth.Value.ToString("MM/dd/yyyy");
            }
        }
    }
}
