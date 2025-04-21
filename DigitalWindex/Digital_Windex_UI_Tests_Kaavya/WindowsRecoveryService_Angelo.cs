using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Windex_UI_Tests_Kaavya
{
    public class WindowsRecoveryService_Angelo
    {
        private readonly IProcessRunner_Angelo _runner;
        public WindowsRecoveryService_Angelo(IProcessRunner_Angelo runner) => _runner = runner;

        public Task LaunchRecoveryAsync()
          => _runner.Run("ms-settings:recovery", "");
    }

}
