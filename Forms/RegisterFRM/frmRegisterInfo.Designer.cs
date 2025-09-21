namespace Pulse.Forms.RegisterFRM
{
    partial class frmRegisterInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 0x00A3;
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return; // Ignore the double-click event on the title bar
            }
            base.WndProc(ref m);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterInfo));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnConfirm = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(gradientPanel4);
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(15);
            gradientPanel1.Size = new Size(425, 340);
            gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderStyle = BorderStyle.None;
            gradientPanel4.Controls.Add(autoLabel2);
            gradientPanel4.Dock = DockStyle.Fill;
            gradientPanel4.Location = new Point(15, 69);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(395, 204);
            gradientPanel4.TabIndex = 2;
            // 
            // autoLabel2
            // 
            autoLabel2.AutoSize = false;
            autoLabel2.Dock = DockStyle.Fill;
            autoLabel2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel2.Location = new Point(0, 0);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Padding = new Padding(5, 0, 5, 0);
            autoLabel2.Size = new Size(395, 204);
            autoLabel2.TabIndex = 0;
            autoLabel2.Text = resources.GetString("autoLabel2.Text");
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(btnConfirm);
            gradientPanel3.Dock = DockStyle.Bottom;
            gradientPanel3.Location = new Point(15, 273);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(5, 0, 5, 0);
            gradientPanel3.Size = new Size(395, 52);
            gradientPanel3.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Top;
            btnConfirm.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(5, 0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(385, 43);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(15, 15);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(395, 54);
            gradientPanel2.TabIndex = 0;
            // 
            // autoLabel1
            // 
            autoLabel1.AutoSize = false;
            autoLabel1.Dock = DockStyle.Fill;
            autoLabel1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel1.Location = new Point(0, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(395, 54);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Registration Form Notice";
            autoLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRegisterInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClientSize = new Size(425, 340);
            Controls.Add(gradientPanel1);
            Name = "frmRegisterInfo";
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information";
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton btnConfirm;
    }
}