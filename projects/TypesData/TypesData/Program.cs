using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesData
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime c = new DateTime();
            Console.WriteLine("{0},{1},{2},{3}/t",b,i,d,c);
            Console.ReadKey();
        }
    }
}
