using SystemDiagnostics;
using Xunit;

namespace DigitalWindexTest
{
    public class DiagnosticRunnerTests
    {
        [Fact]
        public void RunAllDiagnostics_ShouldReturnOutput()
        {
            // Act
            string result = DiagnosticRunner.RunAllDiagnostics();

            // Assert
            Assert.False(string.IsNullOrWhiteSpace(result));
            Assert.DoesNotContain("An error occurred while executing diagnostics", result);
        }
    }
}