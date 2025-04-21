using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Windex_UI_Tests_Kaavya
{
    public class ServicesTests
    {
        // ── TempFilesCleaner ──

        [Fact]
        public void Clean_EmptyFolder_ReturnsZeroCounts()
        {
            var temp = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(temp);

            var cleaner = new TempFilesCleaner();
            var (f, d) = cleaner.Clean(temp);

            Assert.Equal(0, f);
            Assert.Equal(0, d);
        }

        [Fact]
        public void Clean_FolderWithStuff_DeletesAndCounts()
        {
            var temp = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(temp);
            File.WriteAllText(Path.Combine(temp, "x.txt"), "x");
            Directory.CreateDirectory(Path.Combine(temp, "sub"));
            File.WriteAllText(Path.Combine(temp, "sub", "y.txt"), "y");

            var cleaner = new TempFilesCleaner();
            var (f, d) = cleaner.Clean(temp);

            Assert.Equal(1, f);
            Assert.Equal(1, d);
        }

        // ── MalwareScanner ──

        [Fact]
        public void Scan_ExecutableMissing_ReturnsNotFound()
        {
            var runner = Mock.Of<IProcessRunner_Angelo>();
            var scanner = new MalwareScanner(runner);

            var result = scanner.Scan("C:\\nonexistent");

            Assert.Equal(ScanResult.NotFound, result);
        }

        [Fact]
        public void Scan_ExecutableExists_NonZeroExit_ReturnsWarning()
        {
            var mock = new Mock<IProcessRunner_Angelo>();
            mock.Setup(m => m.Run(It.IsAny<string>(), "")).ReturnsAsync(7);

            // make a fake path with the exe
            var basePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(Path.Combine(basePath, "McAfeeStingerPortable"));
            File.WriteAllText(Path.Combine(basePath, "McAfeeStingerPortable", "McAfeeStingerPortable.exe"), "");

            var scanner = new MalwareScanner(mock.Object);
            var result = scanner.Scan(basePath);

            Assert.Equal(ScanResult.Warning, result);
        }

        [Fact]
        public void Scan_ExecutableExists_ZeroExit_ReturnsSuccess()
        {
            var mock = new Mock<IProcessRunner_Angelo>();
            mock.Setup(m => m.Run(It.IsAny<string>(), "")).ReturnsAsync(0);

            var basePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(Path.Combine(basePath, "McAfeeStingerPortable"));
            File.WriteAllText(Path.Combine(basePath, "McAfeeStingerPortable", "McAfeeStingerPortable.exe"), "");

            var scanner = new MalwareScanner(mock.Object);
            var result = scanner.Scan(basePath);

            Assert.Equal(ScanResult.Success, result);
        }

        // ── WindowsRecoveryService ──

        [Fact]
        public async Task LaunchRecoveryAsync_CallsRunnerWithCorrectArgs()
        {
            var mock = new Mock<IProcessRunner_Angelo>();
            mock.Setup(m => m.Run("ms-settings:recovery", "")).ReturnsAsync(0);

            var svc = new WindowsRecoveryService_Angelo(mock.Object);
            await svc.LaunchRecoveryAsync();

            mock.Verify(m => m.Run("ms-settings:recovery", ""), Times.Once);
        }
    }

}
