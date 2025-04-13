using DigitalWindex.Backend;
using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class UpdatesControl : UserControl
    {
        public UpdatesControl()
        {
            InitializeComponent();
            this.Resize += UpdatesControl_Resize;
        }

        private void UpdatesControl_Load(object sender, EventArgs e)
        {
            // Optional: logic on load
        }

        private void BtnSystemUpdates_Click(object sender, EventArgs e)
        {
            //call SYSTEM_UPDATES function
            SystemUpdate.RunSystemUpdate();
        }

        private void BtnDriverUpdates_Click(object sender, EventArgs e)
        {          
            //call driver updates
            DriverUpdate.RunDriverUpdate();
        }

        private void UpdatesControl_Resize(object sender, EventArgs e)
        {
            // Ensure content stays centered (if not using full Dock)
            contentLayout.Left = (this.Width - contentLayout.Width) / 2;
            contentLayout.Top = (this.Height - contentLayout.Height) / 2;
        }

        private void UpdatesControl_Load_1(object sender, EventArgs e)
        {

        }

        private void contentLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
