using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        private Panel sidePanel, mainPanel;
        private Label lblTitle, lblWelcome, lblDescription;
        private Button button1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "My First Desktop Application";
            this.Size = new Size(900, 500);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            sidePanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 200,
                BackColor = Color.MediumPurple
            };
            Controls.Add(sidePanel);

            Button btnHome = CreateButton("Home", 0);
            Button btnDiagnostics = CreateButton("Diagnostics", 1);
            Button btnMalware = CreateButton("Malware", 2);
            Button btnInstall = CreateButton("Install", 3);
            Button btnClean = CreateButton("Clean Corruption", 4);
            Button btnUpdates = CreateButton("Updates", 5);
            Button btnDesignations = CreateButton("Designations", 6);

            sidePanel.Controls.AddRange(new Control[] { btnHome, btnDiagnostics, btnMalware, btnInstall, btnClean, btnUpdates, btnDesignations });

            mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Purple
            };
            Controls.Add(mainPanel);

            lblTitle = new Label
            {
                Text = "Digital Windex",
                ForeColor = Color.White,
                Font = new Font("Arial", 24, FontStyle.Bold),
                Location = new Point(300, 50),
                AutoSize = true
            };
            mainPanel.Controls.Add(lblTitle);

            lblWelcome = new Label
            {
                Text = "Hello (User’s name)!",
                ForeColor = Color.White,
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(350, 120),
                AutoSize = true
            };
            mainPanel.Controls.Add(lblWelcome);

            lblDescription = new Label
            {
                Text = "Simple Description .....",
                ForeColor = Color.White,
                Font = new Font("Arial", 12),
                Location = new Point(350, 180),
                AutoSize = true
            };
            mainPanel.Controls.Add(lblDescription);

            button1 = new Button
            {
                Text = "Click Me",
                Location = new Point(100, 100),
                Size = new Size(100, 40),
                BackColor = Color.White,
                ForeColor = Color.Black
            };
            button1.Click += Button1_Click;
            mainPanel.Controls.Add(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }

        private Button CreateButton(string text, int position)
        {
            return new Button
            {
                Text = text,
                Size = new Size(180, 40),
                Location = new Point(10, 20 + position * 50),
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.MediumPurple,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
        }
    }
}
