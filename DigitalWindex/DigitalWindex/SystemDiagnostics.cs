using System;
using System.Diagnostics;
using System.IO;

namespace SystemDiagnostics
{
    public static class DiagnosticRunner
    {
        public static string RunAllDiagnostics()
        {
            string script = @"
$drives = Get-WmiObject -Class Win32_DiskDrive | Select-Object Model, Status
$cpu = Get-WmiObject -Class Win32_Processor | Select-Object Name, Status

Write-Output '=== Disk Drive SMART Status ==='
foreach ($d in $drives) {
    Write-Output ('Model: ' + $d.Model)
    Write-Output ('Status: ' + $d.Status)
    Write-Output ''
}

Write-Output '=== CPU Information ==='
foreach ($c in $cpu) {
    Write-Output ('Name: ' + $c.Name)
    Write-Output ('Status: ' + $c.Status)
}
";

            // Option 1: Unique temp file (safer for parallel runs)
            string tempScriptPath = Path.Combine(Path.GetTempPath(), $"smartcheck_{Guid.NewGuid()}.ps1");

            try
            {
                File.WriteAllText(tempScriptPath, script);

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-ExecutionPolicy Bypass -NoProfile -File \"{tempScriptPath}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    return output;
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred while executing diagnostics: {ex.Message}";
            }
            finally
            {
                // Clean up the script file
                try
                {
                    if (File.Exists(tempScriptPath))
                        File.Delete(tempScriptPath);
                }
                catch { /* ignore delete error */ }
            }
        }
    }
}
