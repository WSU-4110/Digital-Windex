using System;
using System.IO;
using System.Windows.Forms;
using DigitalWindex.Backend;

namespace DesktopApp
{
    public partial class TempFilesControl : UserControl
    {
        public TempFilesControl()
        {
            InitializeComponent();
        }

        private void TempFilesControl_Load(object sender, EventArgs e)
        {
            // Optional: Additional initialization logic if needed
        }

        private void BtnCleanTempFiles_Click(object sender, EventArgs e)
        {
            string[] cleanupPaths = new string[]
            {
                Path.GetTempPath(),
                @"C:\Windows\Temp",
                @"C:\Windows\SoftwareDistribution\Download",
                @"C:\Windows\SoftwareDistribution\DeliveryOptimization",
                @"C:\ProgramData\Microsoft\Windows\WER",
                @"C:\Windows\Panther",
                @"C:\Windows\Logs",

                Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\AppData\Local\Microsoft\Windows\Explorer"),
                Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\AppData\Local\Microsoft\Windows\INetCache"),
                Environment.ExpandEnvironmentVariables(@"%LocalAppData%\D3DSCache"),
            };

            int totalFilesDeleted = 0;
            int totalDirsDeleted = 0;

            foreach (string path in cleanupPaths)
            {
                if (!Directory.Exists(path)) continue;

                CleanFolder(path, ref totalFilesDeleted, ref totalDirsDeleted);
            }

            MessageBox.Show(
                $"Cleanup complete!\n\nRemoved {totalFilesDeleted} files and {totalDirsDeleted} directories from various temp locations.",
                "Cleanup Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LOG.WriteLog();
        }

        /// <summary>
        /// Cleans all files and subdirectories in the given folder.
        /// Files/folders in use or without proper permissions will be skipped.
        /// </summary>
        private void CleanFolder(string folderPath, ref int fileCount, ref int dirCount)
        {
            try
            {
                // Delete all files in the folder
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    try
                    {
                        File.Delete(file);
                        fileCount++;
                    }
                    catch
                    {
                        // Ignore locked or access-denied files
                    }
                }

                // Delete all subdirectories
                foreach (string dir in Directory.GetDirectories(folderPath))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        dirCount++;
                    }
                    catch
                    {
                        // Ignore locked or access-denied directories
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cleaning {folderPath}: {ex.Message}");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
