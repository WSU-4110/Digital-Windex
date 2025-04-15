namespace DesktopApp
{
    partial class DiagnosticsControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnRunDiagnostics;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnRunDiagnostics = new System.Windows.Forms.Button();

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(103, 80, 164);
            this.lblTitle.Text = "Diagnostics";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(400, 40); // Initial, gets adjusted on resize
            this.lblTitle.Name = "lblTitle";

            // 
            // lblDescription
            // 
            // lblDescription
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Text = "You are in the diagnostics section of Digital Windex. \nRun system diagnostics to detect any underlying issues. This helps ensure your PC is operating smoothly.";
            this.lblDescription.AutoSize = true;
            this.lblDescription.MaximumSize = new System.Drawing.Size(800, 0); // <-- this enables word wrap
            this.lblDescription.Location = new System.Drawing.Point(150, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            // 
            // btnRunDiagnostics
            // 
            this.btnRunDiagnostics.Text = "Run Diagnostics";
            this.btnRunDiagnostics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRunDiagnostics.Size = new System.Drawing.Size(180, 40);
            this.btnRunDiagnostics.Location = new System.Drawing.Point(400, 200);
            this.btnRunDiagnostics.Name = "btnRunDiagnostics";
            this.btnRunDiagnostics.Click += new System.EventHandler(this.BtnRunDiagnostics_Click);

            // 
            // DiagnosticsControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnRunDiagnostics);
            this.Name = "DiagnosticsControl";
            this.Size = new System.Drawing.Size(1005, 600);
        }
    }
}
