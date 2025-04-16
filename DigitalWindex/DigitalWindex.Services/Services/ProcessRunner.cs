using System.Diagnostics;
using System.Threading.Tasks;

namespace DigitalWindex.Services
{
    public class ProcessRunner : IProcessRunner
    {
        public Task<int> Run(string fileName, string arguments)
        {
            return Task.Run(() =>
            {
                var psi = new ProcessStartInfo(fileName, arguments)
                {
                    UseShellExecute = true,
                    Verb = "runas"
                };
                using (var p = Process.Start(psi))
                {
                    p.WaitForExit();
                    return p.ExitCode;
                }
            });
        }
    }
}
