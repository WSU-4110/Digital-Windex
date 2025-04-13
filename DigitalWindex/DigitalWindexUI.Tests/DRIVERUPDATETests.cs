using Moq;
using System.Diagnostics;
using Xunit;
using DigitalWindex.Backend;

namespace DigitalWindexUI.Tests
{

    [Collection("Tests Collection")]
    public class DRIVERUPDATETests
    {
        [Fact]
        public void RunSystemUpdate_CallsProcessStartWithCorrectArguments()
        {
            // Arrange
            var mockProcessRunner = new Mock<IProcessRunner>();
            DriverUpdate.SetProcessRunner(mockProcessRunner.Object); // Inject mock

            // Act
            DriverUpdate.RunDriverUpdate();

            // Assert
            mockProcessRunner.Verify(r => r.Start(It.Is<ProcessStartInfo>(p => p.FileName == "devmgmt.msc" && p.UseShellExecute == true && p.Verb == "open")), Times.Once);
        }
    }
}
