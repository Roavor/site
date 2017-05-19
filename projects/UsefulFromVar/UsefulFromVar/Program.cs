using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulFromVar
{
    class Program
    {
        static void LinqOueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //
            var subset = from i in numbers where 1 < 10 select 1;
            Console.WriteLine("Values in subset");
            foreach(var i in subset)
            {
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine();
            //
            Console.WriteLine("subset is a: {0}",subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
        static void Main(string[] args)
        {
            LinqOueryOverInts();
            Console.ReadKey();
        }
    }
}
