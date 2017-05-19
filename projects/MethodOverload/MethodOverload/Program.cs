using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10,10));
            Console.WriteLine(Add(9000000000000,90000000000000));
            Console.WriteLine(Add(4.3,4.4));
            Console.ReadKey();
        }
        static int Add(int x, int y)
        { return x + y; }
        static double Add(double x,double y)
        { return x + y; }
        static long Add(long x,long y)
        { return x + y; }
    }
}
