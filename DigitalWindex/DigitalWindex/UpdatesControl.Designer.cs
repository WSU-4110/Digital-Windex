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
            this.contentLayout = new TableLayoutPanel();
            this.lblTitle = new Label();
            this.lblDescription = new Label();
            this.btnCheckUpdates = new Button();
            this.SuspendLayout();

            // 
            // contentLayout
            
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.RowCount = 3;
            this.contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.contentLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.contentLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.contentLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.contentLayout.Dock = DockStyle.None; // Important: switch from Fill to None so it respects margin/position
            this.contentLayout.Padding = new Padding(10);
            this.contentLayout.Margin = new Padding(0, 50, 0, 0); // Add space from top
            this.contentLayout.Anchor = AnchorStyles.Top;
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.Size = new Size(1005, 600);


            // Center everything in the layout
            this.contentLayout.Anchor = AnchorStyles.None;
            this.contentLayout.AutoSize = true;
            this.contentLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //
            // lblTitle
            //
            this.lblTitle.Text = "System Updates";
            this.lblTitle.Font = new Font("Century Gothic", 28F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(103, 80, 164);
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.AutoSize = true;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Margin = new Padding(0, 30, 0, 20);

            //
            // lblDescription
            //
            this.lblDescription.Text = "Check for the latest updates to keep your system secure and up to date.";
            this.lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            this.lblDescription.ForeColor = Color.Gray;
            this.lblDescription.MaximumSize = new Size(700, 0); // Wrap at 700px width
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = DockStyle.Fill;
            this.lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            this.lblDescription.Margin = new Padding(0, 0, 0, 30);

            //
            // btnCheckUpdates
            //
            this.btnCheckUpdates.Text = "Check for Updates";
            this.btnCheckUpdates.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCheckUpdates.BackColor = Color.White;
            this.btnCheckUpdates.ForeColor = Color.Black;
            this.btnCheckUpdates.FlatStyle = FlatStyle.Flat;
            this.btnCheckUpdates.FlatAppearance.BorderSize = 1;
            this.btnCheckUpdates.FlatAppearance.BorderColor = Color.Gray;
            this.btnCheckUpdates.Anchor = AnchorStyles.None;
            this.btnCheckUpdates.AutoSize = true;
            this.btnCheckUpdates.Padding = new Padding(20, 10, 20, 10);
            this.btnCheckUpdates.Click += new System.EventHandler(this.BtnCheckUpdates_Click);

            //
            // Add to layout
            //
            this.contentLayout.Controls.Add(this.lblTitle, 0, 0);
            this.contentLayout.Controls.Add(this.lblDescription, 0, 1);
            this.contentLayout.Controls.Add(this.btnCheckUpdates, 0, 2);

            //
            // UpdatesControl
            //
            this.BackColor = Color.FromArgb(244, 246, 249); // Match all modern pages
            this.Controls.Add(this.contentLayout);
            this.Name = "UpdatesControl";
            this.Size = new Size(1005, 600);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
