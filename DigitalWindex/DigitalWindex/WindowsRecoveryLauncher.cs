using System.Diagnostics;

namespace DigitalWindex.Backend
{
    public static class WindowsRecoveryLauncher
    {
        /// <summary>
        /// Opens the Windows 10 and 11 "System -> Recovery" Settings page.
        /// </summary>
        public static void OpenRecoverySettings()
        {
            ProcessStartInfo psi = new ProcessStartInfo("ms-settings:recovery")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(psi);
        }
    }
}
