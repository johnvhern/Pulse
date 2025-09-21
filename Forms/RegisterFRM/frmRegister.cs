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

namespace Pulse.Forms.RegisterFRM
{
    public partial class frmRegister : MetroForm
    {
        public frmRegister()
        {
            InitializeComponent();
            SfButtonStyle.GreenButton(btnRegister);
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            new frmRegisterInfo().ShowDialog();
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = '\u25CF';

            if (txtPass.Text != txtConfirmPass.Text)
            {
                lblConfirmPass.Text = "Password does not match";
                lblConfirmPass.ForeColor = Color.Red;
                lblConfirmPass.Visible = true;
            }
            else
            {
                lblConfirmPass.Visible = false;
            }

            if (string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                txtConfirmPass.Clear();
                imgShowConfirmPass.Visible = false;
                imgShowConfirmPass.Image = Resources.eye__2_;
            }
            else
            {
                imgShowConfirmPass.Visible = true;
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

        private void ShowPassword(object sender, EventArgs e)
        {
            if (sender == imgShowPass)
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
            else
            {
                if (txtConfirmPass.PasswordChar == '\u25CF')
                {
                    txtConfirmPass.PasswordChar = '\0';
                    imgShowConfirmPass.Image = Resources.eye_off;
                }
                else
                {
                    txtConfirmPass.PasswordChar = '\u25CF';
                    imgShowConfirmPass.Image = Resources.eye__2_;
                }
            }
        }
    }
}
