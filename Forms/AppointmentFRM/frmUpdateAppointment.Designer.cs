namespace Pulse.Forms.AppointmentFRM
{
    partial class frmUpdateAppointment
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
            cbSelectedPatient = new Syncfusion.WinForms.ListView.SfComboBox();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            cbSelectedDoctor = new Syncfusion.WinForms.ListView.SfComboBox();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            dtDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            appointmentBindingSource = new BindingSource(components);
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtNotes = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnUpdateAppointment = new Syncfusion.WinForms.Controls.SfButton();
            btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnDeleteAppointment = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            appointmentDetailError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbSelectedPatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).BeginInit();
            gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbSelectedDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).BeginInit();
            gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentDetailError).BeginInit();
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
            gradientPanel1.Size = new Size(446, 448);
            gradientPanel1.TabIndex = 1;
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
            flowLayoutPanel1.Controls.Add(txtNotes);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(15, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 5, 10, 10);
            flowLayoutPanel1.Size = new Size(416, 333);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel2.Location = new Point(13, 5);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(50, 18);
            autoLabel2.TabIndex = 0;
            autoLabel2.Text = "Patient";
            autoLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gradientPanel4
            // 
            gradientPanel4.BorderColor = Color.FromArgb(107, 114, 128);
            gradientPanel4.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel4.Controls.Add(cbSelectedPatient);
            gradientPanel4.Location = new Point(13, 26);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Padding = new Padding(0, 0, 20, 0);
            gradientPanel4.Size = new Size(390, 35);
            gradientPanel4.TabIndex = 8;
            // 
            // cbSelectedPatient
            // 
            cbSelectedPatient.AllowDropDownResize = false;
            cbSelectedPatient.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSelectedPatient.AutoCompleteSuggestDelay = 200;
            cbSelectedPatient.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            cbSelectedPatient.BorderStyle = BorderStyle.None;
            cbSelectedPatient.Dock = DockStyle.Fill;
            cbSelectedPatient.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cbSelectedPatient.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectedPatient.Location = new Point(0, 0);
            cbSelectedPatient.Name = "cbSelectedPatient";
            cbSelectedPatient.Size = new Size(368, 33);
            cbSelectedPatient.Style.EditorStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectedPatient.Style.ReadOnlyEditorStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectedPatient.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            cbSelectedPatient.Style.TokenStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectedPatient.TabIndex = 2;
            cbSelectedPatient.TabStop = false;
            cbSelectedPatient.Tag = "PatientId";
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel3.Location = new Point(13, 69);
            autoLabel3.Margin = new Padding(3, 5, 3, 0);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(50, 18);
            autoLabel3.TabIndex = 2;
            autoLabel3.Text = "Doctor";
            autoLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gradientPanel5
            // 
            gradientPanel5.BorderColor = Color.FromArgb(107, 114, 128);
            gradientPanel5.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel5.Controls.Add(cbSelectedDoctor);
            gradientPanel5.Location = new Point(13, 90);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Padding = new Padding(0, 0, 20, 0);
            gradientPanel5.Size = new Size(390, 35);
            gradientPanel5.TabIndex = 9;
            // 
            // cbSelectedDoctor
            // 
            cbSelectedDoctor.AllowDropDownResize = false;
            cbSelectedDoctor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSelectedDoctor.AutoCompleteSuggestDelay = 200;
            cbSelectedDoctor.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            cbSelectedDoctor.BorderStyle = BorderStyle.None;
            cbSelectedDoctor.Dock = DockStyle.Fill;
            cbSelectedDoctor.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            cbSelectedDoctor.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectedDoctor.Location = new Point(0, 0);
            cbSelectedDoctor.Name = "cbSelectedDoctor";
            cbSelectedDoctor.Size = new Size(368, 33);
            cbSelectedDoctor.Style.EditorStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectedDoctor.Style.ReadOnlyEditorStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectedDoctor.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            cbSelectedDoctor.Style.TokenStyle.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectedDoctor.TabIndex = 1;
            cbSelectedDoctor.TabStop = false;
            cbSelectedDoctor.Tag = "DoctorId";
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel4.Location = new Point(13, 133);
            autoLabel4.Margin = new Padding(3, 5, 3, 0);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(36, 18);
            autoLabel4.TabIndex = 4;
            autoLabel4.Text = "Date";
            autoLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gradientPanel6
            // 
            gradientPanel6.BorderColor = Color.FromArgb(107, 114, 128);
            gradientPanel6.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel6.Controls.Add(dtDate);
            gradientPanel6.Location = new Point(13, 154);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Padding = new Padding(0, 5, 20, 5);
            gradientPanel6.Size = new Size(390, 35);
            gradientPanel6.TabIndex = 10;
            // 
            // dtDate
            // 
            dtDate.DataBindings.Add(new Binding("Text", appointmentBindingSource, "Date", true));
            dtDate.DataBindings.Add(new Binding("Value", appointmentBindingSource, "Date", true, DataSourceUpdateMode.OnValidation, null, "d"));
            dtDate.DateTimeIcon = null;
            dtDate.Dock = DockStyle.Fill;
            dtDate.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtDate.Location = new Point(0, 5);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(368, 23);
            dtDate.Style.BorderColor = Color.Transparent;
            dtDate.Style.FocusedBorderColor = Color.Transparent;
            dtDate.Style.HoverBorderColor = Color.Transparent;
            dtDate.TabIndex = 1;
            dtDate.Tag = "Date";
            dtDate.ToolTipText = "";
            // 
            // appointmentBindingSource
            // 
            appointmentBindingSource.DataSource = typeof(Model.Appointment);
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.FromArgb(107, 114, 128);
            autoLabel5.Location = new Point(13, 197);
            autoLabel5.Margin = new Padding(3, 5, 3, 0);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(45, 18);
            autoLabel5.TabIndex = 6;
            autoLabel5.Text = "Notes";
            autoLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.BeforeTouchSize = new Size(363, 23);
            txtNotes.BorderColor = Color.FromArgb(107, 114, 128);
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.DataBindings.Add(new Binding("Text", appointmentBindingSource, "Notes", true));
            txtNotes.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(13, 218);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(390, 102);
            txtNotes.TabIndex = 11;
            txtNotes.Tag = "Notes";
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderStyle = BorderStyle.None;
            gradientPanel3.Controls.Add(btnUpdateAppointment);
            gradientPanel3.Controls.Add(btnCancel);
            gradientPanel3.Dock = DockStyle.Bottom;
            gradientPanel3.Location = new Point(15, 374);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Padding = new Padding(10, 0, 10, 0);
            gradientPanel3.Size = new Size(416, 59);
            gradientPanel3.TabIndex = 6;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateAppointment.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAppointment.Location = new Point(13, 10);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new Size(284, 38);
            btnUpdateAppointment.TabIndex = 5;
            btnUpdateAppointment.Text = "Update Appointment";
            btnUpdateAppointment.Click += btnUpdateAppointment_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            btnCancel.Location = new Point(303, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 38);
            btnCancel.Style.BackColor = Color.White;
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(btnDeleteAppointment);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(15, 5);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(416, 36);
            gradientPanel2.TabIndex = 5;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteAppointment.BackColor = Color.FromArgb(239, 68, 68);
            btnDeleteAppointment.Font = new Font("Segoe UI Semibold", 9F);
            btnDeleteAppointment.ImageSize = new Size(18, 18);
            btnDeleteAppointment.Location = new Point(382, 3);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(34, 28);
            btnDeleteAppointment.Style.BackColor = Color.FromArgb(239, 68, 68);
            btnDeleteAppointment.Style.Image = Properties.Resources.trash_2__1_;
            btnDeleteAppointment.TabIndex = 3;
            btnDeleteAppointment.UseVisualStyleBackColor = false;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
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
            autoLabel1.Text = "Update Appointment";
            // 
            // appointmentDetailError
            // 
            appointmentDetailError.ContainerControl = this;
            // 
            // frmUpdateAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 448);
            Controls.Add(gradientPanel1);
            Name = "frmUpdateAppointment";
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmUpdateAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbSelectedPatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel5).EndInit();
            gradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbSelectedDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel6).EndInit();
            gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentDetailError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.WinForms.ListView.SfComboBox cbSelectedPatient;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.WinForms.ListView.SfComboBox cbSelectedDoctor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtDate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNotes;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateAppointment;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private ErrorProvider appointmentDetailError;
        private BindingSource appointmentBindingSource;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteAppointment;
    }
}