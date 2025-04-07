using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class InstallControl : UserControl
    {
        public InstallControl()
        {
            InitializeComponent();
            // Layout is handled by TableLayoutPanel, no manual centering needed
        }

        private void InstallControl_Load(object sender, EventArgs e)
        {
            // Optional: initialization logic if needed
        }

        private void BtnStartInstall_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This will open the Recovery Settings to reset or repair your PC. Continue?",
                "Confirm Recovery Launch",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    Process.Start("ms-settings:recovery");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open Recovery Settings:\n" + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
