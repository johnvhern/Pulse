using Pulse.Forms.DoctorFRM;
using Pulse.Helper;
using Pulse.Repository.DoctorRepo;
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
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            new frmAddDoctor(doctorBindingSource, _doctorRepository).ShowDialog();
        }

        private async void DoctorUC_Load(object sender, EventArgs e)
        {
            doctorBindingSource.DataSource = await _doctorRepository.GetAll();
        }
    }
}
