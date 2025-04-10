using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWindex.Backend
{
    public static class LOG
    {

        private static readonly string logFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
            "DigitalWindexLog.txt"
        );

        public static void CreateLog()
        {
            //get the path to where the file will be made
            File.Create(logFilePath);
        }

        public static void OpenLog()
        {
            var systemPath = System.Environment.GetFolderPath(
                                 Environment.SpecialFolder.CommonApplicationData
                             );
            var targetPath = Path.Combine(systemPath, "DigitalWindexLog");

            ProcessStartInfo psiOpenLog = new ProcessStartInfo("notepad.exe", logFilePath)
            {
                UseShellExecute = true,
            };
            Process.Start(psiOpenLog);
        }

        public static void WriteLog()
        {

            StreamWriter textWriter = new StreamWriter(logFilePath, append: true);

            if ((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name == "RunDriverUpdate")
            {
                using (textWriter)
                {
                    textWriter.WriteLine($"- {DateTime.Now}: Ran Driver Update Function");
                }
            }else if ((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name == "RunSystemUpdate")
            {
                using (textWriter)
                {
                    textWriter.WriteLine($"- {DateTime.Now}: Ran System Update Function");
                }
            }
            else if ((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name == "BtnRunCleanup_Click")
            {
                using (textWriter)
                {
                    textWriter.WriteLine($"- {DateTime.Now}: Ran DISM Cleanup");
                }
            }
            else if ((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name == "RunAllDiagnostics")
            {
                using (textWriter)
                {
                    textWriter.WriteLine($"- {DateTime.Now}: Ran Diagnostics");
                }
            }
            else if ((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name == "BtnStartInstall_Click")
            {
                using (textWriter)
                {
                    textWriter.WriteLine($"- {DateTime.Now}: Opened Recovery Settings");
                }
            }
            else if ((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name == "BtnScanMalware_Click")
            {
                using (textWriter)
                {
                    textWriter.WriteLine($"- {DateTime.Now}: Scanned for Malware");
                }
            }
            else if ((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name == "BtnCleanTempFiles_Click")
            {
                using (textWriter)
                {
                    textWriter.WriteLine($"- {DateTime.Now}: Cleaned Temporary Files");
                }
            }
        }

        public static bool LogFileExists()
        {
            return File.Exists(logFilePath);
        }





    }
}
