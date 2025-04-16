using System;
using System.IO;
using System.Threading.Tasks;
using Moq;
using Xunit;
using DigitalWindex.Services; 

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
        var runner = Mock.Of<IProcessRunner>();
        var scanner = new MalwareScanner(runner);

        var result = scanner.Scan("C:\\nonexistent");

        Assert.Equal(ScanResult.NotFound, result);
    }

    [Fact]
    public void Scan_ExecutableExists_NonZeroExit_ReturnsWarning()
    {
        var mock = new Mock<IProcessRunner>();
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
        var mock = new Mock<IProcessRunner>();
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
        var mock = new Mock<IProcessRunner>();
        mock.Setup(m => m.Run("ms-settings:recovery", "")).ReturnsAsync(0);

        var svc = new WindowsRecoveryService(mock.Object);
        await svc.LaunchRecoveryAsync();

        mock.Verify(m => m.Run("ms-settings:recovery", ""), Times.Once);
    }
}
