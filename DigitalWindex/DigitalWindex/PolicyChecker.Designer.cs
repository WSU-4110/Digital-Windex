using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    partial class PolicyCheckerControl
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblDescription;
        private Button btnCheckPolicies;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCheckPolicies = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1005, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Policy Checker";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(150, 120);
            this.lblDescription.MaximumSize = new System.Drawing.Size(800, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(797, 50);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Check your system policies to ensure that your system is secure. Policies may be changed due to malware or 3rd party access to your system.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // btnCheckPolicies
            this.btnCheckPolicies.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckPolicies.Location = new System.Drawing.Point(392, 210);
            this.btnCheckPolicies.Name = "btnCheckPolicies";
            this.btnCheckPolicies.Size = new System.Drawing.Size(220, 45);
            this.btnCheckPolicies.TabIndex = 2;
            this.btnCheckPolicies.Text = "Check Policies";
            this.btnCheckPolicies.UseVisualStyleBackColor = true;
            this.btnCheckPolicies.Click += new System.EventHandler(this.BtnCheckPolicies_Click);

            // PolicyCheckerControl
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCheckPolicies);
            this.Name = "PolicyCheckerControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.PolicyCheckerControl_Load);
            this.Resize += new System.EventHandler(this.PolicyCheckerControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
