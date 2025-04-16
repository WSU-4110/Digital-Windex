using Xunit;
using System;
using System.Linq;
using System.Windows.Forms;
using DesktopApp;

namespace Digital_Windex_UI_Tests
{
    public class FrontendTest_Home
    {
        [Fact]
        public void Clicking_Home_Adds_WelcomeLabels()
        {
            var form = new Form1();
            var method = form.GetType().GetMethod("HomeButton_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            var panel = form.Controls["mainPanel"] as Panel;
            Assert.NotNull(panel);

            var controls = panel.Controls.Cast<Control>(); // Fix here

            Assert.Contains(controls, c => c.Name == "lblWelcome");
            Assert.Contains(controls, c => c.Name == "lblDescription");
        }
    }
}
