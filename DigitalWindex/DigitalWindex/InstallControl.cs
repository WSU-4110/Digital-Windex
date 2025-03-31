using System;
using System.Windows.Forms;
using DigitalWindex.Backend; // Make sure this matches your actual namespace

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
            // Optional: any initialization logic here
        }

        private void BtnStartInstall_Click(object sender, EventArgs e)
        {
            // When clicked, open the "System → Recovery" Settings page in Windows 11
            WindowsRecoveryLauncher.OpenRecoverySettings();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void tblOuter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDescription_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
