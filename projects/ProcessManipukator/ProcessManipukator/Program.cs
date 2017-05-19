using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessManipukator
{
    class Program
    {
        static void ListAllRunningProcesses()
        {
            var runningProcesses = from prog in Process.GetProcesses(".") orderby prog.Id select prog;
            foreach (var p in runningProcesses  )
            {
                string info = string.Format("PID: {0}\tName: {1}",p.Id, p.ProcessName);
                Console.WriteLine(info);
            }
        }
        static void StartAndKillProcess()
        {
            Process ieProc = null;
            try
            {
                ieProc = Process.Start("Chrome.exe","www.vk.com");
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine(ex.Message);
                
            }
            Console.WriteLine("Enter");
            Console.ReadLine();
            try
            {
                ieProc.Kill();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            StartAndKillProcess();
            Console.ReadKey();
        }
    }
}
