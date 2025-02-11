using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using DigitalWindex.Backend;

namespace DesktopApp
{
    public partial class CleanCorruptionForm : Form
    {
        private Button btnRunCleanup;
        private Label lblMessage;

        public CleanCorruptionForm()
        {
            InitializeComponent();
        }

        private void CleanCorruptionForm_Load(object sender, EventArgs e)
        {
            this.Text = "Clean Corruption";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.MediumPurple;

            lblMessage = new Label
            {
                Text = "This page will use DISM to repair system corruption.",
                ForeColor = Color.White,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(50, 50),
                AutoSize = true
            };
            Controls.Add(lblMessage);

            btnRunCleanup = new Button
            {
                Text = "Run DISM Cleanup",
                Location = new Point(200, 150),
                Size = new Size(200, 40),
                BackColor = Color.White,
                ForeColor = Color.Black
            };
            // When clicked, this button calls our DISM cleanup method.
            btnRunCleanup.Click += async (s, ev) => await SFC_DISM.RunDISMCleanup();
            Controls.Add(btnRunCleanup);
        }
    }
}
