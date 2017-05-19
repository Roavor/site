using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DataBigInteger
{
    class Program
    {

        static void UseBigInteger()
        {
            BigInteger biggy = BigInteger.Parse("99999999999999999999999");
            Console.WriteLine("Value of biggy is {0}",biggy);
            Console.WriteLine("Is biggy an even value?: {0}",biggy.IsEven);
            Console.WriteLine("Is biggy a powerof two?: {0}",biggy.IsPowerOfTwo);
            BigInteger reallyBig=BigInteger.Multiply(biggy,BigInteger.Parse("88888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}",reallyBig);
           
        }
        static void Main(string[] args)
        {
            UseBigInteger();
            Console.ReadKey();
        }
    }
}
