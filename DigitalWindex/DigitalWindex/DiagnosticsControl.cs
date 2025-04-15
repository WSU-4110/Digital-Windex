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
            this.Resize += DiagnosticsControl_Resize;
        }

        private void DiagnosticsControl_Resize(object sender, EventArgs e)
        {
            // Wrap the description text
            lblDescription.MaximumSize = new System.Drawing.Size(this.Width - 100, 0);
            lblDescription.Left = (this.Width - lblDescription.Width) / 2;

            // Center title and button
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            btnRunDiagnostics.Left = (this.Width - btnRunDiagnostics.Width) / 2;
        }

        private void BtnRunDiagnostics_Click(object sender, EventArgs e)
        {
            try
            {
                string result = DiagnosticRunner.RunAllDiagnostics();
                MessageBox.Show(result, "System Diagnostics Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error running diagnostics: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiagnosticsControl_Load(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
