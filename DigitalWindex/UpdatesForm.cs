using System;
using System.Windows.Forms;

namespace DigitalWindexUI
{
    public partial class UpdatesForm : UserControl
    {
        public UpdatesForm()
        {
            InitializeComponent();
        }

        private void UpdatesForm_Load(object sender, EventArgs e)
        {
            // Optional: Code to run when the form loads
        }

        private void BtnCheckUpdates_Click(object sender, EventArgs e)
        {
            // Logic for checking updates
            MessageBox.Show("Checking for updates...", "Updates");
        }

        private void BtnInstallUpdates_Click(object sender, EventArgs e)
        {
            // Logic for installing updates
            MessageBox.Show("Installing updates...", "Updates");
        }
    }
}
