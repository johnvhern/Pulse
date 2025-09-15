namespace Pulse.UC.Screens
{
    partial class PatientUC
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dgvPatients = new DataGridView();
            doctorBindingSource = new BindingSource(components);
            patientBindingSource = new BindingSource(components);
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtSearchDoctor = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            btnAddPatient = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            timerSearch = new System.Windows.Forms.Timer(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doctorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AssignedDoctor = new DataGridViewComboBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doctorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).BeginInit();
            gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearchDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            gradientPanel1.Padding = new Padding(15, 20, 15, 15);
            gradientPanel1.Size = new Size(1129, 637);
            gradientPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(gradientPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 76);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1099, 546);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(gradientPanel7);
            gradientPanel3.Controls.Add(gradientPanel6);
            gradientPanel3.Controls.Add(gradientPanel5);
            gradientPanel3.Dock = DockStyle.Fill;
            gradientPanel3.Location = new Point(3, 15);
            gradientPanel3.Margin = new Padding(3, 15, 3, 3);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(1093, 528);
            gradientPanel3.TabIndex = 0;
            // 
            // gradientPanel7
            // 
            gradientPanel7.BorderColor = Color.FromArgb(226, 232, 240);
            gradientPanel7.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel7.Controls.Add(dgvPatients);
            gradientPanel7.Dock = DockStyle.Fill;
            gradientPanel7.Location = new Point(0, 80);
            gradientPanel7.Name = "gradientPanel7";
            gradientPanel7.Padding = new Padding(10);
            gradientPanel7.Size = new Size(1093, 448);
            gradientPanel7.TabIndex = 9;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AllowUserToResizeRows = false;
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.BackgroundColor = Color.White;
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 245, 246);
            dataGridViewCellStyle1.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(147, 150, 159);
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(243, 245, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(147, 150, 159);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, emailAddressDataGridViewTextBoxColumn, doctorIdDataGridViewTextBoxColumn, AssignedDoctor, addressDataGridViewTextBoxColumn, doctorDataGridViewTextBoxColumn, Actions });
            dgvPatients.DataSource = patientBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPatients.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.GridColor = Color.FromArgb(226, 232, 240);
            dgvPatients.Location = new Point(10, 10);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.RowTemplate.Height = 40;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(1071, 426);
            dgvPatients.TabIndex = 0;
            dgvPatients.CellContentClick += dgvPatients_CellContentClick;
            dgvPatients.CellPainting += dgvPatients_CellPainting;
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(Model.Doctor);
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Model.Patient);
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderStyle = BorderStyle.None;
            gradientPanel6.Dock = DockStyle.Top;
            gradientPanel6.Location = new Point(0, 65);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(1093, 15);
            gradientPanel6.TabIndex = 8;
            // 
            // gradientPanel5
            // 
            gradientPanel5.Border3DStyle = Border3DStyle.Flat;
            gradientPanel5.BorderColor = Color.FromArgb(226, 232, 240);
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(gradientPanel4);
            gradientPanel5.Dock = DockStyle.Top;
            gradientPanel5.Location = new Point(0, 0);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(10);
            gradientPanel5.Size = new Size(1093, 65);
            gradientPanel5.TabIndex = 7;
            // 
            // gradientPanel4
            // 
            gradientPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel4.BorderColor = Color.Gainsboro;
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(txtSearchDoctor);
            gradientPanel4.Controls.Add(pictureBox1);
            gradientPanel4.Location = new Point(13, 13);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(1065, 37);
            gradientPanel4.TabIndex = 4;
            // 
            // txtSearchDoctor
            // 
            txtSearchDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bannerTextInfo1.Text = "Search patients by name or email";
            bannerTextInfo1.Visible = true;
            bannerTextProvider1.SetBannerText(txtSearchDoctor, bannerTextInfo1);
            txtSearchDoctor.BeforeTouchSize = new Size(1016, 23);
            txtSearchDoctor.Border3DStyle = Border3DStyle.Flat;
            txtSearchDoctor.BorderColor = Color.Transparent;
            txtSearchDoctor.BorderStyle = BorderStyle.FixedSingle;
            txtSearchDoctor.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchDoctor.Location = new Point(43, 6);
            txtSearchDoctor.Name = "txtSearchDoctor";
            txtSearchDoctor.Size = new Size(1016, 23);
            txtSearchDoctor.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.search__2_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(sfButton1);
            gradientPanel2.Controls.Add(btnAddPatient);
            gradientPanel2.Controls.Add(autoLabel2);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(15, 20);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1099, 56);
            gradientPanel2.TabIndex = 4;
            // 
            // sfButton1
            // 
            sfButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            sfButton1.BackColor = Color.FromArgb(0, 213, 99);
            sfButton1.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfButton1.ForeColor = Color.White;
            sfButton1.Location = new Point(1838, 10);
            sfButton1.Name = "sfButton1";
            sfButton1.Size = new Size(137, 16);
            sfButton1.Style.BackColor = Color.FromArgb(0, 213, 99);
            sfButton1.Style.ForeColor = Color.White;
            sfButton1.Style.Image = Properties.Resources.plus__2_;
            sfButton1.TabIndex = 2;
            sfButton1.Text = "Add Doctor";
            sfButton1.TextAlign = ContentAlignment.MiddleRight;
            sfButton1.UseVisualStyleBackColor = false;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddPatient.BackColor = Color.FromArgb(0, 213, 99);
            btnAddPatient.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPatient.ForeColor = Color.White;
            btnAddPatient.Location = new Point(959, 10);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(137, 36);
            btnAddPatient.Style.BackColor = Color.FromArgb(0, 213, 99);
            btnAddPatient.Style.ForeColor = Color.White;
            btnAddPatient.Style.Image = Properties.Resources.plus__2_;
            btnAddPatient.TabIndex = 3;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.TextAlign = ContentAlignment.MiddleRight;
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(147, 150, 159);
            autoLabel2.Location = new Point(3, 30);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(257, 18);
            autoLabel2.TabIndex = 1;
            autoLabel2.Text = "Manage patient records and information";
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel1.Location = new Point(0, 4);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(87, 27);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Patients";
            // 
            // timerSearch
            // 
            timerSearch.Interval = 500;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Name";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfBirthDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            emailAddressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorIdDataGridViewTextBoxColumn
            // 
            doctorIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorIdDataGridViewTextBoxColumn.DataPropertyName = "DoctorId";
            doctorIdDataGridViewTextBoxColumn.HeaderText = "Assigned Doctor";
            doctorIdDataGridViewTextBoxColumn.Name = "doctorIdDataGridViewTextBoxColumn";
            doctorIdDataGridViewTextBoxColumn.ReadOnly = true;
            doctorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // AssignedDoctor
            // 
            AssignedDoctor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AssignedDoctor.DataPropertyName = "DoctorId";
            AssignedDoctor.DataSource = doctorBindingSource;
            AssignedDoctor.DisplayMember = "FullName";
            AssignedDoctor.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            AssignedDoctor.FlatStyle = FlatStyle.Flat;
            AssignedDoctor.HeaderText = "Assigned Doctor";
            AssignedDoctor.Name = "AssignedDoctor";
            AssignedDoctor.ReadOnly = true;
            AssignedDoctor.ValueMember = "Id";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            doctorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            doctorDataGridViewTextBoxColumn.ReadOnly = true;
            doctorDataGridViewTextBoxColumn.Visible = false;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.Resizable = DataGridViewTriState.False;
            Actions.Width = 80;
            // 
            // PatientUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "PatientUC";
            Size = new Size(1129, 637);
            Load += PatientUC_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).EndInit();
            gradientPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearchDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.WinForms.Controls.SfButton btnAddPatient;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearchDoctor;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel7;
        private DataGridView dgvPatients;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private System.Windows.Forms.Timer timerSearch;
        private BindingSource patientBindingSource;
        private BindingSource doctorBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn AssignedDoctor;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Actions;
    }
}
