namespace Pulse.UC.Topbar
{
    partial class UCTopbar
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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            lblUser = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Border3DStyle = Border3DStyle.Flat;
            gradientPanel1.BorderColor = Color.FromArgb(226, 232, 240);
            gradientPanel1.BorderSides = Border3DSide.Bottom;
            gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel1.Controls.Add(gradientPanel3);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Padding = new Padding(5);
            gradientPanel1.Size = new Size(1151, 73);
            gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel3
            // 
            gradientPanel3.BorderColor = Color.Gainsboro;
            gradientPanel3.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel3.Controls.Add(textBoxExt1);
            gradientPanel3.Controls.Add(pictureBox1);
            gradientPanel3.Location = new Point(13, 17);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(491, 35);
            gradientPanel3.TabIndex = 2;
            // 
            // textBoxExt1
            // 
            textBoxExt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bannerTextInfo2.Text = "Search patients, doctors, appointments";
            bannerTextInfo2.Visible = true;
            bannerTextProvider1.SetBannerText(textBoxExt1, bannerTextInfo2);
            textBoxExt1.BeforeTouchSize = new Size(440, 23);
            textBoxExt1.Border3DStyle = Border3DStyle.Flat;
            textBoxExt1.BorderColor = Color.Transparent;
            textBoxExt1.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxExt1.Location = new Point(44, 5);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.Size = new Size(440, 23);
            textBoxExt1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.search__2_;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.None;
            gradientPanel2.Controls.Add(lblUser);
            gradientPanel2.Controls.Add(autoLabel1);
            gradientPanel2.Dock = DockStyle.Right;
            gradientPanel2.Location = new Point(807, 5);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(337, 61);
            gradientPanel2.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = false;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(107, 114, 128);
            lblUser.Location = new Point(0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(337, 30);
            lblUser.TabIndex = 1;
            lblUser.Text = "Welcome back, Jane Doe!";
            lblUser.TextAlign = ContentAlignment.BottomRight;
            // 
            // autoLabel1
            // 
            autoLabel1.AutoSize = false;
            autoLabel1.Dock = DockStyle.Bottom;
            autoLabel1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(147, 150, 159);
            autoLabel1.Location = new Point(0, 30);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(337, 31);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Secretary";
            autoLabel1.TextAlign = ContentAlignment.TopRight;
            // 
            // UCTopbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gradientPanel1);
            Name = "UCTopbar";
            Size = new Size(1151, 73);
            Load += UCTopbar_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel3).EndInit();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblUser;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private PictureBox pictureBox1;
    }
}
