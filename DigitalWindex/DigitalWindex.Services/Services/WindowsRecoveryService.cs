using DigitalWindex.Services;
using System.Threading.Tasks;

namespace DigitalWindex.Services
{
    public class WindowsRecoveryService
    {
        private readonly IProcessRunner _runner;
        public WindowsRecoveryService(IProcessRunner runner) => _runner = runner;

        public Task LaunchRecoveryAsync()
          => _runner.Run("ms-settings:recovery", "");
    }
}
