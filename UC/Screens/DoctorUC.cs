using Pulse.Helper;
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
        SfButtonStyle SfButtonStyle = new SfButtonStyle();
        public DoctorUC()
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnAddDoctor);
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
