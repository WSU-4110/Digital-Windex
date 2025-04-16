using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moq;
using Xunit;

namespace DigitalWindexTest
{
    // ✅ Mockable interface
    public interface ICorruptionCleaner
    {
        Task RunCleanupAsync();
    }

    // ✅ Testable version of the form
    public class CleanCorruptionFormTestable : UserControl
    {
        private readonly ICorruptionCleaner _cleaner;
        public Button BtnRunCleanup { get; } = new Button();

        public CleanCorruptionFormTestable(ICorruptionCleaner cleaner)
        {
            _cleaner = cleaner;

            BtnRunCleanup.Text = "Run Cleanup";
            BtnRunCleanup.Click += BtnRunCleanup_Click;

            Controls.Add(BtnRunCleanup);
        }

        private void BtnRunCleanup_Click(object sender, EventArgs e)
        {
            _ = _cleaner.RunCleanupAsync();
        }
    }

    // ✅ The unit test itself
    public class CleanCorruptionFormTests
    {
        [Fact]
        public void BtnRunCleanup_Click_CallsRunCleanupAsync()
        {
            // Arrange
            var mockCleaner = new Mock<ICorruptionCleaner>();
            mockCleaner.Setup(c => c.RunCleanupAsync()).Returns(Task.CompletedTask);

            var form = new CleanCorruptionFormTestable(mockCleaner.Object);

            // Act
            form.BtnRunCleanup.PerformClick();

            // Assert
            mockCleaner.Verify(c => c.RunCleanupAsync(), Times.Once);
        }
    }
}
