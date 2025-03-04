namespace DesktopApp
{
    partial class CleanCorruptionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnRunCleanup;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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

            // Use 3 rows: title, description, and button
            this.tableLayoutPanel1.RowCount = 3;
            // Title row auto-sizes, description row fills remaining space, and button row auto-sizes
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());

            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);

            // Title Label
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Clean Corruption";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Description Label
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            // Turn off AutoSize so it fills the cell
            this.lblDescription.AutoSize = false;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Text = "Welcome to the Clean Corruption section of Digital Windex!\n\n" +
                "This section uses DISM to scan and repair system corruption. \n\n" +
                "A comprehensive DISM scan and cleanup will attempt to repair your system files and restore stability.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.Margin = new System.Windows.Forms.Padding(10);

            // Run DISM Cleanup Button
            this.btnRunCleanup = new System.Windows.Forms.Button();
            this.btnRunCleanup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRunCleanup.AutoSize = true;
            this.btnRunCleanup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnRunCleanup.Text = "Run DISM Cleanup";
            this.btnRunCleanup.UseVisualStyleBackColor = true;
            this.btnRunCleanup.Click += new System.EventHandler(this.BtnRunCleanup_Click);

            // Add controls to the TableLayoutPanel
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRunCleanup, 1, 2);

            // Configure the main control
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CleanCorruptionForm";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.CleanCorruptionForm_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
