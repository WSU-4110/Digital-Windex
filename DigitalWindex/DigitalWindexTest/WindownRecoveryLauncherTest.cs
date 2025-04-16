using System;
using Xunit;
using Moq;

namespace DigitalWindexTest
{
    // Mockable interface for launching system URIs
    public interface IProcessLauncher
    {
        void Launch(string uri);
    }

    // Testable recovery launcher that uses IProcessLauncher
    public class WindowsRecoveryLauncherTestable
    {
        private readonly IProcessLauncher _launcher;

        public WindowsRecoveryLauncherTestable(IProcessLauncher launcher)
        {
            _launcher = launcher;
        }

        public void OpenRecoverySettings()
        {
            _launcher.Launch("ms-settings:recovery");
        }
    }

    // Unit test using Moq
    public class WindowsRecoveryLauncherTests
    {
        [Fact]
        public void OpenRecoverySettings_CallsLauncherWithCorrectUri()
        {
            // Arrange
            var mockLauncher = new Mock<IProcessLauncher>();
            var recoveryLauncher = new WindowsRecoveryLauncherTestable(mockLauncher.Object);

            // Act
            recoveryLauncher.OpenRecoverySettings();

            // Assert
            mockLauncher.Verify(p => p.Launch("ms-settings:recovery"), Times.Once);
        }
    }
}
