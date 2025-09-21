namespace Pulse.Forms.RegisterFRM
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnSignIn = new Syncfusion.WinForms.Controls.SfButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            imgShowPass = new PictureBox();
            txtPass = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            cbShowPass = new CheckBox();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgShowPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Controls.Add(flowLayoutPanel1);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(15);
            gradientPanel1.Size = new Size(382, 501);
            gradientPanel1.TabIndex = 1;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(btnSignIn);
            gradientPanel3.Dock = DockStyle.Top;
            gradientPanel3.Location = new Point(15, 425);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(352, 41);
            gradientPanel3.TabIndex = 3;
            // 
            // btnSignIn
            // 
            btnSignIn.Dock = DockStyle.Fill;
            btnSignIn.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(0, 0);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(352, 41);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoLabel3);
            flowLayoutPanel1.Controls.Add(gradientPanel4);
            flowLayoutPanel1.Controls.Add(autoLabel4);
            flowLayoutPanel1.Controls.Add(gradientPanel6);
            flowLayoutPanel1.Controls.Add(cbShowPass);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(15, 153);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(352, 272);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold);
            autoLabel3.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel3.Location = new Point(3, 15);
            autoLabel3.Margin = new Padding(3, 15, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(73, 18);
            autoLabel3.TabIndex = 0;
            autoLabel3.Text = "Username";
            // 
            // gradientPanel4
            // 
            gradientPanel4.BackgroundImageLayout = ImageLayout.Center;
            gradientPanel4.BorderColor = Color.Gainsboro;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(txtUsername);
            gradientPanel4.Location = new Point(3, 36);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(346, 35);
            gradientPanel4.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left;
            txtUsername.BeforeTouchSize = new Size(283, 23);
            txtUsername.BorderColor = Color.Transparent;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(28, -17);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(313, 23);
            txtUsername.TabIndex = 0;
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold);
            autoLabel4.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel4.Location = new Point(3, 94);
            autoLabel4.Margin = new Padding(3, 20, 3, 0);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(69, 18);
            autoLabel4.TabIndex = 3;
            autoLabel4.Text = "Password";
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderColor = Color.Gainsboro;
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(imgShowPass);
            gradientPanel6.Controls.Add(txtPass);
            gradientPanel6.Location = new Point(3, 115);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(346, 35);
            gradientPanel6.TabIndex = 1;
            // 
            // imgShowPass
            // 
            imgShowPass.Anchor = AnchorStyles.Left;
            imgShowPass.Image = Properties.Resources.eye__1_;
            imgShowPass.Location = new Point(317, 6);
            imgShowPass.Name = "imgShowPass";
            imgShowPass.Size = new Size(20, 20);
            imgShowPass.SizeMode = PictureBoxSizeMode.Zoom;
            imgShowPass.TabIndex = 2;
            imgShowPass.TabStop = false;
            imgShowPass.Visible = false;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Left;
            txtPass.BeforeTouchSize = new Size(283, 23);
            txtPass.BorderColor = Color.Transparent;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(28, -17);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(283, 23);
            txtPass.TabIndex = 1;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPass.Location = new Point(3, 156);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(111, 21);
            cbShowPass.TabIndex = 5;
            cbShowPass.Text = "Remember Me";
            cbShowPass.UseVisualStyleBackColor = true;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(autoLabel2);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Controls.Add(pictureBox1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(15, 15);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(352, 138);
            gradientPanel2.TabIndex = 99;
            // 
            // autoLabel2
            // 
            autoLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            autoLabel2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(147, 150, 159);
            autoLabel2.Location = new Point(78, 100);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(223, 23);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "Patient Management System";
            // 
            // autoLabel1
            // 
            autoLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            autoLabel1.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel1.Location = new Point(144, 70);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(71, 30);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "Pulse";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClientSize = new Size(382, 501);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegister";
            ShowIcon = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgShowPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.WinForms.Controls.SfButton btnSignIn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private PictureBox imgShowPass;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPass;
        private CheckBox cbShowPass;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private PictureBox pictureBox1;
    }
}