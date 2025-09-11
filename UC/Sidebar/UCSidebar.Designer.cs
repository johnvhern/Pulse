namespace Pulse.UC.Sidebar
{
    partial class UCSidebar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSidebar));
            sidebarPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnDashboard = new Syncfusion.WinForms.Controls.SfButton();
            btnDoctor = new Syncfusion.WinForms.Controls.SfButton();
            btnPatient = new Syncfusion.WinForms.Controls.SfButton();
            btnAppointment = new Syncfusion.WinForms.Controls.SfButton();
            btnReports = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnLogout = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sidebarPanel).BeginInit();
            sidebarPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.Border3DStyle = Border3DStyle.Flat;
            sidebarPanel.BorderColor = Color.Gainsboro;
            sidebarPanel.BorderSides = Border3DSide.Right;
            sidebarPanel.BorderStyle = BorderStyle.FixedSingle;
            sidebarPanel.Controls.Add(flowLayoutPanel1);
            sidebarPanel.Controls.Add(gradientPanel2);
            sidebarPanel.Controls.Add(gradientPanel1);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Padding = new Padding(15, 0, 15, 0);
            sidebarPanel.Size = new Size(299, 912);
            sidebarPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoLabel3);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnDoctor);
            flowLayoutPanel1.Controls.Add(btnPatient);
            flowLayoutPanel1.Controls.Add(btnAppointment);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(15, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(267, 739);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = SystemColors.GrayText;
            autoLabel3.Location = new Point(3, 10);
            autoLabel3.Margin = new Padding(3, 10, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(86, 17);
            autoLabel3.TabIndex = 0;
            autoLabel3.Text = "NAVIGATION";
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.ImageMargin = new Padding(10, 3, 3, 3);
            btnDashboard.ImageSize = new Size(18, 18);
            btnDashboard.Location = new Point(3, 37);
            btnDashboard.Margin = new Padding(3, 10, 3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(261, 40);
            btnDashboard.Style.Image = Properties.Resources.layout_dashboard__2_;
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextMargin = new Padding(10, 3, 3, 3);
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDoctor.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoctor.ImageMargin = new Padding(10, 3, 3, 3);
            btnDoctor.ImageSize = new Size(18, 18);
            btnDoctor.Location = new Point(3, 90);
            btnDoctor.Margin = new Padding(3, 10, 3, 3);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(261, 40);
            btnDoctor.Style.Image = Properties.Resources.stethoscope__2_;
            btnDoctor.TabIndex = 2;
            btnDoctor.Text = "Doctor";
            btnDoctor.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctor.TextMargin = new Padding(10, 3, 3, 3);
            btnDoctor.Click += btnDoctor_Click;
            // 
            // btnPatient
            // 
            btnPatient.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatient.ImageMargin = new Padding(10, 3, 3, 3);
            btnPatient.ImageSize = new Size(18, 18);
            btnPatient.Location = new Point(3, 143);
            btnPatient.Margin = new Padding(3, 10, 3, 3);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(261, 40);
            btnPatient.Style.Image = Properties.Resources.users__2_;
            btnPatient.TabIndex = 3;
            btnPatient.Text = "Patient";
            btnPatient.TextAlign = ContentAlignment.MiddleLeft;
            btnPatient.TextMargin = new Padding(10, 3, 3, 3);
            btnPatient.Click += btnPatient_Click;
            // 
            // btnAppointment
            // 
            btnAppointment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointment.ImageMargin = new Padding(10, 3, 3, 3);
            btnAppointment.ImageSize = new Size(18, 18);
            btnAppointment.Location = new Point(3, 196);
            btnAppointment.Margin = new Padding(3, 10, 3, 3);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(261, 40);
            btnAppointment.Style.Image = Properties.Resources.calendar__2_;
            btnAppointment.TabIndex = 4;
            btnAppointment.Text = "Appointment";
            btnAppointment.TextAlign = ContentAlignment.MiddleLeft;
            btnAppointment.TextMargin = new Padding(10, 3, 3, 3);
            btnAppointment.Click += btnAppointment_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.ImageMargin = new Padding(10, 3, 3, 3);
            btnReports.ImageSize = new Size(18, 18);
            btnReports.Location = new Point(3, 249);
            btnReports.Margin = new Padding(3, 10, 3, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(261, 40);
            btnReports.Style.Image = Properties.Resources.file_text__2_;
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextMargin = new Padding(10, 3, 3, 3);
            btnReports.Click += btnReports_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.Border3DStyle = Border3DStyle.Flat;
            gradientPanel2.BorderColor = Color.Gainsboro;
            gradientPanel2.BorderSides = Border3DSide.Top;
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Controls.Add(btnLogout);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(15, 827);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(0, 15, 0, 15);
            gradientPanel2.Size = new Size(267, 83);
            gradientPanel2.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.ImageMargin = new Padding(10, 3, 3, 3);
            btnLogout.ImageSize = new Size(18, 18);
            btnLogout.Location = new Point(0, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(265, 51);
            btnLogout.Style.Image = Properties.Resources.log_out;
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextMargin = new Padding(10, 3, 3, 3);
            btnLogout.Click += btnLogout_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Border3DStyle = Border3DStyle.Flat;
            gradientPanel1.BorderColor = Color.Gainsboro;
            gradientPanel1.BorderSides = Border3DSide.Bottom;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(autoLabel2);
            gradientPanel1.Controls.Add(autoLabel1);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(15, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(267, 88);
            gradientPanel1.TabIndex = 0;
            // 
            // autoLabel2
            // 
            autoLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            autoLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = SystemColors.GrayText;
            autoLabel2.Location = new Point(57, 48);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(173, 17);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "Patient Manegement System";
            // 
            // autoLabel1
            // 
            autoLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            autoLabel1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(55, 19);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(62, 30);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "Pulse";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UCSidebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(sidebarPanel);
            Name = "UCSidebar";
            Size = new Size(299, 912);
            ((System.ComponentModel.ISupportInitialize)sidebarPanel).EndInit();
            sidebarPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel sidebarPanel;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.Controls.SfButton btnDashboard;
        private Syncfusion.WinForms.Controls.SfButton btnDoctor;
        private Syncfusion.WinForms.Controls.SfButton btnPatient;
        private Syncfusion.WinForms.Controls.SfButton btnAppointment;
        private Syncfusion.WinForms.Controls.SfButton btnReports;
        private Syncfusion.WinForms.Controls.SfButton btnLogout;
    }
}
