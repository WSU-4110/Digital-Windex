/*
 namespace DesktopApp
{
    partial class CleanCorruptionForm
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CleanCorruptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Name = "CleanCorruptionForm";
            this.Text = "Clean Corruption";
            this.Load += new System.EventHandler(this.CleanCorruptionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
*/

namespace DesktopApp
{
    partial class CleanCorruptionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnRunCleanup;

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
            this.btnRunCleanup = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Clean Corruption";

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(304, 149);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(350, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "(Uses DISM to repair system corruption...)";

            // 
            // btnRunCleanup
            // 
            this.btnRunCleanup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnRunCleanup.Location = new System.Drawing.Point(350, 250);
            this.btnRunCleanup.Name = "btnRunCleanup";
            this.btnRunCleanup.Size = new System.Drawing.Size(220, 50);
            this.btnRunCleanup.TabIndex = 2;
            this.btnRunCleanup.Text = "Run DISM Cleanup";
            this.btnRunCleanup.UseVisualStyleBackColor = true;
            this.btnRunCleanup.Click += new System.EventHandler(this.BtnRunCleanup_Click);

            // 
            // CleanCorruptionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRunCleanup);
            this.Name = "CleanCorruptionForm";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.CleanCorruptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
