using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class CleanCorruptionForm : Form
    {
        public CleanCorruptionForm()
        {
            InitializeComponent();
        }

        private void CleanCorruptionForm_Load(object sender, EventArgs e)
        {
            this.Text = "Clean Corruption";
            this.Size = new System.Drawing.Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.MediumPurple;

            Label lblMessage = new Label
            {
                Text = "This page will contain tools to repair system corruption.",
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(50, 50),
                AutoSize = true
            };
            Controls.Add(lblMessage);
        }
    }
}
