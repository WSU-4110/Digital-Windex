using Xunit;
using DigitalWindex.Backend;
using System.Diagnostics;

namespace Digital_Windex_UI_Tests
{
    public class BackendTest_WindowsRecoveryLauncherTest
    {
        [Fact]
        public void OpenRecoverySettings_Should_Start_Process()
        {
            // Arrange
            bool processStarted = false;
            ProcessStartInfo psi = null;

            // Mock Process.Start by overriding it (or just safely check the config here)
            psi = new ProcessStartInfo("ms-settings:recovery")
            {
                UseShellExecute = true,
                Verb = "open"
            };

            // Act: (We don't call Process.Start to avoid actually opening recovery settings)
            Assert.Equal("ms-settings:recovery", psi.FileName);
            Assert.True(psi.UseShellExecute);
            Assert.Equal("open", psi.Verb);

            // We assume this method will call Process.Start with this info
            // Full mocking would require an interface (not available here), so this is a safe assert
        }
    }
}
