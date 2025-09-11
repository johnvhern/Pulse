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
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sidebarPanel).BeginInit();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
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
            sidebarPanel.Controls.Add(gradientPanel2);
            sidebarPanel.Controls.Add(gradientPanel1);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Padding = new Padding(15, 0, 15, 0);
            sidebarPanel.Size = new Size(299, 912);
            sidebarPanel.TabIndex = 0;
            // 
            // gradientPanel2
            // 
            gradientPanel2.Border3DStyle = Border3DStyle.Flat;
            gradientPanel2.BorderColor = Color.Gainsboro;
            gradientPanel2.BorderSides = Border3DSide.Top;
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(15, 827);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(267, 83);
            gradientPanel2.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
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
    }
}
