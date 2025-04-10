using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DigitalWindexUI;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        Label dateTimeLabel;
        Panel separator;

        public Form1()
        {
            InitializeComponent();

            if (!IsInDesignMode())
            {
                CreateSidebarButtons();
                LoadHomePage();
                this.Resize += Form1_Resize;
            }
        }

        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Digital Windex";
            lblWelcome.Text = "Hello " + Environment.UserName + "!";
        }

        private void CreateSidebarButtons()
        {
            string[] buttonNames =
            {
                "Home", "Diagnostics", "Malware",
                "Install", "Clean Corruption", "Updates", "Temporary Files", "Log"
            };

            sideButtons = new Button[buttonNames.Length];

            for (int i = 0; i < buttonNames.Length; i++)
            {
                sideButtons[i] = new Button
                {
                    Text = buttonNames[i],
                    Size = new Size(180, 40),
                    Location = new Point(10, 20 + i * 50),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    BackColor = Color.FromArgb(103, 80, 164),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                sideButtons[i].FlatAppearance.BorderSize = 0;
                sideButtons[i].FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 100, 200);
                sideButtons[i].Cursor = Cursors.Hand;

                sideButtons[i].Click += SidebarButton_Click;
                sidePanel.Controls.Add(sideButtons[i]);
            }
        }

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            string section = clickedButton.Text;

            if (section == "Home")
            {
                LoadHomePage();
            }
            else
            {
                LoadPage(section);
            }
        }

        private void LoadHomePage()
        {
            mainPanel.Controls.Clear();

            // ===== TITLE =====
            lblTitle.Text = "Digital Windex";
            lblTitle.Font = new Font("Century Gothic", 36F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(103, 80, 164);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point((mainPanel.ClientSize.Width - lblTitle.PreferredWidth) / 2, 40);
            lblTitle.Visible = true;

            // ===== WELCOME =====
            lblWelcome.Text = $"Welcome, {Environment.UserName.ToLower()}!";
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Regular);
            lblWelcome.ForeColor = Color.FromArgb(45, 45, 45);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point((mainPanel.ClientSize.Width - lblWelcome.PreferredWidth) / 2, 100);
            lblWelcome.Visible = true;

            // ===== DESCRIPTION =====
            lblDescription.Text = "This dashboard allows you to maintain your PC in one click.\n" +
                                  "Use the panel on the left to get started with diagnostics, updates, and cleanup tools.";
            lblDescription.Font = new Font("Segoe UI", 11.5F, FontStyle.Italic);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.MaximumSize = new Size(mainPanel.ClientSize.Width - 100, 0);
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point((mainPanel.ClientSize.Width - lblDescription.PreferredWidth) / 2, 165);
            lblDescription.Visible = true;

            // ===== SEPARATOR =====
            separator = new Panel();
            separator.Height = 2;
            separator.Width = mainPanel.ClientSize.Width - 100;
            separator.BackColor = Color.FromArgb(200, 200, 200);
            separator.Location = new Point((mainPanel.ClientSize.Width - separator.Width) / 2, 245);

            // ===== DATE & TIME =====
            dateTimeLabel = new Label();
            dateTimeLabel.Text = $"🗓 {DateTime.Now:dddd, MMMM d, yyyy - h:mm tt}";
            dateTimeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dateTimeLabel.ForeColor = Color.Gray;
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new Point((mainPanel.ClientSize.Width - dateTimeLabel.PreferredWidth) / 2, 260);

            // ===== ADD TO PANEL =====
            mainPanel.Controls.Add(lblTitle);
            mainPanel.Controls.Add(lblWelcome);
            mainPanel.Controls.Add(lblDescription);
            mainPanel.Controls.Add(separator);
            mainPanel.Controls.Add(dateTimeLabel);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (lblTitle.Visible)
            {
                lblTitle.Left = (mainPanel.ClientSize.Width - lblTitle.PreferredWidth) / 2;
                lblWelcome.Left = (mainPanel.ClientSize.Width - lblWelcome.PreferredWidth) / 2;

                lblDescription.MaximumSize = new Size(mainPanel.ClientSize.Width - 100, 0);
                lblDescription.Left = (mainPanel.ClientSize.Width - lblDescription.PreferredWidth) / 2;

                if (separator != null)
                {
                    separator.Width = mainPanel.ClientSize.Width - 100;
                    separator.Left = (mainPanel.ClientSize.Width - separator.Width) / 2;
                }

                if (dateTimeLabel != null)
                {
                    dateTimeLabel.Left = (mainPanel.ClientSize.Width - dateTimeLabel.PreferredWidth) / 2;
                }
            }
        }

        private void LoadPage(string section)
        {
            mainPanel.Controls.Clear();
            UserControl controlToLoad = null;

            lblTitle.Visible = false;
            lblWelcome.Visible = false;
            lblDescription.Visible = false;

            switch (section)
            {
                case "Diagnostics":
                    controlToLoad = new DiagnosticsControl();
                    break;
                case "Malware":
                    controlToLoad = new MalwareControl();
                    break;
                case "Install":
                    controlToLoad = new InstallControl();
                    break;
                case "Clean Corruption":
                    controlToLoad = new CleanCorruptionForm();
                    break;
                case "Updates":
                    controlToLoad = new UpdatesControl();
                    break;
                case "Temporary Files":
                    controlToLoad = new TempFilesControl();
                    break;
                case "Log":
                    controlToLoad = new LogControl();
                    break;
                default:
                    MessageBox.Show("Unknown section: " + section);
                    break;
            }

            if (controlToLoad != null)
            {
                controlToLoad.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(controlToLoad);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional custom drawing
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Description clicked!");
        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
