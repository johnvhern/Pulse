using Pulse.Data;
using Pulse.Forms.DoctorFRM;
using Pulse.Forms.PatientFRM;
using Pulse.Helper;
using Pulse.Model;
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

            DataUpdateNotifier.DataUpdated += LoadComboBox;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
            null, dgvPatients, new object[] { true });
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new frmAddPatient(patientBindingSource, _doctorRepository, _patientRepository).ShowDialog();
        }

        // Cell click event to handle button clicks
        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPatients.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var cellRectangle = dgvPatients.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int buttonWidth = (cellRectangle.Width - 8) / 2;

                Rectangle button1Rect = new Rectangle(cellRectangle.X + 2, cellRectangle.Y + 2, buttonWidth, cellRectangle.Height - 4);
                Rectangle button2Rect = new Rectangle(cellRectangle.X + 4 + buttonWidth, cellRectangle.Y + 2, buttonWidth, cellRectangle.Height - 4);

                // Get mouse click point relative to DataGridView control
                Point clickPoint = dgvPatients.PointToClient(Cursor.Position);

                var patient = dgvPatients.Rows[e.RowIndex].DataBoundItem as Model.Patient;

                if (button1Rect.Contains(clickPoint))
                {
                    new frmViewPatient(patient, patientBindingSource, _patientRepository).ShowDialog();
                }
                else if (button2Rect.Contains(clickPoint))
                {
                    var selectedPatient = dgvPatients.Rows[e.RowIndex].DataBoundItem as Model.Patient;

                    if (selectedPatient != null)
                    {
                        new frmUpdatePatient(selectedPatient, patientBindingSource, _doctorRepository, _patientRepository).ShowDialog();
                    }
                }
            }
        }

        // Cell painting event to draw buttons
        private void dgvPatients_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvPatients.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                var buttonWidth = (e.CellBounds.Width - 8) / 2;
                Rectangle button1Rect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, buttonWidth, e.CellBounds.Height - 4);
                Rectangle button2Rect = new Rectangle(e.CellBounds.X + 4 + buttonWidth, e.CellBounds.Y + 2, buttonWidth, e.CellBounds.Height - 4);

                ButtonRenderer.DrawButton(e.Graphics, button1Rect, System.Windows.Forms.VisualStyles.PushButtonState.Normal);
                ButtonRenderer.DrawButton(e.Graphics, button2Rect, System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                var viewIcon = Properties.Resources.eye__1_;  // your edit icon
                var editIcon = Properties.Resources.square_pen__1_;    // your delete icon (put your icon)

                int iconSize = 16;

                e.Graphics.DrawImage(viewIcon, new Rectangle(button1Rect.Left + 10, button1Rect.Top + (button1Rect.Height - iconSize) / 2, iconSize, iconSize));
                e.Graphics.DrawImage(editIcon, new Rectangle(button2Rect.Left + 10, button2Rect.Top + (button2Rect.Height - iconSize) / 2, iconSize, iconSize));

                e.Handled = true;
            }
        }

        private async void PatientUC_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private async void LoadComboBox()
        {
            var doctors = await _doctorRepository.GetAll();
            // Load doctors to combobox
            var allDoctor = new Doctor { Id = 0, FullName = "All Doctors" };
            var doctorList = doctors.ToList();
            doctorList.Insert(0, allDoctor);
            cbFilterDoctors.DisplayMember = "FullName";
            cbFilterDoctors.ValueMember = "Id";
            cbFilterDoctors.DataSource = doctorList;
            cbFilterDoctors.SelectedIndex = 0;

            // Assign doctors to the ComboBox column
            var doctorColumn = (DataGridViewComboBoxColumn)dgvPatients.Columns["AssignedDoctor"];
            doctorColumn.DisplayMember = "FullName";
            doctorColumn.ValueMember = "Id";
            doctorColumn.DataSource = doctors.ToList();
        }

        private async void cbFilterDoctors_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedDoctor = (int)cbFilterDoctors.SelectedValue;

            if (selectedDoctor > 0)
            {
                var result = await _patientRepository.GetByDoctorId(selectedDoctor);
                patientBindingSource.DataSource = result.ToList();
            }
            else if (selectedDoctor == 0)
            {
                patientBindingSource.DataSource = await _patientRepository.GetAll();
            }
        }

        #region -- Search Function --

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            timerSearch.Stop();
            timerSearch.Start();
        }

        private async void timerSearch_Tick(object sender, EventArgs e)
        {
            timerSearch.Stop();

            var selectedDoctor = (int)cbFilterDoctors.SelectedValue;

            string query = txtSearchPatient.Text;
            var patients = await _patientRepository.GetAll();

            if (!string.IsNullOrEmpty(query))
            {
                var results = await _patientRepository.SearchByNameEmail(query);
                patientBindingSource.DataSource = new BindingList<Patient>(results.ToList());
            }
            else
            {
                patientBindingSource.DataSource = new BindingList<Patient>(patients.ToList());
            }

            //if (string.IsNullOrEmpty(query))
            //{
            //    if (selectedDoctor > 0)
            //    {
            //        var result = await _patientRepository.GetByDoctorId(selectedDoctor);
            //        patientBindingSource.DataSource = new BindingList<Patient>(result.ToList());
            //    }
            //    else if (selectedDoctor == 0)
            //    {
            //        patientBindingSource.DataSource = new BindingList<Patient>(patients.ToList());
            //    }
            //}
            //else
            //{
            //    var filtered = patients
            //        .Where(p => p.FullName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.EmailAddress.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

            //    patientBindingSource.DataSource = new BindingList<Patient>(filtered);
            //}
        }

        #endregion
    }
}