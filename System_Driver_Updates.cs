// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

//no task version
//string SFCtext;
//SFCtext = "cmd /c sfc /scannow";
//Process sfcProcess = new Process();
//sfcProcess.StartInfo.FileName = "cmd.exe";
//sfcProcess.StartInfo.Arguments = SFCtext;
//
//
//string dismtext;
//dismtext = "cmd /c DISM /online /cleanup-image /scanhealth";
//Process dismProcess = new Process();
//dismProcess.StartInfo.FileName = "cmd.exe";
//dismProcess.StartInfo.Arguments = dismtext;
//
//sfcProcess.Start();
//sfcProcess.WaitForExit();
//dismProcess.Start();

//snatch for updates

string updateSysText;
updateSysText = "start ms-settings:windowsupdate-action";
Process updateSysProcess = new Process();
updateSysProcess.StartInfo.FileName = "powershell.exe";
updateSysProcess.StartInfo.Arguments = updateSysText;

string updateDriv1Text;
updateDriv1Text = "devmgmt.msc";
Process updateDriv1Process = new Process();
updateDriv1Process.StartInfo.FileName = "powershell.exe";
updateDriv1Process.StartInfo.Arguments = updateDriv1Text;

//updateSysProcess.Start();
updateDriv1Process.Start();