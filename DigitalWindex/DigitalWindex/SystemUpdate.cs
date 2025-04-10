using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindex.Backend
{
    internal class SystemUpdate
    {

        public static void RunSystemUpdate()
        {
            ProcessStartInfo psiSystemUpdate = new ProcessStartInfo("ms-settings:windowsupdate-action")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(psiSystemUpdate);

            LOG.WriteLog();
        }
    }
}
