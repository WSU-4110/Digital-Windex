using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeUI();
        }

        public void CustomizeUI()
        {
            this.Text = "Digital Windex";
            this.BackColor = System.Drawing.Color.FromArgb(45, 0, 51);
            this.Size = new System.Drawing.Size(800, 450);

            //Sidebar Panel
            Panel panelSidebar = new Panel();
            panelSidebar.Size = new System.Drawing.Size(200, this.Height);
            panelSidebar.BackColor = System.Drawing.Color.FromArgb(107, 78, 118);
            panelSidebar.Dock = DockStyle.Left;
            this.Controls.Add(panelSidebar);

            //Sidebar button
            string[] menuItems = { "Home", "Diagnostics", "Malware", "Install", "Clean Corruption", "Updates", "Designations" };
            int yPos = 50;
            foreach (string item in menuItems)
            {
                Button btn = new Button();
                btn.Text = item;
                btn.ForeColor = System.Drawing.Color.White;
                btn.BackColor = item == "Home" ? System.Drawing.Color.FromArgb(125, 90, 144) : System.Drawing.Color.Transparent;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Width = 180;
                btn.Height = 30;
                btn.Location = new System.Drawing.Point(10, yPos);
                btn.Click += new EventHandler(MenuButton_Click);
                panelSidebar.Controls.Add(btn);
                yPos += 40;
            }
            // Main Content Panel
            Panel panelMain = new Panel();
            panelMain.Size = new System.Drawing.Size(600, this.Height);
            panelMain.BackColor = System.Drawing.Color.FromArgb(45, 0, 51);
            panelMain.Location = new System.Drawing.Point(200, 0);
            this.Controls.Add(panelMain);
            // Title Label
            Label lblTitle = new Label();
            lblTitle.Text = "Digital  Windex";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(150, 50);
            panelMain.Controls.Add(lblTitle);

            // Welcome Message
            Label lblWelcome = new Label();
            lblWelcome.Text = "Hello (User's name)!";
            lblWelcome.ForeColor = System.Drawing.Color.White;
            lblWelcome.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(180, 120);
            panelMain.Controls.Add(lblWelcome);

            // Simple Description
            Label lblDescription = new Label();
            lblDescription.Text = "Simple Description .....";
            lblDescription.ForeColor = System.Drawing.Color.White;
            lblDescription.Font = new System.Drawing.Font("Arial", 10);
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(190, 160);
            panelMain.Controls.Add(lblDescription);
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show("You clicked: " + clickedButton.Text);
        }

    }
}


