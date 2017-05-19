using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeFunctionolity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maxof int:{0}",int.MaxValue);
            Console.WriteLine("Maxof int:{0}", int.MinValue);
            Console.WriteLine("Maxof of double: {0}", double.MaxValue);
            Console.WriteLine("Maxof of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.PositiveInfinity: {0}", double.NegativeInfinity);
            Console.ReadKey();
        }
    }
}
