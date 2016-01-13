//declarations
using system.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
//more

//namespace here

//class here

//initialize method

class Program
{
    static void Main()
    {
        //related .dll import
        [DllImport("user32.dll")]
            public static extern void SwitchToThisWindow(IntPtr hWnd);

        String ProcWindow = "main";
        //function which calls switchWindow() is here but not important

        Process[] procs = Process.GetProcessesByName(ProcWindow);
        foreach (Process proc in procs)
        {
            //switch to process by name
            SwitchToThisWindow(proc.MainWindowHandle);

            Console.WriteLine("Process: {0} ID: {1} Window title: {2}", proc.ProcessName, proc.Id, proc.MainWindowTitle);
        }
    }
}
}


// --------------------------------------------------------------------------------
// ---  
// --------------------------------------------------------------------------------
http://stackoverflow.com/questions/2315561/correct-way-in-net-to-switch-the-focus-to-another-application
// --------------------------------------------------------------------------------
// --- 
// --------------------------------------------------------------------------------
AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
if (element != null)
{
    element.SetFocus();
}
