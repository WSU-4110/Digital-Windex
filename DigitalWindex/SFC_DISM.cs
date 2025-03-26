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
<<<<<<< HEAD
                    int dismExitCode = await RunCommandDirectly(dismPath, "/online /cleanup-image /scanhealth");
=======
                    int dismExitCode = await RunCommandDirectly(dismPath, "/online /cleanup-image /restorehealth");
>>>>>>> 53b18beb34e8d117601a4f04d3a905a7bd5ddc5e

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
<<<<<<< HEAD
                    Verb = "runas",
                    WorkingDirectory = Environment.SystemDirectory,
                    CreateNoWindow = false
=======
                    Verb = "runas", 
                    WorkingDirectory = Environment.SystemDirectory,
                    CreateNoWindow = false  
>>>>>>> 53b18beb34e8d117601a4f04d3a905a7bd5ddc5e
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
