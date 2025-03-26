using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DigitalWindexUI;

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
                LoadHomePage();
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
                "Install", "Clean Corruption", "Updates", "Temporary Files"
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

                if (buttonNames[i] == "Home")
                {
                    sideButtons[i].Click += HomeButton_Click;
                }
                else if (buttonNames[i] == "Diagnostics")
                {
                    sideButtons[i].Click += DiagnosticsButton_Click;
                }
                else if (buttonNames[i] == "Malware")
                {
                    sideButtons[i].Click += MalwareButton_Click;
                }
                else if (buttonNames[i] == "Install")
                {
                    sideButtons[i].Click += InstallButton_Click;
                }
                else if (buttonNames[i] == "Clean Corruption")
                {
                    sideButtons[i].Click += CleanCorruptionButton_Click;
                }
                else if (buttonNames[i] == "Temporary Files")
                {
                    sideButtons[i].Click += TemporaryFilesButton_Click;
                }
                else if (buttonNames[i] == "Updates")  // ✅ Connected the Updates Button
                {
                    sideButtons[i].Click += UpdatesButton_Click;
                }

                this.sidePanel.Controls.Add(sideButtons[i]);
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LoadHomePage(); // Restore the default Form1 layout when clicking Home
            mainPanel.Controls.Add(lblTitle);
            mainPanel.Controls.Add(lblWelcome);
            mainPanel.Controls.Add(lblDescription);
        }

        private void LoadHomePage()
        {
            mainPanel.Controls.Clear(); // Clear existing content
            mainPanel.Controls.Add(lblTitle);
            mainPanel.Controls.Add(lblWelcome);
            mainPanel.Controls.Add(lblDescription);
        }

        private void DiagnosticsButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            DiagnosticsControl diagnosticsControl = new DiagnosticsControl();
            diagnosticsControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(diagnosticsControl);
        }

        private void MalwareButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            MalwareControl malwareControl = new MalwareControl();
            malwareControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(malwareControl);
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            InstallControl installControl = new InstallControl();
            installControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(installControl);
        }

        private void CleanCorruptionButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            CleanCorruptionForm cleanControl = new CleanCorruptionForm();
            cleanControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(cleanControl);
        }

        private void TemporaryFilesButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TempFilesControl tempFilesControl = new TempFilesControl();
            tempFilesControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(tempFilesControl);
        }

        
        private void UpdatesButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UpdatesForm updatesControl = new UpdatesForm();
            updatesControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(updatesControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Digital Windex";
            this.lblWelcome.Text = "Hello " + Environment.UserName + "!";
            LoadHomePage();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Description clicked!");
        }
    }
}
