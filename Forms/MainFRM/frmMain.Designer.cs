namespace Pulse.Forms.MainFRM
{
    partial class frmMain
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
            ucSidebar1 = new Pulse.UC.Sidebar.UCSidebar();
            SuspendLayout();
            // 
            // ucSidebar1
            // 
            ucSidebar1.BackColor = Color.White;
            ucSidebar1.Dock = DockStyle.Left;
            ucSidebar1.Location = new Point(0, 0);
            ucSidebar1.Name = "ucSidebar1";
            ucSidebar1.Size = new Size(299, 716);
            ucSidebar1.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClientSize = new Size(1151, 716);
            Controls.Add(ucSidebar1);
            Margin = new Padding(0);
            Name = "frmMain";
            ShowIcon = false;
            ShowMaximizeBox = false;
            Text = "PULSE";
            ResumeLayout(false);
        }

        #endregion

        private UC.Sidebar.UCSidebar ucSidebar1;
    }
}