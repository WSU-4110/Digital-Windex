using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    partial class InstallControl
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private Label lblDescription;
        private Button btnStartInstall;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Create and configure TableLayoutPanel
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.tableLayoutPanel1.ColumnCount = 3;
            // Left and right columns for spacing (20% each) and center column for content (60%)
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            // Use 3 rows: title, description, and button
            this.tableLayoutPanel1.RowCount = 3;
            // Title row auto-sizes, description row fills remaining space, and button row auto-sizes
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());

            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Padding = new Padding(20);

            // Title Label
            this.lblTitle = new Label();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Text = "Install";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new EventHandler(this.lblTitle_Click_1);

            // Description Label
            this.lblDescription = new Label();
            this.lblDescription.Dock = DockStyle.Fill;
            // Turn off AutoSize so it fills the cell
            this.lblDescription.AutoSize = false;
            this.lblDescription.Font = new Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = Color.White;
            this.lblDescription.Text = "Welcome to the installation section of Digital Windex! \n\n" +
                "This section is useful for two main reasons:" +
                "\n- If you want to start fresh on your PC by wiping all of your current user data and programs" +
                "\n- If the corruption on your PC is too severe to be fixed by DISM (Clean Corruption)" +
                "\n\nKeep my files reset: Use if you want to fix severe OS corruption without losing your data" +
                "\nRemove everything reset: Use if you want to start fresh or if you already tried a keep my files reset " +
                "to fix OS corruption to no avail." +
                "\n\nThese are the only two options on Windows 10. However, if you are on Windows 11, you will see more " +
                "options for fixing corruption: \n- Fix problems without resetting your PC \n- Fix problems using Windows Update\n\n" +
                "You can use these extra two options for fixing corruption on your PC." ;
            this.lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            this.lblDescription.Margin = new Padding(10);
            this.lblDescription.Click += new EventHandler(this.lblDescription_Click_1);

            // Start Install Button
            this.btnStartInstall = new Button();
            this.btnStartInstall.Anchor = AnchorStyles.None;
            this.btnStartInstall.AutoSize = true;
            this.btnStartInstall.Font = new Font("Arial", 12F, FontStyle.Bold);
            this.btnStartInstall.Text = "Start Installation";
            this.btnStartInstall.UseVisualStyleBackColor = true;
            this.btnStartInstall.Click += new EventHandler(this.BtnStartInstall_Click);

            // Add controls to the TableLayoutPanel
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStartInstall, 1, 2);

            // Configure the main control
            this.BackColor = Color.Purple;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InstallControl";
            this.Size = new Size(1005, 600);
            this.Load += new EventHandler(this.InstallControl_Load);
        }

        #endregion
    }
}
