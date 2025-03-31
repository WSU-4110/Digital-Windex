using System;
using System.Windows.Forms;
using SystemDiagnostics;

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
            // Optional: Initialization logic upon loading the control
        }

        private void BtnRunDiagnostics_Click(object sender, EventArgs e)
        {
            try
            {
                string result = DiagnosticRunner.RunAllDiagnostics();

                MessageBox.Show(result,
                    "System Diagnostics Output",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error running diagnostics: " + ex.Message,
                    "Execution Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
