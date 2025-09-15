using Pulse.Forms.DoctorFRM;
using Pulse.Helper;
using Pulse.Model;
using Pulse.Repository.DoctorRepo;
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
    public partial class DoctorUC : UserControl
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorUC(IDoctorRepository doctorRepository)
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddDoctor);

            _doctorRepository = doctorRepository;

            // Enable double buffering for smoother rendering
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
            null, dgvDoctors, new object[] { true });
        }

        #region -- Click Events --

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            new frmAddDoctor(doctorBindingSource, _doctorRepository).ShowDialog();
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDoctors.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var doctor = dgvDoctors.Rows[e.RowIndex].DataBoundItem as Model.Doctor;

                if (doctor != null)
                {
                    new frmUpdateDoctor(doctor, doctorBindingSource, _doctorRepository).ShowDialog();
                }
            }
        }

        #endregion

        private void dgvDoctors_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvDoctors.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var img = Properties.Resources.square_pen__1_;

                int imgWidth = 16;
                int imgHeight = 16;

                int x = e.CellBounds.Left + (e.CellBounds.Width - imgWidth) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - imgHeight) / 2;

                e.Graphics.DrawImage(img, new Rectangle(x, y, imgWidth, imgHeight));

                e.Handled = true;
            }
        }

        private async void DoctorUC_Load(object sender, EventArgs e)
        {
            doctorBindingSource.DataSource = await _doctorRepository.GetAll();
        }

        #region -- Search Function --

        private async void timerSearch_Tick(object sender, EventArgs e)
        {
            timerSearch.Stop();

            string query = txtSearchDoctor.Text.Trim();
            var doctors = await _doctorRepository.GetAll();

            if (string.IsNullOrEmpty(query))
            {
                doctorBindingSource.DataSource = new BindingList<Doctor>(doctors.ToList());
            }
            else
            {
                var filtered = doctors
                    .Where(d => d.FullName.Contains(query, StringComparison.OrdinalIgnoreCase) || d.Specialization.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

                doctorBindingSource.DataSource = new BindingList<Doctor>(filtered);
            }
        }

        private void txtSearchDoctor_TextChanged(object sender, EventArgs e)
        {
            timerSearch.Stop();
            timerSearch.Start();
        }

        #endregion
    }
}