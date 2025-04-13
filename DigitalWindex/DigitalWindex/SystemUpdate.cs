using System.Diagnostics;


namespace DigitalWindex.Backend
{
    public static class SystemUpdate
    {

        private static IProcessRunner _processRunner = new ProcessRunner();

        public static void SetProcessRunner(IProcessRunner processRunner)
        {
            _processRunner = processRunner;
        }

        //private static ILogger _logger = new RealLogger();

        //public static void SetLogger(ILogger logger)
        //{
        //    _logger = logger;
        //}

        public static void RunSystemUpdate()
        {
            ProcessStartInfo psiSystemUpdate = new ProcessStartInfo("ms-settings:windowsupdate-action")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            _processRunner.Start(psiSystemUpdate);

            LOG.WriteLog();
        }
    }
}
