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
    public partial class ReportsUC : UserControl
    {
        public ReportsUC()
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnGenReport);
        }

        private void LoadComboBox()
        {
            List<string> reports = new List<string>();
            reports.Add("Daily Appointments");
            reports.Add("Monthly Patients per Doctor");
            reports.Add("No-show Statistics");
            reports.Add("Patient Demographics");

            cbReports.DataSource = reports;
        }

        private void ReportsUC_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
    }
}
