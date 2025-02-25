// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
public interface ICommand
{
    void Execute();
}

public class DISMRunner
{
    public void RunDISM()
    {
        Console.WriteLine("Executing DISM Cleanup...");
        try
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c dism /Online /Cleanup-Image /RestoreHealth")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = Process.Start(processInfo);
            process.WaitForExit();

            Console.WriteLine("DISM executed successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"DISM execution failed! Error: {e.Message}");
        }
    }
}

public class RunDISMCommand : ICommand
{
    private readonly DISMRunner _receiver;

    public RunDISMCommand(DISMRunner receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.RunDISM();
    }
}

public class Invoker
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        if (_command != null)
        {
            _command.Execute();
        }
        else
        {
            Console.WriteLine("No command set!");
        }
    }
}

class Program
{
    static void Main()
    {
        DISMRunner dismRunner = new DISMRunner();

        ICommand dismCommand = new RunDISMCommand(dismRunner);

        Invoker invoker = new Invoker();
        invoker.SetCommand(dismCommand);

        Console.WriteLine("User clicks 'Run DISM' button.");
        invoker.ExecuteCommand();
    }
}
;