using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWindex.Backend;
using Moq;
using System.Diagnostics;

namespace DigitalWindexUI.Tests
{

    [Collection("Tests Collection")]
    public class LOGTests
    {

        private static readonly string logFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
            "DigitalWindexLog.txt"
        );

        //Create Log
        [Fact]
        public void CreateLogCreatesPredeterminedLog()
        {
            if (File.Exists(logFilePath)) File.Delete(logFilePath);

            // Act
            LOG.CreateLog();

            // Assert
            Assert.True(File.Exists(logFilePath));

            // Cleanup
            File.Delete(logFilePath);
        
        }

        //Open Log
        [Fact]
        public void OpenLogOpensTheLog()
        {
            // Arrange
            var mockProcessRunner = new Mock<IProcessRunner>();
            LOG.SetProcessRunner(mockProcessRunner.Object); // Inject mock

            // Act
            LOG.OpenLog();

            // Assert
            mockProcessRunner.Verify(r => r.Start(It.Is<ProcessStartInfo>(p => p.FileName == "notepad.exe" && p.Arguments == logFilePath && p.UseShellExecute == true)), Times.Once);
        }


        //Write Log
        [Fact]
        public void WriteLogWritesToTheLogFromDriverAndSystemUpdate()
        {
            // Arrange
            DriverUpdate.RunDriverUpdate();
            SystemUpdate.RunSystemUpdate();

            var lines = File.ReadAllLines(logFilePath);
            Assert.True(lines.Length >= 2, "Expected at least 2 log lines.");

            var secondToLastLine = lines[lines.Length-2];
            var lastLine = lines[lines.Length - 1];

            Console.WriteLine(secondToLastLine);
            Console.WriteLine(lastLine);

            Assert.Contains("Ran Driver Update Function", secondToLastLine);
            Assert.Contains("Ran System Update Function", lastLine);
        }

        [Fact]
        public void LogFileExists_ReturnsTrue_WhenFileExists()
        {
            // Arrange
            File.WriteAllText(logFilePath, "Log data");

            // Act
            var result = LOG.LogFileExists();

            // Cleanup
            File.Delete(logFilePath);

            // Assert
            Assert.True(result);
        }


    }
}
