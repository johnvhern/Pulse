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
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("D");
        }
    }
}
