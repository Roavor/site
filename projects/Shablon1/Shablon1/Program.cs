using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon1
{
    class Program
    {
        static double Input(string S)
        {
            Console.WriteLine(S);
            double n = 0;
            try
            {
                n = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("error");
            }
            return n;
        }
        static void Main(string[] args)
        {
        }
    }
}
