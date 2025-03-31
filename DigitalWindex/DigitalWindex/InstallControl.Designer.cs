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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnStartInstall = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStartInstall, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(216, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(573, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Install";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click_1);
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.BackColor = Color.FromArgb(60, 0, 0, 0); // semi-transparent background
            this.lblDescription.Padding = new System.Windows.Forms.Padding(20);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click_1);
            // 
            // btnStartInstall
            // 
            this.btnStartInstall.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartInstall.AutoSize = true;
            this.btnStartInstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartInstall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartInstall.Location = new System.Drawing.Point(415, 534);
            this.btnStartInstall.Margin = new System.Windows.Forms.Padding(0, 10, 0, 40);
            this.btnStartInstall.Name = "btnStartInstall";
            this.btnStartInstall.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnStartInstall.Size = new System.Drawing.Size(175, 44);
            this.btnStartInstall.TabIndex = 2;
            this.btnStartInstall.Text = "Start Installation";
            this.btnStartInstall.UseVisualStyleBackColor = true;
            this.btnStartInstall.Click += new System.EventHandler(this.BtnStartInstall_Click);
            // 
            // InstallControl
            // 
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InstallControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.InstallControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
