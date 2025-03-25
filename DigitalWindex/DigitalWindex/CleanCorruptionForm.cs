using System;
using System.Windows.Forms;
using System.Threading.Tasks;
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
            // Additional initialization logic if needed
        }

        private void BtnRunCleanup_Click(object sender, EventArgs e)
        {
            // Call the DISM cleanup function
            _ = SFC_DISM.RunDISMCleanup();
        }
    }
}
