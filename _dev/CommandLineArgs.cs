using System;

public class CommandLine
{
    public static int SwitchToWindow(){
        Console.WriteLine("SwitchToWindow");
        return 0;
    }
    
    public static int ListWindows(){
        Console.WriteLine("ListWindows");
        return 0;
    }


    public static int Main(string[] args)
    {
        int status=0; // Return status for Main

        // --------------------------------------------------------------------------------
        // --- Parsing arguments 
        // --------------------------------------------------------------------------------
        int nArgs=args.Length;
        Console.WriteLine("Number of command line parameters = {0}", args.Length);

        int i=0;
        while (i<nArgs) {
            string s=args[i];
            switch(s){
                case "-s":
                    Console.WriteLine("s");
                    status=SwitchToWindow();
                    break;
                case "-l":
                    Console.WriteLine("l");
                    status=ListWindows();
                    
                    Console.WriteLine("Error:");
                    status=-1;
                    break;
                default:
                    Console.WriteLine(args[i]);
                    break;
            }
            i++;
            if (status!=0) {
                break;
            }
        }
        //
        return status;
    }



}
