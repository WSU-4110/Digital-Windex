using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moq;
using Xunit;

namespace DigitalWindexTest
{
    // Interfaces for mocking
    public interface IMessageBoxService
    {
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
        void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool isError);
    }

    public interface IProcessRunner
    {
        Task<int> RunAsync(string fileName, string arguments);
    }

    // Testable version of the DISM runner
    public class TestableSFC_DISM
    {
        private readonly IMessageBoxService _msgBox;
        private readonly IProcessRunner _processRunner;

        public TestableSFC_DISM(IMessageBoxService msgBox, IProcessRunner processRunner)
        {
            _msgBox = msgBox;
            _processRunner = processRunner;
        }

        public async Task RunDISMCleanup()
        {
            var result = _msgBox.Show(
                "This will run a DISM scan and cleanup. Do you want to continue?",
                "System Repair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string dismPath = Path.Combine(Environment.SystemDirectory, "DISM.exe");
                    int exitCode = await _processRunner.RunAsync(dismPath, "/online /cleanup-image /scanhealth");

                    _msgBox.Show("DISM scan completed with exit code: " + exitCode,
                                 "Scan Completed",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 false);
                }
                catch (Exception ex)
                {
                    _msgBox.Show($"An error occurred: {ex.Message}",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error,
                                 true);
                }
            }
        }
    }

    public class SFCDISMTests
    {
        [Fact]
        public async Task RunDISMCleanup_UserClicksYes_ShouldRunDISMAndShowExitMessage()
        {
            // Arrange
            var mockMsgBox = new Mock<IMessageBoxService>();
            var mockProcessRunner = new Mock<IProcessRunner>();

            mockMsgBox.Setup(m => m.Show(
                It.IsAny<string>(),
                It.IsAny<string>(),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning))
                .Returns(DialogResult.Yes);

            mockProcessRunner.Setup(p => p.RunAsync(It.IsAny<string>(), It.IsAny<string>()))
                             .ReturnsAsync(0);

            var dism = new TestableSFC_DISM(mockMsgBox.Object, mockProcessRunner.Object);

            // Act
            await dism.RunDISMCleanup();

            // Assert
            mockProcessRunner.Verify(p => p.RunAsync(
                It.Is<string>(s => s.EndsWith("DISM.exe")),
                "/online /cleanup-image /scanhealth"), Times.Once);

            mockMsgBox.Verify(m => m.Show(
                It.Is<string>(s => s.Contains("DISM scan completed")),
                "Scan Completed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                false), Times.Once);
        }
    }
}
