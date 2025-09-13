using Pulse.UC.Screens;
using Pulse.UC.Sidebar;
using Pulse.UC.Topbar;
using Syncfusion.Windows.Forms;

namespace Pulse.Forms.MainFRM
{
    public partial class frmMain : MetroForm
    {
        private bool isDragging = false;
        public frmMain()
        {
            InitializeComponent();
            this.Text = $"Pulse - {Application.ProductVersion}";
            this.WindowState = FormWindowState.Maximized;

            // Add Topbar
            UCTopbar topbar = new UCTopbar(this);
            topbar.Dock = DockStyle.Top;
            this.Controls.Add(topbar);

            // Add Sidebar
            UCSidebar sidebar = new UCSidebar(this);
            sidebar.Dock = DockStyle.Left;
            this.Controls.Add(sidebar);
        }

        #region -- Windows dragging fix --
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int WM_NCLBUTTONDBLCLK = 0x00A3;
            const int SC_MOVE = 0xF010; // Move command
            const int WM_EXITSIZEMOVE = 0x0232; // Event when dragging stops

            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return; // Ignore the double-click event on the title bar
            }

            // Detect when dragging starts
            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_MOVE)
            {
                isDragging = true;
            }

            // Detect when dragging stops
            if (m.Msg == WM_EXITSIZEMOVE && isDragging)
            {
                isDragging = false;
                this.WindowState = FormWindowState.Maximized; // Re-maximize
            }

            base.WndProc(ref m);
        }

        #endregion

        public void frmMain_Load(object sender, EventArgs e)
        {
            OpenScreen(new DashboardUC());
        }

        public void OpenScreen(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
            control.Show();
        }
    }
}
