using System;
using System.IO;
using System.Windows.Forms;

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
            try
            {
                string tempPath = Path.GetTempPath();
                int fileCount = 0;
                int dirCount = 0;
                foreach (string file in Directory.GetFiles(tempPath))
                {
                    try
                    {
                        File.Delete(file);
                        fileCount++;
                    }
                    catch { /* Ignore files in use or access denied errors */ }
                }

                foreach (string dir in Directory.GetDirectories(tempPath))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        dirCount++;
                    }
                    catch { /* Ignore directories in use or access denied errors */ }
                }

                MessageBox.Show($"Cleanup complete!\n\nRemoved {fileCount} files and {dirCount} directories from the temporary folder.",
                                "Cleanup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cleaning temporary files: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
