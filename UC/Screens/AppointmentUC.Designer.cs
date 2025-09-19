namespace Pulse.UC.Screens
{
    partial class AppointmentUC
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dgvAppointments = new DataGridView();
            PatientId = new DataGridViewComboBoxColumn();
            patientBindingSource = new BindingSource(components);
            DoctorId = new DataGridViewComboBoxColumn();
            doctorBindingSource = new BindingSource(components);
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewComboBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewButtonColumn();
            appointmentBindingSource = new BindingSource(components);
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            cbDateRange = new Syncfusion.WinForms.ListView.SfComboBox();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            txtSearchAppointments = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            btnScheduleAppointment = new Syncfusion.WinForms.Controls.SfButton();
            sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            timerSearch = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).BeginInit();
            gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel8).BeginInit();
            gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbDateRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearchAppointments).BeginInit();
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
            tableLayoutPanel1.TabIndex = 6;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderColor = Color.FromArgb(226, 232, 240);
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(gradientPanel7);
            gradientPanel3.Controls.Add(gradientPanel6);
            gradientPanel3.Controls.Add(gradientPanel4);
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
            gradientPanel7.Controls.Add(dgvAppointments);
            gradientPanel7.Dock = DockStyle.Fill;
            gradientPanel7.Location = new Point(0, 80);
            gradientPanel7.Name = "gradientPanel7";
            gradientPanel7.Padding = new Padding(10);
            gradientPanel7.Size = new Size(1093, 448);
            gradientPanel7.TabIndex = 10;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AllowUserToResizeRows = false;
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.BorderStyle = BorderStyle.None;
            dgvAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 245, 246);
            dataGridViewCellStyle1.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(147, 150, 159);
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(243, 245, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(147, 150, 159);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Columns.AddRange(new DataGridViewColumn[] { PatientId, DoctorId, dateDataGridViewTextBoxColumn, Status, notesDataGridViewTextBoxColumn, Actions });
            dgvAppointments.DataSource = appointmentBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle4.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAppointments.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.GridColor = Color.FromArgb(226, 232, 240);
            dgvAppointments.Location = new Point(10, 10);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.RowTemplate.Height = 40;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1071, 426);
            dgvAppointments.TabIndex = 0;
            dgvAppointments.CellContentClick += dgvAppointments_CellContentClick;
            dgvAppointments.CellPainting += dgvAppointments_CellPainting;
            dgvAppointments.EditingControlShowing += dgvAppointments_EditingControlShowing;
            // 
            // PatientId
            // 
            PatientId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PatientId.DataPropertyName = "PatientId";
            PatientId.DataSource = patientBindingSource;
            PatientId.DisplayMember = "FullName";
            PatientId.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            PatientId.HeaderText = "Patient";
            PatientId.Name = "PatientId";
            PatientId.ValueMember = "Id";
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Model.Patient);
            // 
            // DoctorId
            // 
            DoctorId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DoctorId.DataPropertyName = "DoctorId";
            DoctorId.DataSource = doctorBindingSource;
            DoctorId.DisplayMember = "FullName";
            DoctorId.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            DoctorId.HeaderText = "Doctor";
            DoctorId.Name = "DoctorId";
            DoctorId.ValueMember = "Id";
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(Model.Doctor);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.Padding = new Padding(0, 8, 100, 5);
            Status.DefaultCellStyle = dataGridViewCellStyle2;
            Status.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Status.HeaderText = "Status";
            Status.Items.AddRange(new object[] { "Scheduled", "Completed", "Cancelled", "No-show" });
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.False;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Actions
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(20, 3, 20, 3);
            Actions.DefaultCellStyle = dataGridViewCellStyle3;
            Actions.HeaderText = "Actions";
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.Resizable = DataGridViewTriState.False;
            Actions.Width = 80;
            // 
            // appointmentBindingSource
            // 
            appointmentBindingSource.DataSource = typeof(Model.Appointment);
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderStyle = BorderStyle.None;
            gradientPanel6.Dock = DockStyle.Top;
            gradientPanel6.Location = new Point(0, 65);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(1093, 15);
            gradientPanel6.TabIndex = 9;
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderColor = Color.FromArgb(226, 232, 240);
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(gradientPanel8);
            gradientPanel4.Controls.Add(gradientPanel5);
            gradientPanel4.Dock = DockStyle.Top;
            gradientPanel4.Location = new Point(0, 0);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Padding = new Padding(10);
            gradientPanel4.Size = new Size(1093, 65);
            gradientPanel4.TabIndex = 0;
            // 
            // gradientPanel8
            // 
            gradientPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gradientPanel8.BorderColor = Color.Gainsboro;
            gradientPanel8.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel8.Controls.Add(cbDateRange);
            gradientPanel8.Location = new Point(869, 13);
            gradientPanel8.Name = "gradientPanel8";
            gradientPanel8.Size = new Size(209, 37);
            gradientPanel8.TabIndex = 11;
            // 
            // cbDateRange
            // 
            cbDateRange.AllowDropDownResize = false;
            cbDateRange.BackColor = Color.White;
            cbDateRange.BorderStyle = BorderStyle.None;
            cbDateRange.Dock = DockStyle.Fill;
            cbDateRange.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cbDateRange.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            cbDateRange.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDateRange.Location = new Point(0, 0);
            cbDateRange.Name = "cbDateRange";
            cbDateRange.Size = new Size(207, 35);
            cbDateRange.Style.EditorStyle.BackColor = Color.White;
            cbDateRange.Style.EditorStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDateRange.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            cbDateRange.Style.ReadOnlyEditorStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDateRange.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            cbDateRange.Style.TokenStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDateRange.TabIndex = 0;
            cbDateRange.SelectedValueChanged += cbDateRange_SelectedValueChanged;
            // 
            // gradientPanel5
            // 
            gradientPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel5.BorderColor = Color.Gainsboro;
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(txtSearchAppointments);
            gradientPanel5.Controls.Add(pictureBox1);
            gradientPanel5.Location = new Point(13, 13);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Size = new Size(850, 37);
            gradientPanel5.TabIndex = 5;
            // 
            // txtSearchAppointments
            // 
            txtSearchAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bannerTextInfo1.Text = "Search appointments by patient or doctor";
            bannerTextInfo1.Visible = true;
            bannerTextProvider1.SetBannerText(txtSearchAppointments, bannerTextInfo1);
            txtSearchAppointments.BeforeTouchSize = new Size(801, 23);
            txtSearchAppointments.Border3DStyle = Border3DStyle.Flat;
            txtSearchAppointments.BorderColor = Color.Transparent;
            txtSearchAppointments.BorderStyle = BorderStyle.FixedSingle;
            txtSearchAppointments.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchAppointments.Location = new Point(44, 6);
            txtSearchAppointments.Name = "txtSearchAppointments";
            txtSearchAppointments.Size = new Size(801, 23);
            txtSearchAppointments.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.search__2_;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(sfButton1);
            gradientPanel2.Controls.Add(btnScheduleAppointment);
            gradientPanel2.Controls.Add(sfButton2);
            gradientPanel2.Controls.Add(autoLabel2);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(15, 20);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1099, 56);
            gradientPanel2.TabIndex = 5;
            // 
            // sfButton1
            // 
            sfButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            sfButton1.BackColor = Color.FromArgb(0, 213, 99);
            sfButton1.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfButton1.ForeColor = Color.White;
            sfButton1.Location = new Point(2717, 10);
            sfButton1.Name = "sfButton1";
            sfButton1.Size = new Size(137, 0);
            sfButton1.Style.BackColor = Color.FromArgb(0, 213, 99);
            sfButton1.Style.ForeColor = Color.White;
            sfButton1.Style.Image = Properties.Resources.plus__2_;
            sfButton1.TabIndex = 2;
            sfButton1.Text = "Add Doctor";
            sfButton1.TextAlign = ContentAlignment.MiddleRight;
            sfButton1.UseVisualStyleBackColor = false;
            // 
            // btnScheduleAppointment
            // 
            btnScheduleAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnScheduleAppointment.BackColor = Color.FromArgb(0, 213, 99);
            btnScheduleAppointment.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScheduleAppointment.ForeColor = Color.White;
            btnScheduleAppointment.Location = new Point(890, 10);
            btnScheduleAppointment.Name = "btnScheduleAppointment";
            btnScheduleAppointment.Size = new Size(206, 36);
            btnScheduleAppointment.Style.BackColor = Color.FromArgb(0, 213, 99);
            btnScheduleAppointment.Style.ForeColor = Color.White;
            btnScheduleAppointment.Style.Image = Properties.Resources.plus__2_;
            btnScheduleAppointment.TabIndex = 4;
            btnScheduleAppointment.Text = "Schedule Appointment";
            btnScheduleAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnScheduleAppointment.UseVisualStyleBackColor = false;
            btnScheduleAppointment.Click += btnScheduleAppointment_Click;
            // 
            // sfButton2
            // 
            sfButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            sfButton2.BackColor = Color.FromArgb(0, 213, 99);
            sfButton2.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfButton2.ForeColor = Color.White;
            sfButton2.Location = new Point(1838, 10);
            sfButton2.Name = "sfButton2";
            sfButton2.Size = new Size(137, 16);
            sfButton2.Style.BackColor = Color.FromArgb(0, 213, 99);
            sfButton2.Style.ForeColor = Color.White;
            sfButton2.Style.Image = Properties.Resources.plus__2_;
            sfButton2.TabIndex = 3;
            sfButton2.Text = "Add Patient";
            sfButton2.TextAlign = ContentAlignment.MiddleRight;
            sfButton2.UseVisualStyleBackColor = false;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(147, 150, 159);
            autoLabel2.Location = new Point(3, 30);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(280, 18);
            autoLabel2.TabIndex = 1;
            autoLabel2.Text = "Schedule and manage patient appointments";
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel1.Location = new Point(0, 4);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(143, 27);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Appointments";
            // 
            // timerSearch
            // 
            timerSearch.Interval = 500;
            // 
            // AppointmentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "AppointmentUC";
            Size = new Size(1129, 637);
            Load += AppointmentUC_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel7).EndInit();
            gradientPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel8).EndInit();
            gradientPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbDateRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearchAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.WinForms.Controls.SfButton btnScheduleAppointment;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel7;
        private DataGridView dgvAppointments;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel8;
        private Syncfusion.WinForms.ListView.SfComboBox cbDateRange;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearchAppointments;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private System.Windows.Forms.Timer timerSearch;
        private BindingSource appointmentBindingSource;
        private BindingSource patientBindingSource;
        private DataGridViewComboBoxColumn PatientId;
        private DataGridViewComboBoxColumn DoctorId;
        private BindingSource doctorBindingSource;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Status;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Actions;
    }
}
