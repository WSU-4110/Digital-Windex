/*
using System;
using System.Diagnostics;
using System.IO;

namespace SystemDiagnostics
{
    class Program
    {
        static void ExecuteCommand(string command)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = psi })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(output))
                        Console.WriteLine("Output: " + output);
                    if (!string.IsNullOrEmpty(error))
                        Console.WriteLine("Error: " + error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Command Execution Error: " + ex.Message);
                File.WriteAllText("error_log.txt", "Command Execution Error: " + ex.ToString());
            }
        }

        static void CheckCPUStatus()
        {
            Console.WriteLine("Checking CPU Status...");
            ExecuteCommand("powershell -Command \"Get-CimInstance Win32_Processor | Select-Object Name, LoadPercentage\"");
        }

        static void RunMemoryDiagnostics()
        {
            Console.WriteLine("Scheduling Windows Memory Diagnostics...");
            ExecuteCommand("bcdedit /set {current} badmemoryaccess yes");
        }

        static void RestartComputer()
        {
            Console.WriteLine("Press any key to restart the system in 10 seconds...");
            Console.ReadKey();
            ExecuteCommand("shutdown /r /t 10");
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting System Diagnostics...");

                CheckCPUStatus();

                RunMemoryDiagnostics();

                RestartComputer();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fatal Error: " + ex.Message);
                File.WriteAllText("error_log.txt", "Fatal Error: " + ex.ToString());
            }
        }
    }
}
*/

using System;
using System.Diagnostics;
using System.IO;

namespace SystemDiagnostics
{
    public class DiagnosticRunner
    {
        private static void ExecuteCommand(string command)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = psi })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(output))
                        Console.WriteLine("Output: " + output);
                    if (!string.IsNullOrEmpty(error))
                        Console.WriteLine("Error: " + error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Command Execution Error: " + ex.Message);
                File.WriteAllText("error_log.txt", "Command Execution Error: " + ex.ToString());
            }
        }

        public static void CheckCPUStatus()
        {
            ExecuteCommand("powershell -Command \"Get-CimInstance Win32_Processor | Select-Object Name, LoadPercentage\"");
        }

        public static void RunMemoryDiagnostics()
        {
            ExecuteCommand("bcdedit /set {current} badmemoryaccess yes");
        }

        public static void RestartComputer()
        {
            ExecuteCommand("shutdown /r /t 10");
        }

        public static void RunAllDiagnostics()
        {
            CheckCPUStatus();
            RunMemoryDiagnostics();
            RestartComputer();
        }
    }
}
