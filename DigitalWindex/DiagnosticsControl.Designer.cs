namespace DesktopApp
{
    partial class DiagnosticsControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnRunDiagnostics; // Added Button

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnRunDiagnostics = new System.Windows.Forms.Button(); // Initialize Button
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Diagnostics";

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(304, 149);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(361, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "(Gives out what the actual problem is)...";

            // 
            // btnRunDiagnostics
            // 
            this.btnRunDiagnostics.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnRunDiagnostics.Location = new System.Drawing.Point(350, 250); // Positioned below description
            this.btnRunDiagnostics.Name = "btnRunDiagnostics";
            this.btnRunDiagnostics.Size = new System.Drawing.Size(220, 50);
            this.btnRunDiagnostics.TabIndex = 2;
            this.btnRunDiagnostics.Text = "Run Diagnostics";
            this.btnRunDiagnostics.UseVisualStyleBackColor = true;
            this.btnRunDiagnostics.Click += new System.EventHandler(this.BtnRunDiagnostics_Click);

            // 
            // DiagnosticsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRunDiagnostics); // Add button to the control
            this.Name = "DiagnosticsControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.DiagnosticsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
