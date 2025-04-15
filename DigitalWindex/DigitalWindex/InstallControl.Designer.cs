using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    partial class InstallControl
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel contentLayout;
        private Label lblTitle;
        private Label lblDescription;
        private Button btnStartInstall;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallControl));
            this.contentLayout = new TableLayoutPanel();
            this.lblTitle = new Label();
            this.lblDescription = new Label();
            this.btnStartInstall = new Button();
            this.contentLayout.SuspendLayout();
            this.SuspendLayout();

            // contentLayout
            this.contentLayout.BackColor = Color.FromArgb(244, 246, 249);
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.contentLayout.Controls.Add(this.lblTitle, 0, 0);
            this.contentLayout.Controls.Add(this.lblDescription, 0, 1);
            this.contentLayout.Controls.Add(this.btnStartInstall, 0, 2);
            this.contentLayout.Dock = DockStyle.Fill;
            this.contentLayout.Location = new Point(0, 0);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.Padding = new Padding(10);
            this.contentLayout.RowCount = 3;
            this.contentLayout.RowStyles.Add(new RowStyle());
            this.contentLayout.RowStyles.Add(new RowStyle());
            this.contentLayout.RowStyles.Add(new RowStyle());
            this.contentLayout.Size = new Size(1005, 600);
            this.contentLayout.TabIndex = 0;

            // lblTitle
            this.lblTitle.Anchor = AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Century Gothic", 28F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(103, 80, 164);
            this.lblTitle.Margin = new Padding(0, 30, 0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Install";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblDescription
            this.lblDescription.Anchor = AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            this.lblDescription.ForeColor = Color.FromArgb(108, 108, 108);
            this.lblDescription.MaximumSize = new Size(700, 0);
            this.lblDescription.Margin = new Padding(0, 0, 0, 30);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.TextAlign = ContentAlignment.MiddleCenter;

            // btnStartInstall
            this.btnStartInstall.Anchor = AnchorStyles.None;
            this.btnStartInstall.AutoSize = true;
            this.btnStartInstall.Name = "btnStartInstall";
            this.btnStartInstall.Text = "Start Installation";
            this.btnStartInstall.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnStartInstall.BackColor = Color.FromArgb(103, 80, 164);
            this.btnStartInstall.ForeColor = Color.White;
            this.btnStartInstall.FlatStyle = FlatStyle.Flat;
            this.btnStartInstall.FlatAppearance.BorderSize = 0;
            this.btnStartInstall.UseVisualStyleBackColor = false;
            this.btnStartInstall.Padding = new Padding(20, 10, 20, 10);
            this.btnStartInstall.Click += new EventHandler(this.BtnStartInstall_Click);

            // InstallControl
            this.BackColor = Color.FromArgb(244, 246, 249);
            this.Controls.Add(this.contentLayout);
            this.Name = "InstallControl";
            this.Size = new Size(1005, 600);
            this.Load += new EventHandler(this.InstallControl_Load);
            this.contentLayout.ResumeLayout(false);
            this.contentLayout.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
