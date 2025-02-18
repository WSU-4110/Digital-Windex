using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!IsInDesignMode())
            {
                CreateSidebarButtons();
            }
        }

        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        private void CreateSidebarButtons()
        {
            string[] buttonNames =
            {
                "Home", "Diagnostics", "Malware",
                "Install", "Clean Corruption", "Updates", "Designations"
            };

            sideButtons = new Button[buttonNames.Length];

            for (int i = 0; i < buttonNames.Length; i++)
            {
                sideButtons[i] = new Button
                {
                    Text = buttonNames[i],
                    Size = new Size(180, 40),
                    Location = new Point(10, 20 + i * 50),
                    Font = new Font("Arial", 12F, FontStyle.Bold),
                    BackColor = Color.MediumPurple,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                if (buttonNames[i] == "Diagnostics")
                {
                    sideButtons[i].Click += DiagnosticsButton_Click;
                }
                else if (buttonNames[i] == "Clean Corruption")
                {
                    sideButtons[i].Click += CleanCorruptionButton_Click;
                }

                this.sidePanel.Controls.Add(sideButtons[i]);
            }
        }

        private void DiagnosticsButton_Click(object sender, EventArgs e)
        {
            // Clear existing controls in mainPanel
            mainPanel.Controls.Clear();

            // Create and load the DiagnosticsControl
            DiagnosticsControl diagnosticsControl = new DiagnosticsControl();
            diagnosticsControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(diagnosticsControl);
        }

        private void CleanCorruptionButton_Click(object sender, EventArgs e)
        {
            CleanCorruptionForm cleanForm = new CleanCorruptionForm();
            cleanForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Digital Windex";
            this.lblWelcome.Text = "Hello " + Environment.UserName + "!";
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom painting logic here if needed
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Description clicked!");
        }

    }
}
