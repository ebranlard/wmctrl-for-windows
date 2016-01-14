// Note: to compile with Mono you need:  mcs /r:System.Windows.Forms.dll 
// 
// 
using System; // For IntPtr
using System.Runtime.InteropServices; // DllImport
using System.Diagnostics; // Process
using System.Collections;
using System.Collections.Generic; // List<string>
using System.Windows.Forms; // SendKeys
// using System.Threading; // For Thread.Sleep

class Program
{
    //dll import (can't be in method, but needs to be in class
    [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr point);
    static void Main()
    {
        // --------------------------------------------------------------------------------
        // ---  
        // --------------------------------------------------------------------------------
        Process p = Process.Start("notepad.exe");
        p.WaitForInputIdle();
        IntPtr h = p.MainWindowHandle;
        SetForegroundWindow(h);
        SendKeys.SendWait("k");
//         Thread.Sleep(1000);
        IntPtr processFoundWindow = p.MainWindowHandle;
    }
}
