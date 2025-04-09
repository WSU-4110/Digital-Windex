using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindex.Backend
{
    public static class DriverUpdate
    {

        public static void RunDriverUpdate()
        {
            ProcessStartInfo psiDriverUpdate = new ProcessStartInfo("devmgmt.msc")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(psiDriverUpdate);
        }

    }
}
