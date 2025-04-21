using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xunit;
using DigitalWindex.Backend;
using DigitalWindexUI;

namespace Digital_Windex_UI_Tests_Kaavya
{
    [Collection("Tests Collection")]
    public class DRIVERUPDATETests_Clara
    {
        [Fact]
        public void RunSystemUpdate_CallsProcessStartWithCorrectArguments()
        {
            // Arrange
            var mockProcessRunner = new Mock<DigitalWindex.Backend.IProcessRunner>();
            DriverUpdate.SetProcessRunner(mockProcessRunner.Object); // Inject mock

            // Act
            DriverUpdate.RunDriverUpdate();

            // Assert
            mockProcessRunner.Verify(r => r.Start(It.Is<ProcessStartInfo>(p => p.FileName == "devmgmt.msc" && p.UseShellExecute == true && p.Verb == "open")), Times.Once);
        }
    }
}
