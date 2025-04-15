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
        private Button btnSystemUpdates;
        private Button btnDriverUpdates;

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

            this.btnSystemUpdates = new System.Windows.Forms.Button();
            this.btnDriverUpdates = new System.Windows.Forms.Button();
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

            this.contentLayout.Controls.Add(this.btnSystemUpdates, 0, 2);
            this.contentLayout.Controls.Add(this.btnDriverUpdates, 0, 2);
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

            // renamed the buttons because its system updates and driver updates - Clara
            // 
            this.btnSystemUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSystemUpdates.AutoSize = true;
            this.btnSystemUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSystemUpdates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSystemUpdates.Location = new System.Drawing.Point(384, 422);
            this.btnSystemUpdates.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnSystemUpdates.Name = "btnSystemUpdates";
            this.btnSystemUpdates.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnSystemUpdates.Size = new System.Drawing.Size(236, 54);
            this.btnSystemUpdates.TabIndex = 1;
            this.btnSystemUpdates.Text = "Check for System Updates";
            this.btnSystemUpdates.UseVisualStyleBackColor = true;
            this.btnSystemUpdates.Click += new System.EventHandler(this.BtnSystemUpdates_Click);
            // 
            // btnInstallUpdates
            // 
            this.btnDriverUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDriverUpdates.AutoSize = true;
            this.btnDriverUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDriverUpdates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDriverUpdates.Location = new System.Drawing.Point(402, 486);
            this.btnDriverUpdates.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.btnDriverUpdates.Name = "btnDriverUpdates";
            this.btnDriverUpdates.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnDriverUpdates.Size = new System.Drawing.Size(200, 54);
            this.btnDriverUpdates.TabIndex = 2;
            this.btnDriverUpdates.Text = "Check for Driver Updates";
            this.btnDriverUpdates.UseVisualStyleBackColor = true;
            this.btnDriverUpdates.Click += new System.EventHandler(this.BtnDriverUpdates_Click);
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
