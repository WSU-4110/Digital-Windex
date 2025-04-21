using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Windex_UI_Tests_Kaavya
{
    public class ProcessRunner_Angelo : IProcessRunner_Angelo
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
