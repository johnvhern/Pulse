using Pulse.Forms.MainFRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.UC.Topbar
{
    public partial class UCTopbar : UserControl
    {
        frmMain _main;
        public UCTopbar(frmMain main)
        {
            InitializeComponent();
            _main = main;
        }
    }
}
