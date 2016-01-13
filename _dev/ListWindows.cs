using System.IO;
using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        Process[] processlist = Process.GetProcesses();
        foreach (Process process in processlist)
        {
            if (!String.IsNullOrEmpty(process.MainWindowTitle))
            {
                Console.WriteLine("Process: {0} ID: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle);
            }
        }
    }
}
