using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class UpdatesControl : UserControl
    {
        public UpdatesControl()
        {
            InitializeComponent();
            this.Resize += UpdatesControl_Resize;
        }

        private void UpdatesControl_Load(object sender, EventArgs e)
        {
            // Optional: logic on load
        }

        private void BtnCheckUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checking for updates...", "System Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdatesControl_Resize(object sender, EventArgs e)
        {
            // Ensure content stays centered (if not using full Dock)
            contentLayout.Left = (this.Width - contentLayout.Width) / 2;
            contentLayout.Top = (this.Height - contentLayout.Height) / 2;
        }

        private void UpdatesControl_Load_1(object sender, EventArgs e)
        {

        }
    }
}
