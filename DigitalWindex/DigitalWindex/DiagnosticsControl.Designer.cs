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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticsControl));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnRunDiagnostics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.lblTitle.Location = new System.Drawing.Point(400, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Diagnostics";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(150, 120);
            this.lblDescription.MaximumSize = new System.Drawing.Size(800, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(781, 150);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // btnRunDiagnostics
            // 
            this.btnRunDiagnostics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRunDiagnostics.Location = new System.Drawing.Point(449, 361);
            this.btnRunDiagnostics.Name = "btnRunDiagnostics";
            this.btnRunDiagnostics.Size = new System.Drawing.Size(180, 40);
            this.btnRunDiagnostics.TabIndex = 2;
            this.btnRunDiagnostics.Text = "Run Diagnostics";
            this.btnRunDiagnostics.Click += new System.EventHandler(this.BtnRunDiagnostics_Click);
            // 
            // DiagnosticsControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnRunDiagnostics);
            this.Name = "DiagnosticsControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.DiagnosticsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
