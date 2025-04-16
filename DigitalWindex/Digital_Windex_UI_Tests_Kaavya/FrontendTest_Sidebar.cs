using Xunit;
using System.Windows.Forms;
using DesktopApp;

namespace Digital_Windex_UI_Tests
{
    public class FrontendTest_Sidebar
    {
        [Fact]
        public void Sidebar_Should_Have_7Buttons_WithExpectedText()
        {
            var form = new Form1();
            var sidePanel = form.Controls["sidePanel"] as Panel;
            Assert.NotNull(sidePanel);

            Assert.Equal(7, sidePanel.Controls.Count);
            string[] expected = { "Home", "Diagnostics", "Malware", "Install", "Clean Corruption", "Updates", "Temporary Files" };

            for (int i = 0; i < 7; i++)
            {
                var btn = sidePanel.Controls[i] as Button;
                Assert.Equal(expected[i], btn.Text);
            }
        }
    }
}
