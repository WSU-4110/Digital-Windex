using NUnit.Framework;
using System.Windows.Forms;
using DesktopApp;
using System.Reflection;
using System.Reflection.Emit;

namespace DigitalWindexTests
{
    [TestFixture]
    public class UpdatesControlTests
    {
        [Test]
        public void UpdatesControl_ShouldInitialize()
        {
            var updatesControl = new UpdatesControl();
            updatesControl.CreateControl();
            Assert.IsNotNull(updatesControl);
        }

        [Test]
        public void TitleLabel_ShouldContainCorrectText()
        {
            var control = new UpdatesControl();
            control.CreateControl();
            var title = GetPrivateField<System.Windows.Forms.Label>(control, "lblTitle");
            Assert.AreEqual("System Updates", title.Text);
        }

        [Test]
        public void DescriptionLabel_ShouldContainCorrectText()
        {
            var control = new UpdatesControl();
            control.CreateControl();
            var desc = GetPrivateField<System.Windows.Forms.Label>(control, "lblTitle");
            StringAssert.Contains("latest updates", desc.Text);
        }

        [Test]
        public void Layout_ShouldContainFourControls()
        {
            var control = new UpdatesControl();
            control.CreateControl();
            var layout = GetPrivateField<TableLayoutPanel>(control, "contentLayout");
            Assert.AreEqual(4, layout.Controls.Count);
        }

        [Test]
        public void SystemUpdatesButton_ShouldHaveCorrectText()
        {
            var control = new UpdatesControl();
            control.CreateControl();
            var button = GetPrivateField<Button>(control, "btnSystemUpdates");
            Assert.AreEqual("Check System Updates", button.Text);
        }

        [Test]
        public void DriverUpdatesButton_ShouldHaveCorrectText()
        {
            var control = new UpdatesControl();
            control.CreateControl();
            var button = GetPrivateField<Button>(control, "btnDriverUpdates");
            Assert.AreEqual("Check Driver Updates", button.Text);
        }

        // Helper to access private fields in Windows Forms
        private T GetPrivateField<T>(object obj, string fieldName) where T : class
        {
            var field = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            return field?.GetValue(obj) as T;
        }
    }
}
