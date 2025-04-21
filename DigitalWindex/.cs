using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindex.Backend
{

    public interface IProcessRunner
    {
        void Start(ProcessStartInfo startInfo);
    }

    public class ProcessRunner : IProcessRunner
    {
        public void Start(ProcessStartInfo startInfo)
        {
            Process.Start(startInfo);
        }
    }


    public static class DriverUpdate
    {

        private static IProcessRunner _processRunner = new ProcessRunner();

        public static void SetProcessRunner(IProcessRunner processRunner)
        {
            _processRunner = processRunner;
        }

        public static void RunDriverUpdate()
        {
            ProcessStartInfo psiDriverUpdate = new ProcessStartInfo("devmgmt.msc")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            _processRunner.Start(psiDriverUpdate);

            LOG.WriteLog();
        }

    }
}