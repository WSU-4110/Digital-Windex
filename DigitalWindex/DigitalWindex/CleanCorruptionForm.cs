/*
 using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using DigitalWindex.Backend;

namespace DesktopApp
{
    public partial class CleanCorruptionForm : UserControl
    {
        private Label lblTitle;
        private Label lblDescription;
        private Button btnRunCleanup;

        public CleanCorruptionForm()
        {
            SetupUI();
        }

        private void SetupUI()
        {
            // Ensure Clean Corruption page matches the other pages (like Diagnostics)
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Purple; // Match the background of the diagnostics page

            // Title Label (Same Style as Diagnostics)
            lblTitle = new Label
            {
                Text = "Clean Corruption",
                ForeColor = Color.White,
                Font = new Font("Arial", 24, FontStyle.Bold),
                Location = new Point(50, 50),
                AutoSize = true
            };
            Controls.Add(lblTitle);

            // Description Label
            lblDescription = new Label
            {
                Text = "(Uses DISM to repair system corruption...)",
                ForeColor = Color.White,
                Font = new Font("Arial", 14, FontStyle.Italic),
                Location = new Point(50, 120), // Adjusted for alignment
                AutoSize = true
            };
            Controls.Add(lblDescription);

            // Run DISM Cleanup Button
            btnRunCleanup = new Button
            {
                Text = "Run DISM Cleanup",
                Location = new Point(50, 200), // Aligned properly
                Size = new Size(220, 50),
                BackColor = Color.White,
                ForeColor = Color.Black,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };

            // Preserve existing functionality
            btnRunCleanup.Click += async (s, ev) => await SFC_DISM.RunDISMCleanup();
            Controls.Add(btnRunCleanup);
        }

        private void CleanCorruptionForm_Load(object sender, EventArgs e)
        {
            // You can initialize any additional logic here if needed
        }

    }
}

*/

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
            // Any logic to initialize the form
        }

        private void BtnRunCleanup_Click(object sender, EventArgs e)
        {
            // Call the DISM cleanup function
            _ = SFC_DISM.RunDISMCleanup();
        }
    }
}
