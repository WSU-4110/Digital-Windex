using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Windows.Forms;
using DigitalWindex.Backend;
using System.Drawing;

namespace DesktopApp
{
    public partial class PolicyCheckerControl : UserControl
    {
        public PolicyCheckerControl()
        {
            InitializeComponent();
            this.Resize += new EventHandler(this.PolicyCheckerControl_Resize);
        }

        private void PolicyCheckerControl_Resize(object sender, EventArgs e)
        {
            int maxWidth = this.Width - 100;

            lblDescription.MaximumSize = new Size(maxWidth, 0);
            lblDescription.Left = (this.Width - lblDescription.Width) / 2;

            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            btnCheckPolicies.Left = (this.Width - btnCheckPolicies.Width) / 2;
        }

        private void PolicyCheckerControl_Load(object sender, EventArgs e)
        {
            // Optional: Additional initialization logic if needed
        }

        private void BtnCheckPolicies_Click(object sender, EventArgs e)
        {
            List<Policy> defaultPolicies = new List<Policy>
            {
                new Policy(@"Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoControlPanel", 0),
                new Policy(@"Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", 0),
                new Policy(@"Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoRun", 0),
                new Policy(@"Software\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 0)
            };

            int issuesFound = 0;

            foreach (var policy in defaultPolicies)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(policy.Path, false))
                {
                    if (key != null)
                    {
                        var value = key.GetValue(policy.Name);
                        if (value != null && !value.Equals(policy.ExpectedValue))
                        {
                            issuesFound++;
                        }
                    }
                }
            }

            MessageBox.Show(
                issuesFound == 0
                    ? "All policies are configured correctly."
                    : $"Detected {issuesFound} modified policy(ies).",
                "Policy Check Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LOG.WriteLog();
        }

        public class Policy
        {
            public string Path { get; set; }
            public string Name { get; set; }
            public object ExpectedValue { get; set; }

            public Policy(string path, string name, object expectedValue)
            {
                Path = path;
                Name = name;
                ExpectedValue = expectedValue;
            }
        }
    }
}
