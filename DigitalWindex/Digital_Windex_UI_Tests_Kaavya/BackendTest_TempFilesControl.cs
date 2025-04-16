using Xunit;
using System.IO;
using DesktopApp;
using System.Windows.Forms;

namespace Digital_Windex_UI_Tests
{
    public class BackendTest_TempFilesControl
    {
        [Fact]
        public void BtnCleanTempFiles_Should_Delete_TempFiles()
        {
            // Arrange: Create a fake temp file
            string tempDir = Path.GetTempPath();
            string testFile = Path.Combine(tempDir, "dummy_temp_test.txt");
            File.WriteAllText(testFile, "test");

            var control = new TempFilesControl();
            var method = control.GetType().GetMethod("BtnCleanTempFiles_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            // Act: Invoke the cleanup method
            method.Invoke(control, new object[] { null, System.EventArgs.Empty });

            // Assert: Check the file was deleted
            Assert.False(File.Exists(testFile));
        }
    }
}
