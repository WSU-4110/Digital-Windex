using System;
using System.Windows.Forms;
using DigitalWindex.Backend;

namespace DesktopApp
{
    public partial class CleanCorruptionForm : UserControl
    {
        public CleanCorruptionForm()
        {
            InitializeComponent();
        }

        private void CleanCorruptionForm_Load(object sender, EventArgs e)
        {
            // Optional: Additional setup when the form loads
        }

        private void BtnRunCleanup_Click(object sender, EventArgs e)
        {
            // Disable the button while DISM runs
            btnRunCleanup.Enabled = false;
            btnRunCleanup.Text = "Running...";

            try
            {
                // Trigger the cleanup process
                _ = SFC_DISM.RunDISMCleanup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attempting to run DISM cleanup:\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRunCleanup.Enabled = true;
                btnRunCleanup.Text = "Run DISM Cleanup";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: for custom UI painting, if needed
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
