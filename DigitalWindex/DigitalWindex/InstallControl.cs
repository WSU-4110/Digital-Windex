using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class InstallControl : UserControl
    {
        public InstallControl()
        {
            InitializeComponent();
        }

        private void InstallControl_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization logic here
        }

        private void BtnStartInstall_Click(object sender, EventArgs e)
        {
            // Action when "Start Installation" button is clicked
            MessageBox.Show("Installation process started...", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
