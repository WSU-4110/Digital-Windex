using Moq;
using System.Diagnostics;
using Xunit;
using DigitalWindex.Backend;

namespace DigitalWindexUI.Tests
{

    [Collection("Tests Collection")]
    public class SystemUpdateTests
    {
        [Fact]
        public void RunSystemUpdate_CallsProcessStartWithCorrectArguments()
        {
            // Arrange
            var mockProcessRunner = new Mock<IProcessRunner>();
            SystemUpdate.SetProcessRunner(mockProcessRunner.Object);

            //var mockLogger = new Mock<ILogger>();
            //SystemUpdate.SetLogger(mockLogger.Object);

            // Act
            SystemUpdate.RunSystemUpdate();

            // Assert
            mockProcessRunner.Verify(r => r.Start(It.Is<ProcessStartInfo>(p => p.FileName == "ms-settings:windowsupdate-action" && p.UseShellExecute == true && p.Verb == "open")), Times.Once);
        }
    }
}