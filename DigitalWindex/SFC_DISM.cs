using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindex.Backend
{
    public class SFC_DISM
    {
        public static async Task RunDISMCleanup()
        {
            DialogResult dialogResult = MessageBox.Show(
                "This will run a DISM scan and cleanup. Do you want to continue?",
                "System Repair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string dismPath = Path.Combine(Environment.SystemDirectory, "DISM.exe");
                    int dismExitCode = await RunCommandDirectly(dismPath, "/online /cleanup-image /scanhealth");

                    MessageBox.Show("DISM scan completed with exit code: " + dismExitCode,
                                    "Scan Completed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private static async Task<int> RunCommandDirectly(string fullFileName, string arguments)
        {
            return await Task.Run(() =>
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = fullFileName,
                    Arguments = arguments,
                    UseShellExecute = true,
                    Verb = "runas", 
                    WorkingDirectory = Environment.SystemDirectory,
                    CreateNoWindow = false  
                };

                int exitCode = -1;
                using (Process process = Process.Start(processInfo))
                {
                    process.WaitForExit();
                    exitCode = process.ExitCode;
                }
                return exitCode;
            });
        }
    }
}
