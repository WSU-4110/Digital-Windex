using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindex.Backend
{
    public class DRIVER_UPDATE
    {
        public static async Task RunDriverUpdate()
        {
            DialogResult dialogResult = MessageBox.Show(
                "This will redirect you to the Device Manager. Do you want to continue?",
                "Redirection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string driverUpdatePath = Path.Combine(Environment.SystemDirectory, "powershell.exe");
                    int driverUpdateExitCode = await RunCommandDirectly(driverUpdatePath, "devmgmt.msc");

                    MessageBox.Show("redirection completed with exit code: " + driverUpdateExitCode,
                                    "Redirection Completed",
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
