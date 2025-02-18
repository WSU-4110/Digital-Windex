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
            // Add initialization code for DiagnosticsControl here.
            this.Dock = DockStyle.Fill;  // Ensure it fills the panel.
        }
    }
}
