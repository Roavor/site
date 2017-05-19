using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of prossesors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Versoin: {0}", Environment.Version);
        }
        static int Main(string[] args)
        {
            Console.WriteLine("***My first App");
            Console.WriteLine("Hello World");
            foreach (string arg in args)
                Console.WriteLine("Arg: {0}",args);
            ShowEnvironmentDetails();
            Console.ReadLine();

            return -1;
        }
    }
}
