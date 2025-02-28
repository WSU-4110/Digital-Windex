namespace DesktopApp
{
    partial class InstallControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnStartInstall;

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
            this.btnStartInstall = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Install";

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(304, 149);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(380, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "(Installs necessary components for the system)...";

            // 
            // btnStartInstall
            // 
            this.btnStartInstall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartInstall.Location = new System.Drawing.Point(350, 250);
            this.btnStartInstall.Name = "btnStartInstall";
            this.btnStartInstall.Size = new System.Drawing.Size(220, 50);
            this.btnStartInstall.TabIndex = 2;
            this.btnStartInstall.Text = "Start Installation";
            this.btnStartInstall.UseVisualStyleBackColor = true;
            this.btnStartInstall.Click += new System.EventHandler(this.BtnStartInstall_Click);

            // 
            // InstallControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStartInstall);
            this.Name = "InstallControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.InstallControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
