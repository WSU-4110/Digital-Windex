/*
using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class DiagnosticsControl : UserControl
    {
        public DiagnosticsControl()
        {
            InitializeComponent();
        }

        private void DiagnosticsControl_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization logic here
        }

        private void BtnRunDiagnostics_Click(object sender, EventArgs e)
        {
            // Action when "Run Diagnostics" button is clicked
            MessageBox.Show("Diagnostics process started...", "System Diagnostics", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
*/

using System;
using System.Windows.Forms;
using SystemDiagnostics; // Import the namespace where the DiagnosticRunner class is defined

namespace DesktopApp
{
    public partial class DiagnosticsControl : UserControl
    {
        public DiagnosticsControl()
        {
            InitializeComponent();
        }

        private void DiagnosticsControl_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization logic here
        }

        private void BtnRunDiagnostics_Click(object sender, EventArgs e)
        {
            try
            {
                // Run diagnostics when button is clicked
                DiagnosticRunner.RunAllDiagnostics();

                MessageBox.Show("Diagnostics process started. Check console output or logs for details.",
                    "System Diagnostics", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error running diagnostics: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
