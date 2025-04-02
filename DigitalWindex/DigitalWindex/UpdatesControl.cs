using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindexUI
{
    public partial class UpdatesControl : UserControl
    {
        public UpdatesControl()
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
