using Xunit;
using System.Windows.Forms;
using DesktopApp;

namespace Digital_Windex_UI_Tests
{
    public class FrontendTest_Install
    {
        [Fact]
        public void Clicking_Install_Adds_InstallControl()
        {
            var form = new Form1();
            var method = form.GetType().GetMethod("InstallButton_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            var panel = form.Controls["mainPanel"] as Panel;
            Assert.NotNull(panel);
            Assert.Single(panel.Controls);
            Assert.IsType<InstallControl>(panel.Controls[0]);
        }
    }
}
