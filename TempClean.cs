using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindex.Backend
{
    // command interface
    public interface ICleanupCommand
    {
        int Execute();
    }

    // concrete command for cleaning temp files
    public class TempFileCleanupCommand : ICleanupCommand
    {
        private readonly string[] tempFolders =
        {
            Path.GetTempPath(),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft\\Windows\\INetCache"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp")
        };

        public int Execute()
        {
            int deletedCount = 0;
            foreach (var folder in tempFolders)
            {
                try
                {
                    if (Directory.Exists(folder))
                    {
                        var files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
                        foreach (var file in files)
                        {
                            try
                            {
                                File.SetAttributes(file, FileAttributes.Normal);
                                File.Delete(file);
                                deletedCount++;
                            }
                            catch { }
                        }
                    }
                }
                catch { }
            }
            return deletedCount;
        }
    }

    // invoker class to execute cmds
    public class CleanupInvoker
    {
        private readonly List<ICleanupCommand> _commands = new List<ICleanupCommand>();

        public void AddCommand(ICleanupCommand command)
        {
            _commands.Add(command);
        }

        public int ExecuteAll()
        {
            int totalDeleted = 0;
            foreach (var command in _commands)
            {
                totalDeleted += command.Execute();
            }
            return totalDeleted;
        }
    }

    public class TempFileCleaner
    {
        public static async Task RunTempCleanup()
        {
            DialogResult dialogResult = MessageBox.Show(
                "This will delete temporary files from your system. Do you want to continue?",
                "Temporary File Cleanup",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    CleanupInvoker invoker = new CleanupInvoker();
                    invoker.AddCommand(new TempFileCleanupCommand());

                    int filesDeleted = await Task.Run(() => invoker.ExecuteAll());

                    MessageBox.Show($"Cleanup completed! {filesDeleted} files deleted.",
                                    "Cleanup Successful",
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
    }
}
