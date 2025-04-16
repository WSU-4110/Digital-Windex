using Xunit;
using SystemDiagnostics;

namespace Digital_Windex_UI_Tests
{
    public class BackendTest_OutputCheck
    {
        [Fact]
        public void RunAllDiagnostics_Should_Return_NonEmptyOutput()
        {
            string result = DiagnosticRunner.RunAllDiagnostics();
            Assert.False(string.IsNullOrWhiteSpace(result));
        }
    }
}
