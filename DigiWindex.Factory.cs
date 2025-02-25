using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

//Product Interface
public interface Task_ProductInterface
{
    String startdir;
    //function to run command applies to all tasks
    public void RunCommandDirectly(string startdir, string arguments)
    {
           ProcessStartInfo processInfo = new ProcessStartInfo
           {
               FileName = startdir,
               Arguments = arguments,
               UseShellExecute = true,
               Verb = "runas",
               WorkingDirectory = Environment.SystemDirectory,
               CreateNoWindow = false
           };

           int exitCode = -1;
           using (Process process = Process.Start(processInfo))
           {
               process.WaitForExit();
               exitCode = process.ExitCode;
           }
           return exitCode;
    }

    //each task will have a starting directory and a 
}

//Concrete Creators
abstract class abstract class TaskNoWarnings_Concrete_Creator
{
    public abstract Task_ProductInterface createTask(string startdir, string arguments)
    {
        startdir = Path.Combine(Environment.SystemDirectory, startdir);
    }
}Concrete_Creator
{
    public abstract Task_ProductInterface createTaskNoWarnings(string startdir, string arguments)
    {
        startdir = Path.Combine(Environment.SystemDirectory, startdir);
    }
}

abstract class TaskYesWarnings_Concrete_Creator
{
    public abstract Task_ProductInterface createTaskYesWarnings(string startdir, string arguments)
    {
        startdir = Path.Combine(Environment.SystemDirectory, startdir);
    }
}

//Concrete Products
public class TaskNoWarnings : Task_ProductInterface
{
    public void RunCommandDirectly(string startdir, string arguments)
    {
        Console.WriteLine("Running Task in" + startdir)
    }
}

public class TaskYesWarnings : Task_ProductInterface
{
    String warning;
    String boxText;
    DialogResult dialogResult = MessageBox.Show(
                warning,
                boxText,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
    int driverUpdateExitCode = await RunCommandDirectly(string startdir, string arguments);

    MessageBox.Show("redirection completed with exit code: " + sysUpdateExitCode,
                                    "Redirection Completed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
}

//Factory Interface
public interface TaskFactory
{
    Task_ProductInterface createTask(string startDir, string arguments);
}
