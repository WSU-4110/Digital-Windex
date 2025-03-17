using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindex.Backend
{
    public static class SYSTEM_UPDATE
    {

        public static void RunSystemUpdate()
        {
            ProcessStartInfo psiSystemUpdate = new ProcessStartInfo("ms-settings:windowsupdate-action")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(psiSystemUpdate);
        }

        //public static async Task RunSystemUpdate()
        //{
        //    DialogResult dialogResult = MessageBox.Show(
        //        "This will redirect you to the Windows Update settings. Do you want to continue?",
        //        "Redirection",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Warning);
        //
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            string sysUpdatePath = Path.Combine(Environment.SystemDirectory, "cmd.exe");
        //            int sysUpdateExitCode = await RunCommandDirectly(sysUpdatePath, "start ms-settings:windowsupdate-action");
        //
        //            MessageBox.Show("redirection completed with exit code: " + sysUpdateExitCode,
        //                            "Redirection Completed",
        //                            MessageBoxButtons.OK,
        //                            MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"An error occurred: {ex.Message}",
        //                            "Error",
        //                            MessageBoxButtons.OK,
        //                            MessageBoxIcon.Error);
        //        }
        //    }
        //}
        //
        //private static async Task<int> RunCommandDirectly(string fullFileName, string arguments)
        //{
        //    return await Task.Run(() =>
        //    {
        //        ProcessStartInfo processInfo = new ProcessStartInfo
        //        {
        //            FileName = fullFileName,
        //            Arguments = arguments,
        //            UseShellExecute = true,
        //            Verb = "runas",
        //            WorkingDirectory = Environment.SystemDirectory,
        //            CreateNoWindow = false
        //        };
        //
        //        int exitCode = -1;
        //        using (Process process = Process.Start(processInfo))
        //        {
        //            process.WaitForExit();
        //            exitCode = process.ExitCode;
        //        }
        //        return exitCode;
        //    });
        //}
    }
}
