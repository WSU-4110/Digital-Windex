using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DigitalWindexUI;
using DigitalWindexUI.Properties;

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
        "Install", "Clean Corruption", "Updates", "Temporary Files"
    };

            // Clear existing controls from the side panel
            sidePanel.Controls.Clear();
            sidePanel.BackColor = Color.FromArgb(30, 30, 50); // Optional: Match visual theme

            // === Add Logo ===
            PictureBox logoBox = new PictureBox
            {
                Image = Resources.logo_mini, // <- using embedded resource
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(180, 100),
                Location = new Point((sidePanel.Width - 180) / 2, 10),
                Margin = new Padding(0),
                Anchor = AnchorStyles.Top
            };
            sidePanel.Controls.Add(logoBox);

            // === Create TableLayoutPanel for Buttons ===
            TableLayoutPanel tablePanel = new TableLayoutPanel
            {
                Location = new Point(0, logoBox.Bottom + 10),
                Size = new Size(sidePanel.Width, sidePanel.Height - logoBox.Bottom - 20),
                RowCount = buttonNames.Length,
                ColumnCount = 1,
                Dock = DockStyle.None,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.Transparent
            };

            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            for (int i = 0; i < buttonNames.Length; i++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / buttonNames.Length));
            }

            foreach (string name in buttonNames)
            {
                Button btn = new Button
                {
                    Text = name,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    BackColor = Color.FromArgb(103, 80, 164),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(4, 4, 4, 4)
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 100, 200);
                btn.Cursor = Cursors.Hand;
                btn.Click += SidebarButton_Click;

                tablePanel.Controls.Add(btn);
            }

            sidePanel.Controls.Add(tablePanel);
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
