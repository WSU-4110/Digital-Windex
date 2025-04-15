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
            this.btnSystemUpdates = new Button();

            this.contentLayout.SuspendLayout();
            this.SuspendLayout();

            // contentLayout
            this.contentLayout.Anchor = AnchorStyles.None;
            this.contentLayout.AutoSize = true;
            this.contentLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.contentLayout.Location = new Point(0, 0);
            this.contentLayout.Margin = new Padding(0, 50, 0, 0);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.Padding = new Padding(10);
            this.contentLayout.RowCount = 3;
            this.contentLayout.RowStyles.Add(new RowStyle());
            this.contentLayout.RowStyles.Add(new RowStyle());
            this.contentLayout.RowStyles.Add(new RowStyle());

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Font = new Font("Century Gothic", 28F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(103, 80, 164);
            this.lblTitle.Margin = new Padding(0, 30, 0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(460, 44);
            this.lblTitle.Text = "System Updates";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = DockStyle.Fill;
            this.lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            this.lblDescription.ForeColor = Color.Gray;
            this.lblDescription.MaximumSize = new Size(700, 0);
            this.lblDescription.Margin = new Padding(0, 0, 0, 30);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(460, 20);
            this.lblDescription.Text = "Check for the latest updates to keep your system secure and up to date.";
            this.lblDescription.TextAlign = ContentAlignment.MiddleCenter;

            // btnSystemUpdates
            this.btnSystemUpdates = new Button();
            this.btnSystemUpdates.Anchor = AnchorStyles.Top;
            this.btnSystemUpdates.AutoSize = true;
            this.btnSystemUpdates.Font = new Font("Arial", 12F, FontStyle.Bold);
            this.btnSystemUpdates.Padding = new Padding(20, 10, 20, 10);
            this.btnSystemUpdates.Name = "btnSystemUpdates";
            this.btnSystemUpdates.Text = "Check System Updates";
            this.btnSystemUpdates.BackColor = Color.FromArgb(103, 80, 164);
            this.btnSystemUpdates.ForeColor = Color.White;
            this.btnSystemUpdates.FlatStyle = FlatStyle.Flat;
            this.btnSystemUpdates.FlatAppearance.BorderSize = 0;
            this.btnSystemUpdates.UseVisualStyleBackColor = false;
            this.btnSystemUpdates.Click += new System.EventHandler(this.BtnSystemUpdates_Click);

            // Add controls to layout
            this.contentLayout.Controls.Add(this.lblTitle, 0, 0);
            this.contentLayout.Controls.Add(this.lblDescription, 0, 1);
            this.contentLayout.Controls.Add(this.btnSystemUpdates, 0, 2);

            // UpdatesControl
            this.BackColor = Color.FromArgb(244, 246, 249);
            this.Controls.Add(this.contentLayout);
            this.Name = "UpdatesControl";
            this.Size = new Size(1005, 600);
            this.Load += new System.EventHandler(this.UpdatesControl_Load_1);

            this.contentLayout.ResumeLayout(false);
            this.contentLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
