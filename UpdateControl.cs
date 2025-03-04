using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using DigitalWindex.Backend;

namespace DesktopApp
{
    public partial class UpdateControl : UserControl
    {
        public UpdateControl()
        {
            InitializeComponent();
        }

        private void UpdateControl_Load(object sender, EventArgs e)
        {
            // Additional initialization logic if needed
        }

        private void BtnRunSystemUpdate_Click(object sender, EventArgs e)
        {
            // Call the system update function
            _ = SYSTEM_UPDATE.RunSystemUpdate();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
