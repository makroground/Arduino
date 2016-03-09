using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDCC_StartupHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var process = Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"Serial_LEDStrip_Communication.exe", "startintray");

                process.WaitForExit();

                var exitCode = process.ExitCode;
            } catch
            {
                Console.WriteLine("Das System kann die erforderlichen Dateien nicht finden: " + AppDomain.CurrentDomain.BaseDirectory + @"Serial_LEDStrip_Communication.exe");
            }
            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            //Console.Read();
        }
    }
}
