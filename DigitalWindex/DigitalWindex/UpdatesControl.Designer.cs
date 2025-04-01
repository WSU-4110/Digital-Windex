/*
namespace DigitalWindexUI
{
    partial class UpdatesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UpdatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UpdatesForm";
            this.Load += new System.EventHandler(this.UpdatesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
*/

using System.Windows.Forms;

namespace DigitalWindexUI
{
    partial class UpdatesControl
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private Label lblDescription;
        private Button btnCheckUpdates;
        private Button btnInstallUpdates;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.btnInstallUpdates = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.btnCheckUpdates, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInstallUpdates, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 600);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.lblTitle.Text = "Updates";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(60, 0, 0, 0);
            this.lblDescription.Padding = new System.Windows.Forms.Padding(20);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "Check for the latest system updates and install them to keep your PC secure and stable.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckUpdates.AutoSize = true;
            this.btnCheckUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckUpdates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckUpdates.Location = new System.Drawing.Point(410, 450);
            this.btnCheckUpdates.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnCheckUpdates.Size = new System.Drawing.Size(185, 44);
            this.btnCheckUpdates.TabIndex = 1;
            this.btnCheckUpdates.Text = "Check for Updates";
            this.btnCheckUpdates.UseVisualStyleBackColor = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.BtnCheckUpdates_Click);
            // 
            // btnInstallUpdates
            // 
            this.btnInstallUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInstallUpdates.AutoSize = true;
            this.btnInstallUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInstallUpdates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnInstallUpdates.Location = new System.Drawing.Point(420, 514);
            this.btnInstallUpdates.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.btnInstallUpdates.Name = "btnInstallUpdates";
            this.btnInstallUpdates.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnInstallUpdates.Size = new System.Drawing.Size(165, 44);
            this.btnInstallUpdates.TabIndex = 2;
            this.btnInstallUpdates.Text = "Install Updates";
            this.btnInstallUpdates.UseVisualStyleBackColor = true;
            this.btnInstallUpdates.Click += new System.EventHandler(this.BtnInstallUpdates_Click);
            // 
            // UpdatesControl
            // 
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpdatesControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.Load += new System.EventHandler(this.UpdatesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
