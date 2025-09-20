using Pulse.Helper;
using Pulse.Properties;
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

namespace Pulse.Forms.LoginFRM
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnSignIn);            
        }

        private void imgShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\u25CF')
            {
                txtPass.PasswordChar = '\0';
                imgShowPass.Image = Resources.eye_off;
            }
            else
            {
                txtPass.PasswordChar = '\u25CF';
                imgShowPass.Image = Resources.eye__2_;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\u25CF';

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Clear();
                imgShowPass.Visible = false;
                imgShowPass.Image = Resources.eye__2_;
            }
            else
            {
                imgShowPass.Visible = true;
            }
        }
    }
}
