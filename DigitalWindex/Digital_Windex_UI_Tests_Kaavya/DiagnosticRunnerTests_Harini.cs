using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDiagnostics;

namespace Digital_Windex_UI_Tests_Kaavya
{
    public class DiagnosticRunnerTests_Harini
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
