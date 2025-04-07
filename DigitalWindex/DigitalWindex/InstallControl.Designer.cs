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
            this.contentLayout = new TableLayoutPanel();
            this.lblTitle = new Label();
            this.lblDescription = new Label();
            this.btnStartInstall = new Button();

            // 
            // contentLayout
            // 
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.RowCount = 3;
            this.contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.contentLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.contentLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.contentLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.contentLayout.Dock = DockStyle.Fill;
            this.contentLayout.Padding = new Padding(10);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.BackColor = Color.FromArgb(244, 246, 249); // Light background

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Century Gothic", 28F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(103, 80, 164);
            this.lblTitle.Text = "Install";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Anchor = AnchorStyles.None;
            this.lblTitle.Margin = new Padding(0, 30, 0, 20);

            // 
            // lblDescription
            // 
            this.lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            this.lblDescription.ForeColor = Color.FromArgb(108, 108, 108);
            this.lblDescription.Text = "You are currently in the Recovery section of Digital Windex!\n\nFrom here, you can open Windows' built-in Recovery Settings, where you have options to reset or repair your PC if it’s running poorly or experiencing serious issues. By choosing between keeping personal files or removing everything, you can address system corruption, restore performance, and essentially ‘start fresh’—all guided by Windows' straightforward wizard.\n\nWARNING: All of your user data and installed programs will be deleted if you choose to reset and remove everything!";
            this.lblDescription.MaximumSize = new Size(700, 0);
            this.lblDescription.AutoSize = true;
            this.lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            this.lblDescription.Anchor = AnchorStyles.None;
            this.lblDescription.Margin = new Padding(0, 0, 0, 30);

            // 
            // btnStartInstall
            // 
            this.btnStartInstall.Text = "Start Installation";
            this.btnStartInstall.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnStartInstall.Size = new Size(200, 45);
            this.btnStartInstall.Anchor = AnchorStyles.None;
            this.btnStartInstall.BackColor = Color.White;
            this.btnStartInstall.ForeColor = Color.Black;
            this.btnStartInstall.FlatStyle = FlatStyle.Flat;
            this.btnStartInstall.FlatAppearance.BorderSize = 1;
            this.btnStartInstall.FlatAppearance.BorderColor = Color.Gray;
            this.btnStartInstall.Click += new System.EventHandler(this.BtnStartInstall_Click);

            // 
            // Add controls
            // 
            this.contentLayout.Controls.Add(this.lblTitle, 0, 0);
            this.contentLayout.Controls.Add(this.lblDescription, 0, 1);
            this.contentLayout.Controls.Add(this.btnStartInstall, 0, 2);

            // 
            // InstallControl
            // 
            this.BackColor = Color.FromArgb(244, 246, 249);
            this.Controls.Add(this.contentLayout);
            this.Name = "InstallControl";
            this.Size = new Size(1005, 600);
            this.Load += new System.EventHandler(this.InstallControl_Load);
            
        }
    }
}
