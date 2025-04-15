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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallControl));
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.contentLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentLayout
            // 
            this.contentLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayout.Controls.Add(this.lblTitle, 0, 0);
            this.contentLayout.Controls.Add(this.lblDescription, 0, 1);
            this.contentLayout.Controls.Add(this.btnLog, 0, 2);
            this.contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayout.Location = new System.Drawing.Point(0, 0);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.Padding = new System.Windows.Forms.Padding(10);
            this.contentLayout.RowCount = 3;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayout.Size = new System.Drawing.Size(1005, 600);
            this.contentLayout.TabIndex = 0;
            this.contentLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.contentLayout_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.lblTitle.Location = new System.Drawing.Point(426, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 30, 0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Log";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lblDescription.Location = new System.Drawing.Point(152, 116);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.lblDescription.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(700, 250);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "You are currently in the log section of Digital Windex. \n Here, you can be taken to " +
                "a log of Digital Windex tools you ran. The log includes what tool you used, including time and date!";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartInstall
            // 
            this.btnLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLog.BackColor = System.Drawing.Color.White;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Location = new System.Drawing.Point(402, 470);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(200, 45);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Open Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // InstallControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.contentLayout);
            this.Name = "LogControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.LogControl_Load);
            this.contentLayout.ResumeLayout(false);
            this.contentLayout.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
