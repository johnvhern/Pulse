namespace Pulse.Forms.DoctorFRM
{
    partial class frmAddDoctor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtFullName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            doctorBindingSource = new BindingSource(components);
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtSpecialization = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtPhoneNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtEmailAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnAddDoctor = new Syncfusion.WinForms.Controls.SfButton();
            btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            doctorDetailError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtFullName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSpecialization).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).BeginInit();
            gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmailAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorDetailError).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(flowLayoutPanel1);
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(15, 5, 15, 15);
            gradientPanel1.Size = new Size(446, 398);
            gradientPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoLabel2);
            flowLayoutPanel1.Controls.Add(gradientPanel4);
            flowLayoutPanel1.Controls.Add(autoLabel3);
            flowLayoutPanel1.Controls.Add(gradientPanel5);
            flowLayoutPanel1.Controls.Add(autoLabel4);
            flowLayoutPanel1.Controls.Add(gradientPanel6);
            flowLayoutPanel1.Controls.Add(autoLabel5);
            flowLayoutPanel1.Controls.Add(gradientPanel7);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(15, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 5, 10, 10);
            flowLayoutPanel1.Size = new Size(416, 283);
            flowLayoutPanel1.TabIndex = 1;
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
            // gradientPanel4
            // 
            gradientPanel4.BorderColor = Color.FromArgb(107, 114, 128);
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(txtFullName);
            gradientPanel4.Location = new Point(13, 26);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Padding = new Padding(5, 5, 20, 5);
            gradientPanel4.Size = new Size(390, 35);
            gradientPanel4.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BeforeTouchSize = new Size(363, 23);
            txtFullName.BorderColor = Color.Transparent;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.DataBindings.Add(new Binding("Text", doctorBindingSource, "FullName", true));
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(5, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(363, 23);
            txtFullName.TabIndex = 1;
            txtFullName.Tag = "FullName";
            txtFullName.WordWrap = false;
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(Model.Doctor);
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel3.Location = new Point(13, 69);
            autoLabel3.Margin = new Padding(3, 5, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(93, 18);
            autoLabel3.TabIndex = 2;
            autoLabel3.Text = "Specialization";
            autoLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gradientPanel5
            // 
            gradientPanel5.BorderColor = Color.FromArgb(107, 114, 128);
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(txtSpecialization);
            gradientPanel5.Location = new Point(13, 90);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(5, 5, 20, 5);
            gradientPanel5.Size = new Size(390, 35);
            gradientPanel5.TabIndex = 9;
            // 
            // txtSpecialization
            // 
            txtSpecialization.BeforeTouchSize = new Size(363, 23);
            txtSpecialization.BorderColor = Color.Transparent;
            txtSpecialization.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialization.DataBindings.Add(new Binding("Text", doctorBindingSource, "Specialization", true));
            txtSpecialization.Dock = DockStyle.Fill;
            txtSpecialization.Font = new Font("Inter", 9.75F);
            txtSpecialization.Location = new Point(5, 5);
            txtSpecialization.Margin = new Padding(3, 5, 3, 3);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(363, 23);
            txtSpecialization.TabIndex = 3;
            txtSpecialization.Tag = "Specialization";
            txtSpecialization.WordWrap = false;
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel4.Location = new Point(13, 133);
            autoLabel4.Margin = new Padding(3, 5, 3, 0);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(102, 18);
            autoLabel4.TabIndex = 4;
            autoLabel4.Text = "Phone Number";
            autoLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderColor = Color.FromArgb(107, 114, 128);
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(txtPhoneNumber);
            gradientPanel6.Location = new Point(13, 154);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Padding = new Padding(5, 5, 20, 5);
            gradientPanel6.Size = new Size(390, 35);
            gradientPanel6.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BeforeTouchSize = new Size(363, 23);
            txtPhoneNumber.BorderColor = Color.Transparent;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.DataBindings.Add(new Binding("Text", doctorBindingSource, "PhoneNumber", true));
            txtPhoneNumber.Dock = DockStyle.Fill;
            txtPhoneNumber.Font = new Font("Inter", 9.75F);
            txtPhoneNumber.Location = new Point(5, 5);
            txtPhoneNumber.Margin = new Padding(3, 5, 3, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(363, 23);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.Tag = "PhoneNumber";
            txtPhoneNumber.WordWrap = false;
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel5.Location = new Point(13, 197);
            autoLabel5.Margin = new Padding(3, 5, 3, 0);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(96, 18);
            autoLabel5.TabIndex = 6;
            autoLabel5.Text = "Email Address";
            autoLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gradientPanel7
            // 
            gradientPanel7.BorderColor = Color.FromArgb(107, 114, 128);
            gradientPanel7.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel7.Controls.Add(txtEmailAddress);
            gradientPanel7.Location = new Point(13, 218);
            gradientPanel7.Name = "gradientPanel7";
            gradientPanel7.Padding = new Padding(5, 5, 20, 5);
            gradientPanel7.Size = new Size(390, 35);
            gradientPanel7.TabIndex = 11;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BeforeTouchSize = new Size(363, 23);
            txtEmailAddress.BorderColor = Color.Transparent;
            txtEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            txtEmailAddress.DataBindings.Add(new Binding("Text", doctorBindingSource, "EmailAddress", true));
            txtEmailAddress.Dock = DockStyle.Fill;
            txtEmailAddress.Font = new Font("Inter", 9.75F);
            txtEmailAddress.Location = new Point(5, 5);
            txtEmailAddress.Margin = new Padding(3, 5, 3, 3);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(363, 23);
            txtEmailAddress.TabIndex = 7;
            txtEmailAddress.Tag = "EmailAddress";
            txtEmailAddress.WordWrap = false;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(btnAddDoctor);
            gradientPanel3.Controls.Add(btnCancel);
            gradientPanel3.Dock = DockStyle.Bottom;
            gradientPanel3.Location = new Point(15, 324);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(10, 0, 10, 0);
            gradientPanel3.Size = new Size(416, 59);
            gradientPanel3.TabIndex = 2;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddDoctor.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDoctor.Location = new Point(12, 11);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(284, 38);
            btnAddDoctor.TabIndex = 1;
            btnAddDoctor.Text = "Add Doctor";
            btnAddDoctor.Click += btnAddDoctor_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            btnCancel.Location = new Point(302, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 38);
            btnCancel.Style.BackColor = Color.White;
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(15, 5);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(416, 36);
            gradientPanel2.TabIndex = 0;
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
            autoLabel1.Size = new Size(416, 36);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Add New Doctor";
            // 
            // doctorDetailError
            // 
            doctorDetailError.ContainerControl = this;
            // 
            // frmAddDoctor
            // 
            AcceptButton = btnAddDoctor;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(107, 114, 128);
            ClientSize = new Size(446, 398);
            Controls.Add(gradientPanel1);
            MaximumSize = new Size(458, 434);
            MinimumSize = new Size(458, 434);
            Name = "frmAddDoctor";
            ShowIcon = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtFullName).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSpecialization).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).EndInit();
            gradientPanel7.ResumeLayout(false);
            gradientPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmailAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)doctorDetailError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnAddDoctor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFullName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSpecialization;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPhoneNumber;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmailAddress;
        private BindingSource doctorBindingSource;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel7;
        private ErrorProvider doctorDetailError;
    }
}