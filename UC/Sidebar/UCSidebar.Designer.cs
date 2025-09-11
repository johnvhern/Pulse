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
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            pictureBox1 = new PictureBox();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)sidebarPanel).BeginInit();
            sidebarPanel.SuspendLayout();
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
            sidebarPanel.Controls.Add(gradientPanel1);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Padding = new Padding(10, 0, 10, 0);
            sidebarPanel.Size = new Size(299, 912);
            sidebarPanel.TabIndex = 0;
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
            gradientPanel1.Location = new Point(10, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(277, 113);
            gradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(67, 31);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(62, 30);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "Pulse";
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = SystemColors.GrayText;
            autoLabel2.Location = new Point(69, 61);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(173, 17);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "Patient Manegement System";
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
    }
}
