using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_222222
{
    class Program
    {
        static double Input(string S)
        {
            int a = 0;
            Console.WriteLine(S);
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "False data");
            }
            return a;
        }
        static double z1(double a)
        {
            return (Math.Sin(3.0 / 8.0 * Math.PI - a / 4.0) - Math.Sin(11.0 / 8.0 * Math.PI + a / 4.0));
        }
        static double z2(double a)
        {
            return (((a + 2) / Math.Sqrt(2.0 * a) - a / (Math.Sqrt(2.0 * a) + 2.0) + 2.0 / (a - Math.Sqrt(2.0 * a))) * (Math.Sqrt(a) - Math.Sqrt(2.0)) / (a + 2.0));
        }
        static void Main(string[] args)
        {
            double a = Input("Input a");

            Console.WriteLine(z1(a));
            Console.WriteLine(z2(a));

        }
    }
}

