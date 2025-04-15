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
            var confirm = MessageBox.Show("Are you sure you want to delete all temporary files?\nThis action cannot be undone.",
                                          "Confirm Cleanup", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                btnCleanTempFiles.Enabled = false;
                btnCleanTempFiles.Text = "Cleaning...";

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
                    catch { /* Ignore access denied/in-use files */ }
                }

                foreach (string dir in Directory.GetDirectories(tempPath))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        dirCount++;
                    }
                    catch { /* Ignore access denied/in-use dirs */ }
                }

                MessageBox.Show($"Cleanup complete!\n\nRemoved {fileCount} files and {dirCount} directories from the temporary folder.",
                                "Cleanup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cleaning temporary files: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCleanTempFiles.Text = "Clean Temporary Files";
                btnCleanTempFiles.Enabled = true;
            }
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {


        }
    }
}
