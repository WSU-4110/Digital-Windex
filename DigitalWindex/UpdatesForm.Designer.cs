namespace DigitalWindexUI
{
    partial class UpdatesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCheckUpdates;
        private System.Windows.Forms.Button btnInstallUpdates;

       
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
            // Create and configure the TableLayoutPanel
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.ColumnCount = 3;
            // Left and right columns for spacing (20% each) and center column for content (60%)
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));

            // Use 4 rows: title, description, and two buttons
            this.tableLayoutPanel1.RowCount = 4;
            // Title row auto-sizes, description row fills remaining space, buttons auto-size
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());

            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);

            // Title Label
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "System Updates";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Description Label
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            // Turn off AutoSize so it fills the cell
            this.lblDescription.AutoSize = false;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Text = "Welcome to the Updates section of Digital Windex!\n\n" +
                "This section allows you to check for the latest system updates and install them " +
                "to ensure your system is running smoothly and securely.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.Margin = new System.Windows.Forms.Padding(10);

            // Check for Updates Button
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.btnCheckUpdates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckUpdates.AutoSize = true;
            this.btnCheckUpdates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckUpdates.Text = "Check for Updates";
            this.btnCheckUpdates.UseVisualStyleBackColor = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.BtnCheckUpdates_Click);

            // Install Updates Button
            this.btnInstallUpdates = new System.Windows.Forms.Button();
            this.btnInstallUpdates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInstallUpdates.AutoSize = true;
            this.btnInstallUpdates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnInstallUpdates.Text = "Install Updates";
            this.btnInstallUpdates.UseVisualStyleBackColor = true;
            this.btnInstallUpdates.Click += new System.EventHandler(this.BtnInstallUpdates_Click);

            // Add controls to the TableLayoutPanel
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckUpdates, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInstallUpdates, 1, 3);

            // Configure the main control
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpdatesForm";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.UpdatesForm_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
