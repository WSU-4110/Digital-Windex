using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Windex_UI_Tests_Kaavya
{
    // ✅ Testable file cleaner class
    public class TempFileCleaner
    {
        public (int filesDeleted, int dirsDeleted) CleanFolder(string folderPath)
        {
            int fileCount = 0;
            int dirCount = 0;

            try
            {
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    try
                    {
                        File.Delete(file);
                        fileCount++;
                    }
                    catch { /* ignore errors */ }
                }

                foreach (string dir in Directory.GetDirectories(folderPath))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        dirCount++;
                    }
                    catch { /* ignore errors */ }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cleaning {folderPath}: {ex.Message}");
            }

            return (fileCount, dirCount);
        }
    }

    // ✅ Unit test for the cleaner
    public class TempFileCleanerTests
    {
        [Fact]
        public void CleanFolder_DeletesFilesAndDirectories()
        {
            // Arrange: Create test folder
            string testRoot = Path.Combine(Path.GetTempPath(), "TempTest_" + Guid.NewGuid());
            Directory.CreateDirectory(testRoot);

            string file1 = Path.Combine(testRoot, "file1.txt");
            File.WriteAllText(file1, "test");

            string subDir = Path.Combine(testRoot, "subDir");
            Directory.CreateDirectory(subDir);
            File.WriteAllText(Path.Combine(subDir, "nested.txt"), "nested");

            var cleaner = new TempFileCleaner();

            // Act
            var result = cleaner.CleanFolder(testRoot);

            // Assert
            Assert.Equal(1, result.filesDeleted);
            Assert.Equal(1, result.dirsDeleted);
            Assert.True(Directory.Exists(testRoot));
            Assert.Empty(Directory.GetFiles(testRoot));
            Assert.Empty(Directory.GetDirectories(testRoot));

            // Cleanup
            Directory.Delete(testRoot, true);
        }
    }
}
