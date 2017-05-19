using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotNecessoriParametrs
{
    class Program
    {
        static void EnterLogData(string message,string owner="Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}",message);
            Console.WriteLine("Owner of Error: {0}",owner);
        }
        static void Main(string[] args)
        {
            EnterLogData("Oh no!Grid can't find data");
            EnterLogData("Oh no!Grid can't find the payroll data", "CFO");
            Console.ReadKey();
        }
    }
}
