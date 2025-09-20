namespace Pulse.Forms.PatientFRM
{
    partial class frmViewPatient
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
            components = new System.ComponentModel.Container();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblFullName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            patientBindingSource = new BindingSource(components);
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblPhoneNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblAssignedDoctor = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            autoLabel14 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblAge = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblEmailAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblDOB = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(tableLayoutPanel1);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(15, 3, 15, 15);
            gradientPanel1.Size = new Size(505, 266);
            gradientPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 39);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(475, 212);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoLabel2);
            flowLayoutPanel1.Controls.Add(lblFullName);
            flowLayoutPanel1.Controls.Add(autoLabel4);
            flowLayoutPanel1.Controls.Add(lblPhoneNumber);
            flowLayoutPanel1.Controls.Add(autoLabel6);
            flowLayoutPanel1.Controls.Add(lblAssignedDoctor);
            flowLayoutPanel1.Controls.Add(autoLabel7);
            flowLayoutPanel1.Controls.Add(lblAddress);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 5, 10, 10);
            flowLayoutPanel1.Size = new Size(237, 212);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel2.Location = new Point(13, 5);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(70, 18);
            autoLabel2.TabIndex = 0;
            autoLabel2.Text = "Full Name";
            autoLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            lblFullName.DataBindings.Add(new Binding("Text", patientBindingSource, "FullName", true));
            lblFullName.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(107, 114, 128);
            lblFullName.Location = new Point(13, 23);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 18);
            lblFullName.TabIndex = 15;
            lblFullName.Text = "autoLabel8";
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Model.Patient);
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel4.Location = new Point(13, 51);
            autoLabel4.Margin = new Padding(3, 10, 3, 0);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(102, 18);
            autoLabel4.TabIndex = 4;
            autoLabel4.Text = "Phone Number";
            autoLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.DataBindings.Add(new Binding("Text", patientBindingSource, "PhoneNumber", true));
            lblPhoneNumber.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.ForeColor = Color.FromArgb(107, 114, 128);
            lblPhoneNumber.Location = new Point(13, 69);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(81, 18);
            lblPhoneNumber.TabIndex = 17;
            lblPhoneNumber.Text = "autoLabel10";
            // 
            // autoLabel6
            // 
            autoLabel6.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel6.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel6.Location = new Point(13, 97);
            autoLabel6.Margin = new Padding(3, 10, 3, 0);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Size = new Size(111, 18);
            autoLabel6.TabIndex = 12;
            autoLabel6.Text = "Assigned Doctor";
            autoLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAssignedDoctor
            // 
            lblAssignedDoctor.DataBindings.Add(new Binding("Text", patientBindingSource, "DoctorId", true));
            lblAssignedDoctor.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssignedDoctor.ForeColor = Color.FromArgb(107, 114, 128);
            lblAssignedDoctor.Location = new Point(13, 115);
            lblAssignedDoctor.Name = "lblAssignedDoctor";
            lblAssignedDoctor.Size = new Size(81, 18);
            lblAssignedDoctor.TabIndex = 19;
            lblAssignedDoctor.Text = "autoLabel12";
            // 
            // autoLabel7
            // 
            autoLabel7.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel7.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel7.Location = new Point(13, 143);
            autoLabel7.Margin = new Padding(3, 10, 3, 0);
            autoLabel7.Name = "autoLabel7";
            autoLabel7.Size = new Size(60, 18);
            autoLabel7.TabIndex = 14;
            autoLabel7.Text = "Address";
            autoLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            lblAddress.DataBindings.Add(new Binding("Text", patientBindingSource, "Address", true));
            lblAddress.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.FromArgb(107, 114, 128);
            lblAddress.Location = new Point(13, 161);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(81, 18);
            lblAddress.TabIndex = 20;
            lblAddress.Text = "autoLabel13";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(autoLabel14);
            flowLayoutPanel2.Controls.Add(lblAge);
            flowLayoutPanel2.Controls.Add(autoLabel5);
            flowLayoutPanel2.Controls.Add(lblEmailAddress);
            flowLayoutPanel2.Controls.Add(autoLabel3);
            flowLayoutPanel2.Controls.Add(lblDOB);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(237, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10, 5, 10, 10);
            flowLayoutPanel2.Size = new Size(238, 212);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // autoLabel14
            // 
            autoLabel14.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel14.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel14.Location = new Point(13, 5);
            autoLabel14.Name = "autoLabel14";
            autoLabel14.Size = new Size(33, 18);
            autoLabel14.TabIndex = 21;
            autoLabel14.Text = "Age";
            autoLabel14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.FromArgb(107, 114, 128);
            lblAge.Location = new Point(13, 23);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(81, 18);
            lblAge.TabIndex = 22;
            lblAge.Text = "autoLabel15";
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel5.Location = new Point(13, 51);
            autoLabel5.Margin = new Padding(3, 10, 3, 0);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(96, 18);
            autoLabel5.TabIndex = 6;
            autoLabel5.Text = "Email Address";
            autoLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.DataBindings.Add(new Binding("Text", patientBindingSource, "EmailAddress", true));
            lblEmailAddress.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailAddress.ForeColor = Color.FromArgb(107, 114, 128);
            lblEmailAddress.Location = new Point(13, 69);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(78, 18);
            lblEmailAddress.TabIndex = 18;
            lblEmailAddress.Text = "autoLabel11";
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel3.Location = new Point(13, 97);
            autoLabel3.Margin = new Padding(3, 10, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(84, 18);
            autoLabel3.TabIndex = 2;
            autoLabel3.Text = "Date of Birth";
            autoLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDOB
            // 
            lblDOB.DataBindings.Add(new Binding("Text", patientBindingSource, "DateOfBirth", true));
            lblDOB.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.ForeColor = Color.FromArgb(107, 114, 128);
            lblDOB.Location = new Point(13, 115);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(76, 18);
            lblDOB.TabIndex = 16;
            lblDOB.Text = "autoLabel9";
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(15, 3);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(475, 36);
            gradientPanel2.TabIndex = 2;
            // 
            // autoLabel1
            // 
            autoLabel1.AutoSize = false;
            autoLabel1.Dock = DockStyle.Fill;
            autoLabel1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel1.Location = new Point(0, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Padding = new Padding(8, 0, 0, 0);
            autoLabel1.Size = new Size(475, 36);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Patient Details";
            // 
            // frmViewPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 266);
            Controls.Add(gradientPanel1);
            MaximumSize = new Size(517, 302);
            MinimumSize = new Size(517, 302);
            Name = "frmViewPatient";
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private BindingSource patientBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblFullName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPhoneNumber;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblAssignedDoctor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblAddress;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel14;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblAge;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblEmailAddress;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDOB;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}