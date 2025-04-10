using DigitalWindex.Backend;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class LogControl : UserControl
    {

        public LogControl()
        {
            InitializeComponent();
            // Layout is handled by TableLayoutPanel, no manual centering needed
        }

        private void LogControl_Load(object sender, EventArgs e)
        {
            // Optional: initialization logic if needed
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            // When clicked, open the "System → Recovery" Settings page in Windows 11
            if (LOG.LogFileExists() == false)
            {
                LOG.CreateLog();
            }
            else
            {
                LOG.OpenLog();
            }

        }

        private void contentLayout_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
