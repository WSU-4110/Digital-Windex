using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    partial class UpdatesControl
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel contentLayout;
        private Label lblTitle;
        private Label lblDescription;
        private Button btnCheckUpdates;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.contentLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentLayout
            // 
            this.contentLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentLayout.AutoSize = true;
            this.contentLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayout.Controls.Add(this.lblTitle, 0, 0);
            this.contentLayout.Controls.Add(this.lblDescription, 0, 1);
            this.contentLayout.Controls.Add(this.btnCheckUpdates, 0, 2);
            this.contentLayout.Location = new System.Drawing.Point(0, 0);
            this.contentLayout.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.Padding = new System.Windows.Forms.Padding(10);
            this.contentLayout.RowCount = 3;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayout.Size = new System.Drawing.Size(608, 244);
            this.contentLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.lblTitle.Location = new System.Drawing.Point(10, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 30, 0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(588, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Updates";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblDescription.Location = new System.Drawing.Point(10, 116);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.lblDescription.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(588, 25);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Check for the latest updates to keep your system secure and up to date.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckUpdates.AutoSize = true;
            this.btnCheckUpdates.BackColor = System.Drawing.Color.White;
            this.btnCheckUpdates.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCheckUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUpdates.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheckUpdates.ForeColor = System.Drawing.Color.Black;
            this.btnCheckUpdates.Location = new System.Drawing.Point(190, 174);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnCheckUpdates.Size = new System.Drawing.Size(227, 57);
            this.btnCheckUpdates.TabIndex = 2;
            this.btnCheckUpdates.Text = "Check for Updates";
            this.btnCheckUpdates.UseVisualStyleBackColor = false;
            this.btnCheckUpdates.Click += new System.EventHandler(this.BtnCheckUpdates_Click);
            // 
            // UpdatesControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.contentLayout);
            this.Name = "UpdatesControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.UpdatesControl_Load_1);
            this.contentLayout.ResumeLayout(false);
            this.contentLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
