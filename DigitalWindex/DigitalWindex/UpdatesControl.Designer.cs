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
        private Button btnSystemUpdates;
        private Button btnDriverUpdates;

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
            this.btnSystemUpdates = new System.Windows.Forms.Button();
            this.btnDriverUpdates = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.btnSystemUpdates, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDriverUpdates, 1, 3);
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
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(213, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(579, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Updates";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(213, 106);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(20);
            this.lblDescription.Size = new System.Drawing.Size(579, 286);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Check for the latest system updates and install them to keep your PC secure and s" +
    "table.";
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
