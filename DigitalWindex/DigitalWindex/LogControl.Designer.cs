using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    partial class LogControl
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel contentLayout;
        private Label lblTitle;
        private Label lblDescription;
        private Button btnLog;

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
            this.btnLog = new Button();
            this.contentLayout.SuspendLayout();
            this.SuspendLayout();

            // contentLayout
            this.contentLayout.BackColor = Color.FromArgb(244, 246, 249);
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.contentLayout.Controls.Add(this.lblTitle, 0, 0);
            this.contentLayout.Controls.Add(this.lblDescription, 0, 1);
            this.contentLayout.Controls.Add(this.btnLog, 0, 2);
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
            this.lblTitle.Text = "Log";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblDescription
            this.lblDescription.Anchor = AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            this.lblDescription.ForeColor = Color.FromArgb(108, 108, 108);
            this.lblDescription.MaximumSize = new Size(700, 0);
            this.lblDescription.Margin = new Padding(0, 0, 0, 30);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "You are currently in the log section of Digital Windex. \nHere, you can be taken to a log of Digital Windex tools you ran. The log includes what tool you used, including time and date!";
            this.lblDescription.TextAlign = ContentAlignment.MiddleCenter;

            // btnLog
            this.btnLog.Anchor = AnchorStyles.None;
            this.btnLog.AutoSize = true;
            this.btnLog.Name = "btnLog";
            this.btnLog.Text = "Open Log";
            this.btnLog.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnLog.BackColor = Color.FromArgb(103, 80, 164);
            this.btnLog.ForeColor = Color.White;
            this.btnLog.FlatStyle = FlatStyle.Flat;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Padding = new Padding(20, 10, 20, 10);
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);

            // LogControl
            this.BackColor = Color.FromArgb(244, 246, 249);
            this.Controls.Add(this.contentLayout);
            this.Name = "LogControl";
            this.Size = new Size(1005, 600);
            this.Load += new System.EventHandler(this.LogControl_Load);
            this.contentLayout.ResumeLayout(false);
            this.contentLayout.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
