namespace Pulse.Forms.LoginFRM
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            pictureBox1 = new PictureBox();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            gradientPanel1.Padding = new Padding(10);
            gradientPanel1.Size = new Size(431, 495);
            gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(autoLabel2);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Controls.Add(pictureBox1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(10, 10);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(411, 138);
            gradientPanel2.TabIndex = 0;
            // 
            // gradientPanel3
            // 
            gradientPanel3.Dock = DockStyle.Bottom;
            gradientPanel3.Location = new Point(10, 405);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(411, 80);
            gradientPanel3.TabIndex = 1;
            // 
            // gradientPanel4
            // 
            gradientPanel4.Dock = DockStyle.Fill;
            gradientPanel4.Location = new Point(10, 148);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(411, 257);
            gradientPanel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // autoLabel1
            // 
            autoLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            autoLabel1.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(107, 112, 129);
            autoLabel1.Location = new Point(173, 70);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(71, 30);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "Pulse";
            // 
            // autoLabel2
            // 
            autoLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            autoLabel2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(147, 150, 159);
            autoLabel2.Location = new Point(107, 100);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(223, 23);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "Patient Management System";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClientSize = new Size(431, 495);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLogin";
            ShowIcon = false;
            ShowMaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private PictureBox pictureBox1;
    }
}